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
    public partial class FrmPaymentManagerSP : DevExpress.XtraEditors.XtraForm
    {
        public FrmPaymentManagerSP()
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
                //支付日期
                string bcDate1 = "";
                if (!string.IsNullOrEmpty(zfdqdateEdit1.Text))
                {
                    bcDate1 = ((DateTime)zfdqdateEdit1.EditValue).ToShortDateString();
                }
                string bcDate2 = "";
                if (!string.IsNullOrEmpty(zfdqdateEdit2.Text))
                {
                    bcDate2 = ((DateTime)zfdqdateEdit2.EditValue).ToShortDateString();
                }
                //初始做账时间
                string cszzDate1 = "";
                if (!string.IsNullOrEmpty(cszzdateEdit1.Text))
                {
                    cszzDate1 = ((DateTime)cszzdateEdit1.EditValue).ToShortDateString();
                }
                string cszzDate2 = "";
                if (!string.IsNullOrEmpty(cszzdateEdit2.Text))
                {
                    cszzDate2 = ((DateTime)cszzdateEdit2.EditValue).ToShortDateString();
                }

                proceedsDataSet.GetPaymentByInfoSP(是否审批comboBoxEdit.Text, 支付单位TextEdit.Text, "", 支付日期DateEdit.Text
                    , 支付日期DateEdit1.Text, 收款类别ComboBoxEdit.Text
                    , paymentEndDate,comboBoxEditBSK.Text,comboBoxEditLSB.Text
                    ,cszzDate1,cszzDate2,bcDate1,bcDate2);
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

        private void btnSP_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try {
                int[] rowIndexs = gridView1.GetSelectedRows();
                if (rowIndexs.Length > 0)
                {
                    splash.ShowWaitForm();
                    splash.SetWaitFormCaption("审批中");
                    splash.SetWaitFormDescription("正在审批……");
                    foreach (int i in rowIndexs)
                    {
                        DataRowView rv= gridView1.GetRow(i) as DataRowView;
                        rv.BeginEdit();
                        rv["审核人"] = Security.UserName;
                        rv["审核时间"] = DateTime.Now;
                        rv["是否审核"] = true;
                        rv.EndEdit();

                    }
                    proceedsDataSet.SaveDataSet();
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

        private void btnView_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
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
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("确定要删除当前收款项目么？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    DataRowView rv = tW_PaymentBindingSource.Current as DataRowView;
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

        private void btnCX_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                int[] rowIndexs = gridView1.GetSelectedRows();
                if (rowIndexs.Length > 0)
                {
                    splash.ShowWaitForm();
                    splash.SetWaitFormCaption("撤销中");
                    splash.SetWaitFormDescription("正在撤销……");
                    foreach (int i in rowIndexs)
                    {
                        DataRowView rv = gridView1.GetRow(i) as DataRowView;
                        rv.BeginEdit();
                        rv["审核人"] = Security.UserName;
                        rv["审核时间"] = DateTime.Now;
                        rv["是否审核"] = false;
                        rv.EndEdit();

                    }
                    proceedsDataSet.SaveDataSet();
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
    }
}
