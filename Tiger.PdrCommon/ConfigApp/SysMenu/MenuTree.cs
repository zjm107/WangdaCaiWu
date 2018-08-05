using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

using System.Text;
using System.Windows.Forms;
using Tiger.PdrCommon;
using Tiger.Tools;

namespace Tiger.PdrCommon
{
    /// <summary>
    ///  Copyright (c) 2006-2007 *********Tiger
    /// ������: �Խ���
    /// �� ��: 2006-06-28
    ///
    /// �� ��:
    /// ���ã�ϵͳ���˵�
    /// ģ����
    /// </summary>
    public class MenuTree
    {
        /// <summary>
        /// �˵���
        /// </summary>
        private TreeView m_MenuTree;
        /// <summary>
        /// ����
        /// </summary>
        /// <param name="p_MenuTree">ϵͳ�˵���</param>
        public MenuTree(TreeView p_MenuTree )
        {
            m_MenuTree = p_MenuTree;
        }
        /// <summary>
        /// ��ʾϵͳ�˵� 
        /// </summary>
        public void ShowSystemMenu()
        {
            m_MenuTree.Cursor = Cursors.WaitCursor;
            try                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             
            {
                m_MenuTree.Nodes.Clear();
                //menuTreeList.Clear();
               
                    DataSet ds = SysTools.config.GetSystemMenu();
                    DataRow[] RootRows = ds.Tables[0].Select("IsRoot=True");
                    foreach (DataRow row in RootRows)
                    {
                        MenuNode rNode = new MenuNode();
                        rNode.Text = row["MENUNAME"].ToString();
                        rNode.ImageIndex = 0;
                        rNode.SelectedImageIndex = 1;
                        rNode.ClassName = row["CODETYPE"].ToString();
                        m_MenuTree.Nodes.Add(rNode);
                        //menuTreeList.Add(row["MENUID"].ToString(), row["MENUNAME"].ToString());
                        ShowChildMenu(rNode.Text, ds, rNode);
                    }
              

            }
            catch (Exception e)
            {
                UserMessages.ShowErrorBox(e.Message);
            }
            finally
            {
                m_MenuTree.Cursor = Cursors.Default;
            }
        }
        /// <summary>
        /// ��ʾ�Ӳ˵�
        /// </summary>
        /// <param name="p_strParentMenuName">���˵�����</param>
        /// <param name="p_ds">���ݼ�</param>
        /// <param name="p_MenuNode">���˵�</param>
        /// <param name="funTable"></param>
        /// <param name="UserfunTable"></param>
        private void ShowChildMenu(string p_strParentMenuName, DataSet p_ds, MenuNode p_MenuNode, DataTable UserfunTable, DataTable funTable)
        {
            DataRow[] rows = p_ds.Tables[0].Select("PARENTMENUNAME='" + p_strParentMenuName + "'");
            foreach (DataRow row in rows)
            {
                MenuNode cNode = new MenuNode();
                cNode.Text = row["MENUNAME"].ToString();
                cNode.ImageIndex = 0;
                cNode.SelectedImageIndex = 1;
                cNode.ClassName = row["CODETYPE"].ToString();
                p_MenuNode.Nodes.Add(cNode);
                //menuTreeList.Add(row["MENUID"].ToString(), row["MENUNAME"].ToString());
                AddFun(UserfunTable, funTable, row, cNode);
                ShowChildMenu(cNode.Text, p_ds, cNode, UserfunTable, funTable);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_strParentMenuName"></param>
        /// <param name="p_ds"></param>
        /// <param name="p_MenuNode"></param>

        private void ShowChildMenu(string p_strParentMenuName, DataSet p_ds, MenuNode p_MenuNode)
        {
            DataRow[] rows = p_ds.Tables[0].Select("PARENTMENUNAME='" + p_strParentMenuName + "'");
            foreach (DataRow row in rows)
            {
                MenuNode cNode = new MenuNode();
                cNode.Text = row["MENUNAME"].ToString();
                cNode.ImageIndex = 0;
                cNode.SelectedImageIndex = 1;
                cNode.ClassName = row["CODETYPE"].ToString();
                p_MenuNode.Nodes.Add(cNode);
                //menuTreeList.Add(row["MENUID"].ToString(), row["MENUNAME"].ToString());
                ShowChildMenu(cNode.Text, p_ds, cNode);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        //public Hashtable menuTreeList = new Hashtable();

        /// <summary>
        /// ��ʾĳһ�û���ϵͳ�˵�
        /// </summary>

        /// <param name="p_strUserID"></param>
        public void ShowSystemMenu( string p_strUserID)
        {
            m_MenuTree.Cursor = Cursors.WaitCursor;
            try
            {

                m_MenuTree.Nodes.Clear();
                //menuTreeList.Clear();

                DataSet ds = SysTools.config.GetSystemCSMenuByUser(p_strUserID);
                    DataSet rootDs = SysTools.config.GetSystemRoot( p_strUserID);
                    DataTable UserfunTable = SysTools.config.GetSystemFunctionByUser( p_strUserID).Tables[0];
                    DataTable funTable = SysTools.config.GetSystemFunction().Tables[0];
                    funTable = SysTools.config.GetSystemFunction().Tables[0];

                    foreach (DataRow rootRow in rootDs.Tables[0].Rows)
                    {

                        MenuNode rNode = new MenuNode();
                        rNode.Text = rootRow["MENUNAME"].ToString();
                        rNode.ImageIndex = 0;
                        rNode.SelectedImageIndex = 1;
                        rNode.ClassName = rootRow["CODETYPE"].ToString();
                        m_MenuTree.Nodes.Add(rNode);
                        //menuTreeList.Add(rootRow["MENUID"].ToString(), rootRow["MenuName"].ToString());
                        AddFun(UserfunTable, funTable, rootRow, rNode);
                        ShowChildMenu(rNode.Text, ds, rNode, UserfunTable, funTable);  //����ӽڵ�
                    }
               

            }
            catch (Exception e)
            {
                UserMessages.ShowErrorBox(e.Message);
            }
            finally
            {
                m_MenuTree.Cursor = Cursors.Default;
            }
        }
        /// <summary>
        /// ��Ȩ�޹���
        /// </summary>
        /// <param name="UserfunTable"></param>
        /// <param name="funTable"></param>
        /// <param name="MenuRow"></param>
        /// <param name="MenuNode"></param>
        private  void AddFun(DataTable UserfunTable, DataTable funTable, DataRow MenuRow, MenuNode MenuNode)
        {
            DataRow[] funRows = funTable.Select("PARENTMENUNAME='" + MenuRow["MENUNAME"].ToString() + "'");
            if (funRows.Length > 0)
            {
                MenuNode.AllowAdd = false;
                MenuNode.AllowDelete = false;
                MenuNode.AllowQuery = false;
                MenuNode.AllowSave = false;
                foreach (DataRow funrow in funRows)
                {
                    DataRow[] userFunRows = UserfunTable.Select("MENUID='" + funrow["MENUID"].ToString() + "'");
                    if (userFunRows.Length > 0)
                    {
                        string strFun = userFunRows[0]["MENUID"].ToString();
                        if (strFun.IndexOf("���") > -1 || strFun.IndexOf("����") > -1)
                        {
                            MenuNode.AllowAdd = true;
                        }
                        if (strFun.IndexOf("ɾ��") > -1)
                        {
                            MenuNode.AllowDelete = true;
                        }
                        if (strFun.IndexOf("��ѯ") > -1 || strFun.IndexOf("����")>-1 || strFun.IndexOf("���")>-1 || strFun.IndexOf("�鿴")>-1 || strFun.IndexOf("��ѯ")>-1)
                        {
                            MenuNode.AllowQuery = true;
                        }
                        if (strFun.IndexOf("����") > -1 || strFun.IndexOf("�ύ") > -1 || strFun.IndexOf("�޸�") > -1 || strFun.IndexOf("�༭") > -1)
                        {
                            MenuNode.AllowSave = true;
                            MenuNode.AllowAdd = true;
                            MenuNode.AllowDelete = true;
                            MenuNode.AllowQuery = true;
                        }

                    }
                }
            }
        }

    }
}
