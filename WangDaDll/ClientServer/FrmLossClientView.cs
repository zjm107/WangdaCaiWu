using System;
using System.Data;
using System.Windows.Forms;
using Tiger.Tools;
using WangDaDll.Common;
using WangDaDll.Contract;

namespace WangDaDll
{
    public partial class FrmLossClientView : DevExpress.XtraEditors.XtraForm
    {
        public FrmLossClientView()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
               

            }
            catch (Exception ex)
            {
                MessageBox.Show("错误:" + ex.Message);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        private void FrmClientEdit_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {

                if (Security.UserName == "秦艳" || Security.UserName == "admin" || Security.UserBusiness == "注册主管")   //管理员可以查看所有信息
                {
                    if (ClientId != "")
                    {
                        //查询客户信息
                        contractDataSetView.GetTW_ClientByClientId(ClientId);
                        contractDataSetView.GetContractInfoByClientId(ClientId);
                        //查询客户附件
                        //fileDataSet.GetFileListByFkId(ClientId);

                    }
                    else if (ClientName != "")
                    {
                        //查询客户信息
                        contractDataSetView.GetTW_ClientByClientName(ClientName);
                        //tW_ClientBindingSource1.MoveFirst();
                        //查询客户附件
                        DataRowView rv = tW_ClientBindingSource1.Current as DataRowView;
                        if (rv != null)
                        {
                            ClientId = rv["客户名称ID"].ToString();
                            contractDataSetView.GetContractInfoByClientId(ClientId);
                            //fileDataSet.GetFileListByFkId(clientId);
                        }

                    }
                }
                else
                {
                    if (ClientId != "")
                    {
                        //查询客户信息
                        contractDataSetView.GetTW_ClientByClientIdAndUserId(ClientId, Security.UserID);
                        //查询客户附件
                        DataRowView rv = tW_ClientBindingSource1.Current as DataRowView;
                        if (rv != null)
                        {
                            ClientId = rv["客户名称ID"].ToString();
                            contractDataSetView.GetContractInfoByClientId(ClientId);
                            //fileDataSet.GetFileListByFkId(clientId);
                        }
                    }
                    else if (ClientName != "")
                    {
                        //查询客户信息
                        contractDataSetView.GetTW_ClientByClientNameAndUserName(ClientName, Security.UserName);
                        //查询客户附件
                        DataRowView rv = tW_ClientBindingSource1.Current as DataRowView;
                        if (rv != null)
                        {
                            ClientId = rv["客户名称ID"].ToString();
                            contractDataSetView.GetContractInfoByClientId(ClientId);
                            //fileDataSet.GetFileListByFkId(clientId);
                        }
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
        /// <summary>
        /// 客户ID
        /// </summary>
        public string ClientId = "";
        /// <summary>
        /// 客户名称
        /// </summary>
        public string ClientName = "";

        private void 做账会计TextEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try {
                FrmUserSelectDlg frmUserDlg = new FrmUserSelectDlg();
                if (frmUserDlg.ShowDialog() == DialogResult.OK)
                {
                    DataRowView rv = frmUserDlg.SelectRow;
                    string userID = rv["USERID"].ToString();
                    string userName = rv["USERNAME"].ToString();
                    DataRowView wRv = tW_ClientBindingSource1.Current as DataRowView;
                    wRv.BeginEdit();
                    wRv["做账会计ID"] = userID;
                    wRv["做账会计"] = userName;
                    wRv.EndEdit();
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
                    DataRowView wRv = tW_ClientBindingSource1.Current as DataRowView;
                    wRv.BeginEdit();
                    wRv["注册员ID"] = userID;
                    wRv["注册员"] = userName;
                    wRv.EndEdit();
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
                    DataRowView wRv = tW_ClientBindingSource1.Current as DataRowView;
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
        /// <summary>
        /// 获取数据库中的文件流，调用系统应用程序打开
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 查看HypertextLabel_OpenHyperlink(object sender, DevExpress.Utils.OpenHyperlinkEventArgs e)
        {
            try
            {
                DataRowView rv = this.tF_FILEBindingSource.Current as DataRowView;
                if (rv == null) return;

                string fileID = rv["FileID"].ToString();
                string fileType = rv["FileType"].ToString().ToLower();

                byte[] fileBytes = fileDataSet.GetFileByID(fileID);

                // 其他类型，保存到临时文件并用系统默认程序打开
                string tempPath = System.IO.Path.GetTempPath();
                string tempFile = System.IO.Path.Combine(tempPath, Guid.NewGuid().ToString() + fileType);
                System.IO.File.WriteAllBytes(tempFile, fileBytes);
                System.Diagnostics.Process.Start(tempFile);

            }
            catch (Exception ex)
            {
                UserMessages.ShowInfoBox(ex.Message);
            }
        }
        /// <summary>
        /// 确定客户流失，保存客户信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click_1(object sender, EventArgs e)
        {
            try
            {
                //提示是否确认客户流失
                if (!UserMessages.ShowQuestionBox("是否确认客户流失？"))
                {
                    return;
                }
                var rv =  tW_ClientBindingSource1.Current as DataRowView; 
                rv["流失审批状态"] = "待审批";

                this.Validate();
                tW_ClientBindingSource1.EndEdit();
                contractDataSetView.SaveClientData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("错误:" + ex.Message);
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
