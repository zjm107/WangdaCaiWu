using DevExpress.Utils.Helpers;
using System;
using System.Data;
using System.Windows.Forms;
using Tiger.Tools;

namespace WangDaDll
{
    /// <summary>
    /// 
    /// </summary>
    public class SysTools
    {


        public SysTools()
        {
            try
            {
                string serverIP = Tiger.Tools.ReflectionHelper.GetUrl("ServerIP");
                if (serverIP.Trim() == "")
                    serverIP = "localhost";
                Tiger.Tools.WebServiceConfig.SetWebURL(serverIP);
                BasicSer = new WangDaDll.BaseSerReference.BaseSerSoapClient(WebServiceConfig.BuildBinding(), new System.ServiceModel.EndpointAddress(WebServiceConfig.BaseSerURL));
                WangDaSer =new WangDaDll.WangDaReference.WangDaSerSoapClient(WebServiceConfig.BuildBinding(), new System.ServiceModel.EndpointAddress(WebServiceConfig.WangDaSerURL));
                UserSer = new WangDaDll.UserSerReference.UserSerSoapClient(WebServiceConfig.BuildBinding(), new System.ServiceModel.EndpointAddress(WebServiceConfig.UserSerURL));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public WangDaDll.BaseSerReference.BaseSerSoapClient BasicSer;

        public WangDaDll.WangDaReference.WangDaSerSoapClient WangDaSer;

        public WangDaDll.UserSerReference.UserSerSoapClient UserSer;
       
     
        
  
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public DateTime GetServerDateTime()
        {
            try
            {
                DateTime sysDate = DateTime.Now;
                sysDate = BasicSer.GetSysDate();
                return sysDate;
            }
            catch (Exception ex)
            {
                throw new Exception("获取系统时间出错:" + ex.Message);
            }
        }

      

    }
}
