﻿using System;
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
using WangDaDll.Common;

namespace WangDaDll
{
    public partial class FrmPaymentGeneral : DevExpress.XtraEditors.XtraForm
    {
        public FrmPaymentGeneral()
        {
            InitializeComponent();
            frmUserDlg.DeptName = "做账部";
        }

        public bool CheckPayment()
        {
            DateTime beginDate = new DateTime(1900, 1, 1);
            if (string.IsNullOrEmpty(上次到期月DateEdit.Text))
            {
                UserMessages.ShowInfoBox("开始时间必须填写!");
                return false;
            }
            beginDate = 上次到期月DateEdit.DateTime;
            DateTime endDate = new DateTime(1900, 1, 1);
            if (string.IsNullOrEmpty(本次到期月DateEdit.Text))
            {
                UserMessages.ShowInfoBox("结束时间必须填写!");
                return false;
            }
            endDate = 本次到期月DateEdit.DateTime;
            //if ((beginDate < DateTime.Today && beginDate.Month != DateTime.Today.Month) &&  endDate>=DateTime.Today  )
            //{
            //    UserMessages.ShowInfoBox("补交款和预交款请分开收款!");
            //    return false ;
            //}
            if (beginDate.Year != endDate.Year)
            {
                UserMessages.ShowInfoBox("跨年费用请分开收款!");
                return false;
            }

            if (!string.IsNullOrEmpty( endPayDate))
            {
                DateTime pDate = DateTime.Parse(endPayDate);
                if (endDate>pDate && pDate > beginDate)
                {
                    UserMessages.ShowInfoBox(string.Format("首年业务提成期是{0},请将收款已这个时间分开!",pDate));
                    return false;
                }
            }
            if (string.IsNullOrEmpty(支付单位ButtonEdit.Text.Trim()))
            {
                UserMessages.ShowInfoBox("支付单位不能为空!");
                return false;
            }

            //if (支付金额CalcEdit.Text == "" || 支付金额CalcEdit.Value <= 0)
            //{
            //    UserMessages.ShowInfoBox("支付金额必须大于0!");
            //    return false;
            //}
            decimal month = 0;

            if (!string.IsNullOrEmpty(缴费月数TextEdit.Text))
            {
                month = decimal.Parse(缴费月数TextEdit.Text);
            }
            if (month == 0)
            {
                UserMessages.ShowInfoBox("缴费月数必须大于0");
                return false;
            }
            if (string.IsNullOrEmpty(支付方式ComboBoxEdit.Text))
            {
                UserMessages.ShowInfoBox("支付方式必须填写!");
                return false;
            }

            decimal monthPrice = 0;

            if (!string.IsNullOrEmpty(月平均费TextEdit.Text))
            {
                monthPrice = 月平均费TextEdit.Value;
            }
            //if (monthPrice == 0)
            //{
            //    UserMessages.ShowInfoBox("月平均费必须大于0!");
            //    return false;
            //}
            return true;
        }
        /// <summary>
        /// 选择收款单位
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectUnit_Click(object sender, EventArgs e)
        {
            if (frmclientDlg.ShowDialog() == DialogResult.OK)
            {
                var dst = frmclientDlg.selCsDataSet;
                var row = dst.TW_Client.Rows[0];
                paymentRow.BeginEdit();
                paymentRow.客户名称ID = row["客户名称ID"].ToString();
                paymentRow.支付单位 = row["客户名称"].ToString();
                paymentRow.业务员 = row["业务员"].ToString();
                paymentRow.业务员ID = row["业务员ID"].ToString();
                paymentRow.注册员 = row["注册员"].ToString();
                paymentRow.注册员ID = row["注册员ID"].ToString();
                if(paymentRow.Is做账会计Null())
                {
                    paymentRow.做账会计 = row["做账会计"].ToString();
                    paymentRow.做账会计ID = row["做账会计ID"].ToString();
                }
                else
                {
                    if (paymentRow.做账会计ID != row["做账会计ID"].ToString())
                    {
                        if (UserMessages.ShowQuestionBox("做账会计要变更为:" + row["做账会计"].ToString() + "么？"))
                        {
                            paymentRow.做账会计 = row["做账会计"].ToString();
                            paymentRow.做账会计ID = row["做账会计ID"].ToString();
                        }
                    }
                  
                }
                paymentRow.注册提成月 = 0;
                paymentRow.业务提成月 = 0;
                paymentRow.做账提成月 = 0;
                paymentRow.做账团队提成 = 0;
                paymentRow.业务团队提成 = 0;
                paymentRow.做账主管提成 = 0;
                paymentRow.注册团队提成 = 0;
                paymentRow.注册年提成 = 0;
                paymentRow.业务年提成 = 0;
                paymentRow.工本开票提成 = 0;
                paymentRow.做账业务团队提成 = 0;
                paymentRow.零申报 = false;
                

                if (!string.IsNullOrEmpty(row["费用到期月份"].ToString()))
                {
                    // paymentRow.上次到期月份 = DateTime.Parse(row["费用到期月份"].ToString());
                    DateTime scDate = DateTime.Parse(row["费用到期月份"].ToString());
                    if (scDate.Day == 28 || scDate.Day == 29 || scDate.Day == 30 || scDate.Day == 31)
                    {
                        DateTime startDate  = scDate.AddMonths(1);
                        startDate = new DateTime(startDate.Year, startDate.Month, 1);
                        paymentRow.上次到期月份 = startDate;
                    }
                       
                }
                 
              
                string endPay = row["首年提成结束期"].ToString();
                if (!string.IsNullOrEmpty(endPay))
                {
                    endPayDate = endPay;
                    paymentRow.首年提成结束期 =DateTime.Parse( endPayDate);
                }
              
                paymentRow.EndEdit();

            }
        }
        /// <summary>
        /// 首年提成结束期
        /// </summary>
        string endPayDate;
        /// <summary>
        /// 当前付款行
        /// </summary>
        public ProceedsDataSet.TW_PaymentRow paymentRow;
        
        /// <summary>
        /// 选择用户信息
        /// </summary>
        FrmClientSelectDlg frmclientDlg = new FrmClientSelectDlg();
        /// <summary>
        /// 选择用户
        /// </summary>
        FrmUserSelectDlg frmUserDlg = new FrmUserSelectDlg();
        /// <summary>
        /// 选择做账会计
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAccount_Click(object sender, EventArgs e)
        {
            if (frmUserDlg.ShowDialog() == DialogResult.OK)
            {
                DataRowView rv = frmUserDlg.SelectRow;
                paymentRow.BeginEdit();
                paymentRow.做账会计 = rv["UserName"].ToString();
                paymentRow.做账会计ID = rv["UserID"].ToString();
                paymentRow.EndEdit();
            }
        }
        /// <summary>
        /// 收款确定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (零申报CheckEdit.Checked)
            {
                if (!UserMessages.ShowQuestionBox("确定要零申报收款么?"))
                    return;
            }
           
            if (!CheckPayment())
                return;
            this.Cursor = Cursors.WaitCursor;
            tW_PaymentBindingSource.EndEdit();
            DataRowView rv = tW_PaymentBindingSource.Current as DataRowView;
            splash.ShowWaitForm();
            splash.SetWaitFormCaption("收款");
            splash.SetWaitFormDescription("正在收款中……");
            try
            {
                //添加主收款记录
                proceedsDataSet.AddPaymentMainRow(rv.Row as ProceedsDataSet.TW_PaymentRow);
                string endPaymentDate = rv["本次到期月份"].ToString();
                string clientId = rv["客户名称ID"].ToString();
                ///查询关联人员
                proceedsDataSet.GetUsers(rv["注册员ID"].ToString(), rv["业务员ID"].ToString(), rv["做账会计ID"].ToString());

                if (!string.IsNullOrEmpty(缴费月数TextEdit.Text))
                {
                    decimal month = decimal.Parse(缴费月数TextEdit.Text);
                    if (month > 1)//如果缴费超过1个月拆分
                    {

                        proceedsDataSet.CFPayment(int.Parse(month.ToString()), rv.Row);

                    }
                    else
                    {

                        proceedsDataSet.GetZCTC(rv.Row as ProceedsDataSet.TW_PaymentRow);

                    }
                }
                proceedsDataSet.SaveDataSet(); //保存数据
                proceedsDataSet.UpdateClientPaymentDate(endPaymentDate, clientId);
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
   

        /// <summary>
        /// 收款取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        private void FrmPaymentGeneral_Load(object sender, EventArgs e)
        {
            try {
                dstTCONF_WORD.FillDevComboBox("支付方式", 支付方式ComboBoxEdit);
                proceedsDataSet.GetCommission();
                string newID = proceedsDataSet.NewPayment("常规收款");
                this.paymentRow = proceedsDataSet.TW_Payment.FindByTW_PaymentID(newID);

            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }
        }

        private void 支付金额CalcEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                decimal payPrice = 0;
                decimal kpPrice = 0;
                decimal gbPrice = 0;
                payPrice = 支付金额CalcEdit.Value;
                kpPrice = 开票费CalcEdit.Value;
                gbPrice = 工本费CalcEdit.Value;
                decimal sumprice = payPrice + kpPrice + gbPrice;
                总额TextBox.Text = sumprice.ToString();
                decimal month = 0;

                if (!string.IsNullOrEmpty(缴费月数TextEdit.Text))
                {
                    month = decimal.Parse(缴费月数TextEdit.Text);
                }
                if (month > 0)
                {
                    payPrice = Math.Round( payPrice / month);
                    if (payPrice > 0)
                    {
                        月平均费TextEdit.Value = payPrice;
                    }
                }

            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }

        }

        private void 缴费月数TextEdit_EditValueChanged(object sender, EventArgs e)
        {

            decimal payPrice = 支付金额CalcEdit.Value;
            decimal month = 0;

            if (!string.IsNullOrEmpty(缴费月数TextEdit.Text))
            {
                month = decimal.Parse(缴费月数TextEdit.Text);
            }
            if (month > 0)
            {
                payPrice = Math.Round(payPrice / month);
                if (payPrice > 0)
                {
                    月平均费TextEdit.Value = payPrice;
                }
            }
        }

        private void 本次到期月DateEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(本次到期月DateEdit.Text) && !string.IsNullOrEmpty(上次到期月DateEdit.Text))
            {
                int maxDays = DateTime.DaysInMonth(本次到期月DateEdit.DateTime.Year, 本次到期月DateEdit.DateTime.Month);
                if (maxDays < 28)
                {
                    本次到期月DateEdit.DateTime = new DateTime(本次到期月DateEdit.DateTime.Year, 本次到期月DateEdit.DateTime.Month, maxDays);
                }

                DateTime beginDate = 上次到期月DateEdit.DateTime;
                DateTime endDate = 本次到期月DateEdit.DateTime;
                var mDays = endDate - beginDate;
                int days = mDays.Days + 1;
                if (days >= 30)
                {
                    int months = days / 30;
                    缴费月数TextEdit.Text = months.ToString();
                }


            }
            
        }
    }
}
