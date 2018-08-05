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
    /// 创建人: 赵金明
    /// 日 期: 2006-10-21
    ///
    /// 版 本:
    /// 作用：获取部门信息
    /// 模块编号：模块编号，可以引用系统设计中的模块编号
    /// </summary>
    public partial class FrmDepartmentDlg : Form
    {
        /// <summary>
        /// 部门对话框
        /// </summary>
        public FrmDepartmentDlg()
        {
            InitializeComponent();
        }

        #region 处理数据的事件
        /// <summary>
        /// 保存数据
        /// </summary>
        protected  void DoSaveData()
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
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
        protected void ExportGridToFiles()
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                //WindDataManager.ExportGrid();

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
        protected void GetAllData()
        {
            if (UserMessages.ShowQuestionBox("确定要获取全部数据吗？"))
            {
                Cursor = Cursors.WaitCursor;
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
            this.Cursor = Cursors.WaitCursor;
            try
            {
                //设置数据源
                //SetDataSource(mDataSet, "TableName", this);
               
                    DataSet ds =SysTools.basicService.GetAllDepartment();
                    DataManager.ImpDataSet(ds.Tables[0], dstDepartment1.Tables["TCOM_DEPT"]);
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

        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {



                dstDepartment1.GetDeptByName(txtDepartmentNmae.Text);
                    gridView1.BestFitColumns();
               

            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }
        }
        /// <summary>
        /// 获取当前选中行
        /// </summary>
        /// <returns></returns>
        public DataRow GetCurrSelectRow()
        {
            DataRow row = null;
            try
            {
                
                if (TCOM_DEPTbindingSource.Position ==-1)
                {
                    throw new Exception("请选择要获取的数据信息!");
                }
                DataRowView rv = TCOM_DEPTbindingSource.Current as DataRowView;
                row = rv.Row;
            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }
            return row;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }


    }
}

