using System;
using System.Collections;
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
    /// ���ã�Ա�����ṹ
    /// ģ���ţ�
    /// </summary>
    public class EmployeeTree
    {
        ContextMenuStrip RMenu = new ContextMenuStrip();

        /// <summary>
        /// Ա���� 
        /// </summary>
        private TreeView m_TreeView;
        /// <summary>
        /// Ա����
        /// </summary>
        public TreeView FTreeView
        {
            get
            {
                return m_TreeView;
            }
        }

        /// <summary>
        /// ��ʾԱ����Ϣ�Ķ���
        /// </summary>
        /// <param name="treeView"></param>
        public EmployeeTree(TreeView treeView)
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
        }

        /// <summary>
        /// ��ʾ��
        /// </summary>
        public void ShowTree()
        {
            try
            {
                GetAllDeptTree();
                GetAllUserTree();
                m_TreeView.Nodes.Clear();
                DataRow[] ds = GetRootDepartment();
                foreach (DataRow row in ds)
                {
                    DepartmenItem RootNode = new DepartmenItem(row);

                    RootNode.Text = row["DeptName"].ToString();
                    RootNode.ImageIndex = 0;
                    RootNode.SelectedImageIndex = 0;
                    m_TreeView.Nodes.Add(RootNode);
                    //���Ա���ڵ�
                    AddUserNode(RootNode);
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

        public void ShowTreeByImg()
        {
            try
            {
                GetAllDeptTree();
                GetAllUserTree();
                 m_TreeView.Nodes.Clear();
                DataRow[] ds = GetRootDepartment();
                foreach (DataRow row in ds)
                {
                    DepartmenItem RootNode = new DepartmenItem(row);

                    RootNode.Text = row["DeptName"].ToString();
                    RootNode.ImageIndex = 0;
                    RootNode.SelectedImageIndex = 0;
                    m_TreeView.Nodes.Add(RootNode);
                    //���Ա���ڵ�
                    AddUserNode(RootNode);
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



        DataRow[] GetRootDepartment()
        {
            DataRow[] rows = dstDeptTree.Tables[0].Select(" PARENTDEPTID=''");
            return rows;
 
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
                    if (ds.Length == 0)
                        return;
                    foreach (DataRow row in ds)
                    {
                        DepartmenItem SubNode = new DepartmenItem(row);

                        SubNode.Text = row["DeptName"].ToString();

                        SubNode.ImageIndex = 0;
                        SubNode.SelectedImageIndex = 0;

                        rootnode.Nodes.Add(SubNode);
                        //�ݹ�ѭ�������������
                        AddDeptNodes(SubNode);
                        //���Ա���ڵ�
                        AddUserNode(SubNode);

                    }
                
            }

        }


        DataSet dstDeptTree;
        DataSet dstUserTree;

        public void GetAllDeptTree()
        {
            dstDeptTree = SysTools.basicService.GetAllDepartment();
        }
        public void GetAllUserTree()
        {
            dstUserTree = SysTools.userSer.GetUserAll();
        }


        /// <summary>
        /// ���ݲ���ID��ȡ�Ӽ�����
        /// </summary>
        /// <param name="DepartmentID"></param>
        /// <returns></returns>
        public DataRow[] GetDepartmentByDeptID(string DepartmentID)
        {

           DataRow[] rows = dstDeptTree.Tables[0].Select("PARENTDEPTID ='" + DepartmentID + "'");
           return rows;
        }
        /// <summary>
        /// ���ݲ��Ż�ȡ���û�
        /// </summary>
        /// <param name="departmentId"></param>
        /// <returns></returns>
        public DataRow[] GetUserByDept(string departmentId)
        {
            DataRow[] rows = dstUserTree.Tables[0].Select("DEPTID='"+ departmentId +"'");
            return rows;
        }

        /// <summary>
        /// ��һ�����������Ա����Ϣ
        /// </summary>
        ///<param name="RNode">���Žڵ�</param>
        public void AddUserNode(DepartmenItem RNode)
        {
            try
            {
              
                    DataRow[] ds = GetUserByDept(RNode.DepartmentID);
                    RNode.SeleDepEmployee = ds;
                    if (ds.Length == 0)
                    {
                    }
                    else
                    {
                        foreach (DataRow aRow in ds)
                        {
                            EmployeeItem employeenode = new EmployeeItem(aRow);
                            employeenode.EmployeeRowInfo = aRow;
                            employeenode.Text = aRow["UserName"].ToString();
                            employeenode.ImageIndex = 1;
                            employeenode.SelectedImageIndex = 1;
                            RNode.Nodes.Add(employeenode);
                        }
                    }
                
            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
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
        /// ѡ�в����µ�Ա���ڵ�
        /// </summary>
        public EmployeeItem SelectEmployeeItemNode
        {
            get
            {
                if (m_TreeView.SelectedNode != null)
                {
                    EmployeeItem selNode = m_TreeView.SelectedNode as EmployeeItem;
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
