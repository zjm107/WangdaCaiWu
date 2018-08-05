using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Windows.Forms;
using Tiger.Entities;
using Tiger.Tools;
using Tiger.WinControl.Forms;

namespace Tiger.ConfigApp
{
    /// <summary>
    /// 
    /// </summary>
    public partial class FrmRePassWord : BaseForm 
    {
        /// <summary>
        /// 更改用户密码
        /// </summary>
        public FrmRePassWord()
        {
            InitializeComponent();
        }

        private void FrmRePassWord_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (this.DialogResult == DialogResult.Cancel)
                {
                    e.Cancel = false;
                    return;
                }
                if (txtNewPassWord.Text != txtReNewPassWord.Text || (txtNewPassWord.Text == "" || txtReNewPassWord.Text == ""))
                {
                    if (UserMessages.ShowQuestionBox("新密码不一致，需要重新输入吗？"))
                    {
                        e.Cancel = true;
                    }
                    else
                    {
                        e.Cancel = false;
                    }
                    return;
                }
                if (txtOldPassWord.Text != "")
                {
                    //SysLogin LoginSer = new SysLogin();
                  

                        DataSet ds = SysTools.config.GetUserInfo(Security.UserID);
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            DataRow row = ds.Tables[0].Rows[0];
                            if (row["LogPassword"].ToString() == EnDecrypt.Encrypt(txtOldPassWord.Text))
                            {
                                //更新密码
                                row.BeginEdit();
                                row["LogPassword"] = EnDecrypt.Encrypt(txtNewPassWord.Text);
                                row.EndEdit();
                                SysTools.config.SaveTable(ds, "TCOM_USER");
                            }

                        }
                        else
                        {
                            UserMessages.ShowErrorBox("用户信息无效，请于系统管理员联系!");
                            e.Cancel = true;
                        }
                   
                }
                else
                {
                    if (UserMessages.ShowQuestionBox("没有输入旧密码，需要重新输入吗？"))
                    {
                        e.Cancel = true;
                    }
                    else
                    {
                        e.Cancel = false;
                    }
                    return;
                }
            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }
            
        }


       

    }
}