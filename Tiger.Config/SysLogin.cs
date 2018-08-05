using System;
using System.Collections.Generic;
using System.Text;

using Tiger.CoreClass.Data;
using System.Data;
using System.Management;
using System.Security.Cryptography;
using System.IO;


namespace Tiger.Config
{
    /// <summary>
    /// 系统登录
    /// </summary>
    public class SysLogin : BaseSer
    {


        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <returns></returns>
        private string GetUserInfo()
        {
            string idCode = "";
            string cpuInfo = "";//cpu序列号
            ManagementClass cimobject = new ManagementClass("Win32_Processor");
            ManagementObjectCollection moc = cimobject.GetInstances();
            foreach (ManagementObject mo in moc)
            {
                cpuInfo = mo.Properties["ProcessorId"].Value.ToString();
                //txtCPU.Text = cpuInfo;
                idCode = cpuInfo;
                break;
            }

            ManagementClass mcHD = new ManagementClass("win32_logicaldisk");
            ManagementObjectCollection mocHD = mcHD.GetInstances();
            foreach (ManagementObject m in mocHD)
            {
                if (m["DeviceID"].ToString() == "C:")
                {
                    //txtDisc.Text = 
                    idCode += m["VolumeSerialNumber"].ToString();
                    break;

                }
            }


            ////获取硬盘ID
            //String HDid;
            //ManagementClass cimobject1 = new ManagementClass("Win32_DiskDrive");
            //ManagementObjectCollection moc1 = cimobject1.GetInstances();
            //foreach(ManagementObject mo in moc1)
            //{
            // HDid = (string)mo.Properties["Model"].Value;
            // txtDisc.Text=HDid ;
            //}


            //获取网卡硬件地址   

            ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection moc2 = mc.GetInstances();
            foreach (ManagementObject mo in moc2)
            {
                if ((bool)mo["IPEnabled"] == true)
                {
                    //txtMac.Text = mo["MacAddress"].ToString();
                    idCode += mo["MacAddress"].ToString();
                    break;
                }
            }
            idCode = idCode.Replace(":", "");

            int i = idCode.Length;
            int len = i / 3;
            string newCode = idCode.Substring(0, len);
            idCode = newCode + idCode;
            newCode = idCode.Substring(idCode.Length - len, len);
            idCode = newCode + idCode;
            idCode = idCode.Remove(idCode.Length - len, len);
            int newLen = idCode.Length;
            string idtxt = "";
            for (int j = 0; j < newLen; j++)
            {

                idtxt = idCode.Substring(j, 1) + idtxt;
            }
            idtxt = "DIB93" + idtxt + "83LDO";
            //txtNewId.Text = idtxt;


            byte[] desKey = new byte[] { 0x13, 0x09, 0x14, 0x06, 0x07, 0x01, 0x05, 0x08 };
            byte[] desIV = new byte[] { 0x16, 0x09, 0x14, 0x15, 0x07, 0x01, 0x05, 0x08 };

            DESCryptoServiceProvider des = new DESCryptoServiceProvider();

            //把字符串放到byte数组中
            //原来使用的UTF8编码，我改成Unicode编码了，不行
            byte[] inputByteArray = Encoding.Default.GetBytes(idtxt);
            //byte[] inputByteArray=Encoding.Unicode.GetBytes(pToEncrypt);

            //建立加密对象的密钥和偏移量
            //原文使用ASCIIEncoding.ASCII方法的GetBytes方法
            //使得输入密码必须输入英文文本
            des.Key = desKey;		// ASCIIEncoding.ASCII.GetBytes(sKey);
            des.IV = desIV;			//ASCIIEncoding.ASCII.GetBytes(sKey);
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(),
                CryptoStreamMode.Write);
            //Write the byte array into the crypto stream
            //(It will end up in the memory stream)
            cs.Write(inputByteArray, 0, inputByteArray.Length);
            cs.FlushFinalBlock();

            //Get the data back from the memory stream, and into a string
            StringBuilder ret = new StringBuilder();
            foreach (byte b in ms.ToArray())
            {
                //Format as hex
                ret.AppendFormat("{0:X2}", b);
            }

            return getSysTime(ret.ToString());
        }
        /// <summary>
        /// 获取系统时间
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        private string getSysTime(string dateTime)
        {
            byte[] desKey = new byte[] { 0x13, 0x08, 0x14, 0x16, 0x07, 0x01, 0x05, 0x08 };
            byte[] desIV = new byte[] { 0x17, 0x02, 0x14, 0x15, 0x07, 0x01, 0x05, 0x08 };

            DESCryptoServiceProvider des = new DESCryptoServiceProvider();

            //把字符串放到byte数组中
            //原来使用的UTF8编码，我改成Unicode编码了，不行
            byte[] inputByteArray = Encoding.Default.GetBytes(dateTime);
            //byte[] inputByteArray=Encoding.Unicode.GetBytes(pToEncrypt);

            //建立加密对象的密钥和偏移量
            //原文使用ASCIIEncoding.ASCII方法的GetBytes方法
            //使得输入密码必须输入英文文本
            des.Key = desKey;		// ASCIIEncoding.ASCII.GetBytes(sKey);
            des.IV = desIV;			//ASCIIEncoding.ASCII.GetBytes(sKey);
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(),
                CryptoStreamMode.Write);
            //Write the byte array into the crypto stream
            //(It will end up in the memory stream)
            cs.Write(inputByteArray, 0, inputByteArray.Length);
            cs.FlushFinalBlock();

            //Get the data back from the memory stream, and into a string
            StringBuilder ret = new StringBuilder();
            foreach (byte b in ms.ToArray())
            {
                //Format as hex
                ret.AppendFormat("{0:X2}", b);
            }
            return ret.ToString();
        }
        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="p_strLogName">登录名</param>
        /// <param name="p_strPassword">密码</param>
        ///  <returns></returns>
        public DataSet Login(string p_strLogName, string p_strPassword)
        {
            try
            {
                //if (GetUserInfo() == "")
                //{
                object[] param = new object[] { p_strLogName, p_strPassword };
                string strSql = string.Format(@"select * from TCOM_USER  
                            where LogName='{0}' and LogPassword='{1}'  ", param);
                DataSet ds = ServiceManager.GetDatabase().GetEntity(strSql, "TCOM_USER");
                return ds;
                //}
                //else
                //{
                //    throw new Exception("系统错误代码'11784411',请与软件供货商联系!");
                //}
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// 用户登录,航扩
        /// </summary>
        /// <param name="p_strLogName"></param>
        /// <param name="p_strPassword"></param>
        /// <returns></returns>
        public DataSet LoginB(string p_strLogName, string p_strPassword)
        {
            try
            {
                object[] param = new object[] { p_strLogName, p_strPassword };
                string strSql = string.Format(@"select * from TCOM_USER 
                            where LogName='{0}' and LogPassword='{1}' ", param);
                DataSet ds = ServiceManager.GetDatabase().GetEntity(strSql, "TCOM_USER");
                return ds;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// 根据用户ID获取用户信息
        /// </summary>
        /// <param name="p_strUserID"></param>
        /// <returns></returns>
        public DataSet GetUserInfo(string p_strUserID)
        {
            try
            {
                string strSql = string.Format("select * from TCOM_USER where UserID='{0}'", p_strUserID);

                DataSet ds = ServiceManager.GetDatabase().GetEntity(strSql, "TCOM_USER");
                return ds;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        /// <summary>
        /// 保存数据到指定的库
        /// </summary>
        /// <param name="p_ds"></param>
        /// <param name="p_strTableName"></param>
        public override void SaveTable(DataSet p_ds, string p_strTableName)
        {
            try
            {
                ServiceManager.GetDatabase().StoreTable(p_ds.Tables[p_strTableName], false);

            }
            catch (Exception e)
            {
                throw e;
            }
        }




    }
}
