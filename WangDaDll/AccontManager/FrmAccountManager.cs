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
using WangDaDll;

namespace WangDaDll
{
    public partial class FrmAccountManager : DevExpress.XtraEditors.XtraForm
    {
        public FrmAccountManager()
        {
            InitializeComponent();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try {
                if (Security.UserBusiness.Contains("总经理"))
                {
                    businessDataSet.GetBusinessRegDataEdit(做账会计TextEdit.Text, 登记日期DateEdit.Text, 登记日期DateEdit1.Text
                        , 公司预核名称TextEdit.Text, PaymentcomboBoxEdit.Text, 注册进度ComboBox.Text
                        , 外勤进度ComboBox.Text, "","",cmbPaiDan.Text, "做账管理",cmbRegWC.Text,"","");
                }
                else
                if (Security.UserBusiness.Contains("主管"))
                {
                    businessDataSet.GetBusinessRegDataEdit(做账会计TextEdit.Text, 登记日期DateEdit.Text, 登记日期DateEdit1.Text
                        , 公司预核名称TextEdit.Text, PaymentcomboBoxEdit.Text, 注册进度ComboBox.Text
                        , 外勤进度ComboBox.Text,Security.DeptName,"",cmbPaiDan.Text, "做账管理",cmbRegWC.Text,"","");
                }
                else
                {
                    businessDataSet.GetBusinessRegDataEdit(Security.UserName, 登记日期DateEdit.Text, 登记日期DateEdit1.Text
                        , 公司预核名称TextEdit.Text, PaymentcomboBoxEdit.Text, 注册进度ComboBox.Text
                        , 外勤进度ComboBox.Text,"","","", "做账管理", cmbRegWC.Text,"","");
                }
                gridView1.UnselectRow(0);

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
                做账会计TextEdit.Text = "";
                登记日期DateEdit.Text = "";
                登记日期DateEdit1.Text = "";
                公司预核名称TextEdit.Text = "";
                PaymentcomboBoxEdit.Text = "";
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
                if (Security.UserBusiness.Contains("主管") || Security.UserBusiness.Contains("经理"))
                    layoutControlItem4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                else
                    layoutControlItem4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                cmbPaiDan.Text = "否";
                注册进度ComboBox.Text = "完成";

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

        private void btnSendOrder_Click(object sender, EventArgs e)
        {
            
            try {
                int[] rowindexs = gridView1.GetSelectedRows();
                List<string> rowids = new List<string>();
                if (rowindexs.Length>0)
                {
                    FrmUserSelectDlg frmUserDlg = new FrmUserSelectDlg();
                    frmUserDlg.DeptName = Security.DeptName;
                    if (frmUserDlg.ShowDialog() == DialogResult.OK)
                    {
                        DataRowView rv = frmUserDlg.SelectRow;
                        if (rv != null)
                        {
                            string userName = rv["USERNAME"].ToString();
                            string userID = rv["USERID"].ToString();

                            foreach (int rowIndex in rowindexs)
                            {
                                DataRowView  selRow = gridView1.GetRow(rowIndex) as DataRowView;
                                rowids.Add(selRow["TW_BusinessRegID"].ToString());
                            }
                            foreach (string regID in rowids)
                            {
                                DataRow row = businessDataSet.TW_BusinessReg.FindByTW_BusinessRegID(regID);
                                row.BeginEdit();
                                row["做账会计"] = userName;
                                row["做账会计ID"] = userID;
                                row["外勤派单标记"] = true;
                                row.EndEdit();
                            }
                            //保存数据
                            businessDataSet.SaveTable();
                        }
                    }
                }
                

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnChangeState_Click(object sender, EventArgs e)
        {
            try
            {
                int[] rowindexs = gridView1.GetSelectedRows();
                List<string> rowids = new List<string>();
                if (rowindexs.Length > 0)
                {
                    FrmStateList frmStateDlg;
                    if (rowindexs.Length == 1)
                    {
                        DataRowView selRow = gridView1.GetRow(rowindexs[0]) as DataRowView;
                        string companyType = selRow["公司类型"].ToString();
                        if (companyType.Contains("外贸"))
                        {
                            frmStateDlg = new FrmStateList("", "外勤进度进出口");
                        }
                        else
                        {
                            frmStateDlg = new FrmStateList("外勤进度", "");
                        }
                    }
                    else
                        frmStateDlg = new FrmStateList("外勤进度", "外勤进度进出口");

                    if (frmStateDlg.ShowDialog() == DialogResult.OK)
                    {
                        string selectState = frmStateDlg.SelectState;
                        if (!string.IsNullOrEmpty(selectState))
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
                                row["外勤进度"] = selectState;
                                row.EndEdit();
                            }
                            //保存数据
                            businessDataSet.SaveTable();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnWQ_Click(object sender, EventArgs e)
        {
            try
            {
                int[] rowindexs = gridView1.GetSelectedRows();
                List<string> rowids = new List<string>();
                if (rowindexs.Length > 0)
                {
                    FrmUserSelectDlg frmUserDlg = new FrmUserSelectDlg();
                    frmUserDlg.DeptName = Security.DeptName;
                    if (frmUserDlg.ShowDialog() == DialogResult.OK)
                    {
                        DataRowView rv = frmUserDlg.SelectRow;
                        if (rv != null)
                        {
                            string userName = rv["USERNAME"].ToString();
                            string userID = rv["USERID"].ToString();

                            foreach (int rowIndex in rowindexs)
                            {
                                DataRowView selRow = gridView1.GetRow(rowIndex) as DataRowView;
                                rowids.Add(selRow["TW_BusinessRegID"].ToString());
                            }
                            foreach (string regID in rowids)
                            {
                                DataRow row = businessDataSet.TW_BusinessReg.FindByTW_BusinessRegID(regID);
                                row.BeginEdit();
                                row["外勤员"] = userName;
                                row["外勤员ID"] = userID;
                                row.EndEdit();
                            }
                            //保存数据
                            businessDataSet.SaveTable();
                        }
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
