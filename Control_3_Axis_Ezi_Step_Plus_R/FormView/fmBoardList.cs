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

namespace Control_3_Axis_Ezi_Step_Plus_R.FormView
{
    public partial class fmBoardList : DevExpress.XtraEditors.XtraForm
    {
        byte _pType_ezi = 0;
        byte _pType_motor = 0;
        string _typeEzi = "";
        string _version = "";
        string _motor = "";
        public fmBoardList()
        {
            InitializeComponent();
        }

        private void fmBoardList_Load(object sender, EventArgs e)
        {
            if (VarGlobal.m_Connected)
            {
                for (byte i = 1; i <= 3; i++)
                {
                    int nRtn1 = EziMOTIONPlusRLib.FAS_GetSlaveInfo(VarGlobal.PortNo, i, ref _pType_ezi, ref _version);
                    int nRtn2 = EziMOTIONPlusRLib.FAS_GetMotorInfo(VarGlobal.PortNo, i, ref _pType_motor, ref _motor);
                    if (nRtn1 != EziMOTIONPlusRLib.FMM_OK)
                    {
                        string strMsg;
                        strMsg = "FAS_GetSlaveInfo() \nReturned: " + nRtn1.ToString();
                        MessageBox.Show(strMsg, "Function Failed");
                        return;
                    }
                    if (nRtn2 != EziMOTIONPlusRLib.FMM_OK)
                    {
                        string strMsg;
                        strMsg = "FAS_GetMotorInfo() \nReturned: " + nRtn2.ToString();
                        MessageBox.Show(strMsg, "Function Failed");
                        return;
                    }
                    switch (_pType_ezi)
                    {
                        case 1:
                            _typeEzi = "Ezi-SERVO Plus-R ST";
                            break;
                        case 20:
                            _typeEzi = "Ezi-STEP Plus-R ST";
                            break;
                        case 50:
                            _typeEzi = "Ezi- SERVO Plus-R MINI";
                            break;
                        default:
                            break;
                    }
                    ListViewItem lvi = new ListViewItem("Port " + VarGlobal.PortNo + " Slave No " + i);
                    lvi.SubItems.Add(_typeEzi);
                    lvi.SubItems.Add(_motor);
                    lvi.SubItems.Add(_version);
                    lviBoardList.Items.Add(lvi);
                }
            }
            else { MessageBox.Show("Not connect"); }
        }
    }
}
