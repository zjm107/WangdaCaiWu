using System;
using System.Data;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using System.Runtime.Serialization.Formatters;
using Tiger.Entities;
using Tiger.Tools;

namespace Tiger.ConfigApp {


    partial class DstCOMPANY
    {
        partial class TS_COMPANYDataTable
        {
        }


        /// <summary>
        /// 获取单位信息
        /// </summary>
        /// <returns></returns>
        public void GetCompany()
        {
            
                DataSet dst = SysTools.config.GetCompany();
                DataManager.ImpDataSet(dst.Tables[0], this.TS_COMPANY);
          
        }

        /// <summary>
        /// 保存单位信息
        /// </summary>
        public void UpdateCompany()
        {
          
                DataRow row = TS_COMPANY.Rows[0];
                row.BeginEdit();
                row["company"] = Tools.EnDecrypt.Encrypt(row["company"].ToString());
                row["phone1"] = Tools.EnDecrypt.Encrypt(row["phone1"].ToString());
                row["phone2"] = Tools.EnDecrypt.Encrypt(row["phone2"].ToString());
                row["fax"] = Tools.EnDecrypt.Encrypt(row["fax"].ToString());
                row["email"] = Tools.EnDecrypt.Encrypt(row["email"].ToString());
                row["weblink"] = Tools.EnDecrypt.Encrypt(row["weblink"].ToString());
                row["address"] = Tools.EnDecrypt.Encrypt(row["address"].ToString());
                row["BeginDate"] = Tools.EnDecrypt.Encrypt(row["BeginDate"].ToString());
                row["EndDate"] = Tools.EnDecrypt.Encrypt(row["EndDate"].ToString());
                row.EndEdit();
                DataTable tb = TS_COMPANY.GetChanges();
                if (tb != null)
                {
                    DataSet dst = new DataSet();
                    dst.Tables.Add(tb);
                    SysTools.config.UpdateCompany(dst);
                }
            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="RegCode"></param>
        public void SetSystemUsefull(string RegCode)
        {

            SysTools.config.SetSystemUsefull(RegCode);
           
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool GetSystemUsefull()
        {

            return SysTools.config.GetSystemUsefull();
            
        }
    }
}
