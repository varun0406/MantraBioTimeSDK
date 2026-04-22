using MantraBioTimeDLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace MantraBioTimeSDK
{
    public partial class FrmAccessManagement : Form
    {
        private MantraBioTimeSDK _MantraBioTimeSDK;
        public FrmAccessManagement(MantraBioTimeSDK _Parent)
        {
            InitializeComponent();
            _MantraBioTimeSDK = _Parent;
        }

        #region "Button Events"

        private void btnGetTZone_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            int _flgVal = 0;
            try
            {                
                List<KeyValuePair<string, string>> _TZ = new List<KeyValuePair<string,string>>();
                _flgVal = MantraBioTime.GetTZone(clsGlobal.DeviceType, Convert.ToInt32(txtTZoneID.Text), ref _TZ);
                if (_flgVal == 0)
                {
                    dtSUN.Text = _TZ[0].Value;
                    dtTOSUN.Text = _TZ[1].Value;
                    dtMON.Text = _TZ[2].Value;
                    dtTOMON.Text = _TZ[3].Value;
                    dtTUE.Text = _TZ[4].Value;
                    dtTOTUE.Text = _TZ[5].Value;
                    dtWEN.Text = _TZ[6].Value;
                    dtTOWEN.Text = _TZ[7].Value;
                    dtTHU.Text = _TZ[8].Value;
                    dtTOTHU.Text = _TZ[9].Value;
                    dtFRI.Text = _TZ[10].Value;
                    dtTOFRI.Text = _TZ[11].Value;
                    dtSTA.Text = _TZ[12].Value;
                    dtTOSTA.Text = _TZ[13].Value;
                    MantraBioTimeSDK.theForm.EventLogs.Items.Add("Get TimeZone Successfully!");
                    MantraBioTimeSDK.theForm.EventLogs.TopIndex = MantraBioTimeSDK.theForm.EventLogs.Items.Count - 1;
                }
                else
                {
                    MantraBioTimeSDK.theForm.ErrorLogs.Items.Add(MantraBioTimeException.MsgCode(_flgVal));
                    MantraBioTimeSDK.theForm.ErrorLogs.TopIndex = MantraBioTimeSDK.theForm.ErrorLogs.Items.Count - 1;
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

        private void btnSetTZone_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            int _flgVal = 0;
            try
            {
                _flgVal = MantraBioTime.SetTZone(clsGlobal.DeviceType, Convert.ToInt32(txtTZoneID.Text), dtSUN.Value, dtTOSUN.Value, dtMON.Value, dtTOMON.Value, dtTUE.Value, dtTOTUE.Value, dtWEN.Value, dtTOWEN.Value, dtTHU.Value, dtTOTHU.Value, dtFRI.Value, dtTOFRI.Value, dtSTA.Value, dtTOSTA.Value);
                if(_flgVal == 0)
                {
                    MantraBioTimeSDK.theForm.EventLogs.Items.Add("Set TimeZone Successfully!");
                    MantraBioTimeSDK.theForm.EventLogs.TopIndex = MantraBioTimeSDK.theForm.EventLogs.Items.Count - 1;
                }
                else
                {
                    MantraBioTimeSDK.theForm.ErrorLogs.Items.Add(MantraBioTimeException.MsgCode(_flgVal));
                    MantraBioTimeSDK.theForm.ErrorLogs.TopIndex = MantraBioTimeSDK.theForm.ErrorLogs.Items.Count - 1;
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


        private void btnGetUATZone_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            int _flgVal = 0;
            try
            {
                string idx1 = ""; string idx2 = ""; string idx3 = "";
                _flgVal = MantraBioTime.GetUserTZone(clsGlobal.DeviceType, Convert.ToInt32(txtUATZoneID.Text), ref idx1, ref idx2, ref idx3);               
                if (_flgVal == 0)
                {
                    txtUATZIdx1.Text = idx1;
                    txtUATZIdx2.Text = idx2;
                    txtUATZIdx3.Text = idx3;
                    MantraBioTimeSDK.theForm.EventLogs.Items.Add("Get User Access TimeZone Successfully!");
                    MantraBioTimeSDK.theForm.EventLogs.TopIndex = MantraBioTimeSDK.theForm.EventLogs.Items.Count - 1;
                }
                else
                {
                    txtUATZIdx1.Text = "";
                    txtUATZIdx2.Text = "";
                    txtUATZIdx3.Text = "";
                    MantraBioTimeSDK.theForm.ErrorLogs.Items.Add(MantraBioTimeException.MsgCode(_flgVal));
                    MantraBioTimeSDK.theForm.ErrorLogs.TopIndex = MantraBioTimeSDK.theForm.ErrorLogs.Items.Count - 1;
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

        private void btnSetUATZone_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            int _flgVal = 0;
            try
            {
                _flgVal = MantraBioTime.SetUserTZone(clsGlobal.DeviceType, Convert.ToInt32(txtUATZoneID.Text), txtUATZIdx1.Text, txtUATZIdx2.Text, txtUATZIdx3.Text);
                if (_flgVal == 0)
                {
                    MantraBioTimeSDK.theForm.EventLogs.Items.Add("Set User Access TimeZone Successfully!");
                    MantraBioTimeSDK.theForm.EventLogs.TopIndex = MantraBioTimeSDK.theForm.EventLogs.Items.Count - 1;
                }
                else
                {
                    MantraBioTimeSDK.theForm.ErrorLogs.Items.Add(MantraBioTimeException.MsgCode(_flgVal));
                    MantraBioTimeSDK.theForm.ErrorLogs.TopIndex = MantraBioTimeSDK.theForm.ErrorLogs.Items.Count - 1;
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

        #endregion

    }
}
