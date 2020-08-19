using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_3_Axis_Ezi_Step_Plus_R
{
    public partial class fmSettingPointsPosition : DevExpress.XtraEditors.XtraForm
    {
        public fmSettingPointsPosition()
        {
            InitializeComponent();
        }

        private void fmSettingPointsPosition_Load(object sender, EventArgs e)
        {
            this.Focus();
        }

        private void btnPoint1_Click(object sender, EventArgs e)
        {
            switch (VarGlobal.SELECT_FORM_SETTING)
            {
                case 1:
                    VarGlobal.Point = 0;
                    SetPoint frm1 = new SetPoint();
                    frm1.grpPoint.Text = "Point 1";
                    frm1.Show();
                    this.Close();
                    break;
                case 2:
                    VarGlobal.Point = 0;
                    FormSetting.fmSettingPointBendingConvex frm2 = new FormSetting.fmSettingPointBendingConvex();
                    frm2.grpPoint.Text = "Point 1";
                    frm2.Show();
                    this.Close();
                    break;
                case 3:
                    VarGlobal.Point = 0;
                    FormSetting.fmSettingPointBendingConcave frm3 = new FormSetting.fmSettingPointBendingConcave();
                    frm3.grpPoint.Text = "Point 1";
                    frm3.Show();
                    this.Close();
                    break;
                default:
                    break;
            }
            
        }

        private void btnPoint2_Click(object sender, EventArgs e)
        {
            switch (VarGlobal.SELECT_FORM_SETTING)
            {
                case 1:
                    VarGlobal.Point = 1;
                    SetPoint frm1 = new SetPoint();
                    frm1.grpPoint.Text = "Point 2";
                    frm1.Show();
                    this.Close();
                    break;
                case 2:
                    VarGlobal.Point = 1;
                    FormSetting.fmSettingPointBendingConvex frm2 = new FormSetting.fmSettingPointBendingConvex();
                    frm2.grpPoint.Text = "Point 2";
                    frm2.Show();
                    this.Close();
                    break;
                case 3:
                    VarGlobal.Point = 1;
                    FormSetting.fmSettingPointBendingConcave frm3 = new FormSetting.fmSettingPointBendingConcave();
                    frm3.grpPoint.Text = "Point 2";
                    frm3.Show();
                    this.Close();
                    break;
                default:
                    break;
            }
        }

        private void btnPoint3_Click(object sender, EventArgs e)
        {
            switch (VarGlobal.SELECT_FORM_SETTING)
            {
                case 1:
                    VarGlobal.Point = 2;
                    SetPoint frm1 = new SetPoint();
                    frm1.grpPoint.Text = "Point 3";
                    frm1.Show();
                    this.Close();
                    break;
                case 2:
                    VarGlobal.Point = 2;
                    FormSetting.fmSettingPointBendingConvex frm2 = new FormSetting.fmSettingPointBendingConvex();
                    frm2.grpPoint.Text = "Point 3";
                    frm2.Show();
                    this.Close();
                    break;
                case 3:
                    VarGlobal.Point = 2;
                    FormSetting.fmSettingPointBendingConcave frm3 = new FormSetting.fmSettingPointBendingConcave();
                    frm3.grpPoint.Text = "Point 3";
                    frm3.Show();
                    this.Close();
                    break;
                default:
                    break;
            }
        }

        private void btnPoint4_Click(object sender, EventArgs e)
        {
            switch (VarGlobal.SELECT_FORM_SETTING)
            {
                case 1:
                    VarGlobal.Point = 3;
                    SetPoint frm1 = new SetPoint();
                    frm1.grpPoint.Text = "Point 4";
                    frm1.Show();
                    this.Close();
                    break;
                case 2:
                    VarGlobal.Point = 3;
                    FormSetting.fmSettingPointBendingConvex frm2 = new FormSetting.fmSettingPointBendingConvex();
                    frm2.grpPoint.Text = "Point 4";
                    frm2.Show();
                    this.Close();
                    break;
                case 3:
                    VarGlobal.Point = 3;
                    FormSetting.fmSettingPointBendingConcave frm3 = new FormSetting.fmSettingPointBendingConcave();
                    frm3.grpPoint.Text = "Point 4";
                    frm3.Show();
                    this.Close();
                    break;
                default:
                    break;
            }
        }

        private void btnPoint5_Click(object sender, EventArgs e)
        {
            switch (VarGlobal.SELECT_FORM_SETTING)
            {
                case 1:
                    VarGlobal.Point = 4;
                    SetPoint frm1 = new SetPoint();
                    frm1.grpPoint.Text = "Point 5";
                    frm1.Show();
                    this.Close();
                    break;
                case 2:
                    VarGlobal.Point = 4;
                    FormSetting.fmSettingPointBendingConvex frm2 = new FormSetting.fmSettingPointBendingConvex();
                    frm2.grpPoint.Text = "Point 5";
                    frm2.Show();
                    this.Close();
                    break;
                case 3:
                    VarGlobal.Point = 4;
                    FormSetting.fmSettingPointBendingConcave frm3 = new FormSetting.fmSettingPointBendingConcave();
                    frm3.grpPoint.Text = "Point 5";
                    frm3.Show();
                    this.Close();
                    break;
                default:
                    break;
            }
        }

        private void btnPoint6_Click(object sender, EventArgs e)
        {
            switch (VarGlobal.SELECT_FORM_SETTING)
            {
                case 1:
                    VarGlobal.Point = 5;
                    SetPoint frm1 = new SetPoint();
                    frm1.grpPoint.Text = "Point 6";
                    frm1.Show();
                    this.Close();
                    break;
                case 2:
                    VarGlobal.Point = 5;
                    FormSetting.fmSettingPointBendingConvex frm2 = new FormSetting.fmSettingPointBendingConvex();
                    frm2.grpPoint.Text = "Point 6";
                    frm2.Show();
                    this.Close();
                    break;
                case 3:
                    VarGlobal.Point = 5;
                    FormSetting.fmSettingPointBendingConcave frm3 = new FormSetting.fmSettingPointBendingConcave();
                    frm3.grpPoint.Text = "Point 6";
                    frm3.Show();
                    this.Close();
                    break;
                default:
                    break;
            }
        }

        private void btnPoint7_Click(object sender, EventArgs e)
        {
            switch (VarGlobal.SELECT_FORM_SETTING)
            {
                case 1:
                    VarGlobal.Point = 6;
                    SetPoint frm1 = new SetPoint();
                    frm1.grpPoint.Text = "Point 7";
                    frm1.Show();
                    this.Close();
                    break;
                case 2:
                    VarGlobal.Point = 6;
                    FormSetting.fmSettingPointBendingConvex frm2 = new FormSetting.fmSettingPointBendingConvex();
                    frm2.grpPoint.Text = "Point 7";
                    frm2.Show();
                    this.Close();
                    break;
                case 3:
                    VarGlobal.Point = 6;
                    FormSetting.fmSettingPointBendingConcave frm3 = new FormSetting.fmSettingPointBendingConcave();
                    frm3.grpPoint.Text = "Point 7";
                    frm3.Show();
                    this.Close();
                    break;
                default:
                    break;
            }
        }

        private void btnPoint8_Click(object sender, EventArgs e)
        {
            switch (VarGlobal.SELECT_FORM_SETTING)
            {
                case 1:
                    VarGlobal.Point = 7;
                    SetPoint frm1 = new SetPoint();
                    frm1.grpPoint.Text = "Point 8";
                    frm1.Show();
                    this.Close();
                    break;
                case 2:
                    VarGlobal.Point = 7;
                    FormSetting.fmSettingPointBendingConvex frm2 = new FormSetting.fmSettingPointBendingConvex();
                    frm2.grpPoint.Text = "Point 8";
                    frm2.Show();
                    this.Close();
                    break;
                case 3:
                    VarGlobal.Point = 7;
                    FormSetting.fmSettingPointBendingConcave frm3 = new FormSetting.fmSettingPointBendingConcave();
                    frm3.grpPoint.Text = "Point 8";
                    frm3.Show();
                    this.Close();
                    break;
                default:
                    break;
            }
        }

        private void btnPoint9_Click(object sender, EventArgs e)
        {
            switch (VarGlobal.SELECT_FORM_SETTING)
            {
                case 1:
                    VarGlobal.Point = 8;
                    SetPoint frm1 = new SetPoint();
                    frm1.grpPoint.Text = "Point 9";
                    frm1.Show();
                    this.Close();
                    break;
                case 2:
                    VarGlobal.Point = 8;
                    FormSetting.fmSettingPointBendingConvex frm2 = new FormSetting.fmSettingPointBendingConvex();
                    frm2.grpPoint.Text = "Point 9";
                    frm2.Show();
                    this.Close();
                    break;
                case 3:
                    VarGlobal.Point = 8;
                    FormSetting.fmSettingPointBendingConcave frm3 = new FormSetting.fmSettingPointBendingConcave();
                    frm3.grpPoint.Text = "Point 9";
                    frm3.Show();
                    this.Close();
                    break;
                default:
                    break;
            }
        }

        private void btnPoint10_Click(object sender, EventArgs e)
        {
            switch (VarGlobal.SELECT_FORM_SETTING)
            {
                case 1:
                    VarGlobal.Point = 9;
                    SetPoint frm1 = new SetPoint();
                    frm1.grpPoint.Text = "Point 10";
                    frm1.Show();
                    this.Close();
                    break;
                case 2:
                    VarGlobal.Point = 9;
                    FormSetting.fmSettingPointBendingConvex frm2 = new FormSetting.fmSettingPointBendingConvex();
                    frm2.grpPoint.Text = "Point 10";
                    frm2.Show();
                    this.Close();
                    break;
                case 3:
                    VarGlobal.Point = 9;
                    FormSetting.fmSettingPointBendingConcave frm3 = new FormSetting.fmSettingPointBendingConcave();
                    frm3.grpPoint.Text = "Point 10";
                    frm3.Show();
                    this.Close();
                    break;
                default:
                    break;
            }
        }

        private void btnPoint11_Click(object sender, EventArgs e)
        {
            switch (VarGlobal.SELECT_FORM_SETTING)
            {
                case 1:
                    VarGlobal.Point = 10;
                    SetPoint frm1 = new SetPoint();
                    frm1.grpPoint.Text = "Point 11";
                    frm1.Show();
                    this.Close();
                    break;
                case 2:
                    VarGlobal.Point = 10;
                    FormSetting.fmSettingPointBendingConvex frm2 = new FormSetting.fmSettingPointBendingConvex();
                    frm2.grpPoint.Text = "Point 11";
                    frm2.Show();
                    this.Close();
                    break;
                case 3:
                    VarGlobal.Point = 10;
                    FormSetting.fmSettingPointBendingConcave frm3 = new FormSetting.fmSettingPointBendingConcave();
                    frm3.grpPoint.Text = "Point 11";
                    frm3.Show();
                    this.Close();
                    break;
                default:
                    break;
            }
        }

        private void btnPoint12_Click(object sender, EventArgs e)
        {
            switch (VarGlobal.SELECT_FORM_SETTING)
            {
                case 1:
                    VarGlobal.Point = 11;
                    SetPoint frm1 = new SetPoint();
                    frm1.grpPoint.Text = "Point 12";
                    frm1.Show();
                    this.Close();
                    break;
                case 2:
                    VarGlobal.Point = 11;
                    FormSetting.fmSettingPointBendingConvex frm2 = new FormSetting.fmSettingPointBendingConvex();
                    frm2.grpPoint.Text = "Point 12";
                    frm2.Show();
                    this.Close();
                    break;
                case 3:
                    VarGlobal.Point = 11;
                    FormSetting.fmSettingPointBendingConcave frm3 = new FormSetting.fmSettingPointBendingConcave();
                    frm3.grpPoint.Text = "Point 12";
                    frm3.Show();
                    this.Close();
                    break;
                default:
                    break;
            }
        }

        private void btnPoint13_Click(object sender, EventArgs e)
        {
            switch (VarGlobal.SELECT_FORM_SETTING)
            {
                case 1:
                    VarGlobal.Point = 12;
                    SetPoint frm1 = new SetPoint();
                    frm1.grpPoint.Text = "Point 13";
                    frm1.Show();
                    this.Close();
                    break;
                case 2:
                    VarGlobal.Point = 12;
                    FormSetting.fmSettingPointBendingConvex frm2 = new FormSetting.fmSettingPointBendingConvex();
                    frm2.grpPoint.Text = "Point 13";
                    frm2.Show();
                    this.Close();
                    break;
                case 3:
                    VarGlobal.Point = 12;
                    FormSetting.fmSettingPointBendingConcave frm3 = new FormSetting.fmSettingPointBendingConcave();
                    frm3.grpPoint.Text = "Point 13";
                    frm3.Show();
                    this.Close();
                    break;
                default:
                    break;
            }
        }

        private void btnPoint14_Click(object sender, EventArgs e)
        {
            switch (VarGlobal.SELECT_FORM_SETTING)
            {
                case 1:
                    VarGlobal.Point = 13;
                    SetPoint frm1 = new SetPoint();
                    frm1.grpPoint.Text = "Point 14";
                    frm1.Show();
                    this.Close();
                    break;
                case 2:
                    VarGlobal.Point = 13;
                    FormSetting.fmSettingPointBendingConvex frm2 = new FormSetting.fmSettingPointBendingConvex();
                    frm2.grpPoint.Text = "Point 14";
                    frm2.Show();
                    this.Close();
                    break;
                case 3:
                    VarGlobal.Point = 13;
                    FormSetting.fmSettingPointBendingConcave frm3 = new FormSetting.fmSettingPointBendingConcave();
                    frm3.grpPoint.Text = "Point 14";
                    frm3.Show();
                    this.Close();
                    break;
                default:
                    break;
            }
        }

        private void btnPoint15_Click(object sender, EventArgs e)
        {
            switch (VarGlobal.SELECT_FORM_SETTING)
            {
                case 1:
                    VarGlobal.Point = 14;
                    SetPoint frm1 = new SetPoint();
                    frm1.grpPoint.Text = "Point 15";
                    frm1.Show();
                    this.Close();
                    break;
                case 2:
                    VarGlobal.Point = 14;
                    FormSetting.fmSettingPointBendingConvex frm2 = new FormSetting.fmSettingPointBendingConvex();
                    frm2.grpPoint.Text = "Point 15";
                    frm2.Show();
                    this.Close();
                    break;
                case 3:
                    VarGlobal.Point = 14;
                    FormSetting.fmSettingPointBendingConcave frm3 = new FormSetting.fmSettingPointBendingConcave();
                    frm3.grpPoint.Text = "Point 15";
                    frm3.Show();
                    this.Close();
                    break;
                default:
                    break;
            }
        }

        private void btnPoint16_Click(object sender, EventArgs e)
        {
            switch (VarGlobal.SELECT_FORM_SETTING)
            {
                case 1:
                    VarGlobal.Point = 15;
                    SetPoint frm1 = new SetPoint();
                    frm1.grpPoint.Text = "Point 16";
                    frm1.Show();
                    this.Close();
                    break;
                case 2:
                    VarGlobal.Point = 15;
                    FormSetting.fmSettingPointBendingConvex frm2 = new FormSetting.fmSettingPointBendingConvex();
                    frm2.grpPoint.Text = "Point 16";
                    frm2.Show();
                    this.Close();
                    break;
                case 3:
                    VarGlobal.Point = 15;
                    FormSetting.fmSettingPointBendingConcave frm3 = new FormSetting.fmSettingPointBendingConcave();
                    frm3.grpPoint.Text = "Point 16";
                    frm3.Show();
                    this.Close();
                    break;
                default:
                    break;
            }
        }

        private void btnPoint17_Click(object sender, EventArgs e)
        {
            switch (VarGlobal.SELECT_FORM_SETTING)
            {
                case 1:
                    VarGlobal.Point = 16;
                    SetPoint frm1 = new SetPoint();
                    frm1.grpPoint.Text = "Point 17";
                    frm1.Show();
                    this.Close();
                    break;
                case 2:
                    VarGlobal.Point = 16;
                    FormSetting.fmSettingPointBendingConvex frm2 = new FormSetting.fmSettingPointBendingConvex();
                    frm2.grpPoint.Text = "Point 17";
                    frm2.Show();
                    this.Close();
                    break;
                case 3:
                    VarGlobal.Point = 16;
                    FormSetting.fmSettingPointBendingConcave frm3 = new FormSetting.fmSettingPointBendingConcave();
                    frm3.grpPoint.Text = "Point 17";
                    frm3.Show();
                    this.Close();
                    break;
                default:
                    break;
            }
        }

        private void btnPoint18_Click(object sender, EventArgs e)
        {
            switch (VarGlobal.SELECT_FORM_SETTING)
            {
                case 1:
                    VarGlobal.Point = 17;
                    SetPoint frm1 = new SetPoint();
                    frm1.grpPoint.Text = "Point 18";
                    frm1.Show();
                    this.Close();
                    break;
                case 2:
                    VarGlobal.Point = 17;
                    FormSetting.fmSettingPointBendingConvex frm2 = new FormSetting.fmSettingPointBendingConvex();
                    frm2.grpPoint.Text = "Point 18";
                    frm2.Show();
                    this.Close();
                    break;
                case 3:
                    VarGlobal.Point = 17;
                    FormSetting.fmSettingPointBendingConcave frm3 = new FormSetting.fmSettingPointBendingConcave();
                    frm3.grpPoint.Text = "Point 18";
                    frm3.Show();
                    this.Close();
                    break;
                default:
                    break;
            }
        }

        private void btnPoint19_Click(object sender, EventArgs e)
        {
            switch (VarGlobal.SELECT_FORM_SETTING)
            {
                case 1:
                    VarGlobal.Point = 18;
                    SetPoint frm1 = new SetPoint();
                    frm1.grpPoint.Text = "Point 19";
                    frm1.Show();
                    this.Close();
                    break;
                case 2:
                    VarGlobal.Point = 18;
                    FormSetting.fmSettingPointBendingConvex frm2 = new FormSetting.fmSettingPointBendingConvex();
                    frm2.grpPoint.Text = "Point 19";
                    frm2.Show();
                    this.Close();
                    break;
                case 3:
                    VarGlobal.Point = 18;
                    FormSetting.fmSettingPointBendingConcave frm3 = new FormSetting.fmSettingPointBendingConcave();
                    frm3.grpPoint.Text = "Point 19";
                    frm3.Show();
                    this.Close();
                    break;
                default:
                    break;
            }
        }

        private void btnPoint20_Click(object sender, EventArgs e)
        {
            switch (VarGlobal.SELECT_FORM_SETTING)
            {
                case 1:
                    VarGlobal.Point = 19;
                    SetPoint frm1 = new SetPoint();
                    frm1.grpPoint.Text = "Point 20";
                    frm1.Show();
                    this.Close();
                    break;
                case 2:
                    VarGlobal.Point = 19;
                    FormSetting.fmSettingPointBendingConvex frm2 = new FormSetting.fmSettingPointBendingConvex();
                    frm2.grpPoint.Text = "Point 20";
                    frm2.Show();
                    this.Close();
                    break;
                case 3:
                    VarGlobal.Point = 19;
                    FormSetting.fmSettingPointBendingConcave frm3 = new FormSetting.fmSettingPointBendingConcave();
                    frm3.grpPoint.Text = "Point 20";
                    frm3.Show();
                    this.Close();
                    break;
                default:
                    break;
            }
        }

        private void btnPoint21_Click(object sender, EventArgs e)
        {
            switch (VarGlobal.SELECT_FORM_SETTING)
            {
                case 1:
                    VarGlobal.Point = 20;
                    SetPoint frm1 = new SetPoint();
                    frm1.grpPoint.Text = "Point 21";
                    frm1.Show();
                    this.Close();
                    break;
                case 2:
                    VarGlobal.Point = 20;
                    FormSetting.fmSettingPointBendingConvex frm2 = new FormSetting.fmSettingPointBendingConvex();
                    frm2.grpPoint.Text = "Point 21";
                    frm2.Show();
                    this.Close();
                    break;
                case 3:
                    VarGlobal.Point = 20;
                    FormSetting.fmSettingPointBendingConcave frm3 = new FormSetting.fmSettingPointBendingConcave();
                    frm3.grpPoint.Text = "Point 21";
                    frm3.Show();
                    this.Close();
                    break;
                default:
                    break;
            }
        }

        private void btnPoint22_Click(object sender, EventArgs e)
        {
            switch (VarGlobal.SELECT_FORM_SETTING)
            {
                case 1:
                    VarGlobal.Point = 21;
                    SetPoint frm1 = new SetPoint();
                    frm1.grpPoint.Text = "Point 22";
                    frm1.Show();
                    this.Close();
                    break;
                case 2:
                    VarGlobal.Point = 21;
                    FormSetting.fmSettingPointBendingConvex frm2 = new FormSetting.fmSettingPointBendingConvex();
                    frm2.grpPoint.Text = "Point 22";
                    frm2.Show();
                    this.Close();
                    break;
                case 3:
                    VarGlobal.Point = 21;
                    FormSetting.fmSettingPointBendingConcave frm3 = new FormSetting.fmSettingPointBendingConcave();
                    frm3.grpPoint.Text = "Point 22";
                    frm3.Show();
                    this.Close();
                    break;
                default:
                    break;
            }
        }

        private void btnPoint23_Click(object sender, EventArgs e)
        {
            switch (VarGlobal.SELECT_FORM_SETTING)
            {
                case 1:
                    VarGlobal.Point = 22;
                    SetPoint frm1 = new SetPoint();
                    frm1.grpPoint.Text = "Point 23";
                    frm1.Show();
                    this.Close();
                    break;
                case 2:
                    VarGlobal.Point = 22;
                    FormSetting.fmSettingPointBendingConvex frm2 = new FormSetting.fmSettingPointBendingConvex();
                    frm2.grpPoint.Text = "Point 23";
                    frm2.Show();
                    this.Close();
                    break;
                case 3:
                    VarGlobal.Point = 22;
                    FormSetting.fmSettingPointBendingConcave frm3 = new FormSetting.fmSettingPointBendingConcave();
                    frm3.grpPoint.Text = "Point 23";
                    frm3.Show();
                    this.Close();
                    break;
                default:
                    break;
            }
        }

        private void btnPoint24_Click(object sender, EventArgs e)
        {
            switch (VarGlobal.SELECT_FORM_SETTING)
            {
                case 1:
                    VarGlobal.Point = 23;
                    SetPoint frm1 = new SetPoint();
                    frm1.grpPoint.Text = "Point 24";
                    frm1.Show();
                    this.Close();
                    break;
                case 2:
                    VarGlobal.Point = 23;
                    FormSetting.fmSettingPointBendingConvex frm2 = new FormSetting.fmSettingPointBendingConvex();
                    frm2.grpPoint.Text = "Point 24";
                    frm2.Show();
                    this.Close();
                    break;
                case 3:
                    VarGlobal.Point = 23;
                    FormSetting.fmSettingPointBendingConcave frm3 = new FormSetting.fmSettingPointBendingConcave();
                    frm3.grpPoint.Text = "Point 24";
                    frm3.Show();
                    this.Close();
                    break;
                default:
                    break;
            }
        }
    }
}
