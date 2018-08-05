﻿using System;
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
    public partial class FrmRegSalary : DevExpress.XtraEditors.XtraForm
    {
        public FrmRegSalary()
        {
            InitializeComponent();
        }

        private void FrmRegSalary_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
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
                if (Security.UserBusiness.Contains("总经理") || Security.UserBusiness.Contains("主管"))
                {
                    salaryDataSet.GetRegSum(year, month, "");
                    salaryDataSetYW.GetAllBusinessSum(year, month, "","");
                    foreach (DataRow row in salaryDataSetYW.VW_AllBusinessSalary.Rows)
                    {
                        string userName = row["员工"].ToString();
                        decimal sumPrice = decimal.Parse(row["提成汇总"].ToString());
                        DataRow[] selRows = salaryDataSet.VW_AllBusinessSalary.Select(string.Format("员工='{0}'", sumPrice));
                        foreach (DataRow selRow in selRows)
                        {
                            selRow.BeginEdit();
                            selRow["业务提成"] = sumPrice;
                            selRow.EndEdit();
                            selRow.AcceptChanges();
                        }
                    }
                }
                else {
                    salaryDataSet.GetRegSum(year, month, Security.UserName);
                    decimal sumPrice = salaryDataSetYW.GetAllBusinessSumValue(year, month, UserID, Security.UserName);
                    if (sumPrice > 0 && salaryDataSet.VW_AllBusinessSalary.Rows.Count>0)
                    {
                        DataRow row = salaryDataSet.VW_AllBusinessSalary.Rows[0];
                        row.BeginEdit();
                        row["业务提成"] = sumPrice;
                        row.EndEdit();
                        row.AcceptChanges();
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
                UserID = "";
                salaryDataSet.VW_AllBusinessSalary.Clear();
                
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
                FrmRegSalaryDetail frmDetailDlg = new FrmRegSalaryDetail(year,month,userID);
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
           
                vW_AllBusinessSalaryGridControl_DoubleClick(sender, e);

        }

        private void btnSCYJ_Click(object sender, EventArgs e)
        {

        }
    }
}
