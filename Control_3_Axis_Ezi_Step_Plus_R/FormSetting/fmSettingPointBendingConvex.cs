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

namespace Control_3_Axis_Ezi_Step_Plus_R.FormSetting
{
    public partial class fmSettingPointBendingConvex : DevExpress.XtraEditors.XtraForm
    {
        System.Windows.Forms.Timer t;

        public fmSettingPointBendingConvex()
        {
            InitializeComponent();

            t = new System.Windows.Forms.Timer();
            t.Interval = 1;
            t.Enabled = true;
            t.Tick += T_Tick;
        }
        private void T_Tick(object sender, EventArgs e)
        {
            GetActualPosition();
        }

        private void GetActualPosition()
        {
            lblCoorX.Text = VarGlobal.position_mm_x.ToString("0.000");
            lblCoorY.Text = VarGlobal.position_mm_y.ToString("0.000");
            lblCoorZ.Text = VarGlobal.position_mm_z.ToString("0.000");
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Invoke(new Action(() =>
            {
                if (!SQLite.Instance().CheckExistData("T24DefaultPointBendingConvex", VarGlobal.Point + 1))
                {
                    //MessageBox.Show("Empty");
                    //return;
                    SQLite.Instance().InsertPointsCoordinateBending("T24DefaultPointBendingConvex", VarGlobal.Point + 1,
                    "Point " + (VarGlobal.Point + 1), lblCoorX.Text, lblCoorY.Text, lblCoorZ.Text);
                    this.Close();
                }
                else
                {
                    SQLite.Instance().UpdatePointsCoordinateBending("T24DefaultPointBendingConvex", VarGlobal.Point + 1,
                        lblCoorX.Text, lblCoorY.Text, lblCoorZ.Text);
                    this.Close();
                }
            }));
        }

        private void SettingPointBendingConvex_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Enabled = false;
            fmSettingPointsPosition frm = new fmSettingPointsPosition();
            frm.Show();
        }

        private void SettingPointBendingConvex_Load(object sender, EventArgs e)
        {
            string[] _arr = SQLite.Instance().GetPointsCoordinate("T24DefaultPointBendingConvex",
                   VarGlobal.Point + 1, "Xcoor", "Ycoor", "Zcoor");
            int countnull = 0;
            foreach (string i in _arr)
            {
                if (i == null)
                    countnull++;
            }
            if (countnull > 0)
                return;
            int x_pos_abs = Calculate.Calculate_Coordinate_pulse(float.Parse(_arr[0]), Calculate.STEP_X);
            int y_pos_abs = Calculate.Calculate_Coordinate_pulse(float.Parse(_arr[1]), Calculate.STEP_Y);
            int z_pos_abs = Calculate.Calculate_Coordinate_pulse(float.Parse(_arr[2]), Calculate.STEP_Z);

            //VarGlobal.Instance().Move_All_Axis_Abs_Pos(x_pos_abs, y_pos_abs);
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

        private void btnJogZ_Up_MouseDown(object sender, MouseEventArgs e)
        {
            Jog_Manual(3, 1, VarGlobal.speedJOG_Z);
        }

        private void btnJogZ_Back_MouseDown(object sender, MouseEventArgs e)
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
                MessageBox.Show("Not Connect");
            }
        }
    }
}
