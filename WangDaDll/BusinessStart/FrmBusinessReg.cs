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
    public partial class FrmBusinessReg : DevExpress.XtraEditors.XtraForm
    {
        public FrmBusinessReg()
        {
            InitializeComponent();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try {
                if (Security.UserBusiness.Contains("总经理"))
                {
                    businessDataSet.GetBusinessRegDataEdit(业务员TextEdit.Text, 登记日期DateEdit.Text, 登记日期DateEdit1.Text
                        , 公司预核名称TextEdit.Text, "", 注册进度ComboBox.Text
                        , 外勤进度ComboBox.Text, "","","","业务登记",cmbRegWC.Text,FBegindateEdit.Text,FEnddateEdit.Text);
                }
                else
                if (Security.UserBusiness.Contains("主管"))
                {
                    businessDataSet.GetBusinessRegDataEdit(业务员TextEdit.Text, 登记日期DateEdit.Text, 登记日期DateEdit1.Text
                        , 公司预核名称TextEdit.Text,"", 注册进度ComboBox.Text
                        , 外勤进度ComboBox.Text,Security.DeptName,"","", "业务登记", cmbRegWC.Text, FBegindateEdit.Text, FEnddateEdit.Text);
                }
                else
                {
                    businessDataSet.GetBusinessRegDataEdit(Security.UserName, 登记日期DateEdit.Text, 登记日期DateEdit1.Text
                        , 公司预核名称TextEdit.Text, "", 注册进度ComboBox.Text
                        , 外勤进度ComboBox.Text,"","","","业务登记", cmbRegWC.Text, FBegindateEdit.Text, FEnddateEdit.Text);
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
                //PaymentcomboBoxEdit.Text = "";
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

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                string newID = Guid.NewGuid().ToString();
                FrmRegBusiness frmRegDlg = new FrmRegBusiness(newID,true);
                if (frmRegDlg.ShowDialog() == DialogResult.OK)
                {
                    businessDataSet.GetBusinessRegByID(newID);
                    int i = tW_BusinessRegBindingSource.Find("TW_BusinessRegID", newID);
                    tW_BusinessRegBindingSource.Position = i;
                }

                businessDataSet.DBHelper.WangDaSer.UpdateCUserID();

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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                DataRowView rv = tW_BusinessRegBindingSource.Current as DataRowView;
                if (rv!=null )
                {
                    string newID = rv["TW_BusinessRegID"].ToString();
                    FrmRegBusiness frmRegDlg = new FrmRegBusiness(newID, false);
                    if (frmRegDlg.ShowDialog() == DialogResult.OK)
                    {
                        businessDataSet.GetBusinessRegByID(newID);
                        int i = tW_BusinessRegBindingSource.Find("TW_BusinessRegID", newID);
                        tW_BusinessRegBindingSource.Position = i;
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

        private void btnDel_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                if (UserMessages.ShowQuestionBox("确定要删除么?"))
                {
                    DataRowView rv = tW_BusinessRegBindingSource.Current as DataRowView;
                    if (rv != null)
                    {
                        tW_BusinessRegBindingSource.RemoveCurrent();
                        businessDataSet.DBHelper.BasicSer.SaveTable(businessDataSet, "TW_BusinessReg");
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
                if (Security.UserBusiness.Contains("主管") || Security.UserBusiness.Contains("总经理") || Security.UserName.ToLower() == "admin")
                {
                    layoutControlItem9.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                }
                else
                {
                    layoutControlItem9.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
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

        private void btnWC_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                if (UserMessages.ShowQuestionBox("确定直接设置完成么？"))
                {
                    try
                    {
                        int[] rowindexs = gridView1.GetSelectedRows();
                        List<string> rowids = new List<string>();
                        if (rowindexs.Length > 0)
                        {
                            foreach (int rowIndex in rowindexs)
                            {
                                DataRowView selRow = gridView1.GetRow(rowIndex) as DataRowView;
                                rowids.Add(selRow["TW_BusinessRegID"].ToString());
                            }
                            foreach (string regID in rowids)
                            {
                                DataRow row = businessDataSet.TW_BusinessReg.FindByTW_BusinessRegID(regID);
                                row.BeginEdit();
                                row["交接确认完成"] = true;
                                row["外勤进度"] = "完成";
                                if (row["注册完成时间"].ToString() == "")
                                {
                                    row["注册完成时间"] = DateTime.Now;
                                }
                                row.EndEdit();
                            }
                            //保存数据
                            businessDataSet.SaveTable();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
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
    }
}
