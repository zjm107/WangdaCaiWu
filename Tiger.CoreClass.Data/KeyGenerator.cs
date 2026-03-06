using System;
using System.Collections.Generic;

namespace Tiger.CoreClass.Data
{
    /// <summary>
    /// 取得给定表的主键
    /// </summary>
    public static class KeyGenerator
    {
        /* --Replace your DataBase Name with #DB_NAME#
         * --Drop block is just for SQL Server.
         * 
         * use #DB_NAME#
         * 
         * IF EXISTS (SELECT name FROM sysobjects WHERE name = 'KeyTable' AND type = 'u')  
         * DROP Table KeyTable 
         * GO
         * 
         * Create Table KeyTable(
         * KeyName varchar(50),
         * KeyValue int,
         * constraint PK_KeyName primary key (KeyName)
         * );
         * GO
         */

        private static int POOL_SIZE = int.Parse(System.Configuration.ConfigurationManager.AppSettings["POOL_SIZE"]);

        private static Dictionary<string, KeyInfo> dictOfKeyInfo = new Dictionary<string, KeyInfo>();

        /// <summary>
        /// 获取字段的主键值
        /// </summary>
        /// <param name="keyName">字段名称</param>
        /// <returns>整型值</returns>
        public static int GetNextKey(String keyName)
        {
            KeyInfo keyInfo = null;
            if (dictOfKeyInfo.ContainsKey(keyName))
            {
                keyInfo = dictOfKeyInfo[keyName];
            }
            else
            {
                keyInfo = new KeyInfo(POOL_SIZE, keyName);
                dictOfKeyInfo.Add(keyName, keyInfo);
            }
            return keyInfo.GetNextKey();
        }
    }
}
