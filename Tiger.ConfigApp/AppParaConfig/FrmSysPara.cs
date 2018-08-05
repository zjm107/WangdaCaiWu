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
    /// 创建人: 
    /// 日 期: 模块创建日期，格式：YYYY-MM-DD
    ///
    /// 版 本:
    /// 作用：对此类的描述，可以引用系统设计中的描述
    /// 模块编号：模块编号，可以引用系统设计中的模块编号
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
        #region 处理数据的事件
        /// <summary>
        /// 保存数据
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
        /// 删除数据前
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected override void DoBeforeDelete(object sender, CancelEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                if (UserMessages.ShowQuestionBox("确定要删当前记录吗？"))
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
        /// 获取全部数据
        /// </summary>
        protected override void GetAllData()
        {
            if (UserMessages.ShowQuestionBox("确定要获取全部数据吗？"))
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
        /// 刷新类别列表
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
        /// 显示选中节点的内容
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
        /// 显示参数类别列表
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
                    UserMessages.ShowInfoBox("请选择参数类别!");
                }
            }
            catch (Exception ex)
            {
                UserMessages.ShowInfoBox(ex.Message);
            }
        }

   



    }
}

