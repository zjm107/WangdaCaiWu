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
    public partial class FrmRegBusiness : Form
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="businessRegID">新增的主键</param>
        /// <param name="isNew">是否新增，否是修改</param>
        public FrmRegBusiness(string businessRegID,bool isNew)
        {
            this.TW_BusinessRegID = businessRegID;
            this.IsNew = isNew;
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try {
                tW_BusinessRegBindingSource.EndEdit();

                businessDataSet.DBHelper.BasicSer.SaveTable(businessDataSet, "TW_BusinessReg");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                Tiger.Tools.UserMessages.ShowErrorBox(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        /// <summary>
        /// 是否新增，否则为修改
        /// </summary>
        public bool IsNew {
            get;set;
        }
        /// <summary>
        /// 主键值
        /// </summary>
        public string TW_BusinessRegID
        {
            get;
            set;
        }

        private void FrmRegBusiness_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try {
                if (IsNew)
                {
                    var row  = businessDataSet.TW_BusinessReg.NewTW_BusinessRegRow();
                    row.TW_BusinessRegID = this.TW_BusinessRegID;
                    row.修改人 = Security.UserName;
                    row.修改时间 = DateTime.Now;
                    row.登记日期 = businessDataSet.DBHelper.GetServerDateTime();
                    row.业务员 = Security.UserName;
                    row.业务员ID = Security.UserID;
                    row.部门 = Security.DeptName;
                    businessDataSet.TW_BusinessReg.Rows.Add(row);
                }
                else
                {
                    businessDataSet.GetBusinessRegByID(this.TW_BusinessRegID);
                    tW_BusinessRegBindingSource.MoveFirst();
                }


                dstTCONF_WORD.FillDevComboBox("公司类型", 公司类型ComboBoxEdit);
            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }
            finally {
                this.Cursor = Cursors.Default;
            }
        }

        private void 开始时间DateEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (开始时间DateEdit.Text != null &&  !string.IsNullOrEmpty(开始时间DateEdit.Text) )
            {
                预计注册完成时间DateEdit.EditValue = ((DateTime)开始时间DateEdit.EditValue).AddDays(10);
            }
        }

        private void 图章TextBox_TextChanged(object sender, EventArgs e)
        {
            try {
                decimal tzPrice = 0;
                decimal yhPrice = 0;
                decimal qtPrice = 0;
                decimal cbPrice = 0;
                if (!string.IsNullOrEmpty(图章TextBox.Text))
                {
                    tzPrice = decimal.Parse(图章TextBox.Text);
                }
                if (!string.IsNullOrEmpty(银行TextBox.Text))
                {
                    yhPrice = decimal.Parse(银行TextBox.Text);
                }
                if (!string.IsNullOrEmpty(其他TextBox.Text))
                {
                    qtPrice = decimal.Parse(其他TextBox.Text);
                }
                cbPrice = tzPrice + yhPrice + qtPrice;
                办理成本TextBox.Text = cbPrice.ToString();

                decimal zcPrice = 0;
                if (!string.IsNullOrEmpty(注册费TextBox.Text))
                {
                    zcPrice = decimal.Parse(注册费TextBox.Text);
                }
                decimal lrPrice = zcPrice - cbPrice;
                注册利润TextBox.Text = lrPrice.ToString();

            }
            catch (Exception ex)
            {
                UserMessages.ShowInfoBox(ex.Message);
            }
        }

        private void 月做账费TextBox_TextChanged(object sender, EventArgs e)
        {
            try {
                decimal monthPrice = 0;
                if (!string.IsNullOrEmpty(月做账费TextBox.Text))
                {
                    monthPrice = decimal.Parse(月做账费TextBox.Text);
                }
                decimal yearPrice = monthPrice * 12;
                年做账费TextBox.Text = yearPrice.ToString();

            }
            catch (Exception ex)
            {
                UserMessages.ShowInfoBox(ex.Message);
            }
        }

        private void 注册费TextBox_TextChanged(object sender, EventArgs e)
        {
            try {
                decimal tzPrice = 0;
                decimal yhPrice = 0;
                decimal qtPrice = 0;
                decimal cbPrice = 0;
                if (!string.IsNullOrEmpty(图章TextBox.Text))
                {
                    tzPrice = decimal.Parse(图章TextBox.Text);
                }
                if (!string.IsNullOrEmpty(银行TextBox.Text))
                {
                    yhPrice = decimal.Parse(银行TextBox.Text);
                }
                if (!string.IsNullOrEmpty(其他TextBox.Text))
                {
                    qtPrice = decimal.Parse(其他TextBox.Text);
                }
                cbPrice = tzPrice + yhPrice + qtPrice;
                

                decimal zcPrice = 0;
                if (!string.IsNullOrEmpty(注册费TextBox.Text))
                {
                    zcPrice = decimal.Parse(注册费TextBox.Text);
                }
                decimal lrPrice = zcPrice - cbPrice;
                注册利润TextBox.Text = lrPrice.ToString();
            }
            catch (Exception ex)
            {
                UserMessages.ShowInfoBox(ex.Message);
            }
        }
        FrmUserSelectDlg frmUserDlg = new FrmUserSelectDlg();
        private void 业务员TextEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try {
                frmUserDlg.DeptName = Security.DeptName;
                if (frmUserDlg.ShowDialog() == DialogResult.OK)
                {
                    DataRowView rv = frmUserDlg.SelectRow;
                    业务员TextEdit.Text = rv["UserName"].ToString();
                    DataRowView crv = tW_BusinessRegBindingSource.Current as DataRowView;
                    if (crv != null)
                    {
                        crv["业务员ID"]= rv["UserID"].ToString();
                        crv["部门"] = Security.DeptName;
                    }
                }
            }
            catch (Exception ex)
            {
                UserMessages.ShowInfoBox(ex.Message);
            }
        }

        private void btnYWY_Click(object sender, EventArgs e)
        {
            try {
                业务员TextEdit.Text = "";
                DataRowView crv = tW_BusinessRegBindingSource.Current as DataRowView;
                if (crv != null)
                {
                    crv["业务员ID"] ="";
                    crv["部门"] = "";
                }
            }
            catch (Exception ex)
            {
                UserMessages.ShowInfoBox(ex.Message );
            }
        }

        private void 公司预核名称TextEdit_Leave(object sender, EventArgs e)
        {
            try {
                string companyName = 公司预核名称TextEdit.Text;
                if (!string.IsNullOrEmpty(companyName.Trim()))
                {
                    if (businessDataSet.DBHelper.WangDaSer.CheckCompanyName(companyName))
                    {
                        MessageBox.Show("该公司有过注册信息，确认要继续登记该公司？");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
