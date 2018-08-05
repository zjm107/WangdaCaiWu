using System;
using System.Data;
using Tiger.Entities;
using Tiger.Tools;
namespace Tiger.PdrCommon.Entities.Basic {
    
    
    public partial class DstMachiningConfig
    {
        public void GetProcessPriceData(string materailBreed,string spec,string brandNo)
        {
            DataSet dst = SysTools.basicService.GetProcessPriceData( materailBreed, spec, brandNo);
            this.TEXP_PROCESSPRICE.Clear();
            DataManager.ImpDataSet(dst.Tables["TEXP_PROCESSPRICE"], this.TEXP_PROCESSPRICE);
            this.TEXP_PROCESSPRICE.AcceptChanges();
        }
        public void Save()
        {
            try
            {
                DataSet dst = new DataSet();
                DataTable tb = this.TEXP_PROCESSPRICE.GetChanges();
                if (tb != null)
                {
                    dst.Tables.Add(tb);
                    SysTools.basicSer.SaveTable(dst, "TEXP_PROCESSPRICE");
                }
                this.TEXP_PROCESSPRICE.AcceptChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("DataSet保存方法出错" + ex.Message + ex.InnerException);
            }
        }
    }
}
