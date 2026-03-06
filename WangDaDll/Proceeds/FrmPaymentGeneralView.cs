using System;
using Tiger.Tools;

namespace WangDaDll
{
    public partial class FrmPaymentGeneralView : DevExpress.XtraEditors.XtraForm
    {
        public FrmPaymentGeneralView(string paymentID)
        {
            InitializeComponent();
            PaymentID = paymentID;
         
            proceedsDataSet.GetPaymentMainById(paymentID);

        }
        /// <summary>
        /// 付款ID
        /// </summary>
        public string PaymentID
        {
            get;set;
        }
        
      
        
      
      

        private void FrmPaymentGeneral_Load(object sender, EventArgs e)
        {
            try {
             

            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }
        }
        
      
    }
}
