using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;
using Tiger.PdrCommon;
using Tiger.Tools;

namespace Tiger.PdrCommon
{
    /// <summary>
    /// 
    /// </summary>
    public partial class FrmRePassWord : DevExpress.XtraEditors.XtraForm
    {
        /// <summary>
        /// �����û�����
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
                    if (UserMessages.ShowQuestionBox("�����벻һ�£���Ҫ����������"))
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
                            if (row["LogPassword"].ToString() ==txtOldPassWord.Text)
                            {
                                //��������
                                row.BeginEdit();
                                row["LogPassword"] = txtNewPassWord.Text;
                                row.EndEdit();
                                SysTools.config.SaveTable(ds, "TCOM_USER");
                            }

                        }
                        else
                        {
                            UserMessages.ShowErrorBox("�û���Ϣ��Ч������ϵͳ����Ա��ϵ!");
                            e.Cancel = true;
                        }
                   
                }
                else
                {
                    if (UserMessages.ShowQuestionBox("û����������룬��Ҫ����������"))
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