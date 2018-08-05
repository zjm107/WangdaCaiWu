using System;
using System.Data;
using System.Runtime.CompilerServices;

namespace Tiger.CoreClass.Data
{
	/// <summary>
	/// KeyInfo 的摘要说明。
	/// </summary>
	internal class KeyInfo
	{
        private int keyMax;
        private int keyMin;
		private int nextKey;
		private int poolSize;
		private string keyName;

		internal KeyInfo(int poolSize, string keyName)
		{
			this.poolSize = poolSize;
			this.keyName = keyName;
			retrieveFromDB();
		}

		//TODO:Use Lock
		[MethodImpl(MethodImplOptions.Synchronized)]
        internal int GetNextKey()
		{
            if (nextKey > this.keyMax)
            {
                retrieveFromDB();
            }
            return nextKey++;
		}

		private void retrieveFromDB()
		{
            AbsDatabase db = ServiceManager.GetDatabase();
            int keyFromDB;

			string sqlUpdate = "UPDATE KeyTable SET keyValue = keyValue + "
				+ poolSize + " WHERE keyName = '"
				+ keyName + "'";

			string sqlGetNewKey = "SELECT keyValue FROM KeyTable WHERE KeyName = '"
				+ keyName + "'";

            try
            {
                db.ExecuteNonQuery(sqlUpdate);

                keyFromDB = (Int32)db.ExecuteScalar(sqlGetNewKey);

            }
            catch (Exception)
            {
                throw;
            }

			this.keyMax = keyFromDB;
			this.keyMin = keyFromDB - poolSize + 1;
			this.nextKey = this.keyMin;
		}
	}
}
