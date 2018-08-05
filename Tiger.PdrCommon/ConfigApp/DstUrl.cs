using System;
using System.Data;
using System.Windows.Forms;
namespace Tiger.PdrCommon.ConfigApp
{


    partial class DstUrl
    {
        public void GetData()
        {
            string fileName = "c:\\wangDaApp.exe.XML";
            this.ReadXml(fileName);
        }
        public void SaveData()
        {
            string fileName = "c:\\WangDaApp.exe.XML";
            this.WriteXml(fileName);
        }

        public void setValue(string newUrl, string oldUrl)
        {
            try
            {
                //this.ServiceURL.Clear();
                //GetData();
                foreach (DataRow row in ServiceURL.Rows)
                {
                    row.BeginEdit();
                    row["URLValue"] = row["URLValue"].ToString().Replace(oldUrl, newUrl);
                    row.EndEdit();
                }
                SaveData();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
