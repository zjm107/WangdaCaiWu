using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;


namespace Tiger.PdrCommon
{
    /// <summary>
    /// Copyright (c) 2006-2007 *********Tiger
    /// ������: �Խ���
    /// �� ��: 2006-06-13
    ///
    /// �� ��:
    /// ���ã��������Ľڵ�
    /// ģ���ţ�
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
        /// ���Žڵ�
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
        /// ���ż���
        /// </summary>
        public string DeptCategory
        {
            get;
            set;
        }
        
        /// <summary>
        /// ���ò����ֵ�ID
        /// </summary>
        public string DepartmentID
        {
            get;
            set;
        }
        
        /// <summary>
        /// ���ò�������
        /// </summary>
        public string DepartmentName
        {
            get;
            set;
        }
        //string m_DepartmentNo;
        ///// <summary>
        ///// ���ò��ű���
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
        ///// ���ò��Ÿ�����
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
        ///// ��ϵ�绰
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
        ///// ����
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
        ///// ���ŵ�ַ
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
        ///// �����ʼ�
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
        ///// �ʱ�
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
        /// ��ע
        /// </summary>
        public string Remark
        {
            get;
            set;
        }
      
        /// <summary>
        /// ���������ֵ�ID 
        /// </summary>
        public string PDepartmentID
        {
            get;
            set;
        }
        //string m_PDepartmentName;
        ///// <summary>
        ///// ������������
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
        ///// �������ű���
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
        ///// ������
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
        ///// ���
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
        ///// Ժ����λ����
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
        ///// �������
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
        ///// Ժ����λ����
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
        /// ����/��ȡ�ò����µ�Ա����һ�����ݼ���
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
        /// ��ȡ/���õ�ǰ���ŵ���Ϣ
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
        /// ��ȡ/����һ�������µ�����������Ϣ
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
