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
using Advantech.Common;
using Advantech.Adam;
using System.Threading;

namespace Control_3_Axis_Ezi_Step_Plus_R.FormMotion
{
    public partial class fmMotionGraphics : DevExpress.XtraEditors.XtraForm
    {
        public delegate void mDelegate();
        public event mDelegate CheckDone;

        Thread _threadRUN;
        Thread _Show_Coordinate;

        int x_pos_abs = 0;
        int y_pos_abs = 0;
        int z_pos_abs = 0;

        Graphics gp = null;
        Pen mPen = new Pen(Color.Black, 2);
        Brush _Brush = new SolidBrush(Color.Black);
        Brush mBrush = new SolidBrush(Color.Red);

        List<int> lstPointFail = new List<int>(); //list points error measurement distance (points: deltaL < -0.07 & deltaL > 0.07)

        float[] _arrMeasureValueTemplate = new float[24];
        float[] _arrValueDeltaLFail = new float[24];

        //int[] _arrValueInterpolate = new int[24];

        uint _CountFail;
        int _countProcess;

        System.Windows.Forms.Timer timeProcess = new System.Windows.Forms.Timer();

        public fmMotionGraphics()
        {
            InitializeComponent();

            CheckDone += FmMotionGraphics_CheckDone;

            timeProcess.Interval = 200;
            timeProcess.Tick += TimeProcess_Tick;

            _Show_Coordinate = new Thread(ShowCoordinate);
            _Show_Coordinate.IsBackground = true;
            _Show_Coordinate.Start();
        }

        private void TimeProcess_Tick(object sender, EventArgs e)
        {
            _countProcess += 1;
            if (_countProcess > 8) _countProcess = 0;
            lblProcess.Text = "";
            //lblProcess.ForeColor = Color.Red;
            for (int i = 0; i < _countProcess; i++)
            {
                lblProcess.Text += ".";
            }
        }

        private void FmMotionGraphics_CheckDone()
        {
            _threadRUN.Abort();
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
            //gp.DrawString(distance, new Font("Arial", 8), _Brush, coor_x * 3, coor_y * 3 + 20);
            gp.Dispose();
        }
        /// <summary>
        /// Run first
        /// </summary>
        private void Run_1()
        {
            if (VarGlobal.m_Connected == false)
            {
                MessageBox.Show("No Connection!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Chạy trục Z đến vị trí đo
            z_pos_abs = Coordinates.Zcoordinate.Instance().z_coor[0];
            if (!VarGlobal.Instance().Move_Z_Axis_Abs_Pos(z_pos_abs))
                return;

            //Vẽ 1 hình chữ nhật tượng trưng
            gp = this.pnGraphics.CreateGraphics();
            gp.DrawRectangle(mPen, 65, 25, 230, 380);

            _CountFail = 0;

            for (int point = 1; point < 25; point++)
            {
                //Lấy tọa độ tuyệt đối lần lượt của 24 điểm
                x_pos_abs = Coordinates.Xcoordinate.Instance().x_coor[point - 1];
                y_pos_abs = Coordinates.Ycoordinate.Instance().y_coor[point - 1];

                //Chạy tới điểm tương ứng
                VarGlobal.Instance().Move_All_Axis_Abs_Pos(x_pos_abs, y_pos_abs);
                Thread.Sleep(500);

                Invoke(new MethodInvoker(delegate
                {
                    lblStatus.Text = "Measuring";
                    lblStatus.ForeColor = Color.LimeGreen;
                    lblProcess.ForeColor = Color.LimeGreen;
                    timeProcess.Start();
                }));

                float height = 0;
                if (VarGlobal.adam_Connected)
                {
                    if (VarGlobal.adamCom.AnalogInput(VarGlobal.Adam_iAddr).GetValue(5, out float value, out Adam4000_ChannelStatus status))
                    {
                        if (status == Adam4000_ChannelStatus.Normal)
                        {
                            height = value * (float)6.0714;

                            float deltaL = height - _arrMeasureValueTemplate[point - 1];

                            if (deltaL > 0.07)
                            {

                                lstPointFail.Add(point - 1);
                                _arrValueDeltaLFail[point - 1] = deltaL;
                                _CountFail++;
                                mBrush = new SolidBrush(Color.Red);

                                Invoke(new MethodInvoker(delegate
                                {
                                    ListViewItem lvi = new ListViewItem("Point " + point);
                                    lvi.SubItems.Add(height.ToString("0.0000"));
                                    lvi.SubItems.Add(deltaL.ToString("0.0000"));
                                    lvi.BackColor = Color.Red;
                                    lviPointMeasurement.Items.Add(lvi);
                                }));

                            }
                            if (deltaL < -0.07)
                            {

                                lstPointFail.Add(point - 1);
                                _arrValueDeltaLFail[point - 1] = deltaL;
                                _CountFail++;
                                mBrush = new SolidBrush(Color.Yellow);

                                Invoke(new MethodInvoker(delegate
                                {
                                    ListViewItem lvi = new ListViewItem("Point " + point);
                                    lvi.SubItems.Add(height.ToString("0.0000"));
                                    lvi.SubItems.Add(deltaL.ToString("0.0000"));
                                    lvi.BackColor = Color.Yellow;
                                    lviPointMeasurement.Items.Add(lvi);
                                }));

                            }
                            else if (deltaL < 0.07 && deltaL > -0.07)
                            {
                                mBrush = new SolidBrush(Color.LimeGreen);
                                Invoke(new MethodInvoker(delegate
                                {
                                    ListViewItem lvi = new ListViewItem("Point " + point);
                                    lvi.SubItems.Add(height.ToString("0.000"));
                                    lvi.SubItems.Add(deltaL.ToString("0.0000"));
                                    lvi.BackColor = Color.LimeGreen;
                                    lviPointMeasurement.Items.Add(lvi);
                                }));
                            }

                            float x_pos_mm = Calculate.Calculate_Coordinate_mm(x_pos_abs, Calculate.STEP_X);
                            float y_pos_mm = Calculate.Calculate_Coordinate_mm(y_pos_abs, Calculate.STEP_Y);
                            DrawPoint(x_pos_mm, y_pos_mm, point);
                        }
                        else MessageBox.Show("Fail to get Value");
                    }
                    else MessageBox.Show("Fail to get Value");
                }
                Thread.Sleep(1000);
            }
        }
        private async Task Wait1s()
        {
            await Task.Delay(1000);
        }
        /// <summary>
        /// Process Run
        /// </summary>
        private void Running()
        {
            Run_1();
            try
            {
                if (!VarGlobal.Instance().Move_Z_Axis_Abs_Pos(VarGlobal.POSITION_INTERMEDIATE_Z_AXIS))
                    return;
                while (_CountFail > 0)
                {
                    pnGraphics.Invalidate();

                    foreach (int point in lstPointFail)
                    {
                        Invoke(new MethodInvoker(delegate
                        {
                            lblStatus.Text = "Is Bending";
                            lblStatus.ForeColor = Color.Purple;
                            lblProcess.ForeColor = Color.Purple;
                        }));
                        float temp = 0;
                        if (_arrValueDeltaLFail[point] > 0.07)
                        {
                            x_pos_abs = Coordinates.Xcoordinate.Instance().x_coor[point];
                            y_pos_abs = Coordinates.Ycoordinate.Instance().y_coor[point] - VarGlobal.OFFSET_CONVEX;

                            //lấy tọa độ trục Z bending lồi

                            Calculate.Instance().Delta_L = _arrValueDeltaLFail[point]; //set giá trị cho _deltaL
                            //nội suy tính toán giá trị bending lồi
                            temp = Calculate.Instance().Calculate_Interpolate_Value((point + 1));
                            int bendingValue = Calculate.Calculate_Coordinate_pulse(temp, Calculate.STEP_Z);

                            //Láy giá trị mặc định trục Z
                            string[] arr = SQLite.Instance().GetZCoorBending(point + 1);
                            int Z_default = Calculate.Calculate_Coordinate_pulse(float.Parse(arr[0]), Calculate.STEP_Z);

                            z_pos_abs = Z_default + bendingValue;
                            if (z_pos_abs < 0)
                            {
                                z_pos_abs = 0;
                                MessageBox.Show("error is too big!\nCannot Bending!");
                            }
                        }
                        if (_arrValueDeltaLFail[point] < -0.07)
                        {
                            x_pos_abs = Coordinates.Xcoordinate.Instance().x_coor[point];
                            y_pos_abs = Coordinates.Ycoordinate.Instance().y_coor[point] - VarGlobal.OFFSET_CONCAVE;

                            //lấy tọa độ trục Z bending lõm

                            Calculate.Instance().Delta_L = Math.Abs(_arrValueDeltaLFail[point]); //set giá trị cho _deltaL
                            //nội suy tính toán giá trị bending lõm
                            temp = Calculate.Instance().Calculate_Interpolate_Value((point + 1));
                            int bendingValue = Calculate.Calculate_Coordinate_pulse(temp, Calculate.STEP_Z);

                            //lấy giá trị mặc định trục Z
                            string[] arr = SQLite.Instance().GetZCoorBending(point + 1);
                            int Z_default = Calculate.Calculate_Coordinate_pulse(float.Parse(arr[1]), Calculate.STEP_Z);

                            z_pos_abs = Z_default + bendingValue;
                            if (z_pos_abs < 0)
                            {
                                z_pos_abs = 0;
                                MessageBox.Show("error is too big!\nCannot Bending!");
                            }
                        }

                        VarGlobal.Instance().Move_All_Axis_Abs_Pos(x_pos_abs, y_pos_abs);
                            
                        Thread.Sleep(1000);
                        if (!VarGlobal.Instance().Move_Z_Axis_Abs_Pos(z_pos_abs))
                            return;
                        
                        mBrush = new SolidBrush(Color.Purple);
                        float x_pos_mm = Calculate.Calculate_Coordinate_mm(x_pos_abs, Calculate.STEP_X);
                        float y_pos_mm = Calculate.Calculate_Coordinate_mm(y_pos_abs, Calculate.STEP_Y);
                        DrawPoint(x_pos_mm, y_pos_mm, point + 1);

                        //gp.DrawString(temp.ToString("0.0000") + " mm", new Font("Arial", 8), _Brush, x_pos_mm * (float)1.45,
                        //    y_pos_mm * (float)1.75 - 10);
                        Thread.Sleep(1000);

                        if (!VarGlobal.Instance().Move_Z_Axis_Abs_Pos(VarGlobal.POSITION_INTERMEDIATE_Z_AXIS))
                            return;
                        Thread.Sleep(1000);
                    }

                    Array.Clear(_arrValueDeltaLFail, 0, _arrValueDeltaLFail.Length);
                    lstPointFail.Clear();
                    Invoke(new MethodInvoker(delegate
                    {
                        pnGraphics.Invalidate();
                        lviPointMeasurement.Items.Clear();
                    }));

                    Thread.Sleep(1000);
                    // chạy lại lần nữa để kiểm tra xem đã đúng chưa, nếu đúng thì thoát vòng lăp while
                    Run_1();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                VarGlobal.Instance().All_Move_Stop();
            }
            Thread.Sleep(1000);
            z_pos_abs = Coordinates.Zcoordinate.Instance().z_coor[0];
            if (!VarGlobal.Instance().Move_Z_Axis_Abs_Pos(z_pos_abs))
                return;
            _CountFail = 0;

            Invoke(new MethodInvoker(delegate
            {
                lblStatus.Text = "Done!";
                lblProcess.Text = "";
                lblStatus.ForeColor = Color.LimeGreen;
                timeProcess.Stop();
                if (CheckDone != null)
                {
                    CheckDone();
                }
            }));
            
        }
        /// <summary>
        /// Get measurement value and points coordinate bending TEMPLATE
        /// </summary>
        private void GetMeasureValue_CoorBending_Template()
        {
            if (!SQLite.Instance().CheckExistData("T24DefaultPointMeasurement", 1))
                return;
            if (!SQLite.Instance().CheckExistData("MeasureValueTemplate", 1))
                return;

            string[] arr = new string[3];

            for (int i = 1; i <= 24; i++)
            {
                //load measurement value template
                _arrMeasureValueTemplate[i - 1] = float.Parse(SQLite.Instance().GetMeasureValueTemplate
                    ("MeasureValueTemplate", "Value", i));

                //load default coordinate
                arr = SQLite.Instance().GetPointsCoordinate("T24DefaultPointMeasurement", i, "Xcoor", "Ycoor", "Zcoor");
                Coordinates.Xcoordinate.Instance().x_coor[i - 1] =
                    Calculate.Calculate_Coordinate_pulse(float.Parse(arr[0]), Calculate.STEP_X);
                Coordinates.Ycoordinate.Instance().y_coor[i - 1] =
                    Calculate.Calculate_Coordinate_pulse(float.Parse(arr[1]), Calculate.STEP_Y);
                Coordinates.Zcoordinate.Instance().z_coor[i - 1] =
                    Calculate.Calculate_Coordinate_pulse(float.Parse(arr[2]), Calculate.STEP_Z);
            }
        }
        private void fmMotionGraphics_Load(object sender, EventArgs e)
        {
            GetMeasureValue_CoorBending_Template();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            pnGraphics.Invalidate();
            lviPointMeasurement.Items.Clear();
            lblStatus.Text = "...";
            lblProcess.Text = "";

            _threadRUN = new Thread(Running);
            _threadRUN.IsBackground = true;
            _threadRUN.Start();
        }

        private void fmMotionGraphics_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                VarGlobal.Instance().All_Move_Stop();
                _threadRUN.Abort();
                timeProcess.Stop();
                _Show_Coordinate.Abort();
            }
           catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fmMotionGraphics_FormClosed(object sender, FormClosedEventArgs e)
        {
            _threadRUN.Abort();
            _Show_Coordinate.Abort();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            VarGlobal.Instance().All_Move_Stop();
            lviPointMeasurement.Items.Clear();
            pnGraphics.Invalidate();
            lstPointFail.Clear();
            Array.Clear(_arrValueDeltaLFail, 0, _arrValueDeltaLFail.Length);
            timeProcess.Stop();
            lblProcess.Text = "";
            lblStatus.Text = "STOPPING!";
            lblStatus.ForeColor = Color.Red;

            _threadRUN.Abort();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        //private void pnGraphics_Paint(object sender, PaintEventArgs e)
        //{
        //Graphics gp = e.Graphics;
        //Pen mPen = new Pen(Color.Black, 2);
        //Brush _Brush = new SolidBrush(Color.Black);
        //Brush mBrush = new SolidBrush(Color.Red);
        //if (_flag)
        //{
        //    Rectangle rec = new Rectangle(new Point(10, 10), new Size(310, 590));
        //    gp.DrawRectangle(mPen, rec);
        //    _flag = false;
        //}
        //Rectangle rec = new Rectangle(new Point(10, 10), new Size(310, 590));
        //gp.DrawRectangle(mPen, rec);

        //gp.FillEllipse(mBrush, (float)77.541 * 3, (float)172.537 * 3, 10, 10);
        //gp.DrawString("Point 1", new Font("Arial", 10), _Brush, (float)77.541 * 3 + 10, (float)172.537 * 3);
        //gp.DrawString("(36.456 mm)", new Font("Arial", 8), _Brush, (float)77.541 * 3, (float)172.537 * 3 + 20);

        //gp.FillEllipse(myBrush, (float)42.883 * 3, (float)172.343 * 3, 10, 10);
        //gp.DrawString("Point 2", new Font("Arial", 10), _brushPoint, (float)42.883 * 3 + 10, (float)172.343 * 3);

        //gp.FillEllipse(myBrush, (float)18.423 * 3, (float)159.679 * 3, 10, 10);
        //gp.DrawString("Point 3", new Font("Arial", 10), _brushPoint, (float)18.423 * 3 + 10, (float)159.679 * 3);

        //gp.FillEllipse(myBrush, (float)49.382 * 3, (float)144.123 * 3, 10, 10);
        //gp.DrawString("Point 4", new Font("Arial", 10), _brushPoint, (float)49.382 * 3 + 10, (float)144.123 * 3);

        //gp.FillEllipse(myBrush, (float)59.882 * 3, (float)127.500 * 3, 10, 10);
        //gp.DrawString("Point 5", new Font("Arial", 10), _brushPoint, (float)59.882 * 3 + 10, (float)127.500 * 3);

        //gp.FillEllipse(myBrush, (float)20.784 * 3, (float)128.742 * 3, 10, 10);
        //gp.DrawString("Point 6", new Font("Arial", 10), _brushPoint, (float)20.784 * 3 + 10, (float)128.742 * 3);

        //gp.FillEllipse(myBrush, (float)47.679 * 3, (float)108.144 * 3, 10, 10);
        //gp.DrawString("Point 7", new Font("Arial", 10), _brushPoint, (float)47.679 * 3 + 10, (float)108.144 * 3);
        //}

    }
}
