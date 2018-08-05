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
    /// 日 期: 2006-07-06
    ///
    /// 版 本:
    /// 作用：对用户权限进行维护
    /// 模块编号：模块编号，可以引用系统设计中的模块编号
    /// </summary>
    public partial class FrmUserManager : DevExpress.XtraEditors.XtraForm
    {
        //员工树
        private EmployeeTree m_UserTree = null;
        //数据范围
        private string strDataWise = "";
        //员工ID
        private string UserID = null;
        /// <summary>
        /// 员工管理
        /// </summary>
        public FrmUserManager()
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

                if (TCOM_USER_bindingSource.Position != -1)
                {
                    DataRowView rv = TCOM_USER_bindingSource.Current as DataRowView;
                    DataRow aRow = rv.Row;
                    aRow.BeginEdit();
                  
                    aRow["LOGNAME"] = txtLongName.Text.Trim();
                    if (aRow == null)
                        return;
                    if (txtNewPassword.Text != "")
                    {
                            //string newpw = EnDecrypt.Encrypt(txtNewPassword.Text);
                            string newpw =txtNewPassword.Text;
                            aRow["LOGPASSWORD"] = newpw;
                            aRow.EndEdit();
                      }
                    aRow.EndEdit();
                    if (dstEmployee.Tables["TCOM_USER"].Rows.Count > 0)
                    {
                        try
                        {
                            dstEmployee.SaveEmployee();
                            UserMessages.ShowInfoBox("设置成功！");

                        }
                        catch (Exception ex)
                        {
                            UserMessages.ShowErrorBox(ex.Message);
                        }
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
              
                m_UserTree = new EmployeeTree(UserTree);
                //显示用户树
                m_UserTree.ShowTree();
             

                //保存表格默认样式
                WindDataManager.SaveDefaltGridViewLayout(gridView2, this.Name);
                //恢复表格样式
                WindDataManager.RestoreGridViewLayout(gridView2, this.Name);
                //保存默认布局样式
                WindDataManager.SaveDefaltControlLayout(layoutControl1, this.Name);
                //恢复布局样式
                WindDataManager.RestoreControlLayout(layoutControl1, this.Name);
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
            WindDataManager.SaveGridViewLayout(gridView2, this.Name);
            //保存布局样式
            WindDataManager.SaveControlLayout(layoutControl1, this.Name);
        }

        /// <summary>
        /// 显示一个用户已经拥有的角色
        /// </summary>
        private void ShowUserRole(string userid)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                dstUserRole1.GetUserRole(userid);
                gridView2.BestFitColumns();
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


        #region 用户角色维护信息
        /// <summary>
        /// 添加系统角色信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TCOM_ROLEBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                
                dstUserRole1.TCOM_ROLE.ROLEIDColumn.DefaultValue = Guid.NewGuid().ToString();
             
                
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

      
        #endregion

        #region 为一个用户添加、删除 角色
        /// <summary>
        /// 为用户添加角色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddUserRole_Click(object sender, EventArgs e)
        {
            try
            {
                ShowRole();
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

        private void ShowRole()
        {
            string roleId = "";
            DataRowView currentRow= TCOM_ROLE1BindingSource.Current as DataRowView;
            if (currentRow != null && !string.IsNullOrEmpty(currentRow["ROLEID"].ToString()))
                roleId = currentRow["ROLEID"].ToString();
            Tiger.PdrCommon.FrmRoleDlg frmRoleDlg = new Tiger.PdrCommon.FrmRoleDlg(roleId);
            if (frmRoleDlg.ShowDialog() == DialogResult.OK)
            {
                DataRow row = frmRoleDlg.GetSelectedRow();
                if (row != null)
                {
                    
                        string strRoleID = row["ROLEID"].ToString();
                  
                        int rows = SysTools.basicService.AddUser2Role(UserID, strRoleID);
                        if (rows > 0)
                        {
                            DataRow rowRole1 = dstUserRole1.Tables["TCOM_ROLE1"].NewRow();
                            rowRole1["ROLEID"] = row["ROLEID"].ToString();
                            rowRole1["REMARK"] = row["REMARK"].ToString();
                            rowRole1["ROLENAME"] = row["ROLENAME"].ToString();

                            dstUserRole1.Tables["TCOM_ROLE1"].Rows.Add(rowRole1);
                        }
                        DoSaveData();
                    
                }
            }
        }
        /// <summary>
        /// 为用户删除角色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteUserRole_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                DataRowView rv = this.TCOM_ROLE1BindingSource.Current as DataRowView;
               
              
                    int rows = SysTools.basicService.DelectUser2Role(UserID, rv["ROLEID"].ToString());
                    if (rows > 0)
                    {
                        TCOM_ROLE1BindingSource.Remove(rv);
                    }
                
                DoSaveData();
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

        #endregion 




        



   

     

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                DoSaveData();
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


        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {
                DoSaveData();
            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }
        }

        private void gridView1_RowCountChanged(object sender, EventArgs e)
        {
            try {
                DoSaveData();
            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }
        }

        private void UserTree_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                //选中员工的信息
                if (m_UserTree.SelectEmployeeItemNode != null)
                {
                    string strUserID = m_UserTree.SelectEmployeeItemNode.EmployeeID;
                    DataRow row = m_UserTree.SelectEmployeeItemNode.EmployeeRowInfo;
                    dstEmployee.GetUserByUserID(strUserID);
                    this.txtNewPassword.Text = "";
                   
                    this.UserID = m_UserTree.SelectEmployeeItemNode.EmployeeID.ToString();
                    ShowUserRole(UserID);
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

        private void TCOM_ROLE1GridControl_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                ShowRole();
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

       
       
    }
    
}

