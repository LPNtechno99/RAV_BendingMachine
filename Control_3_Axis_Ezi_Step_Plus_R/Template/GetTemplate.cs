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

namespace Control_3_Axis_Ezi_Step_Plus_R.Template
{
    public partial class GetTemplate : DevExpress.XtraEditors.XtraForm
    {
        public delegate void _delegate(int point, float height);
        public event _delegate GetDoneTemp;

        System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer checkdone = new System.Windows.Forms.Timer();

        Dictionary<int, float> dicHeightPoint = new Dictionary<int, float>();
        double[] arrHeightPoint = new double[24];

        int _countProcess;
        bool _checkDone;

        int x_pos_abs = 0;
        int y_pos_abs = 0;
        int z_pos_abs = 0;

        Graphics gp = null;
        Pen mPen = new Pen(Color.Black, 2);
        Brush _Brush = new SolidBrush(Color.Black);
        Brush mBrush = new SolidBrush(Color.Red);

        public GetTemplate()
        {
            InitializeComponent();

            t.Interval = 200;
            t.Tick += T_Tick;

            checkdone.Interval = 1;
            checkdone.Tick += Checkdone_Tick;
            checkdone.Start();
        }

        private void Checkdone_Tick(object sender, EventArgs e)
        {

            tslPosX.Text = VarGlobal.position_mm_x.ToString("0.0000");
            tslPosY.Text = VarGlobal.position_mm_y.ToString("0.0000");
            tslPosZ.Text = VarGlobal.position_mm_z.ToString("0.0000");

            if (_checkDone)
                _thread.Abort();
        }

        private void T_Tick(object sender, EventArgs e)
        {
            _countProcess += 1;
            if (_countProcess > 8) _countProcess = 0;
            lblProcess.Text = "";
            lblProcess.ForeColor = Color.Red;
            for (int i = 0; i < _countProcess; i++)
            {
                lblProcess.Text += ".";
            }
        }

        void ShowCoordinate()
        {
            while (true)
            {
                tslPosX.Text = VarGlobal.position_mm_x.ToString("0.0000");
                tslPosY.Text = VarGlobal.position_mm_y.ToString("0.0000");
                tslPosZ.Text = VarGlobal.position_mm_z.ToString("0.0000");
            }
        }
        
        private void DrawPoint(float coor_x, float coor_y, int point)
        {
            gp = this.pnGraphics.CreateGraphics();

            gp.FillEllipse(mBrush, coor_x * (float)1.45, coor_y * (float)1.75, 10, 10);
            gp.DrawString(point + "", new Font("Arial", 6), _Brush, coor_x * (float)1.45 + 10, coor_y * (float)1.75);
            //gp.DrawString(distance, new Font("Arial", 10), _Brush, coor_x * 2, coor_y * 6 + 15);
            gp.Dispose();

        }

        string[] _arr = new string[2];
        private void GetTemplate_Load(object sender, EventArgs e)
        {
            if (!SQLite.Instance().CheckExistData("T24DefaultPointMeasurement", 1))
                return;
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
            }

        }
        bool _flag;
        void GetTemp()
        {
            if (VarGlobal.m_Connected == false)
            {
                MessageBox.Show("No Connection!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            VarGlobal.Instance().ResetAlarm();

            z_pos_abs = Coordinates.Zcoordinate.Instance().z_coor[0];
            if (!VarGlobal.Instance().Move_Z_Axis_Abs_Pos(z_pos_abs))
                return;

            gp = this.pnGraphics.CreateGraphics();
            gp.DrawRectangle(mPen, 60, 25, 230, 380);

            Invoke(new MethodInvoker(delegate
            {
                lblStatus.Text = "Getting data";
                lblStatus.ForeColor = Color.Red;
                t.Start();
            }));

            for (int point = 1; point < 25; point++)
            {
                x_pos_abs = Coordinates.Xcoordinate.Instance().x_coor[point - 1];
                y_pos_abs = Coordinates.Ycoordinate.Instance().y_coor[point - 1];

                VarGlobal.Instance().Move_All_Axis_Abs_Pos(x_pos_abs, y_pos_abs);
                Thread.Sleep(500);

                float height = 0;
                if (VarGlobal.adam_Connected)
                {
                    if (VarGlobal.adamCom.AnalogInput(VarGlobal.Adam_iAddr).GetValue(5, out float value, out Adam4000_ChannelStatus status))
                    {
                        if (status == Adam4000_ChannelStatus.Normal)
                        {
                            height = value * (float)6.0714;

                            dicHeightPoint.Add(point, height);

                            ListViewItem lvi = new ListViewItem("Point " + point);
                            lvi.SubItems.Add(height.ToString("0.0000" + " mm"));
                            lviPointMeasurement.Invoke((Action)(() =>
                            {
                                lviPointMeasurement.BeginUpdate();
                                lviPointMeasurement.Items.Add(lvi);
                                lviPointMeasurement.EndUpdate();
                            }));
                           // Invoke(new MethodInvoker(delegate
                           //{
                           //    lviPointMeasurement.Items.Add(lvi);
                           //}));
                            float x_pos_mm = Calculate.Calculate_Coordinate_mm(x_pos_abs, Calculate.STEP_X);
                            float y_pos_mm = Calculate.Calculate_Coordinate_mm(y_pos_abs, Calculate.STEP_Y);
                            DrawPoint(x_pos_mm, y_pos_mm, point);
                        }
                    }
                }
                if (SQLite.Instance().GetMeasureValueTemplate("MeasureValueTemplate", "Value", 1) != null)
                {
                    SQLite.Instance().UpdateMeasureValueTemplate(point, height.ToString("0.0000"));
                }
                else
                    SQLite.Instance().InsertData(point, "Point" + point, height.ToString("0.0000"));

                Thread.Sleep(1000);
            }
            _checkDone = true;
            Invoke(new MethodInvoker(delegate
            {
                lblStatus.Text = "Done!";
                lblProcess.Text = "";
                lblStatus.ForeColor = Color.Green;
                t.Stop();
            }));

            _flag = true;
        }

        Thread _thread;
        private void btnGetTemplate_Click(object sender, EventArgs e)
        {
            _flag = false;
            _checkDone = false;

            lviPointMeasurement.Items.Clear();
            pnGraphics.Invalidate();

            if (!_flag)
            {
                _thread = new Thread(GetTemp);
                _thread.IsBackground = true;
                _thread.Start();
            }
            else
                _thread.Abort();
        }
        private void GetTemplate_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                checkdone.Stop();
                VarGlobal.Instance().All_Move_Stop();
                _thread.Abort();
                t.Stop();

                if (GetDoneTemp != null)
                {
                    foreach (KeyValuePair<int, float> value in dicHeightPoint)
                    {
                        GetDoneTemp(value.Key, value.Value);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GetTemplate_FormClosed(object sender, FormClosedEventArgs e)
        {
            _thread.Abort();
        }
    }
}
