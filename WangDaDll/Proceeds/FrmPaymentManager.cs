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
    public partial class FrmPaymentManager : DevExpress.XtraEditors.XtraForm
    {
        public FrmPaymentManager()
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
                if (Security.UserName == "秦艳" || Security.UserName == "admin")
                {
                    proceedsDataSet.GetPaymentByInfo(支付单位TextEdit.Text, txtRY.Text, 支付日期DateEdit.Text, 支付日期DateEdit1.Text, 收款类别ComboBoxEdit.Text, paymentEndDate,"",comboBoxEditBSK.Text,comboBoxEditLSB.Text);
                }
                else
                    if (Security.UserBusiness == "注册主管")
                {
                    proceedsDataSet.GetPaymentByInfo(支付单位TextEdit.Text, txtRY.Text, 支付日期DateEdit.Text, 支付日期DateEdit1.Text, 收款类别ComboBoxEdit.Text, paymentEndDate,"注册主管", comboBoxEditBSK.Text, comboBoxEditLSB.Text);
                }
                else
                {
                    proceedsDataSet.GetPaymentByInfo(支付单位TextEdit.Text, Security.UserName, 支付日期DateEdit.Text, 支付日期DateEdit1.Text, 收款类别ComboBoxEdit.Text, paymentEndDate,"", comboBoxEditBSK.Text, comboBoxEditLSB.Text);
                }
                tW_PaymentBindingSource.MoveFirst();
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

        private void GetPaymentDetail()
        {
            DataRowView rv = tW_PaymentBindingSource.Current as DataRowView;
            if (rv != null && (rv["收款类别"].ToString() == "注册收款" || rv["收款类别"].ToString() == "成长版收款" ||
                 rv["收款类别"].ToString() == "其他一次性收款"))
            {
                string paymentID = rv["tw_PaymentID"].ToString();
                proceedsDataSet.GetPaymentDetailID(paymentID);
            }
            else
                proceedsDataSet.TW_PaymentDetail.Clear();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            DataRowView rv = tW_PaymentBindingSource.Current as DataRowView;
            if (rv != null)
            {
                string paymentID = rv["TW_PaymentID"].ToString();
                string paymentType = rv["收款类别"].ToString();
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
                    DataRowView rv = tW_PaymentBindingSource.Current as DataRowView;
                    if (rv != null)
                    {
                        string paymentID = rv["TW_PaymentID"].ToString();
                        string paymentType = rv["收款类别"].ToString();
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
                        rv.Delete();
                        proceedsDataSet.SaveDataSet();
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

        private void btnJJ_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
              
            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }
            finally {
                this.Cursor = Cursors.Default;
            }
        }

        private void btnCF_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
               
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

        private void btnDelPL_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                if (MessageBox.Show("确定要批量删除当前收款项目么？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    DataRowView rv = tW_PaymentBindingSource.Current as DataRowView;
                    if (rv != null)
                    {
                        string paymentID = rv["TW_PaymentID"].ToString();
                        string paymentType = rv["收款类别"].ToString();
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

                        proceedsDataSet.DeletePaymentByPCH(pch);


                        proceedsDataSet.SaveDataSet();
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
    }
}
