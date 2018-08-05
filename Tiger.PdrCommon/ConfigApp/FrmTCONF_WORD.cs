using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tiger.Tools;

namespace Tiger.PdrCommon
{
    public partial class FrmTCONF_WORD : DevExpress.XtraEditors.XtraForm
    {
        public FrmTCONF_WORD()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 工具栏保存方法
        /// </summary>
        private void DoSaveData()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;//鼠标指针设置
                gridView1.PostEditor();
                dstTCONF_WORD.Save();
                gridView1.BestFitColumns();
            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox("保存出错：\r\n" + ex.Message + "\r\n" + ex.InnerException.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default; //鼠标指针设置
            }
        }
       
        /// <summary>
        /// 工具栏删除方法
        /// </summary>
        public  void Delete()
        {
            try
            {
                if (UserMessages.ShowQuestionBox("确定删除选中信息吗？"))
                {
                   
                    DoSaveData();//保存操作
                }
            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox("删除错误，未能成功执行！"+ex.Message);
            }
        }

        private void HyForm_Load(object sender, EventArgs e)
        {
           
            //保存表格默认样式
            //WindDataManager.SaveDefaltGridViewLayout(devGridView, this.Name);
            //恢复表格样式
            //WindDataManager.RestoreGridViewLayout(devGridView, this.Name);

            //绑定工具栏数据源
           // SetDataSource(tCONF_WORDBindingSource);
            //ComBoxListLoad();


            //下拉列表绑定
            ComBoxListLoad();
          
            //保存默认布局样式
            //WindDataManager.SaveDefaltControlLayout(layoutControl1, this.Name);
            //恢复布局样式
            //WindDataManager.RestoreControlLayout(layoutControl1, this.Name);

        }

        /// <summary>
        /// 查询表中单一字段的非重复值（用于下拉列表）
        /// </summary>
        /// <param name="tableName">表名称</param>
        /// <param name="fieldName">字段名</param>
        /// <returns></returns>
        public static List<string> GetTableFieldList(string tableName, string fieldName)
        {
            try
            {
                List<string> lists = new List<string>();
                DataSet ds = SysTools.basicService.GetTableFieldList(tableName, fieldName);
                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        foreach (var item in ds.Tables[0].Rows)
                        {
                            lists.Add(((DataRow)item)[fieldName].ToString());
                        }
                    }
                }
                return lists;
            }
            catch (Exception ex)
            {
                throw new Exception("GetTableFieldList方法出错：" + ex.Message + "\r\n" + ex.InnerException.Message);
            }
        }

        /// <summary>
        /// ComBox下拉列表信息
        /// </summary>
        private void ComBoxListLoad()
        {
            try
            {
                var groups = GetTableFieldList("TCONF_WORD", "GROUPNAME");
                foreach (string row in groups)
                {
                    this.gROUPNAMEComboBoxEdit.Properties.Items.Add(row);
                    this.cmbGroupName.Items.Add(row);

                }

            }
            catch (Exception ex)
            {
                Tiger.Tools.UserMessages.ShowErrorBox("下拉列表获取出错\r\n" + ex.Message + "\r\n" + ex.InnerException.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default; //鼠标指针设置
            }
        }
      
        
        private void HyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //保存表格样式
            WindDataManager.SaveGridViewLayout(gridView1, this.Name);
            //保存布局样式
            WindDataManager.SaveControlLayout(layoutControl1, this.Name);
        }

        /// <summary>
        /// 查询按钮单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
               
                dstTCONF_WORD.GetTCONFWORDData(gROUPNAMEComboBoxEdit.Text, wORDTextBox.Text);
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
        /// 清除按钮单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            gROUPNAMEComboBoxEdit.Text = "";
            wORDTextBox.Text = "";
            
            dstTCONF_WORD.GetTCONFWORDData("","");
            gridView1.BestFitColumns();
        }

        /// <summary>
        /// 添加新数据设置默认值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tCB_DEPTSTANDARDBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            dstTCONF_WORD.TCONF_WORD.WORDIDColumn.DefaultValue = Guid.NewGuid().ToString();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            gridView1.DelSelectedRows();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                dstTCONF_WORD.Save();
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
