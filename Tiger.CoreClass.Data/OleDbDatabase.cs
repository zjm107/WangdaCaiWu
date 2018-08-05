using System;
using System.Collections;
using System.Text.RegularExpressions;
using System.Data;
using System.Data.OleDb;

namespace Tiger.CoreClass.Data
{
	/// <summary>
	/// OleDbDatabase ��ժҪ˵����
	/// </summary>
	internal class OleDbDatabase : AbsDatabase
	{
		/// <summary>
		/// ���캯��
		/// </summary>
		public OleDbDatabase(string connString)
		{
			m_conn = new OleDbConnection(connString);
		}

		/// <summary>
		/// ���DataSet
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
				throw new Exception("������ݳ���" + e.Message, e);
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
		/// ������ĵ����ݿ⣬��ָ���Ƿ���Դ��󣬿�ָ���Ƿ�ִ���ϸ񲢷����
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
