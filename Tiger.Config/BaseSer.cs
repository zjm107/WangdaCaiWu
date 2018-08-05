using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Tiger.CoreClass.Data;


namespace Tiger.Config
{
    /// <summary>
    /// Copyright (c) 2006 *********Tiger
    /// ������: 
    /// �� ��:2006-0-
    ///
    /// �� ��:1.0
    /// ���ã��豸����Ӧ�ó��������� ������Ϣ
    /// ģ���ţ���
    /// </summary>
    public class BaseSer
    {
        /// <summary>
        /// ִ�в��������ݵ�SQL ���
        /// </summary>
        /// <param name="strSql">�������ܵ�SQL ���</param>
        public void ExeSQL(string strSql)
        {
            try
            {

                strSql = EnDecrypt.Decrypt(strSql);

                ServiceManager.GetDatabase().ExecuteNonQuery(strSql);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// ִ�в�ѯ�����,���ִ������SQL��䣬�÷������׳��쳣
        /// </summary>
        /// <param name="strSql">��ѯ���</param>
        /// <returns></returns>
        public DataSet ExeSelectSQL(string strSql)
        {
            try
            {
                strSql = EnDecrypt.Decrypt(strSql);
                if (strSql.ToUpper().IndexOf("DELETE") > -1 || strSql.ToUpper().IndexOf("UPDATE") > -1
                    || strSql.ToUpper().IndexOf("CREATE") > -1 || strSql.ToUpper().IndexOf("DROP") > -1
                    || strSql.ToUpper().IndexOf("EXEC") > -1)
                {
                    throw new Exception("����һ������ȫ��SQL��䣡");
                }

                DataSet ds = ServiceManager.GetDatabase().GetEntity(strSql, "���");
                return ds;

            }
            catch (Exception e)
            {
                throw e;
            }
        }
        /// <summary>
        /// ���ݱ����ƻ�ȡȫ������
        /// </summary>
        /// <param name="strTableName">������</param>
        /// <returns>������Ӧ��ȫ������</returns>
        public DataSet GetDataSetForTableName(string strTableName)
        {
            try
            {
                string strSql = "select * from " + EnDecrypt.Decrypt(strTableName);
                DataSet ds = ServiceManager.GetDatabase().GetEntity(strSql, EnDecrypt.Decrypt(strTableName));
                return ds;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// ִ�з������ݼ��ϵ�SQL���
        /// </summary>
        /// <param name="strSql">��������SQL ���</param>
        /// <param name="strTableName">������</param>
        /// <returns></returns>
        public DataSet GetDataSet(string strSql, string strTableName)
        {
            try
            {

                strSql = EnDecrypt.Decrypt(strSql);

                DataSet ds = ServiceManager.GetDatabase().GetEntity(strSql, strTableName);
                return ds;
            }
            catch (Exception e)
            {
                throw e;
            }

        }
        /// <summary>
        /// ��ѯָ�������ֶε�ģ��ֵ��Ϣ
        /// </summary>
        /// <param name="strTableName"></param>
        /// <param name="strFindField"></param>
        /// <param name="strFindValue"></param>
        /// <returns></returns>
        public DataSet GetDataSetForField(string strTableName, string strFindField, string strFindValue)
        {
            try
            {
                string strSql = "select * from " + strTableName + " where " + strFindField + " like %" + strFindValue + "%";
                DataSet ds = ServiceManager.GetDatabase().GetEntity(strSql, strTableName);
                return ds;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// �Ա���б��棬�����Դ���
        /// </summary>
        /// <param name="ds">���ݼ�</param>
        /// <param name="strTableName">������</param>
        public virtual void SaveTable(DataSet ds, string strTableName)
        {
            try
            {
                ServiceManager.GetDatabase().StoreTable(ds.Tables[strTableName], false);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        /// <summary>
        /// �ѱ��浽ָ�������ݿ���
        /// </summary>
        /// <param name="ds">���ݼ�</param>
        /// <param name="strTableName">�������</param>
        /// <param name="DataBaseName">���ݿ������</param>
        public void SaveTableDataBase(DataSet ds, string strTableName, string DataBaseName)
        {
            try
            {
                ServiceManager.GetDatabase(DataBaseName).StoreTable(ds.Tables[strTableName], false);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ds"></param>
        /// <param name="strTableName"></param>
        public void SaveTableWithCommandBuilder(DataSet ds, string strTableName)
        {
            try
            {
                ServiceManager.GetDatabase().StoreTable(ds.Tables[strTableName], strTableName, false, true);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// �Ա���б��棬���Դ���
        /// </summary>
        /// <param name="ds"></param>
        /// <param name="strTableName"></param>
        public void SaveTableIError(DataSet ds, string strTableName)
        {
            try
            {
                ServiceManager.GetDatabase().StoreTable(ds.Tables[strTableName], true);
            }
            catch (Exception e)
            {
                throw e;
            }
        }




        /// <summary>
        /// ����DataSet
        /// </summary>
        /// <param name="ds">���ݼ�</param>
        public void SaveDataSet(DataSet ds)
        {
            try
            {
                ServiceManager.GetDatabase().StoreDataSet(ds);
            }
            catch (Exception e)
            {
                throw e;
            }
        }



        /// <summary>
        /// ��ϵͳ�ķ����������ݼ�
        /// </summary>
        /// <param name="ds"></param>
        public void SaveRDataSet(DataSet ds)
        {
            try
            {
                ServiceManager.GetDatabase().StoreDataSet(ds, true);
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        /// <summary>
        /// ��ȡ������ϵͳʱ��
        /// </summary>
        /// <returns></returns>
        public DateTime GetSysDate()
        {
            try
            {
                return DateTime.Now;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// ��ȡ���ص�����
        /// </summary>
        public int SelectTopCount()
        {
            try
            {
                int intCount = 0;
                string strSql = "select GROUPLISTITEM from dbo.TCONF_WORD where GROUPNAME='��ȡ����'";
                DataSet ds = ServiceManager.GetDatabase().GetEntity(strSql, "TCONF_WORD");
                if (ds.Tables["TCONF_WORD"].Rows.Count != 0)
                {
                    intCount = Convert.ToInt32(ds.Tables["TCONF_WORD"].Rows[0][0].ToString());
                }
                return intCount;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
