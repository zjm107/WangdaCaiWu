using System;
using System.Xml;
using System.Data;
using System.Collections;
using System.Configuration;
namespace Tiger.CoreClass.Data
{
	/// <summary>
	/// ServiceManager ��ժҪ˵����
	/// </summary>
	public class ServiceManager
	{
		private ServiceManager(){}
		private static Hashtable strConns = Hashtable.Synchronized(new Hashtable());
		private static Hashtable hashEntities = Hashtable.Synchronized(new Hashtable());
		private static Hashtable hashEntitiesWithSchema = Hashtable.Synchronized(new Hashtable());
		static ServiceManager()
		{
			try
			{
                //Hashtable configs = ConfigurationSettings.GetConfig("dataSources") as Hashtable;  1.1����ʹ�÷���
                Hashtable configs = ConfigurationManager.GetSection("dataSources") as Hashtable;
				if (configs == null)
				{
					throw new Exception("�����ļ��п��ܲ�����dataSources���Σ�");
				}
				foreach (DictionaryEntry de in configs)
				{
					SaveConnInfo(de.Key.ToString(), de.Value.ToString());
				}
			}
			catch(Exception e)
			{
				throw new Exception("�����ļ������ڻ��ʽ����ȷ��" + e.Message, e);
			}
		}

		internal static DataSet GetEmptyEntityWithSchema(string selStr, string tableName, AbsDatabase db)
		{
			string key = selStr + db.GetRealOne().ConnectionString;
			if (hashEntitiesWithSchema.ContainsKey(key))
			{
				return (hashEntitiesWithSchema[key] as DataSet).Clone();
			}
			else
			{
				DataSet ds = new DataSet();
				IDbDataAdapter adapter = db.GetDataAdapter(selStr);
				adapter.FillSchema(ds, SchemaType.Source);
				ds.Tables[0].TableName = tableName;
                hashEntitiesWithSchema[key] = ds;
				return ds.Clone();
			}
		}

		/// <summary>
		/// ȡ�ÿ�ʵ��,����ϸģʽ
		/// </summary>
		/// <param name="p_tableName">����</param>
		/// <returns>��DataSet</returns>
		public static DataSet GetEmptyEntityWithSchema(string p_tableName)
		{
			return GetEmptyEntityWithSchema("select * from " + p_tableName,
				p_tableName, GetDatabase());
		}

		/// <summary>
		/// ȡ�ÿ�ʵ��,����ϸģʽ
		/// </summary>
		/// <param name="p_db">AbsDatabase</param>
		/// <param name="p_tableName">����</param>
		/// <returns></returns>
		public static DataSet GetEmptyEntityWithSchema(AbsDatabase p_db, string p_tableName)
		{
			return GetEmptyEntityWithSchema("select * from " + p_tableName,
				p_tableName, p_db);
		}

		/// <summary>
		/// ���ֻ������ṹ��DataSet
		/// </summary>
		/// <param name="p_tableName">����</param>
		/// <returns>��DataSet</returns>
		public static DataSet GetEmptyEntity(string p_tableName)
		{
			return GetEmptyEntity(GetDatabase(), p_tableName);
		}

		/// <summary>
		/// ���ֻ������ṹ��DataSet�����ڳ�_Default���������Դ
		/// </summary>
		/// <param name="p_db">AbsDatabase����</param>
		/// <param name="p_tableName">����</param>
		/// <returns>DataSet</returns>
		public static DataSet GetEmptyEntity(AbsDatabase p_db, string p_tableName)
		{
			string key = p_db.GetRealOne().ConnectionString + p_tableName;
			if (!hashEntities.ContainsKey(key))
			{
				try
				{
					string tableName = p_tableName.Trim();
					string strSql = string.Format("select * from {0} where 0=1", tableName);
					DataSet ds = p_db.GetEntity(strSql, tableName);
					hashEntities.Add(key, ds);
					return ds.Clone();
				}
				catch(Exception e)
				{
					throw e;
				}
			}
			else
			{
				return (hashEntities[key] as DataSet).Clone();
			}
		}

		/// <summary>
		/// ���ȱʡ��AbsDatabase����
		/// </summary>
		/// <returns>AbsDatabaseʵ��</returns>
		public static AbsDatabase GetDatabase()
		{
			return GetDatabase("_Default");
		}

		/// <summary>
		/// ���ָ�����͵�AbsDatabase����ʵ��
		/// </summary>
		/// <param name="p_DataSourceName">����Դ�����֣��������ļ������ã�</param>
		/// <returns>AbsDatabaseʵ��</returns>
		public static AbsDatabase GetDatabase(string p_DataSourceName)
		{
			string allstr, connType, realConnString;
			allstr = getConnectionString(p_DataSourceName);
			int idx = allstr.IndexOf("~");
			connType = allstr.Substring(0, idx);
			realConnString = allstr.Substring(idx + 1);
			try
			{
				switch(connType)
				{
					case "sqlserver" :
						return new SqlDatabase(realConnString);
					case "oledb" :
						return new OleDbDatabase(realConnString);
					default :
						return new OleDbDatabase(realConnString);
				}
			}
			catch(Exception e)
			{
				throw new Exception("�������ݿ����Ӷ���ʧ�ܣ�" + e.Message, e);
			}
		}


        /// <summary>
        /// �������ݿ����ӵ�������Ϣ 
        /// </summary>
        /// <param name="p_name"></param>
        /// <param name="p_value"></param>
		private static void SaveConnInfo(string p_name, string p_value)
		{
            try
            {
                string connType, connTypeString, realConnString, strDBConnString;
                try
                {
                    //strDBConnString = EnDecrypt.Decrypt(p_value);   //�����������ַ����н���  �Խ�����
                    strDBConnString = p_value;   //�����������ַ����н���  �Խ�����
                }
                catch (Exception ex)
                {
                    throw new Exception("���ܳ���" + ex.Message);
                }
                int a = strDBConnString.IndexOf(";");
                connTypeString = strDBConnString.Substring(0, a + 1);
                realConnString = strDBConnString.Substring(a + 1).ToString();
                int b = connTypeString.IndexOf("=");
                connType = connTypeString.Substring(b + 1, a - b - 1).Trim().ToLower();
                string namePart = p_name;
                string valuePart = connType + "~" + realConnString;
                strConns.Add(namePart, valuePart);
            }
            catch (Exception e)
            {
                throw e;
            }
		}
		private static string getConnectionString(string p_DataSourceName)
		{
			if(strConns.Contains(p_DataSourceName))
			{
				return strConns[p_DataSourceName].ToString();
			}
			else
			{
				return strConns["_Default"].ToString();
			}
		}
	}
}
