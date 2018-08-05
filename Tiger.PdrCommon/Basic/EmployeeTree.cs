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
    /// 创建人: 赵金明
    /// 日 期: 2006.08.07
    ///
    /// 版 本:
    /// 作用：员工树结构
    /// 模块编号：
    /// </summary>
    public class EmployeeTree
    {
        ContextMenuStrip RMenu = new ContextMenuStrip();

        /// <summary>
        /// 员工树 
        /// </summary>
        private TreeView m_TreeView;
        /// <summary>
        /// 员工树
        /// </summary>
        public TreeView FTreeView
        {
            get
            {
                return m_TreeView;
            }
        }

        /// <summary>
        /// 显示员工信息的对象
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

            ToolStripMenuItem ShowMenu = new ToolStripMenuItem("刷新");
            RMenu.Items.Add(ShowMenu);
            ShowMenu.Click += new EventHandler(ShowMenu_Click);
        }

        /// <summary>
        /// 显示树
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
                    //添加员工节点
                    AddUserNode(RootNode);
                    //添加下属部门节点
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
                    //添加员工节点
                    AddUserNode(RootNode);
                    //添加下属部门节点
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
        /// 添加下属部门节点的方法
        /// </summary>
        /// <param name="rootnode">根节点</param>
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
                        //递归循环添加下属部门
                        AddDeptNodes(SubNode);
                        //添加员工节点
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
        /// 根据部门ID获取子级部门
        /// </summary>
        /// <param name="DepartmentID"></param>
        /// <returns></returns>
        public DataRow[] GetDepartmentByDeptID(string DepartmentID)
        {

           DataRow[] rows = dstDeptTree.Tables[0].Select("PARENTDEPTID ='" + DepartmentID + "'");
           return rows;
        }
        /// <summary>
        /// 根据部门获取子用户
        /// </summary>
        /// <param name="departmentId"></param>
        /// <returns></returns>
        public DataRow[] GetUserByDept(string departmentId)
        {
            DataRow[] rows = dstUserTree.Tables[0].Select("DEPTID='"+ departmentId +"'");
            return rows;
        }

        /// <summary>
        /// 在一个部门下添加员工信息
        /// </summary>
        ///<param name="RNode">部门节点</param>
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
        /// 选中部门的节点
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
        /// 选中部门下的员工节点
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
        /// 右键选中
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
        /// 右键显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowMenu_Click(object sender, EventArgs e)
        {
            ShowTree();
        }

    }
}
