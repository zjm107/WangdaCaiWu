using DevExpress.XtraPrinting.Native.Preview;
using System;
using System.Data;
using System.Windows.Forms;
using Tiger.Tools;
using WangDaDll.Common;
using WangDaDll.Contract;

namespace WangDaDll
{
    public partial class FrmPaymentView : DevExpress.XtraEditors.XtraForm
    {
        /// <summary>
        /// 查看收款信息
        /// </summary>
        /// <param name="tW_PaymentID">收款ID</param>
        public FrmPaymentView(string tW_PaymentID)
        {
            InitializeComponent();
            frmUserDlg.DeptName = "做账部";
            
            TW_PaymentID = tW_PaymentID;
        }
        /// <summary>
        /// 付款记录ID
        /// </summary>
        string TW_PaymentID = "";
        /// <summary>
        /// 合同ID
        /// </summary>
        
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
                UserMessages.ShowInfoBox("支付金额必须大于0!");
                return false;
            }
            if(decimal.Parse( 总额TextBox.Text.Trim())<=0)
            {
                UserMessages.ShowInfoBox("支付金额必须大于0!");
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
           
        }
     
        /// <summary>
        /// 当前付款行
        /// </summary>
        public ProceedsDataSet.TW_PaymentMainRow paymentMainRow;
    
     
        /// <summary>
        /// 选择用户
        /// </summary>
        FrmUserSelectDlg frmUserDlg = new FrmUserSelectDlg();

      
        /// <summary>
        /// 收款确定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
           
        }
   

        /// <summary>
        /// 收款取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            
        }
    
        private void FrmPaymentGeneral_Load(object sender, EventArgs e)
        {
           
            try
            {
                一次性服务checkEdit.Checked = false;
                周期性服务checkEdit.Checked = false;
             
                dstTCONF_WORD.FillDevComboBox("支付方式", 支付方式ComboBoxEdit);
                proceedsDataSet.GetCommission();
                proceedsDataSet.GetPaymentMainRow(TW_PaymentID);
                paymentMainRow = proceedsDataSet.TW_PaymentMain.Rows[0] as ProceedsDataSet.TW_PaymentMainRow;
                if (!paymentMainRow.Is周期性服务费Null() && paymentMainRow.周期性服务费>0)
                {
                    周期性服务checkEdit.Checked = true;
                }
                if (!paymentMainRow.Is一次性服务费Null() && paymentMainRow.一次性服务费 > 0)
                {
                    一次性服务checkEdit.Checked = true;
                }


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
