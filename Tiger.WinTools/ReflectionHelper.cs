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
    /// 反向影射的方法
    /// </summary>
    public static class ReflectionHelper
    {
        static ReflectionHelper()
        { 
        }
        /// <summary>
        /// 子窗体显示子窗体 
        /// </summary>
        /// <param name="p_ChildFormName">窗体的全名，包括命名空间在内</param>
        /// <param name="p_MDIForm">MDI窗体</param>
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
                throw new Exception( "查找form出现问题："+e.Message);
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
                throw new Exception("创建实例出错：" + e.Message);
            }

        }


        /// <summary>
        /// 子窗体显示子窗体 ,这个方法允许一个窗体有多个实例，但每个Title不可以相同
        /// </summary>
        /// <param name="p_ChildFormName">窗体的全名，包括命名空间在内</param>
        /// <param name="p_MDIForm">MDI窗体</param>
        /// <param name="p_Title">标题名称</param>
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
                throw new Exception("查找form出现问题：" + e.Message);
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
                throw new Exception("创建实例出错：" + e.Message);
            }

        }




        /// <summary>
        /// 获取一个对象的类型
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
        /// 动态获取URL
        /// </summary>
        /// <param name="p_strKeyName">Config中的关键字</param>
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
        /// 加载WebService URL数据
        /// </summary>
        public static void LoadUrlData()
        {
            dstUrl.ReadXml("c:\\wangdaApp.exe.xml");
        }
         #region 数据导出
        /// <summary>
        /// 导出表格
        /// </summary>
        public static void ExportGrid(DevExpress.XtraGrid.GridControl ExpGrid)
        {
            if (ExpGrid == null)
            {
                UserMessages.ShowErrorBox("没有可以导出的表格!");
                return;
            }
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Excel文件|*.xls|网页文件|*.html";
                saveFileDialog1.DefaultExt = "xls";
                saveFileDialog1.ShowDialog();
                string strFileName = saveFileDialog1.FileName;
                if (strFileName.Trim() != "")
                {
                    if (strFileName.ToUpper().IndexOf(".XLS") > -1)
                    {
                       
                        ExpGrid.ExportToXls(strFileName);
                        UserMessages.ShowInfoBox("成功的将数据导出到" + strFileName + "!");
                    }
                    if (strFileName.ToUpper().IndexOf(".HTML") > -1)
                    {
                        ExpGrid.ExportToXls(strFileName);
                        UserMessages.ShowInfoBox("成功的将数据导出到" + strFileName + "!");
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
