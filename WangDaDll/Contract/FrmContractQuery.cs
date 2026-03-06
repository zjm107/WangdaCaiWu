using System;
using System.Data;
using System.Windows.Forms;
using Tiger.PdrCommon;
using Tiger.Tools;
using WangDaDll.Common;
using WangDaDll.Contract;

namespace WangDaDll
{
    public partial class FrmContractQuery : DevExpress.XtraEditors.XtraForm
    {
        public FrmContractQuery()
        {
            InitializeComponent();

        }

       /// <summary>
       /// 根据查询条件查询合同信息
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void btnQuery_Click(object sender, EventArgs e)
        {
           // this.Cursor = Cursors.WaitCursor;
            splash.ShowWaitForm(); 
            try
            {
                // 假设界面有如下控件用于输入查询条件
                string clientName = 公司名称Text.Text.Trim();
                string accountant = 做账会计Text.Text.Trim();
                int endMonth = int.Parse(合同到期月spinEdit.Text);
                string spState = 审批状态comboBoxEdit.Text.Trim();
                string unpaidAmount = 未付款金额comboBoxEdit.Text.Trim();
                if (Security.UserBusiness.Contains("总经理") || Security.UserBusiness.Contains("注册主管") || Security.UserName.ToLower() == "admin")
                {
                    // 调用contractDataSet1的查询方法
                    contractDataSet1.GetContract(clientName, accountant, endMonth, unpaidAmount, spState);
                }
                else
                {
                    // 普通用户只能查询自己的合同
                    contractDataSet1.GetContract(clientName, Security.UserName,  endMonth, unpaidAmount, spState);
                }
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
             //   this.Cursor = Cursors.Default;
            }
        }
        /// <summary>
        /// 清楚界面输入条件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                公司名称Text.Text = "";
                做账会计Text.Text = "";
                合同到期月spinEdit.Text = "";
                审批状态comboBoxEdit.Text = "";
                未付款金额comboBoxEdit.Text = "";
                contractDataSet1.TW_Contract.Clear();

            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }
            finally
            {
              
            }
        }


        private void FrmContract_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                //dstTCONF_WORD.FillDevComboBox("公司性质", 公司性质ComboBoxEdit);
                //dstTCONF_WORD.FillDevComboBox("公司类型", 公司类型ComboBoxEdit);
                //dstTCONF_WORD.FillDevComboBox("客户分级", 客户分级ComboBoxEdit);

                WindDataManager.RestoreGridViewLayout(gridView1, this.Name);

                if (Security.UserBusiness.Contains("总经理") || Security.UserBusiness.Contains("注册主管") || Security.UserName.ToLower() == "admin")
                {
                    做账会计Text.Enabled = true;
                }
                else
                {
                    做账会计Text.Text = Security.UserName;
                    做账会计Text.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }
  

        /// <summary>
        /// 选择用户信息
        /// </summary>
        FrmClientSelectDlg frmclientDlg = new FrmClientSelectDlg();
        /// <summary>
        /// 选择用户
        /// </summary>
        FrmUserSelectDlg frmUserDlg = new FrmUserSelectDlg();


        private void 做账会计Text_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (frmUserDlg.ShowDialog() == DialogResult.OK)
            {
                DataRowView rv = frmUserDlg.SelectRow;
                做账会计Text.Text = rv["UserName"].ToString();
                
            }

        }

        private void 公司名称Text_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (frmclientDlg.ShowDialog() == DialogResult.OK)
            {
                
                var dst = frmclientDlg.selCsDataSet;
                var row = dst.TW_Client.Rows[0];

                公司名称Text.Text = row["客户名称"].ToString();
            }
        }

     

        /// <summary>
        /// 点击客户名称，打开客户信息查看页面
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
                frmClientView.ClientId = dr["客户名称ID"].ToString();
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
        /// 点击合同编号，打开合同查看页面
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
                string contractId = dr["ContractID"].ToString();

                //根据不同的合同审批状态：未提交，待审批，已审批，打开对应的合同页面
                FrmContractEdit frmContractEdit = new FrmContractEdit();
                frmContractEdit.FormStatus = PageStatus.View;
                frmContractEdit.ContractId = contractId;
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
    }
}
