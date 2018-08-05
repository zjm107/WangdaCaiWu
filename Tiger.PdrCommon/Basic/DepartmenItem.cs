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
    /// 日 期: 2006-06-13
    ///
    /// 版 本:
    /// 作用：部门树的节点
    /// 模块编号：
    /// </summary>
    public class DepartmenItem : TreeNode
    {
        /// <summary>
        /// 
        /// </summary>
        public DepartmenItem()
        {
        }
        /// <summary>
        /// 部门节点
        /// </summary>
        /// <param name="row"></param>
        public DepartmenItem(DataRow row)
        {
            DepartmentID = row["DeptID"].ToString();
            DepartmentName = row["DeptName"].ToString();
            //m_DepartmentNo = row["DeptCode"].ToString();
            //m_DepartPrincipal = row["DepartPrincipal"].ToString();
            //m_Address = row["Address"].ToString();
            //m_Phone = row["Phone"].ToString();
            //m_Fax = row["Fax"].ToString();
            //m_EMail = row["EMail"].ToString();
            Remark = row["REMARK"].ToString();
            //m_ZipCode = row["ZipCode"].ToString();
            PDepartmentID = row["ParentDeptID"].ToString();
            DeptCategory = row["DEPTCATEGORY"].ToString();
            //m_PDepartmentName = row["PDepartmentName"].ToString();
            //m_PDepartmentNo = row["PDepartmentNo"].ToString();
            //m_DeptClass = row["DeptClass"].ToString();
            //m_No = row["No"].ToString();
        
           
            //m_DEPTTYPE = row["DEPTTYPE"].ToString();
        }
        /// <summary>
        /// 部门级别
        /// </summary>
        public string DeptCategory
        {
            get;
            set;
        }
        
        /// <summary>
        /// 设置部门字典ID
        /// </summary>
        public string DepartmentID
        {
            get;
            set;
        }
        
        /// <summary>
        /// 设置部门名称
        /// </summary>
        public string DepartmentName
        {
            get;
            set;
        }
        //string m_DepartmentNo;
        ///// <summary>
        ///// 设置部门编码
        ///// </summary>
        //public string DepartmentNo
        //{
        //    get
        //    {
        //        return m_DepartmentNo;
        //    }
        //    set
        //    {
        //        m_DepartmentNo = value;
        //    }
        //}
        //string m_DepartPrincipal;
        ///// <summary>
        ///// 设置部门负责人
        ///// </summary>
        //public string DepartPrincipal
        //{
        //    get
        //    {
        //        return m_DepartPrincipal;
        //    }
        //    set
        //    {
        //        m_DepartPrincipal = value;
        //    }
        //}
        //string m_Phone;
        ///// <summary>
        ///// 联系电话
        ///// </summary>
        //public string Phone
        //{
        //    get
        //    {
        //        return m_Phone;
        //    }
        //    set
        //    {
        //        m_Phone = value;
        //    }
        //}
        //string m_Fax;
        ///// <summary>
        ///// 传真
        ///// </summary>
        //public string Fax
        //{
        //    get
        //    {
        //        return m_Fax;
        //    }
        //    set
        //    {
        //        m_Fax = value;
        //    }
        //}
        //string m_Address;
        ///// <summary>
        ///// 部门地址
        ///// </summary>
        //public string Address
        //{
        //    get
        //    {
        //        return m_Address;
        //    }
        //    set
        //    {
        //        m_Address = value;
        //    }
        //}
        //string m_EMail;
        ///// <summary>
        ///// 电子邮件
        ///// </summary>
        //public string EMail
        //{
        //    get
        //    {
        //        return m_EMail;
        //    }
        //    set
        //    {
        //        m_EMail = value;
        //    }
        //}
        //string m_ZipCode;
        ///// <summary>
        ///// 邮编
        ///// </summary>
        //public string ZipCode
        //{
        //    get
        //    {
        //        return m_ZipCode;
        //    }
        //    set
        //    {
        //        m_ZipCode = value;
        //    }
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
        /// 所属部门字典ID 
        /// </summary>
        public string PDepartmentID
        {
            get;
            set;
        }
        //string m_PDepartmentName;
        ///// <summary>
        ///// 所属部门名称
        ///// </summary>
        //public string PDepartmentName
        //{
        //    get
        //    {
        //        return m_PDepartmentName;
        //    }
        //    set
        //    {
        //        m_PDepartmentName = value;
        //    }
        //}
        //string m_PDepartmentNo;
        ///// <summary>
        ///// 所属部门编码
        ///// </summary>
        //public string PDepartmentNo
        //{
        //    get
        //    {
        //        return m_PDepartmentNo;
        //    }
        //    set
        //    {
        //        m_PDepartmentNo = value;
        //    }
        //}
        //string m_DeptClass;
        ///// <summary>
        ///// 部门组
        ///// 
        ///// </summary>
        //public string DeptClass
        //{
        //    get
        //    {
        //        return m_DeptClass;
        //    }
        //    set
        //    {
        //        m_DeptClass = value;
        //    }
        //}
        //string m_No;
        ///// <summary>
        ///// 编号
        ///// </summary>
        //public string No
        //{
        //    get
        //    {
        //        return m_No;
        //    }
        //    set
        //    {
        //        m_No = value;
        //    }
        //}

    
        //string m_CorparationName;
        ///// <summary>
        ///// 院属单位名称
        ///// </summary>
        //public string CorparationName
        //{
        //    get
        //    {
        //        return m_CorparationName;
        //    }
        //    set
        //    {
        //        m_CorparationName = value;
        //    }
        //}
        //string m_DEPTTYPE;
        ///// <summary>
        ///// 部门类别
        ///// </summary>
        //public string DeptType
        //{
        //    get
        //    {
        //        return m_DEPTTYPE;
        //    }
        //    set
        //    {
        //        m_DEPTTYPE = value;
        //    }
        //}
        //string m_CorporationCode;
        ///// <summary>
        ///// 院属单位代码
        ///// </summary>
        //public string CorporationCode
        //{
        //    get
        //    {
        //        return m_CorporationCode;
        //    }
        //    set
        //    {
        //        m_CorporationCode = value;
        //    }
        //}
        DataRow[] departmentDs;
        /// <summary>
        /// 设置/获取该部门下的员工的一个数据集合
        /// </summary>
        public DataRow[] SeleDepEmployee
        {
            get
            {
                return departmentDs;
            }
            set
            {
                departmentDs = value;
            }
        }
        DataRow m_CurrDepartmentInfo;
        /// <summary>
        /// 获取/设置当前部门的信息
        /// </summary>
        public DataRow CurrDepartment
        {
            get
            {
                return m_CurrDepartmentInfo;
            }
            set
            {
                m_CurrDepartmentInfo = value;
            }
        }
        DataRow[] m_SubDeparmentInfo;
        /// <summary>
        /// 获取/设置一个部门下的下属部门信息
        /// </summary>
        public DataRow[] SubDeparment
        {
            get
            {
                return m_SubDeparmentInfo;
            }
            set
            {
                m_SubDeparmentInfo = value;
            }
        }
    }
}
