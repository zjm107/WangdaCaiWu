using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Configuration;
using System.Data;


namespace Tiger.Tools
{
    /// <summary>
    /// ����Ӱ��ķ���
    /// </summary>
    public static class ReflectionHelper
    {
        static ReflectionHelper()
        { 
        }
        /// <summary>
        /// �Ӵ�����ʾ�Ӵ��� 
        /// </summary>
        /// <param name="p_ChildFormName">�����ȫ�������������ռ�����</param>
        /// <param name="p_MDIForm">MDI����</param>
        public static Form ShowChildMDI(string p_ChildFormName, Form p_MDIForm)
        {
            try
            {
                foreach (Form frm in p_MDIForm.MdiChildren)
                {
                    string FormName = p_ChildFormName.Substring(p_ChildFormName.Length - frm.Name.Length);
                    if (frm.Name == FormName)
                    {
                        frm.Activate();
                        return null;
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception( "����form�������⣺"+e.Message);
            }

            try
            {

                Type t = GetTypeFromString(p_ChildFormName);
                ConstructorInfo ci = t.GetConstructor(Type.EmptyTypes);
                object obj = ci.Invoke(null);
                //object obj = Activator.CreateInstance(t);
                //object obj = Activator.CreateInstance("Tiger.CPMS", ChildFormName);
                //Activator.CreateInsta
                // object obj = Activator.CreateInstance(new Type.GetType(ChildFormName));
                Form cfrm = (obj as Form);
                cfrm.MdiParent = p_MDIForm;
                cfrm.WindowState = FormWindowState.Maximized;
                return cfrm;
            }
            catch (Exception e)
            {
                throw new Exception("����ʵ������" + e.Message);
            }

        }


        /// <summary>
        /// �Ӵ�����ʾ�Ӵ��� ,�����������һ�������ж��ʵ������ÿ��Title��������ͬ
        /// </summary>
        /// <param name="p_ChildFormName">�����ȫ�������������ռ�����</param>
        /// <param name="p_MDIForm">MDI����</param>
        /// <param name="p_Title">��������</param>
        public static Form ShowChildMDI(string p_ChildFormName, Form p_MDIForm, string p_Title)
        {
            try
            {
                foreach (Form frm in p_MDIForm.MdiChildren)
                {
                    if ( frm.Text == p_Title)
                    {
                        frm.Activate();
                        return null;
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception("����form�������⣺" + e.Message);
            }

            try
            {

                Type t = GetTypeFromString(p_ChildFormName);
                ConstructorInfo ci = t.GetConstructor(Type.EmptyTypes);
                object obj = ci.Invoke(null);
                //object obj = Activator.CreateInstance(t);
                //object obj = Activator.CreateInstance("Tiger.CPMS", ChildFormName);
                //Activator.CreateInsta
                // object obj = Activator.CreateInstance(new Type.GetType(ChildFormName));
                Form cfrm = (obj as Form);
                cfrm.Text = p_Title;
                cfrm.MdiParent = p_MDIForm;
                cfrm.WindowState = FormWindowState.Maximized;
                return cfrm;
            }
            catch (Exception e)
            {
                throw new Exception("����ʵ������" + e.Message);
            }

        }




        /// <summary>
        /// ��ȡһ�����������
        /// </summary>
        /// <param name="p_typeName"></param>
        /// <returns></returns>
        public static Type GetTypeFromString(string p_typeName)
        {
            Assembly[] loadedAsms = AppDomain.CurrentDomain.GetAssemblies();

            foreach (Assembly asm in loadedAsms)
            {
                Type tp = asm.GetType(p_typeName);
                if (tp != null)
                {
                    return tp;
                }
            }
            return null;
        }

        /// <summary>
        /// ��̬��ȡURL
        /// </summary>
        /// <param name="p_strKeyName">Config�еĹؼ���</param>
        /// <returns></returns>
        public static  string GetUrl(string p_strKeyName)
        {
            try
            {
                DataRow row= dstUrl.ServiceURL.FindByURLKey(p_strKeyName);
                string strURL = "";
                if (row != null)
                {
                    strURL = row["URLValue"].ToString();
                }

                return strURL;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        private static DstUrl dstUrl = new DstUrl();
        /// <summary>
        /// ����WebService URL����
        /// </summary>
        public static void LoadUrlData()
        {
            dstUrl.ReadXml("c:\\wangdaApp.exe.xml");
        }
         #region ���ݵ���
        /// <summary>
        /// �������
        /// </summary>
        public static void ExportGrid(DevExpress.XtraGrid.GridControl ExpGrid)
        {
            if (ExpGrid == null)
            {
                UserMessages.ShowErrorBox("û�п��Ե����ı��!");
                return;
            }
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Excel�ļ�|*.xls|��ҳ�ļ�|*.html";
                saveFileDialog1.DefaultExt = "xls";
                saveFileDialog1.ShowDialog();
                string strFileName = saveFileDialog1.FileName;
                if (strFileName.Trim() != "")
                {
                    if (strFileName.ToUpper().IndexOf(".XLS") > -1)
                    {
                       
                        ExpGrid.ExportToXls(strFileName);
                        UserMessages.ShowInfoBox("�ɹ��Ľ����ݵ�����" + strFileName + "!");
                    }
                    if (strFileName.ToUpper().IndexOf(".HTML") > -1)
                    {
                        ExpGrid.ExportToXls(strFileName);
                        UserMessages.ShowInfoBox("�ɹ��Ľ����ݵ�����" + strFileName + "!");
                    }
                }
            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        #endregion

   



    }
}
