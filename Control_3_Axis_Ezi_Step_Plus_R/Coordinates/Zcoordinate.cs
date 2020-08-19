using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_3_Axis_Ezi_Step_Plus_R.Coordinates
{
    public class Zcoordinate
    {
        private static Zcoordinate _instance;
        public static Zcoordinate Instance()
        {
            if (_instance == null)
            {
                _instance = new Zcoordinate();
            }
            return _instance;
        }
        public int[] z_coor = new int[24];
        public int this[ushort index]
        {
            get
            {
                if (index >= 0 && index < 24)
                {
                    return z_coor[index];
                }
                else
                    return 0;
            }
            set
            {
                z_coor[index] = value;
            }
        }
    }
}
