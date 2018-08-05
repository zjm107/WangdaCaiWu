using System;
using System.Collections;
using System.Data;

using Tiger.Tools;

namespace Tiger.PdrCommon.ConfigApp
{

    public partial class DstTCONF_WORD
    {

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="paras"></param>
        public void GetTCONFWORDData(string groupName, string word)
        {
            DataSet dst = SysTools.config.GetTCONF_WORDData(groupName, word);
            this.TCONF_WORD.Clear();
            DataManager.ImpDataSet(dst.Tables[0], this.TCONF_WORD);
        }


        public DataSet GetParaItems(string paraName)
        {
            DataSet dst = SysTools.config.GetTCONF_WORDData(paraName, "");
            return dst;
        }

        /// <summary>
        ///填充Combox
        /// </summary>
        /// <param name="GroupName"></param>
        /// <param name="cmbbox"></param>
        public void FillDevComboBox(string GroupName, DevExpress.XtraEditors.ComboBoxEdit cmbbox)
        {
            DataSet dst = GetParaItems(GroupName);
            if (dst.Tables[0].Rows.Count > 0)
            {
                cmbbox.Properties.Items.Clear();
                foreach (DataRow row in dst.Tables[0].Rows)
                {
                    cmbbox.Properties.Items.Add(row["GROUPLISTITEM"].ToString());
                }
            }
        }

        //

        public void FillDevComboBox(string GroupName, DevExpress.XtraEditors.Repository.RepositoryItemComboBox cmbbox)
        {
            DataSet dst = GetParaItems(GroupName);
            if (dst.Tables[0].Rows.Count > 0)
            {
                cmbbox.Items.Clear();
                foreach (DataRow row in dst.Tables[0].Rows)
                {
                    cmbbox.Items.Add(row["GROUPLISTITEM"].ToString());
                }
            }
        }

        /// <summary>
        /// 填充COMBOX
        /// </summary>
        /// <param name="GroupName"></param>
        /// <param name="cmbbox"></param>
        public void FillComBoBox(string GroupName, System.Windows.Forms.ComboBox cmbbox)
        {
            DataSet dst = GetParaItems(GroupName);
            if (dst.Tables[0].Rows.Count > 0)
            {
                cmbbox.Items.Clear();
                foreach (DataRow row in dst.Tables[0].Rows)
                {
                    cmbbox.Items.Add(row["GROUPLISTITEM"].ToString());
                }
            }
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
