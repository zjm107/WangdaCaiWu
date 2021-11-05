using System;
using System.Data;
using System.Windows.Forms;
using Tiger.Tools;

namespace WangDaDll.Proceeds
{
    public partial class FrmJiaojie : Form
    {
        public FrmJiaojie()
        {
            InitializeComponent();
        }


        /// <summary>
        /// 单次交接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDYBG_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(支付单位ButtonEdit.Text))
            {
                UserMessages.ShowInfoBox("请选要交接的客户名称！");
                return;
            }
            if (string.IsNullOrEmpty(txt新会计.Text))
            {
                UserMessages.ShowInfoBox("请选择交接会计！");
                return;
            }

             if (string.IsNullOrEmpty(dateEdit交接起始月份.Text))
            {
                UserMessages.ShowInfoBox("交接起始月份必须填写！");
                return ;
            }
            string clientName = 支付单位ButtonEdit.Text;
            string kuaiji = txt新会计.Text;


            DateTime JiaoJieDate = new DateTime(dateEdit交接起始月份.DateTime.Year, dateEdit交接起始月份.DateTime.Month, 1);
            try
            {
                proceedsDataSet1.JiaoJieOnce(kuaiji, NewKuaijiId, JiaoJieDate.ToString("yyyy-MM-dd"), clientName);

            }
            catch (Exception ex)
            {
                UserMessages.ShowInfoBox(ex.Message);
            }
           
            this.Close();

        }
        /// <summary>
        /// 选择单位
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectUnit_Click(object sender, EventArgs e)
        {
            if (frmclientDlg.ShowDialog() == DialogResult.OK)
            {
                var dst = frmclientDlg.selCsDataSet;
                var row = dst.TW_Client.Rows[0];
                支付单位ButtonEdit.Text = row["客户名称"].ToString();
                ClientId = row["客户名称ID"].ToString();
                
            }
        }
        /// <summary>
        /// 客户Id
        /// </summary>
        public string ClientId{
            get;
            set;
        }
        /// <summary>
        /// 批量交接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPLJJ_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPL原会计.Text))
            {
                UserMessages.ShowInfoBox("请选要交接的原会计！");
                return;
            }
            if (string.IsNullOrEmpty(txtPL交接会计.Text))
            {
                UserMessages.ShowInfoBox("请选择要交接会计！");
                return;
            }

            if (string.IsNullOrEmpty(dateEdit交接批量起始月.Text))
            {
                UserMessages.ShowInfoBox("交接起始月份必须填写！");
                return;
            }

            string newKuaiji = txtPL交接会计.Text;
            DateTime JiaoJieDate = new DateTime(dateEdit交接批量起始月.DateTime.Year, dateEdit交接批量起始月.DateTime.Month, 1);
            try
            {
                proceedsDataSet1.JiaoJieByKuaiji(newKuaiji, NewKuaijiId, JiaoJieDate.ToString("yyyy-MM-dd"), OldKuaijiId);
            }
            catch (Exception ex)
            {
                UserMessages.ShowInfoBox(ex.Message);
            }
            this.Close();
        }
        /// <summary>
        /// 单次交接新会计
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt新会计_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (frmUserDlg.ShowDialog() == DialogResult.OK)
            {
                DataRowView rv = frmUserDlg.SelectRow;
                txt新会计.Text = rv["UserName"].ToString();
                NewKuaijiId = rv["UserID"].ToString();

            }
        }
        /// <summary>
        /// 新会计
        /// </summary>
        public string NewKuaijiId
        {
            get;set;
        }
        
       
        /// <summary>
        /// 选择客户信息
        /// </summary>
        FrmClientSelectDlg frmclientDlg = new FrmClientSelectDlg();
        /// <summary>
        /// 选择用户
        /// </summary>
        FrmUserSelectDlg frmUserDlg = new FrmUserSelectDlg();

        private void FrmJiaojie_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 批量交接新会计
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPL交接会计_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (frmUserDlg.ShowDialog() == DialogResult.OK)
            {
                DataRowView rv = frmUserDlg.SelectRow;
                txtPL交接会计.Text = rv["UserName"].ToString();
                NewKuaijiId = rv["UserID"].ToString();

            }
        }
        /// <summary>
        /// 批量交接原会计
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPL原会计_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (frmUserDlg.ShowDialog() == DialogResult.OK)
            {
                DataRowView rv = frmUserDlg.SelectRow;
                txtPL原会计.Text = rv["UserName"].ToString();
                OldKuaijiId = rv["UserID"].ToString();

            }
        }
        /// <summary>
        /// 原会计
        /// </summary>
        public string OldKuaijiId
        {
            get;set;
        }
    }
}
