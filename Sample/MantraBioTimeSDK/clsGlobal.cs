using MantraBioTimeDLL;
using System;
using System.Collections.Generic;
using System.Text;

namespace MantraBioTimeSDK
{
    public static class clsGlobal
    {
        public static string DevID = "1";
        public static string DevIP = "192.168.1.201";
        public static string DevPort = "4370";
        public static string DevPass = "0";
        public static int DeviceType = 0;
        public static bool IsConnect = false;
        public static string ErrorPrint(int aErrorCode)
        {
            switch (aErrorCode)
            {
                case 0:
                    return "SUCCESS";
                case 1:
                    return "ERR_COMPORT_ERROR";
                case 2:
                    return "ERR_WRITE_FAIL";
                case 3:
                    return "ERR_READ_FAIL";
                case 4:
                    return "ERR_INVALID_PARAM";
                case 5:
                    return "ERR_NON_CARRYOUT";
                case 6:
                    return "ERR_LOG_END";
                case 7:
                    return "ERR_MEMORY";
                case 8:
                    return "ERR_MULTIUSER";
                default:
                    return "NO_ERROR";
            }

        }
    }
    public class ClsSetEnrollData
    {
        public int MachineNo { get; set; }
        public int DeviceType { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string pwd { get; set; }
        public string Card { get; set; }
        public int Privilege { get; set; }
        public string IsEnabled { get; set; }
        public int InputNo { get; set; }
        public Byte[] Template { get; set; }
    }
}
