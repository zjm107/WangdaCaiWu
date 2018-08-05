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
    /// 日 期: 2006.08.07
    ///
    /// 版 本:
    /// 作用：用户角色结点
    /// 模块编号：
    /// </summary>
    public class UserRoleItme : TreeNode
    {
       /// <summary>
       /// 用户角色节点
       /// </summary>
       /// <param name="row"></param>
        public UserRoleItme(DataRow row)
        {
            ParentMenuName = row["PARENTMENUNAME"].ToString();
            MENUNAME = row["MENUNAME"].ToString();
            MENUID = row["MENUID"].ToString();

        }
        //string m_ParentFunctionID;
        /// <summary>
        /// 父菜单
        /// </summary>
        public string ParentMenuName
        {
            get;
            set;
        }
       
        /// <summary>
        /// 菜单名称
        /// </summary>
        public string MENUNAME
        {
            get;
            set;
        }
       
       
        /// <summary>
        /// 唯一id
        /// </summary>
        public string MENUID
        {
            get;
            set;
        }
       
        /// <summary>
        /// 返回表中的一行数据
        /// </summary>
        public DataRow MenuTreeRowInfo
        {
            get;
            set;
        }

    }
}
