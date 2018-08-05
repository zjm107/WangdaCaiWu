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
    public partial class FrmBusinessRegQuery : DevExpress.XtraEditors.XtraForm
    {
        public FrmBusinessRegQuery()
        {
            InitializeComponent();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try {
                if (Security.UserBusiness.Contains("总经理"))
                {
                    businessDataSet.GetBusinessRegData(业务员TextEdit.Text, 登记日期DateEdit.Text, 登记日期DateEdit1.Text
                        , 公司预核名称TextEdit.Text, "", 注册进度ComboBox.Text
                        , 外勤进度ComboBox.Text, "","","","业务登记", FBegindateEdit.Text, FEnddateEdit.Text);
                }
                else
                if (Security.UserBusiness.Contains("主管"))
                {
                    businessDataSet.GetBusinessRegData(业务员TextEdit.Text, 登记日期DateEdit.Text, 登记日期DateEdit1.Text
                        , 公司预核名称TextEdit.Text, "", 注册进度ComboBox.Text
                        , 外勤进度ComboBox.Text,"","","","业务登记", FBegindateEdit.Text, FEnddateEdit.Text);
                }
                else
                {
                    businessDataSet.GetBusinessRegData(Security.UserName, 登记日期DateEdit.Text, 登记日期DateEdit1.Text
                        , 公司预核名称TextEdit.Text, "", 注册进度ComboBox.Text
                        , 外勤进度ComboBox.Text,"","","","业务登记", FBegindateEdit.Text, FEnddateEdit.Text);
                }
            }
            catch (Exception ex)
            {
                UserMessages.ShowInfoBox(ex.Message);
            }
            finally {
                this.Cursor = Cursors.Default;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                业务员TextEdit.Text = "";
                登记日期DateEdit.Text = "";
                登记日期DateEdit1.Text = "";
                公司预核名称TextEdit.Text = "";
               // PaymentcomboBoxEdit.Text = "";
                注册进度ComboBox.Text = ""; 外勤进度ComboBox.Text = "";
                businessDataSet.TW_BusinessReg.Clear();
            }
            catch (Exception ex)
            {
                UserMessages.ShowInfoBox(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                WindDataManager.SaveGridViewLayout(this.gridView1, this.Name);

            }
            catch (Exception ex)
            {
                UserMessages.ShowInfoBox(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void FrmBusinessReg_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                WindDataManager.RestoreGridViewLayout(this.gridView1, this.Name);
                dstTCONF_WORD.FillComBoBox("注册进度", 注册进度ComboBox);
                dstTCONF_WORD.FillComBoBox("外勤进度", 外勤进度ComboBox);
                DataSet dst = dstTCONF_WORD.GetParaItems("外勤进度进出口");
                if (dst.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow row in dst.Tables[0].Rows)
                    {
                        外勤进度ComboBox.Items.Add(row["GROUPLISTITEM"].ToString());
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
            }
        }
    }
}
