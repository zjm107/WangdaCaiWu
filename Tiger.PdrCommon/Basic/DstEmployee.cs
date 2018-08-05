using System;
using System.Data;
using System.Runtime.Serialization.Formatters;

using Tiger.Tools;

namespace Tiger.PdrCommon.Basic
{


    partial class DstEmployee
    {
        /// <summary>
        /// 获取全部数据
        /// </summary>
        public void GetAllData()
        {
            DataSet dst = SysTools.userSer.GetUserAll();
            this.TCOM_USER.Clear();

            DataManager.ImpDataSet(dst.Tables[0], this.TCOM_USER);



        }
        /// <summary>
        /// 获取全部用户名信息
        /// </summary>
        public void GetAllUserName()
        {
            DataSet dst = SysTools.userSer.GetUserAll();
            this.TCOM_USERName.Clear();
            DataManager.ImpDataSet(dst.Tables[0], this.TCOM_USERName);
        }

        /// <summary>
        /// 根据用户ID获取用户信息
        /// </summary>
        /// <param name="strUserID"></param>
        public void GetUserByUserID(string strUserID)
        {
            DataSet dst = SysTools.basicService.GetUserByUserID(strUserID);
            DataManager.ImpDataSet(dst.Tables[0], this.TCOM_USER);
        }
        /// <summary>
        /// 获取最大编号
        /// </summary>
        /// <returns></returns>
        public int GetMaxNO()
        {
            try
            {
                return SysTools.userSer.GetMaxNO();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 重新编排员工顺序号
        /// </summary>
        public void ChangeEmployee()
        {
            try
            {
                SysTools.userSer.ChangeEmployee();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 保存
        /// </summary>
        public void Save()
        {


            DataTable tb = TCOM_USER.GetChanges();

            if (tb != null)
            {
                DataSet dst = new DataSet();
                dst.Tables.Add(tb);
                SysTools.basicSer.SaveTable(dst, "TCOM_USER");
                this.TCOM_USER.AcceptChanges();
            }

        }

        /// <summary>
        /// 保存用户 
        /// </summary>
        public void SaveEmployee()
        {

            DataTable tb = this.TCOM_USER.GetChanges();
            if (tb != null)
            {
                DataSet dst = new DataSet();
                dst.Tables.Add(tb);
                SysTools.basicSer.SaveCommonTableError(dst, "TCOM_USER");
                //Tools.DataManager.ShowError(this.TCOM_USER, erDs.Tables[0], "USERID");
                //aUserSer.SaveTableDataBase(, "", "Tiger_COMMON");
                this.TCOM_USER.AcceptChanges();
            }
        }

        public DataSet GetDeptName()
        {
            DataSet dst = SysTools.userSer.GetDeptAll();
            return dst;
        }

        public DataSet GetDepartmentByKey(string deptName)
        {
            DataSet dst = SysTools.basicService.GetDepartmentByKey(deptName);
            return dst;
        }
    }
}
