using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Advantech.Adam;
using Advantech.Common;
using FASTECH;

namespace Control_3_Axis_Ezi_Step_Plus_R.FormMotion
{
    public partial class fmStartMotion : DevExpress.XtraEditors.XtraForm
    {
        private uint dwAxisStatus_x = 0;
        private uint dwAxisStatus_y = 0;

        public fmStartMotion()
        {
            InitializeComponent();

        }
        int col = 0, row = 0;
        private void fmStartMotion_Load(object sender, EventArgs e)
        {
            if(VarGlobal.m_Connected == false)
            {
                MessageBox.Show("No Connection!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            tsStatus.Text = "Running...";
            tsStatus.ForeColor = Color.Green;

            tpnPoints.Controls.Clear();
            for (int point = 1; point < 25; point++)
            {
                Move_All_Axis_Abs_Pos(point);
                switch (point)
                {
                    case 6:
                        col = 1;
                        break;
                    case 12:
                        col = 2;
                        break;
                    case 18:
                        col = 3;
                        break;
                    default:
                        break;
                }
                if (row < 6)
                {
                    Label lblPoint = new Label();
                    lblPoint.Text = "Checked Point " + point;
                    lblPoint.AutoSize = false;
                    lblPoint.Dock = DockStyle.Fill;
                    lblPoint.TextAlign = ContentAlignment.MiddleCenter;
                    tpnPoints.Controls.Add(lblPoint, col, row);
                    row++;
                    return;
                }
                if (VarGlobal.adam_Connected)
                {
                    if (VarGlobal.adamCom.AnalogInput(VarGlobal.Adam_iAddr).GetValue(5, out float value, out Adam4000_ChannelStatus status))
                    {
                        if (status == Adam4000_ChannelStatus.Normal)
                        {
                            double height_mm;
                            height_mm = (2.5 - value) / 0.008386;
                            ListViewItem lvi = new ListViewItem(point + "");
                            lvi.SubItems.Add("Point " + point);
                            lvi.SubItems.Add(height_mm + "");
                            lviPointMeasurement.Items.Add(lvi);
                        }
                        else MessageBox.Show("Fail to get Value");
                    }
                    else MessageBox.Show("Fail to get Value");
                }

                Thread.Sleep(200);
            }
        }

        private void Move_All_Axis_Abs_Pos(int point)
        {
            int x_pos_abs, y_pos_abs;

            x_pos_abs = (int)(Coordinates.Xcoordinate.Instance().x_coor[point - 1] * 1000);
            y_pos_abs = (int)(Coordinates.Ycoordinate.Instance().y_coor[point - 1] * 1000);

            if (VarGlobal.m_Connected == false)
                return;
            else
            {
                int nRtn_1 = EziMOTIONPlusRLib.FAS_MoveSingleAxisAbsPos(VarGlobal.PortNo, 3, x_pos_abs, VarGlobal.speedJOG_Z);
                if (nRtn_1 != EziMOTIONPlusRLib.FMM_OK)
                {
                    string strMsg;
                    strMsg = "FAS_MoveSingleAxisAbsPos() \nReturned: " + nRtn_1.ToString();
                    MessageBox.Show(strMsg, "Function Failed");
                }

                int nRtn_2 = EziMOTIONPlusRLib.FAS_MoveSingleAxisAbsPos(VarGlobal.PortNo, 2, y_pos_abs, VarGlobal.speedJOG_Y);
                if (nRtn_2 != EziMOTIONPlusRLib.FMM_OK)
                {
                    string strMsg;
                    strMsg = "FAS_MoveSingleAxisAbsPos() \nReturned: " + nRtn_2.ToString();
                    MessageBox.Show(strMsg, "Function Failed");
                }
            }
            do
            {
                int nRtn_3 = EziMOTIONPlusRLib.FAS_GetAxisStatus(VarGlobal.PortNo, 3, ref dwAxisStatus_x);
                int nRtn_4 = EziMOTIONPlusRLib.FAS_GetAxisStatus(VarGlobal.PortNo, 2, ref dwAxisStatus_y);

                if (nRtn_3 != EziMOTIONPlusRLib.FMM_OK || nRtn_4 != EziMOTIONPlusRLib.FMM_OK)
                {
                    string strMsg;
                    strMsg = "FAS_GetAxisStatus() \nReturned: " + nRtn_3.ToString() + nRtn_4.ToString();
                    MessageBox.Show(strMsg, "Function Failed");
                    return;
                }

                if ((dwAxisStatus_x & 0x00000001) == 1 || (dwAxisStatus_y & 0x00000001) == 1)  // FFLAG_ERRORALL is ON
                {
                    string strMsg;
                    strMsg = "Error flag";
                    MessageBox.Show(strMsg, "AxisStatus");
                    return;
                }
            }
            while ((dwAxisStatus_x & 0x08000000) != 0 || (dwAxisStatus_y & 0x08000000) != 0);  // FFLAG_MOTIONING is ON
        }
    }
}
