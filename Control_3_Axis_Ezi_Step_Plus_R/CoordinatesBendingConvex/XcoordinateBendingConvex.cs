using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_3_Axis_Ezi_Step_Plus_R.Coordinates
{
    public class XcoordinateBendingConvex
    {
        private static XcoordinateBendingConvex _instance;
        public static XcoordinateBendingConvex Instance()
        {
            if(_instance==null)
            {
                _instance = new XcoordinateBendingConvex();
            }
            return _instance;
        }
        public int[] x_coor = new int[24];
        public int this[ushort index]
        {
            get
            {
                if (index >= 0 && index < 24)
                {
                    return x_coor[index];
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                x_coor[index] = value;
            }
        }

    }
}
