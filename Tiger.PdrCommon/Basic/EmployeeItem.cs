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
    /// �� ��: 2006.06.14
    ///
    /// �� ��:
    /// ���ã�Ա�����Ľڵ�
    /// ģ���ţ�
    /// </summary>
    public class EmployeeItem : TreeNode
    {

        /// <summary>
        /// Ա����
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
        /// Ա���ڵ�
        /// </summary>
        public EmployeeItem()
        {
        }

        
        /// <summary>
        /// Ա���ֵ�ID
        /// </summary>
        public string EmployeeID
        {
            get;
            set;
        }
        //string m_EmployeeNo;
        /// <summary>
        /// Ա������
        /// </summary>
        public string EmployeeNo
        {
            get;
            set;
        }
        
        /// <summary>
        /// Ա������
        /// </summary>
        public string EmployeeName
        {
            get;
            set;
        }
        
        /// <summary>
        /// �����ֵ�ID
        /// </summary>
        public string DepartmentID
        {
            get;
            set;
        }
       
        /// <summary>
        /// ����
        /// </summary>
        public string CardNo
        {
            get;
            set;
        }
   
        ///// <summary>
        ///// ְ��
        ///// </summary>
        //public string Position
        //{
        //    get;
        //    set;
        //}
     
        ///// <summary>
        ///// �Ա�
        ///// </summary>
        //public string Gender
        //{
        //    get;
        //    set;
        //}
 
        /// <summary>
        /// �绰1
        /// </summary>
        //public string Tel1
        //{

        //    get;
        //    set;
        //}
   
        /// <summary>
        /// �绰2
        /// </summary>
        //public string Tel2
        //{
        //    get;
        //    set;
        //}
     
        /// <summary>
        /// �ƶ��绰
        /// </summary>
        //public string MobileTel
        //{
        //    get;
        //    set;
        //}
      
        /// <summary>
        /// ���֤��
        /// </summary>
        //public string IDNo
        //{
        //    get;
        //    set;
        //}
      
        /// <summary>
        /// ����
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
        /// ��ַ
        /// </summary>
        //public string Address
        //{
        //    get;
        //    set;
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
        /// Ա�����
        /// </summary>
        public string EmployeeType
        {
            get;
            set;
        }
    
        /// <summary>
        /// ����
        /// </summary>
        //public string WorkType
        //{
        //    get;
        //    set;
        //}
     
        /// <summary>
        /// ʡ��
        /// </summary>
        //public string State
        //{
        //    get;
        //    set;
        //}
     
        /// <summary>
        /// ����
        /// </summary>
        //public string City
        //{
        //    get;
        //    set;
        //}
     
        /// <summary>
        /// ��������
        /// </summary>
        public string DepartmentName
        {
            get;
            set;
        }

        /// <summary>
        /// ���ű���
        /// </summary>
        //public string DepartmentNo
        //{
        //    get;
        //    set;
        //}
   
        /// <summary>
        /// Ա����
        /// </summary>
        public DataRow EmployeeRowInfo
        {
            get;
            set;
        }
    }
}
