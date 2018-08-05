using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Tiger.CoreClass.Data
{
	/// <summary>
	/// Sql����
	/// </summary>
	public class SqlStruct : System.ICloneable
	{
		private string m_SqlString;
		//private string[] m_ParamNameList;
		private CommandType m_CommandType;
        private Dictionary<string, object> m_Param;

        /// <summary>
        /// ������Ϣ
        /// </summary>
        public Dictionary<string, object> Param
        {
            get { return m_Param; }
            set { m_Param = value; }
        }

		/// <summary>
		/// ���캯��
		/// </summary>
		/// <param name="p_strSql">Sql���</param>
		public SqlStruct(string p_strSql) : this(p_strSql, CommandType.Text, null){}
		/// <summary>
		/// ���캯��
		/// </summary>
		/// <param name="p_strSql">Sql����洢��������</param>
		/// <param name="p_commandType">CommandType</param>
		public SqlStruct(string p_strSql, CommandType p_commandType) : this(p_strSql, p_commandType, null){}

        /// <summary>
        /// ���캯��
        /// </summary>
        /// <param name="p_strSql">Sql���</param>
        /// <param name="p_param">����</param>
        public SqlStruct(string p_strSql, Dictionary<string, object> p_param)
            : this(p_strSql, CommandType.Text, p_param)
        {
        }
        /// <summary>
        /// ���캯��
        /// </summary>
        /// <param name="p_strSql">Sql����洢��������</param>
        /// <param name="p_commandType">CommandType</param>
        /// <param name="p_param">Dictionary</param>
        public SqlStruct(string p_strSql, CommandType p_commandType, Dictionary<string, object> p_param)
        {
            this.m_CommandType = p_commandType;
            this.m_Param = p_param;
            this.m_SqlString = p_strSql;
        }



		/// <summary>
		/// ��û�����SQL���
		/// </summary>
		public string SqlString
		{
			
			get
			{
				return m_SqlString;
			}
			set
			{
				m_SqlString = value;
			}
		}

		/// <summary>
		/// ��ȡ������SQL�����������ͣ��洢��������SQL���
		/// </summary>
		public CommandType CommandType
		{
			get
			{
				return m_CommandType;
			}
			set
			{
				m_CommandType = value;
			}
		}


		#region ICloneable ��Ա

		/// <summary>
		/// ICloneableʵ��
		/// </summary>
		/// <returns>SqlStruct</returns>
		public object Clone()
		{
			BinaryFormatter serializer = new BinaryFormatter();
��          MemoryStream memStream = new MemoryStream();
��          serializer.Serialize(memStream,this);
            
			memStream.Position = 0;
			BinaryFormatter deserializer = new BinaryFormatter();
��          object obj = deserializer.Deserialize(memStream);
			memStream.Close();
			return obj;
		}

		/// <summary>
		/// ȡ��SqlStruct��¡
		/// </summary>
		/// <returns>SqlStruct</returns>
		public SqlStruct GetClone()
		{
			return (SqlStruct)this.Clone();
		}
		#endregion
	}
}
