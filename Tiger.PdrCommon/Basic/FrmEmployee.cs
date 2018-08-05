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
    /// ������: �Խ���
    /// �� ��: 2006.06.14
    ///
    /// �� ��:
    /// ���ã�ά��Ա����Ϣ
    /// ģ���ţ�
    /// </summary>
    public partial class FrmEmployee : DevExpress.XtraEditors.XtraForm
    {
        //Ա����
        private EmployeeTree m_employeeTree = null;
        /// <summary>
        /// Ա������
        /// </summary>
        public FrmEmployee()
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
        /// ��������
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
        /// ɾ������ǰ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DoBeforeDelete(object sender, CancelEventArgs e)
        {
            if (UserMessages.ShowQuestionBox("ȷ��Ҫɾ��ǰ��¼��"))
            {
                
               
            }
            else
            {
                e.Cancel = true ;
            }
        }


  
  
        /// <summary>
        /// ��ȡȫ������
        /// </summary>
        private void GetAllData()
        {
            if (UserMessages.ShowQuestionBox("ȷ��Ҫ��ȡȫ��������"))
            {
                this.Cursor = Cursors.WaitCursor;
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
            try
            {
                this.Cursor = Cursors.WaitCursor;
                //AllowDelete = false;
                //��������Դ
                
                m_employeeTree = new EmployeeTree(tvEmployee);
                //��ʾ��
                m_employeeTree.ShowTreeByImg();
                //�����б���Ϣ
                LoadFromInfo();
                dstEmployee.TCOM_USER.EMPLOYEETYPEColumn.DefaultValue = "��ʽ";
                dstEmployee.TCOM_USER.ENABLEColumn.DefaultValue = true ;
                //������Ĭ����ʽ
                WindDataManager.SaveDefaltGridViewLayout(gdvEmployee, this.Name);
                //�ָ������ʽ
                WindDataManager.RestoreGridViewLayout(gdvEmployee, this.Name);
                //����Ĭ�ϲ�����ʽ
                WindDataManager.SaveDefaltControlLayout(layoutControl1, this.Name);
                //�ָ�������ʽ
                WindDataManager.RestoreControlLayout(layoutControl1, this.Name);
                dstTCONF_WORD.FillDevComboBox("н������", WorkTypeComboBox);
                dstTCONF_WORD.FillDevComboBox("Ա������", EMPLOYEETYPEComboBox);
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
            //��������ʽ
            WindDataManager.SaveGridViewLayout(gdvEmployee, this.Name);
            //���沼����ʽ
            WindDataManager.SaveControlLayout(layoutControl1, this.Name);
        }
        DstTCONF_WORD dstWord = new DstTCONF_WORD();
        /// <summary>
        /// �����б���Ϣ
        /// </summary>
        private void LoadFromInfo()
        {
           
        }
        /// <summary>
        /// ˫��Ա����ʱ�����¼�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvEmployee_DoubleClick(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                //ѡ��Ա������Ϣ
                if (m_employeeTree.SelectEmployeeItemNode != null)
                {
                    DataRow row = m_employeeTree.SelectEmployeeItemNode.EmployeeRowInfo;
                    dstEmployee.Tables["TCOM_USER"].Clear();
                    dstEmployee.Tables["TCOM_USER"].ImportRow(row);
                    dstEmployee.Tables["TCOM_USER"].AcceptChanges();
                    gdvEmployee.BestFitColumns();
                }
                //ѡ�в��Žڵ��µ�Ա����Ϣ
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
                    UserMessages.ShowInfoBox("����ѡ��һ�����ţ�");
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
        /// ɾ��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDel_Click(object sender, EventArgs e)
        {
            gdvEmployee.DelSelectedRows();
        }
        /// <summary>
        /// ����
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

