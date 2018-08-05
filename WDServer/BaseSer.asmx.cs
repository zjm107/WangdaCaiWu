using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using Tiger.CoreClass.Data;

namespace WDServer
{
   
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class BaseSer : System.Web.Services.WebService
    {


        /// <summary>
        /// 执行不返回数据的SQL 语句
        /// </summary>
        /// <param name="p_strSql">经过加密的SQL 语句</param>
        [WebMethod]
        public void ExeSQL(string p_strSql)
        {
            try
            {
                Tiger.Config.BaseSer bs = new Tiger.Config.BaseSer();
                bs.ExeSQL(p_strSql);
            }
            catch (Exception ex)
            {
                throw ex;;
            }
        }

        /// <summary>
        /// 执行查询用语句,如果执行其他SQL语句，该方法将抛出异常 
        /// </summary>
        /// <param name="p_strSql"> 查询语句</param>
        /// <returns></returns>
        [WebMethod]
        public DataSet ExeSelectSQL(string p_strSql)
        {
            try
            {
                Tiger.Config.BaseSer bs = new Tiger.Config.BaseSer();
                DataSet dst = bs.ExeSelectSQL(p_strSql);
                return dst;
            }
            catch (Exception ex)
            {
                throw ex;;
            }
        }

        /// <summary>
        /// 执行返回数据集合的SQL语句 
        /// </summary>
        /// <param name="p_strSql">经过加密SQL 语句</param>
        /// <param name="p_strTableName">表名称</param>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetDataSet(string p_strSql, string p_strTableName)
        {
            try
            {
                Tiger.Config.BaseSer bs = new Tiger.Config.BaseSer();
                DataSet dst = bs.GetDataSet(p_strSql, p_strTableName);
                return dst;
            }
            catch (Exception ex)
            {
                throw ex;;
            }
        }

        /// <summary>
        /// 查询指定表中字段的模糊值信息 
        /// </summary>
        /// <param name="p_strTableName">表名称</param>
        /// <param name="p_strFindField">字段名称</param>
        /// <param name="p_strFindValue">字段所包含的内容</param>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetDataSetForField(string p_strTableName, string p_strFindField, string p_strFindValue)
        {
            try
            {
                Tiger.Config.BaseSer bs = new Tiger.Config.BaseSer();
                DataSet dst = bs.GetDataSetForField(p_strTableName, p_strFindField, p_strFindValue);
                return dst;
            }
            catch (Exception ex)
            {
                throw ex;;
            }
        }

        /// <summary>
        /// 根据表名称获取全部数据 
        /// </summary>
        /// <param name="p_strTableName">表名称</param>
        /// <returns></returns>
        [WebMethod]
        public System.Data.DataSet GetDataSetForTableName(string p_strTableName)
        {
            try
            {
                Tiger.Config.BaseSer bs = new Tiger.Config.BaseSer();
                DataSet dst = bs.GetDataSetForTableName(p_strTableName);
                return dst;
            }
            catch (Exception ex)
            {
                throw ex;;
            }
        }

        /// <summary>
        /// 获取服务器系统时间 
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public System.DateTime GetSysDate()
        {
            try
            {
                Tiger.Config.BaseSer bs = new Tiger.Config.BaseSer();
                DateTime dtm = bs.GetSysDate();
                return dtm;
            }
            catch (Exception ex)
            {
                throw ex;;
            }
        }

        /// <summary>
        /// 保存DataSet 
        /// </summary>
        /// <param name="p_ds">数据集</param>
        [WebMethod]
        public void SaveDataSet(System.Data.DataSet p_ds)
        {
            try
            {
                Tiger.Config.BaseSer bs = new Tiger.Config.BaseSer();
                bs.SaveDataSet(p_ds);
            }
            catch (Exception ex)
            {
                throw ex;;
            }
        }
        /// <summary>
        /// 保存文件DataSet
        /// </summary>
        /// <param name="p_ds"></param>
        [WebMethod]
        public void SaveFileDataSet(System.Data.DataSet p_ds)
        {
            try
            {
                var db = ServiceManager.GetDatabase("FileDB");
                db.StoreDataSet(p_ds);
            }
            catch (Exception ex)
            {
                throw ex; ;
            }
        }

        /// <summary>
        /// 用系统的方法保存数据集 
        /// </summary>
        /// <param name="p_ds">数据集</param>
        [WebMethod]
        public void SaveRDataSet(System.Data.DataSet p_ds)
        {
            try
            {
                Tiger.Config.BaseSer bs = new Tiger.Config.BaseSer();
                bs.SaveRDataSet(p_ds);
            }
            catch (Exception ex)
            {
                throw ex;;
            }
        }

        /// <summary>
        /// 对表进行保存，忽略错误 
        /// </summary>
        /// <param name="p_dst">数据集</param>
        /// <param name="p_strTableName">表名称</param>
        [WebMethod]
        public virtual DataSet SaveTableError(DataSet p_dst, string p_strTableName)
        {
            try
            {
                ServiceManager.GetDatabase().StoreTable(p_dst.Tables[p_strTableName], true);
                DataSet dstError = Tiger.Tools.DataManager.GetErrorInfo(p_dst, p_strTableName);
                return dstError;

            }
            catch (Exception ex)
            {
                throw ex;;
            }
        }
        /// <summary>
        /// 对表进行保存，或略错误
        /// </summary>
        /// <param name="ds"></param>
        /// <returns></returns>
        [WebMethod]
        public DataSet SaveTableIgnoreError(DataSet ds)
        {
            try
            {
                ServiceManager.GetDatabase().StoreTable(ds.Tables[0], true);
                DataSet tbError = Tiger.Tools.DataManager.GetErrorInfo(ds, ds.Tables[0].TableName);
                return tbError;
            }
            catch (Exception ex)
            {
                throw ex;;
            }
        }
        /// <summary>
        /// 保存表，不忽略错误
        /// </summary>
        /// <param name="table"></param>
        [WebMethod]
        public void SaveOnlyTable(DataTable table)
        {
            try
            {
                ServiceManager.GetDatabase().StoreTable(table, false);

            }
            catch (Exception ex)
            {
                throw ex;;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_dst"></param>
        /// <param name="p_strTableName"></param>
        [WebMethod]
        public virtual void SaveTable(System.Data.DataSet p_dst, string p_strTableName)
        {
            try
            {
                ServiceManager.GetDatabase().StoreTable(p_dst.Tables[p_strTableName],p_strTableName,true,false);

            }
            catch (Exception ex)
            {
                throw ex;;
            }
        }
        /// <summary>
        /// 保存通用数据表
        /// </summary>
        /// <param name="p_dst"></param>
        /// <param name="p_strTableName"></param>
        /// <returns></returns>
        [WebMethod]
        public virtual DataSet SaveCommonTableError(DataSet p_dst, string p_strTableName)
        {
            try
            {
                ServiceManager.GetDatabase().StoreTable(p_dst.Tables[p_strTableName], true);
                DataSet dstError = Tiger.Tools.DataManager.GetErrorInfo(p_dst, p_strTableName);
                return dstError;

            }
            catch (Exception ex)
            {
                throw ex;;
            }
        }

        /// <summary>
        /// 把表保存到指定的数据库中 
        /// </summary>
        /// <param name="p_ds">数据集</param>
        /// <param name="p_strTableName">表的名称</param>
        /// <param name="p_DataBaseName">数据库的名称</param>
        [WebMethod]
        public void SaveTableDataBase(System.Data.DataSet p_ds, string p_strTableName, string p_DataBaseName)
        {
            try
            {
                Tiger.Config.BaseSer bs = new Tiger.Config.BaseSer();
                bs.SaveTableDataBase(p_ds, p_strTableName, p_DataBaseName);
            }
            catch (Exception ex)
            {
                throw ex;;
            }
        }

        /// <summary>
        /// 对表进行保存，忽略错误 
        /// </summary>
        /// <param name="p_ds">数据集</param>
        /// <param name="p_strTableName">数据表名称</param>
        [WebMethod]
        public void SaveTableIError(System.Data.DataSet p_ds, string p_strTableName)
        {
            try
            {
                Tiger.Config.BaseSer bs = new Tiger.Config.BaseSer();
                bs.SaveTableIError(p_ds, p_strTableName);
            }
            catch (Exception ex)
            {
                throw ex;;
            }
        }

        /// <summary>
        /// 保存数据集中的表
        /// </summary>
        /// <param name="p_ds">数据集</param>
        /// <param name="p_strTableName">数据表名称</param>
        [WebMethod]
        public void SaveTableWithCommandBuilder(System.Data.DataSet p_ds, string p_strTableName)
        {
            try
            {
                Tiger.Config.BaseSer bs = new Tiger.Config.BaseSer();
                bs.SaveTableWithCommandBuilder(p_ds, p_strTableName);
            }
            catch (Exception ex)
            {
                throw ex;;
            }
        }

        /// <summary>
        /// 获取返回的行数 
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public int SelectTopCount()
        {
            try
            {
                Tiger.Config.BaseSer bs = new Tiger.Config.BaseSer();
                int intCount = bs.SelectTopCount();
                return intCount;
            }
            catch (Exception ex)
            {
                throw ex;;
            }
        }

        #region 扩充功能
        /// <summary>
        /// 对表/视图进行保存
        /// </summary>
        /// <param name="p_ds">数据集</param>
        /// <param name="p_strViewName">数据集中的视图名称</param>
        /// <param name="p_strTableName">数据库中的表名称</param>
        ///<param name="p_blnIgnore"></param>
        [WebMethod]
        public void SaveViewTable(System.Data.DataSet p_ds, string p_strViewName, string p_strTableName, bool p_blnIgnore)
        {
            try
            {
                ServiceManager.GetDatabase().StoreTable(p_ds.Tables[p_strViewName], p_strTableName, p_blnIgnore);
            }
            catch (Exception ex)
            {
                throw ex;;
            }
        }
        /// <summary>
        /// 根据语句获取数据集
        /// </summary>
        /// <param name="strSql">加密的</param>
        /// <param name="strTableName"></param>
        /// <param name="strDataBase"></param>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetDataBaseDataSet(string strSql, string strTableName, string strDataBase)
        {
            try
            {

                strSql = EnDecrypt.Decrypt(strSql);

                DataSet ds = ServiceManager.GetDatabase(strDataBase).GetEntity(strSql, strTableName);
                return ds;
            }
            catch (Exception e)
            {
                throw e;
            }

        }
        #endregion
    }
}

