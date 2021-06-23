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
    public partial class FrmBusinessSalary2021 : DevExpress.XtraEditors.XtraForm
    {
        public FrmBusinessSalary2021()
        {
            InitializeComponent();
        }

        private void FrmBusinessSalary_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try {
                YearComboBoxEdit.EditValue = DateTime.Today.AddMonths(-1).Year;
                monthComboBoxEdit.Text = DateTime.Today.AddMonths(-1).Month.ToString();

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

        private void btnQuery_Click(object sender, EventArgs e)
        {
            splash.ShowWaitForm();
            splash.SetWaitFormCaption("查询");
            splash.SetWaitFormDescription("正在查询……");
            this.Cursor = Cursors.WaitCursor;
            try
            {
                salaryDataSet.DBHelper.WangDaSer.UpdateUserID();
                int year = int.Parse(YearComboBoxEdit.Text);
                int month = int.Parse(monthComboBoxEdit.Text);
                if (pageControl1.SelectedTabPageIndex == 0)  //本年业务提成
                {
                    if (Security.UserBusiness.Contains("总经理") || Security.UserBusiness.Contains("主管"))
                    {
                        salaryDataSet.GetAllBusinessSum2021(year, month, UserID, "");
                    }
                    else
                    {
                        salaryDataSet.GetAllBusinessSum2021(year, month, UserID,Security.UserName);
                    }
                }
                else { //上年业务提层
                    salaryDataSet.GetBussinessSumByLastYear(year, UserID);
                    if (Security.UserBusiness.Contains("总经理") || Security.UserBusiness.Contains("主管"))
                    {
                        salaryDataSet.GetBusinessLastYear(year, "");
                    }
                    else {
                        salaryDataSet.GetBusinessLastYear(year, Security.UserName);
                    }
                }


            }
            catch (Exception ex)
            {
                UserMessages.ShowInfoBox(ex.Message);
            }
            finally {
                this.Cursor = Cursors.Default;
                if (splash.IsSplashFormVisible)
                    splash.CloseWaitForm();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try {
                YearComboBoxEdit.Text = DateTime.Today.Year.ToString();
                monthComboBoxEdit.Text = DateTime.Today.AddMonths(-1).Month.ToString();
                btnUserID.Text = "";
                UserID = "";
                salaryDataSet.VW_AllBusinessSalary.Clear();
                salaryDataSet.VW_AllBusinessSalaryYear.Clear();
            }
            catch (Exception ex)
            {
                UserMessages.ShowInfoBox(ex.Message);
            }
        }
        /// <summary>
        /// 选择的用户ID
        /// </summary>
        public string UserID
        {
            get;set;
        }

        private void btnUserID_Click(object sender, EventArgs e)
        {
            try {
                FrmUserSelectDlg frmUserDlg = new FrmUserSelectDlg();
                frmUserDlg.DeptName = "业务部";
                if (frmUserDlg.ShowDialog() == DialogResult.OK)
                {
                    DataRowView userRow = frmUserDlg.SelectRow;
                    string userID = userRow["USERID"].ToString();
                    string userName = userRow["USERNAME"].ToString();
                    this.UserID = UserID;
                    btnUserID.Text = userName;
                }
            }
            catch (Exception ex)
            {
                UserMessages.ShowInfoBox(ex.Message);
            }
        }

        private void vW_AllBusinessSalaryGridControl_DoubleClick(object sender, EventArgs e)
        {
            try {
                int year = int.Parse(YearComboBoxEdit.Text);
                int month = int.Parse(monthComboBoxEdit.Text);
                
                DataRowView rv = vW_AllBusinessSalaryBindingSource.Current as DataRowView;
                string userID = rv["员工ID"].ToString();
                FrmBusinessSalaryDetail2021 frmDetailDlg = new FrmBusinessSalaryDetail2021("本年工资",year,month,userID);
                if (frmDetailDlg.ShowDialog() == DialogResult.OK)
                {
                    
                }
            }
            catch (Exception ex)
            {
                UserMessages.ShowInfoBox(ex.Message);
            }
        }

        private void vW_AllBusinessSalaryYearGridControl_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                int year = int.Parse(YearComboBoxEdit.Text);
                int month = int.Parse(monthComboBoxEdit.Text);
                DataRowView rv = vW_AllBusinessSalaryYearBindingSource.Current as DataRowView;
                string userID = rv["员工ID"].ToString();
                FrmBusinessSalaryDetail frmDetailDlg = new FrmBusinessSalaryDetail("上年工资",year,month,userID);
                if (frmDetailDlg.ShowDialog() == DialogResult.OK)
                {

                }
            }
            catch (Exception ex)
            {
                UserMessages.ShowInfoBox(ex.Message);
            }
        }

        private void btnShowDetail_Click(object sender, EventArgs e)
        {
            if (pageControl1.SelectedTabPageIndex == 0)
            {
                vW_AllBusinessSalaryGridControl_DoubleClick(sender, e);
            }
            else
            {
                vW_AllBusinessSalaryYearGridControl_DoubleClick(sender, e);
            }
        }

        private void btnSCYJ_Click(object sender, EventArgs e)
        {

        }
    }
}
