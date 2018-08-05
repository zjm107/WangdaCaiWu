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
using WangDaDll.Common;

namespace WangDaDll
{
    public partial class FrmClientSelectDlg : DevExpress.XtraEditors.XtraForm
        {
        public FrmClientSelectDlg()
        {
            InitializeComponent();

            if (Security.UserBusiness == "总经理" || Security.UserBusiness == "注册主管" || Security.UserName.ToLower()=="admin")
            {
                csDataSet.GetClientInfo("", "", "", "", "");
            }
            else
            {
                csDataSet.GetClientInfo("", "", "", "",Security.UserName);
            }
            
        }
        public CsDataSet selCsDataSet
        {
            set;get;
        }

        private void FrmClientSelectDlg_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                WindDataManager.RestoreGridViewLayout(gridView1, this.Name);
                selCsDataSet = new CsDataSet();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void btnSaveLayout_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                WindDataManager.SaveGridViewLayout(gridView1, this.Name);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try {

                if (gridView1.GetSelectedRows().Length > 0)
                {
                    int[] rowIndexs = gridView1.GetSelectedRows();
                    DataRowView rv = gridView1.GetRow(rowIndexs[0]) as DataRowView;
                    selCsDataSet.TW_Client.Clear();
                    selCsDataSet.TW_Client.ImportRow(rv.Row);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else {
                    UserMessages.ShowInfoBox("请选择单位信息!");
                }
                
            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }
        }
    }
}
