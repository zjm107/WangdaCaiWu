using System;
using System.Windows.Forms;
using Tiger.Tools;

namespace WangDaDll
{
    public partial class FrmAccountantSalaryDetail2022 : DevExpress.XtraEditors.XtraForm
    {
        public FrmAccountantSalaryDetail2022(int year,string userID)
        {
            InitializeComponent();
            this.Year = year;
        
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
                salaryDataSet.GetGongbenDetail(this.Year, this.UserID);
              
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
