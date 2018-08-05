using System;
using System.Data;
using System.Windows.Forms;
using Tiger.Tools;

namespace Tiger.ConfigApp
{
    /// <summary>
    /// 
    /// </summary>
    public static class SysTools
    {


        static SysTools()
        {
           
            string serverIP = ReflectionHelper.GetUrl("ServerIP");
            if (serverIP.Trim() == "")
                serverIP = "localhost";
            HyCommon.WebServiceConfig.SetWebURL(serverIP);
            basicSer = new BaseSerReference.BaseSerSoapClient();
            basicSer.Endpoint.Address = new System.ServiceModel.EndpointAddress(HyCommon.WebServiceConfig.BaseSerURL);

            
            basicService = new BasicServiceReference.BasicServiceSoapClient();
            basicService.Endpoint.Address = new System.ServiceModel.EndpointAddress(HyCommon.WebServiceConfig.BasicServiceURL);

            userSer = new UserSerReference.UserSerSoapClient();
            userSer.Endpoint.Address = new System.ServiceModel.EndpointAddress(HyCommon.WebServiceConfig.UserSerURL);

            config = new ConfigReference.ConfigSoapClient();
            config.Endpoint.Address = new System.ServiceModel.EndpointAddress(HyCommon.WebServiceConfig.ConfigURL);

        }
        public static BaseSerReference.BaseSerSoapClient basicSer;
        
        public static BasicServiceReference.BasicServiceSoapClient  basicService;
       
        public static UserSerReference.UserSerSoapClient userSer;

        public static ConfigReference.ConfigSoapClient config;
        
  
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static DateTime GetServerDateTime()
        {
            try
            {
                DateTime sysDate = DateTime.Now;
                //using (BasicDataService.BasicDataServiceSysTools.Bser = new BasicDataService.BasicDataService())
                //{
                //   SysTools.Bser.Url = ReflectionHelper.GetUrl("BasicDataService");
                //   SysTools.Bser.Credentials = System.Net.CredentialCache.DefaultCredentials;
                sysDate = SysTools.basicSer.GetSysDate();
                //}
                return sysDate;
            }
            catch (Exception ex)
            {
                throw new Exception("获取系统时间出错:" + ex.Message);
            }
        }

        /// <summary>
        ///  现实应用程序的form 
        /// </summary>
        /// <param name="pstrModleName"></param>
        /// <param name="FrmMDI"></param>
        /// <returns></returns>
        public static Form showAppForm(string pstrModleName, Form FrmMDI)
        {
            Form frm = null;
            if (modleData.Tables.Count > 0)
            {

                //if (!m_SystemMenu.menuTreeList.ContainsKey(pstrModleName))
                //{
                //    return frm;
                //}
                DataRow[] rows = modleData.Tables["TS_Model"].Select("ModelName='" + pstrModleName + "'");
                if (rows.Length > 0)
                {

                    string strFrmModleName = rows[0]["CodeType"].ToString();
                    string strTitle = rows[0]["Title"].ToString();
                    frm = ReflectionHelper.ShowChildMDI(strFrmModleName, FrmMDI, strTitle);
                    if (frm != null)
                    {
                        //Form ChildFrm = frm as Form;
                        //if (ChildFrm != null)
                        //{
                        //    ChildFrm.AllowSave = mNode.AllowSave;
                        //    ChildFrm.AllowQuery = mNode.AllowQuery;
                        //    ChildFrm.OtherOperation = mNode.OtherOperation;
                        //    ChildFrm.AllowAdd = mNode.AllowAdd;
                        //    ChildFrm.AllowDelete = mNode.AllowDelete;
                        //    ChildFrm.AllEdit = btnCheck.Checked;
                        //}
                        //Console.WriteLine(frm.Name);
                        frm.Show();
                    }
                }
                else
                {
                    Console.WriteLine("没有找到'" + pstrModleName + "'关联的窗体！");

                }
            }
            else
            {
                Console.WriteLine("没有发现系统模块配置信息！");
            }
            return frm;
        }

        public static Form showAppForm(string className, string title, Form FrmMDI)
        {
            Form frm = null;
            frm = ReflectionHelper.ShowChildMDI(className, FrmMDI, title);
            if (frm != null)
            {
                frm.Show();
            }
            return frm;
        }

        /// <summary>
        /// menuModle
        /// </summary>
        public static DataSet modleData = new DataSet();

        /// <summary>
        /// 系统菜单
        /// </summary>
        public static MenuTree m_SystemMenu;

    }
}
