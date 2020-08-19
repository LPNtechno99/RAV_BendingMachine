using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FASTECH;
using Advantech.Adam;
using Advantech.Common;
using System.Threading;

namespace Control_3_Axis_Ezi_Step_Plus_R
{
    public partial class fmMain : DevExpress.XtraEditors.XtraForm
    {
        Thread _Show_Coordinate;
        float[] _arrMeasureValueTemplate = new float[24];

        uint dwAxisStatus = 0;

        readonly GroupControl[] arr_grp_x_y = new GroupControl[24];
        readonly TextBox[] arr_txt_x = new TextBox[24];
        readonly TextBox[] arr_txt_y = new TextBox[24];

        int grb_co = 1;
        int txt_co = 0;

        public fmMain()
        {
            InitializeComponent();
            //VarGlobal.Instance().node_item_x = new EziMOTIONPlusRLib.ITEM_NODE();
            //VarGlobal.Instance().node_item_y = new EziMOTIONPlusRLib.ITEM_NODE();
            foreach (GroupControl grp in grbPointCoordinate.Controls.OfType<GroupControl>())
            {
                grp.Name = "grPoint" + grb_co;
                grp.Text = "Point " + grb_co;
                arr_grp_x_y[grb_co - 1] = grp;
                grb_co += 1;
            }
            for (int i = 0; i < 24; i++)
            {
                foreach (TextBox txt in arr_grp_x_y[i].Controls.OfType<TextBox>())
                {
                    if (txt_co % 2 == 0) arr_txt_y[i] = txt;
                    if (txt_co % 2 != 0) arr_txt_x[i] = txt;
                    txt_co += 1;
                }
                txt_co = 0;
            }

        }
        void ShowCoordinate()
        {
            if (VarGlobal.m_Connected)
            {
                try
                {
                    while (true)
                    {
                        int nRtn_1 = EziMOTIONPlusRLib.FAS_GetCommandPos(VarGlobal.PortNo, 1, ref Calculate.CommandPosX);
                        if (nRtn_1 != EziMOTIONPlusRLib.FMM_OK)
                        {
                            string strmsg;
                            strmsg = "FAS_GetActualPos() \nreturned: " + nRtn_1.ToString();
                            MessageBox.Show(strmsg, "function failed");
                        }
                        int nRtn_2 = EziMOTIONPlusRLib.FAS_GetCommandPos(VarGlobal.PortNo, 2, ref Calculate.CommandPosY);
                        if (nRtn_2 != EziMOTIONPlusRLib.FMM_OK)
                        {
                            string strmsg;
                            strmsg = "FAS_GetActualPos() \nreturned: " + nRtn_2.ToString();
                            MessageBox.Show(strmsg, "function failed");
                        }
                        int nRtn_3 = EziMOTIONPlusRLib.FAS_GetCommandPos(VarGlobal.PortNo, 3, ref Calculate.CommandPosZ);
                        if (nRtn_3 != EziMOTIONPlusRLib.FMM_OK)
                        {
                            string strmsg;
                            strmsg = "FAS_GetActualPos() \nreturned: " + nRtn_3.ToString();
                            MessageBox.Show(strmsg, "function failed");
                        }
                        if (nRtn_1 != EziMOTIONPlusRLib.FMM_OK || nRtn_2 != EziMOTIONPlusRLib.FMM_OK || nRtn_3!=EziMOTIONPlusRLib.FMM_OK)
                        {
                            return;
                        }

                        VarGlobal.position_mm_x = Calculate.Calculate_Coordinate_mm(Calculate.CommandPosX, Calculate.STEP_X);
                        VarGlobal.position_mm_y = Calculate.Calculate_Coordinate_mm(Calculate.CommandPosY, Calculate.STEP_Y);
                        VarGlobal.position_mm_z = Calculate.Calculate_Coordinate_mm(Calculate.CommandPosZ, Calculate.STEP_Z);

                        //Invoke(new MethodInvoker(delegate
                        //{
                        bsiPosX.Caption = VarGlobal.position_mm_x.ToString("0.0000");
                        bsiPosY.Caption = VarGlobal.position_mm_y.ToString("0.0000");
                        bsiPosZ.Caption = VarGlobal.position_mm_z.ToString("0.0000");
                        //bsiMeasurement.Caption = VarGlobal.measurementvalue.ToString("0.0000");
                        //}));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Not Connected");
            }

        }
        private void btnConnect_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fmConnect frm = new fmConnect();
            frm.SuccessConnect += Frm_SuccessConnect;
            frm.Show();
        }
        /// <summary>
        /// Get Position Actual
        /// </summary>

        private void Frm_SuccessConnect(fmConnect.CheckConnection e)
        {
            switch (e)
            {
                case fmConnect.CheckConnection.success:

                    if (VarGlobal._3AxisReady >= 3)
                    {
                        bsiX.Caption = "X Axis Ready";
                        bsiY.Caption = "Y Axis Ready";
                        bsiZ.Caption = "Z Axis Ready";

                        _Show_Coordinate = new Thread(ShowCoordinate);
                        _Show_Coordinate.IsBackground = true;
                        _Show_Coordinate.Start();

                        //VarGlobal.Instance().Move_All_Axis_Origin();
                        //VarGlobal.Instance().Move_Z_Axis_Abs_Pos(Coordinates.Zcoordinate.Instance().z_coor[0]);
                    }

                    break;
                case fmConnect.CheckConnection.fail:
                    MessageBox.Show("Error Connect!");
                    break;
                default:
                    break;
            }
            //connect adam
            try
            {
                VarGlobal.Adam_iAddr = 1;
                VarGlobal.adamCom = new AdamCom(VarGlobal.AdamCOM)
                {
                    Checksum = false
                };
                if (VarGlobal.adamCom.OpenComPort())
                {
                    // set COM port state, 9600,N,8,1
                    VarGlobal.adamCom.SetComPortState(Baudrate.Baud_9600, Databits.Eight, Parity.None, Stopbits.One);
                    // set COM port timeout
                    VarGlobal.adamCom.SetComPortTimeout(500, 500, 0, 500, 0);

                    if (!VarGlobal.adamCom.Configuration(VarGlobal.Adam_iAddr).GetModuleConfig(out VarGlobal.adamConfig))
                    {
                        VarGlobal.adamCom.CloseComPort();
                        MessageBox.Show("Failed to get module config!", "Error");
                        return;
                    }
                    bsiAdam.Caption = "Connected Adam";
                    VarGlobal.adam_Connected = true;
                }
                else
                    MessageBox.Show("Failed to open COM port!", "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSetSpeedJOG_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fmSpeedJOG frm = new fmSpeedJOG();
            frm.Show();
        }

        private void btnSettingPosition_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!VarGlobal.Instance().Move_Z_Axis_Abs_Pos(Coordinates.Zcoordinate.Instance().z_coor[0]))
                return;
            VarGlobal.SELECT_FORM_SETTING = 1;
            fmSettingPointsPosition frm = new fmSettingPointsPosition();
            frm.Show();
        }

        private void btnReadfromROM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (VarGlobal.m_Connected)
            {
                for (ushort point = 1; point <= 24; point++)
                {
                    //int nRtn_1 = EziMOTIONPlusRLib.FAS_PosTableReadItem(VarGlobal.PortNo, 1, i, ref VarGlobal.Instance().node_item_x);
                    //int nRtn_2 = EziMOTIONPlusRLib.FAS_PosTableReadItem(VarGlobal.PortNo, 2, i, ref VarGlobal.Instance().node_item_y);

                    //if (nRtn_1 != EziMOTIONPlusRLib.FMM_OK || nRtn_2 != EziMOTIONPlusRLib.FMM_OK)
                    //{
                    //    string strMsg;
                    //    strMsg = "FAS_PosTableReadItem() \nReturned: " + nRtn_1.ToString() + "And" + nRtn_2.ToString();
                    //    MessageBox.Show(strMsg, "Function Failed");
                    //}
                    //Coordinates.Xcoordinate.Instance().x_coor[i] = VarGlobal.Instance().node_item_x.lPosition;
                    //Coordinates.Ycoordinate.Instance().y_coor[i] = VarGlobal.Instance().node_item_y.lPosition;

                    _arr = SQLite.Instance().GetPointsCoordinate("T24DefaultPointMeasurement",
                     point, "Xcoor", "Ycoor", "Zcoor");
                    Coordinates.Xcoordinate.Instance().x_coor[point - 1] = Calculate.Calculate_Coordinate_pulse(
                        float.Parse(_arr[0]), Calculate.STEP_X);
                    Coordinates.Ycoordinate.Instance().y_coor[point - 1] = Calculate.Calculate_Coordinate_pulse(
                        float.Parse(_arr[1]), Calculate.STEP_Y);
                    Coordinates.Zcoordinate.Instance().z_coor[point - 1] = Calculate.Calculate_Coordinate_pulse(
                        float.Parse(_arr[2]), Calculate.STEP_Z);

                    arr_txt_x[point - 1].Text = _arr[0];
                    arr_txt_y[point - 1].Text = _arr[1];
                }
            }
            else
            {
                MessageBox.Show("Not connect");
            }
        }

        private void btnWritetoROM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (VarGlobal.m_Connected)
            {
                int ntRn_3 = EziMOTIONPlusRLib.FAS_PosTableWriteROM(VarGlobal.PortNo, 1);
                int ntRn_4 = EziMOTIONPlusRLib.FAS_PosTableWriteROM(VarGlobal.PortNo, 2);

                if (ntRn_3 != EziMOTIONPlusRLib.FMM_OK || ntRn_4 != EziMOTIONPlusRLib.FMM_OK)
                {
                    string strMsg;
                    strMsg = "FAS_PosTableWriteROM() \nReturned: " + ntRn_3.ToString() + "And" + ntRn_4.ToString();
                    MessageBox.Show(strMsg, "Function Failed");
                }

                MessageBox.Show("Write Success!");
            }
            else
            {
                MessageBox.Show("Not connect");
            }
        }

        private void btnMoveOrigin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Calculate.CommandPosX < 0 || Calculate.CommandPosY < 0 || Calculate.CommandPosZ < 0)
            {
                VarGlobal.Instance().All_Move_Stop();
                return;
            }
            VarGlobal.Instance().Move_All_Axis_Origin();
        }

        private void btnResetAlarm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (VarGlobal.m_Connected == false)
                return;
            else
            {
                for (byte i = 1; i <= 3; i++)
                {
                    if (EziMOTIONPlusRLib.FAS_IsSlaveExist(VarGlobal.PortNo, i) != 0)
                    {
                        int nRnt_1 = EziMOTIONPlusRLib.FAS_GetAxisStatus(VarGlobal.PortNo, i, ref dwAxisStatus);
                        if (nRnt_1 != EziMOTIONPlusRLib.FMM_OK)
                        {
                            string strMsg;
                            strMsg = "FAS_GetAxisStatus() \nReturned: " + nRnt_1.ToString();
                            MessageBox.Show(strMsg, "Function Failed");
                        }
                        if ((dwAxisStatus & 0x00000001) != 0) //FFLAG_ERRORALL is ON
                        {
                            int nRtn = EziMOTIONPlusRLib.FAS_StepAlarmReset(VarGlobal.PortNo, i, 1);
                            if (nRtn != EziMOTIONPlusRLib.FMM_OK)
                            {
                                string strMsg;
                                strMsg = "FAS_ServoAlarmReset() \nReturned: " + nRtn.ToString();
                                MessageBox.Show(strMsg, "Function Failed");
                            }
                        }

                    }
                }
            }
        }

        private void btnGetTemplateAuto_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Template.GetTemplate frm = new Template.GetTemplate();
            frm.GetDoneTemp += Frm_GetDoneTemp;
            lviTempMeasurement.Items.Clear();
            frm.ShowDialog();
        }

        private void Frm_GetDoneTemp(int point, float height)
        {
            ListViewItem lvi = new ListViewItem("Point " + point);
            lvi.SubItems.Add(height.ToString("0.0000") + " mm");
            lviTempMeasurement.Items.Add(lvi);
        }

        string[] _arr = new string[3];
        private void fmMain_Load(object sender, EventArgs e)
        {
            uint[] arr = SQLite.Instance().GetSpeedJOG();
            VarGlobal.speedJOG_X = arr[0];
            VarGlobal.speedJOG_Y = arr[1];
            VarGlobal.speedJOG_Z = arr[2];

            try
            {
                for (int point = 1; point < 25; point++)
                {
                    _arr = SQLite.Instance().GetPointsCoordinate("T24DefaultPointMeasurement",
                      point, "Xcoor", "Ycoor", "Zcoor");
                    Coordinates.Xcoordinate.Instance().x_coor[point - 1] = Calculate.Calculate_Coordinate_pulse(
                        float.Parse(_arr[0]), Calculate.STEP_X);
                    Coordinates.Ycoordinate.Instance().y_coor[point - 1] = Calculate.Calculate_Coordinate_pulse(
                        float.Parse(_arr[1]), Calculate.STEP_Y);
                    Coordinates.Zcoordinate.Instance().z_coor[point - 1] = Calculate.Calculate_Coordinate_pulse(
                        float.Parse(_arr[2]), Calculate.STEP_Z);

                    _arrMeasureValueTemplate[point - 1] = float.Parse(SQLite.Instance().GetMeasureValueTemplate
                    ("MeasureValueTemplate", "Value", point));
                    ListViewItem lvi = new ListViewItem("Point " + point);
                    lvi.SubItems.Add(_arrMeasureValueTemplate[point - 1].ToString("0.0000"));
                    lviTempMeasurement.Items.Add(lvi);

                    arr_txt_x[point-1].Text = _arr[0];
                    arr_txt_y[point-1].Text = _arr[1];
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Thread.Sleep(500);
            for (byte i = 0; i < EziMOTIONPlusRLib.MAX_SLAVE_NUMS; i++)
            {
                if (EziMOTIONPlusRLib.FAS_IsSlaveExist(VarGlobal.PortNo, i) != 0)
                {
                    int nRtn = EziMOTIONPlusRLib.FAS_ServoEnable(VarGlobal.PortNo, i, 0);
                    if (nRtn != EziMOTIONPlusRLib.FMM_OK)
                    {
                        string strMsg;
                        strMsg = "FAS_ServoEnable() \nReturned: " + nRtn.ToString();
                        MessageBox.Show(strMsg, "Function Failed");
                    }
                }
            }
        }

        private void fmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (VarGlobal.m_Connected)
                EziMOTIONPlusRLib.FAS_Close(VarGlobal.PortNo);
            if (VarGlobal.adam_Connected)
                VarGlobal.adamCom.CloseComPort();
        }

        private void btnStartMotion_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //FormMotion.fmStartMotion frm = new FormMotion.fmStartMotion();
            //frm.ShowDialog();

            FormMotion.fmMotionGraphics frm = new FormMotion.fmMotionGraphics();
            frm.Show();
        }

        private void btnTestGraphics_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fmTestGraphics frm = new fmTestGraphics();
            frm.Show();
        }

        private void btnDisconnect_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EziMOTIONPlusRLib.FAS_Close(VarGlobal.PortNo);
            VarGlobal.adamCom.CloseComPort();
            VarGlobal.Reset();
            bsiX.Caption = "...";
            bsiY.Caption = "...";
            bsiZ.Caption = "...";

            bsiPosX.Caption = "---";
            bsiPosY.Caption = "---";
            bsiPosZ.Caption = "---";
            bsiMeasurement.Caption = "---";
            bsiAdam.Caption = "---";
        }

        private void btnBoardList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormView.fmBoardList frm = new FormView.fmBoardList();
            frm.Show();
        }

        private void btnTestSQLite_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SQLite.Instance().CheckConnect();
            if (SQLite.Instance()._checkconnect)
                MessageBox.Show("Connected!");
            else
                MessageBox.Show("Error");
        }

        private void btnSettingCoorZ_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormSetting.fmSettingCoorZ frm = new FormSetting.fmSettingCoorZ();
            frm.Show();
        }

        private void btnPointBendingConvex_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            VarGlobal.SELECT_FORM_SETTING = 2;
            fmSettingPointsPosition frm = new fmSettingPointsPosition();
            frm.Show();
        }

        private void btnPointBendingConcave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            VarGlobal.SELECT_FORM_SETTING = 3;
            fmSettingPointsPosition frm = new fmSettingPointsPosition();
            frm.Show();
        }

        private void btnStop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!VarGlobal.Instance().Move_Z_Axis_Abs_Pos(VarGlobal.POSITION_INTERMEDIATE_Z_AXIS))
                return;
            FormMotion.fmMotionTest frm = new FormMotion.fmMotionTest();
            frm.Show();
        }

        private void btnStop_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            VarGlobal.Instance().All_Move_Stop();
        }

        
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }

        private void btnParameterList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int ROMPara = 0;
            string temp = "";
            if (VarGlobal.m_Connected)
            {
                for (byte i = 0; i < 30; i++)
                {
                    EziMOTIONPlusRLib.FAS_GetROMParameter(VarGlobal.PortNo, 1, i, ref ROMPara);
                    temp += ROMPara.ToString() + "-";
                }
            }
            else
                MessageBox.Show("not connect");
            MessageBox.Show(temp);
        }

    }
}
