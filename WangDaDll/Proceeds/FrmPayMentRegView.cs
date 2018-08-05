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
