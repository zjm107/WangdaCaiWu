using System;
using System.Data;
using Tiger.Tools;
namespace WangDaDll.Common
{


    partial class BusinessDataSet
    {
        public SysTools DBHelper = new SysTools();
        /// <summary>
        /// 获取业务登记信息
        /// </summary>
        /// <param name="businessMan">业务员</param>
        /// <param name="beginRegDate">登记时间</param>
        /// <param name="endRegDate">登记结束时间</param>
        /// <param name="companyName">公司名称</param>
        /// <param name="isPayment">是否付款</param>
        /// <param name="regState">注册进度</param>
        /// <param name="wqState">外勤进度</param>
        public void GetBusinessRegData(string businessMan, string beginRegDate, string endRegDate, string companyName
            , string isPayment, string regState, string wqState, string deptname, string regTag, string wqTag, string frmType,string fBeginDate,string fEndDate)
        {
            try
            {
                DataSet dst = DBHelper.WangDaSer.GetBusinessRegData(businessMan, beginRegDate, endRegDate, companyName,
                    isPayment, regState, wqState, deptname, regTag, wqTag, frmType,fBeginDate,fEndDate);
                dst.Tables[0].ImpDataSet(TW_BusinessReg);
            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }
        }
        /// <summary>
        /// 根据客户名称获取客户ID
        /// </summary>
        /// <param name="clientName"></param>
        /// <returns></returns>
        public string GetClientId(string clientName)
        {
            string clientId = DBHelper.WangDaSer.GetClientId(clientName);
            return clientId;
        }


        /// <summary>
        /// 查询可以编辑的信息
        /// </summary>
        /// <param name="businessMan"></param>
        /// <param name="beginRegDate"></param>
        /// <param name="endRegDate"></param>
        /// <param name="companyName"></param>
        /// <param name="isPayment"></param>
        /// <param name="regState"></param>
        /// <param name="wqState"></param>
        /// <param name="deptname"></param>
        /// <param name="regTag"></param>
        /// <param name="wqTag"></param>
        /// <param name="regMan"></param>
        /// <param name="wqMan"></param>
        /// <param name="frmType"></param>
        /// <param name="bdae">完成开始时间</param>
        ///<param name="eDate">完成结束时间</param>
        public void GetBusinessRegDataEdit(string businessMan, string beginRegDate, string endRegDate, string companyName
           , string isPayment, string regState, string wqState, string deptname, string regTag, string wqTag, string frmType, string regWC,string bdae,string eDate)
        {
            try
            {
                DataSet dst = DBHelper.WangDaSer.GetBusinessRegDataEdit(businessMan, beginRegDate, endRegDate, companyName,
                    isPayment, regState, wqState, deptname, regTag, wqTag, frmType, regWC, bdae, eDate);
                dst.Tables[0].ImpDataSet(TW_BusinessReg);
            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }
        }
        /// <summary>
        /// 根据ID获取业务登记信息
        /// </summary>
        /// <param name="TW_BusinessRegID"></param>
        public void GetBusinessRegByID(string TW_BusinessRegID)
        {
            try
            {
                DataSet dst = DBHelper.WangDaSer.GetBusinessRegByID(TW_BusinessRegID);

                var row = TW_BusinessReg.FindByTW_BusinessRegID(TW_BusinessRegID);
                if (row == null)
                {
                    TW_BusinessReg.ImportRow(dst.Tables[0].Rows[0]);
                    TW_BusinessReg.AcceptChanges();
                }
                else
                {
                    row.Delete();
                    TW_BusinessReg.AcceptChanges();
                    TW_BusinessReg.ImportRow(dst.Tables[0].Rows[0]);
                    TW_BusinessReg.AcceptChanges();

                }
            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }
        }

        /// <summary>
        /// 保存业务登记信息
        /// </summary>
        public void SaveTable()
        {
            DataTable tb = TW_BusinessReg.GetChanges();
            if (tb != null)
            {
                DataSet dst = new DataSet();
                dst.Tables.Add(tb);
                DBHelper.BasicSer.SaveTable(dst, "TW_BusinessReg");
            }

        }



        /// <summary>
        /// 获取审批数据
        /// </summary>
        /// <param name="businessMan"></param>
        /// <param name="beginRegDate"></param>
        /// <param name="endRegDate"></param>
        /// <param name="companyName"></param>
        /// <param name="isPayment"></param>
        /// <param name="regState"></param>
        /// <param name="wqState"></param>
        /// <param name="deptName"></param>
        /// <param name="regTag"></param>
        /// <param name="wqTag"></param>
        /// <param name="regMan"></param>
        /// <param name="wqMan"></param>
        /// <param name="isExamine"></param>
        public void GetBusinessExamineData(string businessMan, string beginRegDate, string endRegDate, string companyName
        , string isPayment, string regState, string wqState, string deptName
        , string regTag, string wqTag, string isExamine)
        {
            try
            {
                DataSet dst = DBHelper.WangDaSer.GetBusinessExamineData(businessMan, beginRegDate, endRegDate, companyName
        , isPayment, regState, wqState, deptName
        , regTag, wqTag, isExamine);
                DataManager.ImpDataSet(dst.Tables[0], this.TW_BusinessReg);
            }
            catch (Exception ex)
            {
                UserMessages.ShowInfoBox(ex.Message);
            }
        }



    }
}
