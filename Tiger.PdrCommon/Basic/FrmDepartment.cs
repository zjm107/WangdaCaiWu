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
    /// <summary>
    /// Copyright (c) 2006-2007 *********Tiger
    /// 创建人:　赵金明
    /// 日 期: 2006-10-18
    ///
    /// 版 本:
    /// 作用：对部门信息进行管理
    /// 模块编号：模块编号，可以引用系统设计中的模块编号
    /// </summary>
    public partial class FrmDepartment : DevExpress.XtraEditors.XtraForm
    {
        //部门树
        private DepartmentTree m_DepartmentTree = null;
        //添加部门根节点菜单
        ToolStripMenuItem AddDepartmentItem = null;
        ToolStripMenuItem LookCurrentDepartment = null;
        /// <summary>
        /// 部门管理
        /// </summary>
        public FrmDepartment()
        {
            InitializeComponent();
        }

        #region 处理数据的事件
        /// <summary>
        /// 保存数据
        /// </summary>
        private void DoSaveData()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                
                    gridView1.PostEditor();
                    
                    dstDepartment1.Save();
                
                    gridView1.BestFitColumns();

                     m_DepartmentTree.ShowTree();
                
                
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
        /// <summary>
        /// 导出数据
        /// </summary>
        private void ExportGridToFiles()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                WindDataManager.ExportGrid(this.tB_DepartmentGridControl);
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
        /// <summary>
        /// 删除数据前
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DoBeforeDelete(object sender, CancelEventArgs e)
        {
            try
            {
                this.Cursor  = Cursors.WaitCursor;

                DataRowView CurrRow = TCOM_DEPTBindingSource.Current as DataRowView;
                    if (CurrRow != null)
                    {
                        //获取部门下员工的结果集
                        DataSet ds = SysTools.basicService.GetUserByDept(CurrRow["DeptID"].ToString());
                        DataRow[] dst = m_DepartmentTree.SelectDepartmenNode.SubDeparment;
                        if (ds.Tables[0].Rows.Count == 0)
                        {
                            if (dst.Length != 0)
                            {
                                UserMessages.ShowInfoBox("请先删除本部门的下属部门信息");
                                e.Cancel = true;
                            }
                            else
                            {
                                if (DialogResult.Yes != MessageBox.Show("是否删除当前信息", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                                {
                                    e.Cancel = true;
                                }
                            }
                        }
                        else
                        {
                            UserMessages.ShowInfoBox("请先删除本部门下的员工信息");
                            e.Cancel = true;
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

     
      



        /// <summary>
        /// 获取全部数据
        /// </summary>
        private void GetAllData()
        {
            if (UserMessages.ShowQuestionBox("确定要获取全部数据吗？"))
            {
                Cursor = Cursors.WaitCursor;
                try
                {
                   
                        //获取数据代码
                    dstDepartment1.GetAllData();
                        gridView1.BestFitColumns();
                   
                }
                catch (Exception ex)
                {
                    UserMessages.ShowInfoBox("获取数据出错:" + ex.Message);
                }
                finally
                {
                    Cursor = Cursors.Default;
                }
            }
        }
        #endregion

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TigerForm_Load(object sender, EventArgs e)
        {
            try
            {
              
                    this.Cursor = Cursors.WaitCursor;
                
                 
                    m_DepartmentTree = new DepartmentTree(DepartmentTree);
                    m_DepartmentTree.ShowTree();
                    AddDepartmentItem = new ToolStripMenuItem("添加根部门");
                    LookCurrentDepartment = new ToolStripMenuItem("查看当前部门");
                    ContextMenuStrip DepartmentMenu = m_DepartmentTree.FTreeView.ContextMenuStrip;
                    AddDepartmentItem.Click += new EventHandler(AddDepartmentItem_Click);
                    LookCurrentDepartment.Click += new EventHandler(LookCurrentDepartment_Click);
                    //保存表格默认样式
                    WindDataManager.SaveDefaltGridViewLayout(gridView1, this.Name);
                    //恢复表格样式
                    WindDataManager.RestoreGridViewLayout(gridView1, this.Name);
                    //保存默认布局样式
                    //WindDataManager.SaveDefaltControlLayout(layoutControl1, this.Name);
                    //恢复布局样式
                    //WindDataManager.RestoreControlLayout(layoutControl1, this.Name);
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

        private void HyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //保存表格样式
            WindDataManager.SaveGridViewLayout(gridView1, this.Name);
            //保存布局样式
            //WindDataManager.SaveControlLayout(layoutControl1, this.Name);
        }

        /// <summary>
        /// 查看当前部门信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void LookCurrentDepartment_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_DepartmentTree.SelectDepartmenNode != null)
                {
                    DataRow row = m_DepartmentTree.SelectDepartmenNode.CurrDepartment;
                    this.dstDepartment1.Tables["TCOM_DEPT"].Clear();
                    dstDepartment1.Tables["TCOM_DEPT"].ImportRow(row);
                    this.dstDepartment1.Tables["TCOM_DEPT"].AcceptChanges();
                    gridView1.BestFitColumns();
                }
            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }
        }
        /// <summary>
        /// 添加根部门节点事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddDepartmentItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {

                
                
                DataRowView rv = TCOM_DEPTBindingSource.Current as DataRowView;
                rv.BeginEdit();
                //获取要添加根部门的信息。
                rv["DEPTID"] = Guid.NewGuid().ToString();
                rv["PARENTDEPTID"] = "0".ToString();
                
          
            
                rv["DEPTNAME"] = "";
                gridView1.BestFitColumns();
                
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
       
        /// <summary>
        /// 当窗体获取焦点时处理事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmDepartment_Activated(object sender, EventArgs e)
        {

            ContextMenuStrip cMenu = m_DepartmentTree .FTreeView .ContextMenuStrip;
            cMenu.Items.Add(AddDepartmentItem);
            cMenu.Items.Add(LookCurrentDepartment );
            //加载部门树的双击事件
            m_DepartmentTree .FTreeView .DoubleClick += new EventHandler(Departmenttree_DoubleClick);

            
          
        }
 
   
       
        /// <summary>
        /// 部门树的双击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Departmenttree_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (m_DepartmentTree.SelectDepartmenNode != null)
                {
                    DataRow[] ds =m_DepartmentTree .SelectDepartmenNode.SubDeparment;
                    if (ds.Length > 0)
                    {
                        this.dstDepartment1.Tables["TCOM_DEPT"].Clear();
                        foreach (DataRow row in ds)
                        {
                            dstDepartment1.Tables["TCOM_DEPT"].ImportRow(row);
                            dstDepartment1.Tables["TCOM_DEPT"].AcceptChanges();
                        }
                        
                        
                        gridView1.BestFitColumns();
                    }
                    else
                    {
                        DataRow row = m_DepartmentTree.SelectDepartmenNode.CurrDepartment;
                        this.dstDepartment1.Tables["TCOM_DEPT"].Clear();
                        dstDepartment1.Tables["TCOM_DEPT"].ImportRow(row);
                        this.dstDepartment1.Tables["TCOM_DEPT"].AcceptChanges();
                        gridView1.BestFitColumns();
                    }
                }
            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }
        }
        /// <summary>
        /// 当窗体失去焦点时处理事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmDepartment_Deactivate(object sender, EventArgs e)
        {
            AddDepartmentItem.Click -= new EventHandler(AddDepartmentItem_Click);
            ContextMenuStrip cMenu = m_DepartmentTree .FTreeView .ContextMenuStrip;
            cMenu.Items.Remove (AddDepartmentItem);
            cMenu.Items.Remove(LookCurrentDepartment );

            //卸载部门树的双击事件
            m_DepartmentTree .FTreeView.DoubleClick -= new EventHandler(Departmenttree_DoubleClick);
        }

        private void lookUpCorparation_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (TCOM_DEPTBindingSource.Position != -1)
                {
                    DataRowView rv = TCOM_DEPTBindingSource.Current as DataRowView;
                    //rv.BeginEdit();
  
                    //rv.EndEdit();
                }
            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }
        }
        /// <summary>
        /// 刷新显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
               
                    this.Cursor = Cursors.WaitCursor;
                    //设置数据源
                    m_DepartmentTree.ShowTree();

                
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

        private void TCOM_DEPTBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            try
            {
                if (m_DepartmentTree.SelectDepartmenNode != null)
                {
                    DepartmenItem dtree = m_DepartmentTree.SelectDepartmenNode;
                    dstDepartment1.TCOM_DEPT.PARENTDEPTIDColumn.DefaultValue = dtree.DepartmentID.ToString();
                 
                    dstDepartment1.TCOM_DEPT.PDEPARTMENTNAMEColumn.DefaultValue = dtree.DepartmentName.ToString();
                    
                    
                    dstDepartment1.TCOM_DEPT.DEPTIDColumn.DefaultValue = Guid.NewGuid().ToString();
                    
                    dstDepartment1.TCOM_DEPT.DEPTNAMEColumn.DefaultValue = "";

                    gridView1.BestFitColumns();
                }
                else
                {
                    UserMessages.ShowInfoBox("请您选择一个部门！");
                }
            }
            catch (Exception ex)
            {
                UserMessages.ShowInfoBox(ex.Message);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            gridView1.DelSelectedRows();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try {
                dstDepartment1.Save();
            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }
        }
    }
}

