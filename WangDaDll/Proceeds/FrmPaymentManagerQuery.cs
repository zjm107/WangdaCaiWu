using System;
using System.Data;
using System.Windows.Forms;
using Tiger.Tools;
using WangDaDll.Proceeds;

namespace WangDaDll
{
    public partial class FrmPaymentManagerQuery : DevExpress.XtraEditors.XtraForm
    {
        public FrmPaymentManagerQuery()
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
                    //proceedsDataSet.GetPaymentByInfoSP2025(支付单位TextEdit.Text, txtRY.Text, 支付日期DateEdit.Text, 支付日期DateEdit1.Text, 收款类别ComboBoxEdit.Text, paymentEndDate, "", comboBoxEditBSK.Text, comboBoxEditLSB.Text);
                    proceedsDataSet.GetPaymentByInfoSP2025(是否审批comboBoxEdit.Text, 支付单位TextEdit.Text,关系人textEdit.Text, 支付日期DateEdit.Text, 支付日期DateEdit1.Text, 收款类别ComboBoxEdit.Text, paymentEndDate,"", comboBoxEditBSK.Text, comboBoxEditLSB.Text);
                }
                else
                   if (Security.UserBusiness == "注册主管") //注册主管可以查看注册主管的信息
                {
                    proceedsDataSet.GetPaymentByInfoSP2025(是否审批comboBoxEdit.Text, 支付单位TextEdit.Text, 关系人textEdit.Text, 支付日期DateEdit.Text, 支付日期DateEdit1.Text, 收款类别ComboBoxEdit.Text, paymentEndDate, "注册主管", comboBoxEditBSK.Text, comboBoxEditLSB.Text);
                }
                else
                {
                    //其他会计只能查看自己的信息
                    proceedsDataSet.GetPaymentByInfoSP2025(是否审批comboBoxEdit.Text,支付单位TextEdit.Text, Security.UserName, 支付日期DateEdit.Text, 支付日期DateEdit1.Text, 收款类别ComboBoxEdit.Text, paymentEndDate, "", comboBoxEditBSK.Text, comboBoxEditLSB.Text);
                }
                TW_PaymentMainBindingSource.MoveFirst();
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

        private void btnGeneralPay_Click(object sender, EventArgs e)
        {
            try {
                FrmPaymentGeneral frmDlg = new FrmPaymentGeneral();
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

        private void tW_PaymentBindingSource_PositionChanged(object sender, EventArgs e)
        {
            try {
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

       


        private void btnView_Click(object sender, EventArgs e)
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                DataRowView rv = TW_PaymentBindingSource.Current as DataRowView;
                if (rv != null)
                {
                    string paymentID = rv["TW_PaymentID"].ToString();
                    string paymentType = rv["收款类别"].ToString();
                    if (Security.UserName != "秦艳" && Security.UserName != "高红艳")
                    {
                        
                        bool sp = false;
                        if (!string.IsNullOrEmpty( rv["是否审核"].ToString()))
                            sp = bool.Parse(rv["是否审核"].ToString());
                        if (sp)
                        {
                            UserMessages.ShowInfoBox("收款信息已审批,不能修改!");
                            return;
                        }
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

                    btnQuery_Click( sender,  e);
                }
            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }

        }

        private void FrmPaymentManagerSP_Load(object sender, EventArgs e)
        {
            if (Security.UserName == "秦艳" || Security.UserName == "admin")
            {
                是否审批comboBoxEdit.Enabled = true;
            }
            else
                是否审批comboBoxEdit.Enabled = false;

            proceedsDataSet.DBHelper.WangDaSer.UpdateUserID();
            var ldate = DateTime.Today.AddMonths(-2);
            var adate = DateTime.Today;
            支付日期DateEdit.DateTime = DateTime.Now.AddMonths(-2);
            支付日期DateEdit1.DateTime = DateTime.Now.AddDays(1);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("确定要删除当前收款项目么？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    DataRowView rv = TW_PaymentMainBindingSource.Current as DataRowView;
                    if (rv != null)
                    {
                        string paymentID = rv["TW_PaymentID"].ToString();
                        string paymentType = rv["收款类别"].ToString();
                        string creater = rv["操作人"].ToString();
                        //if (creater != Security.UserName) { UserMessages.ShowInfoBox("操作人本人可以进行删除!"); return; }

                        if (Security.UserName != "秦艳"&& Security.UserName!="高红艳")
                        {
                            bool sp = false;
                            if (!string.IsNullOrEmpty(rv["是否审核"].ToString()))
                                sp = bool.Parse(rv["是否审核"].ToString());

                            if (sp)
                            {
                                UserMessages.ShowInfoBox("收款信息已审批,不能删除!");
                                return;
                            }
                        }
                        rv.Delete();
                        proceedsDataSet.SaveDataSet();

                        btnQuery_Click(sender, e);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 拆分
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCF_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                int[] rowIndexs = tW_PaymentMainGridView.GetSelectedRows();
                if (rowIndexs.Length > 0)
                {
                    splash.ShowWaitForm();
                    splash.SetWaitFormCaption("拆分中");
                    splash.SetWaitFormDescription("正在进行拆分……");
                    foreach (int i in rowIndexs)
                    {
                        DataRowView rv = tW_PaymentMainGridView.GetRow(i) as DataRowView;
                        int monthCount = int.Parse(rv["缴费月数"].ToString());
                        if(monthCount>1)
                        {
                            proceedsDataSet.CFPayments(monthCount, rv.Row);
                        }
                    }
                    foreach (int i in rowIndexs)
                    {
                        DataRowView rv = tW_PaymentMainGridView.GetRow(i) as DataRowView;
                        int monthCount = int.Parse(rv["缴费月数"].ToString());
                        if (monthCount == 0 || monthCount==1)
                        {
                            tW_PaymentMainGridView.UnselectRow(i);
                        }
                    }
                    tW_PaymentMainGridView.DeleteSelectedRows();//删除选中行
                    proceedsDataSet.SaveDataSet(); //保存
                }
            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
                if (splash.IsSplashFormVisible)
                    splash.CloseWaitForm();
            }
        }

        private void btnCFAll_Click(object sender, EventArgs e)
        {
            FrmPaymentManagerCF cf = new FrmPaymentManagerCF();
            cf.Show();
        }


        private void repositoryItemHyperLinkEdit1_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            try
            {
                DataRowView rv = TW_PaymentBindingSource.Current as DataRowView;
                if (rv != null)
                {
                    string paymentID = rv["TW_PaymentID"].ToString();
                    string paymentType = rv["收款类别"].ToString();
                    if (Security.UserName != "秦艳" && Security.UserName != "高红艳")
                    {

                        bool sp = false;
                        if (!string.IsNullOrEmpty(rv["是否审核"].ToString()))
                            sp = bool.Parse(rv["是否审核"].ToString());
                        if (sp)
                        {
                            UserMessages.ShowInfoBox("收款信息已审批,不能修改!");
                            return;
                        }
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

                    btnQuery_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (Security.UserName.ToLower() != "admin")
            {
                MessageBox.Show("没有权限！");
                return;
            }

            if (xlsSaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (xlsSaveFileDialog.FileName != "")
                {

                    tW_PaymentMainGridView.ExportToXlsx(xlsSaveFileDialog.FileName);

                }
            }
        }

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
        /// 根据合同编号查询合同信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 合同编号HyperLinkEdit_DoubleClick(object sender, EventArgs e)
        {

            try
            {
                DataRowView rv = TW_PaymentMainBindingSource.Current as DataRowView;
                if (rv != null)
                {
                    string contractNo = rv["合同编号"].ToString();
                    //根据不同的合同审批状态：未提交，待审批，已审批，打开对应的合同页面
                    FrmContractEdit frmContractEdit = new FrmContractEdit();
                    frmContractEdit.FormStatus = PageStatus.View;
                    //frmContractEdit.ContractId = contractId;
                    frmContractEdit.ContractNo = contractNo;

                    frmContractEdit.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }
        }
    }
}
