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
using WangDaDll;

namespace WangDaDll
{
    public partial class FrmPayMentReg : DevExpress.XtraEditors.XtraForm
    {
        public FrmPayMentReg()
        {
            InitializeComponent();
        }

        private void btnSelectClient_Click(object sender, EventArgs e)
        {
            
            try {
                FrmNoPaymentDlg frmDlg = new FrmNoPaymentDlg(this.proceedsDataSet);
                if (frmDlg.ShowDialog() == DialogResult.OK)
                {
                    this.proceedsDataSet.ImpPaymentDetail(this.PaymentID,out this.ZCLX); //付款明细
                    
                }
            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }
        }
        /// <summary>
        /// 注册类型
        /// </summary>
        public string ZCLX;
        

        private void btnPayhalf_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            splash.ShowWaitForm();
            splash.SetWaitFormCaption("支付");
            splash.SetWaitFormDescription("支付一半…");
            try {
                this.proceedsDataSet.HalfPayment();
            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }
            finally {
                if (splash.IsSplashFormVisible)
                {
                    splash.CloseWaitForm();
                }
                this.Cursor = Cursors.Default;
            }
        }

        private void btnPayAll_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            splash.ShowWaitForm();
            splash.SetWaitFormCaption("支付");
            splash.SetWaitFormDescription("全部支付…");
            try
            {
                this.proceedsDataSet.FullPayment();
            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
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


        public bool CheckPayment()
        {
            if (string.IsNullOrEmpty(支付单位TextEdit.Text.Trim()))
            {
                UserMessages.ShowInfoBox("支付单位不能为空!");
                return false;
            }
            if (支付金额CalcEdit.Text=="" ||  支付金额CalcEdit.Value <= 0 )
            {
                UserMessages.ShowInfoBox("支付金额必须大于0!");
                return false;
            }
            if (string.IsNullOrEmpty(支付方式ComboBoxEdit.Text))
            {
                UserMessages.ShowInfoBox("支付方式必须填写!");
                return false;
            }
            foreach (DataRow row in proceedsDataSet.Tables["TW_PaymentDetail"].Rows)
            {
                decimal monthPrice = decimal.Parse(row["做账费收款额"].ToString());
                if (monthPrice > 0)
                {
                    decimal pj = decimal.Parse(row["月平均费"].ToString());
                    //if (pj <= 0)
                    //{
                    //    UserMessages.ShowInfoBox("月平均费必须大于0!");
                    //    return false;
                    //}
                    DateTime beginDate = new DateTime(1900, 1, 1);
                    if (string.IsNullOrEmpty(row["上次到期月"].ToString()))
                    {
                        UserMessages.ShowInfoBox("开始时间必须填写!");
                        return false;
                    }
                    beginDate = DateTime.Parse(row["上次到期月"].ToString());
                    DateTime endDate = new DateTime(1900, 1, 1);
                    if (string.IsNullOrEmpty(row["做账到期月"].ToString()))
                    {
                        UserMessages.ShowInfoBox("结束时间必须填写!");
                        return false;
                    }
                    endDate = DateTime.Parse(row["做账到期月"].ToString());
                    if ((beginDate < DateTime.Today && beginDate.Month != DateTime.Today.Month) && endDate >= DateTime.Today)
                    {
                        UserMessages.ShowInfoBox("补交款和预交款请分开收款!");
                        return false;
                    }

                    if (beginDate.Year != endDate.Year)
                    {
                        UserMessages.ShowInfoBox("跨年费用请分开收款!");
                        return false;
                    }
                }

            }


            return true;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (CheckPayment() == false)
                return;
            this.Cursor = Cursors.WaitCursor;
            tW_PaymentBindingSource.EndEdit();

            splash.ShowWaitForm();
            splash.SetWaitFormCaption("收款");
            splash.SetWaitFormDescription("正在收款中……");
            try
            {
                proceedsDataSet.GetRegTC(this.ZCLX);  //计算注册提成
                proceedsDataSet.SaveDataSet(); //保存数据
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
                this.Cursor = Cursors.Default;
            }
        }
        /// <summary>
        /// 当前的主键
        /// </summary>
        public string PaymentID
        {
            get;set;
        }

        private void FrmPayMentReg_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor ;
            try {
                proceedsDataSet.GetCommission();
                string newID = this.proceedsDataSet.NewPayment("注册收款");
                this.PaymentID = newID;
                
                dstTCONF_WORD.FillDevComboBox("支付方式", 支付方式ComboBoxEdit);
            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }
            finally {
                this.Cursor = Cursors.Default;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataRow row in proceedsDataSet.Tables["TW_PaymentDetail"].Rows)
                {
                    decimal monthPrice = decimal.Parse(row["做账费收款额"].ToString());
                    if (monthPrice > 0)
                    {
                        decimal month = decimal.Parse(row["缴费月数"].ToString());
                        decimal pj = Math.Round( monthPrice / month);
                        if (pj <= 0)
                        {
                            row.BeginEdit();
                            row["月平均费"] = pj;
                            row.EndEdit();
                        }
                    }
                }
                decimal sumPrice = proceedsDataSet.SumRegPayment();
                if (proceedsDataSet.TW_Payment.Rows.Count > 0)
                {
                    DataRow payRow = proceedsDataSet.TW_Payment.Rows[0];
                    payRow.BeginEdit();
                    payRow["支付金额"] = sumPrice;
                    payRow.EndEdit();
                }
            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }
        }

        private void tW_PaymentDetailBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            try {
                foreach (DataRow row in proceedsDataSet.Tables["TW_PaymentDetail"].Rows)
                {
                    decimal monthPrice = decimal.Parse(row["做账费收款额"].ToString());
                    if (monthPrice > 0)
                    {
                        decimal month = decimal.Parse(row["缴费月数"].ToString());
                        decimal pj = Math.Round( monthPrice / month);
                        if (pj <= 0)
                        {
                            row.BeginEdit();
                            row["月平均费"] = pj;
                            row.EndEdit();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }
        }
    }
}
