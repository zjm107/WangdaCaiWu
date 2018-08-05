using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Tiger.CoreClass.Data;

namespace Tiger.Config
{
    /// <summary>
    ///Copyright (c) 2006-2007 *********Tiger
    /// 创建人: 赵金明
    /// 日 期: 2006-10-9
    ///
    /// 版 本:
    /// 作用：获取数据库信息，和操控查询模版
    /// 模块编号
    /// </summary>
    public class SQLDBInfo : Tiger.Config.AbsDBInfo 
    {
        /// <summary>
        /// 获取数据库中表名称
        /// </summary>
        /// <returns>TableName:表名称</returns>
        public override  DataSet GetDBTableNames(string DataBaseName)
        {
            try
            {
                string strSql = "select [name] from dbo.sysobjects where xtype='U'";
                DataSet ds = ServiceManager.GetDatabase(DataBaseName).GetEntity(strSql, "表名称");
                return ds;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// 获取数据库中视图名称
        /// </summary>
        /// <returns>视图名称</returns>
        public override DataSet GetDBViewNames(string DataBaseName)
        {
            try
            {
                string strSql = "select [name] from dbo.sysobjects where xtype='V'";
                DataSet ds = ServiceManager.GetDatabase(DataBaseName).GetEntity(strSql, "视图名称");
                return ds;
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        /// <summary>
        /// 获取公共的
        /// </summary>
        /// <returns></returns>
        public override DataSet GetPublicQueryTemp()
        {
            try
            {
                string strSql = "select * from TS_查询模板 where (模块名称 is null or 模块名称='')";
                DataSet ds = ServiceManager.GetDatabase("Tiger_COMMON").GetEntity(strSql, "TS_查询模板");
                return ds;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// 获取数据库中指定表或视图的字段名称
        /// </summary>
        /// <param name="strTableName">表或视图名称</param>
        /// <param name="DataBaseName"></param>
        /// <returns>空的表结构，表名称：字段名称</returns>
        public override DataSet GetDBFieldNames(string strTableName, string DataBaseName)
        {
            try
            {
                string strSql = "select * from " + strTableName + " where 1=2";
                DataSet ds = ServiceManager.GetDatabase(DataBaseName).GetEntity(strSql, "字段名称");
                return ds;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// 或取全部模板数据
        /// </summary>
        /// <returns></returns>
        public override DataSet GetAllQueryTemp()
        {
            try
            {
                string strSql = "select * from TS_查询模板 ";
                DataSet ds = ServiceManager.GetDatabase().GetEntity(strSql, "TS_查询模板");
                return ds;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        ///获取某一个控件的查询模板内容
        /// </summary>
        /// <param name="ControlID">控件唯一名称,包括所属Form名称</param>
        /// <returns></returns>
        public override DataSet GetQueryTemp(string ControlID)
        {
            try
            {
                string strSql = string.Format( "select * from TS_查询模板 where 控件ID='{0}'",ControlID);
                DataSet ds = ServiceManager.GetDatabase().GetEntity(strSql, "TS_查询模板");
                return ds;

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// 通过模板名称，删除模板
        /// </summary>
        /// <param name="TempName">模板名称</param>
        public override void DelQueryTemp(string TempName)
        {
            try
            {
                string strSql =string.Format( "Delete from TS_查询模板 where 名称='{0}'",TempName);
                ServiceManager.GetDatabase().ExecuteNonQuery(strSql);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// 更新查询模板
        /// </summary>
        /// <param name="strNewName">新名称</param>
        /// <param name="strNewMemo">新说明</param>
        /// <param name="strNewControlID">新控件ID</param>
        /// <param name="strNewSQL">新查询语句</param>
        /// <param name="strNewKeyField">新关键字段</param>
        /// <param name="decIsCreateForm">是否创建窗体</param>
        /// <param name="strFormClassName">窗体类名称</param>
        /// <param name="strID"></param>
        public override void UpdateQueryTemp(string strNewName, string strNewMemo, string strNewControlID, 
            string strNewSQL, string strNewKeyField, string strID, decimal decIsCreateForm, string strFormClassName)
        {
            try
            {
                string [] para = new string[] { strNewName, strNewMemo, strNewControlID, strNewSQL, strNewKeyField, strID,strFormClassName,decIsCreateForm.ToString() };
                string strSql = string.Format(" UPDATE TS_查询模板 "
                    + " SET 名称='{0}', 说明='{1}', 控件ID='{2}', 查询语句='{3}', 关键字段='{4}',模块名称='{5}',是否创建窗体={6}'"
                    + " WHERE 查询模板ID={5}", para);
                ServiceManager.GetDatabase().ExecuteNonQuery(strSql);
            }
            catch (Exception e)
            {
                throw e;
            }

        }

  /// <summary>
  /// 
  /// </summary>
  /// <param name="strNewName"></param>
  /// <param name="strNewMemo"></param>
  /// <param name="strNewControlID"></param>
  /// <param name="strNewSQL"></param>
  /// <param name="strNewKeyField"></param>
  /// <param name="strID"></param>
  /// <param name="decIsCreateForm"></param>
  /// <param name="strFormClassNam"></param>
        public override void AddQueryTemp(string strNewName, string strNewMemo, string strNewControlID, string strNewSQL, string strNewKeyField, string strID, decimal decIsCreateForm, string strFormClassNam)
        {
            try
            {
                string[] para = new string[] { strNewName, strNewMemo, strNewControlID, strNewSQL, strNewKeyField, strID ,decIsCreateForm.ToString(),strFormClassNam};
                string strSql = string.Format(" INSERT INTO TS_查询模板(名称, 说明, 控件ID, 查询语句, 关键字段,查询模板ID,是否创建窗体,模块名称) "
                            + " VALUES('{0}', '{1}','{2}','{3}','{4}','{5}',{6},'{7}')",para);
                
                ServiceManager.GetDatabase().ExecuteNonQuery(strSql );
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// 根据模块名称
        /// </summary>
        /// <param name="strFormClassName"></param>
        /// <returns></returns>
        public override DataSet GetQueryTempByFromClass(string strFormClassName)
        {
            try
            {
                string strSql = string.Format(" select * from TS_查询模板 where 模块名称='{0}'", strFormClassName);
                DataSet dst = ServiceManager.GetDatabase().GetEntity(strSql, "TS_查询模板");
                return dst;

            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}
