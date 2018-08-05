using System;
using System.Collections.Generic;
using System.Data;

using System.Text;
using System.Windows.Forms;
using Tiger.Tools;

namespace Tiger.PdrCommon
{
    /// <summary>
    /// Copyright (c) 2006-2007 *********Tiger
    /// 创建人: 赵金明
    /// 日 期: 2006.08.07
    ///
    /// 版 本:
    /// 作用：为用户分配系统管理模块的树
    /// 模块编号：
    /// </summary>
    public class UserRoleTree
    {
        /// <summary>
        /// 菜单树
        /// </summary>
        private TreeView m_FunctionTree;
        /// <summary>
        /// 构造
        /// </summary>
        /// <param name="p_FunctionTree">系统菜单树</param>
        public UserRoleTree(TreeView p_FunctionTree)
        {
            m_FunctionTree = p_FunctionTree;
        }
        /// <summary>
        /// 显示用户功能树 
        /// </summary>
        public void ShowFunctionTree()
        {
            m_FunctionTree.Cursor = Cursors.WaitCursor;
            try
            {
               
                    m_FunctionTree.Nodes.Clear();
                    DataSet ds = SysTools.basicService.GetUserFunction();//获取所有菜单
                    DataRow[] RootRows = ds.Tables[0].Select("PARENTMENUNAME=''");//获取所有根菜单

                    foreach (DataRow row in RootRows)
                    {
                        UserRoleItme rNode = new UserRoleItme(row);
                        rNode.MenuTreeRowInfo = row;
                        //rNode.Text = row["FunctionID"].ToString();
                        rNode.Text = row["MENUNAME"].ToString();//菜单名
                        rNode.ImageIndex = 0;
                        rNode.SelectedImageIndex = 1;
                        m_FunctionTree.Nodes.Add(rNode);
                        //rNode.Expand();
                        ShowChildMenu(rNode.Text, ds, rNode);//显示子菜单
                    }
               

            }
            catch (Exception e)
            {
                UserMessages.ShowErrorBox(e.Message);
            }
            finally
            {
                m_FunctionTree.Cursor = Cursors.Default;
            }
        }
        /// <summary>
        /// 显示子用户功能树
        /// </summary>
        /// <param name="p_strParentMenuName">父用户功能名称</param>
        /// <param name="p_ds">数据集</param>
        /// <param name="p_MenuNode">父用户功能</param>
        private void ShowChildMenu(string p_strParentMenuName, DataSet p_ds, TreeNode p_MenuNode)
        {
            DataRow[] rows = p_ds.Tables[0].Select("PARENTMENUNAME='" + p_strParentMenuName + "'");//获取指定父菜单下一级子菜单
            foreach (DataRow row in rows)
            {
                UserRoleItme cNode = new UserRoleItme(row);
                cNode.MenuTreeRowInfo = row;
                //cNode.Text = row["FunctionID"].ToString();
                cNode.Text = row["MENUNAME"].ToString();
                cNode.ImageIndex = 0;
                cNode.SelectedImageIndex = 1;
                p_MenuNode.Nodes.Add(cNode);
                cNode.Expand();
                ShowChildMenu(cNode.Text, p_ds, cNode);
            }
        }

    }
}
