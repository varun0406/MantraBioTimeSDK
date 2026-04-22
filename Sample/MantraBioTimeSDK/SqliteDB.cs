using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data;
using MantraBioTimeDLL;

namespace MantraBioTimeSDK
{    
    public class SqliteDB
    {
        static string dbDir = Application.StartupPath + "\\Database";
        static string dbName = "MantraBioTimeDB.sqlite";
        static string dbFile = dbDir + "\\" + dbName;
        static string strCon = "Data Source=" + dbFile + ";Version=3;";

        public static void CreateNewDatabase()
        {
            SQLiteConnection con = null;            
            try
            {
                if (!Directory.Exists(dbDir))
                {
                    Directory.CreateDirectory(dbDir);                    
                }
                else
                {
                    SQLiteCommand cmd;
                    if (LastDeviceType())
                    {
                        string DroptblDemographicsData = "DROP TABLE tblDemographicsData ;";
                        string DroptblBiometircsData = "DROP TABLE tblBiometircsData ;";
                        string DroptblAttnLogData = "DROP TABLE tblAttnLogData ;";
                        con = new SQLiteConnection(strCon);
                        con.Open();

                        cmd = new SQLiteCommand(DroptblDemographicsData, con);
                        cmd.ExecuteNonQuery();
                        cmd = new SQLiteCommand(DroptblBiometircsData, con);
                        cmd.ExecuteNonQuery();
                        cmd = new SQLiteCommand(DroptblAttnLogData, con);
                        cmd.ExecuteNonQuery();

                        //SQLiteConnection.CreateFile(dbFile);
                        string CreatetblDemographicsData = "CREATE TABLE IF NOT EXISTS tblDemographicsData ([Index] INTEGER PRIMARY KEY AUTOINCREMENT, MachineNo INT, DeviceType INT, UserId VARCHAR (20), UserName VARCHAR (30), pwd VARCHAR (50), Card VARCHAR (50), Privilege INT, IsEnabled BOOLEAN);";
                        string CreatetblBiometircsData = "CREATE TABLE IF NOT EXISTS tblBiometircsData ([Index] INTEGER PRIMARY KEY AUTOINCREMENT, MachineNo INT, DeviceType INT, UserId VARCHAR (20), InputNo INT, Template BLOB);";
                        string CreatetblAttnLogData = "CREATE TABLE IF NOT EXISTS tblAttnLogData (MachineNo INT,DeviceType INT, UserId VARCHAR (20), VerifyType INT, VerifyMode INT, VDateTime DATETIME);";
                        con = new SQLiteConnection(strCon);
                        con.Open();

                        cmd = new SQLiteCommand(CreatetblDemographicsData, con);
                        cmd.ExecuteNonQuery();
                        cmd = new SQLiteCommand(CreatetblBiometircsData, con);
                        cmd.ExecuteNonQuery();
                        cmd = new SQLiteCommand(CreatetblAttnLogData, con);
                        cmd.ExecuteNonQuery();
                    }
                    else {
                        //SQLiteConnection.CreateFile(dbFile);
                        string CreatetblDemographicsData = "CREATE TABLE IF NOT EXISTS tblDemographicsData ([Index] INTEGER PRIMARY KEY AUTOINCREMENT, MachineNo INT, DeviceType INT, UserId VARCHAR (20), UserName VARCHAR (30), pwd VARCHAR (50), Card VARCHAR (50), Privilege INT, IsEnabled BOOLEAN);";
                        string CreatetblBiometircsData = "CREATE TABLE IF NOT EXISTS tblBiometircsData ([Index] INTEGER PRIMARY KEY AUTOINCREMENT, MachineNo INT, DeviceType INT, UserId VARCHAR (20), InputNo INT, Template BLOB);";
                        string CreatetblAttnLogData = "CREATE TABLE IF NOT EXISTS tblAttnLogData (MachineNo INT,DeviceType INT, UserId VARCHAR (20), VerifyType INT, VerifyMode INT, VDateTime DATETIME);";
                        con = new SQLiteConnection(strCon);
                        con.Open();
                       
                        cmd = new SQLiteCommand(CreatetblDemographicsData, con);
                        cmd.ExecuteNonQuery();
                        cmd = new SQLiteCommand(CreatetblBiometircsData, con);
                        cmd.ExecuteNonQuery();
                        cmd = new SQLiteCommand(CreatetblAttnLogData, con);
                        cmd.ExecuteNonQuery();
                    }
                }

                if (!File.Exists(dbFile))
                {
                    SQLiteConnection.CreateFile(dbFile);
                    string CreatetblDemographicsData = "CREATE TABLE IF NOT EXISTS tblDemographicsData ([Index] INTEGER PRIMARY KEY AUTOINCREMENT, MachineNo INT, DeviceType INT, UserId VARCHAR (20), UserName VARCHAR (30), pwd VARCHAR (50), Card VARCHAR (50), Privilege INT, IsEnabled BOOLEAN);";
                    string CreatetblBiometircsData = "CREATE TABLE IF NOT EXISTS tblBiometircsData ([Index] INTEGER PRIMARY KEY AUTOINCREMENT, MachineNo INT, DeviceType INT, UserId VARCHAR (20), InputNo INT, Template BLOB);";
                    string CreatetblAttnLogData = "CREATE TABLE IF NOT EXISTS tblAttnLogData (MachineNo INT,DeviceType INT, UserId VARCHAR (20), VerifyType INT, VerifyMode INT, VDateTime DATETIME);";
                    con = new SQLiteConnection(strCon);
                    con.Open();

                    SQLiteCommand cmd = new SQLiteCommand(CreatetblDemographicsData, con);
                    cmd.ExecuteNonQuery();
                    cmd = new SQLiteCommand(CreatetblBiometircsData, con);
                    cmd.ExecuteNonQuery();
                    cmd = new SQLiteCommand(CreatetblAttnLogData, con);
                    cmd.ExecuteNonQuery();
                }                
            }
            catch (Exception Ex)
            {
                MantraBioTimeSDK.theForm.ErrorLogs.Items.Add(Ex.Message);
                MantraBioTimeSDK.theForm.ErrorLogs.TopIndex = MantraBioTimeSDK.theForm.ErrorLogs.Items.Count - 1;
            }
            finally
            {
                try
                {
                    if (con != null)
                    {
                        con.Close();
                        con.Dispose();                       
                    }
                }
                catch { }
            }
        }

        public static bool DeleteDatabase()
        {
            SQLiteConnection con = null;
            try
            {
                if (!Directory.Exists(dbDir))
                {
                    Directory.CreateDirectory(dbDir);
                }
                else
                {
                    string DroptblDemographicsData = "DROP TABLE tblDemographicsData ;";
                    string DroptblBiometircsData = "DROP TABLE tblBiometircsData ;";
                    string DroptblAttnLogData = "DROP TABLE tblAttnLogData ;";
                    con = new SQLiteConnection(strCon);
                    con.Open();

                    SQLiteCommand cmd = new SQLiteCommand(DroptblDemographicsData, con);
                    cmd.ExecuteNonQuery();
                    cmd = new SQLiteCommand(DroptblBiometircsData, con);
                    cmd.ExecuteNonQuery();
                    cmd = new SQLiteCommand(DroptblAttnLogData, con);
                    cmd.ExecuteNonQuery();

                    //SQLiteConnection.CreateFile(dbFile);
                    string CreatetblDemographicsData = "CREATE TABLE tblDemographicsData ([Index] INTEGER PRIMARY KEY AUTOINCREMENT, MachineNo INT, DeviceType INT, UserId VARCHAR (20), UserName VARCHAR (30), pwd VARCHAR (50), Card VARCHAR (50), Privilege INT, IsEnabled BOOLEAN);";
                    string CreatetblBiometircsData = "CREATE TABLE tblBiometircsData ([Index] INTEGER PRIMARY KEY AUTOINCREMENT, MachineNo INT, DeviceType INT, UserId VARCHAR (20), InputNo INT, Template BLOB);";
                    string CreatetblAttnLogData = "CREATE TABLE tblAttnLogData (MachineNo INT,DeviceType INT, UserId VARCHAR (20), VerifyType INT, VerifyMode INT, VDateTime DATETIME);";
                    con = new SQLiteConnection(strCon);
                    con.Open();

                    cmd = new SQLiteCommand(CreatetblDemographicsData, con);
                    cmd.ExecuteNonQuery();
                    cmd = new SQLiteCommand(CreatetblBiometircsData, con);
                    cmd.ExecuteNonQuery();
                    cmd = new SQLiteCommand(CreatetblAttnLogData, con);
                    cmd.ExecuteNonQuery();

                }

                if (!File.Exists(dbFile))
                {
                    SQLiteConnection.CreateFile(dbFile);
                    string CreatetblDemographicsData = "CREATE TABLE tblDemographicsData ([Index] INTEGER PRIMARY KEY AUTOINCREMENT, MachineNo INT, DeviceType INT, UserId VARCHAR (20), UserName VARCHAR (30), pwd VARCHAR (50), Card VARCHAR (50), Privilege INT, IsEnabled BOOLEAN);";
                    string CreatetblBiometircsData = "CREATE TABLE tblBiometircsData ([Index] INTEGER PRIMARY KEY AUTOINCREMENT, MachineNo INT, DeviceType INT, UserId VARCHAR (20), InputNo INT, Template BLOB);";
                    string CreatetblAttnLogData = "CREATE TABLE tblAttnLogData (MachineNo INT,DeviceType INT, UserId VARCHAR (20), VerifyType INT, VerifyMode INT, VDateTime DATETIME);";
                    con = new SQLiteConnection(strCon);
                    con.Open();

                    SQLiteCommand cmd = new SQLiteCommand(CreatetblDemographicsData, con);
                    cmd.ExecuteNonQuery();
                    cmd = new SQLiteCommand(CreatetblBiometircsData, con);
                    cmd.ExecuteNonQuery();
                    cmd = new SQLiteCommand(CreatetblAttnLogData, con);
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                try
                {
                    if (con != null)
                    {
                        con.Close();
                        con.Dispose();
                    }
                }
                catch { }
            }
        }

        public static bool LastDeviceType()
        {
            object result;
            SQLiteConnection con = null;
            try
            {
                string LastDataType = "SELECT DeviceType From tblDemographicsData WHERE DeviceType = " + clsGlobal.DeviceType+ " limit 1;";
                con = new SQLiteConnection(strCon);
                con.Open();

                SQLiteCommand cmd = new SQLiteCommand(LastDataType, con);
                result = cmd.ExecuteScalar();
                if (clsGlobal.DeviceType != Convert.ToInt32(result))
                {
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                try
                {
                    if (con != null)
                    {
                        con.Close();
                        con.Dispose();
                    }
                }
                catch
                {
                }
            }
            return false;
        }

        public static bool TableExists(String tableName)
        {
            using (SQLiteCommand cmd = new SQLiteCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.Connection = new SQLiteConnection(strCon);
                cmd.CommandText = "SELECT COUNT(*) AS QtRecords FROM MantraBioTimeDB WHERE type = 'table' AND name = @name";
                cmd.Parameters.AddWithValue("@name", tableName);
                if (Convert.ToInt32(cmd.ExecuteScalar()) == 0)
                    return false;
                else
                    return true;
            }
        }

        public static DataTable SelectUserDataByID(Int64 UserId)
        {
            DataTable dt = null;
            SQLiteConnection con = null;
            try
            {
                string SelectUserDataByID = "SELECT DGD.[Index] As [Index], DGD.MachineNo, DGD.DeviceType, DGD.UserId, UserName, pwd, [Card], Privilege, IsEnabled, InputNo, Template FROM  tblDemographicsData DGD LEFT OUTER JOIN tblBiometircsData BMD on DGD.UserId = BMD.UserID WHERE DGD.UserId = " + UserId + " ORDER BY CAST(DGD.UserId AS INTEGER), InputNo Asc ";
                con = new SQLiteConnection(strCon);
                con.Open();

                SQLiteCommand cmd = new SQLiteCommand(SelectUserDataByID, con);
                SQLiteDataAdapter sda = new SQLiteDataAdapter();
                sda.SelectCommand = cmd;
                dt = new DataTable();
                sda.Fill(dt);
                return dt;
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                try
                {
                    if (con != null)
                    {
                        con.Close();
                        con.Dispose();
                    }
                }
                catch { }
            }
        }

        public static DataTable SelectAllUserData()
        {
            DataTable dt = null;
            SQLiteConnection con = null;
            try
            {
                string SelectUserDataByID = "SELECT DGD.[Index] As [Index], DGD.MachineNo, DGD.DeviceType, DGD.UserId, UserName, pwd, [Card],InputNo, Template, Privilege, IsEnabled FROM  tblDemographicsData DGD LeFT OUTER JOIN tblBiometircsData BMD on DGD.UserId = BMD.UserID ORDER BY CAST(DGD.UserId AS INTEGER), InputNo Asc ";
                con = new SQLiteConnection(strCon);
                con.Open();

                SQLiteCommand cmd = new SQLiteCommand(SelectUserDataByID, con);
                SQLiteDataAdapter sda = new SQLiteDataAdapter();
                sda.SelectCommand = cmd;
                dt = new DataTable();
                sda.Fill(dt);
                return dt;
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                try
                {
                    if (con != null)
                    {
                        con.Close();
                        con.Dispose();
                    }
                }
                catch { }
            }
        }

        public static string GetDemographicDataId(string UserId)
        {
            object result;
            SQLiteConnection con = null;
            try
            {
                string QryIndex = "SELECT [Index] FROM tblDemographicsData WHERE UserId = '" + UserId + "' limit 1; ";
                con = new SQLiteConnection(strCon);
                con.Open();

                SQLiteCommand cmd = new SQLiteCommand(QryIndex, con);
                result = cmd.ExecuteScalar();
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                try
                {
                    if (con != null)
                    {
                        con.Close();
                        con.Dispose();
                    }
                }
                catch
                {
                }
            }
            return (result == null ? "" : result.ToString());
        }

        public static string GetBiometicDataId(string UserId, int InputNo)
        {
            object result;
            SQLiteConnection con = null;
            try
            {
                string QryIndex = "SELECT [Index] FROM tblBiometircsData WHERE UserId = '" + UserId + "' AND InputNo = " + InputNo + " limit 1; ";
                con = new SQLiteConnection(strCon);
                con.Open();

                SQLiteCommand cmd = new SQLiteCommand(QryIndex, con);
                result = cmd.ExecuteScalar();
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                try
                {
                    if (con != null)
                    {
                        con.Close();
                        con.Dispose();
                    }
                }
                catch
                {
                }
            }
            return (result == null ? "" : result.ToString());
        }

        public static bool SaveToDemographicData(ref List<DemographicsList> DList)
        {
            bool result = false;
            SQLiteConnection con = null;
            con = new SQLiteConnection(strCon);
            con.Open();
            try
            {
                if (DList.Count == 0) return false;
                for (int i = 0; i <= DList.Count; i++)
                {
                    if (GetDemographicDataId(DList[i].UserId) == "")
                    {
                        string InsertDemographicsDataQry = "INSERT INTO tblDemographicsData (MachineNo, DeviceType, UserId, UserName, pwd, [Card], Privilege, IsEnabled) VALUES(@MachineNo, @DeviceType, @UserId, @UserName, @pwd, @Card, @Privilege, @IsEnabled) ;";

                        SQLiteCommand cmd = new SQLiteCommand(InsertDemographicsDataQry, con);
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Add(new SQLiteParameter("@MachineNo", DList[i].MachineNo));
                        cmd.Parameters.Add(new SQLiteParameter("@DeviceType", DList[i].DeviceType));
                        cmd.Parameters.Add(new SQLiteParameter("@UserId", DList[i].UserId));
                        cmd.Parameters.Add(new SQLiteParameter("@UserName", DList[i].UserName));
                        cmd.Parameters.Add(new SQLiteParameter("@pwd", DList[i].pwd));
                        cmd.Parameters.Add(new SQLiteParameter("@Card", DList[i].Card));
                        cmd.Parameters.Add(new SQLiteParameter("@Privilege", DList[i].Privilege));
                        cmd.Parameters.Add(new SQLiteParameter("@IsEnabled", DList[i].IsEnabled));
                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        string UpdateDemographicsDataQry = "UPDATE tblDemographicsData SET MachineNo = @MachineNo, DeviceType = @DeviceType, UserId = @UserId, UserName = @UserName, pwd = @pwd, [Card] = @Card, Privilege = @Privilege, IsEnabled = @IsEnabled WHERE UserId = " + DList[i].UserId + " ";

                        SQLiteCommand cmd = new SQLiteCommand(UpdateDemographicsDataQry, con);
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Add(new SQLiteParameter("@MachineNo", DList[i].MachineNo));
                        cmd.Parameters.Add(new SQLiteParameter("@DeviceType", DList[i].DeviceType));
                        cmd.Parameters.Add(new SQLiteParameter("@UserId", DList[i].UserId));
                        cmd.Parameters.Add(new SQLiteParameter("@UserName", DList[i].UserName));
                        cmd.Parameters.Add(new SQLiteParameter("@pwd", DList[i].pwd));
                        cmd.Parameters.Add(new SQLiteParameter("@Card", DList[i].Card));
                        cmd.Parameters.Add(new SQLiteParameter("@Privilege", DList[i].Privilege));
                        cmd.Parameters.Add(new SQLiteParameter("@IsEnabled", DList[i].IsEnabled));
                        cmd.ExecuteNonQuery();
                    }
                }
                result = true;
            }
            catch (Exception)
            {
                result = false;
            }
            finally
            {
                try
                {
                    if (con != null)
                    {
                        con.Close();
                        con.Dispose();
                    }
                }
                catch
                {
                }
            }
            return result;
        }

        public static bool SaveToBiometricData(ref List<BiometricsList> BList)
        {     
           
            bool result = false;
            SQLiteConnection con = null;
            con = new SQLiteConnection(strCon);
            con.Open();            
                try
                {
                    if (BList.Count == 0) return false;
                    for (int i = 0; i <= BList.Count; i++)
                    {
                        if (GetBiometicDataId(BList[i].UserId, BList[i].InputNo) == "")
                        {
                            string InsertBiometircsDataQry = "INSERT INTO tblBiometircsData (MachineNo, DeviceType, UserId, InputNo, Template) VALUES(@MachineNo, @DeviceType, @UserId, @InputNo, @Template ) ;";

                            SQLiteCommand cmd = new SQLiteCommand(InsertBiometircsDataQry, con);
                            cmd.CommandType = CommandType.Text;
                            cmd.Parameters.Add(new SQLiteParameter("@MachineNo", BList[i].MachineNo));
                            cmd.Parameters.Add(new SQLiteParameter("@DeviceType", BList[i].DeviceType));
                            cmd.Parameters.Add(new SQLiteParameter("@UserId", BList[i].UserId));
                            cmd.Parameters.Add(new SQLiteParameter("@InputNo", BList[i].InputNo));
                            cmd.Parameters.Add(new SQLiteParameter("@Template", BList[i].Template));

                            cmd.ExecuteNonQuery();
                        }
                        else
                        {
                            string UpdateBiometircsDataQry = "UPDATE tblBiometircsData SET MachineNo = @MachineNo, DeviceType = @DeviceType, UserId = @UserId, InputNo = @InputNo, Template = @Template WHERE UserId = " + BList[i].UserId + " AND InputNo = " + BList[i].InputNo + " ";
                            SQLiteCommand cmd = new SQLiteCommand(UpdateBiometircsDataQry, con);
                            cmd.CommandType = CommandType.Text;
                            cmd.Parameters.Add(new SQLiteParameter("@MachineNo", BList[i].MachineNo));
                            cmd.Parameters.Add(new SQLiteParameter("@DeviceType", BList[i].DeviceType));
                            cmd.Parameters.Add(new SQLiteParameter("@UserId", BList[i].UserId));
                            cmd.Parameters.Add(new SQLiteParameter("@InputNo", BList[i].InputNo));
                            cmd.Parameters.Add(new SQLiteParameter("@Template", BList[i].Template));
                            cmd.ExecuteNonQuery();
                        }
                    }
                    result = true;

                }
                catch (Exception)
                {
                    result = false;
                }
                finally
                {
                    try
                    {
                        if (con != null)
                        {
                            con.Close();
                            con.Dispose();
                        }
                    }
                    catch { }
                }
            return result;
        }

        public static string CheckAttnLogData(string UserId, string vDate)
        {
            object result;
            SQLiteConnection con = null;
            try
            {
                string CheckLogData = "SELECT UserId FROM tblAttnLogData WHERE UserId = '" + UserId + "' AND VDateTime = '"  + vDate + "' limit 1; ";
                con = new SQLiteConnection(strCon);
                con.Open();

                SQLiteCommand cmd = new SQLiteCommand(CheckLogData, con);
                result = cmd.ExecuteScalar();
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                try
                {
                    if (con != null)
                    {
                        con.Close();
                        con.Dispose();
                    }
                }
                catch
                {
                }
            }
            return (result == null ? "" : result.ToString());
        }

        public static bool SaveToLogData(ref DataTable dt)
        {
            bool result = false;
            SQLiteConnection con = null;
            con = new SQLiteConnection(strCon);
            con.Open();
            try
            {
                for (int i = 0; i <= dt.Rows.Count-1; i++)
                {
                    if (CheckAttnLogData(dt.Rows[i]["UserId"].ToString(), dt.Rows[i]["VDateTime"].ToString()) == "")
                    {
                        string InsertDemographicsDataQry = "INSERT INTO tblAttnLogData (MachineNo, DeviceType, UserId, VerifyType, VerifyMode, VDateTime) VALUES(@MachineNo, @DeviceType, @UserId, @VerifyType, @VerifyMode, @VDateTime) ;";

                        SQLiteCommand cmd = new SQLiteCommand(InsertDemographicsDataQry, con);
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Add(new SQLiteParameter("@MachineNo", dt.Rows[i]["MachineNo"]));
                        cmd.Parameters.Add(new SQLiteParameter("@DeviceType", dt.Rows[i]["DeviceType"]));
                        cmd.Parameters.Add(new SQLiteParameter("@UserId", dt.Rows[i]["UserId"]));
                        cmd.Parameters.Add(new SQLiteParameter("@VerifyType", dt.Rows[i]["VerifyType"]));
                        cmd.Parameters.Add(new SQLiteParameter("@VerifyMode", dt.Rows[i]["VerifyMode"]));
                        cmd.Parameters.Add(new SQLiteParameter("@VDateTime", dt.Rows[i]["VDateTime"]));                      
                        cmd.ExecuteNonQuery();
                    }
                }
                result = true;
            }
            catch (Exception)
            {
                result = false;
            }
            finally
            {
                try
                {
                    if (con != null)
                    {
                        con.Close();
                        con.Dispose();
                    }
                }
                catch
                {
                }
            }
            return result;
        }

        public static bool SaveToLogData1(string MachineNo, int DeviceType, string UserId, string VerifyType, string VerifyMode, string VDateTime)
        {
            bool result = false;
            SQLiteConnection con = null;
            con = new SQLiteConnection(strCon);
            con.Open();
            try
            {
               
                    if (CheckAttnLogData(UserId, VDateTime) == "")
                    {
                        string InsertDemographicsDataQry = "INSERT INTO tblAttnLogData (MachineNo, DeviceType, UserId, VerifyType, VerifyMode, VDateTime) VALUES(@MachineNo, @DeviceType, @UserId, @VerifyType, @VerifyMode, @VDateTime) ;";

                        SQLiteCommand cmd = new SQLiteCommand(InsertDemographicsDataQry, con);
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Add(new SQLiteParameter("@MachineNo", MachineNo));
                        cmd.Parameters.Add(new SQLiteParameter("@DeviceType", DeviceType));
                        cmd.Parameters.Add(new SQLiteParameter("@UserId",UserId));
                        cmd.Parameters.Add(new SQLiteParameter("@VerifyType", VerifyType));
                        cmd.Parameters.Add(new SQLiteParameter("@VerifyMode", VerifyMode));
                        cmd.Parameters.Add(new SQLiteParameter("@VDateTime",VDateTime));
                        cmd.ExecuteNonQuery();
                    }                
                result = true;
            }
            catch (Exception)
            {
                result = false;
            }
            finally
            {
                try
                {
                    if (con != null)
                    {
                        con.Close();
                        con.Dispose();
                    }
                }
                catch
                {
                }
            }
            return result;
        }
    }
}
