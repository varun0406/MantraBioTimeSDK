using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MantraBioTimeDLL;
using System.Threading;
using System.IO;

using DLLMsg = MantraBioTimeDLL.MantraBioTimeException;
namespace MantraBioTimeSDK
{
    public partial class FrmUserDataManagement : Form
    {
        private MantraBioTimeSDK _MantraBioTimeSDK;
        public FrmUserDataManagement(MantraBioTimeSDK _Parent)
        {
            InitializeComponent();
            _MantraBioTimeSDK = _Parent;
           
            if (clsGlobal.DeviceType == 1)
            {               
               //this.cbUserEnable.Enabled = false;
               //this.btnSetUserInfo.Enabled = true;
               //this.grpVerifyStyle.Enabled = true;
               this.cbPrivilege.Items.Clear();
               this.cbPrivilege.Items.Add("0-Normal");
               this.cbPrivilege.Items.Add("1-Enroll/Registrar");
               this.cbPrivilege.Items.Add("2-Admin");
               this.cbPrivilege.Items.Add("3-Super Admin");
               this.cbPrivilege.Items.Add("4-User Defined Role3");
               this.cbPrivilege.Items.Add("5-Undefine");
               this.cbUserEnable.SelectedIndex = 0;
            }
            else if (clsGlobal.DeviceType == 2)
            {
                //this.cbUserEnable.Enabled = true;
                //this.btnSetUserInfo.Enabled = false;
                //this.grpVerifyStyle.Enabled = false;
                this.cbPrivilege.Items.Clear();
                this.cbPrivilege.Items.Add("0-User");
                this.cbPrivilege.Items.Add("1-Admin");
                this.cbPrivilege.Items.Add("2-Manager");
                this.cbPrivilege.SelectedIndex = 0;
            }
        }

        #region "Button Events"

        private void btnGetUserInfo_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            int _flgVal = 0;
            try
            {
                //if (txtUserID.Text.Trim() == "")
                //{
                //    MantraBioTimeSDK.theForm.ErrorLogs.Items.Add("UserId Is Blank.");
                //    MantraBioTimeSDK.theForm.ErrorLogs.TopIndex = MantraBioTimeSDK.theForm.ErrorLogs.Items.Count - 1;                    
                //    return;
                //}                
                List<DemographicsList> DList = new List<DemographicsList>();               
                _flgVal = MantraBioTime.GetUserInfo(clsGlobal.DeviceType, txtUserID.Text.Trim(), ref DList) ;
                if (_flgVal == 0)                
                {
                    MantraBioTimeSDK.theForm.EventLogs.Items.Add("Get UserInfo*.");
                    MantraBioTimeSDK.theForm.EventLogs.TopIndex = MantraBioTimeSDK.theForm.EventLogs.Items.Count - 1;
                    GetUserInfo(ref DList);
                }
                else
                {
                    GetUserInfo(ref DList);
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

        private void btnSetUserInfo_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            int _flgVal = 0;
            try
            {
                _flgVal = MantraBioTime.SetUserInfo(clsGlobal.DeviceType, txtUserID.Text.Trim(), txtName.Text.Trim(), txtPassword.Text.Trim(), txtCardnumber.Text.Trim(), cbPrivilege.SelectedIndex.ToString(), Convert.ToBoolean(cbUserEnable.SelectedIndex));
                if (_flgVal == 0)
                {
                    MantraBioTimeSDK.theForm.EventLogs.Items.Add("Set User Information Successfully!");
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

        private void btnGetUserPeriod_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            int _flgVal = 0;
            try
            {              
                string FromDate="" ; //yyyy-MMM-dd
                string   ToDate = "";//yyyy-MMM-dd
                _flgVal = MantraBioTime.GetUserValidDate(clsGlobal.DeviceType, txtUserID2.Text.Trim(), ref FromDate, ref ToDate);
                if (_flgVal == 0)
                {
                    GetUserValidDate(ref FromDate, ref ToDate);
                    MantraBioTimeSDK.theForm.EventLogs.Items.Add("Get User Access Time Period Successfully!");
                    MantraBioTimeSDK.theForm.EventLogs.TopIndex = MantraBioTimeSDK.theForm.EventLogs.Items.Count - 1;
                }
                else
                {
                    GetUserValidDate(ref FromDate, ref ToDate);
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

        private void btnSetUserPeriod_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            int _flgVal = 0;
            try
            {
                _flgVal = MantraBioTime.SetUserValidDate(clsGlobal.DeviceType, txtUserID2.Text.Trim(), dtStartDate.Value.ToString("yyyy-MM-dd"), dtEndDate.Value.ToString("yyyy-MM-dd"));
                if (_flgVal == 0)
                {
                    MantraBioTimeSDK.theForm.EventLogs.Items.Add("Set User Access Time Period Successfully!");
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

        private void btGetUserVerifyStyle_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            int _flgVal = 0;
            try
            {
                //MantraBioTimeSDK.theForm.EventLogs.Items.Add("Get User Verify Mode"); // like Fin + card || Fin + Pwd || Face + card etc. 
                int iVerifyStyle = 0;
                _flgVal = MantraBioTime.GetUserVerifyStyle(clsGlobal.DeviceType, txtUserID3.Text.Trim(), ref iVerifyStyle);
                if (_flgVal == 0)
                {                   
                    GetUserVerifyStyle(ref iVerifyStyle);
                    MantraBioTimeSDK.theForm.EventLogs.Items.Add("Get User Verify Mode Successfully!");
                    MantraBioTimeSDK.theForm.EventLogs.TopIndex = MantraBioTimeSDK.theForm.EventLogs.Items.Count - 1;
                }
                else 
                {
                    //GetUserVerifyStyle(ref iVerifyStyle);
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

        private void btSetUserVerifyStyl_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            int _flgVal = 0;
            try
            {               
                _flgVal=MantraBioTime.SetUserVerifyStyle(clsGlobal.DeviceType, txtUserID3.Text.Trim(), cbVerifyStyle.Text);
                if (_flgVal == 0)
                {
                    MantraBioTimeSDK.theForm.EventLogs.Items.Add("Set User Verify Mode Successfully!");
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

        private void btnPhotopath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (DialogResult.OK == fbd.ShowDialog())
            {
                tbGetPhotoPath.Text = fbd.SelectedPath;

                if (!fbd.SelectedPath.EndsWith("\\"))
                {
                    tbGetPhotoPath.Text += "\\";
                }
            }
        }

        private void btnGetUserPhoto_Click(object sender, EventArgs e)
        {
             Cursor = Cursors.WaitCursor;
             int _flgVal = 0;
             try
             {
                 byte[] imgByte = null;
                 _flgVal = MantraBioTime.GetUserPhoto(clsGlobal.DeviceType, this.txtPhUserId.Text.Trim(), this.tbGetPhotoPath.Text.Trim(), ref imgByte);
                 if (_flgVal == 0)
                 {
                     MemoryStream ms = new MemoryStream(imgByte, 0, imgByte.Length);
                     ms.Write(imgByte, 0, imgByte.Length);
                     pbUserPhoto.Image = Image.FromStream(ms, true);//Exception occurs here
                     MantraBioTimeSDK.theForm.EventLogs.Items.Add("Get User Photo Successfully!");
                     MantraBioTimeSDK.theForm.EventLogs.TopIndex = MantraBioTimeSDK.theForm.EventLogs.Items.Count - 1;
                 }
                 else
                 {
                     pbUserPhoto.Image = null;
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

        private void btnSetUserPhoto_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            int _flgVal = 0;
            try
            {
                _flgVal = MantraBioTime.SetUserPhoto(clsGlobal.DeviceType, this.txtPhUserId.Text.Trim(), this.tbGetPhotoPath.Text.Trim());
                if (_flgVal == 0)
                {
                    using (FileStream file = new FileStream(tbGetPhotoPath.Text.Trim() + this.txtPhUserId.Text.Trim() + ".jpg", FileMode.Open)) 
                    {
                        byte[] b = new byte[file.Length];
                        file.Read(b, 0, b.Length);
                        MemoryStream stream = new MemoryStream(b);
                        pbUserPhoto.Image = Image.FromStream(stream);
                    }
                    MantraBioTimeSDK.theForm.EventLogs.Items.Add("Set User Photo Successfully!");
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

        private void btnDeleteUserPhoto_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            int _flgVal = 0;
            try
            {
                _flgVal = MantraBioTime.DelUserPhoto(clsGlobal.DeviceType, this.txtPhUserId.Text.Trim());
                if (_flgVal == 0)
                {
                    MantraBioTimeSDK.theForm.EventLogs.Items.Add("Delete User Photo Successfully!");
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

        private void btnStartEnrollFP_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            int _flgVal = 0;
            try
            {
                _flgVal = MantraBioTime.StartEnrollFP(clsGlobal.DeviceType, txtUserREID.Text, cbFIndex.SelectedIndex);
                if (_flgVal == 0)
                {
                    MantraBioTimeSDK.theForm.EventLogs.Items.Add("Enroll Finger Successfully!");
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

        private void btnStartEnrollFace_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            int _flgVal = 0;
            try
            {
                _flgVal = MantraBioTime.StartEnrollFace(clsGlobal.DeviceType, txtUserREID.Text);
                if (_flgVal == 0)
                {
                    MantraBioTimeSDK.theForm.EventLogs.Items.Add("Enroll Face Successfully!");
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

        private void btnStartEnrollCard_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            int _flgVal = 0;
            try
            {
               _flgVal = MantraBioTime.StartEnrollCard(clsGlobal.DeviceType, txtUserREID.Text);
                if (_flgVal == 0)
                {
                    MantraBioTimeSDK.theForm.EventLogs.Items.Add("Enroll Card Successfully!");
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

        private void btnExitEnroll_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            int _flgVal = 0;
            try
            {
                _flgVal = MantraBioTime.StopEnroll(clsGlobal.DeviceType);
                if (_flgVal == 0)
                {
                    MantraBioTimeSDK.theForm.EventLogs.Items.Add("Exit Remote Successfully!");
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

        private void btnGetUserEnrollData_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            int _flgVal = 0;
            try
            {
                List<DemographicsList> DList = new List<DemographicsList>();
                List<BiometricsList> BList = new List<BiometricsList>();
                _flgVal = MantraBioTime.GetUserEnrollData(clsGlobal.DeviceType, txtDBDUserID.Text.Trim(), ref DList, ref BList);
                if (_flgVal == 0)
                {                    
                    GetUserEnrollData(ref DList, ref BList);
                    MantraBioTimeSDK.theForm.EventLogs.Items.Add("Get User EnrollData Successfully!");
                    //Save Record
                    SqliteDB.SaveToDemographicData(ref DList);
                    SqliteDB.SaveToBiometricData(ref BList);
                    MantraBioTimeSDK.theForm.EventLogs.Items.Add("Save User EnrollData Successfully!");
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

        private void btnSetUserEnrollData_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            int _flgVal = 0;
            try
            {              
                DataTable tblData = new DataTable();               
                tblData = SqliteDB.SelectUserDataByID(Convert.ToInt64(txtDBDUserID.Text.Trim()));

                _flgVal = MantraBioTime.SetUserEnrollData(clsGlobal.DeviceType, txtDBDUserID.Text.Trim(), tblData);
                if (_flgVal == 0)
                {
                    MantraBioTimeSDK.theForm.EventLogs.Items.Add("Set User EnrollData Successfully!");
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
                if (Ex.Message.Contains("Input string was not in a correct format."))
                {
                    MantraBioTimeSDK.theForm.ErrorLogs.Items.Add("Parameter Not Valid.");
                }
                else
                {
                    MantraBioTimeSDK.theForm.ErrorLogs.Items.Add(Ex.Message);
                }
                MantraBioTimeSDK.theForm.ErrorLogs.TopIndex = MantraBioTimeSDK.theForm.ErrorLogs.Items.Count - 1;
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void btnGetAllUserEnrollData_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            int _flgVal = 0;
            try
            {                
                List<DemographicsList> DList = new List<DemographicsList>();
                List<BiometricsList> BList = new List<BiometricsList>();

                _flgVal = MantraBioTime.GetAllUserEnrollData(clsGlobal.DeviceType, ref DList, ref BList);
                if (_flgVal == 0)                
                {                   
                    GetAllUserEnrollData(ref DList, ref BList);
                    MantraBioTimeSDK.theForm.EventLogs.Items.Add("Get All User EnrollData Successfully!");
                    //Save Record
                    SqliteDB.SaveToDemographicData(ref DList);
                    SqliteDB.SaveToBiometricData(ref BList);
                    MantraBioTimeSDK.theForm.EventLogs.Items.Add("Save All User EnrollData Successfully!");
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

        private void btnSetAllUserEnrollData_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            int _flgVal = 0;
            try
            {              
                DataTable tblData = new DataTable();
                tblData = SqliteDB.SelectAllUserData();

                _flgVal = MantraBioTime.SetAllUserEnrollData(clsGlobal.DeviceType, tblData);
                if (_flgVal == 0)
                {
                    MantraBioTimeSDK.theForm.EventLogs.Items.Add("Set All User EnrollData Successfully!");
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

        private void btnDeleteEnrollData_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            int _flgVal = 0;
            try
            {
                _flgVal = MantraBioTime.DeleteEnrollData(clsGlobal.DeviceType, txtDBDUserID.Text);
                if (_flgVal == 0)
                {
                    MantraBioTimeSDK.theForm.EventLogs.Items.Add("Delete EnrollData Successfully!");
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

        private void btnDeleteAllEnrollData_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            int _flgVal = 0;
            try
            {
                _flgVal = MantraBioTime.DeleteAllEnrollData(clsGlobal.DeviceType);
                if (_flgVal == 0)
                {
                    MantraBioTimeSDK.theForm.EventLogs.Items.Add("Delete All EntrollData Successfully!");
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

        #region "Method"

        private void GetUserInfo(ref List<DemographicsList> DList)
        {
            if (DList.Count == 0) return;
            DemographicsList _listProp = new DemographicsList();
            txtUserID.Text = DList[0].UserId;
            txtName.Text = DList[0].UserName;
            cbPrivilege.SelectedIndex = DList[0].Privilege;
            txtCardnumber.Text = DList[0].Card;
            txtPassword.Text = DList[0].pwd;
            cbUserEnable.SelectedIndex = Convert.ToInt32(DList[0].IsEnabled);
        }

        private void GetUserValidDate(ref string FromDate, ref string ToDate)
        {
           // MantraBioTime.GetUserValidDate(clsGlobal.DeviceType, txtUserID2.Text.Trim(), ref FromDate, ref ToDate);            
            dtStartDate.Text = FromDate;
            dtEndDate.Text = ToDate;          
        }

        private void GetUserVerifyStyle(ref int iVerifyStyle)
        {           
            switch (iVerifyStyle)
            {
                case 0: cbVerifyStyle.Text = "Group Verify"; break;
                case 128: cbVerifyStyle.Text = "FP/PW/RF"; break;
                case 129: cbVerifyStyle.Text = "FP"; break;
                case 130: cbVerifyStyle.Text = "PIN"; break;
                case 131: cbVerifyStyle.Text = "PW"; break;
                case 132: cbVerifyStyle.Text = "RF"; break;
                case 133: cbVerifyStyle.Text = "FP/PW"; break;
                case 134: cbVerifyStyle.Text = "FP/RF"; break;
                case 135: cbVerifyStyle.Text = "PW/RF"; break;
                case 136: cbVerifyStyle.Text = "PIN&FP"; break;
                case 137: cbVerifyStyle.Text = "FP&PW"; break;
                case 138: cbVerifyStyle.Text = "FP&RF"; break;
                case 139: cbVerifyStyle.Text = "PW&RF"; break;
                case 140: cbVerifyStyle.Text = "FP&PW&RF"; break;
                case 141: cbVerifyStyle.Text = "PIN&FP&PW"; break;
                case 142: cbVerifyStyle.Text = "FP&RF/PIN"; break;
            }
        }

        private void GetUserEnrollData(ref List<DemographicsList> DList, ref List<BiometricsList> BList)
        {           
            listBioUsers.Items.Clear();
            bool flg = false;
            ListViewItem item; 
            int i = 1;
            foreach (var Ditem in DList)
            {
                flg = false;
                foreach (var Bitem in BList)
                {
                    item = new ListViewItem((i).ToString());
                    if (Ditem.UserId == Bitem.UserId)
                    {
                        flg = true;
                        item.SubItems.Add(Ditem.UserId);
                        item.SubItems.Add(Ditem.UserName);
                        item.SubItems.Add(Ditem.pwd);
                        item.SubItems.Add(Ditem.Card);
                        item.SubItems.Add(Ditem.Privilege.ToString());
                        item.SubItems.Add(Bitem.InputNo.ToString());
                        if (!Convert.IsDBNull(Bitem.Template))
                        {
                            item.SubItems.Add(Convert.ToBase64String(Bitem.Template));
                        }
                        else
                        {
                            item.SubItems.Add("");
                        }
                        item.SubItems.Add(Ditem.IsEnabled.ToString());
                        listBioUsers.Items.Add(item); //Add this row to the ListView
                        i++;
                    }
                }
                if (flg == false)
                {
                    item = new ListViewItem((i).ToString());
                    item.SubItems.Add(Ditem.UserId);
                    item.SubItems.Add(Ditem.UserName);
                    item.SubItems.Add(Ditem.pwd);
                    item.SubItems.Add(Ditem.Card);
                    item.SubItems.Add(Ditem.Privilege.ToString());
                    item.SubItems.Add("");
                    item.SubItems.Add("");
                    item.SubItems.Add(Ditem.IsEnabled.ToString());
                    listBioUsers.Items.Add(item); //Add this row to the ListView
                    i++;
                }
            }
        }

        private void GetAllUserEnrollData(ref List<DemographicsList> DList, ref List<BiometricsList> BList)
        {
           // MantraBioTime.GetUserEnrollData(clsGlobal.DeviceType, txtUserID.Text.Trim());
            listBioUsers.Items.Clear();
            bool flg = false;
            ListViewItem item;
            int i = 1;
            foreach (var Ditem in DList)
            {
                flg = false;
                foreach (var Bitem in BList)
                {
                    item = new ListViewItem((i).ToString());
                    if (Ditem.UserId == Bitem.UserId)
                    {
                        flg = true;                      
                        item.SubItems.Add(Ditem.UserId);
                        item.SubItems.Add(Ditem.UserName);
                        item.SubItems.Add(Ditem.pwd);
                        item.SubItems.Add(Ditem.Card);
                        item.SubItems.Add(Ditem.Privilege.ToString());                        
                        if (!Convert.IsDBNull(Bitem.InputNo))
                        {
                            item.SubItems.Add(Convert.ToString(Bitem.InputNo));
                        }
                        else
                        {
                            item.SubItems.Add("");
                        }
                        if (!Convert.IsDBNull(Bitem.Template))
                        {
                            item.SubItems.Add(Convert.ToBase64String(Bitem.Template));
                        }
                        else
                        {
                            item.SubItems.Add("");
                        }
                        item.SubItems.Add(Ditem.IsEnabled.ToString());
                        listBioUsers.Items.Add(item); //Add this row to the ListView
                        i++;
                    }
                }
                if (flg == false)
                {
                    item = new ListViewItem((i).ToString());
                    item.SubItems.Add(Ditem.UserId);
                    item.SubItems.Add(Ditem.UserName);
                    item.SubItems.Add(Ditem.pwd);
                    item.SubItems.Add(Ditem.Card);
                    item.SubItems.Add(Ditem.Privilege.ToString());
                    item.SubItems.Add("");                    
                    item.SubItems.Add("");                    
                    item.SubItems.Add(Ditem.IsEnabled.ToString());
                    listBioUsers.Items.Add(item); //Add this row to the ListView
                    i++;
                }
            }
        }

        #endregion

        private void FrmUserDataManagement_Load(object sender, EventArgs e)
        {
        }

        private void tabUserDataManagement_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabUserDataManagement.SelectedTab == tabMainUserEnrollData)
            {
                listBioUsers.Items.Clear();
                DataTable tblData = new DataTable();
                tblData = SqliteDB.SelectAllUserData();
                
                for (int i = 0; i < tblData.Rows.Count; i++)
                {
                    DataRow dr = tblData.Rows[i];
                    ListViewItem listitem = new ListViewItem((i + 1).ToString());
                    listitem.SubItems.Add(dr["UserId"].ToString().PadLeft(3));
                    listitem.SubItems.Add(dr["UserName"].ToString());
                    listitem.SubItems.Add(dr["Pwd"].ToString());
                    listitem.SubItems.Add(dr["Card"].ToString());
                    listitem.SubItems.Add(dr["Privilege"].ToString());
                    listitem.SubItems.Add(dr["InputNo"].ToString());
                    if (!Convert.IsDBNull(dr["Template"]))
                    {
                        listitem.SubItems.Add(Convert.ToBase64String((Byte[])dr["Template"]));
                    }
                    else
                    {
                        listitem.SubItems.Add("");
                    }                   
                    listitem.SubItems.Add(dr["IsEnabled"].ToString());
                    listBioUsers.Items.Add(listitem);
                }
            }
        }
                
    }
}
