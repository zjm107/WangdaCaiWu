using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tiger.Tools;

namespace WangDaDll
{
    public partial class FrmEndDateQuery : DevExpress.XtraEditors.XtraForm
    {
        public FrmEndDateQuery()
        {
            InitializeComponent();
        }

        private void FrmEndDateQuery_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                dstTCONF_WORD.FillDevComboBox("公司性质", 公司性质ComboBoxEdit);
                dstTCONF_WORD.FillDevComboBox("公司类型", 公司类型ComboBoxEdit);
                dstTCONF_WORD.FillDevComboBox("客户分级", 客户分级ComboBoxEdit);
                WindDataManager.RestoreGridViewLayout(this.gridView1, this.Name);
                EnddateEdit.DateTime = DateTime.Today;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            splash.ShowWaitForm();
            try
            {
                splash.SetWaitFormCaption("请等待");
                splash.SetWaitFormDescription("正在执行查询……");

                if (Security.UserBusiness.Contains("总经理") || Security.UserBusiness.Contains("主管"))
                {
                    csDataSet.GetEndDateClient(客户分级ComboBoxEdit.Text, 公司类型ComboBoxEdit.Text
                    , 客户分级ComboBoxEdit.Text, 公司性质ComboBoxEdit.Text, 做账会计TextEdit.Text, EnddateEdit.DateTime.ToShortDateString());
                }
                else
                {
                    csDataSet.GetEndDateClient(客户分级ComboBoxEdit.Text, 公司类型ComboBoxEdit.Text
                      , 客户分级ComboBoxEdit.Text, 公司性质ComboBoxEdit.Text, Security.UserName, EnddateEdit.DateTime.ToShortDateString());

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (splash.IsSplashFormVisible)
                {
                    splash.CloseWaitForm();
                }
                this.Cursor = Cursors.Default;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                客户分级ComboBoxEdit.Text = "";
                客户名称TextEdit.Text = "";
                公司性质ComboBoxEdit.Text = "";
                公司类型ComboBoxEdit.Text = "";
                做账会计TextEdit.Text = "";
                csDataSet.TW_Client.Clear();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void btnSaveLayout_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                WindDataManager.SaveGridViewLayout(this.gridView1, this.Name);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
    }
}
