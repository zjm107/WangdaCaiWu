using System;
using System.Data;
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
                csDataSet.GetClientInfo("", "", "", "", "","");
            }
            else
            {
                csDataSet.GetClientInfo("", "", "", "",Security.UserName,"");
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
        /// <summary>
        /// 添加一个新客户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //询问用户要添加一个新客户么?
            if (MessageBox.Show("确认添加一个新客户？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }
            this.Cursor = Cursors.WaitCursor;
            try
            {

                DataRowView newRow = tW_ClientBindingSource.AddNew() as DataRowView;
                newRow["客户名称ID"] = Guid.NewGuid().ToString();
                newRow["修改时间"] = DateTime.Now;
                newRow["修改人"] = Tiger.Tools.Security.UserName;
                newRow["做账会计"]= Tiger.Tools.Security.UserName;
                newRow["做账会计ID"] = Tiger.Tools.Security.UserID;
                tW_ClientBindingSource.EndEdit();
                int position = tW_ClientBindingSource.Find("客户名称ID", newRow["客户名称ID"].ToString());
                tW_ClientBindingSource.Position = position;
                FrmClientEdit frmEdit = new FrmClientEdit();
                frmEdit.csDataSet = this.csDataSet;
                frmEdit.tW_ClientBindingSource.DataSource = this.csDataSet;
                frmEdit.tW_ClientBindingSource.DataMember = "TW_Client";
                frmEdit.tW_ClientBindingSource.Position = position;
                if (frmEdit.ShowDialog() == DialogResult.OK)
                {
                    this.tW_ClientBindingSource.EndEdit();

                    csDataSet.SaveData();
                }

              
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
