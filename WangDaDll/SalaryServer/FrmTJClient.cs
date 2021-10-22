using System;
using System.Data;
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

        private void FrmTJClient_Load(object sender, EventArgs e)
        {
            上次到期月份DateEdit.DateTime = new DateTime(DateTime.Today.Year, 1, 1);
            本次到期月份DateEdit.DateTime = new DateTime(DateTime.Today.Year, 12, 31);
        }

        private void btnShowDetail_Click(object sender, EventArgs e)
        {
            ShowDetail();
        }

        private void ShowDetail()
        {
            try
            {
                DataRowView rv = gridView1.GetFocusedRow() as DataRowView;
                string clientName = rv["支付单位"].ToString();
                string zzKSDate = 上次到期月份DateEdit.Text;
                string zzDQDate = 本次到期月份DateEdit.Text;
                string zfKSData = 支付日期DateEdit1.Text;
                string zfJSData = 支付日期DateEdit2.Text;
                FrmTJClientDetail frmshow = new FrmTJClientDetail();
               // frmshow.clientId = clientName;
                frmshow.clientName = clientName;
                frmshow.BeginDate = zzKSDate;
                frmshow.EndDate = zzDQDate;
                frmshow.ZFBeginDate = zfKSData;
                frmshow.ZFEndDate = zfJSData;
                frmshow.Show();

            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            ShowDetail();
        }
    }
}
