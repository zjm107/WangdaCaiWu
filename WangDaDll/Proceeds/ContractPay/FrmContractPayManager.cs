using System;
using System.Data;
using System.Windows.Forms;
using Tiger.Tools;
using WangDaDll.Common;
namespace WangDaDll
{
    public partial class FrmContractPayManager : DevExpress.XtraEditors.XtraForm
    {
        public FrmContractPayManager()
        {
            InitializeComponent();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            isQuery = false;
            try
            {
                proceedsDataSet.DBHelper.WangDaSer.UpdateUserID();
                string paymentEndDate = "";
                if (!string.IsNullOrEmpty(本次到期月DateEdit.Text))
                {
                    paymentEndDate = ((DateTime)本次到期月DateEdit.EditValue).ToShortDateString();
                }
                if (Security.UserName == "秦艳" || Security.UserName == "admin")   //管理员可以查看所有信息
                {
                    proceedsDataSet.GetPaymentByInfo2025(支付单位TextEdit.Text, txtRY.Text, 支付日期DateEdit.Text, 支付日期DateEdit1.Text, 收款类别ComboBoxEdit.Text, paymentEndDate,"",comboBoxEditBSK.Text,comboBoxEditLSB.Text);
                }
                else
                    if (Security.UserBusiness == "注册主管") //注册主管可以查看注册主管的信息
                {
                    proceedsDataSet.GetPaymentByInfo2025(支付单位TextEdit.Text, txtRY.Text, 支付日期DateEdit.Text, 支付日期DateEdit1.Text, 收款类别ComboBoxEdit.Text, paymentEndDate,"注册主管", comboBoxEditBSK.Text, comboBoxEditLSB.Text);
                }
                else
                {
                    //其他会计只能查看自己的信息
                    proceedsDataSet.GetPaymentByInfo2025(支付单位TextEdit.Text, Security.UserName, 支付日期DateEdit.Text, 支付日期DateEdit1.Text, 收款类别ComboBoxEdit.Text, paymentEndDate,"", comboBoxEditBSK.Text, comboBoxEditLSB.Text);
                }
                tW_PaymentBindingSource.MoveFirst();
                tW_PaymentMainGridView.BestFitColumns();
                
                tW_PaymentMainGridView.ExpandAllGroups();
                GetPaymentDetail();
            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }
            finally {
                isQuery = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                支付单位TextEdit.Text = "";
                支付方式ComboBoxEdit.Text = "";
                支付日期DateEdit.Text = "";
                支付日期DateEdit1.Text = "";
                收款类别ComboBoxEdit.Text = "";
                proceedsDataSet.TW_Payment.Clear();
                proceedsDataSet.TW_PaymentDetail.Clear();

            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }
        }
        /// <summary>
        /// 周期性服务收款，即常规收款
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGeneralPay_Click(object sender, EventArgs e)
        {
    
        }
        /// <summary>
        /// 一次性服务收款，即注册收款
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegPay_Click(object sender, EventArgs e)
        {
            try {
                FrmPayMentReg frmPaymentRegDlg = new FrmPayMentReg();
                if (frmPaymentRegDlg.ShowDialog() == DialogResult.OK)
                {
                     string paymentID = frmPaymentRegDlg.PaymentID;
                    proceedsDataSet.GetPaymentById(paymentID);
                    
                    proceedsDataSet.TW_Payment.AcceptChanges();

                    //proceedsDataSet.ImpPaymentDetail(paymentID);
                }
            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }
        }
        bool isQuery = false;

    

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                DataRowView rv = tW_PaymentBindingSource.Current as DataRowView;
                if (rv != null)
                {
                    string paymentID = rv["TW_PaymentID"].ToString();
                    string paymentType = rv["收款类别"].ToString();
                    string creater = rv["操作人"].ToString();
                    if (creater != Security.UserName) { UserMessages.ShowInfoBox("操作人本人可以进行修改!");return; }
                    bool sp = false;
                    if (!string.IsNullOrEmpty(rv["是否审核"].ToString()))
                        sp = bool.Parse(rv["是否审核"].ToString());
                    
                    if (sp)
                    {
                        UserMessages.ShowInfoBox("收款信息已审批,不能修改!");
                        return;
                    }
                    if (paymentType == "常规收款")
                    {
                        FrmPaymentGeneralEdit frmGeneralEdit = new FrmPaymentGeneralEdit(paymentID);
                        frmGeneralEdit.ShowDialog();
                    }
                    else
                    {
                        FrmPayMentRegEdit frmRegEdit = new FrmPayMentRegEdit(paymentID);
                        frmRegEdit.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }
        }

        private void FrmPaymentManager_Load(object sender, EventArgs e)
        {
            dstTCONF_WORD.FillDevComboBox("支付方式", 支付方式ComboBoxEdit);
            proceedsDataSet.DBHelper.WangDaSer.UpdateUserID();

            if (DateTime.Today.Day >= 15)
            {
                支付日期DateEdit.DateTime = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
                支付日期DateEdit1.DateTime = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month));
            }
            else
            {
                var ldate = DateTime.Today.AddMonths(-1);
                支付日期DateEdit.DateTime = new DateTime(ldate.Year, ldate.Month, 1);
                支付日期DateEdit1.DateTime = DateTime.Today;
            }
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try {
                if (MessageBox.Show("确定要删除当前收款项目么？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    DataRowView rv = TW_PaymentMainBindingSource.Current as DataRowView;
                    if (rv != null)
                    {
                        string paymentID = rv["批次号"].ToString();
                        string paymentType = rv["收款类别"].ToString();
                        string creater = rv["收款人"].ToString();
                        if (Security.UserBusiness.Contains("总经理") || Security.UserBusiness.Contains("注册主管")
                             || Security.UserName=="admin")
                        {
                            
                        }
                        else
                             if (creater != Security.UserName) { UserMessages.ShowInfoBox("操作人本人可以进行删除!"); return; }

                        bool sp = false;
                        if (!string.IsNullOrEmpty(rv["是否审核"].ToString()))
                            sp = bool.Parse(rv["是否审核"].ToString());

                        if (sp)
                        {
                            UserMessages.ShowInfoBox("收款信息已审批,不能删除!");
                            return;
                        }
                        //删除收款明细和主表记录
                        proceedsDataSet.TW_PaymentDetail.Clear();
                        rv.Delete();
                        
                        proceedsDataSet.DelByPCH(paymentID);

                        proceedsDataSet.TW_PaymentMain.AcceptChanges();
                        //删除收款三张表数据
                                              
                    }

                }
            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }
            finally {
                this.Cursor = Cursors.Default;
            }
        }

        private void FrmPaymentManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            proceedsDataSet.DBHelper.WangDaSer.UpdateUserID();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                FrmPaymentGeneralX frmDlg = new FrmPaymentGeneralX();
                frmDlg.StartPosition = FormStartPosition.CenterScreen;
                if (frmDlg.ShowDialog() == DialogResult.OK)
                {
                    proceedsDataSet.TW_Payment.ImportRow(frmDlg.paymentRow);
                    proceedsDataSet.TW_Payment.AcceptChanges();
                    UserMessages.ShowInfoBox("完成收款!");
                }
            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }
        }



        private void btnDelPL_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                if (MessageBox.Show("确定要删除当前收款项目么？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    DataRowView rv = TW_PaymentMainBindingSource.Current as DataRowView;
                    if (rv != null)
                    {
                        string creater = rv["操作人"].ToString();
                        if (creater != Security.UserName) { UserMessages.ShowInfoBox("操作人本人可以进行删除!"); return; }
                        bool sp = false;
                        if (!string.IsNullOrEmpty(rv["是否审核"].ToString()))
                            sp = bool.Parse(rv["是否审核"].ToString());

                        if (sp)
                        {
                            UserMessages.ShowInfoBox("收款信息已审批,不能删除!");
                            return;
                        }
                        string pch = rv["批次号"].ToString();
                        proceedsDataSet.DelByPCH(pch);
                        btnQuery_Click(sender, e);
                        //proceedsDataSet.GetPaymentMainRow(pch);
                        //proceedsDataSet.DeletePaymentByPCH(pch);


                        //proceedsDataSet.SaveDataSet();
                    }

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
        /// 合同收款
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnContractPay_Click(object sender, EventArgs e)
        {
            try
            {
                FrmSelectContractDlg frmSelectContractDlg = new FrmSelectContractDlg();
                frmSelectContractDlg.StartPosition = FormStartPosition.CenterScreen;
                if (frmSelectContractDlg.ShowDialog() == DialogResult.OK)
                {
                  
                    btnQuery_Click(sender, e);
                }

              
            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }
        }


        /// <summary>
        /// 查询付款明细子记录
        /// </summary>
        private void GetPaymentDetail()
        {
            DataRowView rv = TW_PaymentMainBindingSource.Current as DataRowView;
            if (rv != null)
            {
                //if (rv != null && (rv["收款类别"].ToString() == "注册收款" || rv["收款类别"].ToString() == "成长版收款" ||
                //     rv["收款类别"].ToString() == "其他一次性收款"))
                //{
                string paymentID = rv["tw_PaymentID"].ToString();
                proceedsDataSet.GetPaymentDetailID(paymentID);
                //}
                //else
                //{
                //  proceedsDataSet.TW_PaymentDetail.Clear();
                string paymentid = rv["TW_PaymentID"].ToString();//批次号
                proceedsDataSet.GetPaymentByPch(paymentid);

                //}
            }

        }

        private void TW_PaymentMainBindingSource_PositionChanged(object sender, EventArgs e)
        {
            try
            {
                if (isQuery)
                {
                    GetPaymentDetail();
                }

            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }
        }
        /// <summary>
        /// 查询这个单位的详细信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 支付单位HyperLinkEdit_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (tW_PaymentMainGridView.FocusedRowHandle < 0) return;
                DataRow dr = tW_PaymentMainGridView.GetDataRow(tW_PaymentMainGridView.FocusedRowHandle);
                if (dr == null) return;
                string clientName = dr["支付单位"].ToString();
                string clientId = dr["客户名称ID"].ToString();
                FrmClientView frmClientView = new FrmClientView();
                frmClientView.ClientName = clientName;
                frmClientView.ClientId = clientId;
                frmClientView.Text = clientName;
                frmClientView.ShowDialog();
            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }
            finally
            {
            }
        }
        /// <summary>
        /// 根据合同编号查询合同详细信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 合同编号HyperLinkEdit_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (tW_PaymentMainGridView.FocusedRowHandle < 0) return;
                DataRow dr = tW_PaymentMainGridView.GetDataRow(tW_PaymentMainGridView.FocusedRowHandle);
                if (dr == null) return;
                // string contractId = dr["ContractID"].ToString();
                string contractNo = dr["合同编号"].ToString();
                //根据不同的合同审批状态：未提交，待审批，已审批，打开对应的合同页面
                FrmContractEdit frmContractEdit = new FrmContractEdit();
                frmContractEdit.FormStatus = PageStatus.View;
                //frmContractEdit.ContractId = contractId;
                frmContractEdit.ContractNo = contractNo;

                frmContractEdit.ShowDialog();


            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }
            finally
            {
            }
        }

        /// <summary>
        /// 查看收款信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 查看HyperLinkEdit_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                DataRowView rv = TW_PaymentMainBindingSource.Current as DataRowView;
                if (rv != null)
                {
                    string paymentID = rv["批次号"].ToString();
                    string paymentType = rv["收款类别"].ToString();
                    string contractNo = rv["合同编号"].ToString();
                    if (!string.IsNullOrEmpty(contractNo))
                    {
                        FrmPaymentView frmPaymentView = new FrmPaymentView(paymentID);
                        frmPaymentView.ShowDialog();
                    }
                    else
                    if (paymentType == "常规收款")
                    {
                        FrmPaymentGeneralView frmGeneralView = new FrmPaymentGeneralView(paymentID);
                        frmGeneralView.ShowDialog();
                    }
                    else
                    {
                        FrmPayMentRegView frmRegView = new FrmPayMentRegView(paymentID);
                        frmRegView.ShowDialog();
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
