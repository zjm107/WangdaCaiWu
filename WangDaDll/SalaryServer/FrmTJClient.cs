using System;
using System.Windows.Forms;
using Tiger.Tools;

namespace WangDaDll.SalaryServer
{
    public partial class FrmTJClient : Form
    {
        public FrmTJClient()
        {
            InitializeComponent();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            splash.ShowWaitForm();
            splash.SetWaitFormCaption("查询");
            splash.SetWaitFormDescription("正在查询……");
            this.Cursor = Cursors.WaitCursor;
            try
            {
                string zzKSDate = 上次到期月份DateEdit.Text;
                string zzDQDate = 本次到期月份DateEdit.Text;
                string zfKSData = 支付日期DateEdit1.Text;
                string zfJSData = 支付日期DateEdit2.Text;
                string clientName = 支付单位TextEdit.Text;
                fXDataSet.GetClientFX(zzKSDate, zzDQDate, zfKSData, zfJSData, clientName);
            }
            catch (Exception ex)
            {
                UserMessages.ShowInfoBox(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
                if (splash.IsSplashFormVisible)
                    splash.CloseWaitForm();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            上次到期月份DateEdit.Text = "";
            本次到期月份DateEdit.Text = "";
            支付日期DateEdit1.Text = "";
            支付日期DateEdit2.Text = "";
            支付单位TextEdit.Text = "";
            fXDataSet.VW_客户收支表.Clear();
        }
    }
}
