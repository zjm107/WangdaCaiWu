using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WangDaDll
{
    public partial class FrmRejected : DevExpress.XtraEditors.XtraForm
    {
        public FrmRejected()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 取消驳回
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        /// <summary>
        /// 驳回意见
        /// </summary>
        public string Rejection
        {
            get;set;

        }

        /// <summary>
        /// 同意驳回
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            Rejection = textRejection.Text;
            this.DialogResult= DialogResult.OK;

        }

        private void FrmRejected_Load(object sender, EventArgs e)
        {
            textRejection.Text = "不同意";
        }
    }
}