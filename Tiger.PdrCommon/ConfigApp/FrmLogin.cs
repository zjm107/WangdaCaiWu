using System;
using System.Data;
using System.Windows.Forms;
using Tiger.Tools;


namespace Tiger.PdrCommon
{

    /// <summary>
    /// 
    /// </summary>
    public partial class FrmLogin : DevExpress.XtraEditors.XtraForm
    {
        /// <summary>
        /// 
        /// </summary>
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                if (this.DialogResult == DialogResult.OK)
                {
                    //SysLogin sysLogin = new SysLogin();

                    //string strPassWord = EnDecrypt.Encrypt(this.txtPassword.Text);
                    string strPassWord = this.txtPassword.Text;
                    DataSet ds = SysTools.config.Login(this.cmbUserName.Text, strPassWord);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        DataRow row = ds.Tables[0].Rows[0];
                        Security.UserID = row["UserID"].ToString();
                        Security.UserName = row["UserName"].ToString();
                        Security.DeptID = row["DeptID"].ToString();
                        Security.DeptName = row["DeptName"].ToString();
                        Security.UserPopedom = row["DUTIES"].ToString();
                        Security.DataBound = row["DataWise"].ToString();
                        Security.CorporationCode = "";
                        Security.UserLevel = "";
                        Security.CorporationName = row["LogName"].ToString();
                        Security.UserBusiness = row["WorkType"].ToString();
                        dstLogName.Add(cmbUserName.Text);
                        e.Cancel = false;
                    }
                    else
                    {
                        if (UserMessages.ShowQuestionBox("您输入的登录名或密码错误！要退出系统吗？"))
                        {
                            e.Cancel = false;
                            Application.ExitThread();
                        }
                        else
                        {
                            e.Cancel = true;
                        }
                    }

                }
                else
                {
                    Application.ExitThread();
                }
            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
                Application.ExitThread();
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                dstLogName.loadLoginName();
                DataView dataview = dstLogName.登录记录.DefaultView;
                dataview.Sort = "登录时间";
                foreach (DataRowView rv in dataview)
                {
                    cmbUserName.Items.Add(rv["登录名称"].ToString());
                }
            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                FrmURLSet frm= new FrmURLSet();
                frm.ShowDialog();

            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

        }
    }
}