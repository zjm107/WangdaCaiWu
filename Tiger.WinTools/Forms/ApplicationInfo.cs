using System;
using System.Collections.Generic;
using System.Text;

namespace Tiger.Tools
{

    /// <summary>
    /// Copyright (c) 2006-2007 *********Tiger
    /// ������: 
    /// �� ��:2006��6��14��
    ///
    /// �� ��:
    /// ����:����Ӧ�ó�����Ϣ
    /// </summary>
    public��static class ApplicationInfo
    {
        static ApplicationInfo()
        { }

     

       static string  m_ApplicationTitle = "";
        /// <summary>
        /// Ӧ�ó������
        /// </summary>
        public static string ApplicationTitle
        {
            get
            {
                return m_ApplicationTitle;
            }
            set
            {
                m_ApplicationTitle = value;
            }
        }

        static string m_RegsterName = "";
        /// <summary>
        /// ע����
        /// </summary>
        public static string RegsterName
        {
            get
            {
                return m_RegsterName;
            }
            set
            {
                m_RegsterName = value;
            }
        }
        static string m_RegsterCode = "";
        /// <summary>
        /// ע����
        /// </summary>
        public static string RegsterCode
        {
            get
            {
                return m_RegsterCode;
            }
            set
            {
                m_RegsterCode = value;
            }
        }

        static string m_TryDays = "";
        /// <summary>
        /// ����ʱ�䣨�죩
        /// </summary>
        public static string TryDays
        {
            get
            {
                return m_TryDays;
            }
            set
            {
                m_TryDays = value;
            }
        }
        static string m_CompanyName = "";
        /// <summary>
        /// ��˾����
        /// </summary>
        public static string CompanyName
        {
            get
            {
                return m_CompanyName;
            }
            set
            {
                m_CompanyName = value;
            }
        }

        static string m_phoneNO1 = "";
        /// <summary>
        /// �绰����1
        /// </summary>
        public static string PhoneNO1
        {
            get
            {
                return m_phoneNO1;
            }
            set
            {
                m_phoneNO1 = value;
            }
        }
        static string m_phoneNO2 = "";
        /// <summary>
        /// �绰����2
        /// </summary>
        public static string PhoneNO2
        {
            get
            {
                return m_phoneNO2;
            }
            set
            {
                m_phoneNO2 = value;
            }
        }


        static string m_TaxNO = "";
        /// <summary>
        /// ����
        /// </summary>
        public static string TaxNO
        {
            get
            {
                return m_TaxNO;
            }
            set
            {
                m_TaxNO = value;
            }
        }

    }
}
