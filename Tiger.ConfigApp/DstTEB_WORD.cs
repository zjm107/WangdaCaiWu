using System;
using System.Collections;
using System.Data;
using Tiger.Entities;
using Tiger.Tools;
namespace Tiger.ConfigApp 
{
    public partial class DstTEB_WORD 
    {
        public void GetNDDWordData(Hashtable paras)
        {
            DataSet dst = SysTools.config.GetTEB_WORDData(paras);
            this.TEB_WORD.Clear();
            DataManager.ImpDataSet(dst.Tables[0], this.TEB_WORD);
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
                DataTable tab = this.TEB_WORD.GetChanges();
                if (tab != null)
                {
                    Newds.Tables.Add(tab);

                    SysTools.basicSer.SaveTable(Newds, "TEB_Word");
                    this.TEB_WORD.AcceptChanges();
                }

            }
            catch (Exception ex)
            {
                throw new Exception("保存出错:Save方法\r\n" + ex.Message + "\r\n" + ex.InnerException.Message);
            }
        }
    }
}
