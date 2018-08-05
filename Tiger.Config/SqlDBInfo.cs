using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Tiger.CoreClass.Data;

namespace Tiger.Config
{
    /// <summary>
    ///Copyright (c) 2006-2007 *********Tiger
    /// ������: �Խ���
    /// �� ��: 2006-10-9
    ///
    /// �� ��:
    /// ���ã���ȡ���ݿ���Ϣ���Ͳٿز�ѯģ��
    /// ģ����
    /// </summary>
    public class SQLDBInfo : Tiger.Config.AbsDBInfo 
    {
        /// <summary>
        /// ��ȡ���ݿ��б�����
        /// </summary>
        /// <returns>TableName:������</returns>
        public override  DataSet GetDBTableNames(string DataBaseName)
        {
            try
            {
                string strSql = "select [name] from dbo.sysobjects where xtype='U'";
                DataSet ds = ServiceManager.GetDatabase(DataBaseName).GetEntity(strSql, "������");
                return ds;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// ��ȡ���ݿ�����ͼ����
        /// </summary>
        /// <returns>��ͼ����</returns>
        public override DataSet GetDBViewNames(string DataBaseName)
        {
            try
            {
                string strSql = "select [name] from dbo.sysobjects where xtype='V'";
                DataSet ds = ServiceManager.GetDatabase(DataBaseName).GetEntity(strSql, "��ͼ����");
                return ds;
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        /// <summary>
        /// ��ȡ������
        /// </summary>
        /// <returns></returns>
        public override DataSet GetPublicQueryTemp()
        {
            try
            {
                string strSql = "select * from TS_��ѯģ�� where (ģ������ is null or ģ������='')";
                DataSet ds = ServiceManager.GetDatabase("Tiger_COMMON").GetEntity(strSql, "TS_��ѯģ��");
                return ds;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// ��ȡ���ݿ���ָ�������ͼ���ֶ�����
        /// </summary>
        /// <param name="strTableName">�����ͼ����</param>
        /// <param name="DataBaseName"></param>
        /// <returns>�յı�ṹ�������ƣ��ֶ�����</returns>
        public override DataSet GetDBFieldNames(string strTableName, string DataBaseName)
        {
            try
            {
                string strSql = "select * from " + strTableName + " where 1=2";
                DataSet ds = ServiceManager.GetDatabase(DataBaseName).GetEntity(strSql, "�ֶ�����");
                return ds;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// ��ȡȫ��ģ������
        /// </summary>
        /// <returns></returns>
        public override DataSet GetAllQueryTemp()
        {
            try
            {
                string strSql = "select * from TS_��ѯģ�� ";
                DataSet ds = ServiceManager.GetDatabase().GetEntity(strSql, "TS_��ѯģ��");
                return ds;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        ///��ȡĳһ���ؼ��Ĳ�ѯģ������
        /// </summary>
        /// <param name="ControlID">�ؼ�Ψһ����,��������Form����</param>
        /// <returns></returns>
        public override DataSet GetQueryTemp(string ControlID)
        {
            try
            {
                string strSql = string.Format( "select * from TS_��ѯģ�� where �ؼ�ID='{0}'",ControlID);
                DataSet ds = ServiceManager.GetDatabase().GetEntity(strSql, "TS_��ѯģ��");
                return ds;

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// ͨ��ģ�����ƣ�ɾ��ģ��
        /// </summary>
        /// <param name="TempName">ģ������</param>
        public override void DelQueryTemp(string TempName)
        {
            try
            {
                string strSql =string.Format( "Delete from TS_��ѯģ�� where ����='{0}'",TempName);
                ServiceManager.GetDatabase().ExecuteNonQuery(strSql);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// ���²�ѯģ��
        /// </summary>
        /// <param name="strNewName">������</param>
        /// <param name="strNewMemo">��˵��</param>
        /// <param name="strNewControlID">�¿ؼ�ID</param>
        /// <param name="strNewSQL">�²�ѯ���</param>
        /// <param name="strNewKeyField">�¹ؼ��ֶ�</param>
        /// <param name="decIsCreateForm">�Ƿ񴴽�����</param>
        /// <param name="strFormClassName">����������</param>
        /// <param name="strID"></param>
        public override void UpdateQueryTemp(string strNewName, string strNewMemo, string strNewControlID, 
            string strNewSQL, string strNewKeyField, string strID, decimal decIsCreateForm, string strFormClassName)
        {
            try
            {
                string [] para = new string[] { strNewName, strNewMemo, strNewControlID, strNewSQL, strNewKeyField, strID,strFormClassName,decIsCreateForm.ToString() };
                string strSql = string.Format(" UPDATE TS_��ѯģ�� "
                    + " SET ����='{0}', ˵��='{1}', �ؼ�ID='{2}', ��ѯ���='{3}', �ؼ��ֶ�='{4}',ģ������='{5}',�Ƿ񴴽�����={6}'"
                    + " WHERE ��ѯģ��ID={5}", para);
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
                string strSql = string.Format(" INSERT INTO TS_��ѯģ��(����, ˵��, �ؼ�ID, ��ѯ���, �ؼ��ֶ�,��ѯģ��ID,�Ƿ񴴽�����,ģ������) "
                            + " VALUES('{0}', '{1}','{2}','{3}','{4}','{5}',{6},'{7}')",para);
                
                ServiceManager.GetDatabase().ExecuteNonQuery(strSql );
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// ����ģ������
        /// </summary>
        /// <param name="strFormClassName"></param>
        /// <returns></returns>
        public override DataSet GetQueryTempByFromClass(string strFormClassName)
        {
            try
            {
                string strSql = string.Format(" select * from TS_��ѯģ�� where ģ������='{0}'", strFormClassName);
                DataSet dst = ServiceManager.GetDatabase().GetEntity(strSql, "TS_��ѯģ��");
                return dst;

            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}
