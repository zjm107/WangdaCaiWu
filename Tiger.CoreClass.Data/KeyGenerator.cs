using System;
using System.Collections;
using System.Collections.Generic;

namespace Tiger.CoreClass.Data
{
    /// <summary>
    /// ȡ�ø����������
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
        /// ��ȡ�ֶε�����ֵ
        /// </summary>
        /// <param name="keyName">�ֶ�����</param>
        /// <returns>����ֵ</returns>
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
