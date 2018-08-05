using System;
using System.Data;
using Tiger.Entities;
using Tiger.Tools;
namespace Tiger.PdrCommon.Entities.Basic {
    
    
    public partial class DstWorkFlowConfig {
        /// <summary>
        /// 获取所有的工作流
        /// </summary>
        public void GetWorkFlow()
        {
            try
            {
                DataSet dst = SysTools.basicService.GetWorkFlow();
                this.TWD_WORKFLOW.Clear();
                DataManager.ImpDataSet(dst.Tables["TWD_WORKFLOW"], this.TWD_WORKFLOW);
                this.TWD_WORKFLOW.AcceptChanges();
            }
            catch (Exception ex)
            {
                
                throw new Exception("DataSet获取所有的工作流方法GetWorkFlow出错"+ex.Message+ex.InnerException);
            }
        }
        /// <summary>
        /// 获取指定的工作流,重载
        /// </summary>
        /// <param name="flowName"></param>
        public void GetWorkFlow(string flowName)
        {
            try
            {
                DataSet dst = SysTools.basicService.GetWorkFlow(flowName);
                this.TWD_WORKFLOW.Clear();
                DataManager.ImpDataSet(dst.Tables["TWD_WORKFLOW"], this.TWD_WORKFLOW);
                this.TWD_WORKFLOW.AcceptChanges();
            }
            catch (Exception ex)
            {
                
                throw new Exception("DataSet获取指定的工作流方法GetWorkFlow出错"+ex.Message+ex.InnerException);
            }
        }
        /// <summary>
        /// 获取所有的工作流名称
        /// </summary>
        /// <returns></returns>
        public DataSet GetWorkFlowName()
        {
           DataSet dst=SysTools.basicService.GetWorkFlowName();
           return dst;
        }
        /// <summary>
        /// 获取所有工作流详细
        /// </summary>
        public void GetAllWorkFlowNameDetail()
        {
            try
            {
                DataSet dst = SysTools.basicService.GetAllWorkFlowNameDetail();
                this.TWD_WORKFLOW_DETAIL.Clear();
                DataManager.ImpDataSet(dst.Tables["TWD_WORKFLOW_DETAIL"], this.TWD_WORKFLOW_DETAIL);
                this.TWD_WORKFLOW_DETAIL.AcceptChanges();
            }
            catch (Exception ex)
            {
                
                throw new Exception("DataSet获取工作流详细方法GetAllWorkFlowNameDetail出错"+ex.Message+ex.InnerException);
            }
        }

        /// <summary>
        /// 获取工作流详细
        /// </summary>
        public void GetWorkFlowNameDetail(string flowName)
        {
            try
            {
                DataSet dst = SysTools.basicService.GetWorkFlowNameDetail(flowName);
                this.TWD_WORKFLOW_DETAIL.Clear();
                DataManager.ImpDataSet(dst.Tables["TWD_WORKFLOW_DETAIL"], this.TWD_WORKFLOW_DETAIL);
                this.TWD_WORKFLOW_DETAIL.AcceptChanges();
            }
            catch (Exception ex)
            {
                
                throw new Exception("DataSet获取工作流详细方法GetWorkFlowNameDetail出错"+ex.Message+ex.InnerException);
            }
        }
        /// <summary>
        /// 保存
        /// </summary>
        public void Save()
        {
            try
            {
                DataSet dstFlow = new DataSet();
                DataTable tbFlow = this.TWD_WORKFLOW.GetChanges();
                if (tbFlow != null)
                {
                    dstFlow.Tables.Add(tbFlow);
                    SysTools.basicSer.SaveTable(dstFlow, "TWD_WORKFLOW");
                }
                this.TWD_WORKFLOW.AcceptChanges();
                DataSet dstFlowDetail = new DataSet();
                DataTable tbFlowDetail = this.TWD_WORKFLOW_DETAIL.GetChanges();
                if (tbFlowDetail != null)
                {
                    dstFlowDetail.Tables.Add(tbFlowDetail);
                    SysTools.basicSer.SaveTable(dstFlowDetail, "TWD_WORKFLOW_DETAIL");
                }
                this.TWD_WORKFLOW_DETAIL.AcceptChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("DataSet保存方法出错"+ex.Message+ex.InnerException);
            }
        }
    }
}
