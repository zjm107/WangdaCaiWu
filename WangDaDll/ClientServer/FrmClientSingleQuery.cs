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

namespace WangDaDll
{
    public partial class FrmClientSingleQuery : DevExpress.XtraEditors.XtraForm
    {
        public FrmClientSingleQuery()
        {
            InitializeComponent();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try {
                if (客户名称TextEdit.Text.Trim().Length > 5)
                {
                    csDataSet.GetSingleClient(客户名称TextEdit.Text.Trim());
                }
                else {
                    UserMessages.ShowInfoBox("字数不能少于5个字");
                }

            }
            catch (Exception ex)
            {
                UserMessages.ShowInfoBox(ex.Message);
            }
            finally {
                this.Cursor = Cursors.Default;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                客户名称TextEdit.Text = "";
                csDataSet.TW_Client.Clear();
            }
            catch (Exception ex)
            {
                UserMessages.ShowInfoBox(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
    }
}
