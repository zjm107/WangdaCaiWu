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
	/// ���ݷ��ʲ�����ݿ���������࣬�����װ�����ݷ��ʲ���������Ϊ�����࣬����ʵ�������ࡣ
	/// </summary>
	public abstract class AbsDatabase
	{
		/// <summary>
		/// ���Ӷ���
		/// </summary>
		protected IDbConnection m_conn;
		/// <summary>
		/// �������
		/// </summary>
		protected IDbTransaction m_trans;
		/// <summary>
		/// ������
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
				throw new Exception("�����ݿ����ӳ���" + e.Message, e);
			}
		}
		/// <summary>
		/// �ر�����
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
				throw new Exception("�ر����ݿ����ӳ���" + e.Message, e);
			}
		}
		/// <summary>
		/// ����ʼ
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
				throw new Exception("�������ݿ��������" + e.Message, e);
			}
		}
		/// <summary>
		/// �����ύ
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
				throw new Exception("�ύ���ݿ��������" + e.Message, e);
			}
		}
		/// <summary>
		/// ����ع�
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
				throw new Exception("�ع����ݿ��������" + e.Message, e);
			}
		}		

		/// <summary>
		/// ����ڲ�ʵ�ʵ����ݿ����Ӷ���
		/// </summary>
		/// <returns>���ݿ����Ӷ���</returns>
		public IDbConnection GetRealOne()
		{
			return m_conn;
		}

		
		#region Store

		/// <summary>
		/// ����DataSet����ĵ�һ��DataTable��Ϊ�����ϰ汾������
		/// </summary>
		/// <param name="ds">����Ҫ�����DataTable��DataSet</param>
		public void Store(DataSet ds)
		{
			StoreTable(ds.Tables[0]);
		}

		/// <summary>
		/// ����DataSet�����ָ��DataTable��Ϊ�����ϰ汾������
		/// </summary>
		/// <param name="ds">����Ҫ�����DataTable��DataSet</param>
		/// <param name="tableName">����</param>
		public void Store(DataSet ds, string tableName)
		{
			StoreTable(ds.Tables[tableName], tableName);
		}	

		/// <summary>
        /// ����DataSet�����ָ��DataTable������ָ���Ƿ���Դ���Ϊ�����ϰ汾������
		/// </summary>
		/// <param name="ds">����Ҫ�����DataTable��DataSet</param>
		/// <param name="tableName">����</param>
		/// <param name="ignore">ָ���Ƿ���Դ���</param>
		public void Store(DataSet ds, string tableName, bool ignore)
		{
			StoreTable(ds.Tables[tableName], ignore);
		}

        /// <summary>
        /// ����DataSet����ָ����DataTable
        /// </summary>
        /// <param name="ds">DataSet</param>
        /// <param name="tableName">TableName</param>
        /// <param name="ignore">�Ƿ���Դ���</param>
        /// <param name="strict">�Ƿ�ִ���ϸ�Ĳ�������</param>
        public void Store(DataSet ds, string tableName, bool ignore, bool strict)
        {
            StoreTable(ds.Tables[tableName], tableName, ignore, strict);
        }

		private string GetSelectString(DataTable table, string tableName)
		{
			string strsql = "select ";
			
			DataSet entity = ServiceManager.GetEmptyEntity(this, tableName);
					
			DataTable tab = entity.Tables[0];

			//Ҫ����ı���ֶο�����������ݿ���ֶ��٣�Ҳ���Դ��ڲ������ݿ�����ֶΣ������ʱ���˵�
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
		/// ����DataTable�����ݿ⣬Ҫ��DataTable�ı��������ݿ�����ı�����ͬ
		/// </summary>
		/// <param name="table">Ҫ�����DataTable</param>
		public void StoreTable(DataTable table)
		{
			StoreTable(table, table.TableName);
		}

		/// <summary>
		/// ����DataTable�����ݿ⣬Ҫ��DataTable�ı��������ݿ�����ı�����ͬ�����Ծ���������ָ��´����Ƿ����
		/// </summary>
		/// <param name="table">Ҫ�����DataTable</param>
		/// <param name="ignore">ָʾ�Ƿ���Դ���</param>
		public void StoreTable(DataTable table, bool ignore)
		{
			StoreTable(table, table.TableName, ignore);
		}

		/// <summary>
		/// ����DataTable�����ݿ⣬���ݿ�����ı�����DataTable�ı������Բ�ͬ
		/// </summary>
		/// <param name="table">Ҫ�����DataTable</param>
		/// <param name="tableName">DataTable��Ӧ�����ݿ����</param>
		public void StoreTable(DataTable table, string tableName)
		{
			Update(table, GetSelectString(table, tableName), false, false);
		}

		/// <summary>
		/// ����DataTable�����ݿ⣬���ݿ�����ı�����DataTable�ı������Բ�ͬ�����Ծ���������ָ��´����Ƿ����
		/// </summary>
		/// <param name="table">Ҫ�����DataTable</param>
		/// <param name="tableName">DataTable��Ӧ�����ݿ����</param>
		/// <param name="ignore">ָʾ�Ƿ���Դ���</param>
		public void StoreTable(DataTable table, string tableName, bool ignore)
		{
			Update(table, GetSelectString(table, tableName), ignore, false);
		}

		/// <summary>
		/// ����DataTable�����ݿ⣬��ָ�����ݿ������ָ���Ƿ���Դ���ָ���Ƿ�ִ���ϸ�Ĳ������Ƽ��
		/// </summary>
		/// <param name="table">Ҫ�����DataTable</param>
		/// <param name="tableName">DataTable��Ӧ�����ݿ����</param>
		/// <param name="ignore">ָʾ�Ƿ���Դ���</param>
		/// <param name="strict">ָʾ�Ƿ�ִ���ϸ�Ĳ������Ƽ��</param>
		public void StoreTable(DataTable table, string tableName, bool ignore, bool strict)
		{
			Update(table, GetSelectString(table, tableName), ignore, strict);
		}

		/// <summary>
		/// ����DataSet���������DataTable�����ݿ⣬Ҫ��DataTable���������ݿ����һ��
		/// </summary>
		/// <param name="ds">Ҫ�����DataSet</param>
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
				throw new Exception("����DataSet����" + e.Message, e);
			}
		}

		/// <summary>
		/// ����DataSet���������DataTable�����ݿ⣬Ҫ��DataTable���������ݿ����һ�£����Ծ���������ָ��´����Ƿ����
		/// </summary>
		/// <param name="ds">Ҫ�����DataSet</param>
		/// <param name="ignore">ָʾ�Ƿ���Դ���</param>
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
				throw new Exception("����DataSet����" + e.Message, e);
			}
		}
		#endregion

		#region GetEntity

		/// <summary>
		/// ͨ��Select���ȡ��DataAdapter
		/// </summary>
		/// <param name="p_strSelect"></param>
		/// <returns></returns>
		public abstract IDbDataAdapter GetDataAdapter(string p_strSelect);
		/// <summary>
		/// ��ȡĳ�����������������
		/// </summary>
		/// <param name="p_tableName">����</param>
		/// <returns>����ָ�������ݵ�DataSet</returns>
		public DataSet GetEntity(string p_tableName)
		{
			DataSet ds = new DataSet();
			string strSql = "select * from " + p_tableName;
			FillEntity(strSql, ds, p_tableName);
			return ds;
		}

		/// <summary>
		/// ��ȡDataSet
		/// </summary>
		/// <param name="sqlCmd">SqlStruct����</param>
		/// <param name="strTableName">����</param>
		/// <returns>DataSet</returns>
		public DataSet GetEntity(SqlStruct sqlCmd, string strTableName)
		{
			DataSet ds = new DataSet();
            FillEntity(sqlCmd, ds, strTableName);
			return ds;
		}

		/// <summary>
		/// ��ȡDataSet
		/// </summary>
		/// <param name="strSql">SQL���</param>
		/// <param name="strTableName">����</param>
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
		/// ���DataSet
		/// </summary>
		/// <param name="sqlCmd">SqlStruct����</param>
		/// <param name="ds">������DataSet</param>
		/// <param name="strTableName">����</param>
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
		/// ���DataSet
		/// </summary>
		/// <param name="sql">���DataSetʱʹ�õ�SQL���</param>
		/// <param name="ds">������DataSet</param>
		/// <param name="strTableName">����</param>
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
		/// ִ�����ݿ����
		/// </summary>
		/// <param name="sql">Ҫִ�е�SQL���</param>
		/// <returns>����Ӱ��ļ�¼��</returns>
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
				throw new Exception(string.Format("ִ��Sql��������{0}", cmd.CommandText), e);
			}
			finally
			{
				if(m_trans == null)
					Close();
			}
		}

		/// <summary>
		/// ִ�����ݿ����
		/// </summary>
		/// <param name="sqlCmd">Ҫִ�е�SqlStruct����</param>
		/// <returns>����Ӱ��ļ�¼��</returns>
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
				throw new Exception(string.Format("ִ��Sql��������{0}", cmd.CommandText)+":"+e.Message , e);
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
		/// ִ��ֻ����һ����������ݿ����
		/// </summary>
		/// <param name="sql">SQL���</param>
		/// <returns>ִ�н��</returns>
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
				throw new Exception(string.Format("ִ��Sql��������{0}", cmd.CommandText), e);
			}
			finally
			{
				if(m_trans == null)
					Close();
			}
		}

		/// <summary>
		/// ִ��ֻ����һ����������ݿ����
		/// </summary>
		/// <param name="sqlCmd">SqlStruct����</param>
		/// <returns>ִ�н��</returns>
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
				throw new Exception(string.Format("ִ��Sql��������{0}", cmd.CommandText), e);
			}
			finally
			{
				if(m_trans == null)
					Close();
			}
		}
		#endregion

		/// <summary>
		/// Fill �������
		/// </summary>
		protected abstract void Fill(IDbCommand selcmd, DataSet ds, string tablename);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="table">�������ݵ�DataTable</param>
        /// <param name="selSql"></param>
        /// <param name="ignore"></param>
        /// <param name="strict">�Ƿ�ִ���ϸ񲢷����</param>
		protected abstract void Update(DataTable table, string selSql, bool ignore, bool strict);

        #region DeleteTable
        
        /// <summary>
        /// ɾ��һ�������������
        /// </summary>
        /// <param name="tableName">���ݿ����</param>
        public void DeleteTable(string tableName)
        {
            string sql = string.Format("Delete from {0}", tableName);
            ExecuteNonQuery(sql);
        }
        #endregion
	}
}
