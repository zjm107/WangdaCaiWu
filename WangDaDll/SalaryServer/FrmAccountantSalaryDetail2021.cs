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
    public partial class FrmAccountantSalaryDetail2021 : DevExpress.XtraEditors.XtraForm
    {
        public FrmAccountantSalaryDetail2021(int year,int month,string userID)
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
            get;set;
        }
        /// <summary>
        /// 月
        /// </summary>
        public int Month
        { get; set; }
        /// <summary>
        /// 员工ID
        /// </summary>
        public string UserID
        {
            get;set;
        }

        private void FrmAccountantSalaryDetail2021_Load(object sender, EventArgs e)
        {
            splash.ShowWaitForm();
            splash.SetWaitFormCaption("查询");
            splash.SetWaitFormDescription("正在执行查询……");
            try {
                salaryDataSet.GetAccountantSumDetail(this.Year, this.Month, this.UserID);
                salaryDataSetYW.GetBusinessSum(UserID, Year, Month);
            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }
            finally {
                if (splash.IsSplashFormVisible)
                    splash.CloseWaitForm();
            }
        }

        private void btnExp_Click(object sender, EventArgs e)
        {
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
