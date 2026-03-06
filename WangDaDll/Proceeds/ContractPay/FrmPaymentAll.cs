using DevExpress.XtraPrinting.Native.Preview;
using System;
using System.Data;
using System.Windows.Forms;
using Tiger.Tools;
using WangDaDll.Common;
using WangDaDll.Contract;

namespace WangDaDll
{
    public partial class FrmPaymentAll : DevExpress.XtraEditors.XtraForm
    {
        public FrmPaymentAll()
        {
            InitializeComponent();
            frmUserDlg.DeptName = "做账部";
        }
        /// <summary>
        /// 检查必填项
        /// </summary>
        /// <returns></returns>
        public bool CheckPayment()
        {
            if (string.IsNullOrEmpty(支付单位TextBox.Text.Trim()))
            {
                UserMessages.ShowInfoBox("支付单位不能为空!");
                return false;
            }
            if (string.IsNullOrEmpty(支付方式ComboBoxEdit.Text))
            {
                UserMessages.ShowInfoBox("支付方式必须填写!");
                return false;
            }
            if (string.IsNullOrEmpty(总额TextBox.Text))
            {
                UserMessages.ShowInfoBox("支付金额不可以是0!");
                return false;
            }
            if(decimal.Parse( 总额TextBox.Text.Trim())==0)
            {
                UserMessages.ShowInfoBox("支付金额不可以是0!");
                return false;
            }
            //如果是周期性服务，检查开始时间，结束时间，缴费月数
            if (周期性服务checkEdit.Checked)
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
            }

            //如果是一次性服务，检查一次性服务费必须大于0
            if (一次性服务checkEdit.Checked)
            {
                if (string.IsNullOrEmpty(一次性服务费textEdit.Text))
                {
                    UserMessages.ShowInfoBox("一次性服务费必须大于0!");
                    return false;
                }
                if (decimal.Parse(一次性服务费textEdit.Text) <= 0)
                {
                    UserMessages.ShowInfoBox("一次性服务费必须大于0!");
                    return false;
                }
            }
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
                paymentMainRow.BeginEdit();
                paymentMainRow.客户名称ID = row["客户名称ID"].ToString();
                paymentMainRow.支付单位 = row["客户名称"].ToString();
                paymentMainRow.业务员 = row["业务员"].ToString();
                paymentMainRow.业务员ID = row["业务员ID"].ToString();
                paymentMainRow.注册员 = row["注册员"].ToString();
                paymentMainRow.注册员ID = row["注册员ID"].ToString();
                if(paymentMainRow.Is做账会计Null())
                {
                    paymentMainRow.做账会计 = row["做账会计"].ToString();
                    paymentMainRow.做账会计ID = row["做账会计ID"].ToString();
                }
                else
                {
                    if (paymentMainRow.做账会计ID != row["做账会计ID"].ToString())
                    {
                        if (UserMessages.ShowQuestionBox("做账会计要变更为:" + row["做账会计"].ToString() + "么？"))
                        {
                            paymentMainRow.做账会计 = row["做账会计"].ToString();
                            paymentMainRow.做账会计ID = row["做账会计ID"].ToString();
                        }
                    }
                  
                }
                //paymentMainRow.注册提成月 = 0;
                //paymentMainRow.业务提成月 = 0;
                //paymentMainRow.做账提成月 = 0;
                //paymentMainRow.做账团队提成 = 0;
                //paymentMainRow.业务团队提成 = 0;
                //paymentMainRow.做账主管提成 = 0;
                //paymentMainRow.注册团队提成 = 0;
                //paymentMainRow.注册年提成 = 0;
                //paymentMainRow.业务年提成 = 0;
                //paymentMainRow.工本开票提成 = 0;
                //paymentMainRow.做账业务团队提成 = 0;
                paymentMainRow.零申报 = false;
                

                if (!string.IsNullOrEmpty(row["费用到期月份"].ToString()))
                {
                    // paymentRow.上次到期月份 = DateTime.Parse(row["费用到期月份"].ToString());
                    DateTime scDate = DateTime.Parse(row["费用到期月份"].ToString());
                    if (scDate.Day == 28 || scDate.Day == 29 || scDate.Day == 30 || scDate.Day == 31)
                    {
                        DateTime startDate  = scDate.AddMonths(1);
                        startDate = new DateTime(startDate.Year, startDate.Month, 1);
                        paymentMainRow.上次到期月份 = startDate;
                    }
                       
                }
                 
              
                string endPay = row["首年提成结束期"].ToString();
                if (!string.IsNullOrEmpty(endPay))
                {
                    endPayDate = endPay;
                    paymentMainRow.首年提成结束期 =DateTime.Parse( endPayDate);
                }
              
                paymentMainRow.EndEdit();

            }
        }
        /// <summary>
        /// 首年提成结束期
        /// </summary>
        string endPayDate;
        /// <summary>
        /// 当前付款行
        /// </summary>
        public ProceedsDataSet.TW_PaymentMainRow paymentMainRow;
        /// <summary>
        /// 当前合同行
        /// </summary>
        public Contract.ContractDataSet.TW_ContractRow cRow;
        /// <summary>
        /// 合同服务行
        /// </summary>
        public Contract.ContractDataSet.TW_ContractServiceInfoDataTable sTable;
        /// <summary>
        /// 合同应收款行
        /// </summary>
        public Contract.ContractDataSet.vw_ContractReceivablesAccountingRow payRow;
        /// <summary>
        /// 已收款金额
        /// </summary>
        decimal hadPayAmount = 0.0m;
        /// <summary>
        /// 最后收款日期
        /// </summary>
        string lastPayDate = "";

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
            frmUserDlg.DeptName = "做账部";
            if (frmUserDlg.ShowDialog() == DialogResult.OK)
            {
                DataRowView rv = frmUserDlg.SelectRow;
                paymentMainRow.BeginEdit();
                paymentMainRow.做账会计 = rv["UserName"].ToString();
                paymentMainRow.做账会计ID = rv["UserID"].ToString();
                paymentMainRow.EndEdit();
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
                string clientId = rv["客户名称ID"].ToString();
                string endPaymentDate = rv["本次到期月份"].ToString();
                rv["周期性服务费"] = 周期性服务费CalcEdit.Value;
                if (周期性服务checkEdit.Checked)
                {
                  
                    ///查询关联人员
                    proceedsDataSet.GetUsers(rv["注册员ID"].ToString(), rv["业务员ID"].ToString(), rv["做账会计ID"].ToString());

                    if (!string.IsNullOrEmpty(缴费月数TextEdit.Text))
                    {
                        decimal month = decimal.Parse(缴费月数TextEdit.Text);
                        if (month > 0)//如果有周期性服务，按月拆分
                        {

                            proceedsDataSet.CFPayment(this.paymentMainRow); //拆分主记录

                        }
                    }
                }
                if(一次性服务checkEdit.Checked)
                {
                    string newID = this.proceedsDataSet.NewPayment(this.paymentMainRow,sTable);

                }
                proceedsDataSet.SaveDataSet(); //保存数据
                if (!string.IsNullOrEmpty(endPaymentDate))
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
        bool isLoad = false;

        private void FrmPaymentGeneral_Load(object sender, EventArgs e)
        {
            isLoad = true;
            try
            {
                一次性服务checkEdit.Checked = false;
                周期性服务checkEdit.Checked = false;
                一次性服务layoutControlGroup.Enabled = false;
                周期性服务layoutControlGroup.Enabled = false;
                dstTCONF_WORD.FillDevComboBox("支付方式", 支付方式ComboBoxEdit);
                proceedsDataSet.GetCommission();

                string newID = proceedsDataSet.NewMainPayment(cRow, sTable, payRow);
                this.paymentMainRow = proceedsDataSet.TW_PaymentMain.FindByTW_PaymentID(newID); //定位主行记录

                //如果缴费过，并且缴费在这个合同的周期里，从缴费的截止时间开始
                //if (!payRow.Is费用截止月Null() && payRow.费用截止月 > paymentMainRow.上次到期月份)
                //{
                //    paymentMainRow.BeginEdit();
                //    DateTime endmonth = payRow.费用截止月.AddMonths(1);
                //    paymentMainRow.上次到期月份 = new DateTime(endmonth.Year, endmonth.Month, 1);
                //    paymentMainRow.缴费月数= paymentMainRow.本次到期月份.Month - payRow.费用截止月.Month  + (paymentMainRow.本次到期月份.Year - paymentMainRow.上次到期月份.Year) * 12;
                //    paymentMainRow.本次到期月份= paymentMainRow.上次到期月份.AddMonths((int)paymentMainRow.缴费月数).AddDays(-1);
                //    int freeMonth = sRow.赠送时长月;
                //    paymentMainRow.周期性服务费 = paymentMainRow.月做账费 * (paymentMainRow.缴费月数 - freeMonth);
                //    paymentMainRow.支付总额= paymentMainRow.周期性服务费 + paymentMainRow.一次性服务费 + paymentMainRow.开票费 + paymentMainRow.工本费;
                //    paymentMainRow.EndEdit();
                //}
                if (sTable.Rows.Count > 0)
                {
                    DataRow[] sRows = sTable.Select("服务类别='一次性服务'");
                    if (sRows.Length > 0)
                    {
                        decimal regPrice  = decimal.Parse(sRows[0]["服务金额"].ToString());
                        if (regPrice > payRow.已收一次性服务费)
                            一次性服务checkEdit.Checked = true;
                    }
                    sRows = sTable.Select("服务类别='周期性服务'");
                    if (sRows.Length > 0)
                    {
                        decimal servicePrice = decimal.Parse(sRows[0]["服务金额"].ToString());
                        decimal serviceMonth = decimal.Parse(sRows[0]["服务期限月"].ToString());
                        if (servicePrice * serviceMonth != payRow.已收周期性服务费)
                            周期性服务checkEdit.Checked = true;
                    }

                }
                if (!string.IsNullOrEmpty(paymentMainRow.合同编号) && paymentMainRow.合同编号.Contains("补"))
                { 
                    //不收款即为公司补贴
                    不收款CheckEdit.Checked = true;    
                }
            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }
            finally
            {
                isLoad = false;
            }
        }

        private void 支付金额CalcEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (isLoad)
                return;
            if (paymentMainRow == null) return;
            try
            {
                decimal regPrice = 0;//一次性服务费
                if (一次性服务checkEdit.Checked && !string.IsNullOrEmpty(一次性服务费textEdit.Text))
                {
                    regPrice = decimal.Parse(一次性服务费textEdit.Text);
                    paymentMainRow.一次性服务费 = regPrice;
                }

                decimal payPrice = 0;
                decimal kpPrice = 0;
                decimal gbPrice = 0;
                if (周期性服务checkEdit.Checked)
                {
                    payPrice = 周期性服务费CalcEdit.Value;
                    kpPrice = 开票费CalcEdit.Value;
                    gbPrice = 工本费CalcEdit.Value;
                }
               
                
                decimal sumprice = payPrice + kpPrice + gbPrice+regPrice;
                paymentMainRow.支付总额 = sumprice;
                paymentMainRow.周期性服务费 = payPrice;
                总额TextBox.Text = sumprice.ToString();
                decimal month = 0;

                if (!string.IsNullOrEmpty(缴费月数TextEdit.Text))
                {
                    month = decimal.Parse(缴费月数TextEdit.Text);
                }
                if (month > 0)
                {
                    payPrice = Math.Floor(payPrice / month);
                    // payPrice = Math.Round( payPrice / month);
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
            if (isLoad)
                return;

            if (paymentMainRow == null) return;
           //
            int month = 0;

            if (!string.IsNullOrEmpty(缴费月数TextEdit.Text))
            {
                month = int.Parse(缴费月数TextEdit.Text);
                paymentMainRow.缴费月数 = month;
            }
            if (month > 0)
            {
                DateTime beginDate = new DateTime(1900, 1, 1);
                if (!string.IsNullOrEmpty(上次到期月DateEdit.Text))
                {
                    beginDate = 上次到期月DateEdit.DateTime;
                    DateTime endDate = beginDate.AddMonths((int)month - 1);
                    int maxDays = DateTime.DaysInMonth(endDate.Year, endDate.Month);
                    endDate = new DateTime(endDate.Year, endDate.Month, maxDays);
                    //本次到期月DateEdit.DateTime = endDate;
                    paymentMainRow.本次到期月份 = endDate;
                    本次到期月DateEdit.DateTime = endDate;
                    //计算周期性服务费
                    if (paymentMainRow.月做账费 > 0)
                    {

                        //paymentMainRow.周期性服务费 = paymentMainRow.月做账费 * month;
                        paymentMainRow.支付总额 = paymentMainRow.周期性服务费 + paymentMainRow.一次性服务费 + paymentMainRow.开票费 + paymentMainRow.工本费;
                      //  周期性服务费CalcEdit.Value = paymentMainRow.周期性服务费;
                        总额TextBox.Text = paymentMainRow.支付总额.ToString();
                    }

                    decimal payPrice = 0;
                    if (周期性服务checkEdit.Checked)
                    {
                        payPrice = 周期性服务费CalcEdit.Value;
                       
                    }
                    if (month > 0)
                    {
                        //取整数，不四舍五入
                        payPrice= Math.Floor(payPrice / month);
                        //payPrice = payPrice / month;
                        //payPrice = Math.Round(payPrice / month);
                        if (payPrice > 0)
                        {
                            月平均费TextEdit.Value = payPrice;

                        }
                    }

                }
            }
            else
            {
                paymentMainRow.本次到期月份 = DateTime.Parse("1900-01-01");
                paymentMainRow.周期性服务费 = 0;
                paymentMainRow.支付总额 = paymentMainRow.一次性服务费 + paymentMainRow.开票费 + paymentMainRow.工本费;
                周期性服务费CalcEdit.Value = 0;
                总额TextBox.Text = paymentMainRow.支付总额.ToString();
            }
           // tW_PaymentBindingSource.EndEdit();

        }

        /// <summary>
        /// 选择注册员
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelReg_Click(object sender, EventArgs e)
        {
            frmUserDlg.DeptName = "注册部";
            if (frmUserDlg.ShowDialog() == DialogResult.OK)
            {
                DataRowView rv = frmUserDlg.SelectRow;
                paymentMainRow.BeginEdit();
                paymentMainRow.注册员 = rv["UserName"].ToString();
                paymentMainRow.注册员ID = rv["UserID"].ToString();
                paymentMainRow.EndEdit();
            }
        }
        /// <summary>
        /// 根据缴费月数，计算本次到期月的日期，周期性服务费，支付总额
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 上次到期月DateEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (isLoad)
                return;
            //tW_PaymentBindingSource.EndEdit();
            if (paymentMainRow == null) return;
            decimal month = 0;
            if (!string.IsNullOrEmpty(缴费月数TextEdit.Text))
            {
                month = decimal.Parse(缴费月数TextEdit.Text);
            }
            if (month > 0)
            {
                DateTime beginDate = new DateTime(1900, 1, 1);
                if (!string.IsNullOrEmpty(上次到期月DateEdit.Text))
                {
                    beginDate = 上次到期月DateEdit.DateTime;
                    DateTime endDate = beginDate.AddMonths((int)month - 1);
                    int maxDays = DateTime.DaysInMonth(endDate.Year, endDate.Month);
                    endDate = new DateTime(endDate.Year, endDate.Month, maxDays);
                    本次到期月DateEdit.DateTime = endDate;
                    //计算周期性服务费
                    if (paymentMainRow.月做账费 > 0)
                    {
                       // paymentMainRow.周期性服务费 = paymentMainRow.月做账费 * month;
                        paymentMainRow.支付总额 = paymentMainRow.周期性服务费 + paymentMainRow.一次性服务费 + paymentMainRow.开票费 + paymentMainRow.工本费;
                    }
                }

                decimal payPrice = 0;
                if (周期性服务checkEdit.Checked)
                {
                    payPrice = 周期性服务费CalcEdit.Value;

                }

                payPrice = Math.Floor(payPrice / month);
                //  payPrice = Math.Round(payPrice / month);
                if (payPrice > 0)
                    {
                        月平均费TextEdit.Value = payPrice;

                    }
               


            }
        }
        /// <summary>
        /// 选择一次性服务
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 一次性服务checkEdit_CheckedChanged(object sender, EventArgs e)
        {
            isLoad = true;
            try
            {



                if (一次性服务checkEdit.Checked)
                {
                    DataRow[] sRows = sTable.Select("服务类别='一次性服务'");
                    if (sRows.Length > 0)
                    {
                        一次性服务layoutControlGroup.Enabled = true;
                        Contract.ContractDataSet.TW_ContractServiceInfoRow sRow = sRows[0] as Contract.ContractDataSet.TW_ContractServiceInfoRow;
                        if (sRow.服务金额 > payRow.已收一次性服务费)
                        {
                            paymentMainRow.一次性服务费 = sRow.服务金额 - payRow.已收一次性服务费;

                            //paymentMainRow.一次性服务费 = payRow.应收款金额; 
                            paymentMainRow.注册员 = cRow.注册员;
                            paymentMainRow.注册员ID = cRow.注册员ID;
                        }
                        else
                        {
                            MessageBox.Show("该合同的一次性服务费用已经收完，请在合同服务里添加!");
                            paymentMainRow.一次性服务费 = 0;
                            //paymentMainRow.注册员 = "";
                            //paymentMainRow.注册员ID = "";
                        }
                    }
                    else
                    {
                        一次性服务layoutControlGroup.Enabled = false;
                        MessageBox.Show("该合同没有一次性服务费用，请在合同服务里添加!");
                        paymentMainRow.一次性服务费 = 0;
                        //paymentMainRow.注册员 = "";
                        //paymentMainRow.注册员ID = "";
                    }
                }
                else
                {
                    一次性服务layoutControlGroup.Enabled = false;
                    paymentMainRow.一次性服务费 = 0;
                    //paymentMainRow.注册员 = "";
                    //paymentMainRow.注册员ID = "";
                }
                paymentMainRow.EndEdit();
                isLoad = false;
                支付金额CalcEdit_EditValueChanged(null, null);
            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }
            finally
            {
                isLoad = false;
            }
        }
        /// <summary>
        /// 选择周期性服务
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 周期性服务checkEdit_CheckedChanged(object sender, EventArgs e)
        {
            try
            {

                isLoad = true;

                if (周期性服务checkEdit.Checked)
                {
                    DataRow[] sRows = sTable.Select("服务类别='周期性服务'");
                    if (sRows.Length > 0)
                    {
                        周期性服务layoutControlGroup.Enabled = true;
                        Contract.ContractDataSet.TW_ContractServiceInfoRow sRow = sRows[0] as Contract.ContractDataSet.TW_ContractServiceInfoRow;
                        paymentMainRow.月做账费 = sRow.服务金额;
                        
                        if (cRow.合同金额 != payRow.已收周期性服务费)
                        {
                            paymentMainRow.周期性服务费 = cRow.合同金额 - payRow.已收周期性服务费-payRow.已收一次性服务费;
                            //计算缴费月数=服务期限月-已收周期性服务费/服务金额
                            int payMonths = int.Parse(Math.Round(payRow.已收周期性服务费 / sRow.服务金额, 0).ToString());

                            int totalMonths = sRow.服务期限月 - payMonths;
                            if (!payRow.Is费用截止月Null() && payRow.费用截止月 > paymentMainRow.上次到期月份)
                            {


                                paymentMainRow.BeginEdit();
                                DateTime endmonth = payRow.费用截止月.AddMonths(1);
                                paymentMainRow.上次到期月份 = new DateTime(endmonth.Year, endmonth.Month, 1);
                                paymentMainRow.缴费月数 = totalMonths;
                                paymentMainRow.本次到期月份 = paymentMainRow.上次到期月份.AddMonths((int)paymentMainRow.缴费月数).AddDays(-1);
                                //int freeMonth = sRow.赠送时长月;
                                //paymentMainRow.周期性服务费 = paymentMainRow.月做账费 * (paymentMainRow.缴费月数 - freeMonth);
                                paymentMainRow.支付总额 = paymentMainRow.周期性服务费 + paymentMainRow.一次性服务费 + paymentMainRow.开票费 + paymentMainRow.工本费;
                                paymentMainRow.EndEdit();
                            }
                            else
                            {
                                paymentMainRow.上次到期月份 = sRow.开始服务月;
                                paymentMainRow.本次到期月份 = sRow.结束服务月;
                                paymentMainRow.缴费月数 = sRow.服务总时长月;
                                //paymentMainRow.周期性服务费 = sRow.服务金额 * sRow.服务期限月;
                                paymentMainRow.支付总额 = paymentMainRow.周期性服务费 + paymentMainRow.一次性服务费 + paymentMainRow.开票费 + paymentMainRow.工本费;
                            }

                           
                            paymentMainRow.做账会计 = cRow.做账会计;
                            paymentMainRow.做账会计ID = cRow.做账会计ID;
                        }
                    }
                    else
                    {
                        周期性服务layoutControlGroup.Enabled = false;
                        MessageBox.Show("该合同没有周期性服务费用，请在合同服务里添加!");
                        paymentMainRow.缴费月数 = 0;
                        paymentMainRow.月做账费 = 0;
                        paymentMainRow.周期性服务费 = 0;
                       // paymentMainRow.做账会计 = "";
                        //paymentMainRow.做账会计ID = "";
                    }
                }
                else
                {
                    周期性服务layoutControlGroup.Enabled = false;
                    paymentMainRow.缴费月数 = 0;
                    paymentMainRow.月做账费 = 0;
                    paymentMainRow.周期性服务费 = 0;
                   // paymentMainRow.做账会计 = "";
                    //paymentMainRow.做账会计ID = "";
                }
                paymentMainRow.EndEdit();
                isLoad = false;
                支付金额CalcEdit_EditValueChanged(null, null);
            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }
            finally
            {
                isLoad = false;
            }
        }

        private void 一次性服务费textEdit_EditValueChanged(object sender, EventArgs e)
        {
            支付金额CalcEdit_EditValueChanged(sender, e);
        }
    }
}
