using MantraBioTimeDLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MantraBioTimeSDK
{
    public partial class FrmPushData : Form
    {
        private MantraBioTimeSDK _MantraBioTimeSDK;
        public FrmPushData(MantraBioTimeSDK _Parent)
        {
            InitializeComponent();
            _MantraBioTimeSDK = _Parent;
            MantraBioTimePush.sayHello += sayHello;
            MantraBioTimePush.OnLogData += OnLogDataHandler;
        }

        bool OnLogDataHandler(string MachineNo, int DeviceType, string UserId, string VerifyType, string VerifyMode, string VDateTime, string SerNo)
        {
            try
            {
                ListViewItem item = new ListViewItem(MachineNo);
                item.SubItems.Add(DeviceType.ToString());
                item.SubItems.Add(UserId);
                item.SubItems.Add(VerifyType);
                item.SubItems.Add(VerifyMode);
                item.SubItems.Add(VDateTime);
                item.SubItems.Add(SerNo);

                if (lvAttLog.InvokeRequired)
                {
                    lvAttLog.Invoke((MethodInvoker)delegate()
                    {
                        lvAttLog.Items.Add(item);
                        lvAttLog.EnsureVisible(lvAttLog.Items.Count - 1);
                    });
                }
                else
                {
                    lvAttLog.Items.Add(item);
                }

                // if Get DeviceId Is Zero Than Use For SerialNo(SerNo) Unique For Device
                SqliteDB.SaveToLogData1(MachineNo, DeviceType, UserId, VerifyType, VerifyMode, VDateTime);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        void sayHello(string DeviceId)
        {
 
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                bool Ret = MantraBioTimePush.PortRunning(clsGlobal.DeviceType);
                if (Ret)
                {
                    MantraBioTimeSDK.theForm.EventLogs.Items.Add("Already listening on port(" + txtPort.Text + ").");
                }
                
                bool FlgPort = false;
                FlgPort = MantraBioTimePush.ListenerToDevice(clsGlobal.DeviceType, txtIP.Text, txtPort.Text);
                if (FlgPort)
                {
                    this.btnStart.Text = "Stop Listening";
                    MantraBioTimeSDK.theForm.EventLogs.Items.Add("Start Listener Successfully!");
                }
                else
                {                   
                    this.btnStart.Text = "Start Listening";
                    MantraBioTimeSDK.theForm.EventLogs.Items.Add("Stop Listener Successfully!");
                }
              
                MantraBioTimeSDK.theForm.EventLogs.TopIndex = MantraBioTimeSDK.theForm.EventLogs.Items.Count - 1;
            }
            catch (Exception Ex)
            {
                MantraBioTimeSDK.theForm.ErrorLogs.Items.Add(Ex.Message);
                MantraBioTimeSDK.theForm.ErrorLogs.TopIndex = MantraBioTimeSDK.theForm.ErrorLogs.Items.Count - 1;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lvAttLog.Items.Clear();
        }
    }
}
