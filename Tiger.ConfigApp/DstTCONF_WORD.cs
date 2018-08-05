using System;
using System.Collections;
using System.Data;
using Tiger.Entities;
using Tiger.Tools;

namespace Tiger.ConfigApp { 

    public partial class DstTCONF_WORD 
    {
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="paras"></param>
        public void GetTCONFWORDData(Hashtable paras)
        {
            DataSet dst = SysTools.config.GetTCONF_WORDData(paras);
            this.TCONF_WORD.Clear();
            DataManager.ImpDataSet(dst.Tables[0], this.TCONF_WORD);
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
                DataTable tab = this.TCONF_WORD.GetChanges();
                if (tab != null)
                {
                    Newds.Tables.Add(tab);

                    SysTools.basicSer.SaveTable(Newds, "TCONF_WORD");
                    this.TCONF_WORD.AcceptChanges();
                }

            }
            catch (Exception ex)
            {
                throw new Exception("保存出错:SaveNoMetal方法\r\n" + ex.Message + "\r\n" + ex.InnerException.Message);
            }
        }
    }
}
