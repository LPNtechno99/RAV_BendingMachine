using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FASTECH;
using Advantech.Adam;
using Advantech.Common;
using System.Windows.Forms;

namespace Control_3_Axis_Ezi_Step_Plus_R
{
    public class VarGlobal
    {
        public const byte iSLAVE_X = 1;
        public const byte iSLAVE_Y = 2;
        public const byte iSLAVE_Z = 3;
        
        public static byte demo; //Test github
        public string str = "Thu push len server github";

        private uint dwAxisStatus_x;
        private uint dwAxisStatus_y;
        private uint dwAxisStatus_z;

        public EziMOTIONPlusRLib.ITEM_NODE node_item_x = null;
        public EziMOTIONPlusRLib.ITEM_NODE node_item_y = null;
        public EziMOTIONPlusRLib.ITEM_NODE node_item_z = null;
        public VarGlobal()
        {
            node_item_x = new EziMOTIONPlusRLib.ITEM_NODE();
            node_item_y = new EziMOTIONPlusRLib.ITEM_NODE();
            node_item_z = new EziMOTIONPlusRLib.ITEM_NODE();
        }
        private static VarGlobal _instance;
        public static VarGlobal Instance()
        {
            if (_instance == null)
            {
                _instance = new VarGlobal();
            }
            return _instance;
        }

        public static AdamCom adamCom;
        public static Adam4000Config adamConfig;

        public static ushort Point { get; set; } //Point check
        public static byte PortNo { get; set; } //port ezi
        public static bool m_Connected { get; set; } //flag connect ezi
        public static int AdamCOM { get; set; } // port Adam
        public static int Adam_iAddr { get; set; }
        public static bool adam_Connected { get; set; }
        public static byte _3AxisReady { get; set; }

        //public static int position_pul_x;
        //public static int position_pul_y;
        //public static int position_pul_z;

        public static float position_mm_x; //for view X axis coordiate
        public static float position_mm_y; //for view Y axis coordiate
        public static float position_mm_z; //for view Z axis coordiate
        public static float measurementvalue; //for view measurement value

        public static float Z_coor_interpolate_pusle;

        //chọn chế độ hiển thị form
        public static int SELECT_FORM_SETTING;
        //Hằng số OFFSET khoảng cách giữa đầu đo và đầu bending 
        public const int OFFSET_CONVEX = 66017;
        public const int OFFSET_CONCAVE = 72647;
        //Vị trí trung gian của trục Z
        public const int POSITION_INTERMEDIATE_Z_AXIS = 33015;

        public static uint speedJOG_X;
        public static uint speedJOG_Y;
        public static uint speedJOG_Z;

        public uint dwAxisStatus;

        public void ResetAlarm()
        {
            if (VarGlobal.m_Connected == false)
                return;
            else
            {
                for (byte i = 1; i <= 3; i++)
                {
                    if (EziMOTIONPlusRLib.FAS_IsSlaveExist(VarGlobal.PortNo, i) != 0)
                    {
                        int nRnt_1 = EziMOTIONPlusRLib.FAS_GetAxisStatus(VarGlobal.PortNo, i, ref dwAxisStatus);
                        if (nRnt_1 != EziMOTIONPlusRLib.FMM_OK)
                        {
                            string strMsg;
                            strMsg = "FAS_GetAxisStatus() \nReturned: " + nRnt_1.ToString();
                            MessageBox.Show(strMsg, "Function Failed");
                        }
                        if ((dwAxisStatus & 0x00000001) != 0) //FFLAG_ERRORALL is ON
                        {
                            int nRtn = EziMOTIONPlusRLib.FAS_StepAlarmReset(VarGlobal.PortNo, i, 1);
                            if (nRtn != EziMOTIONPlusRLib.FMM_OK)
                            {
                                string strMsg;
                                strMsg = "FAS_ServoAlarmReset() \nReturned: " + nRtn.ToString();
                                MessageBox.Show(strMsg, "Function Failed");
                            }
                        }

                    }
                }
            }
        }
        /// <summary>
        /// Stop all axis motioning
        /// </summary>
        public void All_Move_Stop()
        {
            if (!VarGlobal.m_Connected)
            {
                MessageBox.Show("not connect");
                return;
            }
            int nRtn = EziMOTIONPlusRLib.FAS_AllMoveStop(VarGlobal.PortNo);
            if (nRtn != EziMOTIONPlusRLib.FMM_OK)
            {
                string strMsg;
                strMsg = "FAS_AllMoveStop() \nReturned: " + nRtn.ToString();
                MessageBox.Show(strMsg, "Function Failed");
            }

        }
        /// <summary>
        /// Move all axis with Abs Position
        /// </summary>
        /// <param name="x_pos_abs"></param>
        /// <param name="y_pos_abs"></param>
        public void Move_All_Axis_Abs_Pos(int x_pos_abs, int y_pos_abs)
        {
            if (VarGlobal.m_Connected == false)
                return;
            else
            {
                int nRtn_1 = EziMOTIONPlusRLib.FAS_MoveSingleAxisAbsPos(VarGlobal.PortNo, VarGlobal.iSLAVE_X, x_pos_abs, VarGlobal.speedJOG_X);
                if (nRtn_1 != EziMOTIONPlusRLib.FMM_OK)
                {
                    string strMsg;
                    strMsg = "FAS_MoveSingleAxisAbsPos() \nReturned: " + nRtn_1.ToString();
                    MessageBox.Show(strMsg, "Function Failed");
                }

                int nRtn_2 = EziMOTIONPlusRLib.FAS_MoveSingleAxisAbsPos(VarGlobal.PortNo, VarGlobal.iSLAVE_Y, y_pos_abs, VarGlobal.speedJOG_Y);
                if (nRtn_2 != EziMOTIONPlusRLib.FMM_OK)
                {
                    string strMsg;
                    strMsg = "FAS_MoveSingleAxisAbsPos() \nReturned: " + nRtn_2.ToString();
                    MessageBox.Show(strMsg, "Function Failed");
                }
            }
            do
            {
                int nRtn_3 = EziMOTIONPlusRLib.FAS_GetAxisStatus(VarGlobal.PortNo, VarGlobal.iSLAVE_X, ref dwAxisStatus_x);
                int nRtn_4 = EziMOTIONPlusRLib.FAS_GetAxisStatus(VarGlobal.PortNo, VarGlobal.iSLAVE_Y, ref dwAxisStatus_y);

                if (nRtn_3 != EziMOTIONPlusRLib.FMM_OK || nRtn_4 != EziMOTIONPlusRLib.FMM_OK)
                {
                    string strMsg;
                    strMsg = "FAS_GetAxisStatus() \nReturned: " + nRtn_3.ToString() + nRtn_4.ToString();
                    MessageBox.Show(strMsg, "Function Failed");
                    return;
                }

                if ((dwAxisStatus_x & 0x00000001) == 1 || (dwAxisStatus_y & 0x00000001) == 1)  // FFLAG_ERRORALL is ON
                {
                    string strMsg;
                    strMsg = "Error flag";
                    MessageBox.Show(strMsg, "AxisStatus");
                    return;
                }
            }
            while ((dwAxisStatus_x & 0x08000000) != 0 || (dwAxisStatus_y & 0x08000000) != 0);  // FFLAG_MOTIONING is ON
        }
        /// <summary>
        /// Move Z axis with Abs position
        /// </summary>
        /// <param name="z_pos_abs"></param>
        public bool Move_Z_Axis_Abs_Pos(int z_pos_abs)
        {
            if (VarGlobal.m_Connected == false)
                MessageBox.Show("Not Connect");
            int nRtn_1 = EziMOTIONPlusRLib.FAS_MoveSingleAxisAbsPos(VarGlobal.PortNo, VarGlobal.iSLAVE_Z, z_pos_abs, VarGlobal.speedJOG_Z);
            do
            {
                int nRtn = EziMOTIONPlusRLib.FAS_GetAxisStatus(VarGlobal.PortNo, VarGlobal.iSLAVE_Z, ref dwAxisStatus_z);
                if (nRtn != EziMOTIONPlusRLib.FMM_OK)
                {
                    string strMsg;
                    strMsg = "FAS_GetAxisStatus() \nReturned: " + nRtn.ToString();
                    MessageBox.Show(strMsg, "Function Failed");
                    return false;
                }
                if ((dwAxisStatus_z & 0x00000001) == 1)  // FFLAG_ERRORALL is ON
                {
                    string strMsg;
                    strMsg = "Error flag";
                    MessageBox.Show(strMsg, "AxisStatus");
                    return false;
                }
            }
            while ((dwAxisStatus_z & 0x08000000) != 0);
            if (nRtn_1 != EziMOTIONPlusRLib.FMM_OK)
            {
                string strMsg;
                strMsg = "FAS_MoveSingleAxisAbsPos() \nReturned: " + nRtn_1.ToString();
                MessageBox.Show(strMsg, "Function Failed");
                return false;
            }
            else
                return true;
        }
        /// <summary>
        /// ALl axis return Origin
        /// </summary>
        public void Move_All_Axis_Origin()
        {
            int nRtn = EziMOTIONPlusRLib.FAS_AllMoveOriginSingleAxis(VarGlobal.PortNo);
            if (nRtn != EziMOTIONPlusRLib.FMM_OK)
            {
                string strMsg;
                strMsg = "FAS_AllMoveOriginSingleAxis() \nReturned: " + nRtn.ToString();
                MessageBox.Show(strMsg, "Function Failed");
            }
            do
            {
                int nRtn_3 = EziMOTIONPlusRLib.FAS_GetAxisStatus(VarGlobal.PortNo, VarGlobal.iSLAVE_X, ref dwAxisStatus_x);
                int nRtn_4 = EziMOTIONPlusRLib.FAS_GetAxisStatus(VarGlobal.PortNo, VarGlobal.iSLAVE_Y, ref dwAxisStatus_y);
                int nRtn_5 = EziMOTIONPlusRLib.FAS_GetAxisStatus(VarGlobal.PortNo, VarGlobal.iSLAVE_Z, ref dwAxisStatus_z);

                if (nRtn_3 != EziMOTIONPlusRLib.FMM_OK || nRtn_4 != EziMOTIONPlusRLib.FMM_OK || nRtn_5 != EziMOTIONPlusRLib.FMM_OK)
                {
                    string strMsg;
                    strMsg = "FAS_GetAxisStatus() \nReturned: " + nRtn_3.ToString() + nRtn_4.ToString() + nRtn_5.ToString();
                    MessageBox.Show(strMsg, "Function Failed");
                    return;
                }

                if ((dwAxisStatus_x & 0x00000001) == 1 || (dwAxisStatus_y & 0x00000001) == 1 || (dwAxisStatus_z & 0x00000001) == 1)  // FFLAG_ERRORALL is ON
                {
                    string strMsg;
                    strMsg = "Error flag";
                    MessageBox.Show(strMsg, "AxisStatus");
                    return;
                }
            }
            while ((dwAxisStatus_x & 0x08000000) != 0 || (dwAxisStatus_y & 0x08000000) != 0 || (dwAxisStatus_z & 0x08000000) != 0);  // FFLAG_MOTIONING is ON
        }
        public static void Reset()
        {
            m_Connected = false;
            adam_Connected = false;
        }
    }
}
