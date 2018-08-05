using System;
using System.Collections.Generic;
using System.Text;

namespace Tiger.Tools
{
    /// <summary>
    /// 记录系统安全性信息的类
    /// </summary>
    public static  class Security
    {
        static Security()
        {
        }
        /// <summary>
        /// 用户ID
        /// </summary>
        private static string m_UserID = "";
        /// <summary>
        /// 当前登陆用户ID
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
        /// 用户名称
        /// </summary>
        private static string m_UserName = "";
        /// <summary>
        /// 用户姓名
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
        /// 权限
        /// </summary>
        private static string m_UserPopedom = "";
        /// <summary>
        /// 用户权限
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
        /// 部门名称
        /// </summary>
        private static string m_DeptName = "";
        /// <summary>
        /// 部门名称
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
        /// 级别
        /// </summary>
        private static string userLevel;

        /// <summary>
        /// 级别
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
        /// 部门ID
        /// </summary>
        private static string m_DeptID = "";


        /// <summary>
        /// 部门ID
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
        /// 用户职务
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
        /// 数据使用范围,描述为"部门1,部门2,部门3"
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
        /// 用户编码
        /// </summary>
        private static string m_UserCode;

        /// <summary>
        /// 用户编码
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
        /// 院属单位编码
        /// </summary>
        private  static string m_CorporationCode = "";
        /// <summary>
        /// 院属单位编码
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
        /// 院属单位名称
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
        /// 院属单位名称
        /// </summary>
        private static string m_CorpoationName = "";



       


    }


}
