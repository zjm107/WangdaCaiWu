using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Xml;
using System.Runtime.Serialization;
//using System.Windows.Forms;

namespace Tiger.Tools
{
    public static class WebServiceConfig
    {
        /// <summary>
        /// 创建客户端WebService的绑定对象
        /// </summary>
        /// <returns></returns>
        public static System.ServiceModel.Channels.Binding BuildBinding()
        {
            var binding = new BasicHttpBinding();
            binding.MaxReceivedMessageSize = int.MaxValue;
            binding.MaxBufferSize = int.MaxValue;
            binding.MaxBufferPoolSize = int.MaxValue;
            binding.ReaderQuotas = new XmlDictionaryReaderQuotas();
            binding.ReaderQuotas.MaxDepth = int.MaxValue;
            binding.ReaderQuotas.MaxStringContentLength = int.MaxValue;
            binding.ReaderQuotas.MaxArrayLength = int.MaxValue;
            binding.ReaderQuotas.MaxBytesPerRead = int.MaxValue;
            binding.ReaderQuotas.MaxNameTableCharCount = int.MaxValue;
            binding.CloseTimeout = new TimeSpan(0, 5, 0);  //超时的时间5分钟
            binding.OpenTimeout = new TimeSpan(0, 5, 0);
            binding.ReceiveTimeout = new TimeSpan(0, 10, 0);
            binding.SendTimeout = new TimeSpan(0, 5, 0);
            binding.AllowCookies = false;
            binding.BypassProxyOnLocal = false;
            binding.HostNameComparisonMode = HostNameComparisonMode.StrongWildcard;
            binding.MaxBufferSize = 2147483647;
            binding.MaxBufferPoolSize = 2147483647;
            binding.MaxReceivedMessageSize = 2147483647;
            binding.MessageEncoding = WSMessageEncoding.Text;
            binding.TextEncoding = UTF8Encoding.UTF8;
            binding.TransferMode = TransferMode.Buffered;
            binding.UseDefaultWebProxy = true;
            binding.ReaderQuotas.MaxDepth = 32;
            binding.ReaderQuotas.MaxStringContentLength = 8192;
            binding.ReaderQuotas.MaxArrayLength = 16384;
            binding.ReaderQuotas.MaxBytesPerRead = 4096;
            binding.ReaderQuotas.MaxNameTableCharCount = 16384;
            binding.Security.Mode = BasicHttpSecurityMode.None;
            binding.Security.Transport.ClientCredentialType = HttpClientCredentialType.None;
            binding.Security.Transport.ProxyCredentialType = HttpProxyCredentialType.None;
            binding.Security.Message.ClientCredentialType = BasicHttpMessageCredentialType.UserName;
            binding.Security.Message.AlgorithmSuite = System.ServiceModel.Security.SecurityAlgorithmSuite.Default;
            
            return binding;
        }

        public static string aBaseSerURL = "/BaseSer.asmx";
        

        public static string aBasicServiceURL = "/BasicService.asmx";
        

        public static string aConfigURL = "/Config.asmx";
        

        public static string aUserSerURL = "/UserSer.asmx";

        public static string aWangDaSerURL = "/WangDaSer.asmx";

        public static string BaseSerURL = "/BaseSer.asmx";
        

        public static string BasicServiceURL = "/BasicService.asmx";
        

        public static string ConfigURL = "/Config.asmx";
        

        public static string UserSerURL = "/UserSer.asmx";


        public static string WangDaSerURL = "/WangDaSer.asmx";




        /// <summary>
        /// 设置服务地址
        /// </summary>
        /// <param name="httpHost"></param>
        public  static void SetWebURL(string httpHost)
        {
           
            string mainHost = httpHost.Replace("2849", "2849").Replace("2849", "2849").Replace("2849", "2849");

            BaseSerURL = "http://" + mainHost + aBaseSerURL;
            BasicServiceURL = "http://" + mainHost + aBasicServiceURL;
            ConfigURL = "http://" + mainHost + aConfigURL;
            UserSerURL = "http://" + mainHost + aUserSerURL;
            WangDaSerURL = "http://" + mainHost + aWangDaSerURL;
        }



    }
}
