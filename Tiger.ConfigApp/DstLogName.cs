using System;
using System.Data;
using System.Windows.Forms;
namespace Tiger.ConfigApp {


    partial class DstLogName
    {
        /// <summary>
        /// 添加登录名
        /// </summary>
        /// <param name="logName"></param>
        public void Add(string logName)
        {
            DataRow row = table登录记录.FindBy登录名称(logName);
            if (row != null)
            {
                row["登录时间"] = DateTime.Now;
            }
            else
            {
                DataRow newRow  = table登录记录.NewRow();
                newRow["登录时间"] = DateTime.Now;
                newRow["登录名称"] = logName;
                table登录记录.Rows.Add(newRow);
            }
            this.WriteXml(Application.ExecutablePath.ToLower() + "log.xml");
        }
        /// <summary>
        /// 获取最近登录名
        /// </summary>
        public void loadLoginName()
        {
            try
            {
                this.ReadXml(Application.ExecutablePath.ToLower() + "log.xml");
            }
            catch
            {
                Console.WriteLine("没有文件");
            }
        }
    }
}
