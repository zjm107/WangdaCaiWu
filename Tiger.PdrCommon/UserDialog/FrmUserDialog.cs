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
    /// 创建人: 邢根立
    /// 日  期: 2006-10-14
    ///
    /// 版  本:
    /// 作  用：实现人员对话框功能。
    /// 模块编号：无
    /// </summary>
    public partial class FrmUserDialog : Form
    {
        /// <summary>
        /// 用户行
        /// </summary>
        public DataRow UserRow;
        /// <summary>
        /// 用户对话框
        /// </summary>
        public FrmUserDialog()
        {
            InitializeComponent();
        }

        #region 处理数据的事件
        /// <summary>
        /// 保存数据
        /// </summary>
        protected void DoSaveData()
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
                //this.txtUserCardNO.Focus();
                
                //设置数据源
                //SetDataSource(mDataSet, "TableName", this);
                this.GetDataAll();
               
            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
                //this.txtUserCardNO.Focus();
            }

        }

        #region 自定义函数
        /// <summary>
        /// 获取用户及部门信息
        /// </summary>
        private void GetDataAll()
        {
            try
            {
                this.GetUser();
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 获取用户信息
        /// </summary>
        private void GetUser()
        {
            try
            {
                
                    DataSet dst = SysTools.userSer.GetUserAll();
                    this.userDialogSet.Tables["TCOM_USER"].Clear();
                    foreach (DataRow drow in dst.Tables["TCOM_USER"].Rows)
                        this.userDialogSet.Tables["TCOM_USER"].ImportRow(drow);
                    this.userDialogSet.Tables["TCOM_USER"].AcceptChanges();
                
                this.gridView1.ExpandAllGroups();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        /// <summary>
        /// 选中的用户行
        /// </summary>
        public UserDialog.UserDialogSet.TCOM_USERRow SelectUserRow
        {
            get
            {
                if (this.TCOM_USERBindingSource.Position >= 0)
                {
                    DataRowView rv = this.TCOM_USERBindingSource.Current as DataRowView;
                    return rv.Row as UserDialog.UserDialogSet.TCOM_USERRow;
                }
                else
                    return null;
            }
        }


        ///// <summary>
        ///// 确定
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void Btn_Enter_Click(object sender, EventArgs e)
        //{
        //    DataRowView dvw=this.TCOM_USERBindingSource.Current as DataRowView;
        //    if(dvw!=null)
        //    {
        //        UserRow = dvw.Row;
        //        this.Close();
        //    }
        //    else
        //    {
        //        UserMessages.ShowInfoBox("请选择用户！");
        //    }
        //}

        ///// <summary>
        ///// 显示用户对话框，并返回选择的用户行信息
        ///// </summary>
        ///// <returns>返回选择的用户行信息</returns>
        //public static DataRow ShowDialog1()
        //{
        //    FrmUserDialog frm = new FrmUserDialog();
        //    frm.ShowDialog();
        //    return frm.UserRow;
        //}



    }
}

