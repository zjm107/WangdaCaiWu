using System;
using System.Collections.Generic;
using System.Data;

using System.Text;
using System.Windows.Forms;

//using Tiger.CoreClass.Data;
using Tiger.Tools;



namespace Tiger.PdrCommon
{
    /// <summary>
    /// Copyright (c) 2006-2007 *********Tiger
    /// ������: �Խ���
    /// �� ��: 2006-06-13
    ///
    /// �� ��:
    /// ���ã��Դ������������������ϵͳ����е�����
    /// ģ���ţ�ģ���ţ���������ϵͳ����е�ģ����
    /// </summary>
    public class DepartmentTree
    {
        ContextMenuStrip RMenu = new ContextMenuStrip();

        /// <summary>
        /// ������ 
        /// </summary>
        private TreeView m_TreeView;
        /// <summary>
        /// ������
        /// </summary>
        public TreeView FTreeView
        {
            get
            {
                return m_TreeView;
            }
        }
        /// <summary>
        /// ������ 
        /// </summary>
        public DepartmentTree()
        { }
        /// <summary>
        /// ��ʾ������Ϣ�Ķ���
        /// </summary>
        /// <param name="treeView"></param>
        public DepartmentTree(TreeView treeView)
        {
            m_TreeView = treeView;
            m_TreeView.MouseDown -= new MouseEventHandler(m_TreeView_MouseDown);
            m_TreeView.MouseDown += new MouseEventHandler(m_TreeView_MouseDown);

            if (m_TreeView.ContextMenuStrip != null)
            {
                RMenu = m_TreeView.ContextMenuStrip;
            }
            else
            {
                m_TreeView.ContextMenuStrip = RMenu;
            }

            ToolStripMenuItem ShowMenu = new ToolStripMenuItem("ˢ��");
            RMenu.Items.Add(ShowMenu);
            ShowMenu.Click += new EventHandler(ShowMenu_Click);
            ToolStripMenuItem ExpTree = new ToolStripMenuItem("չ��ȫ��");
            RMenu.Items.Add(ExpTree);
            ExpTree.Click += new EventHandler(ExpTree_Click);
            ToolStripMenuItem CloTree = new ToolStripMenuItem("�۵�ȫ��");
            RMenu.Items.Add(CloTree);
            CloTree.Click += new EventHandler(CloTree_Click);
            ToolStripMenuItem ExpNodeTree = new ToolStripMenuItem("չ��");
            RMenu.Items.Add(ExpNodeTree);
            ExpNodeTree.Click += new EventHandler(ExpNodeTree_Click);
            ToolStripMenuItem CloNodeTree = new ToolStripMenuItem("�۵�");
            RMenu.Items.Add(CloNodeTree);
            CloNodeTree.Click += new EventHandler(CloNodeTree_Click);
        }







        void CloNodeTree_Click(object sender, EventArgs e)
        {
            if (m_TreeView.SelectedNode != null)
            {
                m_TreeView.SelectedNode.Collapse();
            }

        }

        void ExpNodeTree_Click(object sender, EventArgs e)
        {
            if (m_TreeView.SelectedNode != null)
            {
                m_TreeView.SelectedNode.ExpandAll();
            }

        }

        void CloTree_Click(object sender, EventArgs e)
        {
            m_TreeView.CollapseAll();
        }

        void ExpTree_Click(object sender, EventArgs e)
        {
            m_TreeView.ExpandAll();
        }

        DataSet DeptDataSet;
        DataRow[] GetRootDepartment()
        {
            DataRow[] rows = DeptDataSet.Tables[0].Select(" PARENTDEPTID=''");
            return rows;
        }

        /// <summary>
        /// ��ʾ��
        /// </summary>
        public void ShowTree()
        {
            try
            {
               
                    m_TreeView.Nodes.Clear();
                    GetAllDeptTree();
                    DataRow[] ds =  GetRootDepartment();
                    foreach (DataRow row in ds)
                    {
                        DepartmenItem RootNode = new DepartmenItem(row);
                        //���õ�ǰ���ŵ���Ϣ
                        RootNode.CurrDepartment = row;
                        RootNode.Text = row["DeptName"].ToString();
                        RootNode.ImageIndex = 0;
                        RootNode.SelectedImageIndex = 0;

                        m_TreeView.Nodes.Add(RootNode);
                        //����������Žڵ�
                        AddDeptNodes(RootNode);
                    }
                

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                
            }
        }


        /// <summary>
        /// ���ݲ���ID��ȡ�Ӽ�����
        /// </summary>
        /// <param name="DepartmentID"></param>
        /// <returns></returns>
        public DataRow[] GetDepartmentByDeptID(string DepartmentID)
        {

            DataRow[] rows = DeptDataSet.Tables[0].Select("PARENTDEPTID ='" + DepartmentID + "'");
            return rows;
        }
        public void GetAllDeptTree()
        {
            DeptDataSet = SysTools.basicService.GetAllDepartment();
        }
        /// <summary>
        /// ����������Žڵ�ķ���
        /// </summary>
        /// <param name="rootnode">���ڵ�</param>
        private void AddDeptNodes(DepartmenItem rootnode)
        {
            if (rootnode != null)
            {
                
                    DataRow[] ds = GetDepartmentByDeptID(rootnode.DepartmentID);
                    //���õ�ǰ�����µ�����������Ϣ
                    rootnode.SubDeparment = ds;
                    if (ds.Length == 0)
                        return;
                    foreach (DataRow row in ds)
                    {
                        DepartmenItem SubNode = new DepartmenItem(row);
                        SubNode.CurrDepartment = row;
                        SubNode.Text = row["DeptName"].ToString();

                        SubNode.ImageIndex = 0;
                        SubNode.SelectedImageIndex = 0;

                        rootnode.Nodes.Add(SubNode);
                        //�ݹ�ѭ�������������
                        AddDeptNodes(SubNode);

                    }
               
            }

        }

        /// <summary>
        /// ѡ�в��ŵĽڵ�
        /// </summary>
        public DepartmenItem SelectDepartmenNode
        {
            get
            {
                if (m_TreeView.SelectedNode != null)
                {
                    DepartmenItem selNode = m_TreeView.SelectedNode as DepartmenItem;
                    return selNode;
                }
                else
                {
                    return null;
                }

            }
        }
        /// <summary>
        /// �Ҽ�ѡ��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void m_TreeView_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                TreeNode node = m_TreeView.GetNodeAt(e.X, e.Y);
                m_TreeView.SelectedNode = node;
            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }
        }
        /// <summary>
        /// �Ҽ���ʾ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowMenu_Click(object sender, EventArgs e)
        {
            ShowTree();
        }


    }

}
