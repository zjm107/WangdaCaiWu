using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Tiger.CoreClass.Data;
using System.Management;
using System.Security.Cryptography;
using System.IO;
namespace Tiger.Config
{

    /// <summary>
    ///Copyright (c) 2006-2007 *********Tiger
    /// 创建人: 赵金明
    /// 日 期: 2006-06-28
    ///
    /// 版 本:
    /// 作用：系统主菜单
    /// 模块编号
    /// </summary>
    public class SystemMenu
    {
        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <returns></returns>
        private string GetUserInfo()
        {
            string str = "";
            ManagementObjectCollection instances = new ManagementClass("Win32_Processor").GetInstances();
            foreach (ManagementObject obj2 in instances)
            {
                str = obj2.Properties["ProcessorId"].Value.ToString();
                break;
            }
            ManagementObjectCollection objects2 = new ManagementClass("win32_logicaldisk").GetInstances();
            foreach (ManagementObject obj3 in objects2)
            {
                if (obj3["DeviceID"].ToString() == "C:")
                {
                    str = str + obj3["VolumeSerialNumber"].ToString();
                    break;
                }
            }
            ManagementObjectCollection objects3 = new ManagementClass("Win32_NetworkAdapterConfiguration").GetInstances();
            foreach (ManagementObject obj2 in objects3)
            {
                if ((bool)obj2["IPEnabled"])
                {
                    str = str + obj2["MacAddress"].ToString();
                    break;
                }
            }
            str = str.Replace(":", "");
            int length = str.Length / 3;
            str = str.Substring(0, length) + str;
            str = str.Substring(str.Length - length, length) + str;
            str = str.Remove(str.Length - length, length);
            int num3 = str.Length;
            string s = "";
            for (int i = 0; i < num3; i++)
            {
                s = str.Substring(i, 1) + s;
            }
            s = "DIB93" + s + "83LDO";
            byte[] buffer = new byte[] { 0x13, 9, 20, 6, 7, 1, 5, 8 };
            byte[] buffer2 = new byte[] { 0x16, 9, 20, 0x15, 7, 1, 5, 8 };
            DESCryptoServiceProvider provider = new DESCryptoServiceProvider();
            byte[] bytes = Encoding.Default.GetBytes(s);
            provider.Key = buffer;
            provider.IV = buffer2;
            MemoryStream stream = new MemoryStream();
            CryptoStream stream2 = new CryptoStream(stream, provider.CreateEncryptor(), CryptoStreamMode.Write);
            stream2.Write(bytes, 0, bytes.Length);
            stream2.FlushFinalBlock();
            StringBuilder builder = new StringBuilder();
            foreach (byte num5 in stream.ToArray())
            {
                builder.AppendFormat("{0:X2}", num5);
            }
            return this.getSysTime(builder.ToString());
        }



        /// <summary>
        /// 获取系统时间
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        private string getSysTime(string dateTime)
        {
            try
            {
                byte[] buffer = new byte[] { 0x13, 8, 20, 0x16, 7, 1, 5, 8 };
                byte[] buffer2 = new byte[] { 0x17, 2, 20, 0x15, 7, 1, 5, 8 };
                DESCryptoServiceProvider provider = new DESCryptoServiceProvider();
                byte[] bytes = Encoding.Default.GetBytes(dateTime);
                provider.Key = buffer;
                provider.IV = buffer2;
                MemoryStream stream = new MemoryStream();
                CryptoStream stream2 = new CryptoStream(stream, provider.CreateEncryptor(), CryptoStreamMode.Write);
                stream2.Write(bytes, 0, bytes.Length);
                stream2.FlushFinalBlock();
                StringBuilder builder = new StringBuilder();
                foreach (byte num in stream.ToArray())
                {
                    builder.AppendFormat("{0:X2}", num);
                }
                return builder.ToString();
            }
            catch (Exception ex)
            {
                throw new Exception("系统加密验证出错:" + ex.Message);
            }
        }



        /// <summary>
        /// 获取根节点菜单
        /// </summary>
        /// <param name="p_strUserID"></param>
        /// <returns></returns>
        public DataSet GetSystemRoot(string p_strUserID)
        {
            DataSet entity;
            try
            {
                string strSql = "select * from TCOM_MENU where IsRoot<>0 and MenuID in (  select MENUID from TCOM_ROLESMENU where RoleID in ( select RoleID from TCOM_USERSROLE where UserID='" + p_strUserID + "' )  )  order by SEQNO";
                entity = ServiceManager.GetDatabase().GetEntity(strSql, "TCOM_MENU");
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return entity;
        }






        /// <summary>
        /// 根据父菜单获取子菜单
        /// </summary>
        /// <param name="p_strParentMenuName">父菜单名</param>
        /// <returns>TCOM_MENU</returns>
        public DataSet GetSystemMenuByParent(string p_strParentMenuName)
        {
            DataSet entity;
            try
            {
                string strSql = string.Format("select * from TCOM_MENU where ParentMenuName='{0}'  order by SEQNO ", p_strParentMenuName);
                entity = ServiceManager.GetDatabase().GetEntity(strSql, "TCOM_MENU");
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return entity;
        }







        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_strUserID"></param>
        /// <returns></returns>
        public DataSet GetSystemMenubyUser(string p_strUserID)
        {
            DataSet entity;
            try
            {
                string strSql = "select * from TCOM_MENU where MenuID in (  select MENUID from TCOM_ROLESMENU where RoleID in ( select RoleID from TCOM_USERSROLE where UserID='" + p_strUserID + "' )  )  order by SEQNO";
                entity = ServiceManager.GetDatabase().GetEntity(strSql, "TS_UserMenu");
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return entity;
        }






        /// <summary>
        /// 获取用户在模块中的使用功能
        /// </summary>
        /// <param name="p_strUserID">用户ID</param>
        /// <returns>VCOM_USERSMEUN</returns>
        public DataSet GetSystemFunctionByUser(string p_strUserID)
        {
            DataSet entity;
            try
            {
                string strSql = "select * from VCOM_USERSMEUN where UserID='" + p_strUserID + "'  ";
                entity = ServiceManager.GetDatabase().GetEntity(strSql, "VCOM_USERSMEUN");
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return entity;
        }
        /// <summary>
        /// 获取系统功能 
        /// </summary>
        /// <returns></returns>
        public DataSet GetSystemFunction()
        {
            DataSet entity;
            try
            {
                string strSql = string.Format("select * from TCOM_MENU order by SEQNO");
                entity = ServiceManager.GetDatabase().GetEntity(strSql, "TCOM_MENU");
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return entity;
        }


















        /// <summary>
        /// 获取系统全部菜单
        /// </summary>
        /// <param name="p_strApplicationName">应用程序名称</param>
        /// <returns>TCOM_MENU</returns>

        public DataSet GetSystemMenu()
        {
            DataSet entity;
            try
            {
                string strSql = "select * from TCOM_MENU order by SEQNO";
                entity = ServiceManager.GetDatabase().GetEntity(strSql, "TCOM_MENU");
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return entity;
        }







    }
}
