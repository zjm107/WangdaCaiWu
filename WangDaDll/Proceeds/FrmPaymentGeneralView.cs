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
using WangDaDll;
using WangDaDll.Common;

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
