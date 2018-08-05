using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Tiger.CoreClass.Data;


namespace Tiger.Config
{
    /// <summary>
    /// Copyright (c) 2006 *********Tiger
    /// 创建人: 
    /// 日 期:2006-0-
    ///
    /// 版 本:1.0
    /// 作用：设备管理应用程序主窗体 配置信息
    /// 模块编号：无
    /// </summary>
    public class BaseSer
    {
        /// <summary>
        /// 执行不返回数据的SQL 语句
        /// </summary>
        /// <param name="strSql">经过加密的SQL 语句</param>
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
        /// 执行查询用语句,如果执行其他SQL语句，该方法将抛出异常
        /// </summary>
        /// <param name="strSql">查询语句</param>
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
                    throw new Exception("这是一个不安全的SQL语句！");
                }

                DataSet ds = ServiceManager.GetDatabase().GetEntity(strSql, "结果");
                return ds;

            }
            catch (Exception e)
            {
                throw e;
            }
        }
        /// <summary>
        /// 根据表名称获取全部数据
        /// </summary>
        /// <param name="strTableName">表名称</param>
        /// <returns>表明对应的全部数据</returns>
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
        /// 执行返回数据集合的SQL语句
        /// </summary>
        /// <param name="strSql">经过加密SQL 语句</param>
        /// <param name="strTableName">表名称</param>
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
        /// 查询指定表中字段的模糊值信息
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
        /// 对表进行保存，不忽略错误
        /// </summary>
        /// <param name="ds">数据集</param>
        /// <param name="strTableName">表名称</param>
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
        /// 把表保存到指定的数据库中
        /// </summary>
        /// <param name="ds">数据集</param>
        /// <param name="strTableName">表的名称</param>
        /// <param name="DataBaseName">数据库的名称</param>
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
        /// 对表进行保存，忽略错误
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
        /// 保存DataSet
        /// </summary>
        /// <param name="ds">数据集</param>
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
        /// 用系统的方法保存数据集
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
        /// 获取服务器系统时间
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
        /// 获取返回的行数
        /// </summary>
        public int SelectTopCount()
        {
            try
            {
                int intCount = 0;
                string strSql = "select GROUPLISTITEM from dbo.TCONF_WORD where GROUPNAME='获取行数'";
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
