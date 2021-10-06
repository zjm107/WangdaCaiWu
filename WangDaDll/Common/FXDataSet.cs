using System;
using System.Data;
using Tiger.Tools;

namespace WangDaDll.Common
{


    partial class FXDataSet
    {
      
        public SysTools DBHelper = new SysTools();

        public void GetClientFX(string zzKSDate, string zzDQDate, string zfKSData, string zfJSData, string clientName)
        {
            try
            {
                
                DataSet dst = DBHelper.WangDaSer.GetClientFX( zzKSDate,  zzDQDate,  zfKSData,  zfJSData,  clientName);
                DataManager.ImpDataSet(dst.Tables[0], this.VW_客户收支表);
            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }
        }
    }
}
