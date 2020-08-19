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
using System.Threading;

namespace Control_3_Axis_Ezi_Step_Plus_R.FormMotion
{
    public partial class fmMotionTest : DevExpress.XtraEditors.XtraForm
    {
        Thread _Show_Coordinate;
        //Task show;
        System.Windows.Forms.Timer t;
        public fmMotionTest()
        {
            InitializeComponent();

            t = new System.Windows.Forms.Timer();
            t.Interval = 1;
            //t.Enabled = true;
            t.Tick += T_Tick;

            _Show_Coordinate = new Thread(ShowCoordinate);
            _Show_Coordinate.IsBackground = true;
            _Show_Coordinate.Start();
        }

        private void T_Tick(object sender, EventArgs e)
        {
            ShowCoordinate();
        }

        private void fmMotionTest_Load(object sender, EventArgs e)
        {
            
        }

        private void btnJogXplus_MouseDown(object sender, MouseEventArgs e)
        {
            Jog_Manual(1, 1, VarGlobal.speedJOG_X);
        }

        private void btnJogXminus_MouseDown(object sender, MouseEventArgs e)
        {
            Jog_Manual(1, 0, VarGlobal.speedJOG_X);
        }

        private void btnJogYplus_MouseDown(object sender, MouseEventArgs e)
        {
            Jog_Manual(2, 1, VarGlobal.speedJOG_Y);
        }

        private void btnJogYminus_MouseDown(object sender, MouseEventArgs e)
        {
            Jog_Manual(2, 0, VarGlobal.speedJOG_Y);
        }

        private void btnJogZplus_MouseDown(object sender, MouseEventArgs e)
        {
            Jog_Manual(3, 1, VarGlobal.speedJOG_Z);
        }

        private void btnJogZminus_MouseDown(object sender, MouseEventArgs e)
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
        void ShowCoordinate()
        {
            while (true)
            {
               // Invoke(new MethodInvoker(delegate
               //{
                   tslPosX.Text = VarGlobal.position_mm_x.ToString("0.0000");
                   tslPosY.Text = VarGlobal.position_mm_y.ToString("0.0000");
                   tslPosZ.Text = VarGlobal.position_mm_z.ToString("0.0000");
               //}));
            }
        }
        private void Move_Stop(object sender, MouseEventArgs e)
        {
            for (byte i = 1; i <= 3; i++)
            {
                EziMOTIONPlusRLib.FAS_MoveStop(VarGlobal.PortNo, i);
            }
        }

        private void btnMoveX_Click(object sender, EventArgs e)
        {
            if (VarGlobal.m_Connected)
            {
                int nRtn_1 = EziMOTIONPlusRLib.FAS_MoveSingleAxisAbsPos(VarGlobal.PortNo, 1,
                    Calculate.Calculate_Coordinate_pulse(float.Parse(txtPositionX.Text.Trim()), Calculate.STEP_X),
                    VarGlobal.speedJOG_X);
                if (nRtn_1 != EziMOTIONPlusRLib.FMM_OK)
                {
                    string strMsg;
                    strMsg = "FAS_MoveSingleAxisAbsPos() \nReturned: " + nRtn_1.ToString();
                    MessageBox.Show(strMsg, "Function Failed");
                }
            }
            else { MessageBox.Show("Not connect"); }
        }

        private void btnMoveY_Click(object sender, EventArgs e)
        {
            if (VarGlobal.m_Connected)
            {
                int nRtn_1 = EziMOTIONPlusRLib.FAS_MoveSingleAxisAbsPos(VarGlobal.PortNo, 2,
                    Calculate.Calculate_Coordinate_pulse(float.Parse(txtPositionY.Text.Trim()), Calculate.STEP_Y),
                    VarGlobal.speedJOG_Y);
                if (nRtn_1 != EziMOTIONPlusRLib.FMM_OK)
                {
                    string strMsg;
                    strMsg = "FAS_MoveSingleAxisAbsPos() \nReturned: " + nRtn_1.ToString();
                    MessageBox.Show(strMsg, "Function Failed");
                }
            }
            else { MessageBox.Show("Not connect"); }
        }

        private void btnMoveZ_Click(object sender, EventArgs e)
        {
            if (VarGlobal.m_Connected)
            {
                int nRtn_1 = EziMOTIONPlusRLib.FAS_MoveSingleAxisAbsPos(VarGlobal.PortNo, 3,
                    Calculate.Calculate_Coordinate_pulse(float.Parse(txtPositionZ.Text.Trim()), Calculate.STEP_Z),
                    VarGlobal.speedJOG_Z);
                if (nRtn_1 != EziMOTIONPlusRLib.FMM_OK)
                {
                    string strMsg;
                    strMsg = "FAS_MoveSingleAxisAbsPos() \nReturned: " + nRtn_1.ToString();
                    MessageBox.Show(strMsg, "Function Failed");
                }
            }
            else { MessageBox.Show("Not connect"); }
        }

        private void btnMoveOriginX_Click(object sender, EventArgs e)
        {
            if (VarGlobal.m_Connected)
            {
                int nRtn_1 = EziMOTIONPlusRLib.FAS_MoveOriginSingleAxis(VarGlobal.PortNo, 1);
                if (nRtn_1 != EziMOTIONPlusRLib.FMM_OK)
                {
                    string strMsg;
                    strMsg = "FAS_MoveSingleAxisAbsPos() \nReturned: " + nRtn_1.ToString();
                    MessageBox.Show(strMsg, "Function Failed");
                }
                Thread.Sleep(500);
            }
            else { MessageBox.Show("Not Connect"); }
        }

        private void btnMoveOriginY_Click(object sender, EventArgs e)
        {
            if (VarGlobal.m_Connected)
            {
                int nRtn_1 = EziMOTIONPlusRLib.FAS_MoveOriginSingleAxis(VarGlobal.PortNo, 2);
                if (nRtn_1 != EziMOTIONPlusRLib.FMM_OK)
                {
                    string strMsg;
                    strMsg = "FAS_MoveSingleAxisAbsPos() \nReturned: " + nRtn_1.ToString();
                    MessageBox.Show(strMsg, "Function Failed");
                }
                Thread.Sleep(500);
            }
            else { MessageBox.Show("Not Connect"); }
        }

        private void btnMoveOriginZ_Click(object sender, EventArgs e)
        {
            if (VarGlobal.m_Connected)
            {
                int nRtn_1 = EziMOTIONPlusRLib.FAS_MoveOriginSingleAxis(VarGlobal.PortNo, 3);
                if (nRtn_1 != EziMOTIONPlusRLib.FMM_OK)
                {
                    string strMsg;
                    strMsg = "FAS_MoveSingleAxisAbsPos() \nReturned: " + nRtn_1.ToString();
                    MessageBox.Show(strMsg, "Function Failed");
                }
                Thread.Sleep(500);
            }
            else { MessageBox.Show("Not Connect"); }
        }
        uint dwAxisStatus;
        private void btnResetAlarmX_Click(object sender, EventArgs e)
        {
            if (VarGlobal.m_Connected)
            {
                if (EziMOTIONPlusRLib.FAS_IsSlaveExist(VarGlobal.PortNo, 1) != 0)
                {
                    int nRnt_1 = EziMOTIONPlusRLib.FAS_GetAxisStatus(VarGlobal.PortNo, 1, ref dwAxisStatus);
                    if (nRnt_1 != EziMOTIONPlusRLib.FMM_OK)
                    {
                        string strMsg;
                        strMsg = "FAS_GetAxisStatus() \nReturned: " + nRnt_1.ToString();
                        MessageBox.Show(strMsg, "Function Failed");
                    }
                    if ((dwAxisStatus & 0x00000001) != 0) //FFLAG_ERRORALL is ON
                    {
                        int nRtn = EziMOTIONPlusRLib.FAS_StepAlarmReset(VarGlobal.PortNo, 1, 1);
                        if (nRtn != EziMOTIONPlusRLib.FMM_OK)
                        {
                            string strMsg;
                            strMsg = "FAS_ServoAlarmReset() \nReturned: " + nRtn.ToString();
                            MessageBox.Show(strMsg, "Function Failed");
                        }
                    }

                }
            }
            else { MessageBox.Show("Not Connect"); }
        }

        private void btnResetAlarmY_Click(object sender, EventArgs e)
        {
            if (VarGlobal.m_Connected)
            {
                if (EziMOTIONPlusRLib.FAS_IsSlaveExist(VarGlobal.PortNo, 2) != 0)
                {
                    int nRnt_1 = EziMOTIONPlusRLib.FAS_GetAxisStatus(VarGlobal.PortNo, 2, ref dwAxisStatus);
                    if (nRnt_1 != EziMOTIONPlusRLib.FMM_OK)
                    {
                        string strMsg;
                        strMsg = "FAS_GetAxisStatus() \nReturned: " + nRnt_1.ToString();
                        MessageBox.Show(strMsg, "Function Failed");
                    }
                    if ((dwAxisStatus & 0x00000001) != 0) //FFLAG_ERRORALL is ON
                    {
                        int nRtn = EziMOTIONPlusRLib.FAS_StepAlarmReset(VarGlobal.PortNo, 2, 1);
                        if (nRtn != EziMOTIONPlusRLib.FMM_OK)
                        {
                            string strMsg;
                            strMsg = "FAS_ServoAlarmReset() \nReturned: " + nRtn.ToString();
                            MessageBox.Show(strMsg, "Function Failed");
                        }
                    }

                }
            }
            else { MessageBox.Show("Not Connect"); }
        }

        private void btnResetAlarmZ_Click(object sender, EventArgs e)
        {
            if (VarGlobal.m_Connected)
            {
                if (EziMOTIONPlusRLib.FAS_IsSlaveExist(VarGlobal.PortNo, 3) != 0)
                {
                    int nRnt_1 = EziMOTIONPlusRLib.FAS_GetAxisStatus(VarGlobal.PortNo, 3, ref dwAxisStatus);
                    if (nRnt_1 != EziMOTIONPlusRLib.FMM_OK)
                    {
                        string strMsg;
                        strMsg = "FAS_GetAxisStatus() \nReturned: " + nRnt_1.ToString();
                        MessageBox.Show(strMsg, "Function Failed");
                    }
                    if ((dwAxisStatus & 0x00000001) != 0) //FFLAG_ERRORALL is ON
                    {
                        int nRtn = EziMOTIONPlusRLib.FAS_StepAlarmReset(VarGlobal.PortNo, 3, 1);
                        if (nRtn != EziMOTIONPlusRLib.FMM_OK)
                        {
                            string strMsg;
                            strMsg = "FAS_ServoAlarmReset() \nReturned: " + nRtn.ToString();
                            MessageBox.Show(strMsg, "Function Failed");
                        }
                    }

                }
            }
            else
            {
                MessageBox.Show("Not connect");
            }
        }

        private void fmMotionTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Enabled = false;
            _Show_Coordinate.Abort();
        }

        private void btnMotionConvex_Click(object sender, EventArgs e)
        {
            int x_pos_abs = 0;
            int y_pos_abs = 0;
            int z_pos_abs = 0;

            for (int i = 1; i <= 24; i++)
            {
                Thread.Sleep(1000);
                string[] arr = SQLite.Instance().GetZCoorBending(i);

                x_pos_abs = Coordinates.Xcoordinate.Instance().x_coor[i - 1];
                y_pos_abs = Coordinates.Ycoordinate.Instance().y_coor[i - 1] - VarGlobal.OFFSET_CONVEX;
                z_pos_abs = Calculate.Calculate_Coordinate_pulse(float.Parse(arr[0]), Calculate.STEP_Z);


                VarGlobal.Instance().Move_All_Axis_Abs_Pos(x_pos_abs, y_pos_abs);
                Thread.Sleep(1000);
                if (!VarGlobal.Instance().Move_Z_Axis_Abs_Pos(z_pos_abs))
                    return;
                Thread.Sleep(2000);
                if (!VarGlobal.Instance().Move_Z_Axis_Abs_Pos(VarGlobal.POSITION_INTERMEDIATE_Z_AXIS))
                    return;
            }

        }

        private void btnMotionConcave_Click(object sender, EventArgs e)
        {
            int x_pos_abs = 0;
            int y_pos_abs = 0;
            int z_pos_abs = 0;

            for (int i = 1; i <= 24; i++)
            {
                Thread.Sleep(1000);
                string[] arr = SQLite.Instance().GetZCoorBending(i);

                x_pos_abs = Coordinates.Xcoordinate.Instance().x_coor[i - 1];
                y_pos_abs = Coordinates.Ycoordinate.Instance().y_coor[i - 1] - VarGlobal.OFFSET_CONCAVE;
                z_pos_abs = Calculate.Calculate_Coordinate_pulse(float.Parse(arr[1]), Calculate.STEP_Z);


                VarGlobal.Instance().Move_All_Axis_Abs_Pos(x_pos_abs, y_pos_abs);
                Thread.Sleep(1000);
                if (!VarGlobal.Instance().Move_Z_Axis_Abs_Pos(z_pos_abs))
                    return;
                Thread.Sleep(2000);
                if (!VarGlobal.Instance().Move_Z_Axis_Abs_Pos(VarGlobal.POSITION_INTERMEDIATE_Z_AXIS))
                    return;
            }
        }
    }
}
