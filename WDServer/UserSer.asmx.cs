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
    public class UserSer : System.Web.Services.WebService
    {
        /// <summary>
        /// 根据部门名称获取用户信息
        /// </summary>
        /// <param name="deptName"></param>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetUserByDeptName(string deptName)
        {
            try
            {
                //赵金明改（2006-12-09）以前 employeetype='操作工'
                string strSql = @" select t.*,
 CONVERT(date, convert(varchar(4), Year(getdate())) + '-' + convert(varchar(2), MONTH([BirthDay])) + '-' + CONVERT(varchar(2), day([BirthDay]))) as 预警生日
 from [dbo].[TCOM_USER] t where deptName ='" + deptName + "'  ";
                DataSet dst = ServiceManager.GetDatabase().GetEntity(strSql, "TCOM_USER");
                return dst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /// <summary>
        /// </summary>
        /// <returns></returns>
        /// 获取用户信息
        [WebMethod]
        public DataSet GetUserAll()
        {
            try
            {
                //赵金明改（2006-12-09）以前 employeetype='操作工'
                //改为 worktype='操作工'，在用户表里worktype字段存的是员工的工种
                //string strSql = "Select * from TCOM_USER where employeetype='操作工'";
                string strSql = @" select t.*,
 CONVERT(date, convert(varchar(4), Year(getdate())) + '-' + convert(varchar(2), MONTH([BirthDay])) + '-' + CONVERT(varchar(2), day([BirthDay]))) as 预警生日
 from [dbo].[TCOM_USER] t  ";
                DataSet dst = ServiceManager.GetDatabase().GetEntity(strSql, "TCOM_USER");
                return dst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        /// <summary>
        /// 根据工资类别获取薪水
        /// </summary>
        /// <param name="SalaryType"></param>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetUserByType(string RelationshipType,string WorkType,string EMPLOYEETYPE,string userName,string deptName)
        {
            try
            {
                string strSql = @"select t.*,
 CONVERT(date, convert(varchar(4), Year(getdate())) + '-' + convert(varchar(2), MONTH([BirthDay])) + '-' + CONVERT(varchar(2), day([BirthDay]))) as 预警生日
 from [dbo].[TCOM_USER] t where 1=1 ";
                if (!string.IsNullOrEmpty(RelationshipType))
                {
                    strSql += " and RelationshipType='"+ RelationshipType + "'";
                }
                if (!string.IsNullOrEmpty(WorkType))
                {
                    strSql += " and WorkType ='"+ WorkType  +"'";

                }
                if (!string.IsNullOrEmpty(EMPLOYEETYPE))
                {
                    strSql += " and EMPLOYEETYPE='"+ EMPLOYEETYPE +"'";
                }
                if (!string.IsNullOrEmpty(userName))
                {
                    strSql += " and [USERNAME] like '%"+ userName +"%'";
                }
                if (!string.IsNullOrEmpty(deptName))
                {
                    strSql += " and [DEPTNAME]='"+ deptName +"'";
                }
                DataSet dst = ServiceManager.GetDatabase().GetEntity(strSql, "TCOM_USER");
                return dst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 获取师父的徒弟信息
        /// </summary>
        /// <param name="teacherID"></param>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetUserByTeacherID(string teacherID)
        {
            try
            {
                string strSql = @"select t.*,
 CONVERT(date, convert(varchar(4), Year(getdate())) + '-' + convert(varchar(2), MONTH([BirthDay])) + '-' + CONVERT(varchar(2), day([BirthDay]))) as 预警生日
 from [dbo].[TCOM_USER] t where t.teacherID ='" + teacherID + "'";
                DataSet dst = ServiceManager.GetDatabase().GetEntity(strSql, "TCOM_USER");
                return dst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

      




        /// <summary>
        /// 获取最大编号
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public int GetMaxNO()
        {
           BasicService bser = new BasicService();
            return bser.GetMaxNO();
        }

        /// <summary>
        /// 重新编排员工顺序号
        /// </summary>
        [WebMethod]
        public void ChangeEmployee()
        {
            BasicService bser = new BasicService();
            bser.ChangeEmployee();
        }
        /// <summary>
        /// 获取部门信息
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetDeptAll()
        {
            try
            {
                string strSql = "Select * from TCOM_DEPT";
                DataSet dst = ServiceManager.GetDatabase().GetEntity(strSql, "TCOM_DEPT");
                return dst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 获取部门信息
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetDept()
        {
            try
            {
                DataSet ds = ServiceManager.GetDatabase().GetEntity("vub_isproductiondept");
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

