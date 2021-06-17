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
    public partial class FrmBusinessSalaryDetail2021 : DevExpress.XtraEditors.XtraForm
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="salaryType">本年工资,上年工资</param>
        public FrmBusinessSalaryDetail2021(string salaryType, int year,int month,string userID)
        {
            InitializeComponent();
            this.SalaryType = salaryType;
            this.Year = year;
            this.Month = month;
            this.UserID = userID;

        }
        /// <summary>
        /// 年
        /// </summary>
        public int Year
        {
            get;set;
        }
        /// <summary>
        /// 工资明细类别
        /// </summary>
        public string SalaryType
        {
            get;set;
        }

        /// <summary>
        /// 用户ID
        /// </summary>
        public string UserID
        {
            get;set;
        }

        public int Month
        {
            get;set;
        }
        private void FrmBusinessSalaryDetail_Load(object sender, EventArgs e)
        {
            try {
                if (SalaryType == "本年工资")
                {
                    salaryDataSet.GetBusinessSum(UserID, Year, Month);
                }
                else if (SalaryType=="上年工资")
                {
                    salaryDataSet.GetBussinessSumByLastYear(Year, UserID);
                }
            }
            catch (Exception ex)
            {
                UserMessages.ShowInfoBox(ex.Message);
            }
        }
    }
}
