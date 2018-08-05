using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Xml;
using System.IO;

namespace Tiger.Tools
{
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
        public static void ImpDataSet(DataTable STable, DataTable TTable)
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
        public static void ImpDataSet(DataSet Sds, string STableName, DataSet Tds, string TTableName)
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
        public static DataTable  GetErrorInfo(DataTable tb)
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
        public static void ClearError(DataTable tb , string TableName)
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
        public static void ShowError(DataTable p_Tb, DataTable p_ErrorTb,string p_strPKName)
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
