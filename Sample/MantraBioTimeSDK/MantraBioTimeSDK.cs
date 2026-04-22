using MantraBioTimeDLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MantraBioTimeSDK
{
    public partial class MantraBioTimeSDK : Form
    {
        #region "Declare Class For Common"

        public delegate void delegateAppendMessage(string message);
        public delegateAppendMessage theDelegateAppendMessage;
        public static MantraBioTimeSDK theForm;	// Global form object

        #endregion
                
        #region "Default Constructor"

        public MantraBioTimeSDK()
        {
            InitializeComponent();

            // Initialize objects
            theDelegateAppendMessage = new delegateAppendMessage(AppendMessage);
            theForm = this;
        }

        #endregion

        #region "Form Event"

        private void MantraBioTimeSDK_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {               
                Microsoft.VisualBasic.Devices.ComputerInfo CompInfo = new Microsoft.VisualBasic.Devices.ComputerInfo();
                string OSFullName = CompInfo.OSFullName;
                ProcessStartInfo ProcessInfo = new ProcessStartInfo(Application.StartupPath + @"\RegisterFile.bat");

                if (OSFullName.Length > 0)
                {
                    if (!(OSFullName.Contains("Windows XP") | OSFullName.Contains("Windows Server")))
                    {
                        ProcessInfo.UseShellExecute = true;
                        ProcessInfo.Verb = "runas";
                    }
                }
                Process P = Process.Start(ProcessInfo);
                P.WaitForExit();

                CloseAll(this);
                pnlFillDevice.Visible = true;
                pnlFillTerminal.Visible = false;
                pnlFillUser.Visible = false;
                pnlFillLog.Visible = false;
                pnlAccess.Visible = false;
                pnlOther.Visible = false;
                pnlData.Visible = false;
                FrmDevice _FrmDevice = new FrmDevice(this);
                _FrmDevice.TopLevel = false;
                pnlFillDevice.Dock = DockStyle.Fill;
                pnlFillDevice.Controls.Clear();
                this.pnlFillDevice.Controls.Add(_FrmDevice);
                this.pnlFillDevice.Refresh();
                _FrmDevice.Show();

               
            }
            catch (Exception)
            {

            }
            Cursor = Cursors.Default;
        }

        #endregion

        #region "Method"

        public void AppendMessage(string message)
        {
            lblDeviceName.Text = message;
        }

        public void CloseAll(Form _MantraBioTimeSDK)
        {
            try
            {
                foreach (Form ChildForm in _MantraBioTimeSDK.MdiChildren)
                {
                    ChildForm.Close();
                }
            }
            catch (Exception Ex)
            {
                MantraBioTimeSDK.theForm.ErrorLogs.Items.Add(Ex.Message);
                MantraBioTimeSDK.theForm.ErrorLogs.TopIndex = MantraBioTimeSDK.theForm.ErrorLogs.Items.Count - 1;            
            }
        }
        #endregion
        
        #region "Button Event"

        private void btnDevice_Click(object sender, EventArgs e)
        {
            lblMenu.Text = "|| Device ||";
            try
            {
                CloseAll(this);
                pnlFillDevice.Visible = true;
                pnlFillTerminal.Visible = false;
                pnlFillUser.Visible = false;
                pnlFillLog.Visible = false;
                pnlAccess.Visible = false;
                pnlOther.Visible = false;
                pnlData.Visible = false;
                FrmDevice _FrmDevice = new FrmDevice(this);
                _FrmDevice.TopLevel = false;               
                pnlFillDevice.Dock = DockStyle.Fill;
                pnlFillDevice.Controls.Clear();
                this.pnlFillDevice.Controls.Add(_FrmDevice);
                this.pnlFillDevice.Refresh();
                _FrmDevice.Show();
            }
            catch (Exception Ex)
            {
                MantraBioTimeSDK.theForm.ErrorLogs.Items.Add(Ex.Message);
                MantraBioTimeSDK.theForm.ErrorLogs.TopIndex = MantraBioTimeSDK.theForm.ErrorLogs.Items.Count - 1;
            }
        }

        private void btnTerminal_Click(object sender, EventArgs e)
        {
            lblMenu.Text = "|| Terminal ||";
            try
            {                
                CloseAll(this);
                pnlFillDevice.Visible = false;
                pnlFillTerminal.Visible = true;
                pnlFillUser.Visible = false;
                pnlFillLog.Visible = false;
                pnlAccess.Visible = false;
                pnlOther.Visible = false;
                pnlData.Visible = false;
                FrmTerminal _FrmTerminal = new FrmTerminal(this);
                _FrmTerminal.TopLevel = false;
                pnlFillTerminal.Dock = DockStyle.Fill;               
                this.pnlFillTerminal.Controls.Add(_FrmTerminal);                
                _FrmTerminal.Show();
            }
            catch (Exception Ex)
            {
                MantraBioTimeSDK.theForm.ErrorLogs.Items.Add(Ex.Message);
                MantraBioTimeSDK.theForm.ErrorLogs.TopIndex = MantraBioTimeSDK.theForm.ErrorLogs.Items.Count - 1;
            }
        }

        private void btnUserDataMgmt_Click(object sender, EventArgs e)
        {
            lblMenu.Text = "|| UserDataMgmt ||";
            try
            {
                CloseAll(this);
                pnlFillDevice.Visible = false;
                pnlFillTerminal.Visible = false;
                pnlFillUser.Visible = true;
                pnlFillLog.Visible = false;
                pnlAccess.Visible = false;
                pnlOther.Visible = false;
                pnlData.Visible = false;
                FrmUserDataManagement _FrmUserDataMngt = new FrmUserDataManagement(this);
                _FrmUserDataMngt.TopLevel = false;
                pnlFillUser.Dock = DockStyle.Fill;
                pnlFillUser.Controls.Clear();
                this.pnlFillUser.Controls.Add(_FrmUserDataMngt);
                this.pnlFillUser.Refresh();
                _FrmUserDataMngt.Show();
            }
            catch (Exception Ex)
            {
                MantraBioTimeSDK.theForm.ErrorLogs.Items.Add(Ex.Message);
                MantraBioTimeSDK.theForm.ErrorLogs.TopIndex = MantraBioTimeSDK.theForm.ErrorLogs.Items.Count - 1;
            }
        }

        private void btnLogDataMgmt_Click(object sender, EventArgs e)
        {
            lblMenu.Text = "|| LogDataMgmt ||";
            try
            {
                CloseAll(this);
                pnlFillDevice.Visible = false;
                pnlFillTerminal.Visible = false;
                pnlFillUser.Visible = false;
                pnlFillLog.Visible = true;
                pnlAccess.Visible = false;
                pnlOther.Visible = false;
                pnlData.Visible = false;
                FrmLogDataManagement _FrmUserDataMngt = new FrmLogDataManagement(this);
                _FrmUserDataMngt.TopLevel = false;
                pnlFillLog.Dock = DockStyle.Fill;
                pnlFillLog.Controls.Clear();
                this.pnlFillLog.Controls.Add(_FrmUserDataMngt);
                pnlFillLog.Refresh();
                _FrmUserDataMngt.Show();
            }
            catch (Exception Ex)
            {
                MantraBioTimeSDK.theForm.ErrorLogs.Items.Add(Ex.Message);
                MantraBioTimeSDK.theForm.ErrorLogs.TopIndex = MantraBioTimeSDK.theForm.ErrorLogs.Items.Count - 1;
            }
        }

        private void btnAccessMgmt_Click(object sender, EventArgs e)
        {
            lblMenu.Text = "|| AccessMgmt ||";
            try
            {
                CloseAll(this);
                pnlFillDevice.Visible = false;
                pnlFillTerminal.Visible = false;
                pnlFillUser.Visible = false;
                pnlFillLog.Visible = false;
                pnlAccess.Visible = true;
                pnlOther.Visible = false;
                pnlData.Visible = false;
                FrmAccessManagement _FrmAccessMngt = new FrmAccessManagement(this);
                _FrmAccessMngt.TopLevel = false;
                pnlAccess.Dock = DockStyle.Fill;
                pnlAccess.Controls.Clear();
                this.pnlAccess.Controls.Add(_FrmAccessMngt);
                pnlAccess.Refresh();
                _FrmAccessMngt.Show();
            }
            catch (Exception Ex)
            {
                MantraBioTimeSDK.theForm.ErrorLogs.Items.Add(Ex.Message);
                MantraBioTimeSDK.theForm.ErrorLogs.TopIndex = MantraBioTimeSDK.theForm.ErrorLogs.Items.Count - 1;
            }
        }

        private void btnOthersMgmt_Click(object sender, EventArgs e)
        {
            lblMenu.Text = "|| Others ||";
            try
            {
                CloseAll(this);
                pnlFillDevice.Visible = false;
                pnlFillTerminal.Visible = false;
                pnlFillUser.Visible = false;
                pnlFillLog.Visible = false;
                pnlAccess.Visible = false;
                pnlOther.Visible = true;
                pnlData.Visible = false;
                FrmOthers _FrmOthers = new FrmOthers(this);
                _FrmOthers.TopLevel = false;
                pnlOther.Dock = DockStyle.Fill;
                pnlOther.Controls.Clear();
                this.pnlOther.Controls.Add(_FrmOthers);
                pnlOther.Refresh();
                _FrmOthers.Show();
            }
            catch (Exception Ex)
            {
                MantraBioTimeSDK.theForm.ErrorLogs.Items.Add(Ex.Message);
                MantraBioTimeSDK.theForm.ErrorLogs.TopIndex = MantraBioTimeSDK.theForm.ErrorLogs.Items.Count - 1;
            }           
        }

        private void btnPushDemo_Click(object sender, EventArgs e)
        {
            lblMenu.Text = "|| PushDemo ||";
            try
            {
                CloseAll(this);
                pnlFillDevice.Visible = false;
                pnlFillTerminal.Visible = false;
                pnlFillUser.Visible = false;
                pnlFillLog.Visible = false;
                pnlAccess.Visible = false;
                pnlOther.Visible = false;
                pnlData.Visible = true;
                FrmPushData _FrmPushData = new FrmPushData(this);
                _FrmPushData.TopLevel = false;
                pnlData.Dock = DockStyle.Fill;               
                this.pnlData.Controls.Add(_FrmPushData);
                pnlData.Refresh();
                _FrmPushData.Show();
            }
            catch (Exception Ex)
            {
                MantraBioTimeSDK.theForm.ErrorLogs.Items.Add(Ex.Message);
                MantraBioTimeSDK.theForm.ErrorLogs.TopIndex = MantraBioTimeSDK.theForm.ErrorLogs.Items.Count - 1;
            }           
        }

        private void MantraLogo_MouseClick(object sender, MouseEventArgs e)
        {
            pnlFillDevice.Visible = false;
            pnlFillTerminal.Visible = false;
            pnlCenter.Visible = true;
        }

        private void _Minimize_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void _Close_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure to exit system?", "Warning!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);          

            if (dr == DialogResult.OK)
            {
                try
                {
                    MantraBioTime.DisConnectTCP(Convert.ToInt32(clsGlobal.DevID), clsGlobal.DeviceType);               
                }
                catch (Exception Ex)
                {
                    MantraBioTimeSDK.theForm.ErrorLogs.Items.Add(Ex.Message);
                    MantraBioTimeSDK.theForm.ErrorLogs.TopIndex = MantraBioTimeSDK.theForm.ErrorLogs.Items.Count - 1;
                }
                finally
                {
                    Application.Exit();
                }                
            }
        }

        private void lnkEventLog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EventLogs.Items.Clear();
        }

        private void lnkErrorLog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ErrorLogs.Items.Clear();
        }

        #endregion            

        private void lblHelp_Click(object sender, EventArgs e)
        {
            //Application.StartupPath;
        }
       
    }
}
