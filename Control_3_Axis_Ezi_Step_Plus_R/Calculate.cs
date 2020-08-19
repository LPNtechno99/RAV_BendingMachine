using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_3_Axis_Ezi_Step_Plus_R
{
    public class Calculate
    {
        public Calculate()
        {

        }
        private static Calculate _instance;
        public static Calculate Instance()
        {
            if (_instance == null)
            {
                _instance = new Calculate();
            }
            return _instance;
        }

        public const int STEP_X = 10; //step vitme of X axis
        public const int STEP_Y = 5; //step vitme of Y axis
        public const int STEP_Z = 10; //step vitme of Z axis
        public const int PULSE_PER_REVOLUTION = 10000; //pulse recevied when motor have been 1 rotate 

        public static int CommandPosX; //abs position of X axis (calculate equal pulse)
        public static int CommandPosY; //abs position of Y axis (calculate equal pulse)
        public static int CommandPosZ; //abs position of Z axis (calculate equal pulse)

        private float _deltaL; //subtraction between measurement value with template value
        public float Delta_L
        {
            get
            {
                return _deltaL;
            }
            set
            {
                _deltaL = value;
            }
        }
        private float _interpolatevalue;
        public float InterpolateValue
        {
            get
            {
                return _interpolatevalue;
            }
            set
            {
                _interpolatevalue = value;
            }
        }

        /// <summary>
        /// Hàm tính toán giá trị nội suy
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public float Calculate_Interpolate_Value(int id)
        {
            float[] hs = new float[3];
            
            if(!SQLite.Instance().CheckNullData("HS_A,HS_B,HS_C", "HeSoPhuongTrinh",id))
            {
                hs = SQLite.Instance().Get_Default_Coefficient("HeSoPhuongTrinh", id);
            }
            else
            {
                MessageBox.Show("null data!");
            }
            _interpolatevalue = hs[0] + hs[1] * _deltaL + hs[2] * _deltaL * _deltaL;

            return _interpolatevalue;
        }

        /// <summary>
        /// Convert pulse -> mm
        /// </summary>
        /// <param name="cmdPos"></param>
        /// <param name="step"></param>
        /// <returns></returns>
        public static float Calculate_Coordinate_mm(int cmdPos, int step)
        {
            float pos_x_mm = ((float)cmdPos / PULSE_PER_REVOLUTION) * step;
            return pos_x_mm;
        }
        /// <summary>
        /// Convert mm -> pulse
        /// </summary>
        /// <param name="mmPos"></param>
        /// <param name="step"></param>
        /// <returns></returns>
        public static int Calculate_Coordinate_pulse(float mmPos, int step)
        {
            int position_pul = (int)((mmPos / step) * PULSE_PER_REVOLUTION);
            return position_pul;
        }
    }
}
