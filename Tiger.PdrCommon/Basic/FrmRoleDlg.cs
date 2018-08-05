using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Tiger.Tools;

namespace Tiger.PdrCommon
{
    public partial class FrmRoleDlg : DevExpress.XtraEditors.XtraForm
    {
        public FrmRoleDlg(string roleId)
        {
            InitializeComponent();
            if (!string.IsNullOrEmpty(roleId))
                RoleId = roleId;
        }
        private string RoleId;
        /// <summary>
        /// 选中角色
        /// </summary>
        /// <returns></returns>
        public DataRow GetSelectedRow()
        {
            DataRowView rv = TCOM_ROLEBindingSource.Current as DataRowView;
            if (rv != null)
            {
                return rv.Row;
            }
            else
            {
                return null;
            }
        }

        private void SaveRole()
        {
            TCOM_ROLEgridView.PostEditor();
            dstUserRole.SaveRole();
                this.Cursor = Cursors.WaitCursor;
              
           
        }
      
  

        private void FrmRoleDlg_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                UserRoleTree functionTree = new UserRoleTree(this.systemtree);
                functionTree.ShowFunctionTree();
                //保存表格默认样式
                WindDataManager.SaveDefaltGridViewLayout(TCOM_ROLEgridView, this.Name);
                //恢复表格样式
                WindDataManager.RestoreGridViewLayout(TCOM_ROLEgridView, this.Name);
                //保存默认布局样式
                WindDataManager.SaveDefaltControlLayout(layoutControl1, this.Name);
                //恢复布局样式
                WindDataManager.RestoreControlLayout(layoutControl1, this.Name);
            }
            catch (Exception ex)
            {
                UserMessages.ShowInfoBox(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void HyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //保存表格样式
            WindDataManager.SaveGridViewLayout(TCOM_ROLEgridView, this.Name);
            //保存布局样式
            WindDataManager.SaveControlLayout(layoutControl1, this.Name);
        }

        #region 清除节点的checkBoxs的选中选项
        private void CleanNodeChecks(TreeNode SubNode)
        {
            foreach (TreeNode node in SubNode.Nodes)
            {
                node.Checked = false;
                CleanSubNodeChecks(node);
            }
        }
        private void CleanSubNodeChecks(TreeNode SubNode)
        {

            foreach (TreeNode node in SubNode.Nodes)
            {
                node.Checked = false;
                CleanSubNodeChecks(node);
            }

        }
        #endregion 

        bool notChecked = false;

        private void TCOM_ROLEBindingSource_PositionChanged(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                notChecked = true;
                //清除节点上所有处于选中状态
                foreach (TreeNode node in systemtree.Nodes)
                {
                    node.Checked = false;
                    CleanNodeChecks(node);
                }

                DataRowView rv = this.TCOM_ROLEBindingSource.Current as DataRowView;
                string strRoleID = rv["ROLEID"].ToString();
                
                    DataSet ds = SysTools.basicService.GetUserRole2Function(strRoleID);
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        string strFunctionID = row["MENUID"].ToString();
                        //显示 一个角色所拥有的系统分配
                        foreach (UserRoleItme node in systemtree.Nodes)
                        {
                            string funcitonid = node.MENUID;
                            if (funcitonid == strFunctionID)
                            {
                                node.Checked = true;
                            }
                            else
                            {
                            }
                            IsNodeChecks(node, strFunctionID);
                        }
                    }
                
            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }
            finally
            {
                notChecked = false;
                this.Cursor = Cursors.Default;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try

            {
                dstUserRole.SaveRole();
                DataRowView rv = this.TCOM_ROLEBindingSource.Current as DataRowView;
                string strRoleID = rv["ROLEID"].ToString();
                int rows = SysTools.basicService.DeleteUserRole2Function(strRoleID);
                this.dstUserRole.Tables["TCOM_ROLESMENU"].Clear();
                foreach (UserRoleItme node in systemtree.Nodes)
                {
                    if (node.Checked)
                    {
                        DataRow rv1 = dstUserRole.Tables["TCOM_ROLESMENU"].NewRow();
                        rv1.BeginEdit();
                        rv1["ROLEID"] = strRoleID;
                        rv1["MENUID"] = node.MENUID;
                     
                        rv1.EndEdit();
                        dstUserRole.Tables["TCOM_ROLESMENU"].Rows.Add(rv1);
                    }
                
                    AddHaveNodeChack(node, strRoleID);
                }
                DoSaveRole2FunctionData();
                

            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }



        private void AddHaveNodeChack(UserRoleItme SubNode, string strRoleID)
        {
            foreach (UserRoleItme node in SubNode.Nodes)
            {
                if (node.Checked)
                {
                    DataRow rv = dstUserRole.Tables["TCOM_ROLESMENU"].NewRow();
                    rv.BeginEdit();
                    rv["ROLEID"] = strRoleID;
                    rv["MENUID"] = node.MENUID;
                 
                    rv.EndEdit();
                    dstUserRole.Tables["TCOM_ROLESMENU"].Rows.Add(rv);
                }
                else
                {
                }
                AddHaveSubNodeChack(node, strRoleID);
            }
        }
        private void AddHaveSubNodeChack(UserRoleItme SubNode, String strRoleID)
        {

            foreach (UserRoleItme node in SubNode.Nodes)
            {
                if (node.Checked)
                {
                    DataRow rv = dstUserRole.Tables["TCOM_ROLESMENU"].NewRow();
                    rv.BeginEdit();
                    rv["ROLEID"] = strRoleID;
                    rv["MENUID"] = node.MENUID;
                  
                    rv.EndEdit();
                    dstUserRole.Tables["TCOM_ROLESMENU"].Rows.Add(rv);
                }
                else
                {
                }
                AddHaveSubNodeChack(node, strRoleID);
            }

        }

        private void DoSaveRole2FunctionData()
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                if (this.dstUserRole.Tables["TCOM_ROLESMENU"].Rows.Count > 0)
                {
                   
                        try
                        {
                            dstUserRole.SaveRoleToMenu();
                            //dstEmployee1.TCOM_USER.AcceptChanges();
                            UserMessages.ShowInfoBox("系统分配成功！");
                        }
                        catch (Exception ex)
                        {
                            UserMessages.ShowErrorBox(ex.Message);
                        }
                    

                }
            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }


        #region 判断一个角色所拥有的系统分配，使节点处与选中状态。
        private void IsNodeChecks(UserRoleItme SubNode, string strFunctionID)
        {
            foreach (UserRoleItme node in SubNode.Nodes)
            {
                string functionid = node.MENUID;
                if (functionid == strFunctionID)
                {
                    node.Checked = true;
                }
                else
                {
                }
                IsSubNodeChecks(node, strFunctionID);
            }
        }
        private void IsSubNodeChecks(UserRoleItme SubNode, string strFunctionID)
        {

            foreach (UserRoleItme node in SubNode.Nodes)
            {
                string functionid = node.MENUID;
                if (functionid == strFunctionID)
                {
                    node.Checked = true;
                }
                else
                {
                }
                IsSubNodeChecks(node, strFunctionID);
            }

        }

        #endregion 

        private void TCOM_ROLEgridView_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                SaveRole();
            }
            catch (Exception ex)
            {
                UserMessages.ShowInfoBox(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void TCOM_ROLEgridView_RowCountChanged(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                SaveRole();
            }
            catch (Exception ex)
            {
                UserMessages.ShowInfoBox(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void TCOM_ROLEBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {

                dstUserRole.TCOM_ROLE.ROLEIDColumn.DefaultValue = Guid.NewGuid().ToString();
           

            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void FrmRoleDlg_Shown(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                //获取系统所拥有的角色信息
                dstUserRole.GetAllUserRole();
                DataRow row = dstUserRole.TCOM_ROLE.Rows.Find(RoleId);
                int index = TCOM_ROLEBindingSource.Find("ROLEID", RoleId);
                TCOM_ROLEBindingSource.Position = index;
            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        #region 设置节点选中状态，小马
        /// <summary>
        /// 控件树单击事件
        /// </summary>
        private void systemtree_Click(object sender, EventArgs e)
        {
            try
            {
                if (isCheck)
                {
                    notChecked = true;
                    TreeNode currentNode = systemtree.SelectedNode as TreeNode;
                    if (currentNode != null)
                    {
                        //当前节点是选中的
                        if (currentNode.Checked)
                        {
                            //父节点
                            TreeNode parentNode = currentNode.Parent as TreeNode;
                            //选中父节点
                            SelectedParentNode(parentNode);
                            //选中子节点
                            SelectedChildNode(currentNode);
                        }
                        else//当前节点未选中
                        {
                            //取消选中子结点
                            CancelSelectedChildNode(currentNode);
                            //父节点
                            TreeNode parentNode = currentNode.Parent as TreeNode;
                            if (parentNode != null)
                            {
                                //当前结点的所有同级节点
                                TreeNodeCollection nodes = parentNode.Nodes;
                                //记录同级结点是否有选中节点
                                bool flag = false;
                                foreach (TreeNode node in nodes)
                                {
                                    if (node.Checked)
                                    {
                                        flag = true;
                                        break;
                                    }
                                }
                                //如果同级中没有选中的节点，则取消父节点的选中状态
                                if (!flag)
                                    parentNode.Checked = false;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                notChecked = false;
                isCheck = false;
            }
        }
        /// <summary>
        /// 选中父节点
        /// </summary>
        /// <param name="parentNode">当前结点的父节点</param>
        private void SelectedParentNode(TreeNode parentNode)
        {
            if (parentNode != null)
            {
                parentNode.Checked = true;
                //递归选中父节点
                SelectedParentNode(parentNode.Parent);
            }
        }

        /// <summary>
        /// 取消选中子结点
        /// </summary>
        /// <param name="currentNode">当前节点</param>
        private void CancelSelectedChildNode(TreeNode currentNode)
        {
            if (currentNode != null)
            {
                //所有子节点
                TreeNodeCollection nodes = currentNode.Nodes;
                foreach (TreeNode node in nodes)
                {
                    node.Checked = false;
                    //递归
                    CancelSelectedChildNode(node);
                }
            }
        }

        /// <summary>
        /// 选中子节点
        /// </summary>
        /// <param name="currentNode">当前节点</param>
        private void SelectedChildNode(TreeNode currentNode)
        {
            if (currentNode != null)
            {
                //所有子节点
                TreeNodeCollection nodes = currentNode.Nodes;
                foreach (TreeNode node in nodes)
                {
                    node.Checked = true;
                    //递归
                    SelectedChildNode(node);
                }
            }
        } 
        #endregion
        bool isCheck = false;
        private void systemtree_AfterCheck(object sender, TreeViewEventArgs e)
        { 
           
            if (notChecked == false)
            {
                if (e.Node.Checked == true)
                {
                    systemtree.SelectedNode = e.Node;
                    
                }
                isCheck = true;
            }
        }

        private void btnSelectRole_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            TCOM_ROLEgridView.DelSelectedRows();
        }
    }
}
