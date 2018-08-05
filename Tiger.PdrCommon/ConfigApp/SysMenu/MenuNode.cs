using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Tiger.PdrCommon
{
    /// <summary>
    ///  Copyright (c) 2006-2007 *********Tiger
    /// 创建人: 赵金明
    /// 日 期: 2006-06-28
    ///
    /// 版 本:
    /// 作用：系统主菜单
    /// 模块编号
    /// </summary>
    public class MenuNode:TreeNode
    {

        bool m_AllowQuery = true;
        /// <summary>
        /// 允许查询
        /// </summary>
        public bool AllowQuery
        {
            get
            {
                return m_AllowQuery;
            }
            set
            {
                m_AllowQuery = value;
            }
        }
        bool m_AllowSave = true;
        /// <summary>
        /// 允许保存
        /// </summary>
        public bool AllowSave
        {
            get
            {
                return m_AllowSave;
            }
            set
            {
                m_AllowSave = value;
            }
        }

        bool m_AllowAdd=true;
        /// <summary>
        /// 允许添加
        /// </summary>
        public bool AllowAdd
        {
            get {
                return m_AllowAdd;
            }
            set
            {
                m_AllowAdd = value;
            }
        }


        bool m_AllowDelete = true;
        /// <summary>
        /// 允许删除
        /// </summary>
        public bool AllowDelete
        {
            get
            {
                return m_AllowDelete;
            }
            set
            {
                m_AllowDelete = value;
            }
        }

        /// <summary>
        /// 类名
        /// </summary>
        public string ClassName
        {
            get;
            set;
        }


        Dictionary<string, bool> m_OtherOperation = new Dictionary<string, bool>();
        /// <summary>
        /// 其他操作权限
        /// </summary>
        public Dictionary<string, bool> OtherOperation
        {
            get
            {
                return m_OtherOperation;
            }
        }
    }
}
