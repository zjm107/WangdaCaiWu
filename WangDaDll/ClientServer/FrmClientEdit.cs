using DevExpress.XtraEditors.Controls;
using System;
using System.Data;
using System.Windows.Forms;
using static DevExpress.XtraEditors.Mask.MaskSettings;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WangDaDll
{
    public partial class FrmClientEdit : DevExpress.XtraEditors.XtraForm
    {
        public FrmClientEdit()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
               
                //判断当前行的状态是否为添加状态
               var rv = tW_ClientBindingSource.Current as DataRowView; 
                if (rv.Row.RowState == DataRowState.Added)
                {
                    contractDataSet.GetTW_ClientByClientName(客户名称TextEdit.Text.Trim());
                    if (contractDataSet.TW_Client.Count > 0)
                    {
                        //提示用户客户名称已存在，在某某做账会计下
                        string accountantName = contractDataSet.TW_Client[0]["做账会计"].ToString();
                        MessageBox.Show("客户名称已存在！做账会计为：" + accountantName + "！");
                        return;
                    }
                }

                //初始做账时间DateEdit不能为空
                if (初始做账时间DateEdit.DateTime == DateTime.MinValue)
                {
                    MessageBox.Show("初始做账时间不能为空！");
                    return;
                }

                DateTime endDate = 初始做账时间DateEdit.DateTime.AddMonths(12);
                //设置成endDate的月的最后一天
               // endDate = new DateTime(endDate.Year, endDate.Month, 1).AddMonths(1).AddDays(-1);
                dateEdit1.DateTime = endDate;
                tW_ClientBindingSource.EndEdit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("错误:" + ex.Message);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();

        }


        //默认会计ID
        public string deafultAccountantID = "";
        //默认会计名称
        public string deafultAccountantName = "";
        private void FrmClientEdit_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try {
                dstTCONF_WORD.FillDevComboBox("公司性质", 公司性质ComboBoxEdit);
                dstTCONF_WORD.FillDevComboBox("公司类型", 公司类型ComboBoxEdit);
                dstTCONF_WORD.FillDevComboBox("客户分级", 客户分级ComboBoxEdit);
                DataRowView wRv = tW_ClientBindingSource.Current as DataRowView;
                if (!string.IsNullOrEmpty(deafultAccountantName))
                {
                    做账会计TextEdit.Text = deafultAccountantName;
                   
                    if (wRv != null)
                    {
                        wRv.BeginEdit();
                        wRv["做账会计ID"] = deafultAccountantID;
                        wRv["做账会计"] = deafultAccountantName;

                        wRv.EndEdit();
                    }
                }
               if( wRv != null && wRv.Row.RowState == DataRowState.Added)
                {
                    //初始做账时间为这个月的第一天
                    初始做账时间DateEdit.DateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                    DateTime endDate = 初始做账时间DateEdit.DateTime.AddMonths(12);
                    dateEdit1.DateTime = endDate;
                }
                    


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally {
                this.Cursor = Cursors.Default;
            }
        }

        private void 做账会计TextEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try {
                FrmUserSelectDlg frmUserDlg = new FrmUserSelectDlg();
                if (frmUserDlg.ShowDialog() == DialogResult.OK)
                {
                    DataRowView rv = frmUserDlg.SelectRow;
                    string userID = rv["USERID"].ToString();
                    string userName = rv["USERNAME"].ToString();
                    DataRowView wRv = tW_ClientBindingSource.Current as DataRowView;
                    wRv.BeginEdit();
                    wRv["做账会计ID"] = userID;
                    wRv["做账会计"] = userName;
                    wRv.EndEdit();
                    string clientID = wRv["客户名称ID"].ToString();
                    //ntractDataSet.GetContractInfoByClientId(clientID);
                    if (contractDataSet.Tables["TW_Contract"].Rows.Count > 0)
                    {
                        DataRow cRow  = contractDataSet.Tables["TW_Contract"].Rows[0];
                        cRow.BeginEdit();
                        cRow["做账会计ID"] = userID;
                        cRow["做账会计"] = userName;
                        cRow.EndEdit();
                    }
                    else
                        {
                        contractDataSet.GetLastContractByClientId(clientID);
                        if (contractDataSet.Tables["TW_Contract"].Rows.Count > 0)
                        {
                            DataRow cRow = contractDataSet.Tables["TW_Contract"].Rows[0];
                            cRow.BeginEdit();
                            cRow["做账会计ID"] = userID;
                            cRow["做账会计"] = userName;
                            cRow.EndEdit();
                        }
                    }
                    //contractDataSet.Tables["TW_Contract"].Rows[0]["做账会计ID"] = userID;
                    //contractDataSet.Tables["TW_Contract"].Rows[0]["做账会计"] = userName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void 注册员TextEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                FrmUserSelectDlg frmUserDlg = new FrmUserSelectDlg();
                if (frmUserDlg.ShowDialog() == DialogResult.OK)
                {
                    DataRowView rv = frmUserDlg.SelectRow;
                    string userID = rv["USERID"].ToString();
                    string userName = rv["USERNAME"].ToString();
                    DataRowView wRv = tW_ClientBindingSource.Current as DataRowView;
                    wRv.BeginEdit();
                    wRv["注册员ID"] = userID;
                    wRv["注册员"] = userName;
                    wRv.EndEdit();

                    if (contractDataSet.Tables["TW_Contract"].Rows.Count > 0)
                    {
                        DataRow cRow = contractDataSet.Tables["TW_Contract"].Rows[0];
                        cRow.BeginEdit();
                        cRow["注册员ID"] = userID;
                        cRow["注册员"] = userName;
                        cRow.EndEdit();
                    }
                    else
                    {
                        contractDataSet.GetLastContractByClientId(wRv["客户名称ID"].ToString());
                        if (contractDataSet.Tables["TW_Contract"].Rows.Count > 0)
                        {
                            DataRow cRow = contractDataSet.Tables["TW_Contract"].Rows[0];
                            cRow.BeginEdit();
                            cRow["注册员ID"] = userID;
                            cRow["注册员"] = userName;
                            cRow.EndEdit();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void 业务员TextEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                FrmUserSelectDlg frmUserDlg = new FrmUserSelectDlg();
                if (frmUserDlg.ShowDialog() == DialogResult.OK)
                {
                    DataRowView rv = frmUserDlg.SelectRow;
                    string userID = rv["USERID"].ToString();
                    string userName = rv["USERNAME"].ToString();
                    DataRowView wRv = tW_ClientBindingSource.Current as DataRowView;
                    wRv.BeginEdit();
                    wRv["业务员ID"] = userID;
                    wRv["业务员"] = userName;
                    wRv.EndEdit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void 初始做账时间DateEdit_EditValueChanged(object sender, EventArgs e)
        {
            try { 
            DateTime endDate = 初始做账时间DateEdit.DateTime.AddMonths(12);
            dateEdit1.DateTime = endDate;
            }catch(Exception ex)
            {
                MessageBox.Show("错误:" + ex.Message);
            }
        }

        private void 客户名称TextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
