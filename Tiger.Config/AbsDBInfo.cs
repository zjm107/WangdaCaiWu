using System;
namespace Tiger.Config
{
    /// <summary>
    ///Copyright (c) 2006-2007 *********Tiger
    /// 创建人: 赵金明
    /// 日 期: 2006-10-9
    /// 版 本:
    /// 作用：获取数据库信息，和操控查询模版 抽象的
    /// 模块编号
    /// </summary>
    public   abstract class AbsDBInfo
    {
        /// <summary>
        /// 获取公共查询模板
        /// </summary>
        /// <returns></returns>
        public abstract System.Data.DataSet GetPublicQueryTemp();
        /// <summary>
        /// 添加查询模板
        /// </summary>
        /// <param name="strNewName"></param>
        /// <param name="strNewMemo"></param>
        /// <param name="strNewControlID"></param>
        /// <param name="strNewSQL"></param>
        /// <param name="strNewKeyField"></param>
        /// <param name="strID"></param>
        /// <param name="decIsCreateForm">是否创建模板</param>
        /// <param name="strFormClassNam">模板类名称</param>
        public abstract  void AddQueryTemp(string strNewName, string strNewMemo, string strNewControlID, string strNewSQL, string strNewKeyField, string strID,decimal decIsCreateForm,string strFormClassNam);
        /// <summary>
        /// 通过模板名称，删除模板
        /// </summary>
        /// <param name="TempName"></param>
        public abstract void DelQueryTemp(string TempName);
        /// <summary>
        /// 或取全部模板数据
        /// </summary>
        /// <returns></returns>
        public abstract System.Data.DataSet GetAllQueryTemp();
      /// <summary>
        /// 获取数据库中指定表或视图的字段名称
      /// </summary>
      /// <param name="strTableName"></param>
      /// <param name="DataBaseName"></param>
      /// <returns></returns>
        public abstract System.Data.DataSet GetDBFieldNames(string strTableName, string DataBaseName);

        /// <summary>
        /// 根据模块名称获取其模版
        /// </summary>
        /// <param name="strFormClassName"></param>
        /// <returns></returns>
        public abstract System.Data.DataSet GetQueryTempByFromClass(string strFormClassName);
        /// <summary>
        /// 获取数据库中表名称
        /// </summary>
        /// <returns></returns>
        public abstract System.Data.DataSet GetDBTableNames(string DataBaseName);
        /// <summary>
        /// 获取数据库中视图名称
        /// </summary>
        /// <returns></returns>
        public abstract System.Data.DataSet GetDBViewNames(string DataBaseName);
        /// <summary>
        /// 获取某一个控件的查询模板内容
        /// </summary>
        /// <param name="ControlID"></param>
        /// <returns></returns>
        public abstract System.Data.DataSet GetQueryTemp(string ControlID);
        /// <summary>
        /// 更新查询模板
        /// </summary>
        /// <param name="strNewName"></param>
        /// <param name="strNewMemo"></param>
        /// <param name="strNewControlID"></param>
        /// <param name="strNewSQL"></param>
        /// <param name="strNewKeyField"></param>
        /// <param name="strID"></param>
        /// <param name="decIsCreateForm">是否创建模板</param>
        /// <param name="strFormClassNam">窗体名称</param>
        public abstract void UpdateQueryTemp(string strNewName, string strNewMemo, string strNewControlID, string strNewSQL, string strNewKeyField, string strID,decimal decIsCreateForm,string strFormClassNam);
    }
}
