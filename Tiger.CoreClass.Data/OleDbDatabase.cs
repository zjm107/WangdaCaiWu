using System;
using System.Collections;
using System.Text.RegularExpressions;
using System.Data;
using System.Data.OleDb;

namespace Tiger.CoreClass.Data
{
	/// <summary>
	/// OleDbDatabase 的摘要说明。
	/// </summary>
	internal class OleDbDatabase : AbsDatabase
	{
		/// <summary>
		/// 构造函数
		/// </summary>
		public OleDbDatabase(string connString)
		{
			m_conn = new OleDbConnection(connString);
		}

		/// <summary>
		/// 填充DataSet
		/// </summary>
		protected override void Fill(IDbCommand selcmd, DataSet ds, string tablename)
		{
			OleDbDataAdapter m_Adapter = new OleDbDataAdapter();
			m_Adapter.SelectCommand = (OleDbCommand)selcmd;
			try
			{
				Open();
				m_Adapter.Fill(ds, tablename);				
			}
			catch(Exception e)
			{
				throw new Exception("填充数据出错：" + e.Message, e);
			}
			finally
			{
				m_Adapter.Dispose();
				if(m_trans == null)
				{
					Close();
				}
			}
		}
       
        /// <summary>
		/// 保存更改到数据库，可指定是否忽略错误，可指定是否执行严格并发检查
		/// </summary>
        protected override void Update(DataTable table, string selSql, bool ignore, bool strict)
        {
            OleDbCommand comm = new OleDbCommand(selSql, m_conn as OleDbConnection);
            comm.Transaction = m_trans as OleDbTransaction;
            bool tempTrans = false;
            if (m_trans == null)
            {
                tempTrans = true;
                this.BeginTrans();
                comm.Transaction = m_trans as OleDbTransaction;
            }

            OleDbDataAdapter adapter = new OleDbDataAdapter(comm);
            OleDbCommandBuilder cmdBuilder = new OleDbCommandBuilder(adapter);
            cmdBuilder.SetAllValues = true;
            if (!strict)
            {
                cmdBuilder.ConflictOption = ConflictOption.OverwriteChanges;
            }
            adapter.ContinueUpdateOnError = ignore;
            if (tempTrans)
            {
                try
                {
                    adapter.Update(table);
                    this.CommitTrans();
                }
                catch
                {
                    this.RollbackTrans();
                    throw;
                }
            }
            else
            {
                try
                {
                    Open();
                    adapter.Update(table);
                }
                finally
                {
                    if (m_trans == null)
                    {
                        Close();
                    }
                }
            }
        }
		public override IDbDataAdapter GetDataAdapter(string p_strSelect)
		{
			OleDbCommand command = new OleDbCommand(p_strSelect,
				this.m_conn as OleDbConnection,
				this.m_trans as OleDbTransaction);
			return new OleDbDataAdapter(command);
		}
	}
}
