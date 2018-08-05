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
    /// ������:���Խ���
    /// �� ��: 2006-10-18
    ///
    /// �� ��:
    /// ���ã��Բ�����Ϣ���й���
    /// ģ���ţ�ģ���ţ���������ϵͳ����е�ģ����
    /// </summary>
    public partial class FrmDepartment : DevExpress.XtraEditors.XtraForm
    {
        //������
        private DepartmentTree m_DepartmentTree = null;
        //��Ӳ��Ÿ��ڵ�˵�
        ToolStripMenuItem AddDepartmentItem = null;
        ToolStripMenuItem LookCurrentDepartment = null;
        /// <summary>
        /// ���Ź���
        /// </summary>
        public FrmDepartment()
        {
            InitializeComponent();
        }

        #region �������ݵ��¼�
        /// <summary>
        /// ��������
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
        /// ��������
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
        /// ɾ������ǰ
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
                        //��ȡ������Ա���Ľ����
                        DataSet ds = SysTools.basicService.GetUserByDept(CurrRow["DeptID"].ToString());
                        DataRow[] dst = m_DepartmentTree.SelectDepartmenNode.SubDeparment;
                        if (ds.Tables[0].Rows.Count == 0)
                        {
                            if (dst.Length != 0)
                            {
                                UserMessages.ShowInfoBox("����ɾ�������ŵ�����������Ϣ");
                                e.Cancel = true;
                            }
                            else
                            {
                                if (DialogResult.Yes != MessageBox.Show("�Ƿ�ɾ����ǰ��Ϣ", "��ʾ��Ϣ", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                                {
                                    e.Cancel = true;
                                }
                            }
                        }
                        else
                        {
                            UserMessages.ShowInfoBox("����ɾ���������µ�Ա����Ϣ");
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
                    dstDepartment1.GetAllData();
                        gridView1.BestFitColumns();
                   
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
                
                 
                    m_DepartmentTree = new DepartmentTree(DepartmentTree);
                    m_DepartmentTree.ShowTree();
                    AddDepartmentItem = new ToolStripMenuItem("��Ӹ�����");
                    LookCurrentDepartment = new ToolStripMenuItem("�鿴��ǰ����");
                    ContextMenuStrip DepartmentMenu = m_DepartmentTree.FTreeView.ContextMenuStrip;
                    AddDepartmentItem.Click += new EventHandler(AddDepartmentItem_Click);
                    LookCurrentDepartment.Click += new EventHandler(LookCurrentDepartment_Click);
                    //������Ĭ����ʽ
                    WindDataManager.SaveDefaltGridViewLayout(gridView1, this.Name);
                    //�ָ������ʽ
                    WindDataManager.RestoreGridViewLayout(gridView1, this.Name);
                    //����Ĭ�ϲ�����ʽ
                    //WindDataManager.SaveDefaltControlLayout(layoutControl1, this.Name);
                    //�ָ�������ʽ
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
            //��������ʽ
            WindDataManager.SaveGridViewLayout(gridView1, this.Name);
            //���沼����ʽ
            //WindDataManager.SaveControlLayout(layoutControl1, this.Name);
        }

        /// <summary>
        /// �鿴��ǰ������Ϣ
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
        /// ��Ӹ����Žڵ��¼�
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
                //��ȡҪ��Ӹ����ŵ���Ϣ��
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
        /// �������ȡ����ʱ�����¼�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmDepartment_Activated(object sender, EventArgs e)
        {

            ContextMenuStrip cMenu = m_DepartmentTree .FTreeView .ContextMenuStrip;
            cMenu.Items.Add(AddDepartmentItem);
            cMenu.Items.Add(LookCurrentDepartment );
            //���ز�������˫���¼�
            m_DepartmentTree .FTreeView .DoubleClick += new EventHandler(Departmenttree_DoubleClick);

            
          
        }
 
   
       
        /// <summary>
        /// ��������˫���¼�
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
        /// ������ʧȥ����ʱ�����¼�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmDepartment_Deactivate(object sender, EventArgs e)
        {
            AddDepartmentItem.Click -= new EventHandler(AddDepartmentItem_Click);
            ContextMenuStrip cMenu = m_DepartmentTree .FTreeView .ContextMenuStrip;
            cMenu.Items.Remove (AddDepartmentItem);
            cMenu.Items.Remove(LookCurrentDepartment );

            //ж�ز�������˫���¼�
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
        /// ˢ����ʾ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
               
                    this.Cursor = Cursors.WaitCursor;
                    //��������Դ
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
                    UserMessages.ShowInfoBox("����ѡ��һ�����ţ�");
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

