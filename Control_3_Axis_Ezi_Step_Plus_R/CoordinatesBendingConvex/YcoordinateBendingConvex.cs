using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_3_Axis_Ezi_Step_Plus_R.Coordinates
{
    public class YcoordinateBendingConvex
    {
        private static YcoordinateBendingConvex _instance;
        public static YcoordinateBendingConvex Instance()
        {
            if (_instance == null)
            {
                _instance = new YcoordinateBendingConvex();
            }
            return _instance;
        }
        public int[] y_coor = new int[24];
        public int this[ushort index]
        {
            get
            {
                if (index >= 0 && index < 24)
                {
                    return y_coor[index];
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                y_coor[index] = value;
            }
        }

    }
}
