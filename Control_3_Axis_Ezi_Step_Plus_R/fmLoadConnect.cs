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

namespace Control_3_Axis_Ezi_Step_Plus_R
{
    public partial class fmLoadConnect : DevExpress.XtraEditors.XtraForm
    {
        //public delegate void progress();
        //public event progress CheckDone;
        System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();

        public fmLoadConnect()
        {
            InitializeComponent();
            t.Interval = 1;
            t.Tick += T_Tick;
            t.Start();
        }

        private void T_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value == progressBar1.Maximum)
            {
                this.Close();
            }
        }

        private void fmLoadConnect_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Stop();
        }
    }
}
