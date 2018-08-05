using System;
using System.Data;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using System.Runtime.Serialization.Formatters;
using Tiger.Entities;
using Tiger.Tools;

namespace Tiger.PdrCommon.Entities {

    /// <summary>
    /// 
    /// </summary>
    partial class DstPrint
    {
        /// <summary>
        /// 保存打印设置
        /// </summary>
        public void SavePrintSettings()
        {
            try
            {
                DataTable tb = TS_Print.GetChanges();
                if (tb != null)
                {
                        DataSet dst = new DataSet();
                        dst.Tables.Add(tb);
                        SysTools.basicService.SavePrintSettings(dst);
                        TS_Print.AcceptChanges();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 获取全部打印设置
        /// </summary>
        /// <returns></returns>
        public void GetAllPrintSettings()
        {
            try
            {
                    DataSet dst = SysTools.basicService.GetAllPrintSettings();
                    DataManager.ImpDataSet( dst.Tables[0],this.TS_Print);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
       /// <summary>
        /// 查询打印设置
       /// </summary>
       /// <param name="modelName"></param>
       /// <returns></returns>
        public bool GetPrintSettings(string modelName)
        {
            try
            {
                    DataSet dst = SysTools.basicService.GetPrintSettings(modelName);
                    DataManager.ImpDataSet(dst.Tables[0], this.TS_Print);
                    if (TS_Print.Rows.Count > 0)
                    {
                         return bool.Parse(TS_Print.Rows[0]["打印"].ToString());
                    }
                    else
                    {
                        return true;
                    }
                    
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
