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
    public partial class FrmClientEdit : DevExpress.XtraEditors.XtraForm
    {
        public FrmClientEdit()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime endDate = 初始做账时间DateEdit.DateTime.AddMonths(12);
                dateEdit1.DateTime = endDate;
                tW_ClientBindingSource.EndEdit();

            }
            catch (Exception ex)
            {
                MessageBox.Show("错误:" + ex.Message);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();

        }

        private void FrmClientEdit_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try {
                dstTCONF_WORD.FillDevComboBox("公司性质", 公司性质ComboBoxEdit);
                dstTCONF_WORD.FillDevComboBox("公司类型", 公司类型ComboBoxEdit);
                dstTCONF_WORD.FillDevComboBox("客户分级", 客户分级ComboBoxEdit);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally {
                this.Cursor = Cursors.Default;
            }
        }

        private void 做账会计TextEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try {
                FrmUserSelectDlg frmUserDlg = new FrmUserSelectDlg();
                if (frmUserDlg.ShowDialog() == DialogResult.OK)
                {
                    DataRowView rv = frmUserDlg.SelectRow;
                    string userID = rv["USERID"].ToString();
                    string userName = rv["USERNAME"].ToString();
                    DataRowView wRv = tW_ClientBindingSource.Current as DataRowView;
                    wRv.BeginEdit();
                    wRv["做账会计ID"] = userID;
                    wRv["做账会计"] = userName;
                    wRv.EndEdit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void 注册员TextEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                FrmUserSelectDlg frmUserDlg = new FrmUserSelectDlg();
                if (frmUserDlg.ShowDialog() == DialogResult.OK)
                {
                    DataRowView rv = frmUserDlg.SelectRow;
                    string userID = rv["USERID"].ToString();
                    string userName = rv["USERNAME"].ToString();
                    DataRowView wRv = tW_ClientBindingSource.Current as DataRowView;
                    wRv.BeginEdit();
                    wRv["注册员ID"] = userID;
                    wRv["注册员"] = userName;
                    wRv.EndEdit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void 业务员TextEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                FrmUserSelectDlg frmUserDlg = new FrmUserSelectDlg();
                if (frmUserDlg.ShowDialog() == DialogResult.OK)
                {
                    DataRowView rv = frmUserDlg.SelectRow;
                    string userID = rv["USERID"].ToString();
                    string userName = rv["USERNAME"].ToString();
                    DataRowView wRv = tW_ClientBindingSource.Current as DataRowView;
                    wRv.BeginEdit();
                    wRv["业务员ID"] = userID;
                    wRv["业务员"] = userName;
                    wRv.EndEdit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void 初始做账时间DateEdit_EditValueChanged(object sender, EventArgs e)
        {
            try { 
            DateTime endDate = 初始做账时间DateEdit.DateTime.AddMonths(12);
            dateEdit1.DateTime = endDate;
            }catch(Exception ex)
            {
                MessageBox.Show("错误:" + ex.Message);
            }
        }

        private void 做账会计TextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void 做账会计TextEdit_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }
    }
}
