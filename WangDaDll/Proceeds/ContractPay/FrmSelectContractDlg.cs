using DevExpress.XtraEditors;
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
using WangDaDll.Contract;

namespace WangDaDll
{
    public partial class FrmSelectContractDlg : DevExpress.XtraEditors.XtraForm
    {
        public FrmSelectContractDlg()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            客户名称textEdit.Text = "";
            注册员buttonEdit.Text = "";
            做账会计buttonEdit.Text = "";
            签约日期dateEdit1.Text = "";
            签约日期dateEdit2.Text = "";
            contractDataSet.vw_ContractReceivablesAccounting.Clear();
        }
        FrmUserSelectDlg frmUserDlg = new FrmUserSelectDlg();


        private void 做账会计buttonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                frmUserDlg.DeptName = "做账部";
                if (frmUserDlg.ShowDialog() == DialogResult.OK)
                {
                    DataRowView rv = frmUserDlg.SelectRow;
                    做账会计buttonEdit.Text = rv["UserName"].ToString();

                }
            }
            catch (Exception ex)
            {
                UserMessages.ShowInfoBox(ex.Message);
            }
        }

        private void 注册员buttonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                frmUserDlg.DeptName = "注册部";
                if (frmUserDlg.ShowDialog() == DialogResult.OK)
                {
                    DataRowView rv = frmUserDlg.SelectRow;
                    注册员buttonEdit.Text = rv["UserName"].ToString();

                }
            }
            catch (Exception ex)
            {
                UserMessages.ShowInfoBox(ex.Message);
            }
        }

        private void FrmSelectContractDlg_Load(object sender, EventArgs e)
        {
            //默认一个月
            签约日期dateEdit2.DateTime = DateTime.Now.AddDays(1);
            var enddate = DateTime.Now.AddMonths(-1);
            签约日期dateEdit1.DateTime = new DateTime(enddate.Year, enddate.Month, 1);
        }
        /// <summary>
        /// 查看合同详细信息
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
        /// 查看客户详细信息
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
                string clientId ="";
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

        private void btnQuery_Click(object sender, EventArgs e)
        {
            string clientName = 客户名称textEdit.Text.Trim();
            string signDate1 = "";
            string signDate2 = "";
            string accountant = "";
            if (Security.UserBusiness.Contains("总经理") || Security.UserBusiness.Contains("注册主管") || Security.UserName.ToLower() == "admin")
            {
                accountant = 做账会计buttonEdit.Text.Trim();
            }
            else
            {
                 //如果不是管理员或注册主管，只能查询自己的合同
                accountant = Security.UserName;
                做账会计buttonEdit.Text = accountant;
            }

            if (!string.IsNullOrEmpty(签约日期dateEdit1.Text))
            {
                //将日期转换为字符串格式yyyy-MM-dd
                signDate1 = Convert.ToDateTime(签约日期dateEdit1.Text).ToString("yyyy-MM-dd");

            }

            if (!string.IsNullOrEmpty(签约日期dateEdit2.Text))
            {
                signDate2 = Convert.ToDateTime(签约日期dateEdit2.Text).ToString("yyyy-MM-dd");
            }



            //查询应收款
            contractDataSet.GetContractReceivables(clientName, accountant, signDate1, signDate2);
            gridView1.BestFitColumns();

        }
        /// <summary>
        /// 选中的合同ID
        /// </summary>
        public string ContractId = "";
        /// <summary>
        /// 合同编号
        /// </summary>
        public string ContractNO = "";
        /// <summary>
        /// 合同记录
        /// </summary>
        public Contract.ContractDataSet.TW_ContractRow ContractRow = null;
        /// <summary>
        /// 合同服务明细
        /// </summary>
        public Contract.ContractDataSet.TW_ContractServiceInfoDataTable TW_ContractServiceInfo = null;
        /// <summary>
        /// 合同付款页面
        /// </summary>
        public FrmPaymentAll frmPaymentAll ;

        private void btnOK_Click(object sender, EventArgs e)
        {
            
            //获取选中的合同ID
            if (gridView1.FocusedRowHandle < 0)
            {
                MessageBox.Show("请选择合同,进行收款操作！");
                return;
            }
           

            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr == null) return;
         //   this.ContractId = dr["ContractID"].ToString();
            this.ContractNO = dr["合同编号"].ToString();
            //获取最后收款时间，已收款额
            decimal hadPayAmount = 0.0m;
            string lastPayDate = "";
            if ( !string.IsNullOrEmpty(dr["已收款金额"].ToString()))
            {
                lastPayDate = dr["最后收款日期"].ToString();
                hadPayAmount = decimal.Parse(dr["已收款金额"].ToString());
            }
           
            
            contractDataSet.GetContractByNo(ContractNO);
            ContractRow = contractDataSet.TW_Contract.Rows[0] as Contract.ContractDataSet.TW_ContractRow;
            if (ContractRow == null)
            {
                MessageBox.Show("选择的合同无效,请重新选择合同！");
                return;
            }

            string accountant = ContractRow["做账会计ID"].ToString();
            string registrar = ContractRow["注册员ID"].ToString();
            //string showinfo= string.Format("您选择的合同编号:{0}\r\n客户名称:{1}\r\n请确认是否进行收款操作？", ContractRow.合同编号, ContractRow.客户名称);
            ////对话框提示用户要对选择的合同进行收款操作
            //if (MessageBox.Show(showinfo, "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
            //{
            //    return;
            //}
            //contractDataSet.GetContractByID(ContractId);
            
            TW_ContractServiceInfo = contractDataSet.TW_ContractServiceInfo;
            frmPaymentAll= new FrmPaymentAll();
            //赋值合同信息
            frmPaymentAll.cRow = ContractRow;
            //赋值合同服务明细
            frmPaymentAll.sTable = TW_ContractServiceInfo;
            frmPaymentAll.payRow = dr as Contract.ContractDataSet.vw_ContractReceivablesAccountingRow;
            bool edit= false;
            //判断行是一次性服务，需要有注册员，是周期性服务，需要有做账会计
            foreach (DataRow row in TW_ContractServiceInfo.Rows)
            {
                string serviceType = row["服务类别"].ToString();
                if (serviceType=="周期性服务" && string.IsNullOrEmpty(accountant))
                {
                    edit = true;
                }
                if (serviceType == "一次性服务" && string.IsNullOrEmpty(registrar))
                {
                    edit= true;
                }
            }
            if (edit)
            {
                FrmContractEditPp frmContractEditPp = new FrmContractEditPp();
                frmContractEditPp.ContractId = ContractRow.ContractID;
                if (frmContractEditPp.ShowDialog() != DialogResult.OK)
                {
                    MessageBox.Show("做账会计或注册员没有填写！");
                    return;
                }
                else
                {
                    if (!string.IsNullOrEmpty( frmContractEditPp.Accountant))
                    {
                        frmPaymentAll.cRow["做账会计"] = frmContractEditPp.Accountant;
                        frmPaymentAll.cRow["做账会计ID"] = frmContractEditPp.AccountantId;

                    }
                    if (!string.IsNullOrEmpty(frmContractEditPp.Registrar))
                    {
                        frmPaymentAll.cRow["注册员"] = frmContractEditPp.Registrar;
                        frmPaymentAll.cRow["注册员ID"] = frmContractEditPp.RegistrarId;
                    }
                    frmPaymentAll.cRow.AcceptChanges();

                }
            }
            

            if (frmPaymentAll.ShowDialog()== DialogResult.OK)
            {
                //如果付款成功，关闭当前窗口
                
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                //如果付款取消，继续停留在当前窗口
                return;
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        

    }
}