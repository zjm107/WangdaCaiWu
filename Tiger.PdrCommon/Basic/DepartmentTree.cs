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
    /// 创建人: 赵金明
    /// 日 期: 2006-06-13
    ///
    /// 版 本:
    /// 作用：对此类的描述，可以引用系统设计中的描述
    /// 模块编号：模块编号，可以引用系统设计中的模块编号
    /// </summary>
    public class DepartmentTree
    {
        ContextMenuStrip RMenu = new ContextMenuStrip();

        /// <summary>
        /// 部门树 
        /// </summary>
        private TreeView m_TreeView;
        /// <summary>
        /// 部门树
        /// </summary>
        public TreeView FTreeView
        {
            get
            {
                return m_TreeView;
            }
        }
        /// <summary>
        /// 部门树 
        /// </summary>
        public DepartmentTree()
        { }
        /// <summary>
        /// 显示部门信息的对象
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

            ToolStripMenuItem ShowMenu = new ToolStripMenuItem("刷新");
            RMenu.Items.Add(ShowMenu);
            ShowMenu.Click += new EventHandler(ShowMenu_Click);
            ToolStripMenuItem ExpTree = new ToolStripMenuItem("展开全部");
            RMenu.Items.Add(ExpTree);
            ExpTree.Click += new EventHandler(ExpTree_Click);
            ToolStripMenuItem CloTree = new ToolStripMenuItem("折叠全部");
            RMenu.Items.Add(CloTree);
            CloTree.Click += new EventHandler(CloTree_Click);
            ToolStripMenuItem ExpNodeTree = new ToolStripMenuItem("展开");
            RMenu.Items.Add(ExpNodeTree);
            ExpNodeTree.Click += new EventHandler(ExpNodeTree_Click);
            ToolStripMenuItem CloNodeTree = new ToolStripMenuItem("折叠");
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
        /// 显示树
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
                        //设置当前部门的信息
                        RootNode.CurrDepartment = row;
                        RootNode.Text = row["DeptName"].ToString();
                        RootNode.ImageIndex = 0;
                        RootNode.SelectedImageIndex = 0;

                        m_TreeView.Nodes.Add(RootNode);
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


        /// <summary>
        /// 根据部门ID获取子级部门
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
        /// 添加下属部门节点的方法
        /// </summary>
        /// <param name="rootnode">根节点</param>
        private void AddDeptNodes(DepartmenItem rootnode)
        {
            if (rootnode != null)
            {
                
                    DataRow[] ds = GetDepartmentByDeptID(rootnode.DepartmentID);
                    //设置当前部门下的下属部门信息
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
                        //递归循环添加下属部门
                        AddDeptNodes(SubNode);

                    }
               
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
