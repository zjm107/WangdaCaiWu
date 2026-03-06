using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tiger.Tools;
using WangDaDll.Contract;

namespace WangDaDll
{
    public partial class FrmContractReceivablesPeriodAccountant : DevExpress.XtraEditors.XtraForm
    {
        public FrmContractReceivablesPeriodAccountant()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 根据查询条件查询合同收款信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuery_Click(object sender, EventArgs e)
        {
            string clientName = 客户名称TextEdit.Text.Trim();
            string signDate1 = "";
            string signDate2 = "";
            string receiptDate1 = "";
            string receiptDate2 = "";
            string accountant = 做账会计textEdit.Text.Trim();
            if (!string.IsNullOrEmpty(签约日期DateEdit1.Text))
            {
                //将日期转换为字符串格式yyyy-MM-dd
                signDate1 = Convert.ToDateTime(签约日期DateEdit1.Text).ToString("yyyy-MM-dd");

            }
            if (!string.IsNullOrEmpty(签约日期DateEdit2.Text))
            {
                signDate2 = Convert.ToDateTime(签约日期DateEdit2.Text).ToString("yyyy-MM-dd");
            }
            if (!string.IsNullOrEmpty(收款日期DateEdit1.Text))
            {
                receiptDate1 = Convert.ToDateTime(收款日期DateEdit1.Text).ToString("yyyy-MM-dd");

            }
            if (!string.IsNullOrEmpty(收款日期DateEdit2.Text))
            {
                receiptDate2 = Convert.ToDateTime(收款日期DateEdit2.Text).ToString("yyyy-MM-dd");
            }
            
            contractDataSet.GetContractReceivablesPeriod(clientName, accountant, signDate1, signDate2, receiptDate1, receiptDate2); 



        }
        /// <summary>
        /// 清除查询条件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            客户名称TextEdit.Text = "";
            签约日期DateEdit1.Text = "";
            签约日期DateEdit2.Text = "";
            收款日期DateEdit1.Text = "";
            收款日期DateEdit2.Text = "";
            contractDataSet.vw_ContractReceivablesPeriod.Clear();
        }
        /// <summary>
        /// 选择用户信息
        /// </summary>
        FrmClientSelectDlg frmclientDlg = new FrmClientSelectDlg();
        /// <summary>
        /// 选择用户
        /// </summary>
        FrmUserSelectDlg frmUserDlg = new FrmUserSelectDlg();


        private void FrmContractReceivablesPeriodAccountant_Load(object sender, EventArgs e)
        {
            if (Security.UserBusiness.Contains("总经理") || Security.UserBusiness.Contains("注册主管") || Security.UserName.ToLower() == "admin")
            {
            }
            else
            {
                做账会计textEdit.Text = Security.UserName;
                做账会计textEdit.Enabled = false;
            }
        }

        private void 做账会计textEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (frmUserDlg.ShowDialog() == DialogResult.OK)
            {
                DataRowView rv = frmUserDlg.SelectRow;
                做账会计textEdit.Text = rv["UserName"].ToString();

            }
        }

        private void 客户名称TextEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
                
            if (frmclientDlg.ShowDialog() == DialogResult.OK)
            {
                var dst = frmclientDlg.selCsDataSet;
                var row = dst.TW_Client.Rows[0];

                客户名称TextEdit.Text = row["客户名称"].ToString();
            }
        }
        /// <summary>
        /// 单击合同编号，打开合同详细信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 合同编号HyperLinkEdit_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (gridView1.FocusedRowHandle < 0) return;
                DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                if (dr == null) return;
                //string contractId = dr["ContractID"].ToString();
                string contractNo = dr["合同编号"].ToString();
                //根据不同的合同审批状态：未提交，待审批，已审批，打开对应的合同页面
                FrmContractEdit frmContractEdit = new FrmContractEdit();
                frmContractEdit.FormStatus = PageStatus.View;
                frmContractEdit.ContractId = "";
                frmContractEdit.ContractNo = contractNo;
                frmContractEdit.Text = "合同编号：" + contractNo;
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
        /// 单机客户名称，打开客户详细信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 客户名称HyperLinkEdit_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (gridView1.FocusedRowHandle < 0) return;
                DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                if (dr == null) return;
                string clientName = dr["客户名称"].ToString();
                FrmClientView frmClientView = new FrmClientView();
                frmClientView.ClientName = clientName;
                frmClientView.ClientId = "";
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
    }
}