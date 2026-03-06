using System;
using System.Windows.Forms;
using Tiger.Tools;

namespace WangDaDll
{
    public partial class FrmNoPaymentReg : DevExpress.XtraEditors.XtraForm
    {
        public FrmNoPaymentReg()
        {
            InitializeComponent();
           
        }
       
        
        private void btnQuery_Click(object sender, EventArgs e)
        {

            this.Cursor = Cursors.WaitCursor;
            try
            {
                proceedsDataSet.GetNoPaymentReg(业务员TextEdit.Text,"",是否收款comboBoxEdit.Text);
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
                注册员TextEdit.Text = "";
                做账会计TextEdit.Text = "";
                proceedsDataSet.VW_BusinessRegNoPay.Clear();
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

        private void FrmNoPaymentReg_Load(object sender, EventArgs e)
        {
            try
            {
                是否收款comboBoxEdit.Text = "未收款";
            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (xlsSaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (xlsSaveFileDialog.FileName != "")
                {
                    gridView1.ExportToXlsx(xlsSaveFileDialog.FileName);

                }
            }
        }
    }
}
