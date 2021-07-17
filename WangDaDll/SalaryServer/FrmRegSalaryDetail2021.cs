using System;
using Tiger.Tools;

namespace WangDaDll
{
    public partial class FrmRegSalaryDetail2021 : DevExpress.XtraEditors.XtraForm
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="salaryType">本年工资,上年工资</param>
        public FrmRegSalaryDetail2021(int year, int month, string userID)
        {
            InitializeComponent();

            this.Year = year;
            this.Month = month;
            this.UserID = userID;
        }

        /// <summary>
        /// 年
        /// </summary>
        public int Year
        {
            get; set;
        }

        /// <summary>
        /// 用户ID
        /// </summary>
        public string UserID
        {
            get; set;
        }

        public int Month
        {
            get; set;
        }

        private void FrmRegSalaryDetail2021_Load(object sender, EventArgs e)
        {
            try
            {
                salaryDataSet.GetRegSumDetail(Year, Month, UserID);
                salaryDataSetYW.GetBusinessSum(UserID, Year, Month);
            }
            catch (Exception ex)
            {
                UserMessages.ShowInfoBox(ex.Message);
            }
        }
    }
}