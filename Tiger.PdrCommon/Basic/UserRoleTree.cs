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
    /// ������: �Խ���
    /// �� ��: 2006.08.07
    ///
    /// �� ��:
    /// ���ã�Ϊ�û�����ϵͳ����ģ�����
    /// ģ���ţ�
    /// </summary>
    public class UserRoleTree
    {
        /// <summary>
        /// �˵���
        /// </summary>
        private TreeView m_FunctionTree;
        /// <summary>
        /// ����
        /// </summary>
        /// <param name="p_FunctionTree">ϵͳ�˵���</param>
        public UserRoleTree(TreeView p_FunctionTree)
        {
            m_FunctionTree = p_FunctionTree;
        }
        /// <summary>
        /// ��ʾ�û������� 
        /// </summary>
        public void ShowFunctionTree()
        {
            m_FunctionTree.Cursor = Cursors.WaitCursor;
            try
            {
               
                    m_FunctionTree.Nodes.Clear();
                    DataSet ds = SysTools.basicService.GetUserFunction();//��ȡ���в˵�
                    DataRow[] RootRows = ds.Tables[0].Select("PARENTMENUNAME=''");//��ȡ���и��˵�

                    foreach (DataRow row in RootRows)
                    {
                        UserRoleItme rNode = new UserRoleItme(row);
                        rNode.MenuTreeRowInfo = row;
                        //rNode.Text = row["FunctionID"].ToString();
                        rNode.Text = row["MENUNAME"].ToString();//�˵���
                        rNode.ImageIndex = 0;
                        rNode.SelectedImageIndex = 1;
                        m_FunctionTree.Nodes.Add(rNode);
                        //rNode.Expand();
                        ShowChildMenu(rNode.Text, ds, rNode);//��ʾ�Ӳ˵�
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
        /// ��ʾ���û�������
        /// </summary>
        /// <param name="p_strParentMenuName">���û���������</param>
        /// <param name="p_ds">���ݼ�</param>
        /// <param name="p_MenuNode">���û�����</param>
        private void ShowChildMenu(string p_strParentMenuName, DataSet p_ds, TreeNode p_MenuNode)
        {
            DataRow[] rows = p_ds.Tables[0].Select("PARENTMENUNAME='" + p_strParentMenuName + "'");//��ȡָ�����˵���һ���Ӳ˵�
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
