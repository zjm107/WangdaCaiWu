using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Data.OracleClient;
using System.Data.Common;
using System.Collections.Generic;
namespace Tiger.CoreClass.Data
{
	/// <summary>
	/// 数据访问层的数据库操作核心类，该类封装了数据访问操作，该类为抽象类，不能实例化此类。
	/// </summary>
	public abstract class AbsDatabase
	{
		/// <summary>
		/// 连接对象
		/// </summary>
		protected IDbConnection m_conn;
		/// <summary>
		/// 事务对象
		/// </summary>
		protected IDbTransaction m_trans;
		/// <summary>
		/// 打开连接
		/// </summary>
		protected void Open()
		{
			try
			{
				if( m_conn.State != ConnectionState.Open)
				{
					m_conn.Open();
				}
			}
			catch(Exception e)
			{
				throw new Exception("打开数据库连接出错：" + e.Message, e);
			}
		}
		/// <summary>
		/// 关闭连接
		/// </summary>
		protected void Close()
		{
			try
			{
				if( m_conn.State != ConnectionState.Closed)
				{
					m_conn.Close();
				}
			}
			catch(Exception e)
			{
				throw new Exception("关闭数据库连接出错：" + e.Message, e);
			}
		}
		/// <summary>
		/// 事务开始
		/// </summary>
		public void BeginTrans()
		{
			try
			{
				Open();
				m_trans = m_conn.BeginTransaction();
			}
			catch(Exception e)
			{
				throw new Exception("启动数据库事务出错：" + e.Message, e);
			}
		}
		/// <summary>
		/// 事务提交
		/// </summary>
		public void CommitTrans()
		{
			try
			{
				m_trans.Commit();
				m_trans = null;
				Close();
			}
			catch(Exception e)
			{
				throw new Exception("提交数据库事务出错：" + e.Message, e);
			}
		}
		/// <summary>
		/// 事务回滚
		/// </summary>
		public void RollbackTrans()
		{
			try
			{
				m_trans.Rollback();
				m_trans = null;
				Close();
			}
			catch(Exception e)
			{
				throw new Exception("回滚数据库事务出错：" + e.Message, e);
			}
		}		

		/// <summary>
		/// 获得内部实际的数据库连接对象
		/// </summary>
		/// <returns>数据库连接对象</returns>
		public IDbConnection GetRealOne()
		{
			return m_conn;
		}

		
		#region Store

		/// <summary>
		/// 保存DataSet里面的第一个DataTable。为兼容老版本而保留
		/// </summary>
		/// <param name="ds">包含要保存的DataTable的DataSet</param>
		public void Store(DataSet ds)
		{
			StoreTable(ds.Tables[0]);
		}

		/// <summary>
		/// 保存DataSet里面的指定DataTable。为兼容老版本而保留
		/// </summary>
		/// <param name="ds">包含要保存的DataTable的DataSet</param>
		/// <param name="tableName">表名</param>
		public void Store(DataSet ds, string tableName)
		{
			StoreTable(ds.Tables[tableName], tableName);
		}	

		/// <summary>
        /// 保存DataSet里面的指定DataTable，可以指定是否忽略错误。为兼容老版本而保留
		/// </summary>
		/// <param name="ds">包含要保存的DataTable的DataSet</param>
		/// <param name="tableName">表名</param>
		/// <param name="ignore">指定是否忽略错误</param>
		public void Store(DataSet ds, string tableName, bool ignore)
		{
			StoreTable(ds.Tables[tableName], ignore);
		}

        /// <summary>
        /// 保存DataSet里面指定的DataTable
        /// </summary>
        /// <param name="ds">DataSet</param>
        /// <param name="tableName">TableName</param>
        /// <param name="ignore">是否忽略错误</param>
        /// <param name="strict">是否执行严格的并发控制</param>
        public void Store(DataSet ds, string tableName, bool ignore, bool strict)
        {
            StoreTable(ds.Tables[tableName], tableName, ignore, strict);
        }

		private string GetSelectString(DataTable table, string tableName)
		{
			string strsql = "select ";
			
			DataSet entity = ServiceManager.GetEmptyEntity(this, tableName);
					
			DataTable tab = entity.Tables[0];

			//要保存的表的字段可以允许比数据库表字段少，也可以存在不在数据库里的字段，保存的时候滤掉
			for(int i = 0; i < table.Columns.Count; i++)
			{
				string colName = table.Columns[i].ColumnName.Trim();
				if(tab.Columns.Contains(colName))
				{
					strsql += colName + ", ";
				}
			}	
			strsql = strsql.TrimEnd(',', ' ');
			strsql += " from " + tableName.Trim();
			return strsql;
		}
	
		/// <summary>
		/// 保存DataTable到数据库，要求DataTable的表名和数据库里面的表名相同
		/// </summary>
		/// <param name="table">要保存的DataTable</param>
		public void StoreTable(DataTable table)
		{
			StoreTable(table, table.TableName);
		}

		/// <summary>
		/// 保存DataTable到数据库，要求DataTable的表名和数据库里面的表名相同，可以决定如果出现更新错误，是否忽略
		/// </summary>
		/// <param name="table">要保存的DataTable</param>
		/// <param name="ignore">指示是否忽略错误</param>
		public void StoreTable(DataTable table, bool ignore)
		{
			StoreTable(table, table.TableName, ignore);
		}

		/// <summary>
		/// 保存DataTable到数据库，数据库里面的表名和DataTable的表名可以不同
		/// </summary>
		/// <param name="table">要保存的DataTable</param>
		/// <param name="tableName">DataTable对应的数据库表名</param>
		public void StoreTable(DataTable table, string tableName)
		{
			Update(table, GetSelectString(table, tableName), false, false);
		}

		/// <summary>
		/// 保存DataTable到数据库，数据库里面的表名和DataTable的表名可以不同，可以决定如果出现更新错误，是否忽略
		/// </summary>
		/// <param name="table">要保存的DataTable</param>
		/// <param name="tableName">DataTable对应的数据库表名</param>
		/// <param name="ignore">指示是否忽略错误</param>
		public void StoreTable(DataTable table, string tableName, bool ignore)
		{
			Update(table, GetSelectString(table, tableName), ignore, false);
		}

		/// <summary>
		/// 保存DataTable到数据库，可指定数据库表名，指定是否忽略错误，指定是否执行严格的并发控制检查
		/// </summary>
		/// <param name="table">要保存的DataTable</param>
		/// <param name="tableName">DataTable对应的数据库表名</param>
		/// <param name="ignore">指示是否忽略错误</param>
		/// <param name="strict">指示是否执行严格的并发控制检查</param>
		public void StoreTable(DataTable table, string tableName, bool ignore, bool strict)
		{
			Update(table, GetSelectString(table, tableName), ignore, strict);
		}

		/// <summary>
		/// 保存DataSet里面的所有DataTable到数据库，要求DataTable表名和数据库表名一致
		/// </summary>
		/// <param name="ds">要保存的DataSet</param>
		public void StoreDataSet(DataSet ds)
		{
			BeginTrans();
			try
			{
				foreach(DataTable table in ds.Tables)
				{
					StoreTable(table);
				}
				CommitTrans();
			}
			catch(Exception e)
			{
				RollbackTrans();
				throw new Exception("保存DataSet出错：" + e.Message, e);
			}
		}

		/// <summary>
		/// 保存DataSet里面的所有DataTable到数据库，要求DataTable表名和数据库表名一致，可以决定如果出现更新错误，是否忽略
		/// </summary>
		/// <param name="ds">要保存的DataSet</param>
		/// <param name="ignore">指示是否忽略错误</param>
		public void StoreDataSet(DataSet ds, bool ignore)
		{
			BeginTrans();
			try
			{
				foreach(DataTable table in ds.Tables)
				{
					StoreTable(table, ignore);
				}
				CommitTrans();
			}
			catch(Exception e)
			{
				RollbackTrans();
				throw new Exception("保存DataSet出错：" + e.Message, e);
			}
		}
		#endregion

		#region GetEntity

		/// <summary>
		/// 通过Select语句取得DataAdapter
		/// </summary>
		/// <param name="p_strSelect"></param>
		/// <returns></returns>
		public abstract IDbDataAdapter GetDataAdapter(string p_strSelect);
		/// <summary>
		/// 获取某个表里面的所有数据
		/// </summary>
		/// <param name="p_tableName">表名</param>
		/// <returns>包含指定表数据的DataSet</returns>
		public DataSet GetEntity(string p_tableName)
		{
			DataSet ds = new DataSet();
			string strSql = "select * from " + p_tableName;
			FillEntity(strSql, ds, p_tableName);
			return ds;
		}

		/// <summary>
		/// 获取DataSet
		/// </summary>
		/// <param name="sqlCmd">SqlStruct对象</param>
		/// <param name="strTableName">表名</param>
		/// <returns>DataSet</returns>
		public DataSet GetEntity(SqlStruct sqlCmd, string strTableName)
		{
			DataSet ds = new DataSet();
            FillEntity(sqlCmd, ds, strTableName);
			return ds;
		}

		/// <summary>
		/// 获取DataSet
		/// </summary>
		/// <param name="strSql">SQL语句</param>
		/// <param name="strTableName">表名</param>
		/// <returns>DataSet</returns>
		public DataSet GetEntity(string strSql, string strTableName)
		{
			DataSet ds = new DataSet();
			FillEntity(strSql, ds, strTableName);
			return ds;
		}
		#endregion

		#region FillEntity
		/// <summary>
		/// 填充DataSet
		/// </summary>
		/// <param name="sqlCmd">SqlStruct对象</param>
		/// <param name="ds">被填充的DataSet</param>
		/// <param name="strTableName">表名</param>
		public void FillEntity(SqlStruct sqlCmd, DataSet ds, string strTableName)
		{
			IDbCommand cmd = m_conn.CreateCommand();
			cmd.Transaction = m_trans;
			cmd.CommandType = sqlCmd.CommandType;
			cmd.CommandText = sqlCmd.SqlString;

            if (sqlCmd.Param != null)
            {
                foreach (string s in sqlCmd.Param.Keys)
                {
                    IDbDataParameter parameter = cmd.CreateParameter();
                    parameter.ParameterName = s;
                    parameter.Value = sqlCmd.Param[s];
                    cmd.Parameters.Add(parameter);
                }
            }
			Fill(cmd, ds, strTableName);
		}


		/// <summary>
		/// 填充DataSet
		/// </summary>
		/// <param name="sql">填充DataSet时使用的SQL语句</param>
		/// <param name="ds">被填充的DataSet</param>
		/// <param name="strTableName">表名</param>
		public void FillEntity(string sql, DataSet ds, string strTableName)
		{
			IDbCommand cmd = m_conn.CreateCommand();
			cmd.Transaction = m_trans;
			cmd.CommandType = CommandType.Text;
			cmd.CommandText = sql;
			Fill(cmd, ds, strTableName);
		}
		#endregion
		
		#region ExecuteNonQuery
		/// <summary>
		/// 执行数据库操作
		/// </summary>
		/// <param name="sql">要执行的SQL语句</param>
		/// <returns>操作影响的记录数</returns>
		public int ExecuteNonQuery(string sql)
		{
			Open();
			IDbCommand cmd = m_conn.CreateCommand();
			cmd.CommandType = CommandType.Text;
			cmd.CommandText = sql;

			try
			{
				cmd.Transaction = m_trans;
                int res = 0;
                if (m_trans == null)
                {
                    try
                    {
                        BeginTrans();
                        cmd.Transaction = m_trans;
                        res = cmd.ExecuteNonQuery();
                        CommitTrans();
                    }
                    catch
                    {
                        RollbackTrans();
                        throw;
                    }
                }
                else
                {
                    res = cmd.ExecuteNonQuery();
                }
				return res;
			}
			catch(Exception e)
			{
				throw new Exception(string.Format("执行Sql语句出错——{0}", cmd.CommandText), e);
			}
			finally
			{
				if(m_trans == null)
					Close();
			}
		}

		/// <summary>
		/// 执行数据库操作
		/// </summary>
		/// <param name="sqlCmd">要执行的SqlStruct对象</param>
		/// <returns>操作影响的记录数</returns>
		public int ExecuteNonQuery(SqlStruct sqlCmd)
		{
			Open();
			IDbCommand cmd = m_conn.CreateCommand();
			cmd.CommandType = CommandType.Text;
			cmd.CommandText = sqlCmd.SqlString;

            if (sqlCmd.Param != null)
            {
                foreach (string s in sqlCmd.Param.Keys)
                {
                    IDbDataParameter parameter = cmd.CreateParameter();
                    parameter.ParameterName = s;
                    parameter.Value = sqlCmd.Param[s];
                    cmd.Parameters.Add(parameter);
                }
            }
			try
			{
				cmd.Transaction = m_trans;
                int res = 0;
                if (m_trans == null)
                {
                    try
                    {
                        BeginTrans();
                        cmd.Transaction = m_trans;
                        res = cmd.ExecuteNonQuery();
                        CommitTrans();
                    }
                    catch
                    {
                        RollbackTrans();
                        throw;
                    }
                }
                else
                {
                    res = cmd.ExecuteNonQuery();
                }
				return res; 
			}
			catch(Exception e)
			{
				throw new Exception(string.Format("执行Sql语句出错——{0}", cmd.CommandText)+":"+e.Message , e);
			}
			finally
			{
				if(m_trans==null)
					Close();
			}
		}
		#endregion

		#region ExecuteScalar
		/// <summary>
		/// 执行只返回一个结果的数据库操作
		/// </summary>
		/// <param name="sql">SQL语句</param>
		/// <returns>执行结果</returns>
		public object ExecuteScalar(string sql)
		{
			Open();
			IDbCommand cmd = m_conn.CreateCommand();
			cmd.CommandType = CommandType.Text;
			cmd.CommandText = sql;
			
			try
			{
				cmd.Transaction = m_trans;
                object res = null;
                if (m_trans == null)
                {
                    try
                    {
                        BeginTrans();
                        cmd.Transaction = m_trans;
                        res = cmd.ExecuteScalar();
                        CommitTrans();
                    }
                    catch
                    {
                        RollbackTrans();
                        throw;
                    }
                }
                else
                {
                    res = cmd.ExecuteScalar();
                }
				return res;
			}
			catch(Exception e)
			{
				throw new Exception(string.Format("执行Sql语句出错——{0}", cmd.CommandText), e);
			}
			finally
			{
				if(m_trans == null)
					Close();
			}
		}

		/// <summary>
		/// 执行只返回一个结果的数据库操作
		/// </summary>
		/// <param name="sqlCmd">SqlStruct对象</param>
		/// <returns>执行结果</returns>
        public object ExecuteScalar(SqlStruct sqlCmd)
		{
			Open();

			IDbCommand cmd = m_conn.CreateCommand();
			cmd.CommandType = sqlCmd.CommandType;
			cmd.CommandText = sqlCmd.SqlString;

            if (sqlCmd.Param != null)
            {
                foreach (string s in sqlCmd.Param.Keys)
                {
                    IDbDataParameter parameter = cmd.CreateParameter();
                    parameter.ParameterName = s;
                    parameter.Value = sqlCmd.Param[s];
                    cmd.Parameters.Add(parameter);
                }
            }
			try
			{
				cmd.Transaction = m_trans;
                object res = null;
                if (m_trans == null)
                {
                    try
                    {
                        BeginTrans();
                        cmd.Transaction = m_trans;
                        res = cmd.ExecuteScalar();
                        CommitTrans();
                    }
                    catch
                    {
                        RollbackTrans();
                        throw;
                    }
                }
                else
                {
                    res = cmd.ExecuteScalar();
                }
                return res;
			}
			catch(Exception e)
			{
				throw new Exception(string.Format("执行Sql语句出错——{0}", cmd.CommandText), e);
			}
			finally
			{
				if(m_trans == null)
					Close();
			}
		}
		#endregion

		/// <summary>
		/// Fill 填充数据
		/// </summary>
		protected abstract void Fill(IDbCommand selcmd, DataSet ds, string tablename);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="table">包含数据的DataTable</param>
        /// <param name="selSql"></param>
        /// <param name="ignore"></param>
        /// <param name="strict">是否执行严格并发检查</param>
		protected abstract void Update(DataTable table, string selSql, bool ignore, bool strict);

        #region DeleteTable
        
        /// <summary>
        /// 删除一个表的所有数据
        /// </summary>
        /// <param name="tableName">数据库表名</param>
        public void DeleteTable(string tableName)
        {
            string sql = string.Format("Delete from {0}", tableName);
            ExecuteNonQuery(sql);
        }
        #endregion
	}
}
