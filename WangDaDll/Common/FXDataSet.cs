using System;
using System.Data;
using Tiger.Tools;

namespace WangDaDll.Common
{


    partial class FXDataSet
    {

        public SysTools DBHelper = new SysTools();
        /// <summary>
        /// 按照客户查询利润情况
        /// </summary>
        /// <param name="zzKSDate"></param>
        /// <param name="zzDQDate"></param>
        /// <param name="zfKSData"></param>
        /// <param name="zfJSData"></param>
        /// <param name="clientName"></param>
        public void GetClientFX(string zzKSDate, string zzDQDate, string zfKSData, string zfJSData, string clientName)
        {
            try
            {

                DataSet dst = DBHelper.WangDaSer.GetClientFX(zzKSDate, zzDQDate, zfKSData, zfJSData, clientName);
                DataManager.ImpDataSet(dst.Tables[0], this.VW_客户收支表);
            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }
        }
        /// <summary>
        /// 查询年月的综合业绩情况
        /// </summary>
        /// <param name="beginDate"></param>
        /// <param name="endDate"></param>
        public void GetLRByDate(string beginDate, string endDate)
        {
            DataSet dst = DBHelper.WangDaSer.GetLRByDate(beginDate, endDate);
            DataManager.ImpDataSet(dst.Tables[0], this.VW_月份统计表);
        }

        /// <summary>
        /// 查询应收款
        /// </summary>
        /// <param name="beginDate"></param>
        /// <param name="endDate"></param>
        /// <param name="clientName"></param>
        /// <param name="userid"></param>
        /// <returns></returns>
        public void GetYingShou(string beginDate, string endDate, string clientName, string userid)
        {
            DataSet dst = DBHelper.WangDaSer.GetYingShou(beginDate, endDate, clientName, userid);
            DataManager.ImpDataSet(dst.Tables[0], this.VM_应收款);
        }




    }
}
