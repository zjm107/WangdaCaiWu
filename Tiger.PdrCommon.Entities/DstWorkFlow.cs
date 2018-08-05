using System;
using System.Data;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using System.Runtime.Serialization.Formatters;
using Tiger.Entities;
using Tiger.Tools;

namespace Tiger.PdrCommon.Entities {


    partial class DstWorkFlow
    {

        /// <summary>
        /// 获取全部工作流信息
        /// </summary>
        public void GetAllWorkFlow()
        {

                   DataSet dst = SysTools.basicService.GetAllWorkFlow();
                DataManager.ImpDataSet(dst.Tables[0], this.TS_WorkFlow);

        }
        /// <summary>
        /// 保存工作流信息
        /// </summary>
        public void SaveWorkFlow()
        {
            DataTable tb = TS_WorkFlow.GetChanges();
            if (tb != null)
            {
                DataSet dst = new DataSet();
                dst.Tables.Add(tb);
                    SysTools.basicService.SaveWorkFlow(dst);
            }
        }
        /// <summary>
        /// 获取是否强制质检
        /// </summary>
        /// <returns></returns>
        public bool  GetQualityEnable()
        {
            GetAllWorkFlow();
            DataRow[] rows = TS_WorkFlow.Select("流程名称='强制质检'");
            if (rows.Length > 0)
            {
                return  bool.Parse(rows[0]["有效"].ToString());
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 获取是否强制采购
        /// </summary>
        /// <returns></returns>
        public bool GetProcurementEnable()
        {
            GetAllWorkFlow();
            DataRow[] rows = TS_WorkFlow.Select("流程名称='强制采购计划'");
            if (rows.Length > 0)
            {
                return bool.Parse(rows[0]["有效"].ToString());
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 获取流程是否好用
        /// </summary>
        /// <param name="flowName"></param>
        /// <returns></returns>
        public bool GetEnable(string flowName)
        {
            GetAllWorkFlow();
            DataRow[] rows = TS_WorkFlow.Select("流程名称='"+ flowName +"'");
            if (rows.Length > 0)
            {
                return bool.Parse(rows[0]["有效"].ToString());
            }
            else
            {
                return false;
            }
        }



    }
}
