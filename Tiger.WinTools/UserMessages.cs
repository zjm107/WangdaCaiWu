using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Tiger.Tools
{
    /// <summary>
    /// 用户消息提示
    /// </summary>
    public  class UserMessages
    {
      

        /// <summary>
        /// 错误信息提示
        /// </summary>
        /// <param name="ErrorInfo">提示信息</param>
        public static void ShowErrorBox(string ErrorInfo)
        {
            MessageBox.Show(ErrorInfo, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        /// <summary>
        /// 问题信息提示
        /// </summary>
        /// <param name="QuestionInfo">提示信息</param>
        public static bool ShowQuestionBox(string QuestionInfo)
        {

            if (DialogResult.OK == MessageBox.Show(QuestionInfo, "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            {
                return true;
            }
            else
            {
                return false;
            }


        }
        /// <summary>
        /// 警告信息提示
        /// </summary>
        public static void ShowInfoBox(string Info)
        {
            MessageBox.Show(Info, "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
      
    }
}
