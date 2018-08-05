using System;
using System.Collections;
using System.Data;
using Tiger.Tools;

namespace Tiger.ConfigApp {
    
    
    public partial class DstNDD_Word 
    {
        public void GetNDDWordData(Hashtable paras)
        {
            DataSet dst = SysTools.config.GetNDD_WORDData(paras);
            this.NDD_WORD.Clear();
            DataManager.ImpDataSet(dst.Tables[0], this.NDD_WORD);
        }

        /// <summary>
        /// 保存
        /// </summary>
        public void Save()
        {
            try
            {
                DataSet Newds = new DataSet();//NewDataSet

                //NoMetal保存
                DataTable tab = this.NDD_WORD.GetChanges();
                if (tab != null)
                {
                    Newds.Tables.Add(tab);

                    SysTools.basicSer.SaveTable(Newds, "NDD_WORD");
                    this.NDD_WORD.AcceptChanges();
                }

            }
            catch (Exception ex)
            {
                throw new Exception("保存出错:SaveNoMetal方法\r\n" + ex.Message + "\r\n" + ex.InnerException.Message);
            }
        }
    }
}
