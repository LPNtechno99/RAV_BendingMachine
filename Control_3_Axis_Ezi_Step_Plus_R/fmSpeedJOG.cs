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
    public partial class fmSpeedJOG : DevExpress.XtraEditors.XtraForm
    {
        public fmSpeedJOG()
        {
            InitializeComponent();
        }

        private void fmSpeedJOG_Load(object sender, EventArgs e)
        {
            uint[] arr = SQLite.Instance().GetSpeedJOG();
            VarGlobal.speedJOG_X = arr[0];
            VarGlobal.speedJOG_Y = arr[1];
            VarGlobal.speedJOG_Z = arr[2];

            txtSpeedJOG_X.Text = VarGlobal.speedJOG_X.ToString();
            txtSpeedJOG_Y.Text = VarGlobal.speedJOG_Y.ToString();
            txtSpeedJOG_Z.Text = VarGlobal.speedJOG_Z.ToString();

            lblSpeedJOGX.Text += string.Format(" = {0}", VarGlobal.speedJOG_X);
            lblSpeedJOGY.Text += string.Format(" = {0}", VarGlobal.speedJOG_Y);
            lblSpeedJOGZ.Text += string.Format(" = {0}", VarGlobal.speedJOG_Z);
        }

        private void btnSetSpeedJOG_Click(object sender, EventArgs e)
        {
            SQLite.Instance().UpdateSpeedJOG(uint.Parse(txtSpeedJOG_X.Text.Trim()), uint.Parse(txtSpeedJOG_Y.Text.Trim())
                , uint.Parse(txtSpeedJOG_Z.Text.Trim()));
            VarGlobal.speedJOG_X = uint.Parse(txtSpeedJOG_X.Text.Trim());
            VarGlobal.speedJOG_Y = uint.Parse(txtSpeedJOG_Y.Text.Trim());
            VarGlobal.speedJOG_Z = uint.Parse(txtSpeedJOG_Z.Text.Trim());
            this.Close();
        }
    }
}
