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
    /// ������: �ϸ���
    /// ��  ��: 2006-10-14
    ///
    /// ��  ��:
    /// ��  �ã�ʵ����Ա�Ի����ܡ�
    /// ģ���ţ���
    /// </summary>
    public partial class FrmUserDialog : Form
    {
        /// <summary>
        /// �û���
        /// </summary>
        public DataRow UserRow;
        /// <summary>
        /// �û��Ի���
        /// </summary>
        public FrmUserDialog()
        {
            InitializeComponent();
        }

        #region �������ݵ��¼�
        /// <summary>
        /// ��������
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
        /// ��������
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
        /// ��ȡȫ������
        /// </summary>
        protected void GetAllData()
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
                //this.txtUserCardNO.Focus();
                
                //��������Դ
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

        #region �Զ��庯��
        /// <summary>
        /// ��ȡ�û���������Ϣ
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
        /// ��ȡ�û���Ϣ
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
        /// ѡ�е��û���
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
        ///// ȷ��
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
        //        UserMessages.ShowInfoBox("��ѡ���û���");
        //    }
        //}

        ///// <summary>
        ///// ��ʾ�û��Ի��򣬲�����ѡ����û�����Ϣ
        ///// </summary>
        ///// <returns>����ѡ����û�����Ϣ</returns>
        //public static DataRow ShowDialog1()
        //{
        //    FrmUserDialog frm = new FrmUserDialog();
        //    frm.ShowDialog();
        //    return frm.UserRow;
        //}



    }
}

