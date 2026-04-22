using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MantraBioTimeSDK
{
    public partial class FrmDevice : Form
    {
        private MantraBioTimeSDK _MantraBioTimeSDK;
        public FrmDevice(MantraBioTimeSDK _Parent)
        {
            InitializeComponent();
            _MantraBioTimeSDK = _Parent;           
        }
       
        #region "Link Label MORX-Enterprise"

        private void lnkLblBIOFACEMI01_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                MantraBioTimeSDK.theForm.lblDeviceName.Text = "BIOFACE - MI01";
                clsGlobal.DeviceType = 1;
                CallForm();
            }
            catch (Exception Ex)
            {
                MantraBioTimeSDK.theForm.ErrorLogs.Items.Add(Ex.Message);
                MantraBioTimeSDK.theForm.ErrorLogs.TopIndex = MantraBioTimeSDK.theForm.ErrorLogs.Items.Count - 1;
            }
        }

        private void lnkLblBIOTIMEMR103_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                MantraBioTimeSDK.theForm.lblDeviceName.Text = "BIOTIME-MR103";
                clsGlobal.DeviceType = 1;
                CallForm();
            }
            catch (Exception Ex)
            {
                MantraBioTimeSDK.theForm.ErrorLogs.Items.Add(Ex.Message);
                MantraBioTimeSDK.theForm.ErrorLogs.TopIndex = MantraBioTimeSDK.theForm.ErrorLogs.Items.Count - 1;
            }
        }

        private void lnkLblBIOTIMEMR110_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                MantraBioTimeSDK.theForm.lblDeviceName.Text = "BIOTIME-MR110";
                clsGlobal.DeviceType = 1;
                CallForm();
            }
            catch (Exception Ex)
            {
                MantraBioTimeSDK.theForm.ErrorLogs.Items.Add(Ex.Message);
                MantraBioTimeSDK.theForm.ErrorLogs.TopIndex = MantraBioTimeSDK.theForm.ErrorLogs.Items.Count - 1;
            }
        }

        #endregion

        #region "Link Label SBXPC"

        private void lnkLblMBIOG1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                MantraBioTimeSDK.theForm.lblDeviceName.Text = "MBIO G1";
                clsGlobal.DeviceType = 2;
                CallForm();
            }
            catch (Exception Ex)
            {
                MantraBioTimeSDK.theForm.ErrorLogs.Items.Add(Ex.Message);
                MantraBioTimeSDK.theForm.ErrorLogs.TopIndex = MantraBioTimeSDK.theForm.ErrorLogs.Items.Count - 1;
            }
        }

        private void lnkLblMBIOG2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                MantraBioTimeSDK.theForm.lblDeviceName.Text = "MBIO G2";
                clsGlobal.DeviceType = 2;
                CallForm();
            }
            catch (Exception Ex)
            {
                MantraBioTimeSDK.theForm.ErrorLogs.Items.Add(Ex.Message);
                MantraBioTimeSDK.theForm.ErrorLogs.TopIndex = MantraBioTimeSDK.theForm.ErrorLogs.Items.Count - 1;
            }
        }

        private void lnkLblMBIOG3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                MantraBioTimeSDK.theForm.lblDeviceName.Text = "MBIO G3";
                clsGlobal.DeviceType = 2;
                CallForm();
            }
            catch (Exception Ex)
            {
                MantraBioTimeSDK.theForm.ErrorLogs.Items.Add(Ex.Message);
                MantraBioTimeSDK.theForm.ErrorLogs.TopIndex = MantraBioTimeSDK.theForm.ErrorLogs.Items.Count - 1;
            }
        }

        private void lnkLblMBIOM18_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                MantraBioTimeSDK.theForm.lblDeviceName.Text = "MBIO M18";
                clsGlobal.DeviceType = 2;
                CallForm();
            }
            catch (Exception Ex)
            {
                MantraBioTimeSDK.theForm.ErrorLogs.Items.Add(Ex.Message);
                MantraBioTimeSDK.theForm.ErrorLogs.TopIndex = MantraBioTimeSDK.theForm.ErrorLogs.Items.Count - 1;
            }
        }

        private void linkLblmFaceFA200_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                MantraBioTimeSDK.theForm.lblDeviceName.Text = "MFace-FA200";
                clsGlobal.DeviceType = 2;
                CallForm();
            }
            catch (Exception Ex)
            {
                MantraBioTimeSDK.theForm.ErrorLogs.Items.Add(Ex.Message);
                MantraBioTimeSDK.theForm.ErrorLogs.TopIndex = MantraBioTimeSDK.theForm.ErrorLogs.Items.Count - 1;
            }
        }

        private void linkLblmFaceFA300_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                MantraBioTimeSDK.theForm.lblDeviceName.Text = "MFace-FA300";
                clsGlobal.DeviceType = 2;
                CallForm();
            }
            catch (Exception Ex)
            {
                MantraBioTimeSDK.theForm.ErrorLogs.Items.Add(Ex.Message);
                MantraBioTimeSDK.theForm.ErrorLogs.TopIndex = MantraBioTimeSDK.theForm.ErrorLogs.Items.Count - 1;
            }
        }

        #endregion

        private void FrmDevice_Load(object sender, EventArgs e)
        {
            
        }

        #region "Common Method"

        private void CallForm()
        {
            MantraBioTimeSDK.theForm.lblMenu.Text = "|| Terminal ||";
            MantraBioTimeSDK.theForm.pnlFillDevice.Visible = false;
            MantraBioTimeSDK.theForm.pnlFillTerminal.Visible = true;
            MantraBioTimeSDK.theForm.CloseAll(this);
            MantraBioTimeSDK.theForm.pnlFillTerminal.Controls.Clear();
            FrmTerminal _FrmTerminal = new FrmTerminal(MantraBioTimeSDK.theForm);
            _FrmTerminal.txtDeviceId.Text = "1";
            if (clsGlobal.DeviceType == 1)
            {
                _FrmTerminal.txtDeviceIP.Text = "192.168.1.201";
                _FrmTerminal.txtDevicePort.Text = "4370";
            }
            else if (clsGlobal.DeviceType == 2)
            {
                _FrmTerminal.txtDeviceIP.Text = "192.168.1.224";
                _FrmTerminal.txtDevicePort.Text = "5005";
            }

            _FrmTerminal.TopLevel = false;
            MantraBioTimeSDK.theForm.pnlFillTerminal.Dock = DockStyle.Fill;
            MantraBioTimeSDK.theForm.pnlFillTerminal.Controls.Add(_FrmTerminal);
            _FrmTerminal.Show();
            this.Close();
        }

        #endregion
    }
}
