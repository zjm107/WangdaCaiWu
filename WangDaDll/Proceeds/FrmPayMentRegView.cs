using System;
using System.Windows.Forms;
using Tiger.Tools;

namespace WangDaDll
{
    public partial class FrmPayMentRegView : DevExpress.XtraEditors.XtraForm
    {
        public FrmPayMentRegView(string paymentID)
        {
            InitializeComponent();
            this.PaymentID = paymentID;
            proceedsDataSet.GetPaymentById(PaymentID);
        }
        /// <summary>
        /// 付款ID
        /// </summary>
        public string PaymentID {
            get;set;
        }


     

      
       
        private void FrmPayMentReg_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor ;
            try {
               
            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }
            finally {
                this.Cursor = Cursors.Default;
            }
        }

      
     
    }
}
