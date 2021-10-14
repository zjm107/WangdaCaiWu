using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tiger.Tools;

namespace WangDaDll.SalaryServer
{
    public partial class FrmTJmmYY : Form
    {
        public FrmTJmmYY()
        {
            InitializeComponent();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            splash.ShowWaitForm();
            splash.SetWaitFormCaption("查询");
            splash.SetWaitFormDescription("正在查询……");
            this.Cursor = Cursors.WaitCursor;
            try
            {
                string zzKSDate = dateEdit1.Text;
                string zzDQDate = dateEdit2.Text;
             
                fXDataSet.GetLRByDate(zzKSDate, zzDQDate);
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
            dateEdit1.Text = "";
            dateEdit2.Text = "";
            fXDataSet.Clear();
        }

        private void FrmTJmmYY_Load(object sender, EventArgs e)
        {
            dateEdit1.DateTime = new DateTime(DateTime.Today.Year, 1, 1);
            dateEdit2.DateTime = new DateTime(DateTime.Today.Year, 12, 31);
        }
    }
}
