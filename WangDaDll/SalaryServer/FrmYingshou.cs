using System;
using System.Windows.Forms;
using Tiger.Tools;

namespace WangDaDll.SalaryServer
{
    public partial class FrmYingshou : Form
    {
        public FrmYingshou()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            beginDatedateEdit.Text = "";
            endDatedateEdit.Text = "";
            fXDataSet.Clear();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            splash.ShowWaitForm();
            splash.SetWaitFormCaption("查询");
            splash.SetWaitFormDescription("正在查询……");
            this.Cursor = Cursors.WaitCursor;
            try
            {
                string beginDate = beginDatedateEdit.Text;
                string endDate = endDatedateEdit.Text;
                string clientName = txtClient.Text;
                
                if (Security.UserBusiness.Contains("总经理") || Security.UserBusiness.Contains("主管")|| Security.UserBusiness.Contains("二级部门经理"))
                {
                    fXDataSet.GetYingShou(beginDate, endDate, clientName, "");
                }
                else
                {
                    fXDataSet.GetYingShou(beginDate, endDate, clientName, Security.UserID);
                }

                  
            }
            catch (Exception ex)
            {
                UserMessages.ShowInfoBox(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
                if (splash.IsSplashFormVisible)
                    splash.CloseWaitForm();
            }
        }

        private void FrmYingshou_Load(object sender, EventArgs e)
        {
            beginDatedateEdit.DateTime = new DateTime(DateTime.Today.Year, 1, 1);
            endDatedateEdit.DateTime = new DateTime(DateTime.Today.Year, 12, 31);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (Security.UserName.ToLower() != "admin")
            {
                MessageBox.Show("没有权限！");
                return;
            }

            if (xlsSaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (xlsSaveFileDialog.FileName != "")
                {
                   
                   gridView1.ExportToXlsx(xlsSaveFileDialog.FileName);
                 
                }
            }
        }
    }
}
