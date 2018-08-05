using System;
using System.Collections.Generic;
using System.Text;

namespace Tiger.Tools
{
    /// <summary>
    /// ��¼ϵͳ��ȫ����Ϣ����
    /// </summary>
    public static  class Security
    {
        static Security()
        {
        }
        /// <summary>
        /// �û�ID
        /// </summary>
        private static string m_UserID = "";
        /// <summary>
        /// ��ǰ��½�û�ID
        /// </summary>
        public static string UserID
        {
            get
            {
                return m_UserID;
            }
            set
            {
                m_UserID = value;
            }
        }

        /// <summary>
        /// �û�����
        /// </summary>
        private static string m_UserName = "";
        /// <summary>
        /// �û�����
        /// </summary>
        public static string UserName
        {
            get
            {
                return m_UserName;
            }
            set
            {
                m_UserName = value;
            }
        }

        /// <summary>
        /// Ȩ��
        /// </summary>
        private static string m_UserPopedom = "";
        /// <summary>
        /// �û�Ȩ��
        /// </summary>
        public static string UserPopedom
        {
            get
            {
                return m_UserPopedom;
            }
            set
            {
                m_UserPopedom = value;
            }
        }

        /// <summary>
        /// ��������
        /// </summary>
        private static string m_DeptName = "";
        /// <summary>
        /// ��������
        /// </summary>
        public static string DeptName
        {
            get
            {
                return m_DeptName;
            }
            set
            {
                m_DeptName = value;
            }
        }
        /// <summary>
        /// ����
        /// </summary>
        private static string userLevel;

        /// <summary>
        /// ����
        /// </summary>
        public static string UserLevel
        {
            get
            {
                return userLevel;
            }
            set
            {
                if (userLevel == value)
                    return;
                userLevel = value;
            }
        }

        /// <summary>
        /// ����ID
        /// </summary>
        private static string m_DeptID = "";


        /// <summary>
        /// ����ID
        /// </summary>
        public static string DeptID
        {
            get
            {
                return m_DeptID;
            }
            set
            {
                m_DeptID = value;
            }
        }


        private static string userBusiness;

        /// <summary>
        /// �û�ְ��
        /// </summary>
        public static string UserBusiness
        {
            get
            {
                return userBusiness;
            }
            set
            {
                if (userBusiness == value)
                    return;
                userBusiness = value;
            }
        }


        /// <summary>
        /// ����ʹ�÷�Χ,����Ϊ"����1,����2,����3"
        /// </summary>
        public static string DataBound
        {
           get {
                return dataBound;
            }
            set {
                dataBound = value;
            }
        }

        private static string dataBound;

        /// <summary>
        /// �û�����
        /// </summary>
        private static string m_UserCode;

        /// <summary>
        /// �û�����
        /// </summary>
        public static string UserCode
        {
            get {
                return m_UserCode;
            }
            set
            {
                m_UserCode = value;
            }
        }
        /// <summary>
        /// Ժ����λ����
        /// </summary>
        private  static string m_CorporationCode = "";
        /// <summary>
        /// Ժ����λ����
        /// </summary>
        public static string CorporationCode
        {
            get
            {
                return m_CorporationCode;
            }
            set
            {
                m_CorporationCode = value;

            }
        }

        /// <summary>
        /// Ժ����λ����
        /// </summary>
        public static string CorporationName
        {
            get
            {
                return m_CorpoationName;
            }
            set
            {
                m_CorpoationName = value;
            }

        }

        /// <summary>
        /// Ժ����λ����
        /// </summary>
        private static string m_CorpoationName = "";



       


    }


}
