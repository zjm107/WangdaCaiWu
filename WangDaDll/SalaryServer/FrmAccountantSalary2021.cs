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
    public partial class  FrmAccountantSalary2021: DevExpress.XtraEditors.XtraForm
    {
        public FrmAccountantSalary2021()
        {
            InitializeComponent();
        }

        private void FrmAccountantSalary2021_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                yearSpinEdit.EditValue = DateTime.Today.AddMonths(-1).Year;
                monthComboBoxEdit.Text = DateTime.Today.AddMonths(-1).Month.ToString();
                WindDataManager.RestoreGridViewLayout(vW_AllAccountantSalaryGridview, this.Name);
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
                int year = int.Parse(yearSpinEdit.Text);
                int month = int.Parse(monthComboBoxEdit.Text);
                if (Security.UserBusiness.Contains("总经理") || Security.UserBusiness.Contains("主管"))
                {
                    salaryDataSet.GetAccountantSum(year, month, "","");
                    salaryDataSetYW.GetAllBusinessSumOther2021(year, month, "", "","");
                    foreach (DataRow row in salaryDataSetYW.VW_AllBusinessSalary.Rows)
                    {
                        string userName = row["员工"].ToString();
                        decimal sumPrice = decimal.Parse(row["做账提成"].ToString());
                        decimal zcdsumPrice = decimal.Parse(row["注册提成"].ToString());
                        decimal czb = decimal.Parse(row["成长版"].ToString());
                        decimal czbtc = decimal.Parse(row["成长版提成"].ToString());
                        decimal ycx = decimal.Parse(row["其他一次性业务"].ToString());
                        decimal ycxtc = decimal.Parse(row["其他一次性业务提成"].ToString());
                        decimal jx = 0;
                        DataRow[] selRows = salaryDataSet.VW_AllAccountantSalary.Select(string.Format("员工='{0}'", userName));
                        foreach (DataRow selRow in selRows)
                        {
                            selRow.BeginEdit();
                            selRow["业务提成"] = sumPrice + zcdsumPrice;
                            selRow["成长版"] = czb;
                            selRow["成长版提成"] = czbtc;
                            selRow["其他一次性业务"] = ycx;
                            selRow["其他一次性业务提成"] = ycxtc;
                            selRow["绩效"] = jx;
                            selRow.EndEdit();
                            selRow.AcceptChanges();
                        }
                    }
                }
                else if (Security.UserBusiness.Contains("二级部门经理"))
                    {
                        salaryDataSet.GetAccountantSum(year, month, "", Security.DeptID);
                        salaryDataSetYW.GetAllBusinessSumOther2021(year, month, "", "",Security.DeptID);
                        foreach (DataRow row in salaryDataSetYW.VW_AllBusinessSalary.Rows)
                        {
                            string userName = row["员工"].ToString();
                            decimal sumPrice = decimal.Parse(row["做账提成"].ToString());
                            decimal zcdsumPrice = decimal.Parse(row["注册提成"].ToString());
                            decimal czb = decimal.Parse(row["成长版"].ToString());
                            decimal czbtc = decimal.Parse(row["成长版提成"].ToString());
                            decimal ycx = decimal.Parse(row["其他一次性业务"].ToString());
                            decimal ycxtc = decimal.Parse(row["其他一次性业务提成"].ToString());
                            decimal jx = 0;
                            DataRow[] selRows = salaryDataSet.VW_AllAccountantSalary.Select(string.Format("员工='{0}'", userName));
                            foreach (DataRow selRow in selRows)
                            {
                                selRow.BeginEdit();
                                selRow["业务提成"] = sumPrice + zcdsumPrice;
                                selRow["成长版"] = czb;
                                selRow["成长版提成"] = czbtc;
                                selRow["其他一次性业务"] = ycx;
                                selRow["其他一次性业务提成"] = ycxtc;
                                selRow["绩效"] = jx;
                                selRow.EndEdit();
                                selRow.AcceptChanges();
                            }
                        }
                    }
                    else
                {
                    salaryDataSet.GetAccountantSum(year, month, Security.UserName,"");
                    salaryDataSetYW.GetAllBusinessSumOther2021(year, month,Security.UserID, Security.UserName,"");
                    DataRow arow  = salaryDataSetYW.VW_AllBusinessSalary.Rows[0];

                 
                    decimal sumPrice = decimal.Parse(arow["做账提成"].ToString());
                    decimal zcdsumPrice = decimal.Parse(arow["注册提成"].ToString());
                    decimal czb = decimal.Parse(arow["成长版"].ToString());
                    decimal czbtc = decimal.Parse(arow["成长版提成"].ToString());
                    decimal ycx = decimal.Parse(arow["其他一次性业务"].ToString());
                    decimal ycxtc = decimal.Parse(arow["其他一次性业务提成"].ToString());
                    decimal jx = 0;
                    if (sumPrice > 0 && salaryDataSet.VW_AllAccountantSalary.Rows.Count > 0)
                    {
                        DataRow row = salaryDataSet.VW_AllAccountantSalary.Rows[0];
                        row.BeginEdit();
                        row["业务提成"] = sumPrice+zcdsumPrice;
                        row["成长版"] = czb;
                        row["成长版提成"] = czbtc;
                        row["其他一次性业务"] = ycx;
                        row["其他一次性业务提成"] = ycxtc;
                        row["绩效"] = jx;
                        row.EndEdit();
                        row.AcceptChanges();
                    }
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            yearSpinEdit.EditValue = DateTime.Today.AddMonths(-1).Year;
            monthComboBoxEdit.Text = DateTime.Today.AddMonths(-1).Month.ToString();
            accountantBtn.Text = "";
            UserID = "";
            salaryDataSet.VW_AllAccountantSalary.Clear();
        }

        private void btnViewDetail_Click(object sender, EventArgs e)
        {
            vW_AllAccountantSalaryGridControl_DoubleClick(sender, e);
        }

        private void btnSaveLayout_Click(object sender, EventArgs e)
        {
            WindDataManager.SaveGridViewLayout(vW_AllAccountantSalaryGridview, this.Name);
        }
        /// <summary>
        /// 用户ID
        /// </summary>
        public string UserID
        {
            get;set;
        }
        private void accountantBtn_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                FrmUserSelectDlg frmUserDlg = new FrmUserSelectDlg();
                frmUserDlg.DeptName = "业务部";
                if (frmUserDlg.ShowDialog() == DialogResult.OK)
                {
                    DataRowView userRow = frmUserDlg.SelectRow;
                    string userID = userRow["USERID"].ToString();
                    string userName = userRow["USERNAME"].ToString();
                    this.UserID = UserID;
                    accountantBtn.Text = userName;
                }
            }
            catch (Exception ex)
            {
                UserMessages.ShowInfoBox(ex.Message);
            }
        }

        private void vW_AllAccountantSalaryGridControl_DoubleClick(object sender, EventArgs e)
        {
            try {
                int year = int.Parse(yearSpinEdit.Text);
                int month = int.Parse(monthComboBoxEdit.Text);
                DataRowView rv = vW_AllAccountantSalaryBindingSource.Current as DataRowView;
                string userID = rv["员工ID"].ToString();
                FrmAccountantSalaryDetail2021 frmDetailDlg = new FrmAccountantSalaryDetail2021(year, month, userID);
                if (frmDetailDlg.ShowDialog() == DialogResult.OK)
                {

                }
            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }
        }

        private void btnSCYJ_Click(object sender, EventArgs e)
        {

        }
    }
}
