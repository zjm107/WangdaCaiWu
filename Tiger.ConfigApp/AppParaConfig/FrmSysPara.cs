using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Tiger.ConfigApp.AppParaConfig;
using Tiger.Tools;
using Tiger.WinControl.Forms;

namespace Tiger.ConfigApp
{
    /// <summary>
    /// Copyright (c) 2006-2007 *********Tiger
    /// ������: 
    /// �� ��: ģ�鴴�����ڣ���ʽ��YYYY-MM-DD
    ///
    /// �� ��:
    /// ���ã��Դ������������������ϵͳ����е�����
    /// ģ���ţ�ģ���ţ���������ϵͳ����е�ģ����
    /// </summary>
    public partial class FrmSysPara : Form
    {
        /// <summary>
        /// 
        /// </summary>
        public FrmSysPara()
        {
            InitializeComponent();
        }
        #region �������ݵ��¼�
        /// <summary>
        /// ��������
        /// </summary>
        protected override void DoSaveData()
        {
            
            this.Cursor = Cursors.WaitCursor;
            try
            {
                mParaCls.SaveParaValue();
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
        protected override void DoBeforeDelete(object sender, CancelEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                if (UserMessages.ShowQuestionBox("ȷ��Ҫɾ��ǰ��¼��"))
                {
                    e.Cancel = false;
                    base.DoBeforeDelete(sender, e);
                }
                else
                {
                    e.Cancel = true;
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
        protected override void GetAllData()
        {
            if (UserMessages.ShowQuestionBox("ȷ��Ҫ��ȡȫ��������"))
            {
                Cursor = Cursors.WaitCursor;
                try
                {
                    if (tabControl1.SelectedIndex == 0)
                    {
                        ShowParaValue();
                    }
                    else
                    {
                        mParaCls.GetAllParaType();
                     
                    }
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
                SetDataSource(TCONF_WORDBindingSource);
                mParaCls = new ParaConfigCls(this.dsParaConfig);
                mShowParaTypeView();
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
        /// ˢ������б�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mItemRefresh_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                mShowParaTypeView();
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

        private ParaConfigCls mParaCls = null;

        private string mstrCurrentTypeID = "";


        /// <summary>
        /// ��ʾѡ�нڵ������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mItemShow_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                ShowParaValue();
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

        private void ShowParaValue()
        {
            if (lvParaType.SelectedItems.Count > 0)
            {

               

                ParaTypeItem selItem = lvParaType.SelectedItems[0] as ParaTypeItem;
                if (selItem != null)
                {
                    mstrCurrentTypeID = selItem.TypeID;
                    if (selItem.paraName1.Trim() == "")
                    {
                        colInformation1.Visible = false;
                    }
                    else
                    {
                        colInformation1.Visible = true;
                        colInformation1.HeaderText = selItem.paraName1;
                    }
                    if (selItem.paraName2.Trim() == "")
                    {
                        colInformation2.Visible = false;
                    }
                    else
                    {
                        colInformation2.Visible = true;
                        colInformation2.HeaderText = selItem.paraName2;
                    }
                    if (selItem.paraName3.Trim() == "")
                    {
                        colInformation3.Visible = false;
                    }
                    else
                    {
                        colInformation3.Visible = true;
                        colInformation3.HeaderText = selItem.paraName3;
                    }
                    mParaCls.GetParaValue(mstrCurrentTypeID);
                   
                }

            }
            else
            {
               

            }
        }

  

        /// <summary>
        /// ��ʾ��������б�
        /// </summary>
        private void mShowParaTypeView()
        {
            mParaCls.GetAllParaType();
            this.lvParaType.Items.Clear();
            foreach (DataRow row in dsParaConfig.TCONF_WORD.Rows)
            {
                ParaTypeItem pItem = new ParaTypeItem();
                pItem.TypeID = row["SystemConfigGroupID"].ToString();
                pItem.TypeName = row["ConfigGroupName"].ToString();
                pItem.TypeMemo = row["Memo"].ToString();
                pItem.paraName1 = row["Information1"].ToString();
                pItem.paraName2 = row["Information2"].ToString();
                pItem.paraName3 = row["Information3"].ToString();
                pItem.ImageIndex = 0;
                lvParaType.Items.Add(pItem);
            }
        }

     

        private void tS_SystemConfigBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            try
            {
                if (mstrCurrentTypeID.Trim() != "")
                {
                    
                    dsParaConfig.TCONF_WORD.WORDIDColumn.DefaultValue = Guid.NewGuid().ToString();
                    dsParaConfig.TCONF_WORD.GROUPNAMEColumn.DefaultValue = mstrCurrentTypeID;
                  
                }
                else
                {
                    UserMessages.ShowInfoBox("��ѡ��������!");
                }
            }
            catch (Exception ex)
            {
                UserMessages.ShowInfoBox(ex.Message);
            }
        }

   



    }
}

