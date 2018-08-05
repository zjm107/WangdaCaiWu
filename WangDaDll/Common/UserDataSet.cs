using System;
using System.Data;
using Tiger.Tools;

namespace WangDaDll.Common
{


    partial class UserDataSet
    {

        public void GetUserByDeptName(string deptName)
        {
            try
            {
                //赵金明改（2006-12-09）以前 employeetype='操作工'
                string strSql = " Select * from TCOM_USER where deptName ='" + deptName + "'  ";
                DataSet dst = DBHelper.UserSer.GetUserByDeptName(deptName);
                DataManager.ImpDataSet(dst.Tables[0], this.TCOM_USER);
                DataManager.ImpDataSet(dst.Tables[0], this.TCOM_USERName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public SysTools DBHelper = new SysTools();
        /// <summary>
        /// </summary>
        /// <returns></returns>
        /// 获取用户信息
        public void GetUserAll()
        {
            try
            {
                DataSet dst = DBHelper.UserSer.GetUserAll();
                DataManager.ImpDataSet(dst.Tables[0], this.TCOM_USER);
                DataManager.ImpDataSet(dst.Tables[0], this.TCOM_USERName);
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
        public void GetUserByType(string RelationshipType, string WorkType, string EMPLOYEETYPE, string userName, string deptName)
        {
            try
            {
                DataSet dst = DBHelper.UserSer.GetUserByType(RelationshipType, WorkType, EMPLOYEETYPE, userName, deptName);
                DataManager.ImpDataSet(dst.Tables[0], this.TCOM_USER);
                DataManager.ImpDataSet(dst.Tables[0], this.TCOM_USERName);
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
        public void GetUserByTeacherID(string teacherID)
        {
            try
            {
                DataSet dst = DBHelper.UserSer.GetUserByTeacherID(teacherID);
                DataManager.ImpDataSet(dst.Tables[0], this.TCOM_USER);
                DataManager.ImpDataSet(dst.Tables[0], this.TCOM_USERName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
