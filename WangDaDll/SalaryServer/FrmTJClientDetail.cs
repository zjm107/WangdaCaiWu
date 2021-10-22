using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WangDaDll.SalaryServer
{
    public partial class FrmTJClientDetail : Form
    {
        public FrmTJClientDetail()
        {
            InitializeComponent();
        }

        private void FrmTJClientDetail_Load(object sender, EventArgs e)
        {
            proceedsDataSet.GetPaymentByClient(clientName, BeginDate, EndDate, ZFBeginDate, ZFEndDate);
        }
        /// <summary>
        /// 客户名称
        /// </summary>
        public string clientName;
        
        /// <summary>
        /// 客户ID
        /// </summary>
        public string clientId;
        /// <summary>
        /// 开始时间
        /// </summary>
        public string BeginDate;
        /// <summary>
        /// 结束时间
        /// </summary>
        public string EndDate;

        /// <summary>
        /// 支付开始时间
        /// </summary>
        public string ZFBeginDate;
        /// <summary>
        /// 支付结束时间
        /// </summary>
        public string ZFEndDate;


    }
}
