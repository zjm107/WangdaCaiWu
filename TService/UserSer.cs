using System;
using System.Web;
using System.Collections;
using System.Data;

namespace TService
{
    /// <summary>
    /// 文件名:UserSer.cs
    /// Copyright (c) 2003-2007 *********Tiger
    /// 创建人: 邢根立
    /// 日  期: 2006-10-14
    /// 
    /// 版  本: 
    /// 作  用：实现对用户／部门操作。
    /// 模块编号：无
    /// </summary>
    public interface UserSer
    {


        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <returns></returns>
        DataSet GetUserAll();

        /// <summary>
        /// 根据工资类别获取薪水
        /// </summary>
        /// <param name="SalaryType"></param>
        /// <returns></returns>
        DataSet GetUserBySalaryType(string SalaryType);

        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <returns></returns>
        DataSet GetUsers();


        /// <summary>
        /// 获取最大编号
        /// </summary>
        /// <returns></returns>
        int GetMaxNO();

        /// <summary>
        /// 重新编排员工顺序号
        /// </summary>
        void ChangeEmployee();
        /// <summary>
        /// 获取部门信息
        /// </summary>
        /// <returns></returns>
        DataSet GetDeptAll();
        /// <summary>
        /// 获取部门信息
        /// </summary>
        /// <returns></returns>
        DataSet GetDept();
    }
}

