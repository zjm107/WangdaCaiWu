using System;
using System.Web;
using System.Collections;
using System.Data;

namespace TService
{
    /// <summary>
    /// BasicService 的摘要说明
    /// </summary>
    /// <summary>
    /// Copyright (c) 2006-2007 *********Tiger
    /// 创建人: 彭小波
    /// 日 期: 2006-10-18
    ///
    /// 版 本:
    /// 作用：对此类的描述，可以引用系统设计中的描述
    /// 模块编号：模块编号，可以引用系统设计中的模块编号
    /// </summary>


     public interface BasicService
    {





        #region 部门管理

        /// <summary>
        /// 获取所有部门信息数据
        /// </summary>
        /// <returns></returns>

        DataSet GetAllDepartment();

        /// <summary>
        /// 获取部门信息根据部门名称数据
        /// </summary>
        /// <returns></returns>
        DataSet GetDepartmentByKey(string strName);


        /// <summary>
        /// 获取部门的根部门
        /// </summary>
        /// <returns></returns>
        DataSet GetRootDepartment();

        /// <summary>
        /// 获取下属部门信息
        /// </summary>
        /// <param name="DepartmentID"></param>
        /// <returns></returns>

        DataSet GetDepartmentByDeptID(string DepartmentID);

        /// <summary>
        /// 获取指定部门信息
        /// </summary>
        /// <param name="DepartmentID"></param>
        /// <returns></returns>
        DataSet GetDeptCurrent(string DepartmentID);


        /// <summary>
        /// 获取部门信息
        /// </summary>
        /// <param name="deptCode">部门编码</param>
        /// <param name="deptName">部门名称</param>
        /// <returns></returns>
        DataSet GetDepartmentByCodeName(string deptCode, string deptName);

        #endregion


        #region 员工信息
        /// <summary>
        /// 获取指定部门ID下员工信息。
        /// </summary>
        /// <returns></returns>
        DataSet GetUserByDept(string DepartmentID);

        /// <summary>
        /// 获取所有员工信息
        /// </summary>
        /// <returns></returns>
        DataSet GetAllEmployeeInfo();

        #endregion


        #region 用户角色，权限管理
        /// <summary>
        /// 获取所有系统功能
        /// </summary>
    
        /// <returns></returns>
        DataSet GetUserFunction();

        /// <summary>
        /// 获取系统所有的角色
        /// </summary>
        /// <returns></returns>
        DataSet GetAllUserRole();


        /// <summary>
        /// 获取一个用户所拥有的角色
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        DataSet GetUserRole(string userID);



        /// <summary>
        /// 为用户添加一个角色
        /// </summary>
        /// <param name="strUserID">用户ID</param>
        /// <param name="strRoleID">角色id</param>
   
        /// <returns></returns>
        int AddUser2Role(string strUserID, string strRoleID);



        /// <summary>
        /// 为一个用户删除角色
        /// </summary>
        /// <param name="strUserID"></param>
        /// <param name="strRoleID"></param>
        /// <returns></returns>


        int DelectUser2Role(string strUserID, string strRoleID);


        /// <summary>
        /// 获取一个角色用户系统的管理模块
        /// </summary>
        /// <param name="strRoleID"></param>
        /// <returns></returns>
        DataSet GetUserRole2Function(string strRoleID);



        /// <summary>
        /// 删除一个角色拥有分配的系统
        /// </summary>
        /// <param name="strRoleID"></param>
        /// <returns></returns>
        int DeleteUserRole2Function(string strRoleID);
        /// <summary>
        /// 根据卡号获取用户信息,顺序一次为: userid,deptid,usercode,username,deptname,deptcode
        /// </summary>
        /// <param name="p_strCardNO">卡号 </param>
        /// <returns></returns>
        string[] GetUserIDbyCardNO(string p_strCardNO);

        /// <summary>
        /// 根据用户ID获取用户信息
        /// </summary>
        /// <param name="UserID">UserID</param>
        /// <returns></returns>

        DataSet GetUserByUserID(string p_strUserID);

        #endregion

        /// <summary>
        /// 保存打印设置
        /// </summary>
        /// <param name="dst"></param>

        void SavePrintSettings(DataSet dst);

        /// <summary>
        /// 获取全部打印设置
        /// </summary>
        /// <returns></returns>

        DataSet GetAllPrintSettings();

        /// <summary>
        /// 查询打印设置
        /// </summary>
        /// <param name="modelName"></param>
        /// <returns></returns>

        DataSet GetPrintSettings(string modelName);



        /// <summary>
        /// 获取全部工作流信息
        /// </summary>
        /// <returns></returns>

        DataSet GetAllWorkFlow();

        /// <summary>
        /// 保存工作流信息
        /// </summary>
        /// <param name="dst"></param>

        void SaveWorkFlow(DataSet dst);




    }
}
