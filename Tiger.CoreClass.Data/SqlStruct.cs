using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Tiger.CoreClass.Data
{
	/// <summary>
	/// Sql对象
	/// </summary>
	public class SqlStruct : System.ICloneable
	{
		private string m_SqlString;
		//private string[] m_ParamNameList;
		private CommandType m_CommandType;
        private Dictionary<string, object> m_Param;

        /// <summary>
        /// 参数信息
        /// </summary>
        public Dictionary<string, object> Param
        {
            get { return m_Param; }
            set { m_Param = value; }
        }

		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name="p_strSql">Sql语句</param>
		public SqlStruct(string p_strSql) : this(p_strSql, CommandType.Text, null){}
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name="p_strSql">Sql语句或存储过程名字</param>
		/// <param name="p_commandType">CommandType</param>
		public SqlStruct(string p_strSql, CommandType p_commandType) : this(p_strSql, p_commandType, null){}

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="p_strSql">Sql语句</param>
        /// <param name="p_param">参数</param>
        public SqlStruct(string p_strSql, Dictionary<string, object> p_param)
            : this(p_strSql, CommandType.Text, p_param)
        {
        }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="p_strSql">Sql语句或存储过程名字</param>
        /// <param name="p_commandType">CommandType</param>
        /// <param name="p_param">Dictionary</param>
        public SqlStruct(string p_strSql, CommandType p_commandType, Dictionary<string, object> p_param)
        {
            this.m_CommandType = p_commandType;
            this.m_Param = p_param;
            this.m_SqlString = p_strSql;
        }



		/// <summary>
		/// 获得或设置SQL语句
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
		/// 获取或设置SQL语句的命令类型：存储过程名或SQL语句
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


		#region ICloneable 成员

		/// <summary>
		/// ICloneable实现
		/// </summary>
		/// <returns>SqlStruct</returns>
		public object Clone()
		{
			BinaryFormatter serializer = new BinaryFormatter();
　          MemoryStream memStream = new MemoryStream();
　          serializer.Serialize(memStream,this);
            
			memStream.Position = 0;
			BinaryFormatter deserializer = new BinaryFormatter();
　          object obj = deserializer.Deserialize(memStream);
			memStream.Close();
			return obj;
		}

		/// <summary>
		/// 取得SqlStruct克隆
		/// </summary>
		/// <returns>SqlStruct</returns>
		public SqlStruct GetClone()
		{
			return (SqlStruct)this.Clone();
		}
		#endregion
	}
}
