using System;
using System.Collections.Generic;
using System.Text;

namespace Tiger.Tools
{

    /// <summary>
    /// Copyright (c) 2006-2007 *********Tiger
    /// 创建人: 
    /// 日 期:2006年6月14日
    ///
    /// 版 本:
    /// 作用:保存应用程序信息
    /// </summary>
    public　static class ApplicationInfo
    {
        static ApplicationInfo()
        { }

     

       static string  m_ApplicationTitle = "";
        /// <summary>
        /// 应用程序标题
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
        /// 注册名
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
        /// 注册码
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
        /// 试用时间（天）
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
        /// 公司名称
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
        /// 电话号码1
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
        /// 电话号码2
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
        /// 传真
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
