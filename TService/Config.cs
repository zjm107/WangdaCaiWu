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
    /// 日 期: 2006-10-09
    /// 
    /// 版 本:
    /// 作用：实现对系统配置的操作。（封装了Tiger.Config）
    /// 模块编号：无
    /// </summary>
    public interface Config 
    {


        /// <summary>
        /// 版本
        /// </summary>
        /// <returns></returns>

        string GetVar();
       


        /// <summary>
        /// 获取应用程序的窗体菜单对应的窗体 
        /// </summary>
      
        /// <returns></returns>

        System.Data.DataSet GetAppMenu();
        

        /// <summary>
        /// 获取应用程序窗体的标题　
        /// </summary>
       
        /// <returns></returns>

        string GetAppTitle();
      

        /// <summary>
        /// 获取公司名称
        /// </summary>
    
        /// <returns></returns>

        string GetCompanyName();
     

        /// <summary>
        /// 保存应用程序配置信息 
        /// </summary>
        /// <param name="pAppConfig">需要保存的数据集</param>

        void SaveAppConfig(System.Data.DataSet pAppConfig);
      

        /// <summary>
        /// 保存应用程序的菜单配置 
        /// </summary>
        /// <param name="pModleData">要保存的数据集</param>

        void SaveModle(System.Data.DataSet pModleData);
       

        /// <summary>
        /// 获取全部参数类别 
        /// </summary>
    
        /// <returns>TS_SystemConfigGroup</returns>

        System.Data.DataSet GetAllParaType();
      

        /// <summary>
        /// 根据参数类别获取该类别的所有参数值
        /// </summary>
        /// <param name="p_ParaTypeID"></param>
    
        /// <returns>返回数据集, 表名称 TS_SystemConfig</returns>

        System.Data.DataSet GetParaValue(string p_ParaTypeID);
      

        /// <summary>
        /// 根据参数类别名称获取该类别的所有参数值
        /// </summary>
        /// <param name="p_ParaTypeName">参数名称</param>
     
        /// <returns>返回数据集, 表名称 TS_SystemConfig</returns>

        System.Data.DataSet GetParaValueOfName(string p_ParaTypeName);
      

        /// <summary>
        /// 保存参数表
        /// </summary>
        /// <param name="p_ds"></param>
        /// <param name="p_Tablename"></param>

        void SaveParaTable(System.Data.DataSet p_ds, string p_Tablename);
      

        /// <summary>
        /// 根据用户ID获取用户信息 
        /// </summary>
        /// <param name="p_strUserID"></param>
        /// <returns></returns>

        System.Data.DataSet GetUserInfo(string p_strUserID);


        /// <summary>
        /// 用户登录 
        /// </summary>
        /// <param name="p_strLogName">用户名</param>
        /// <param name="p_strPassword">密码</param>
    
        /// <returns></returns>

        System.Data.DataSet Login(string p_strLogName, string p_strPassword);
        


        /// <summary>
        /// 保存数据到指定的库
        /// </summary>
        /// <param name="p_ds"></param>
        /// <param name="p_strTableName"></param>
        /// <returns></returns>

        void SaveTable(System.Data.DataSet p_ds, string p_strTableName);
       

        /// <summary>
        /// 获取系统功能 
        /// </summary>
    
        /// <returns></returns>

        System.Data.DataSet GetSystemFunction();
      

        /// <summary>
        /// 获取用户在模块中的使用功能
        /// </summary>
       
        /// <param name="p_strUserID">用户ID</param>
        /// <returns>VUS_User2FunctionInfo</returns>

        System.Data.DataSet GetSystemFunctionByUser(string p_strUserID);
       

        /// <summary>
        /// 获取系统全部菜单 
        /// </summary>
       
        /// <returns>TS_Menu</returns>

        System.Data.DataSet GetSystemMenu();
       

        /// <summary>
        /// 根据父菜单获取子菜单 
        /// </summary>
        /// <param name="p_strParentMenuName">父菜单名</param>
      
        /// <returns>TS_Menu</returns>

        System.Data.DataSet GetSystemMenuByParent(string p_strParentMenuName);
       
        /// <summary>
        /// 根据用户权限获取子菜单
        /// </summary>
    
        /// <param name="p_strUserID">用户ID</param>
        /// <returns>TS_UserMenu</returns>

        System.Data.DataSet GetSystemMenubyUser( string p_strUserID);
     

        /// <summary>
        /// 获取根节点菜单 
        /// </summary>
      
        /// <param name="p_strUserID"></param>
        /// <returns></returns>

        System.Data.DataSet GetSystemRoot( string p_strUserID);
      



        /// <summary>
        /// 获取单位信息
        /// </summary>
        /// <returns></returns>

        DataSet GetCompany();       

        /// <summary>
        /// 保存单位信息
        /// </summary>
        /// <param name="dst"></param>

        void UpdateCompany(DataSet dst);
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="RegCode"></param>

        void SetSystemUsefull(string RegCode);
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>

        bool GetSystemUsefull();
        



        ///// <summary>
        ///// 保存客户端ID
        ///// </summary>
        ///// <param name="dst"></param>

        //void saveClientCode(DataSet dst);
        
        ///// <summary>
        ///// 获取客户端ID
        ///// </summary>
        ///// <returns></returns>

        //DataSet getClientCode();
       
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strSql"></param>
        /// <returns></returns>

        DataSet GetCommonDateSet(string strSql);
       
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strSql"></param>
        /// <returns></returns>

        int ExeCommonSql(string strSql);
       

    }
}

