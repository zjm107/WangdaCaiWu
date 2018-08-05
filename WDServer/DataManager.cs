using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Xml;
using System.IO;

namespace Tiger.Tools
{
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
        /// 将一个数据集中的数据导入到一数据集中，并且初始化状态
        /// </summary>
        /// <param name="Sds">源数据集</param>
        /// <param name="STableName">源表名称</param>
        /// <param name="Tds">目标数据集</param>
        /// <param name="TTableName">目标表名称</param>
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
        /// 显示错误的数据
        /// </summary>
        /// <param name="p_Tb">原表</param>
        /// <param name="p_ErrorTb">错误表格</param>
        /// <param name="p_strPKName">主键值</param>
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
