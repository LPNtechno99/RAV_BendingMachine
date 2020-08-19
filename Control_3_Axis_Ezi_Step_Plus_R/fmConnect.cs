using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FASTECH;
using System.Threading;

namespace Control_3_Axis_Ezi_Step_Plus_R
{
    public partial class fmConnect : DevExpress.XtraEditors.XtraForm
    {
        uint dwAxisStatus = 0;
        public enum CheckConnection
        {
            success,
            fail
        }

        byte _portNo;
        uint dwBaud;
        bool _mConnected;

        int _adamCOM;
        int _count = 10;
        fmLoadConnect frm = null;

        public delegate void deConn(CheckConnection e);
        public event deConn SuccessConnect;

        public fmConnect()
        {
            InitializeComponent();
            _portNo = 0;
            _adamCOM = 0;
            _mConnected = false;

            frm = new fmLoadConnect();

        }


        private void fmConnect_Load(object sender, EventArgs e)
        {
            UpdateSerialPortList();
            comboBaudrate.SelectedIndex = 4; //default 11500

        }
        private void UpdateSerialPortList()
        {
            comboBoxPortNo.Items.Clear();

            // Port No.
            string[] portlist = SerialPort.GetPortNames();

            List<int> PortNoList = new List<int>();

            foreach (string port in portlist)
                PortNoList.Add(int.Parse(port.Substring(3)));

            PortNoList.Sort();

            foreach (int portno in PortNoList)
            {
                comboBoxPortNo.Items.Add(string.Format("{0}", portno));
                comboBoxAdamCOM.Items.Add(string.Format("{0}", portno));
            }
            comboBoxPortNo.SelectedIndex = 1;
            comboBoxAdamCOM.SelectedIndex = 0;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            frm.Show();
            backgroundWorker1.RunWorkerAsync();
        }

        private void Frm_DoneProgressBar()
        {
            this.Close();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            var woker = sender as BackgroundWorker;

            Invoke(new MethodInvoker(delegate
            {
                if (comboBoxPortNo.Text.Length <= 0)
                {
                    comboBoxPortNo.Focus();
                    return;
                }
                if (comboBoxAdamCOM.Text.Length <= 0)
                {
                    comboBoxAdamCOM.Focus();
                    return;
                }
            }));

            //Connect ezi step plus R

            while (_mConnected == false)
            {

                Invoke(new MethodInvoker(delegate
                {

                    _portNo = byte.Parse(comboBoxPortNo.Text);
                    _adamCOM = int.Parse(comboBoxAdamCOM.Text);
                    dwBaud = uint.Parse(comboBaudrate.Text);
                }));

                if (EziMOTIONPlusRLib.FAS_Connect(_portNo, dwBaud) == 0)
                {
                    //error connect
                    //MessageBox.Show("Error Connect!");
                    if (SuccessConnect != null)
                    {
                        //VarGlobal._portNo = 0;
                        SuccessConnect(CheckConnection.fail);
                        this.Close();
                    }
                }
                else
                {
                    for (byte i = 1; i <= 3; i++)
                    {
                        if (EziMOTIONPlusRLib.FAS_IsSlaveExist(_portNo, i) != 0)
                        {
                            int nRnt_1 = EziMOTIONPlusRLib.FAS_GetAxisStatus(_portNo, i, ref dwAxisStatus);
                            if (nRnt_1 != EziMOTIONPlusRLib.FMM_OK)
                            {
                                string strMsg;
                                strMsg = "FAS_GetAxisStatus() \nReturned: " + nRnt_1.ToString();
                                MessageBox.Show(strMsg, "Function Failed");
                                return;
                            }
                            //reset alarm if there is alarm
                            if ((dwAxisStatus & 0x00000001) != 0) // FFLAG_ERRORALL is ON
                            {
                                int nRnt_2 = EziMOTIONPlusRLib.FAS_StepAlarmReset(_portNo, i, 1);
                                if (nRnt_2 != EziMOTIONPlusRLib.FMM_OK)
                                {
                                    string strMsg;
                                    strMsg = "FAS_ServoAlarmReset() \nReturned: " + nRnt_2.ToString();
                                    MessageBox.Show(strMsg, "Function Failed");
                                    return;
                                }
                            }
                            //all servo on
                            int nRnt_3 = EziMOTIONPlusRLib.FAS_ServoEnable(_portNo, i, 1);
                            if (nRnt_3 != EziMOTIONPlusRLib.FMM_OK)
                            {
                                string strMsg;
                                strMsg = "FAS_ServoEnable() \nReturned: " + nRnt_3.ToString();
                                MessageBox.Show(strMsg, "Function Failed");
                                return;
                            }
                        }
                        VarGlobal._3AxisReady += 1;
                    }
                    if (VarGlobal._3AxisReady >= 3)
                    {
                        _mConnected = true;
                        while (_count <= 100 && _mConnected == true)
                        {
                            Thread.Sleep(100);
                            woker.ReportProgress(_count);
                            _count += 10;
                        }
                    }
                    else
                        MessageBox.Show("Error occur!");
                }
            }
            if (SuccessConnect != null)
            {
                VarGlobal.PortNo = _portNo;
                VarGlobal.m_Connected = _mConnected;
                VarGlobal.AdamCOM = _adamCOM;
                SuccessConnect(CheckConnection.success);
            }

        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            frm.lblPercent.Text = e.ProgressPercentage + "%";
            frm.progressBar1.PerformStep();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            frm.progressBar1.Value = frm.progressBar1.Maximum;
            backgroundWorker1.CancelAsync();
            this.Close();
        }

        private void fmConnect_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
