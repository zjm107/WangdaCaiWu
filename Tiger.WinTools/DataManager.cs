using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.IO;

namespace Tiger.Tools
{
    /// <summary>
    /// ���ݴ�����
    /// </summary>
    public static class WindDataManager
    {
      
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



        #region �ϴ��������ݣ������ݿ����й�ϵ
        //��ṹ
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
        /// �����ļ�,Ҫ�������ֶ�["�ļ���С"][�ļ�][�ļ�����][�ļ�����]
        /// </summary>
        /// <param name="rv"> ��ӵ������У���ǰ�� </param>
        public static string UpLoadFile(DataRowView rv)
        {
            try
            {
                OpenFileDialog OFD = new OpenFileDialog();
                OFD.Filter = "�����ļ�|*.*|Word�ļ�|*.doc|Excel�ļ�|*.xls";
                if (OFD.ShowDialog() == DialogResult.Cancel)
                    return "";

                string FilePath = OFD.FileName;   //�ļ�ȫ��
                string strFileName = Path.GetFileNameWithoutExtension(FilePath);
                string ExtentName = Path.GetExtension(FilePath);   //��չ�� 

                FileStream FSFile = new FileStream(FilePath, FileMode.Open);  //����һ���ļ�������
                byte[] SFile = new byte[FSFile.Length];    //�����ֽڴ�С
                int FileSize = (int)FSFile.Length;
                if (FileSize <= 0)
                {
                    MessageBox.Show("�ļ�����ȷ�����ʵ�ļ��Ƿ���ڣ�");
                    return "";
                }

                FSFile.Read(SFile, 0, FileSize);
                FSFile.Close();



                if (rv == null)
                    return "";
                rv["�ļ���С"] = FileSize;
                rv["�ļ�"] = System.DBNull.Value;
                rv["�ļ�"] = SFile;
                rv["�ļ�����"] = ExtentName;
                rv["�ļ�����"] = strFileName;
                rv.EndEdit();


                return FilePath;
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        /// <summary>
        /// �����ļ�Ҫ,�������ֶ�["�ļ���С"][�ļ�][�ļ�����][�ļ�����]
        /// </summary>
        /// <param name="FileRow">�ļ�������</param>
        public static void DownLoadFile(DataRow FileRow)
        {
            try
            {
                SaveFileDialog aSFD = new SaveFileDialog();
                aSFD.FileName = FileRow["�ļ�����"].ToString();
                aSFD.Filter = "�����ļ�|*.*|Word�ļ�|*.doc|Excel�ļ�|*.xls";
                if (aSFD.ShowDialog() == DialogResult.OK)
                {

                    int intFileSize = Convert.ToInt32(FileRow["�ļ���С"]);
                    byte[] SFile = new byte[intFileSize];

                    if (FileRow["�ļ�"] == DBNull.Value || intFileSize <= 0)
                    {
                        MessageBox.Show("�������ļ���");
                        return;
                    }
                    Object obj = new Object();
                    obj = FileRow["�ļ�"];
                    SFile = (byte[])obj;
                    FileStream fsFile = new FileStream(aSFD.FileName + FileRow["�ļ�����"],
                        FileMode.OpenOrCreate);
                    fsFile.Write(SFile, 0, intFileSize);	//�ļ�д
                    fsFile.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


       /// <summary>
        /// ���ļ����ص���ʱĿ¼
       /// </summary>
       /// <param name="FileRow"></param>
       /// <param name="p_strAppExeName"></param>
       /// <returns></returns>
        public static string DownLoadToTemp(DataRow FileRow,string p_strAppExeName)
        {
            try
            {
                //TempInfo ���ص�����Ŀ¼��TempInfo��
                string strFilePath = GetAppPath(p_strAppExeName) + "TEMPINFO";
                string strFileName = strFilePath + "\\" + FileRow["�ļ�����"].ToString() + FileRow["�ļ�����"].ToString();
                int intFileSize = Convert.ToInt32(FileRow["�ļ���С"]);
                byte[] SFile = new byte[intFileSize];

                if (FileRow["�ļ�"] == DBNull.Value || intFileSize <= 0)
                {
                    MessageBox.Show("�������ļ�,���ܹ��򿪣�");
                    return "";
                }
                Object obj = new Object();
                obj = FileRow["�ļ�"];
                SFile = (byte[])obj;
                FileStream fsFile = new FileStream(strFileName,
                    FileMode.OpenOrCreate);
                fsFile.Write(SFile, 0, intFileSize);	//�ļ�д
                fsFile.Close();
                return strFileName;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
       /// <summary>
        /// ���������ʱ�ļ��ϴ������ݿ�
       /// </summary>
       /// <param name="rv"></param>
       /// <param name="p_strAppExeName"></param>
        public static void UpLoadFromTemp(DataRow rv, string p_strAppExeName)
        {

            try
            {
                string strFilePath = GetAppPath(p_strAppExeName) + "TEMPINFO";
                if (rv["�ļ�����"].ToString().Trim() == "")
                {
                    throw new Exception("�ļ�������ִ���");
                }
                string strFileName = strFilePath + "\\" + rv["�ļ�����"].ToString() + rv["�ļ�����"].ToString();



                FileStream FSFile = new FileStream(strFileName, FileMode.Open);  //����һ���ļ�������
                byte[] SFile = new byte[FSFile.Length];    //�����ֽڴ�С
                int FileSize = (int)FSFile.Length;
                if (FileSize <= 0)
                {
                    MessageBox.Show("�ļ�����ȷ��");
                    return;
                }

                FSFile.Read(SFile, 0, FileSize);
                FSFile.Close();

                if (rv == null)
                    return;
                rv["�ļ���С"] = FileSize;
                rv["�ļ�"] = System.DBNull.Value;
                rv["�ļ�"] = SFile;
                rv.EndEdit();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// ��ȡϵͳִ��Ŀ¼
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
        /// ɾ����ʱĿ¼���ļ�
        /// </summary>
        /// <param name="rv"></param>
        /// <param name="p_strAppExeName"></param>
        public static void DelTempFile(DataRow rv, string p_strAppExeName)
        {
            try
            {
                string strFilePath = GetAppPath(p_strAppExeName) + "TEMPINFO";
                string strFileName = strFilePath + "\\" + rv["�ļ�����"].ToString() + rv["�ļ�����"].ToString();
                File.Delete(strFileName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// ɾ����ʱĿ¼���ȫ���ļ�
        /// </summary>
        public static void DelAllTempFile(string p_strAppExeName)
        {
            try
            {
                string strFilePath = GetAppPath(p_strAppExeName) + "TEMPINFO";
                foreach (string s in Directory.GetFiles(strFilePath))
                {
                    File.Delete(s); //ɾ�����ļ�
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        #endregion 

        /// <summary>
        /// ����gridviewΪֻ��
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
        /// ����gridviewΪ��д
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
        /// ���ر����ʽ
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
                throw new Exception("������ʽ����:"+ex.Message );
            }
        }

        /// <summary>
        /// ɾ��ѡ�е���
        /// </summary>
        /// <param name="gridview"></param>
        /// <returns></returns>
        public static bool DelSelectedRows(this DevExpress.XtraGrid.Views.Grid.GridView gridview)
        {
            bool r = false;
            if (UserMessages.ShowQuestionBox("Ҫɾ��ѡ�е���ô?"))
            {
                gridview.DeleteSelectedRows();
                
                r = true;
            }
            return r;
        }


        /// <summary>
        /// ��������ʽ
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
                throw new Exception("������ʽ����" + ex.Message);
            }
        }

        /// <summary>
        /// �ָ�Ĭ����ʽ
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
                throw new Exception("������ʽ����:" + ex.Message);
            }
        }

 
        /// <summary>
        /// ����Ĭ����ʽ
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
                throw new Exception("������ʽ����" + ex.Message);
            }
        }


        /// <summary>
        /// ���ر����ʽ
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
                throw new Exception("������ʽ����:" + ex.Message);
            }
        }

        /// <summary>
        /// ��������ʽ
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
                throw new Exception("������ʽ����" + ex.Message);
            }
        }

        /// <summary>
        /// �ָ�Ĭ����ʽ
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
                throw new Exception("������ʽ����:" + ex.Message);
            }
        }


        /// <summary>
        /// ����Ĭ����ʽ
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
                throw new Exception("������ʽ����" + ex.Message);
            }
        }



        /// <summary>
        /// ���ؿؼ���ʽ
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
                throw new Exception("������ʽ����:" + ex.Message);
            }
        }

        /// <summary>
        /// ����ؼ���ʽ
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
                throw new Exception("������ʽ����" + ex.Message);
            }
        }

        /// <summary>
        /// �ָ��ؼ�Ĭ����ʽ
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
                throw new Exception("������ʽ����:" + ex.Message);
            }
        }


        /// <summary>
        /// ����ؼ�Ĭ����ʽ
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
                throw new Exception("������ʽ����" + ex.Message);
            }
        }

        /// <summary>
        /// ��ȡѡ����
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
    /// �����ݼ����й���ĳ��÷���
    /// </summary>
    public static class DataManager
    {


        /// <summary>
        /// ��һ�����ݼ��е����ݵ��뵽һ���ݼ��У����ҳ�ʼ��״̬
        /// </summary> 
        /// <param name="STable">Դ���ݼ�</param>
        /// <param name="TTable">Ŀ�����ݼ�</param>
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
        /// ��һ�����ݼ��е����ݵ��뵽һ���ݼ��У����ҳ�ʼ��״̬
        /// </summary>
        /// <param name="Sds">Դ���ݼ�</param>
        /// <param name="STableName">Դ������</param>
        /// <param name="Tds">Ŀ�����ݼ�</param>
        /// <param name="TTableName">Ŀ�������</param>
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
        #region ���ݴ�����

        /// <summary>
        /// ����service�� �������ݺ�,�������еĴ�����Ӽ�¼���б���
        /// </summary>
        /// <param name="ds">ԭʼ����</param>
        /// <param name="TableName">������</param>
        /// <param name="PKName">������</param>
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
        ///  ����service�� �������ݺ�,�������еĴ�����Ӽ�¼���б���
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
        /// ����service�� �������ݺ�,�������еĴ�����Ӽ�¼���б���
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
                                Erow[pkname] = row[pkname, DataRowVersion.Original].ToString();   //������ȡֵ
                            }
                        }
                        else
                        {
                            foreach (string pkname in PKNames)
                            {
                                Erow[pkname] = row[pkname].ToString();							//������ȡֵ
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
        /// ����service�� �������ݺ�,�������еĴ�����Ӽ�¼���б��棬������
        /// </summary>
        /// <param name="ds">ԭʼ����</param>
        /// <param name="TableName">������</param>
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
                                Erow[pkname] = row[pkname, DataRowVersion.Original].ToString();   //������ȡֵ
                            }
                        }
                        else
                        {
                            foreach (string pkname in PKNames)
                            {
                                Erow[pkname] = row[pkname].ToString();							//������ȡֵ
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
        /// �û��ͻ��ˣ�����ǰ���������Ϣ���ͻ�������
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
        /// �û��ͻ��ˣ�����ǰ���������Ϣ���ͻ�������
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
        /// ��ʾ���������
        /// </summary>
        /// <param name="p_Tb">ԭ��</param>
        /// <param name="p_ErrorTb">������</param>
        /// <param name="p_strPKName">����ֵ</param>
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
