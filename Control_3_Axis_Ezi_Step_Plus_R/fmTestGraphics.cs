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
    public partial class fmTestGraphics : Form
    {
        public fmTestGraphics()
        {
            InitializeComponent();
            this.Height = 600;
            this.Width = 330;
        }

        private void fmTestGraphics_Load(object sender, EventArgs e)
        {

        }

        private void fmTestGraphics_Paint(object sender, PaintEventArgs e)
        {
            Graphics gp = e.Graphics;
            Pen myPen = new Pen(Color.Black);
            myPen.Width = 2;
            Brush myBrush = new SolidBrush(Color.Red);
            Brush _brushPoint = new SolidBrush(Color.Black);
            //gp.DrawRectangle(myPen, 0, 0, 310, 590);
            //PointF[] po = 
            //{
            //    new PointF((float)77.541*2,(float)172.537*2),
            //    new PointF((float)42.883*2,(float)172.343*2),
            //    new PointF((float)18.423*2,(float)159.679*2),
            //    new PointF((float)49.382*2,(float)144.123*2),
            //    new PointF((float)59.882*2,(float)127.500*2),
            //    new PointF((float)20.784*2,(float)128.742*2),
            //    new PointF((float)47.679*2,(float)108.144*2),
            //};
            //gp.DrawLines(myPen,po);
            gp.FillEllipse(myBrush, (float)77.541 * 3, (float)172.537 * 3, 10, 10);
            gp.DrawString("Point 1", new Font("Arial", 10), _brushPoint, (float)77.541 * 3 + 10, (float)172.537 * 3);

            gp.FillEllipse(myBrush, (float)42.883 * 3, (float)172.343 * 3, 10, 10);
            gp.DrawString("Point 2", new Font("Arial", 10), _brushPoint, (float)42.883 * 3 + 10, (float)172.343 * 3);

            gp.FillEllipse(myBrush, (float)18.423 * 3, (float)159.679 * 3, 10, 10);
            gp.DrawString("Point 3", new Font("Arial", 10), _brushPoint, (float)18.423 * 3 + 10, (float)159.679 * 3);

            gp.FillEllipse(myBrush, (float)49.382 * 3, (float)144.123 * 3, 10, 10);
            gp.DrawString("Point 4", new Font("Arial", 10), _brushPoint, (float)49.382 * 3 + 10, (float)144.123 * 3);

            gp.FillEllipse(myBrush, (float)59.882 * 3, (float)127.500 * 3, 10, 10);
            gp.DrawString("Point 5", new Font("Arial", 10), _brushPoint, (float)59.882 * 3 + 10, (float)127.500 * 3);

            gp.FillEllipse(myBrush, (float)20.784 * 3, (float)128.742 * 3, 10, 10);
            gp.DrawString("Point 6", new Font("Arial", 10), _brushPoint, (float)20.784 * 3 + 10, (float)128.742 * 3);

            gp.FillEllipse(myBrush, (float)47.679 * 3, (float)108.144 * 3, 10, 10);
            gp.DrawString("Point 7", new Font("Arial", 10), _brushPoint, (float)47.679 * 3 + 10, (float)108.144 * 3);
            //string x = gp.DpiX.ToString();
            //string y = gp.DpiY.ToString();
            //MessageBox.Show("x = " + x + "; y = " + y);
        }
    }
}
