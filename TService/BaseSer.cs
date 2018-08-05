using System;
using System.Web;
using System.Collections;
using System.Data;


namespace TService
{
    /// <summary>
    /// 文件名:
    /// Copyright (c) 2003-2007 *********Tiger
    /// 创建人: 邢根立
    /// 日  期: 2006-10-09
    /// 
    /// 版  本: 
    /// 作  用：实现对数据库的操作，WebService的基础类。(封装了Tiger.Config.Base)
    /// 模块编号：无
    /// </summary>
    public interface BaseSer
    {



        /// <summary>
        /// 执行不返回数据的SQL 语句
        /// </summary>
        /// <param name="p_strSql">经过加密的SQL 语句</param>

         void ExeSQL(string p_strSql);

        /// <summary>
        /// 执行查询用语句,如果执行其他SQL语句，该方法将抛出异常 
        /// </summary>
        /// <param name="p_strSql"> 查询语句</param>
        /// <returns></returns>

         DataSet ExeSelectSQL(string p_strSql);

        /// <summary>
        /// 执行返回数据集合的SQL语句 
        /// </summary>
        /// <param name="p_strSql">经过加密SQL 语句</param>
        /// <param name="p_strTableName">表名称</param>
        /// <returns></returns>

         DataSet GetDataSet(string p_strSql, string p_strTableName);

        /// <summary>
        /// 查询指定表中字段的模糊值信息 
        /// </summary>
        /// <param name="p_strTableName">表名称</param>
        /// <param name="p_strFindField">字段名称</param>
        /// <param name="p_strFindValue">字段所包含的内容</param>
        /// <returns></returns>

         DataSet GetDataSetForField(string p_strTableName, string p_strFindField, string p_strFindValue);


        /// <summary>
        /// 根据表名称获取全部数据 
        /// </summary>
        /// <param name="p_strTableName">表名称</param>
        /// <returns></returns>

         System.Data.DataSet GetDataSetForTableName(string p_strTableName);

        /// <summary>
        /// 获取服务器系统时间 
        /// </summary>
        /// <returns></returns>

         System.DateTime GetSysDate();

        /// <summary>
        /// 保存DataSet 
        /// </summary>
        /// <param name="p_ds">数据集</param>

         void SaveDataSet(System.Data.DataSet p_ds);
        /// <summary>
        /// 用系统的方法保存数据集 
        /// </summary>
        /// <param name="p_ds">数据集</param>

         void SaveRDataSet(System.Data.DataSet p_ds);
        /// <summary>
        /// 对表进行保存，忽略错误 
        /// </summary>
        /// <param name="p_dst">数据集</param>
        /// <param name="p_strTableName">表名称</param>

          DataSet SaveTableError(DataSet p_dst, string p_strTableName);

        /// <summary>
        /// 对表进行保存，或略错误
        /// </summary>
        /// <param name="ds"></param>
        /// <returns></returns>

         DataSet SaveTableIgnoreError(DataSet ds);

        /// <summary>
        /// 保存表，不忽略错误
        /// </summary>
        /// <param name="table"></param>
        /// <param name="p_strTableName"></param>

         void SaveOnlyTable(DataTable table);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_ds"></param>
        /// <param name="p_strTableName"></param>

          void SaveTable(System.Data.DataSet p_dst, string p_strTableName);

        /// <summary>
        /// 保存通用数据表
        /// </summary>
        /// <param name="p_dst"></param>
        /// <param name="p_strTableName"></param>
        /// <returns></returns>

          DataSet SaveCommonTableError(DataSet p_dst, string p_strTableName);
        /// <summary>
        /// 把表保存到指定的数据库中 
        /// </summary>
        /// <param name="p_ds">数据集</param>
        /// <param name="p_strTableName">表的名称</param>
        /// <param name="p_DataBaseName">数据库的名称</param>

         void SaveTableDataBase(System.Data.DataSet p_ds, string p_strTableName, string p_DataBaseName);

        /// <summary>
        /// 对表进行保存，忽略错误 
        /// </summary>
        /// <param name="p_ds">数据集</param>
        /// <param name="p_strTableName">数据表名称</param>

         void SaveTableIError(System.Data.DataSet p_ds, string p_strTableName);

        /// <summary>
        /// 保存数据集中的表
        /// </summary>
        /// <param name="p_ds">数据集</param>
        /// <param name="p_strTableName">数据表名称</param>

         void SaveTableWithCommandBuilder(System.Data.DataSet p_ds, string p_strTableName);


        /// <summary>
        /// 获取返回的行数 
        /// </summary>
        /// <returns></returns>

         int SelectTopCount();

        #region 扩充功能
        /// <summary>
        /// 对表/视图进行保存
        /// </summary>
        /// <param name="p_ds">数据集</param>
        /// <param name="p_strViewName">数据集中的视图名称</param>
        /// <param name="p_strTableName">数据库中的表名称</param>

         void SaveViewTable(System.Data.DataSet p_ds, string p_strViewName, string p_strTableName, bool p_blnIgnore);
        /// <summary>
        /// 根据语句获取数据集
        /// </summary>
        /// <param name="strSql">加密的</param>
        /// <param name="strTableName"></param>
        /// <param name="strDataBase"></param>
        /// <returns></returns>

         DataSet GetDataBaseDataSet(string strSql, string strTableName, string strDataBase);

        #endregion
    }
}

