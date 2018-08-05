using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Tiger.Tools
{
    /// <summary>
    /// �û���Ϣ��ʾ
    /// </summary>
    public  class UserMessages
    {
      

        /// <summary>
        /// ������Ϣ��ʾ
        /// </summary>
        /// <param name="ErrorInfo">��ʾ��Ϣ</param>
        public static void ShowErrorBox(string ErrorInfo)
        {
            MessageBox.Show(ErrorInfo, "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        /// <summary>
        /// ������Ϣ��ʾ
        /// </summary>
        /// <param name="QuestionInfo">��ʾ��Ϣ</param>
        public static bool ShowQuestionBox(string QuestionInfo)
        {

            if (DialogResult.OK == MessageBox.Show(QuestionInfo, "��ʾ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            {
                return true;
            }
            else
            {
                return false;
            }


        }
        /// <summary>
        /// ������Ϣ��ʾ
        /// </summary>
        public static void ShowInfoBox(string Info)
        {
            MessageBox.Show(Info, "��Ϣ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
      
    }
}
