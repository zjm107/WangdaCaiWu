using System;
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
    public class BasicService : System.Web.Services.WebService
    {


        /// <summary>
        /// 获取部门信息
        /// </summary>
        /// <param name="deptCode">部门编码</param>
        /// <param name="deptName">部门名称</param>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetDepartmentByCodeName(string deptName)
        {
            try
            {
                string strSql = "select * from TCOM_DEPT where 1=1";

                if (deptName != "")
                {
                    strSql += " and deptname='" + deptName + "'";
                }
                return ServiceManager.GetDatabase().GetEntity(strSql, "TCOM_DEPT");
            }
            catch (Exception ex)
            {
                throw ex; ;
            }
        }

        /// <summary>
        /// 根据语句获取数据集
        /// </summary>
        /// <param name="strSql">加密的</param>
        /// <param name="strTableName"></param>
        /// <param name="strDataBase"></param>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetDataBaseDataSet(string strSql, string strTableName, string strDataBase)
        {
            try
            {

                strSql = EnDecrypt.Decrypt(strSql);

                DataSet ds = ServiceManager.GetDatabase(strDataBase).GetEntity(strSql, strTableName);
                return ds;
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        #region 部门管理

        /// <summary>
        /// 获取所有部门信息数据
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetAllDepartment()
        {
            try
            {
                string strSql = "select * from vub_dept";
                DataSet ds = ServiceManager.GetDatabase().GetEntity(strSql, "TCOM_DEPT");
                return ds;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        /// <summary>
        /// 获取部门信息根据部门名称数据
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetDepartmentByKey(string strName)
        {
            try
            {
                string strSql = "select * from vub_dept where 1=1";
                if (strName != "")
                {
                    strSql += " and  deptname like '%" + strName + "%'";
                }

                DataSet ds = ServiceManager.GetDatabase().GetEntity(strSql, "TCOM_DEPT");
                return ds;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// 获取部门的根部门
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetRootDepartment()
        {
            try
            {
                string strSql = @"SELECT * FROM  vub_dept  WHERE  parentdeptid  ='" + "0" + "'";
                DataSet ds = ServiceManager.GetDatabase().GetEntity(strSql, "TCOM_DEPT");
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;;
            }

        }
        /// <summary>
        /// 获取下属部门信息
        /// </summary>
        /// <param name="DepartmentID"></param>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetDepartmentByDeptID(string DepartmentID)
        {
            try
            {
                string strSql = @"SELECT * FROM  vub_dept  WHERE parentdeptid ='" + DepartmentID + "'";
                DataSet ds = ServiceManager.GetDatabase().GetEntity(strSql, "TCOM_DEPT");
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;;
            }
        }
        /// <summary>
        /// 获取指定部门信息
        /// </summary>
        /// <param name="DepartmentID"></param>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetDeptCurrent(string DepartmentID)
        {
            try
            {
                string strSql = "select * from vub_dept where deptid= '" + DepartmentID + "'";
                DataSet ds = ServiceManager.GetDatabase().GetEntity(strSql, "TCOM_DEPT");
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;;
            }
        }
        
        #endregion


        #region 员工信息
        /// <summary>
        /// 获取指定部门ID下员工信息。
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetUserByDept(string DepartmentID)
        {
            try
            {
                string strSql = "select * from TCOM_USER where Enable=0 and deptid='" + DepartmentID + "'";
                DataSet ds = ServiceManager.GetDatabase().GetEntity(strSql, "TCOM_USER");
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;;
            }
        }
        /// <summary>
        /// 获取所有员工信息
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetAllEmployeeInfo()
        {
            try
            {

                string strSql = "select * from TCOM_USER order by SEQNO";
                DataSet ds = ServiceManager.GetDatabase().GetEntity(strSql, "TCOM_USER");
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;;
            }
        }

        /// <summary>
        /// 根据员工类别获取员工信息
        /// </summary>
        /// <param name="p_strEmployeeType">员工类别</param>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetEmployeeByType(string p_strEmployeeType)
        {
            try
            {
                string strSql = string.Format("select * from TCOM_USER where EmployeeType='{0}' order by UserName ", p_strEmployeeType);
                DataSet dst = ServiceManager.GetDatabase().GetEntity(strSql, "TCOM_USER");
                return dst;
            }
            catch (Exception ex)
            {
                throw ex; //("按类别获取员工出错："+ ex.Message ); 
            }
        }
        /// <summary>
        /// 获取最大编号
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public int GetMaxNO()
        {
            try
            {
                string strSql = @"select max(SEQNO)+1 SEQNO from dbo.TCOM_USER  ";
                DataSet dst = ServiceManager.GetDatabase().GetEntity(strSql, "TCOM_USER");
                if (dst.Tables.Count > 0)
                {
                     string maxNo =dst.Tables["TCOM_USER"].Rows[0][0].ToString();
                     if (maxNo.Trim() != "")
                     {
                         return int.Parse(maxNo);
                     }
                     else
                     {
                         return 1;
                     }
                }
                else
                {
                    return 1;
                }
            }
            catch (Exception ex)
            {
                throw ex; //("获取最大顺序号:"+ex.Message );
            }
        }

        /// <summary>
        /// 重新编排员工顺序号
        /// </summary>
        [WebMethod]
        public void ChangeEmployee()
        {
            try
            {
                string strSql = @" select * from dbo.TCOM_USER   ";
                DataSet dst = ServiceManager.GetDatabase().GetEntity(strSql, "TCOM_USER");
                int i = 1;
                foreach (DataRow row in dst.Tables["TCOM_USER"].Rows)
                {
                    row.BeginEdit();
                    row["SEQNO"] = i;
                    row.EndEdit();
                    i++;
                }
                ServiceManager.GetDatabase().Store(dst, "TCOM_USER");
            }
            catch (Exception ex)
            {
                throw ex; //("重新编排员工顺序号出错:"+ex.Message );
            }
        }
        #endregion


        #region 用户角色，权限管理
        /// <summary>
        /// 获取所有系统功能
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetUserFunction()
        {
            try
            {
                string strSql = "select * from TCOM_MENU ";
                DataSet ds = ServiceManager.GetDatabase().GetEntity(strSql, "TCOM_MENU");
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;;
            }
        }
        /// <summary>
        /// 获取系统所有的角色
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetAllUserRole()
        {
            try
            {

                string strSql = "select * from TCOM_ROLE";
                DataSet ds = ServiceManager.GetDatabase().GetEntity(strSql, "TCOM_ROLE");
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;;
            }
        }

        /// <summary>
        /// 获取一个用户所拥有的角色
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetUserRole(string userID)
        {
            try
            {
                string strSql = "select * from TCOM_ROLE where roleid in("
                    + " select roleid from TCOM_USERSROLE where userid='" + userID + "')";
                DataSet ds = ServiceManager.GetDatabase().GetEntity(strSql, "TCOM_ROLE");
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;;
            }
        }


        /// <summary>
        /// 为用户添加一个角色
        /// </summary>
        /// <param name="strUserID">用户ID</param>
        /// <param name="strRoleID">角色id</param>

        /// <returns></returns>
        [WebMethod]
        public int AddUser2Role(string strUserID, string strRoleID)
        {
            try
            {
                string strSql = "insert into TCOM_USERSROLE values('" + strUserID + "','" + strRoleID  + "','')";
                int rows = ServiceManager.GetDatabase().ExecuteNonQuery(strSql);
                return rows;
            }
            catch (Exception ex)
            {
                throw ex; //("该用户已经拥有此角色" + ex.Message);
            }

        }


        /// <summary>
        /// 为一个用户删除角色
        /// </summary>
        /// <param name="strUserID"></param>
        /// <param name="strRoleID"></param>
        /// <returns></returns>
        [WebMethod]
        public int DelectUser2Role(string strUserID, string strRoleID)
        {
            try
            {
                string strSql = "delete  from TCOM_USERSROLE where userid ='" + strUserID + "' and roleid ='" + strRoleID + "'";
                int rows = ServiceManager.GetDatabase().ExecuteNonQuery(strSql);
                return rows;
            }
            catch (Exception ex)
            {
                throw ex;;
            }
        }

        /// <summary>
        /// 获取一个角色用户系统的管理模块
        /// </summary>
        /// <param name="strRoleID"></param>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetUserRole2Function(string strRoleID)
        {
            try
            {
                string strSql = "select * from  TCOM_ROLESMENU where roleid='" + strRoleID + "'";
                DataSet ds = ServiceManager.GetDatabase().GetEntity(strSql, "TCOM_ROLESMENU");
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;;
            }
        }


        /// <summary>
        /// 删除一个角色拥有分配的系统
        /// </summary>
        /// <param name="strRoleID"></param>
        /// <returns></returns>
        [WebMethod]
        public int DeleteUserRole2Function(string strRoleID)
        {

            try
            {
                string strSql = "delete  from TCOM_ROLESMENU  where roleid ='" + strRoleID + "'";
                int rows = ServiceManager.GetDatabase().ExecuteNonQuery(strSql);
                return rows;
            }
            catch (Exception ex)
            {
                throw ex;;
            }
        }
        /// <summary>
        /// 根据卡号获取员工信息
        /// </summary>
        /// <param name="p_strCardNO">卡号</param>
        /// <returns></returns>
        [WebMethod]
        public string[] GetUserIDbyCardNO(string p_strCardNO)
        {
            try
            {
                string[] strUserInfos = new string[6];
                string strSql = string.Format("select userid,deptid,usercode,username,deptname,deptcode from vub_user where cardno='{0}'", p_strCardNO);
                DataSet dst = ServiceManager.GetDatabase().GetEntity(strSql, "TCOM_USER");
                if (dst.Tables[0].Rows.Count > 0)
                {

                    strUserInfos[0] = dst.Tables[0].Rows[0]["userid"].ToString();
                    strUserInfos[1] = dst.Tables[0].Rows[0]["deptid"].ToString();
                    strUserInfos[2] = dst.Tables[0].Rows[0]["usercode"].ToString();
                    strUserInfos[3] = dst.Tables[0].Rows[0]["username"].ToString();
                    strUserInfos[4] = dst.Tables[0].Rows[0]["deptname"].ToString();
                    strUserInfos[5] = dst.Tables[0].Rows[0]["deptcode"].ToString();

                }
                return strUserInfos;


            }
            catch (Exception ex)
            {
                throw ex;;
            }
        }

        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <param name="p_strUserID">用户ID号</param>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetUserByUserID(string p_strUserID)
        {
            try
            {
                string strSql = string.Format("select * from TCOM_USER where UserID='{0}'", p_strUserID);
                DataSet dst= ServiceManager.GetDatabase().GetEntity(strSql, "TCOM_USER");
                return dst;

            }
            catch (Exception ex)
            {
                throw ex;;
            }
        }
        #endregion

        /// <summary>
        /// 保存打印设置
        /// </summary>
        /// <param name="dst"></param>
        [WebMethod]
        public void SavePrintSettings(DataSet dst)
        {
            try
            {
                ServiceManager.GetDatabase().Store(dst, "TS_Print");
            }
            catch (Exception ex)
            {
                throw ex; //("保存打印设置出错:" + ex.Message);
            }
        }
        /// <summary>
        /// 获取全部打印设置
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetAllPrintSettings()
        {
            try
            {
                string strSql = "select * from [dbo].[TS_Print] ";
                DataSet dst = ServiceManager.GetDatabase().GetEntity(strSql, "TS_Print");
                return dst;
            }
            catch (Exception ex)
            {
                throw ex; //("获取全部打印设置出错：" + ex.Message);
            }
        }
        /// <summary>
        /// 查询打印设置
        /// </summary>
        /// <param name="modelName"></param>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetPrintSettings(string modelName)
        {
            try
            {
                string strSql = " select * from [dbo].[TS_Print] where 模块名称='" + modelName + "' ";
                DataSet dst =  ServiceManager.GetDatabase().GetEntity(strSql, "TS_Print");
                return dst;
                
            }
            catch (Exception ex)
            {
                throw ex; //("查询打印设置出错:" + ex.Message);
            }
        }

      

        /// <summary>
        /// 查询表中单一字段的非重复值（用于下拉列表）
        /// </summary>
        /// <param name="tableName">表名称</param>
        /// <param name="fieldName">字段名</param>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetTableFieldList(string tableName, string fieldName)
        {
            try
            {
                DataSet dst = new DataSet();
                if (!string.IsNullOrEmpty(tableName) && !string.IsNullOrEmpty(fieldName))
                {
                    string strSql = " select distinct " + fieldName + " from " + tableName + " where " + fieldName + " is not null";
                    dst = ServiceManager.GetDatabase().GetEntity(strSql, tableName);
                }

                return dst;
            }
            catch (Exception ex)
            {
                throw new Exception("服务端GetTableFieldList方法错误\r\n错误信息：" + ex.Message + "\r\n" + ex.InnerException.Message);
            }
        }


        /// <summary>
        /// 查询表中单一字段的非重复值（可加Sql条件）
        /// </summary>
        /// <param name="tableName">表名称</param>
        /// <param name="fieldName">字段名</param>
        /// <param name="fieldName">Sql语句条件，例：“ and 1=1”</param>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetTableFieldList2(string tableName, string fieldName, string SQLstring)
        {
            try
            {
                DataSet dst = new DataSet();
                if (!string.IsNullOrEmpty(tableName) && !string.IsNullOrEmpty(fieldName))
                {
                    string strSql = " select distinct " + fieldName + " from " + tableName + " where 1=1" + SQLstring;
                    dst = ServiceManager.GetDatabase().GetEntity(strSql, tableName);
                }
                return dst;
            }
            catch (Exception ex)
            {
                throw new Exception("服务端GetTableFieldList方法错误\r\n错误信息：" + ex.Message + "\r\n" + ex.InnerException.Message);
            }
        }



    }

}
