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
using WangDaDll.Common;

namespace WangDaDll
{
    public partial class FrmNoPaymentDlg : DevExpress.XtraEditors.XtraForm
    {
        public FrmNoPaymentDlg(ProceedsDataSet mProceedsDataSet)
        {
            InitializeComponent();
            MProceedsDataSet = mProceedsDataSet;
        }
        /// <summary>
        /// 返回结果集
        /// </summary>
        public ProceedsDataSet MProceedsDataSet
        {
            get;set;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            int[] rowHandles = gridView1.GetSelectedRows();
            if (rowHandles.Length == 0)
                return;
            splash.ShowWaitForm();
            splash.SetWaitFormCaption("等待");
            splash.SetWaitFormDescription("正在处理选择的注册单信息……");
            try
            {
                MProceedsDataSet.VW_PaymentDetail.Clear();
                foreach (int i in rowHandles)
                {
                    DataRowView rv = gridView1.GetRow(i) as DataRowView;
                    MProceedsDataSet.VW_PaymentDetail.ImportRow(rv.Row);
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }
            finally
            {
                if (splash.IsSplashFormVisible)
                    splash.CloseWaitForm();
                this.Cursor = Cursors.Default;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            splash.ShowWaitForm();
            splash.SetWaitFormCaption("等待");
            splash.SetWaitFormDescription("正在处理选择的注册单信息……");
            try
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }
            finally
            {
                if (splash.IsSplashFormVisible)
                    splash.CloseWaitForm();
                this.Cursor = Cursors.Default;
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {

            this.Cursor = Cursors.WaitCursor;
            try
            {
                if (Security.UserBusiness.Contains("总经理") || Security.UserBusiness.Contains("主管"))
                {
                    proceedsDataSet.GetNoPaymentReg(业务员TextEdit.Text, 公司预核名称TextEdit.Text, 是否收款comboBoxEdit.Text  );
                }
                else
                {
                    proceedsDataSet.GetNoPaymentReg(Security.UserName, 公司预核名称TextEdit.Text,是否收款comboBoxEdit.Text);

                }
                gridView1.UnselectRow(0);

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

        private void btnClear_Click(object sender, EventArgs e)
        {

            this.Cursor = Cursors.WaitCursor;
            try
            {
                是否收款comboBoxEdit.Text = "";
                公司预核名称TextEdit.Text = "";
                业务员TextEdit.Text = "";
             
                proceedsDataSet.VW_PaymentDetail.Clear();
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

        private void FrmNoPaymentDlg_Load(object sender, EventArgs e)
        {
            try
            {
                是否收款comboBoxEdit.Text = "未收款";
                if (Security.DeptName == "业务部")
                {
                    业务员TextEdit.Text = Security.UserName;
                    业务员TextEdit.Properties.ReadOnly = true;
                }
                
            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }
        }
    }
}
