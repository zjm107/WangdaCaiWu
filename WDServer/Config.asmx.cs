using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using Tiger.CoreClass.Data;

namespace WDServer
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class Config : System.Web.Services.WebService
    {

    


        /// <summary>
        /// 根据用户ID获取用户信息 
        /// </summary>
        /// <param name="p_strUserID"></param>
        /// <returns></returns>
        [WebMethod]
        public System.Data.DataSet GetUserInfo(string p_strUserID)
        {
            try
            {
                Tiger.Config.SysLogin LoginSer = new Tiger.Config.SysLogin();
                DataSet dst = LoginSer.GetUserInfo(p_strUserID);
                return dst;
            }
            catch (Exception ex)
            {
                throw ex; ;
            }
        }

        /// <summary>
        /// 用户登录 
        /// </summary>
        /// <param name="p_strLogName">用户名</param>
        /// <param name="p_strPassword">密码</param>

        /// <returns></returns>
        [WebMethod]
        public System.Data.DataSet Login(string p_strLogName, string p_strPassword)
        {
            try
            {
                Tiger.Config.SysLogin LoginSer = new Tiger.Config.SysLogin();

                DataSet dst = LoginSer.Login(p_strLogName, p_strPassword);
                return dst;
            }
            catch (Exception ex)
            {
                throw ex; ;
            }
        }


        /// <summary>
        /// 保存数据到指定的库
        /// </summary>
        /// <param name="p_ds"></param>
        /// <param name="p_strTableName"></param>
        /// <returns></returns>
        [WebMethod]
        public void SaveTable(System.Data.DataSet p_ds, string p_strTableName)
        {
            try
            {
                Tiger.Config.SysLogin LoginSer = new Tiger.Config.SysLogin();
                LoginSer.SaveTable(p_ds, p_strTableName);
            }
            catch (Exception ex)
            {
                throw ex; ;
            }
        }

        /// <summary>
        /// 获取系统功能 
        /// </summary>

        /// <returns></returns>
        [WebMethod]
        public System.Data.DataSet GetSystemFunction()
        {
            try
            {
                Tiger.Config.SystemMenu SMSer = new Tiger.Config.SystemMenu();
                DataSet dst = SMSer.GetSystemFunction();
                return dst;
            }
            catch (Exception ex)
            {
                throw ex; ;
            }
        }

        /// <summary>
        /// 获取用户在模块中的使用功能
        /// </summary>
        /// <param name="p_strApplication">应用程序名称</param>
        /// <param name="p_strUserID">用户ID</param>
        /// <returns>VUS_User2FunctionInfo</returns>
        [WebMethod]
        public System.Data.DataSet GetSystemFunctionByUser(string p_strUserID)
        {
            try
            {
                Tiger.Config.SystemMenu SMSer = new Tiger.Config.SystemMenu();
                DataSet dst = SMSer.GetSystemFunctionByUser(p_strUserID);
                return dst;
            }
            catch (Exception ex)
            {
                throw ex; ;
            }
        }

        /// <summary>
        /// 获取系统全部菜单 
        /// </summary>

        /// <returns>TS_Menu</returns>
        [WebMethod]
        public System.Data.DataSet GetSystemMenu()
        {
            try
            {
                Tiger.Config.SystemMenu SMSer = new Tiger.Config.SystemMenu();
                DataSet dst = SMSer.GetSystemMenu();
                return dst;
            }
            catch (Exception ex)
            {
                throw ex; ;
            }
        }

        /// <summary>
        /// 根据父菜单获取子菜单 
        /// </summary>
        /// <param name="p_strParentMenuName">父菜单名</param>

        /// <returns>TS_Menu</returns>
        [WebMethod]
        public System.Data.DataSet GetSystemMenuByParent(string p_strParentMenuName)
        {
            try
            {
                Tiger.Config.SystemMenu SMSer = new Tiger.Config.SystemMenu();
                DataSet dst = SMSer.GetSystemMenuByParent(p_strParentMenuName);
                return dst;
            }
            catch (Exception ex)
            {
                throw ex; ;
            }
        }

        /// <summary>
        /// 根据用户权限获取子菜单
        /// </summary>

        /// <param name="p_strUserID">用户ID</param>
        /// <returns>TS_UserMenu</returns>
        [WebMethod]
        public System.Data.DataSet GetSystemMenubyUser(string p_strUserID)
        {
            try
            {
                Tiger.Config.SystemMenu SMSer = new Tiger.Config.SystemMenu();
                DataSet dst = SMSer.GetSystemMenubyUser(p_strUserID);
                return dst;
            }
            catch (Exception ex)
            {
                throw ex; ;
            }
        }

        [WebMethod]
        public DataSet GetSystemCSMenuByUser(string userId)
        {
            try
            {
                string strSql = string.Format("select * from TCOM_MENU where MenuID in (  select MENUID from TCOM_ROLESMENU where RoleID in ( select RoleID from TCOM_USERSROLE where UserID='{0}' )  )  order by SEQNO", userId);
                DataSet dst = ServiceManager.GetDatabase().GetEntity(strSql, "TCOM_MENU");
                return dst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 获取根节点菜单 
        /// </summary>

        /// <param name="p_strUserID"></param>
        /// <returns></returns>
        [WebMethod]
        public System.Data.DataSet GetSystemRoot(string p_strUserID)
        {
            try
            {
                Tiger.Config.SystemMenu SMSer = new Tiger.Config.SystemMenu();
                DataSet dst = SMSer.GetSystemRoot(p_strUserID);
                return dst;
            }
            catch (Exception ex)
            {
                throw ex; ;
            }
        }





        /// <summary>
        /// 
        /// </summary>
        /// <param name="strSql"></param>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetCommonDateSet(string strSql)
        {
            try
            {
                strSql = EnDecrypt.Decrypt(strSql);
                DataSet dst = ServiceManager.GetDatabase().GetEntity(strSql, "tableName");
                return dst;
            }
            catch (Exception ex)
            {
                throw ex; //("系统库出错:" + ex.Message);
            }

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strSql"></param>
        /// <returns></returns>
        [WebMethod]
        public int ExeCommonSql(string strSql)
        {
            try
            {
                strSql = EnDecrypt.Decrypt(strSql);
                int rowCount = ServiceManager.GetDatabase().ExecuteNonQuery(strSql);
                return rowCount;
            }
            catch (Exception ex)
            {
                throw ex; //("系统库出错:" + ex.Message);
            }
        }

     


        /// <summary>
        /// 根据条件查询金属TCONF_WORD表数据
        /// </summary>
        /// <param name="paras">查询条件哈希表</param>
        /// <returns>DataSet</returns>
        [WebMethod]
        public DataSet GetTCONF_WORDData(string groupName,string word)
        {
            string strSql = " select * from TCONF_WORD where 1=1 ";
            if (!string.IsNullOrEmpty(groupName))
            {
                strSql += " and GROUPNAME like '%" + groupName + "%'";
            }
            if (!string.IsNullOrEmpty(word))
            {
                strSql += " and GROUPLISTITEM like '%" + word + "%'";
            }
            DataSet dst = ServiceManager.GetDatabase().GetEntity(strSql, "TCONF_WORD");
            return dst;
        }

    }
}

