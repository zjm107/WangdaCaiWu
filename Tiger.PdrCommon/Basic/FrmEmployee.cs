using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Tiger.PdrCommon.ConfigApp;
using Tiger.Tools;




namespace Tiger.PdrCommon
{
    /// <summary>
    /// Copyright (c) 2006-2007 *********Tiger
    /// 创建人: 赵金明
    /// 日 期: 2006.06.14
    ///
    /// 版 本:
    /// 作用：维护员工信息
    /// 模块编号：
    /// </summary>
    public partial class FrmEmployee : DevExpress.XtraEditors.XtraForm
    {
        //员工树
        private EmployeeTree m_employeeTree = null;
        /// <summary>
        /// 员工管理
        /// </summary>
        public FrmEmployee()
        {
            InitializeComponent();
        }

        #region 处理数据的事件

       
        /// <summary>
        /// 保存数据
        /// </summary>
        private void DoSaveData()
        {

            this.Cursor = Cursors.WaitCursor;
            try
            {
               
                gdvEmployee.PostEditor();
                this.dstEmployee.Save();
                gdvEmployee.BestFitColumns();
                m_employeeTree.ShowTree();


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
                WindDataManager.ExportGrid(this.tB_EmployeeGridControl);
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
            if (UserMessages.ShowQuestionBox("确定要删当前记录吗？"))
            {
                
               
            }
            else
            {
                e.Cancel = true ;
            }
        }


  
  
        /// <summary>
        /// 获取全部数据
        /// </summary>
        private void GetAllData()
        {
            if (UserMessages.ShowQuestionBox("确定要获取全部数据吗？"))
            {
                this.Cursor = Cursors.WaitCursor;
                try
                {
                    //获取数据代码
                        
                   
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
                //AllowDelete = false;
                //设置数据源
                
                m_employeeTree = new EmployeeTree(tvEmployee);
                //显示树
                m_employeeTree.ShowTreeByImg();
                //加载列表信息
                LoadFromInfo();
                dstEmployee.TCOM_USER.EMPLOYEETYPEColumn.DefaultValue = "正式";
                dstEmployee.TCOM_USER.ENABLEColumn.DefaultValue = true ;
                //保存表格默认样式
                WindDataManager.SaveDefaltGridViewLayout(gdvEmployee, this.Name);
                //恢复表格样式
                WindDataManager.RestoreGridViewLayout(gdvEmployee, this.Name);
                //保存默认布局样式
                WindDataManager.SaveDefaltControlLayout(layoutControl1, this.Name);
                //恢复布局样式
                WindDataManager.RestoreControlLayout(layoutControl1, this.Name);
                dstTCONF_WORD.FillDevComboBox("薪资类型", WorkTypeComboBox);
                dstTCONF_WORD.FillDevComboBox("员工类型", EMPLOYEETYPEComboBox);
                dstEmployee.GetAllData();
                dstEmployee.GetAllUserName();
                

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
            WindDataManager.SaveGridViewLayout(gdvEmployee, this.Name);
            //保存布局样式
            WindDataManager.SaveControlLayout(layoutControl1, this.Name);
        }
        DstTCONF_WORD dstWord = new DstTCONF_WORD();
        /// <summary>
        /// 加载列表信息
        /// </summary>
        private void LoadFromInfo()
        {
           
        }
        /// <summary>
        /// 双击员工树时处理事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvEmployee_DoubleClick(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                //选中员工的信息
                if (m_employeeTree.SelectEmployeeItemNode != null)
                {
                    DataRow row = m_employeeTree.SelectEmployeeItemNode.EmployeeRowInfo;
                    dstEmployee.Tables["TCOM_USER"].Clear();
                    dstEmployee.Tables["TCOM_USER"].ImportRow(row);
                    dstEmployee.Tables["TCOM_USER"].AcceptChanges();
                    gdvEmployee.BestFitColumns();
                }
                //选中部门节点下的员工信息
                if (m_employeeTree.SelectDepartmenNode != null)
                {
                    DataRow[] DS = m_employeeTree.SelectDepartmenNode.SeleDepEmployee;
                    dstEmployee.Tables["TCOM_USER"].Clear();
                    dstEmployee.TCOM_USERName.Clear();
                    foreach (DataRow row in DS)
                    {
                        dstEmployee.Tables["TCOM_USER"].ImportRow(row);
                        dstEmployee.Tables["TCOM_USER"].AcceptChanges();

                        dstEmployee.TCOM_USERName.ImportRow(row);
                        dstEmployee.TCOM_USERName.AcceptChanges();
                    }

                    gdvEmployee.BestFitColumns();




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

       

        private void TCOM_USERBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            try
            {
                if (m_employeeTree.SelectDepartmenNode != null)
                {
                    dstEmployee.TCOM_USER.DEPTIDColumn.DefaultValue = m_employeeTree.SelectDepartmenNode.DepartmentID.ToString();
                    dstEmployee.TCOM_USER.DEPTNAMEColumn.DefaultValue = m_employeeTree.SelectDepartmenNode.DepartmentName.ToString();
                    dstEmployee.TCOM_USER.ENABLEColumn.DefaultValue = true;
                    dstEmployee.TCOM_USER.USERIDColumn.DefaultValue = Guid.NewGuid().ToString();
                    dstEmployee.TCOM_USER.SEQNOColumn.DefaultValue = dstEmployee.GetMaxNO();
                    dstEmployee.TCOM_USER.USERCODEColumn.DefaultValue = Guid.NewGuid().ToString();
                    dstEmployee.TCOM_USER.APPLICATIONIDColumn.DefaultValue = Guid.NewGuid().ToString();
                    gdvEmployee.BestFitColumns();
                }
                else
                {
                    UserMessages.ShowInfoBox("请您选择一个部门！");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnChangeSNO_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                dstEmployee.ChangeEmployee();
                GetAllData();
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
       

        private void btnUpdateDeptName_Click(object sender, EventArgs e)
        {
            DataRowView row = TCOM_USERBindingSource.Current as DataRowView;
            if (row != null && !string.IsNullOrEmpty(row["USERID"].ToString()))
            {
                FrmUpdateDeptNameChild frm = new FrmUpdateDeptNameChild();
                frm.Visible = false;
               
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    if (!string.IsNullOrEmpty(frm.DeptName))
                    {
                        row["DEPTNAME"] = frm.DeptName;
                        DataSet dst= dstEmployee.GetDepartmentByKey(frm.DeptName);
                        if (dst != null && dst.Tables[0].Rows.Count > 0)
                            row["DEPTID"] = dst.Tables[0].Rows[0]["DEPTID"].ToString();
                        gdvEmployee.BestFitColumns();
                    }
                }
            }
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDel_Click(object sender, EventArgs e)
        {
            gdvEmployee.DelSelectedRows();
        }
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try {

                dstEmployee.SaveEmployee();
                gdvEmployee.BestFitColumns();
                m_employeeTree.ShowTree();

            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }
            finally {
                this.Cursor = Cursors.Default;
            }
        }

        private void btnSetPassWord_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try {
                List<DataRow> rows = this.gdvEmployee.GetSelectRow();
                foreach (DataRow row in rows)
                {
                    row.BeginEdit();
                    row["LOGPASSWORD"] = "123456";
                    row.EndEdit();
                }
            }
            catch (Exception ex)
            {
                UserMessages.ShowInfoBox(ex.Message);
            }
            finally {
                this.Cursor = Cursors.Default;
            }
        }
    }
}

