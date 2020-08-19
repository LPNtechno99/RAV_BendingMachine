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
    public partial class SetPoint : DevExpress.XtraEditors.XtraForm
    {
        System.Windows.Forms.Timer t;
        Thread _thread;

        int x_pos_abs = 0;
        int y_pos_abs = 0;
        int z_pos_abs = 0;

        string[] _arr = new string[3];

        public SetPoint()
        {
            InitializeComponent();

            t = new System.Windows.Forms.Timer();
            t.Interval = 1;
            //t.Enabled = true;
            t.Tick += T_Tick;


        }

        private void T_Tick(object sender, EventArgs e)
        {
            GetActualPosition();
        }

        private void GetActualPosition()
        {
            while (true)
            {
                Invoke(new MethodInvoker(delegate
                {
                    lblCoorX.Text = VarGlobal.position_mm_x.ToString("0.0000");
                    lblCoorY.Text = VarGlobal.position_mm_y.ToString("0.0000");
                    lblCoorZ.Text = VarGlobal.position_mm_z.ToString("0.0000");
                    tslMeasurement.Text = VarGlobal.measurementvalue.ToString("0.0000");
                }));
                if (VarGlobal.adam_Connected)
                {
                    if (VarGlobal.adamCom.AnalogInput(VarGlobal.Adam_iAddr).GetValue(5, out float value, out Adam4000_ChannelStatus status))
                    {
                        if (status == Adam4000_ChannelStatus.Normal)
                        {
                            VarGlobal.measurementvalue = value * (float)6.0714;
                        }
                    }
                }
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Invoke(new Action(() =>
            {
                Coordinates.Xcoordinate.Instance().x_coor[VarGlobal.Point] = Calculate.CommandPosX;
                Coordinates.Ycoordinate.Instance().y_coor[VarGlobal.Point] = Calculate.CommandPosY;
                Coordinates.Zcoordinate.Instance().z_coor[VarGlobal.Point] = Calculate.CommandPosZ;

                VarGlobal.Instance().node_item_x.lPosition = Calculate.CommandPosX;
                int nRtn_1 = EziMOTIONPlusRLib.FAS_PosTableWriteItem(VarGlobal.PortNo, 1, VarGlobal.Point, VarGlobal.Instance().node_item_x);
                if (nRtn_1 != EziMOTIONPlusRLib.FMM_OK)
                {
                    string strmsg;
                    strmsg = "FAS_PosTableWriteItem() \nreturned: " + nRtn_1.ToString();
                    MessageBox.Show(strmsg, "function failed");
                }

                VarGlobal.Instance().node_item_y.lPosition = Calculate.CommandPosY;
                int ntRn_2 = EziMOTIONPlusRLib.FAS_PosTableWriteItem(VarGlobal.PortNo, 2, VarGlobal.Point, VarGlobal.Instance().node_item_y);
                if (ntRn_2 != EziMOTIONPlusRLib.FMM_OK)
                {
                    string strmsg;
                    strmsg = "FAS_PosTableWriteItem() \nreturned: " + ntRn_2.ToString();
                    MessageBox.Show(strmsg, "function failed");
                }
                VarGlobal.Instance().node_item_z.lPosition = Calculate.CommandPosZ;
                int ntRn_3 = EziMOTIONPlusRLib.FAS_PosTableWriteItem(VarGlobal.PortNo, 2, VarGlobal.Point, VarGlobal.Instance().node_item_z);
                if (ntRn_3 != EziMOTIONPlusRLib.FMM_OK)
                {
                    string strmsg;
                    strmsg = "FAS_PosTableWriteItem() \nreturned: " + ntRn_3.ToString();
                    MessageBox.Show(strmsg, "function failed");
                }
                if (!SQLite.Instance().CheckExistData("T24DefaultPointMeasurement", VarGlobal.Point + 1))
                {
                    SQLite.Instance().InsertDefaultPointsCoordinate("T24DefaultPointMeasurement", VarGlobal.Point + 1,
                "Point " + (VarGlobal.Point + 1), lblCoorX.Text, lblCoorY.Text, lblCoorZ.Text);
                }
                else
                {
                    SQLite.Instance().UpdateDefaultPointsCoordinate("T24DefaultPointMeasurement", VarGlobal.Point + 1,
                   lblCoorX.Text, lblCoorY.Text, lblCoorZ.Text);
                }
                this.Close();
            }));
        }

        private void SetPoint_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Enabled = false;
            _thread.Abort();
            fmSettingPointsPosition frm = new fmSettingPointsPosition();
            frm.Show();
        }

        private void SetPoint_Load(object sender, EventArgs e)
        {
            _arr = SQLite.Instance().GetPointsCoordinate("T24DefaultPointMeasurement",
                   VarGlobal.Point + 1, "Xcoor", "Ycoor", "Zcoor");
            x_pos_abs = Calculate.Calculate_Coordinate_pulse(float.Parse(_arr[0]), Calculate.STEP_X);
            y_pos_abs = Calculate.Calculate_Coordinate_pulse(float.Parse(_arr[1]), Calculate.STEP_Y);
            z_pos_abs = Calculate.Calculate_Coordinate_pulse(float.Parse(_arr[2]), Calculate.STEP_Z);

            VarGlobal.Instance().Move_All_Axis_Abs_Pos(x_pos_abs, y_pos_abs);

            _thread = new Thread(GetActualPosition);
            _thread.IsBackground = true;
            _thread.Start();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnJogX_Up_MouseDown(object sender, MouseEventArgs e)
        {
            Jog_Manual(1, 1, VarGlobal.speedJOG_X);
        }
        private void btnJogX_Back_MouseDown(object sender, MouseEventArgs e)
        {
            Jog_Manual(1, 0, VarGlobal.speedJOG_X);
        }

        private void btnJogY_Up_MouseDown(object sender, MouseEventArgs e)
        {
            Jog_Manual(2, 1, VarGlobal.speedJOG_Y);
        }

        private void btnJogY_Back_MouseDown(object sender, MouseEventArgs e)
        {
            Jog_Manual(2, 0, VarGlobal.speedJOG_Y);
        }
        private void btnJogZ_Plus_MouseDown(object sender, MouseEventArgs e)
        {
            Jog_Manual(3, 1, VarGlobal.speedJOG_Z);
        }

        private void btnJogZ_Minus_MouseDown(object sender, MouseEventArgs e)
        {
            Jog_Manual(3, 0, VarGlobal.speedJOG_Z);
        }
        private void Jog_Manual(byte i, int j, uint speed)
        {
            if (VarGlobal.m_Connected == false)
            {
                return;
            }
            else
            {

                int nRtn = EziMOTIONPlusRLib.FAS_MoveVelocity(VarGlobal.PortNo, i, speed, j);

                if (nRtn != EziMOTIONPlusRLib.FMM_OK)
                {
                    string strmsg;
                    strmsg = "FAS_Movesingleaxisincpos() \nreturned: " + nRtn.ToString();
                    MessageBox.Show(strmsg, "function failed");
                }
            }
        }

        private void Move_Stop(object sender, MouseEventArgs e)
        {
            if (VarGlobal.m_Connected)
            {
                for (byte i = 1; i <= 3; i++)
                {
                    EziMOTIONPlusRLib.FAS_MoveStop(VarGlobal.PortNo, i);
                }
            }
            else
            {
                MessageBox.Show("Not connect");
            }
        }
    }
}
