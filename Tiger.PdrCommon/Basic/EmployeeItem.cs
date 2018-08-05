using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;



namespace Tiger.PdrCommon
{
    /// <summary>
    /// Copyright (c) 2006-2007 *********Tiger
    /// 创建人: 赵金明
    /// 日 期: 2006.06.14
    ///
    /// 版 本:
    /// 作用：员工树的节点
    /// 模块编号：
    /// </summary>
    public class EmployeeItem : TreeNode
    {

        /// <summary>
        /// 员工树
        /// </summary>
        /// <param name="row"></param>
        public EmployeeItem(DataRow row)
        {
            
            EmployeeID = row["UserID"].ToString();
            EmployeeNo = row["UserCode"].ToString();
            EmployeeName = row["UserName"].ToString();
            DepartmentID = row["DeptID"].ToString();
            CardNo = row["CardNo"].ToString();
            //m_Position = row["UserPosition"].ToString();
            //m_Gender = row["Gender"].ToString();
            //m_Tel1 = row["Tel1"].ToString();
            //m_Tel2 = row["Tel2"].ToString();
            //MobileTel = row["MobileTel"].ToString();
            //m_IDNo = row["IDNo"].ToString();
            //m_Fax = row["Fax"].ToString();
            //m_EMail = row["EMail"].ToString();
            //m_Address = row["Address"].ToString();
            //m_Remarks = row["Remarks"].ToString();
            EmployeeType = row["EmployeeType"].ToString();
            //m_WorkType = row["WorkType"].ToString();
            //m_State = row["State"].ToString();
            //m_City = row["City"].ToString();
            DepartmentName = row["DEPTNAME"].ToString();

        }
        /// <summary>
        /// 员工节点
        /// </summary>
        public EmployeeItem()
        {
        }

        
        /// <summary>
        /// 员工字典ID
        /// </summary>
        public string EmployeeID
        {
            get;
            set;
        }
        //string m_EmployeeNo;
        /// <summary>
        /// 员工编码
        /// </summary>
        public string EmployeeNo
        {
            get;
            set;
        }
        
        /// <summary>
        /// 员工姓名
        /// </summary>
        public string EmployeeName
        {
            get;
            set;
        }
        
        /// <summary>
        /// 部门字典ID
        /// </summary>
        public string DepartmentID
        {
            get;
            set;
        }
       
        /// <summary>
        /// 卡号
        /// </summary>
        public string CardNo
        {
            get;
            set;
        }
   
        ///// <summary>
        ///// 职务
        ///// </summary>
        //public string Position
        //{
        //    get;
        //    set;
        //}
     
        ///// <summary>
        ///// 性别
        ///// </summary>
        //public string Gender
        //{
        //    get;
        //    set;
        //}
 
        /// <summary>
        /// 电话1
        /// </summary>
        //public string Tel1
        //{

        //    get;
        //    set;
        //}
   
        /// <summary>
        /// 电话2
        /// </summary>
        //public string Tel2
        //{
        //    get;
        //    set;
        //}
     
        /// <summary>
        /// 移动电话
        /// </summary>
        //public string MobileTel
        //{
        //    get;
        //    set;
        //}
      
        /// <summary>
        /// 身份证号
        /// </summary>
        //public string IDNo
        //{
        //    get;
        //    set;
        //}
      
        /// <summary>
        /// 传真
        /// </summary>
        //public string Fax
        //{
        //    get;
        //    set;
        //}
      
        /// <summary>
        /// EMail
        /// </summary>
        //public string EMail
        //{
        //    get;
        //    set;
        //}
       
        /// <summary>
        /// 地址
        /// </summary>
        //public string Address
        //{
        //    get;
        //    set;
        //}
     
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark
        {
            get;
            set;
        }
   
        /// <summary>
        /// 员工类别
        /// </summary>
        public string EmployeeType
        {
            get;
            set;
        }
    
        /// <summary>
        /// 工种
        /// </summary>
        //public string WorkType
        //{
        //    get;
        //    set;
        //}
     
        /// <summary>
        /// 省份
        /// </summary>
        //public string State
        //{
        //    get;
        //    set;
        //}
     
        /// <summary>
        /// 城市
        /// </summary>
        //public string City
        //{
        //    get;
        //    set;
        //}
     
        /// <summary>
        /// 部门名称
        /// </summary>
        public string DepartmentName
        {
            get;
            set;
        }

        /// <summary>
        /// 部门编码
        /// </summary>
        //public string DepartmentNo
        //{
        //    get;
        //    set;
        //}
   
        /// <summary>
        /// 员工行
        /// </summary>
        public DataRow EmployeeRowInfo
        {
            get;
            set;
        }
    }
}
