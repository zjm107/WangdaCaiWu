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
    /// �� ��: 2006-10-21
    ///
    /// �� ��:
    /// ���ã���ȡ������Ϣ
    /// ģ���ţ�ģ���ţ���������ϵͳ����е�ģ����
    /// </summary>
    public partial class FrmDepartmentDlg : Form
    {
        /// <summary>
        /// ���ŶԻ���
        /// </summary>
        public FrmDepartmentDlg()
        {
            InitializeComponent();
        }

        #region �������ݵ��¼�
        /// <summary>
        /// ��������
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
                //��������Դ
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
        /// ��ȡ��ǰѡ����
        /// </summary>
        /// <returns></returns>
        public DataRow GetCurrSelectRow()
        {
            DataRow row = null;
            try
            {
                
                if (TCOM_DEPTbindingSource.Position ==-1)
                {
                    throw new Exception("��ѡ��Ҫ��ȡ��������Ϣ!");
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

