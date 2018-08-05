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
    public class BasicService : System.Web.Services.WebService
    {


        /// <summary>
        /// ��ȡ������Ϣ
        /// </summary>
        /// <param name="deptCode">���ű���</param>
        /// <param name="deptName">��������</param>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetDepartmentByCodeName(string deptName)
        {
            try
            {
                string strSql = "select * from TCOM_DEPT where 1=1";

                if (deptName != "")
                {
                    strSql += " and deptname='" + deptName + "'";
                }
                return ServiceManager.GetDatabase().GetEntity(strSql, "TCOM_DEPT");
            }
            catch (Exception ex)
            {
                throw ex; ;
            }
        }

        /// <summary>
        /// ��������ȡ���ݼ�
        /// </summary>
        /// <param name="strSql">���ܵ�</param>
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

        #region ���Ź���

        /// <summary>
        /// ��ȡ���в�����Ϣ����
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetAllDepartment()
        {
            try
            {
                string strSql = "select * from vub_dept";
                DataSet ds = ServiceManager.GetDatabase().GetEntity(strSql, "TCOM_DEPT");
                return ds;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        /// <summary>
        /// ��ȡ������Ϣ���ݲ�����������
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetDepartmentByKey(string strName)
        {
            try
            {
                string strSql = "select * from vub_dept where 1=1";
                if (strName != "")
                {
                    strSql += " and  deptname like '%" + strName + "%'";
                }

                DataSet ds = ServiceManager.GetDatabase().GetEntity(strSql, "TCOM_DEPT");
                return ds;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// ��ȡ���ŵĸ�����
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetRootDepartment()
        {
            try
            {
                string strSql = @"SELECT * FROM  vub_dept  WHERE  parentdeptid  ='" + "0" + "'";
                DataSet ds = ServiceManager.GetDatabase().GetEntity(strSql, "TCOM_DEPT");
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;;
            }

        }
        /// <summary>
        /// ��ȡ����������Ϣ
        /// </summary>
        /// <param name="DepartmentID"></param>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetDepartmentByDeptID(string DepartmentID)
        {
            try
            {
                string strSql = @"SELECT * FROM  vub_dept  WHERE parentdeptid ='" + DepartmentID + "'";
                DataSet ds = ServiceManager.GetDatabase().GetEntity(strSql, "TCOM_DEPT");
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;;
            }
        }
        /// <summary>
        /// ��ȡָ��������Ϣ
        /// </summary>
        /// <param name="DepartmentID"></param>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetDeptCurrent(string DepartmentID)
        {
            try
            {
                string strSql = "select * from vub_dept where deptid= '" + DepartmentID + "'";
                DataSet ds = ServiceManager.GetDatabase().GetEntity(strSql, "TCOM_DEPT");
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;;
            }
        }
        
        #endregion


        #region Ա����Ϣ
        /// <summary>
        /// ��ȡָ������ID��Ա����Ϣ��
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetUserByDept(string DepartmentID)
        {
            try
            {
                string strSql = "select * from TCOM_USER where Enable=0 and deptid='" + DepartmentID + "'";
                DataSet ds = ServiceManager.GetDatabase().GetEntity(strSql, "TCOM_USER");
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;;
            }
        }
        /// <summary>
        /// ��ȡ����Ա����Ϣ
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetAllEmployeeInfo()
        {
            try
            {

                string strSql = "select * from TCOM_USER order by SEQNO";
                DataSet ds = ServiceManager.GetDatabase().GetEntity(strSql, "TCOM_USER");
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;;
            }
        }

        /// <summary>
        /// ����Ա������ȡԱ����Ϣ
        /// </summary>
        /// <param name="p_strEmployeeType">Ա�����</param>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetEmployeeByType(string p_strEmployeeType)
        {
            try
            {
                string strSql = string.Format("select * from TCOM_USER where EmployeeType='{0}' order by UserName ", p_strEmployeeType);
                DataSet dst = ServiceManager.GetDatabase().GetEntity(strSql, "TCOM_USER");
                return dst;
            }
            catch (Exception ex)
            {
                throw ex; //("������ȡԱ������"+ ex.Message ); 
            }
        }
        /// <summary>
        /// ��ȡ�����
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public int GetMaxNO()
        {
            try
            {
                string strSql = @"select max(SEQNO)+1 SEQNO from dbo.TCOM_USER  ";
                DataSet dst = ServiceManager.GetDatabase().GetEntity(strSql, "TCOM_USER");
                if (dst.Tables.Count > 0)
                {
                     string maxNo =dst.Tables["TCOM_USER"].Rows[0][0].ToString();
                     if (maxNo.Trim() != "")
                     {
                         return int.Parse(maxNo);
                     }
                     else
                     {
                         return 1;
                     }
                }
                else
                {
                    return 1;
                }
            }
            catch (Exception ex)
            {
                throw ex; //("��ȡ���˳���:"+ex.Message );
            }
        }

        /// <summary>
        /// ���±���Ա��˳���
        /// </summary>
        [WebMethod]
        public void ChangeEmployee()
        {
            try
            {
                string strSql = @" select * from dbo.TCOM_USER   ";
                DataSet dst = ServiceManager.GetDatabase().GetEntity(strSql, "TCOM_USER");
                int i = 1;
                foreach (DataRow row in dst.Tables["TCOM_USER"].Rows)
                {
                    row.BeginEdit();
                    row["SEQNO"] = i;
                    row.EndEdit();
                    i++;
                }
                ServiceManager.GetDatabase().Store(dst, "TCOM_USER");
            }
            catch (Exception ex)
            {
                throw ex; //("���±���Ա��˳��ų���:"+ex.Message );
            }
        }
        #endregion


        #region �û���ɫ��Ȩ�޹���
        /// <summary>
        /// ��ȡ����ϵͳ����
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetUserFunction()
        {
            try
            {
                string strSql = "select * from TCOM_MENU ";
                DataSet ds = ServiceManager.GetDatabase().GetEntity(strSql, "TCOM_MENU");
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;;
            }
        }
        /// <summary>
        /// ��ȡϵͳ���еĽ�ɫ
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetAllUserRole()
        {
            try
            {

                string strSql = "select * from TCOM_ROLE";
                DataSet ds = ServiceManager.GetDatabase().GetEntity(strSql, "TCOM_ROLE");
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;;
            }
        }

        /// <summary>
        /// ��ȡһ���û���ӵ�еĽ�ɫ
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetUserRole(string userID)
        {
            try
            {
                string strSql = "select * from TCOM_ROLE where roleid in("
                    + " select roleid from TCOM_USERSROLE where userid='" + userID + "')";
                DataSet ds = ServiceManager.GetDatabase().GetEntity(strSql, "TCOM_ROLE");
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;;
            }
        }


        /// <summary>
        /// Ϊ�û����һ����ɫ
        /// </summary>
        /// <param name="strUserID">�û�ID</param>
        /// <param name="strRoleID">��ɫid</param>

        /// <returns></returns>
        [WebMethod]
        public int AddUser2Role(string strUserID, string strRoleID)
        {
            try
            {
                string strSql = "insert into TCOM_USERSROLE values('" + strUserID + "','" + strRoleID  + "','')";
                int rows = ServiceManager.GetDatabase().ExecuteNonQuery(strSql);
                return rows;
            }
            catch (Exception ex)
            {
                throw ex; //("���û��Ѿ�ӵ�д˽�ɫ" + ex.Message);
            }

        }


        /// <summary>
        /// Ϊһ���û�ɾ����ɫ
        /// </summary>
        /// <param name="strUserID"></param>
        /// <param name="strRoleID"></param>
        /// <returns></returns>
        [WebMethod]
        public int DelectUser2Role(string strUserID, string strRoleID)
        {
            try
            {
                string strSql = "delete  from TCOM_USERSROLE where userid ='" + strUserID + "' and roleid ='" + strRoleID + "'";
                int rows = ServiceManager.GetDatabase().ExecuteNonQuery(strSql);
                return rows;
            }
            catch (Exception ex)
            {
                throw ex;;
            }
        }

        /// <summary>
        /// ��ȡһ����ɫ�û�ϵͳ�Ĺ���ģ��
        /// </summary>
        /// <param name="strRoleID"></param>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetUserRole2Function(string strRoleID)
        {
            try
            {
                string strSql = "select * from  TCOM_ROLESMENU where roleid='" + strRoleID + "'";
                DataSet ds = ServiceManager.GetDatabase().GetEntity(strSql, "TCOM_ROLESMENU");
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;;
            }
        }


        /// <summary>
        /// ɾ��һ����ɫӵ�з����ϵͳ
        /// </summary>
        /// <param name="strRoleID"></param>
        /// <returns></returns>
        [WebMethod]
        public int DeleteUserRole2Function(string strRoleID)
        {

            try
            {
                string strSql = "delete  from TCOM_ROLESMENU  where roleid ='" + strRoleID + "'";
                int rows = ServiceManager.GetDatabase().ExecuteNonQuery(strSql);
                return rows;
            }
            catch (Exception ex)
            {
                throw ex;;
            }
        }
        /// <summary>
        /// ���ݿ��Ż�ȡԱ����Ϣ
        /// </summary>
        /// <param name="p_strCardNO">����</param>
        /// <returns></returns>
        [WebMethod]
        public string[] GetUserIDbyCardNO(string p_strCardNO)
        {
            try
            {
                string[] strUserInfos = new string[6];
                string strSql = string.Format("select userid,deptid,usercode,username,deptname,deptcode from vub_user where cardno='{0}'", p_strCardNO);
                DataSet dst = ServiceManager.GetDatabase().GetEntity(strSql, "TCOM_USER");
                if (dst.Tables[0].Rows.Count > 0)
                {

                    strUserInfos[0] = dst.Tables[0].Rows[0]["userid"].ToString();
                    strUserInfos[1] = dst.Tables[0].Rows[0]["deptid"].ToString();
                    strUserInfos[2] = dst.Tables[0].Rows[0]["usercode"].ToString();
                    strUserInfos[3] = dst.Tables[0].Rows[0]["username"].ToString();
                    strUserInfos[4] = dst.Tables[0].Rows[0]["deptname"].ToString();
                    strUserInfos[5] = dst.Tables[0].Rows[0]["deptcode"].ToString();

                }
                return strUserInfos;


            }
            catch (Exception ex)
            {
                throw ex;;
            }
        }

        /// <summary>
        /// ��ȡ�û���Ϣ
        /// </summary>
        /// <param name="p_strUserID">�û�ID��</param>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetUserByUserID(string p_strUserID)
        {
            try
            {
                string strSql = string.Format("select * from TCOM_USER where UserID='{0}'", p_strUserID);
                DataSet dst= ServiceManager.GetDatabase().GetEntity(strSql, "TCOM_USER");
                return dst;

            }
            catch (Exception ex)
            {
                throw ex;;
            }
        }
        #endregion

        /// <summary>
        /// �����ӡ����
        /// </summary>
        /// <param name="dst"></param>
        [WebMethod]
        public void SavePrintSettings(DataSet dst)
        {
            try
            {
                ServiceManager.GetDatabase().Store(dst, "TS_Print");
            }
            catch (Exception ex)
            {
                throw ex; //("�����ӡ���ó���:" + ex.Message);
            }
        }
        /// <summary>
        /// ��ȡȫ����ӡ����
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetAllPrintSettings()
        {
            try
            {
                string strSql = "select * from [dbo].[TS_Print] ";
                DataSet dst = ServiceManager.GetDatabase().GetEntity(strSql, "TS_Print");
                return dst;
            }
            catch (Exception ex)
            {
                throw ex; //("��ȡȫ����ӡ���ó���" + ex.Message);
            }
        }
        /// <summary>
        /// ��ѯ��ӡ����
        /// </summary>
        /// <param name="modelName"></param>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetPrintSettings(string modelName)
        {
            try
            {
                string strSql = " select * from [dbo].[TS_Print] where ģ������='" + modelName + "' ";
                DataSet dst =  ServiceManager.GetDatabase().GetEntity(strSql, "TS_Print");
                return dst;
                
            }
            catch (Exception ex)
            {
                throw ex; //("��ѯ��ӡ���ó���:" + ex.Message);
            }
        }

      

        /// <summary>
        /// ��ѯ���е�һ�ֶεķ��ظ�ֵ�����������б�
        /// </summary>
        /// <param name="tableName">������</param>
        /// <param name="fieldName">�ֶ���</param>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetTableFieldList(string tableName, string fieldName)
        {
            try
            {
                DataSet dst = new DataSet();
                if (!string.IsNullOrEmpty(tableName) && !string.IsNullOrEmpty(fieldName))
                {
                    string strSql = " select distinct " + fieldName + " from " + tableName + " where " + fieldName + " is not null";
                    dst = ServiceManager.GetDatabase().GetEntity(strSql, tableName);
                }

                return dst;
            }
            catch (Exception ex)
            {
                throw new Exception("�����GetTableFieldList��������\r\n������Ϣ��" + ex.Message + "\r\n" + ex.InnerException.Message);
            }
        }


        /// <summary>
        /// ��ѯ���е�һ�ֶεķ��ظ�ֵ���ɼ�Sql������
        /// </summary>
        /// <param name="tableName">������</param>
        /// <param name="fieldName">�ֶ���</param>
        /// <param name="fieldName">Sql��������������� and 1=1��</param>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetTableFieldList2(string tableName, string fieldName, string SQLstring)
        {
            try
            {
                DataSet dst = new DataSet();
                if (!string.IsNullOrEmpty(tableName) && !string.IsNullOrEmpty(fieldName))
                {
                    string strSql = " select distinct " + fieldName + " from " + tableName + " where 1=1" + SQLstring;
                    dst = ServiceManager.GetDatabase().GetEntity(strSql, tableName);
                }
                return dst;
            }
            catch (Exception ex)
            {
                throw new Exception("�����GetTableFieldList��������\r\n������Ϣ��" + ex.Message + "\r\n" + ex.InnerException.Message);
            }
        }



    }

}
