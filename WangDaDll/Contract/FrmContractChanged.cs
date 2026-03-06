using System;
using System.Data;
using System.Windows.Forms;
using Tiger.Tools;
using WangDaDll.Common;

namespace WangDaDll
{
    /// <summary>
    /// 处理合同变更的窗体，通常是合同金额的变更，变更记录表TW_ContractChanged，同时修改合同信息表TW_Contract和合同明服务记录表TW_ContractServiceInfo
    /// </summary>
    public partial class FrmContractChanged : DevExpress.XtraEditors.XtraForm
    {
        public FrmContractChanged()
        {
            InitializeComponent();

        }

        private void 做账会计Text_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        private void FrmContractChanged_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {

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
        
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            //判断是否选中了合同记录，如果选中了，打开合同变更记录的窗体 
            if (gridView1.FocusedRowHandle < 0)
            {
                MessageBox.Show("请先选择一条合同记录！");
                return;
            }
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {   FrmContractChangedEdit frm = new FrmContractChangedEdit();
               

            }
        }
        /// <summary>
        /// 查询可以变更的合同信息，比如审批状态是“已审批”，并且合同的结束月份大于等于当前月份的合同
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuery_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 清除查询条件和表格中的数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            
            公司名称Text.Text = "";
            contractDataSet.TW_Contract.Clear();

        }

        private void btnGetChangedRecord_Click(object sender, EventArgs e)
        {

        }
    }
}
