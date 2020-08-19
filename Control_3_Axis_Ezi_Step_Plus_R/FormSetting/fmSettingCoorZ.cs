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

namespace Control_3_Axis_Ezi_Step_Plus_R.FormSetting
{
    public partial class fmSettingCoorZ : DevExpress.XtraEditors.XtraForm
    {
        System.Windows.Forms.Timer t;

        int x_pos_abs, y_pos_abs;
        public fmSettingCoorZ()
        {
            InitializeComponent();

            t = new System.Windows.Forms.Timer();
            t.Interval = 1;
            t.Enabled = true;
            t.Tick += T_Tick;
        }

        private void T_Tick(object sender, EventArgs e)
        {
            tslPosZ.Text = VarGlobal.position_mm_z.ToString("0.0000");
        }

        private void fmSettingCoorZ_Load(object sender, EventArgs e)
        {
            ChekedRad();

            for (int i = 1; i <= 24; i++)
            {
                cbbPoint.Items.Add("Point " + i);
            }
            if (SQLite.Instance().CheckExistData("T24ZCoordinateBending", cbbPoint.SelectedIndex + 1))
            {
                string[] arr = SQLite.Instance().GetZCoorBending(cbbPoint.SelectedIndex + 1);
                txtZCoorConvex.Text = arr[0];
                txtZCoorConcave.Text = arr[1];
            }
            if (!VarGlobal.Instance().Move_Z_Axis_Abs_Pos(VarGlobal.POSITION_INTERMEDIATE_Z_AXIS))
                return;
            Thread.Sleep(500);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!SQLite.Instance().CheckExistData("T24ZCoordinateBending", cbbPoint.SelectedIndex + 1))
            {
                if (radConvex.Checked)
                {
                    SQLite.Instance().InsertZCoorBending("ZCoorConvex", cbbPoint.SelectedIndex + 1, tslPosZ.Text);
                    MessageBox.Show("OK!");
                }
                if (radConcave.Checked)
                {
                    SQLite.Instance().InsertZCoorBending("ZCoorConcave", cbbPoint.SelectedIndex + 1, tslPosZ.Text);
                    MessageBox.Show("OK!");
                }
            }
            else
            {
                if (radConvex.Checked)
                {
                    SQLite.Instance().UpdateZCoorBending("ZCoorConvex", cbbPoint.SelectedIndex + 1, tslPosZ.Text);
                    MessageBox.Show("OK!");
                }
                if (radConcave.Checked)
                {
                    SQLite.Instance().UpdateZCoorBending("ZCoorConcave", cbbPoint.SelectedIndex + 1, tslPosZ.Text);
                    MessageBox.Show("OK!");
                }
            }
        }
        /// <summary>
        /// Option by hand
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
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
        /// <summary>
        /// Move Stop of Z coor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Move_Stop(object sender, MouseEventArgs e)
        {
            if (VarGlobal.m_Connected)
            {
                int nRtn = EziMOTIONPlusRLib.FAS_MoveStop(VarGlobal.PortNo, 3);
                if (nRtn != EziMOTIONPlusRLib.FMM_OK)
                {
                    string strmsg;
                    strmsg = "FAS_MoveStop() \nreturned: " + nRtn.ToString();
                    MessageBox.Show(strmsg, "function failed");
                }
            }
            else
            {
                MessageBox.Show("Not connect");
            }
        }
        private void btnJOGplus_MouseDown(object sender, MouseEventArgs e)
        {
            Jog_Manual(3, 1, VarGlobal.speedJOG_Z);
        }

        private void btnJOGminus_MouseDown(object sender, MouseEventArgs e)
        {
            Jog_Manual(3, 0, VarGlobal.speedJOG_Z);
        }

        private void fmSettingCoorZ_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Enabled = false;
        }

        private void cbbPoint_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!VarGlobal.Instance().Move_Z_Axis_Abs_Pos(VarGlobal.POSITION_INTERMEDIATE_Z_AXIS))
                return;
            Thread.Sleep(500);
            if (radConvex.Checked)
            {
                x_pos_abs = Coordinates.Xcoordinate.Instance().x_coor[cbbPoint.SelectedIndex];
                y_pos_abs = Coordinates.Ycoordinate.Instance().y_coor[cbbPoint.SelectedIndex] - VarGlobal.OFFSET_CONVEX;
            }
            if (radConcave.Checked)
            {
                x_pos_abs = Coordinates.Xcoordinate.Instance().x_coor[cbbPoint.SelectedIndex];
                y_pos_abs = Coordinates.Ycoordinate.Instance().y_coor[cbbPoint.SelectedIndex] - VarGlobal.OFFSET_CONCAVE;
            }
            VarGlobal.Instance().Move_All_Axis_Abs_Pos(x_pos_abs, y_pos_abs);

            if (!SQLite.Instance().CheckExistData("T24ZCoordinateBending", cbbPoint.SelectedIndex + 1))
                return;
            string[] arr = SQLite.Instance().GetZCoorBending(cbbPoint.SelectedIndex + 1);
            txtZCoorConvex.Text = arr[0];
            txtZCoorConcave.Text = arr[1];
        }
        private void ChekedRad()
        {
            if (radConvex.Checked)
            {
                txtZCoorConcave.Enabled = false;
                txtZCoorConvex.Enabled = true;

                btnMoveConvex.Enabled = true;
                btnMoveConcave.Enabled = false;
            }
            if (radConcave.Checked)
            {
                txtZCoorConcave.Enabled = true;
                txtZCoorConvex.Enabled = false;

                btnMoveConvex.Enabled = false;
                btnMoveConcave.Enabled = true;
            }
        }

        private void radConvex_CheckedChanged(object sender, EventArgs e)
        {
            ChekedRad();
        }

        private void radConcave_CheckedChanged(object sender, EventArgs e)
        {
            ChekedRad();
        }

        private void btnMoveConvex_Click(object sender, EventArgs e)
        {
            VarGlobal.Instance().Move_Z_Axis_Abs_Pos(Calculate.Calculate_Coordinate_pulse(
                float.Parse(txtZCoorConvex.Text.Trim()), Calculate.STEP_Z));
        }

        private void btnMoveConcave_Click(object sender, EventArgs e)
        {
            VarGlobal.Instance().Move_Z_Axis_Abs_Pos(Calculate.Calculate_Coordinate_pulse(
                float.Parse(txtZCoorConcave.Text.Trim()), Calculate.STEP_Z));
        }
    }
}
