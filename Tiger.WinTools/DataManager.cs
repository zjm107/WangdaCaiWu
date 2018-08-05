using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.IO;

namespace Tiger.Tools
{
    /// <summary>
    /// 数据处理类
    /// </summary>
    public static class WindDataManager
    {
      
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



        #region 上传下载数据，与数据库表格有关系
        //表结构
        /*
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         */



        /// <summary>
        /// 上载文件,要求行有字段["文件大小"][文件][文件类型][文件名称]
        /// </summary>
        /// <param name="rv"> 添加的数据行，当前行 </param>
        public static string UpLoadFile(DataRowView rv)
        {
            try
            {
                OpenFileDialog OFD = new OpenFileDialog();
                OFD.Filter = "所有文件|*.*|Word文件|*.doc|Excel文件|*.xls";
                if (OFD.ShowDialog() == DialogResult.Cancel)
                    return "";

                string FilePath = OFD.FileName;   //文件全名
                string strFileName = Path.GetFileNameWithoutExtension(FilePath);
                string ExtentName = Path.GetExtension(FilePath);   //扩展名 

                FileStream FSFile = new FileStream(FilePath, FileMode.Open);  //创建一个文件流对象
                byte[] SFile = new byte[FSFile.Length];    //创建字节大小
                int FileSize = (int)FSFile.Length;
                if (FileSize <= 0)
                {
                    MessageBox.Show("文件不正确，请核实文件是否存在！");
                    return "";
                }

                FSFile.Read(SFile, 0, FileSize);
                FSFile.Close();



                if (rv == null)
                    return "";
                rv["文件大小"] = FileSize;
                rv["文件"] = System.DBNull.Value;
                rv["文件"] = SFile;
                rv["文件类型"] = ExtentName;
                rv["文件名称"] = strFileName;
                rv.EndEdit();


                return FilePath;
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        /// <summary>
        /// 下载文件要,求行有字段["文件大小"][文件][文件类型][文件名称]
        /// </summary>
        /// <param name="FileRow">文件所在行</param>
        public static void DownLoadFile(DataRow FileRow)
        {
            try
            {
                SaveFileDialog aSFD = new SaveFileDialog();
                aSFD.FileName = FileRow["文件名称"].ToString();
                aSFD.Filter = "所有文件|*.*|Word文件|*.doc|Excel文件|*.xls";
                if (aSFD.ShowDialog() == DialogResult.OK)
                {

                    int intFileSize = Convert.ToInt32(FileRow["文件大小"]);
                    byte[] SFile = new byte[intFileSize];

                    if (FileRow["文件"] == DBNull.Value || intFileSize <= 0)
                    {
                        MessageBox.Show("不存在文件！");
                        return;
                    }
                    Object obj = new Object();
                    obj = FileRow["文件"];
                    SFile = (byte[])obj;
                    FileStream fsFile = new FileStream(aSFD.FileName + FileRow["文件类型"],
                        FileMode.OpenOrCreate);
                    fsFile.Write(SFile, 0, intFileSize);	//文件写
                    fsFile.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


       /// <summary>
        /// 将文件下载到临时目录
       /// </summary>
       /// <param name="FileRow"></param>
       /// <param name="p_strAppExeName"></param>
       /// <returns></returns>
        public static string DownLoadToTemp(DataRow FileRow,string p_strAppExeName)
        {
            try
            {
                //TempInfo 下载到运行目录的TempInfo下
                string strFilePath = GetAppPath(p_strAppExeName) + "TEMPINFO";
                string strFileName = strFilePath + "\\" + FileRow["文件名称"].ToString() + FileRow["文件类型"].ToString();
                int intFileSize = Convert.ToInt32(FileRow["文件大小"]);
                byte[] SFile = new byte[intFileSize];

                if (FileRow["文件"] == DBNull.Value || intFileSize <= 0)
                {
                    MessageBox.Show("不存在文件,不能够打开！");
                    return "";
                }
                Object obj = new Object();
                obj = FileRow["文件"];
                SFile = (byte[])obj;
                FileStream fsFile = new FileStream(strFileName,
                    FileMode.OpenOrCreate);
                fsFile.Write(SFile, 0, intFileSize);	//文件写
                fsFile.Close();
                return strFileName;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
       /// <summary>
        /// 将保存的临时文件上传至数据库
       /// </summary>
       /// <param name="rv"></param>
       /// <param name="p_strAppExeName"></param>
        public static void UpLoadFromTemp(DataRow rv, string p_strAppExeName)
        {

            try
            {
                string strFilePath = GetAppPath(p_strAppExeName) + "TEMPINFO";
                if (rv["文件名称"].ToString().Trim() == "")
                {
                    throw new Exception("文件保存出现错误！");
                }
                string strFileName = strFilePath + "\\" + rv["文件名称"].ToString() + rv["文件类型"].ToString();



                FileStream FSFile = new FileStream(strFileName, FileMode.Open);  //创建一个文件流对象
                byte[] SFile = new byte[FSFile.Length];    //创建字节大小
                int FileSize = (int)FSFile.Length;
                if (FileSize <= 0)
                {
                    MessageBox.Show("文件不正确！");
                    return;
                }

                FSFile.Read(SFile, 0, FileSize);
                FSFile.Close();

                if (rv == null)
                    return;
                rv["文件大小"] = FileSize;
                rv["文件"] = System.DBNull.Value;
                rv["文件"] = SFile;
                rv.EndEdit();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 获取系统执行目录
        /// </summary>
        /// <returns></returns>
        public static string GetAppPath(string p_strAppExeName)
        {
            try
            {
                string strFilePath = Application.ExecutablePath.ToUpper().Replace(p_strAppExeName, "");
                return strFilePath;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 删除临时目录的文件
        /// </summary>
        /// <param name="rv"></param>
        /// <param name="p_strAppExeName"></param>
        public static void DelTempFile(DataRow rv, string p_strAppExeName)
        {
            try
            {
                string strFilePath = GetAppPath(p_strAppExeName) + "TEMPINFO";
                string strFileName = strFilePath + "\\" + rv["文件名称"].ToString() + rv["文件类型"].ToString();
                File.Delete(strFileName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 删除临时目录里的全部文件
        /// </summary>
        public static void DelAllTempFile(string p_strAppExeName)
        {
            try
            {
                string strFilePath = GetAppPath(p_strAppExeName) + "TEMPINFO";
                foreach (string s in Directory.GetFiles(strFilePath))
                {
                    File.Delete(s); //删除此文件
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        #endregion 

        /// <summary>
        /// 设置gridview为只读
        /// </summary>
        /// <param name="gridview"></param>
        public static void SetGridReadOnly(this DevExpress.XtraGrid.Views.Grid.GridView gridview)
        {
            for (int i = 0; i < gridview.Columns.Count; i++)
            {
                gridview.Columns[i].OptionsColumn.ReadOnly = true;
            }
        }
        /// <summary>
        /// 设置gridview为可写
        /// </summary>
        /// <param name="gridview"></param>
        public static void SetGridWrite(this DevExpress.XtraGrid.Views.Grid.GridView gridview)
        {
            for (int i = 0; i < gridview.Columns.Count; i++)
            {
                gridview.Columns[i].OptionsColumn.ReadOnly = false ;
            }
        }
        /// <summary>
        /// 加载表格样式
        /// </summary>
        /// <param name="gridview"></param>
        /// <param name="formName"></param>
        public static void RestoreGridViewLayout(this DevExpress.XtraGrid.Views.Grid.GridView gridview, string formName)
        {
            try
            {
                //string path = Application.ExecutablePath.ToLower().Replace("tiger.exe","");
                string path = @"C:\TigerApp\";
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);
                path =path + formName+"."+gridview.Name+".xml";
                if (File.Exists(path))
                {
                    gridview.RestoreLayoutFromXml(path);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("加载样式出错:"+ex.Message );
            }
        }

        /// <summary>
        /// 删除选中的行
        /// </summary>
        /// <param name="gridview"></param>
        /// <returns></returns>
        public static bool DelSelectedRows(this DevExpress.XtraGrid.Views.Grid.GridView gridview)
        {
            bool r = false;
            if (UserMessages.ShowQuestionBox("要删除选中的行么?"))
            {
                gridview.DeleteSelectedRows();
                
                r = true;
            }
            return r;
        }


        /// <summary>
        /// 保存表格样式
        /// </summary>
        /// <param name="gridview"></param>
        /// <param name="formName"></param>
        public static void SaveGridViewLayout(this DevExpress.XtraGrid.Views.Grid.GridView gridview, string formName)
        {
            try
            {

                //string path = Application.ExecutablePath.ToLower().Replace("tiger.exe", "");
                string path = @"C:\TigerApp\";
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);
                path = path + formName + "." + gridview.Name + ".xml";
                gridview.SaveLayoutToXml(path);
            }
            catch (Exception ex)
            {
                throw new Exception("保存样式出错：" + ex.Message);
            }
        }

        /// <summary>
        /// 恢复默认样式
        /// </summary>
        /// <param name="gridview"></param>
        /// <param name="formName"></param>
        public static void RestoreDefaltGridViewLayout(this DevExpress.XtraGrid.Views.Grid.GridView gridview, string formName)
        {
            try
            {
//                string path = Application.ExecutablePath.ToLower().Replace("tiger.exe", "");
                string path = @"C:\TigerApp\";
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);
                path = path + formName + "." + gridview.Name + "df.xml";
                if (File.Exists(path))
                {
                    gridview.RestoreLayoutFromXml(path);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("加载样式出错:" + ex.Message);
            }
        }

 
        /// <summary>
        /// 保存默认样式
        /// </summary>
        /// <param name="gridview"></param>
        /// <param name="formName"></param>
        public static void SaveDefaltGridViewLayout(this DevExpress.XtraGrid.Views.Grid.GridView gridview, string formName)
        {
            try
            {

                string path = @"C:\TigerApp\";
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);

                path = path + formName + "." + gridview.Name + "df.xml";
                if (!File.Exists(path))
                {
                    gridview.SaveLayoutToXml(path);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("保存样式出错：" + ex.Message);
            }
        }


        /// <summary>
        /// 加载表格样式
        /// </summary>
        /// <param name="gridview"></param>
        /// <param name="formName"></param>
        public static void RestoreGridViewLayoutB(this DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView gridview, string formName)
        {
            try
            {
                //string path = Application.ExecutablePath.ToLower().Replace("tiger.exe","");
                string path = @"C:\TigerApp\";
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);
                path = path + formName + "." + gridview.Name + ".xml";
                if (File.Exists(path))
                {
                    gridview.RestoreLayoutFromXml(path);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("加载样式出错:" + ex.Message);
            }
        }

        /// <summary>
        /// 保存表格样式
        /// </summary>
        /// <param name="gridview"></param>
        /// <param name="formName"></param>
        public static void SaveGridViewLayoutB(this DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView gridview, string formName)
        {
            try
            {

                //string path = Application.ExecutablePath.ToLower().Replace("tiger.exe", "");
                string path = @"C:\TigerApp\";
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);
                path = path + formName + "." + gridview.Name + ".xml";
                gridview.SaveLayoutToXml(path);
            }
            catch (Exception ex)
            {
                throw new Exception("保存样式出错：" + ex.Message);
            }
        }

        /// <summary>
        /// 恢复默认样式
        /// </summary>
        /// <param name="gridview"></param>
        /// <param name="formName"></param>
        public static void RestoreDefaltGridViewLayoutB(this DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView gridview, string formName)
        {
            try
            {
                //                string path = Application.ExecutablePath.ToLower().Replace("tiger.exe", "");
                string path = @"C:\TigerApp\";
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);
                path = path + formName + "." + gridview.Name + "df.xml";
                if (File.Exists(path))
                {
                    gridview.RestoreLayoutFromXml(path);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("加载样式出错:" + ex.Message);
            }
        }


        /// <summary>
        /// 保存默认样式
        /// </summary>
        /// <param name="gridview"></param>
        /// <param name="formName"></param>
        public static void SaveDefaltGridViewLayoutB(this DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView gridview, string formName)
        {
            try
            {

                string path = @"C:\TigerApp\";
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);

                path = path + formName + "." + gridview.Name + "df.xml";
                if (!File.Exists(path))
                {
                    gridview.SaveLayoutToXml(path);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("保存样式出错：" + ex.Message);
            }
        }



        /// <summary>
        /// 加载控件样式
        /// </summary>
        /// <param name="layoutControl"></param>
        /// <param name="formName"></param>
        public static void RestoreControlLayout(this DevExpress.XtraLayout.LayoutControl layoutControl, string formName)
        {
            try
            {
                string path = @"C:\TigerApp\";
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);
                path = path + formName + "." + layoutControl.Name + ".xml";
                if (File.Exists(path))
                {
                    layoutControl.RestoreLayoutFromXml(path);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("加载样式出错:" + ex.Message);
            }
        }

        /// <summary>
        /// 保存控件样式
        /// </summary>
        /// <param name="layoutControl"></param>
        /// <param name="formName"></param>
        public static void SaveControlLayout(this DevExpress.XtraLayout.LayoutControl layoutControl, string formName)
        {
            try
            {
                string path = @"C:\TigerApp\";
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);
                path = path + formName + "." + layoutControl.Name + ".xml";
                layoutControl.SaveLayoutToXml(path);
            }
            catch (Exception ex)
            {
                throw new Exception("保存样式出错：" + ex.Message);
            }
        }

        /// <summary>
        /// 恢复控件默认样式
        /// </summary>
        /// <param name="layoutControl"></param>
        /// <param name="formName"></param>
        public static void RestoreDefaltControlLayout(this DevExpress.XtraLayout.LayoutControl layoutControl, string formName)
        {
            try
            {
                string path = @"C:\TigerApp\";
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);

                path = path + formName + "." + layoutControl.Name + "df.xml";
                if (File.Exists(path))
                {
                    layoutControl.RestoreLayoutFromXml(path);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("加载样式出错:" + ex.Message);
            }
        }


        /// <summary>
        /// 保存控件默认样式
        /// </summary>
        /// <param name="layoutControl"></param>
        /// <param name="formName"></param>
        public static void SaveDefaltControlLayout(this DevExpress.XtraLayout.LayoutControl layoutControl, string formName)
        {
            try
            {

                string path = @"C:\TigerApp\";
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);
                path = path + formName + "." + layoutControl.Name + "df.xml";
                if (!File.Exists(path))
                {
                    layoutControl.SaveLayoutToXml(path);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("保存样式出错：" + ex.Message);
            }
        }

        /// <summary>
        /// 获取选择列
        /// </summary>
        /// <param name="gridview"></param>
        /// <returns></returns>
        public static List<DataRow> GetSelectRow(this DevExpress.XtraGrid.Views.Grid.GridView gridview)
        {
            List<DataRow> list = new List<DataRow>();
            int[] rowIndexs = gridview.GetSelectedRows();
            foreach (int index in rowIndexs)
            {
                DataRowView rv = gridview.GetRow(index) as DataRowView ;
                if (rv != null)
                {
                    list.Add(rv.Row);
                }
            }
            return list;
        }



    }


    /// <summary>
    /// 对数据集进行管理的常用方法
    /// </summary>
    public static class DataManager
    {


        /// <summary>
        /// 将一个数据集中的数据导入到一数据集中，并且初始化状态
        /// </summary> 
        /// <param name="STable">源数据集</param>
        /// <param name="TTable">目标数据集</param>
        public static void ImpDataSet(this DataTable STable, DataTable TTable)
        {
            try
            {
                TTable.Rows.Clear();
                foreach (DataRow row in STable.Rows)
                {
                    TTable.ImportRow(row);
                }
                TTable.AcceptChanges();
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        /// <summary>
        /// 将一个数据集中的数据导入到一数据集中，并且初始化状态
        /// </summary>
        /// <param name="Sds">源数据集</param>
        /// <param name="STableName">源表名称</param>
        /// <param name="Tds">目标数据集</param>
        /// <param name="TTableName">目标表名称</param>
        public static void ImpDataSet(this DataSet Sds, string STableName, DataSet Tds, string TTableName)
        {
            try
            {
                DataTable TTable = Tds.Tables[TTableName];
                DataTable STable = Sds.Tables[STableName];
                TTable.Rows.Clear();
                foreach (DataRow row in STable.Rows)
                {
                    TTable.ImportRow(row);
                }
                TTable.AcceptChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        #region 数据错误检查

        /// <summary>
        /// 用于service端 保存数据后,将数据中的错误添加记录集中保存
        /// </summary>
        /// <param name="ds">原始数据</param>
        /// <param name="TableName">表名称</param>
        /// <param name="PKName">主键名</param>
        /// <returns></returns>
        public static DataSet GetErrorInfo(DataSet ds, string TableName, string PKName)
        {
            DataSet Eds = new DataSet();
            DataTable tab = new DataTable();
            tab.Columns.Add(PKName);
            tab.Columns.Add("Error");
            DataColumn[] cols = new DataColumn[] { tab.Columns[PKName] };
            tab.PrimaryKey = cols;
            Eds.Tables.Add(tab);
            if (ds.Tables[TableName].HasErrors)
            {
                foreach (DataRow row in ds.Tables[TableName].Rows)
                {
                    if (row.RowError != "" && row.RowError != null)
                    {
                        DataRow Erow = tab.NewRow();
                        if (row.RowState == DataRowState.Deleted)
                        {
                            Erow[PKName] = row[PKName, DataRowVersion.Original].ToString();
                        }
                        else
                        {
                            Erow[PKName] = row[PKName].ToString();
                        }
                        Erow["Error"] = row.RowError;

                        tab.Rows.Add(Erow);
                    }
                }
            }
            return Eds;
        }
        /// <summary>
        ///  用于service端 保存数据后,将数据中的错误添加记录集中保存
        /// </summary>
        /// <param name="tb"></param>
        /// <param name="PKName"></param>
        /// <returns></returns>
        public static DataTable GetErrorInfo(DataTable tb, string PKName)
        {

            DataTable tab = new DataTable();
            tab.Columns.Add(PKName);
            tab.Columns.Add("Error");
            DataColumn[] cols = new DataColumn[] { tab.Columns[PKName] };
            tab.PrimaryKey = cols;

            if (tb.HasErrors)
            {
                foreach (DataRow row in tb.Rows)
                {
                    if (row.RowError != "" && row.RowError != null)
                    {
                        DataRow Erow = tab.NewRow();
                        if (row.RowState == DataRowState.Deleted)
                        {
                            Erow[PKName] = row[PKName, DataRowVersion.Original].ToString();
                        }
                        else
                        {
                            Erow[PKName] = row[PKName].ToString();
                        }
                        Erow["Error"] = row.RowError;

                        tab.Rows.Add(Erow);
                    }
                }
            }
            return tab;
        }
        /// <summary>
        /// 用于service端 保存数据后,将数据中的错误添加记录集中保存
        /// </summary>
        /// <param name="tb"></param>
        /// <returns></returns>
        public static DataTable GetErrorInfo(DataTable tb)
        {

            DataTable tab = new DataTable();
            string[] PKNames = new string[tb.PrimaryKey.Length];
            for (int i = 0; i < PKNames.Length; i++)
            {
                PKNames[i] = tb.PrimaryKey[i].ColumnName;
            }

            foreach (string pkname in PKNames)
            {
                tab.Columns.Add(pkname);
            }
            tab.Columns.Add("Error");
            DataColumn[] cols = new DataColumn[PKNames.Length];
            for (int i = 0; i < PKNames.Length; i++)
            {
                cols[i] = tab.Columns[PKNames[i]];
            }

            tab.PrimaryKey = cols;
            if (tb.HasErrors)
            {
                foreach (DataRow row in tb.Rows)
                {
                    if (row.RowError != "" && row.RowError != null)
                    {
                        DataRow Erow = tab.NewRow();
                        if (row.RowState == DataRowState.Deleted)
                        {
                            foreach (string pkname in PKNames)
                            {
                                Erow[pkname] = row[pkname, DataRowVersion.Original].ToString();   //主键列取值
                            }
                        }
                        else
                        {
                            foreach (string pkname in PKNames)
                            {
                                Erow[pkname] = row[pkname].ToString();							//主键列取值
                            }

                        }
                        Erow["Error"] = row.RowError;

                        tab.Rows.Add(Erow);
                    }
                }
            }
            return tab;
        }



        /// <summary>
        /// 用于service端 保存数据后,将数据中的错误添加记录集中保存，多主键
        /// </summary>
        /// <param name="ds">原始数据</param>
        /// <param name="TableName">表名称</param>
        /// <returns></returns>
        public static DataSet GetErrorInfo(DataSet ds, string TableName)
        {
            DataSet Eds = new DataSet();
            DataTable tab = new DataTable();
            string[] PKNames = new string[ds.Tables[TableName].PrimaryKey.Length];
            for (int i = 0; i < PKNames.Length; i++)
            {
                PKNames[i] = ds.Tables[TableName].PrimaryKey[i].ColumnName;
            }

            foreach (string pkname in PKNames)
            {
                tab.Columns.Add(pkname);
            }
            tab.Columns.Add("Error");
            DataColumn[] cols = new DataColumn[PKNames.Length];
            for (int i = 0; i < PKNames.Length; i++)
            {
                cols[i] = tab.Columns[PKNames[i]];
            }

            tab.PrimaryKey = cols;
            Eds.Tables.Add(tab);
            if (ds.Tables[TableName].HasErrors)
            {
                foreach (DataRow row in ds.Tables[TableName].Rows)
                {
                    if (row.RowError != "" && row.RowError != null)
                    {
                        DataRow Erow = tab.NewRow();
                        if (row.RowState == DataRowState.Deleted)
                        {
                            foreach (string pkname in PKNames)
                            {
                                Erow[pkname] = row[pkname, DataRowVersion.Original].ToString();   //主键列取值
                            }
                        }
                        else
                        {
                            foreach (string pkname in PKNames)
                            {
                                Erow[pkname] = row[pkname].ToString();							//主键列取值
                            }

                        }
                        Erow["Error"] = row.RowError;

                        tab.Rows.Add(Erow);
                    }
                }
            }
            return Eds;
        }

        /// <summary>
        /// 用户客户端，保存前清除错误信息，客户端问题
        /// </summary>
        /// <param name="ds"></param>
        /// <param name="TableName"></param>
        public static void ClearError(DataSet ds, string TableName)
        {
            if (ds.Tables[TableName].HasErrors)
            {
                foreach (DataRow row in ds.Tables[TableName].Rows)
                {
                    row.RowError = "";
                }
            }
        }
        /// <summary>
        /// 用户客户端，保存前清除错误信息，客户端问题
        /// </summary>
        /// <param name="tb"></param>
        /// <param name="TableName"></param>
        public static void ClearError(DataTable tb, string TableName)
        {
            if (tb.HasErrors)
            {
                foreach (DataRow row in tb.Rows)
                {
                    row.RowError = "";
                }
            }
        }
        /// <summary>
        /// 显示错误的数据
        /// </summary>
        /// <param name="p_Tb">原表</param>
        /// <param name="p_ErrorTb">错误表格</param>
        /// <param name="p_strPKName">主键值</param>
        public static void ShowError(DataTable p_Tb, DataTable p_ErrorTb, string p_strPKName)
        {
            try
            {
                int j = 0;
                for (int i = 0; i < p_Tb.Rows.Count; i++)
                {
                    DataRow row = p_Tb.Rows[j];
                    string strKeyValue = "";
                    if (row.RowState == DataRowState.Deleted)
                    {
                        strKeyValue = row[p_strPKName, DataRowVersion.Original].ToString();
                    }
                    else
                    {
                        strKeyValue = row[p_strPKName].ToString();
                        j++;
                    }
                    DataRow[] rows = p_ErrorTb.Select(p_strPKName + "='" + strKeyValue + "'");
                    if (rows.Length > 0)
                    {
                        row.RowError = rows[0]["Error"].ToString();
                    }
                    else
                    {
                        row.AcceptChanges();
                    }


                }


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion





    }
}
