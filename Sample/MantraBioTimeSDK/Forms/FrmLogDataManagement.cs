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
    public partial class FrmLogDataManagement : Form
    {
        private MantraBioTimeSDK _MantraBioTimeSDK;
        public FrmLogDataManagement(MantraBioTimeSDK _Parent)
        {
            InitializeComponent();
            _MantraBioTimeSDK = _Parent;
        }

        #region "Button Events"

        private void btnTimePeriodLogData_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            int _flgVal = 0;
            try
            {             
                DataTable Dt = new DataTable();
                _flgVal = MantraBioTime.TimePeriodLogData(clsGlobal.DeviceType, dtpFromDate.Value.Date.ToString("yyyy-MM-dd"), dtpToDate.Value.Date.ToString("yyyy-MM-dd"), ref Dt);
                if (_flgVal == 0)
                {
                    MantraBioTimeSDK.theForm.EventLogs.Items.Add("Get Periodically AttenLogData Successfully.");
                    SqliteDB.SaveToLogData(ref Dt);
                    MantraBioTimeSDK.theForm.EventLogs.Items.Add("Record Save Successfully!");
                    dgvLogData.DataSource = Dt;
                    MantraBioTimeSDK.theForm.EventLogs.TopIndex = MantraBioTimeSDK.theForm.EventLogs.Items.Count - 1;
                }
                else
                {
                    dgvLogData.DataSource = Dt;
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

        private void btnReadNewLogData_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            int _flgVal = 0;
            try
            {               
                DataTable Dt = new DataTable();
                _flgVal = MantraBioTime.ReadNewLogData(clsGlobal.DeviceType, ref Dt);
                if (_flgVal == 0)
                {
                    MantraBioTimeSDK.theForm.EventLogs.Items.Add("Get New AttenLogData Successfully.");
                    SqliteDB.SaveToLogData(ref Dt);
                    MantraBioTimeSDK.theForm.EventLogs.Items.Add("Record Save Successfully!");
                    dgvLogData.DataSource = Dt;
                    MantraBioTimeSDK.theForm.EventLogs.TopIndex = MantraBioTimeSDK.theForm.EventLogs.Items.Count - 1;
                }
                else
                {
                    dgvLogData.DataSource = Dt;
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

        private void btnReadAllLogData_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            int _flgVal = 0;
            try
            {              
                DataTable Dt = new DataTable();
                _flgVal = MantraBioTime.ReadAllLogData(clsGlobal.DeviceType, ref Dt);
                if (_flgVal == 0)
                {
                    MantraBioTimeSDK.theForm.EventLogs.Items.Add("Get All AttenLogData Successfully!");
                    SqliteDB.SaveToLogData(ref Dt);
                    MantraBioTimeSDK.theForm.EventLogs.Items.Add("Record Save Successfully!");
                    dgvLogData.DataSource = Dt;
                    MantraBioTimeSDK.theForm.EventLogs.TopIndex = MantraBioTimeSDK.theForm.EventLogs.Items.Count - 1;

                }
                else
                {
                    dgvLogData.DataSource = Dt;
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

        private void btnDeleteAllLogData_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            int _flgVal = 0;
            try
            {
                _flgVal = MantraBioTime.DeleteAllLogData(clsGlobal.DeviceType);//GLog Data Clear
                if (_flgVal == 0)                
                {
                    MantraBioTimeSDK.theForm.EventLogs.Items.Add("AttenData Delete Successfully!");
                    MantraBioTimeSDK.theForm.EventLogs.TopIndex = MantraBioTimeSDK.theForm.EventLogs.Items.Count - 1;
                    dgvLogData.DataSource = null;
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
