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
    /// ������: �Խ���
    /// �� ��: 2006-07-06
    ///
    /// �� ��:
    /// ���ã����û�Ȩ�޽���ά��
    /// ģ���ţ�ģ���ţ���������ϵͳ����е�ģ����
    /// </summary>
    public partial class FrmUserManager : DevExpress.XtraEditors.XtraForm
    {
        //Ա����
        private EmployeeTree m_UserTree = null;
        //���ݷ�Χ
        private string strDataWise = "";
        //Ա��ID
        private string UserID = null;
        /// <summary>
        /// Ա������
        /// </summary>
        public FrmUserManager()
        {
            InitializeComponent();
        }

        #region �������ݵ��¼�
        /// <summary>
        /// ��������
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
                            UserMessages.ShowInfoBox("���óɹ���");

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
        /// ��ȡȫ������
        /// </summary>
        private void GetAllData()
        {
            if (UserMessages.ShowQuestionBox("ȷ��Ҫ��ȡȫ��������"))
            {
                Cursor = Cursors.WaitCursor;
                try
                {
                    //��ȡ���ݴ���

                }
                catch (Exception ex)
                {

                    UserMessages.ShowInfoBox("��ȡ���ݳ���:" + ex.Message);
                }
                finally
                {
                    Cursor = Cursors.Default;
                }
            }
        }
        #endregion
        /// <summary>
        /// ��������¼�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TigerForm_Load(object sender, EventArgs e)
        {
            

            this.Cursor = Cursors.WaitCursor;
            try
            {
                //��������Դ
              
                m_UserTree = new EmployeeTree(UserTree);
                //��ʾ�û���
                m_UserTree.ShowTree();
             

                //������Ĭ����ʽ
                WindDataManager.SaveDefaltGridViewLayout(gridView2, this.Name);
                //�ָ������ʽ
                WindDataManager.RestoreGridViewLayout(gridView2, this.Name);
                //����Ĭ�ϲ�����ʽ
                WindDataManager.SaveDefaltControlLayout(layoutControl1, this.Name);
                //�ָ�������ʽ
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
            //��������ʽ
            WindDataManager.SaveGridViewLayout(gridView2, this.Name);
            //���沼����ʽ
            WindDataManager.SaveControlLayout(layoutControl1, this.Name);
        }

        /// <summary>
        /// ��ʾһ���û��Ѿ�ӵ�еĽ�ɫ
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


        #region �û���ɫά����Ϣ
        /// <summary>
        /// ���ϵͳ��ɫ��Ϣ
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

        #region Ϊһ���û���ӡ�ɾ�� ��ɫ
        /// <summary>
        /// Ϊ�û���ӽ�ɫ
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
        /// Ϊ�û�ɾ����ɫ
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
                //ѡ��Ա������Ϣ
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

