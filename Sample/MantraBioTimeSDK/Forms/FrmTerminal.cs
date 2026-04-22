using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MantraBioTimeDLL;
using System.IO;
using Microsoft.VisualBasic;
using DLLMsg = MantraBioTimeDLL.MantraBioTimeException;

namespace MantraBioTimeSDK
{
    public partial class FrmTerminal : Form
    {
        #region "Default Constructor"

        private MantraBioTimeSDK _MantraBioTimeSDK;
        public FrmTerminal(MantraBioTimeSDK _Parent)
        {
            InitializeComponent();
            _MantraBioTimeSDK = _Parent;

            tabConnect.TabPages.Remove(tabRS);
            tabConnect.TabPages.Remove(tabUSB);
        }
        
        #endregion

        #region "Button Event"

        private void btnConnect_Click(object sender, EventArgs e)
        {
            // CREATE DATABASE SQLite           
            SqliteDB.CreateNewDatabase();
         
            if (clsGlobal.DeviceType == 0)
            {               
                MantraBioTimeSDK.theForm.ErrorLogs.Items.Add("Go To Device Menu And Select Device");
                MantraBioTimeSDK.theForm.ErrorLogs.TopIndex = MantraBioTimeSDK.theForm.ErrorLogs.Items.Count - 1;
                return;
            }

            if (txtDeviceIP.Text.Trim() == "")
            {
                 MantraBioTimeSDK.theForm.ErrorLogs.Items.Add("Enter Device IP!");
                 MantraBioTimeSDK.theForm.ErrorLogs.TopIndex = MantraBioTimeSDK.theForm.ErrorLogs.Items.Count - 1;
                 return;
            }
            
            if (txtDeviceId.Text.Trim().Length < 0)
            {
                MantraBioTimeSDK.theForm.ErrorLogs.Items.Add("Enter Valid Device ID!");
                MantraBioTimeSDK.theForm.ErrorLogs.TopIndex = MantraBioTimeSDK.theForm.ErrorLogs.Items.Count - 1;
                return;
            }
            try
            {
                if (Convert.ToInt32(txtDevicePort.Text.Trim()) <= 0 || Convert.ToInt32(txtDevicePort.Text.Trim()) > 65535)
                {
                    MantraBioTimeSDK.theForm.ErrorLogs.Items.Add("Enter Device Port!");
                    MantraBioTimeSDK.theForm.ErrorLogs.TopIndex = MantraBioTimeSDK.theForm.ErrorLogs.Items.Count - 1;
                    return;
                }
            }
            catch
            {
                MantraBioTimeSDK.theForm.ErrorLogs.Items.Add("Enter Device Port!");
                MantraBioTimeSDK.theForm.ErrorLogs.TopIndex = MantraBioTimeSDK.theForm.ErrorLogs.Items.Count - 1;
                return;
            }
           
            clsGlobal.DevID = txtDeviceId.Text.Trim();
            clsGlobal.DevIP = txtDeviceIP.Text.Trim();
            clsGlobal.DevPort = txtDevicePort.Text.Trim();
            clsGlobal.DevPass = txtDeviceCommKey.Text.Trim() == "" ? "0" : txtDeviceCommKey.Text.Trim();
          
            Cursor = Cursors.WaitCursor;
            try
            {
                bool RetVal = false;                
                if (btnConnect.Text == "Connect")
                {                    
                    if (MantraBioTime.ConnectTCP(Convert.ToInt32(clsGlobal.DevID), clsGlobal.DevIP, Convert.ToInt32(clsGlobal.DevPort == "" ? 0 : Convert.ToInt32(clsGlobal.DevPort)), Convert.ToInt32(clsGlobal.DevPass), clsGlobal.DeviceType) == 0)
                    {                       
                        RetVal = true;
                        MantraBioTimeSDK.theForm.EventLogs.Items.Add("Device Connected.");
                        MantraBioTime.DeviceInfo(clsGlobal.DeviceType);
                        MantraBioTimeSDK.theForm.EventLogs.Items.Add("Get DeviceInfo*.");
                        MantraBioTimeSDK.theForm.EventLogs.TopIndex = MantraBioTimeSDK.theForm.EventLogs.Items.Count - 1;
                        MantraBioTime.CapacityInfo(clsGlobal.DeviceType);
                        MantraBioTimeSDK.theForm.EventLogs.Items.Add("Get DeviceCapacity*.");
                        MantraBioTimeSDK.theForm.EventLogs.TopIndex = MantraBioTimeSDK.theForm.EventLogs.Items.Count - 1;
                    }
                }
                else
                {                    
                    MantraBioTime.DisConnectTCP(Convert.ToInt32(clsGlobal.DevID), clsGlobal.DeviceType);
                    MantraBioTimeSDK.theForm.EventLogs.Items.Add("Device DisConnected.");
                }

                if (RetVal)
                {                   
                    clsGlobal.IsConnect = true;
                    this.txtDeviceId.ReadOnly = true;
                    this.txtDeviceIP.ReadOnly = true;
                    this.txtDevicePort.ReadOnly = true;
                    this.txtDeviceCommKey.ReadOnly = true;

                    tabRS.Enabled = false;
                    tabUSB.Enabled = false;

                    getCapacityInfo();
                    getDeviceInfo();

                    btnConnect.Text = "DisConnect";
                    btnConnect.Refresh();
                    MantraBioTimeSDK.theForm.btnDevice.Enabled = false;                   
                }
                else
                {
                    btnConnect.Text = "Connect";
                    btnConnect.Refresh();
                    clsGlobal.IsConnect = false;
                    this.txtDeviceId.ReadOnly = false;
                    this.txtDeviceIP.ReadOnly = false;
                    this.txtDevicePort.ReadOnly = false;
                    this.txtDeviceCommKey.ReadOnly = false;

                    tabConnect.Enabled = true;
                    tabRS.Enabled = true;
                    tabUSB.Enabled = true;
                    MantraBioTimeSDK.theForm.btnDevice.Enabled = true;                    
                }
            }
            catch (Exception Ex)
            {
                foreach (Control Ctrl in this.Controls)
                {
                    if (Ctrl.Name == "pnlTerminal")
                    {
                        foreach (Control pnlCtrl in Ctrl.Controls)
                        {
                            if (pnlCtrl.Name == "pnlMiddle")
                            {
                                foreach (Control Cntrl in pnlCtrl.Controls)
                                {
                                    if (Cntrl is TabControl)
                                    {
                                        foreach (Control _cntl in Cntrl.Controls)
                                        {
                                            if (_cntl is TabPage)
                                            {
                                                foreach (Control c in _cntl.Controls)
                                                {
                                                    if (c is TextBox)
                                                    {
                                                        c.Text = "";
                                                    }
                                                }
                                            }                                            
                                        }
                                    }                                    
                                }
                            }                            
                        }
                    }
                }                
                MantraBioTimeSDK.theForm.ErrorLogs.Items.Add(Ex.Message);
                MantraBioTimeSDK.theForm.ErrorLogs.TopIndex = MantraBioTimeSDK.theForm.ErrorLogs.Items.Count - 1;
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void btn2Connect_Click(object sender, EventArgs e)
        {
            //Not Work
            if (clsGlobal.DeviceType == 0)
            {
                MantraBioTimeSDK.theForm.ErrorLogs.Items.Add("Select Device");
                MantraBioTimeSDK.theForm.ErrorLogs.TopIndex = MantraBioTimeSDK.theForm.ErrorLogs.Items.Count - 1;
                return;
            }

            if (btn2Connect.Text.ToUpper() == "CONNECT")
            {
                btn2Connect.Text = "Disconnect";
                clsGlobal.IsConnect = true;
                btnConnect.Enabled = false;
                btn3Connect.Enabled = false;
                MantraBioTimeSDK.theForm.EventLogs.Items.Add("Device Connecting...");
                MantraBioTimeSDK.theForm.EventLogs.TopIndex = MantraBioTimeSDK.theForm.EventLogs.Items.Count - 1;
            }
            else
            {
                btn2Connect.Text = "Connect";
                clsGlobal.IsConnect = false;
                btnConnect.Enabled = true;
                btn3Connect.Enabled = true;
                MantraBioTimeSDK.theForm.EventLogs.Items.Add("Device does't Connecting...");
                MantraBioTimeSDK.theForm.EventLogs.TopIndex = MantraBioTimeSDK.theForm.EventLogs.Items.Count - 1;
            }
        }

        private void btn3Connect_Click(object sender, EventArgs e)
        {
            //Not Work
            if (clsGlobal.DeviceType == 0)
            {
                MantraBioTimeSDK.theForm.ErrorLogs.Items.Add("Select Device");
                MantraBioTimeSDK.theForm.ErrorLogs.TopIndex = MantraBioTimeSDK.theForm.ErrorLogs.Items.Count - 1;
                return;
            }

            if (btn3Connect.Text.ToUpper() == "CONNECT")
            {
                btn3Connect.Text = "Disconnect";
                clsGlobal.IsConnect = true;
                btnConnect.Enabled = false;
                btn2Connect.Enabled = false;
            }
            else
            {
                btn3Connect.Text = "Connect";
                clsGlobal.IsConnect = false;
                btnConnect.Enabled = true;
                btn2Connect.Enabled = true;
            }
        }

        private void btnGetDevInfo_Click(object sender, EventArgs e)
        {
            if (clsGlobal.IsConnect)
            {
                try
                {                    
                    if (MantraBioTime.DeviceInfo(clsGlobal.DeviceType) == 0)
                    {                        
                        getDeviceInfo();
                        MantraBioTimeSDK.theForm.EventLogs.Items.Add("Get DeviceInfo*.");
                        MantraBioTimeSDK.theForm.EventLogs.TopIndex = MantraBioTimeSDK.theForm.EventLogs.Items.Count - 1;
                    }
                    else
                    {
                        getDeviceInfo();
                        MantraBioTimeSDK.theForm.ErrorLogs.Items.Add("DeviceInfo Fail!");
                        MantraBioTimeSDK.theForm.ErrorLogs.TopIndex = MantraBioTimeSDK.theForm.ErrorLogs.Items.Count - 1;                        
                    }
                    
                }
                catch (Exception Ex)
                {
                    MantraBioTimeSDK.theForm.ErrorLogs.Items.Add(Ex.Message);
                    MantraBioTimeSDK.theForm.ErrorLogs.TopIndex = MantraBioTimeSDK.theForm.ErrorLogs.Items.Count - 1;
                }
            }
            else
            {
                MantraBioTimeSDK.theForm.ErrorLogs.Items.Add("Connect Device First.");
                MantraBioTimeSDK.theForm.ErrorLogs.TopIndex = MantraBioTimeSDK.theForm.ErrorLogs.Items.Count - 1;
            }
        }

        private void btnGetDevCapacity_Click(object sender, EventArgs e)
        {
            if (clsGlobal.IsConnect)
            {
                try
                {                
                    if (MantraBioTime.CapacityInfo(clsGlobal.DeviceType) == 0)
                    {
                        getCapacityInfo();
                        MantraBioTimeSDK.theForm.EventLogs.Items.Add("Get DeviceCapacity*.");                        
                        MantraBioTimeSDK.theForm.EventLogs.TopIndex = MantraBioTimeSDK.theForm.EventLogs.Items.Count - 1;
                    }
                    else
                    {
                        MantraBioTimeSDK.theForm.ErrorLogs.Items.Add("DeviceCapacity Fail!");
                        MantraBioTimeSDK.theForm.ErrorLogs.TopIndex = MantraBioTimeSDK.theForm.ErrorLogs.Items.Count - 1;
                    }                    
                }
                catch (Exception Ex)
                {
                    MantraBioTimeSDK.theForm.ErrorLogs.Items.Add(Ex.Message);
                    MantraBioTimeSDK.theForm.ErrorLogs.TopIndex = MantraBioTimeSDK.theForm.ErrorLogs.Items.Count - 1;
                }
            }
            else
            {
                MantraBioTimeSDK.theForm.ErrorLogs.Items.Add("Connect Device First.");
                MantraBioTimeSDK.theForm.ErrorLogs.TopIndex = MantraBioTimeSDK.theForm.ErrorLogs.Items.Count - 1;
            }
        }

        private void btnDeleteDB_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                if (SqliteDB.DeleteDatabase() == true)
                {
                    MantraBioTimeSDK.theForm.EventLogs.Items.Add("Delete DataBase Successfully!");
                    MantraBioTimeSDK.theForm.EventLogs.TopIndex = MantraBioTimeSDK.theForm.EventLogs.Items.Count - 1;
                }
                else
                {
                    MantraBioTimeSDK.theForm.EventLogs.Items.Add("Delete DataBase Not Successfully!");
                    MantraBioTimeSDK.theForm.EventLogs.TopIndex = MantraBioTimeSDK.theForm.EventLogs.Items.Count - 1;
                }

            }
            catch (Exception Ex)
            {
                MantraBioTimeSDK.theForm.ErrorLogs.Items.Add(Ex.Message);
                MantraBioTimeSDK.theForm.ErrorLogs.TopIndex = MantraBioTimeSDK.theForm.ErrorLogs.Items.Count - 1;
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void txtDeviceCommKey_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion    

        #region "Method"

        private void getDeviceInfo()
        {
            txtFirmVer.Text = MantraBT_DeviceInfo.FirmwareVersion;
            txtMac.Text = MantraBT_DeviceInfo.Mac;
            txtSerialNumber.Text = MantraBT_DeviceInfo.SerialNumber;
            txtPlatFrm.Text = MantraBT_DeviceInfo.PlatForm;
            txtDevNm.Text = MantraBT_DeviceInfo.DeviceName;
            txtFPAlg.Text = MantraBT_DeviceInfo.FPAlg;
            txtFaceAlgo.Text = MantraBT_DeviceInfo.FaceAlg;
            txtMfr.Text = MantraBT_DeviceInfo.Manufacturer;
            txtMfrTime.Text = MantraBT_DeviceInfo.ManufactureTime;          
        }

        private void getCapacityInfo()
        {
            txtAdminCnt.Text = MantraBT_CapacityInfo.AdminCnt.ToString();
            txtUserCnt.Text = MantraBT_CapacityInfo.UserCount.ToString();
            txtFPCnt.Text = MantraBT_CapacityInfo.FpCnt.ToString();
            txtAttLogCnt.Text = MantraBT_CapacityInfo.recordCnt.ToString();
            txtPWDCnt.Text = MantraBT_CapacityInfo.PwdCnt.ToString();
            txtCardCnt.Text = MantraBT_CapacityInfo.CardCnt.ToString();
            txtOpLogCnt.Text = MantraBT_CapacityInfo.OpLogCnt.ToString();
            txtFaceCnt.Text = MantraBT_CapacityInfo.FaceCnt.ToString();
        }

        #endregion

        private void FrmTerminal_Load(object sender, EventArgs e)
        {

        }       
    }
}
