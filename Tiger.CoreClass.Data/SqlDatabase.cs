using System;
using System.Data;
using System.Collections;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace Tiger.CoreClass.Data
{
    /// <summary>
    /// SqlDatabase ��ժҪ˵����
    /// </summary>
    internal class SqlDatabase : AbsDatabase
    {
        /// <summary>
        /// ���캯��
        /// </summary>
        public SqlDatabase(string connString)
        {
            m_conn = new SqlConnection(connString);
        }

        /// <summary>
        /// ���DataSet
        /// </summary>
        protected override void Fill(IDbCommand selcmd, DataSet ds, string tablename)
        {
            SqlDataAdapter m_Adapter = new SqlDataAdapter();
            m_Adapter.SelectCommand = (SqlCommand)selcmd;
            try
            {
                Open();
                m_Adapter.Fill(ds, tablename);
            }
            catch (Exception e)
            {
                throw new Exception("������ݳ���" + e.Message, e);
            }
            finally
            {
                m_Adapter.Dispose();
                if (m_trans == null)
                {
                    Close();
                }
            }
        }

        public override IDbDataAdapter GetDataAdapter(string p_strSelect)
        {
            SqlCommand command = new SqlCommand(p_strSelect,
                this.m_conn as SqlConnection,
                this.m_trans as SqlTransaction);
            return new SqlDataAdapter(command);
        }
       
        /// <summary>
        /// ������ĵ����ݿ⣬��ָ���Ƿ���Դ��󣬿�ָ���Ƿ�ִ���ϸ񲢷����
        /// </summary>
        protected override void Update(DataTable table, string selSql, bool ignore, bool strict)
        {
            SqlCommand comm = new SqlCommand(selSql, m_conn as SqlConnection);
            comm.Transaction = m_trans as SqlTransaction;
            bool tempTrans = false;
            if (m_trans == null)
            {
                tempTrans = true;
                this.BeginTrans();
                comm.Transaction = m_trans as SqlTransaction;
            }

            SqlDataAdapter adapter = new SqlDataAdapter(comm);
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adapter);
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
    }
}
