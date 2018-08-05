using System;
using System.Data;
using System.Windows.Forms;
namespace Tiger.ConfigApp {


    partial class DstUrl
    {
       public void GetData()
       {
           string fileName = Application.ExecutablePath + ".XML";
           this.ReadXml(fileName);
       }
        public void SaveData()
        {
            string fileName = Application.ExecutablePath + ".XML";
            this.WriteXml(fileName);
        }

        public void setValue(string newUrl,string oldUrl)
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
