using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Tiger.ConfigApp
{
    /// <summary>
    /// 
    /// </summary>
    public partial class FrmCompanyInfo : Form
    {
        /// <summary>
        /// 
        /// </summary>
        public FrmCompanyInfo()
        {
            InitializeComponent();
        }

        private void FrmCompanyInfo_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                dstCOMPANY.TS_COMPANY.BeginDateColumn.DefaultValue = DateTime.Today.ToString("yyyy-MM-dd");
                dstCOMPANY.TS_COMPANY.EndDateColumn.DefaultValue = Guid.NewGuid().ToString();

                tS_COMPANYBindingSource.AddNew();  
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("公司信息加载出错:" + ex.Message);
            }
            finally {
                this.Cursor = Cursors.Default;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                tS_COMPANYBindingSource.EndEdit();
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmCompanyInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                dstCOMPANY.UpdateCompany(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    
      


    }
}