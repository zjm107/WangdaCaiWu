﻿using System;
using System.Data;
using System.Web.Services;
using Tiger.CoreClass.Data;

namespace WDServer
{
    /// <summary>
    /// 2020年7月29日更新
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。
    // [System.Web.Script.Services.ScriptService]
    public class WangDaSer : System.Web.Services.WebService
    {
        /// <summary>
        /// 检查公司名称
        /// </summary>
        /// <param name="companyName"></param>
        /// <returns></returns>
        [WebMethod]
        public bool CheckCompanyName(string companyName)
        {
            string strSql = string.Format("select COUNT(*) from [dbo].[TW_Client] where 客户名称 ='{0}'", companyName);
            DataSet dst = ServiceManager.GetDatabase().GetEntity(strSql, "TW_Client");
            int count = int.Parse(dst.Tables[0].Rows[0][0].ToString());
            if (count > 0)
                return true;
            else
                return false;
        }
        [WebMethod]
        public void UpdateCUserID()
        {
            var db = ServiceManager.GetDatabase();

            string exeSql = @"update [dbo].[TW_Client]
            set 注册员ID=(select top 1 注册员ID from[dbo].[TW_BusinessReg] where [TW_Client].客户名称 =[TW_BusinessReg].公司预核名称)
     where 注册员ID is null";
            db.ExecuteNonQuery(exeSql);
            exeSql = @"update[dbo].[TW_Client]
        set 注册员 = (select top 1 注册员 from[dbo].[TW_BusinessReg] where [TW_Client].客户名称 =[TW_BusinessReg].公司预核名称)
   where 注册员 is null";
            db.ExecuteNonQuery(exeSql);
            exeSql = @"update[dbo].[TW_Client]
        set 业务员 = (select top 1 业务员 from[dbo].[TW_BusinessReg] where [TW_Client].客户名称 =[TW_BusinessReg].公司预核名称 and 业务员 is not null )
    where 业务员 is null";
            db.ExecuteNonQuery(exeSql);
            exeSql = @"update[dbo].[TW_Client]
        set 业务员ID = (select top 1 业务员ID from[dbo].[TW_BusinessReg] where [TW_Client].客户名称 =[TW_BusinessReg].公司预核名称 and 业务员ID is not null )
   where 业务员ID is null";
            db.ExecuteNonQuery(exeSql);

            exeSql = @"update [dbo].[TW_Client] 
    set 首年提成结束期 = DATEADD(MONTH,12, 初始做账时间)
    where 首年提成结束期 is null and 初始做账时间 is not null";
            db.ExecuteNonQuery(exeSql);

            exeSql = @"update [dbo].[TW_Client]
    set [首年提成结束期] = dateadd(mm,12, [初始做账时间])
    where [首年提成结束期]  is null and [初始做账时间] is not null";
            db.ExecuteNonQuery(exeSql);

            exeSql = @"update [dbo].[TW_Client]
set [TW_Client].首年提成结束期=DATEADD(month,12,[TW_Client].初始做账时间)
where 初始做账时间>'1900-1-1'
and 首年提成结束期 is null";

            db.ExecuteNonQuery(exeSql);

            exeSql = @"update  [dbo].[TW_BusinessReg] 
set 首年提成结束期 =(select DATEADD(year,1,初始做账时间)  from [dbo].[TW_Client] where TW_Client.客户名称 = TW_BusinessReg.公司预核名称
and TW_Client.初始做账时间 is not null )";
            db.ExecuteNonQuery(exeSql);

        }

        /// <summary>
        /// 更新UserID
        /// </summary>
        [WebMethod]
        public void UpdateUserID()
        {
            var db = ServiceManager.GetDatabase();


            string exeSql = @"update [dbo].[TW_Client]
set 做账会计ID = (
 select USERID from[dbo].[TCOM_USER]
        where USERNAME = [TW_Client].做账会计)
		where [TW_Client].做账会计ID is null and ([TW_Client].客户状态 is null or [TW_Client].客户状态!='注销' and [TW_Client].客户状态!='取走')";
            db.ExecuteNonQuery(exeSql);

            exeSql = @"update [TW_Payment]
set 做账会计ID = (
 select USERID from[dbo].[TCOM_USER]
        where USERNAME = [TW_Payment].做账会计)
        where TW_Payment.做账会计ID is null";
            db.ExecuteNonQuery(exeSql);

            exeSql = @"update [TW_Payment]
set 注册员ID =(
 select USERID  from[dbo].[TCOM_USER]
        where USERNAME = [TW_Payment].注册员)
        where TW_Payment.注册员ID is null";
            db.ExecuteNonQuery(exeSql);

            exeSql = @" update [TW_Payment]
set 业务员ID =(
 select USERID  from[dbo].[TCOM_USER]
        where USERNAME = [TW_Payment].业务员)
         where TW_Payment.业务员ID is null ";
            db.ExecuteNonQuery(exeSql);

            exeSql = @" update [TW_PaymentDetail]
set 注册员ID = (select USERID from[dbo].[TCOM_USER] where[USERNAME]=[TW_PaymentDetail].注册员 )
where 注册员<>'' and 注册员ID = ''";
            db.ExecuteNonQuery(exeSql);

            exeSql = @"update [dbo].[TW_Client]
set [TW_Client].首年提成结束期=DATEADD(month,12,[TW_Client].初始做账时间)
where 初始做账时间>'1900-1-1'
and 首年提成结束期 is null and ([TW_Client].客户状态 is null or [TW_Client].客户状态!='注销' and [TW_Client].客户状态!='取走')";
            db.ExecuteNonQuery(exeSql);
            exeSql = @"update  [dbo].[TW_BusinessReg] 
set 首年提成结束期 =(select DATEADD(year,1,初始做账时间)  from [dbo].[TW_Client] where TW_Client.客户名称 = TW_BusinessReg.公司预核名称
and TW_Client.初始做账时间 is not null )";
            db.ExecuteNonQuery(exeSql);
            exeSql = @"update [dbo].[TW_Client]
            set [TW_Client].费用到期月份 = (select [aaa].费用到期月份 from [aaa] where [aaa].客户名称ID=[TW_Client].客户名称ID  )
             where ([TW_Client].客户状态 is null or [TW_Client].客户状态!='注销' and [TW_Client].客户状态!='取走')";
            db.ExecuteNonQuery(exeSql);
        }

        /// <summary>
        /// 根据客户名称获取ID
        /// </summary>
        /// <param name="clientName"></param>
        /// <returns></returns>
        [WebMethod]
        public string GetClientId(string clientName)
        {
            string strSql = string.Format(@"select t.客户名称ID from[dbo].[TW_Client] t where t.客户名称='{0}'", clientName);
            DataSet dst = ServiceManager.GetDatabase().GetEntity(strSql, "TW_Client");
            if (dst.Tables[0].Rows.Count > 0)
                return dst.Tables[0].Rows[0][0].ToString();
            else
                return "";
        }

        /// <summary>
        /// 根据外键查询附件
        /// </summary>
        /// <param name="fkID"></param>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetImage(string fkID, string fileType)
        {
            string strSql = string.Format(@"select [fileName],FileID,FKID,uploader,Upload_Date,FileType from [dbo].[TF_FILE] where FKID='{0}' and FileType='{1}'", fkID, fileType);
            DataSet dst = ServiceManager.GetDatabase("FileDB").GetEntity(strSql, "TF_FILE");
            return dst;
        }
        /// <summary>
        /// 按照批次号删除
        /// </summary>
        /// <param name="pch"></param>
        [WebMethod]
        public void DelByPCH(string pch)
        {
            string strsql = "delete from [TW_Payment] where 批次号='"+pch+"'";
            var db = ServiceManager.GetDatabase();
            db.ExecuteNonQuery(strsql);
            strsql = "delete from [TW_PaymentMain] where 批次号='"+ pch + "'";
            db.ExecuteNonQuery(strsql);
        }

        /// <summary>
        /// 根据ID获取图片信息
        /// </summary>;
        /// <param name="FileID"></param>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetImagebyID(string FileID)
        {
            string strSql = string.Format(@"select * from TF_FILE where FileID ='{0}'", FileID);
            DataSet dst = ServiceManager.GetDatabase("FileDB").GetEntity(strSql, "TF_FILE");
            return dst;
        }

        /// <summary>
        /// 获取客户信息
        /// </summary>
        /// <param name="clientName">客户名称</param>
        /// <param name="clientType">客户类别</param>
        /// <param name="clientLevel">客户级别</param>
        /// <param name="clientPropety">客户性质</param>
        /// <param name="accountant">做账会计</param>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetClientInfo(string clientName, string clientType, string clientLevel, string clientPropety, string accountant, string clientState)
        {
            try
            {
                string strSql = "select * from VTW_Client where 1=1 ";
                if (!string.IsNullOrEmpty(clientName))
                {
                    strSql += " and [客户名称] like '%" + clientName + "%'";
                }
                if (!string.IsNullOrEmpty(clientType))
                {
                    strSql += " and [公司类型] like '%" + clientType + "%'";
                }
                if (!string.IsNullOrEmpty(clientLevel))
                {
                    strSql += " and [客户分级] like '%" + clientLevel + "%'";
                }
                if (!string.IsNullOrEmpty(clientPropety))
                {
                    strSql += " and [公司性质] like '%" + clientPropety + "%'";
                }
                if (!string.IsNullOrEmpty(accountant))
                {
                    strSql += " and (业务员 like '%" + accountant + "%' or 注册员 like '%" + accountant + "%' or 做账会计 like '%" + accountant + "%')";
                }

                if (!string.IsNullOrEmpty(clientState))
                {
                    strSql += " and isnull(客户状态,'')='" + clientState + "'";
                }
                else
                {
                    strSql += @" and isnull(客户状态,'')<>'转让'
                                and isnull(客户状态,'')<> '注销'
                                and isnull(客户状态,'')<> '非正常'
                                and isnull(客户状态,'')<> '取走'";
                }
                DataSet dst = ServiceManager.GetDatabase().GetEntity(strSql, "TW_Client");
                return dst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 查询到期做账客户信息
        /// </summary>
        /// <param name="clientName"></param>
        /// <param name="clientType"></param>
        /// <param name="clientLevel"></param>
        /// <param name="clientPropety"></param>
        /// <param name="accountant"></param>
        /// <param name="endDate">到期月份</param>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetEndDateClient(string clientName, string clientType, string clientLevel, string clientPropety, string accountant, string endDate)
        {
            try
            {
                string strSql = "select * from VTW_Client where 1=1 ";
                if (!string.IsNullOrEmpty(clientName))
                {
                    strSql += " and [客户名称] like '%" + clientName + "%'";
                }
                if (!string.IsNullOrEmpty(clientType))
                {
                    strSql += " and [公司类型] like '%" + clientType + "%'";
                }
                if (!string.IsNullOrEmpty(clientLevel))
                {
                    strSql += " and [客户分级] like '%" + clientLevel + "%'";
                }
                if (!string.IsNullOrEmpty(clientPropety))
                {
                    strSql += " and [公司性质] like '%" + clientPropety + "%'";
                }
                if (!string.IsNullOrEmpty(accountant))
                {
                    strSql += " and (业务员 like '%" + accountant + "%' or 注册员 like '%" + accountant + "%' or 做账会计 like '%" + accountant + "%')";
                }
                if (!string.IsNullOrEmpty(endDate))
                {
                    DateTime paymentEndDate = DateTime.Parse(endDate);
                    int year = paymentEndDate.Year;
                    int month = paymentEndDate.Month;
                    strSql += " and ((Year(费用到期月份)=" + year.ToString() + " and Month(费用到期月份)=" + month + ") or 费用到期月份 is null ) ";
                }
                DataSet dst = ServiceManager.GetDatabase().GetEntity(strSql, "TW_Client");
                return dst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 根据客户名称查询出唯一客户信息
        /// </summary>
        /// <param name="clientName"></param>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetSingleClient(string clientName)
        {
            try
            {
                string strSql = "select * from VTW_Client where [客户名称] like '" + clientName + "%'";
                DataSet dst = ServiceManager.GetDatabase().GetEntity(strSql, "TW_Client");
                return dst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 获取业务注册信息
        /// </summary>
        /// <param name="businessMan">业务员</param>
        /// <param name="beginRegDate">登记开始时间</param>
        /// <param name="endRegDate">登记结束时间</param>
        /// <param name="companyName">公司名称</param>
        /// <param name="isPayment">是否付款</param>
        /// <param name="regState">注册状态</param>
        /// <param name="wqState">外勤状态</param>
        /// <param name="deptName">注册部门</param>
        /// <param name="regTag">注册标记</param>
        /// <param name="wqTag">外勤标记</param>
        /// <param name="frmType">业务登记，注册管理，做账管理</param>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetBusinessRegData(string businessMan, string beginRegDate, string endRegDate, string companyName
            , string isPayment, string regState, string wqState, string deptName
            , string regTag, string wqTag, string frmType, string FbeginDate, string FendDate)
        {
            try
            {
                string strSql = "select * from TW_BusinessReg where 1=1 ";

                if (!string.IsNullOrEmpty(beginRegDate))
                {
                    strSql += " and 登记日期>='" + beginRegDate + "'";
                }
                if (!string.IsNullOrEmpty(endRegDate))
                {
                    strSql += " and 登记日期<='" + endRegDate + "'";
                }
                if (!string.IsNullOrEmpty(companyName))
                {
                    strSql += " and 公司预核名称 like '%" + companyName + "%'";
                }
                if (isPayment == "是")
                {
                }
                else if (isPayment == "否") { }
                if (!string.IsNullOrEmpty(regState))
                {
                    strSql += " and 注册进度 = '" + regState + "'";
                }
                if (!string.IsNullOrEmpty(wqState))
                {
                    strSql += " and 外勤进度 like '%" + wqState + "%'";
                }

                switch (deptName)
                {
                    case "业务部":
                        strSql += " and 部门 ='" + deptName + "'";
                        break;

                    case "注册部":
                        break;

                    case "做账部":
                        break;
                }

                //if (!string.IsNullOrEmpty(deptName))
                //{
                //    if (frmType == "业务登记")
                //    {
                //        strSql += " and 部门 ='" + deptName + "'";
                //    }
                //    else
                //    { }
                //    //switch (deptName)
                //    //{
                //    //    case "业务部":
                //    //        break;
                //    //    case "注册部":
                //    //        break;
                //    //    case "做账部":
                //    //        break;
                //    //}

                //}
                if (!string.IsNullOrEmpty(regTag))
                {
                    if (regTag == "是")
                    {
                        strSql += " and 注册派单标记=1 ";
                    }
                    else if (regTag == "否")
                    {
                        strSql += " and 注册派单标记=0 ";
                    }
                }
                if (!string.IsNullOrEmpty(regState))
                {
                    if (regState == "是")
                    {
                        strSql += " and 外勤派单标记=1 ";
                    }
                    else if (regState == "否")
                    {
                        strSql += " and 外勤派单标记=0 ";
                    }
                }

                if (!string.IsNullOrEmpty(businessMan))
                {
                    strSql += string.Format(" and ( 业务员 ='{0}'  or  注册员 ='{1}' or  做账会计='{1}') ", businessMan, businessMan, businessMan);
                }

                if (!string.IsNullOrEmpty(FbeginDate))
                {
                    strSql += " and 注册完成时间>='" + FbeginDate + "'";
                }

                if (!string.IsNullOrEmpty(FendDate))
                {
                    strSql += " and 注册完成时间<='" + FendDate + "'";
                }

                DataSet dst = ServiceManager.GetDatabase().GetEntity(strSql, "TW_BusinessReg");
                return dst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 获取注册编辑
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
        /// <param name="frmType"></param>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetBusinessRegDataEdit(string businessMan, string beginRegDate, string endRegDate, string companyName
            , string isPayment, string regState, string wqState, string deptName
            , string regTag, string wqTag, string frmType, string regWC, string fBeginDate, string fEndDate)
        {
            try
            {
                string strSql = "select * from TW_BusinessReg where 1=1 ";
                if (regWC == "完成" || regWC == "已完成")
                {
                    strSql += " and ( 注册进度='完成' or 注册进度!='做账' ) ";
                }
                else if (regWC == "未完成")
                {
                    strSql += " and (注册进度 is null or 注册进度!='完成' or 注册进度!='做账') ";
                }

                if (!string.IsNullOrEmpty(businessMan))
                {
                    strSql += string.Format(" and ( 业务员 ='{0}'  or  注册员 ='{1}' or  做账会计='{2}' or [外勤员]='{3}') ", businessMan, businessMan, businessMan, businessMan);
                }

                if (!string.IsNullOrEmpty(beginRegDate))
                {
                    strSql += " and 登记日期>='" + beginRegDate + "'";
                }
                if (!string.IsNullOrEmpty(endRegDate))
                {
                    strSql += " and 登记日期<='" + endRegDate + "'";
                }
                if (!string.IsNullOrEmpty(companyName))
                {
                    strSql += " and 公司预核名称 like '%" + companyName + "%'";
                }
                if (isPayment == "是")
                {
                }
                else if (isPayment == "否") { }
                if (!string.IsNullOrEmpty(regState))
                {
                    strSql += " and 注册进度 = '" + regState + "'";
                }
                if (!string.IsNullOrEmpty(wqState))
                {
                    strSql += " and 外勤进度 like '%" + wqState + "%'";
                }
                switch (deptName)
                {
                    case "业务部":
                        strSql += " and 部门 ='" + deptName + "'";
                        break;

                    case "注册部":
                        break;

                    case "做账部":
                        break;
                }

                if (!string.IsNullOrEmpty(regTag))
                {
                    if (regTag == "是")
                    {
                        strSql += " and 注册派单标记=1 ";
                    }
                    else if (regTag == "否")
                    {
                        strSql += " and 注册派单标记=0 ";
                    }
                }
                if (!string.IsNullOrEmpty(wqTag))
                {
                    if (wqTag == "是")
                    {
                        strSql += " and isnull(外勤员,'')<>'' ";
                    }
                    else if (wqTag == "否")
                    {
                        strSql += " and isnull(外勤员,'')='' ";
                    }
                }
                if (!string.IsNullOrEmpty(fBeginDate))
                    strSql += " and 注册完成时间>='" + fBeginDate + "'";
                if (!string.IsNullOrEmpty(fBeginDate))
                    strSql += " and 注册完成时间<='" + fEndDate + "'";
                DataSet dst = ServiceManager.GetDatabase().GetEntity(strSql, "TW_BusinessReg");
                return dst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 获取业务注册信息根据ID
        /// </summary>
        /// <param name="TW_BusinessRegID"></param>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetBusinessRegByID(string TW_BusinessRegID)
        {
            try
            {
                string strSql = string.Format("select * from TW_BusinessReg where TW_BusinessRegID='{0}' ", TW_BusinessRegID);
                DataSet dst = ServiceManager.GetDatabase().GetEntity(strSql, "TW_BusinessReg");
                return dst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 获取审批的外勤做账单
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
        /// <returns></returns>
        [WebMethod]
        public DataSet GetBusinessExamineData(string businessMan, string beginRegDate, string endRegDate, string companyName
         , string isPayment, string regState, string wqState, string deptName
         , string regTag, string wqTag, string isExamine)
        {
            try
            {
                string strSql = "select * from TW_BusinessReg where 交接确认完成=1 ";
                if (!string.IsNullOrEmpty(businessMan))
                {
                    strSql += string.Format(" and ( 业务员 ='{0}'  or  注册员 ='{1}' or  做账会计='{1}') ", businessMan, businessMan, businessMan);
                }
                if (!string.IsNullOrEmpty(beginRegDate))
                {
                    strSql += " and 登记日期>='" + beginRegDate + "'";
                }
                if (!string.IsNullOrEmpty(endRegDate))
                {
                    strSql += " and 登记日期<='" + endRegDate + "'";
                }
                if (!string.IsNullOrEmpty(companyName))
                {
                    strSql += " and 公司预核名称 like '%" + companyName + "%'";
                }
                if (isPayment == "是")
                {
                }
                else if (isPayment == "否") { }
                if (!string.IsNullOrEmpty(regState))
                {
                    strSql += " and 注册进度 = '" + regState + "'";
                }
                if (!string.IsNullOrEmpty(wqState))
                {
                    strSql += " and 外勤进度 like '%" + wqState + "%'";
                }
                if (string.IsNullOrEmpty(deptName))
                {
                    strSql += " and 部门 ='%" + deptName + "%'";
                }
                if (!string.IsNullOrEmpty(regTag))
                {
                    if (regTag == "是")
                    {
                        strSql += " and 注册派单标记=1 ";
                    }
                    else if (regTag == "否")
                    {
                        strSql += " and 注册派单标记=0 ";
                    }
                }
                if (!string.IsNullOrEmpty(regState))
                {
                    if (regState == "是")
                    {
                        strSql += " and 外勤派单标记=1 ";
                    }
                    else if (regState == "否")
                    {
                        strSql += " and 外勤派单标记=0 ";
                    }
                }

                if (!string.IsNullOrEmpty(isExamine))
                {
                    if (isExamine == "是")
                    {
                        strSql += " and len(外勤审批确认)>0  ";
                    }
                    else
                    {
                        strSql += " and len(外勤审批确认)=0 ";
                    }
                }
                DataSet dst = ServiceManager.GetDatabase().GetEntity(strSql, "TW_BusinessReg");
                return dst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="businessMan">业务员</param>
        /// <param name="regMan">注册员</param>
        /// <param name="accountant">做账会计</param>
        /// <param name="isPayment">是否收款</param>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetNoPaymentReg(string accountant, string gsName, string isPayment)
        {
            string strSql = "select * from VW_PaymentDetail as t where 1=1 ";
            if (!string.IsNullOrEmpty(accountant))
            {
                strSql += " and  (t.做账会计 ='" + accountant + "' or t.业务员='" + accountant + "' or t.注册员='" + accountant + "') ";
            }
            if (!string.IsNullOrEmpty(isPayment))
            {
                if (isPayment == "未收款")
                {
                    strSql += " and t.注册费 > isnull(t.注册费收款额,0)  ";
                }
                else
                {
                    strSql += " and t.注册费 <= isnull(t.注册费收款额,0)  ";
                }
            }

            if (!string.IsNullOrEmpty(gsName))
            {
                strSql += " and t.公司预核名称 like '%" + gsName + "%' ";
            }
            DataSet dst = ServiceManager.GetDatabase().GetEntity(strSql, "VW_PaymentDetail");
            return dst;
        }

        /// <summary>
        /// 保存付款信息
        /// </summary>
        /// <param name="dst"></param>
        [WebMethod]
        public void SavePayment(DataSet dst)
        {
            ServiceManager.GetDatabase().StoreDataSet(dst);
        }

        /// <summary>
        /// 查询收款记录信息
        /// </summary>
        /// <param name="paymentID"></param>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetPayment(string paymentID)
        {
            string strSql = string.Format("select * from TW_Payment where TW_PaymentID='{0}'", paymentID);
            string strSqlDetail = string.Format("select * from TW_PaymentDetail where TW_PaymentID='{0}'", paymentID);
            DataSet dst = ServiceManager.GetDatabase().GetEntity(strSql, "TW_Payment");
            ServiceManager.GetDatabase().FillEntity(strSqlDetail, dst, "TW_PaymentDetail");
            return dst;
        }

        /// <summary>
        /// 获取付款信息
        /// </summary>
        /// <param name="clinetName">支付名称</param>
        /// <param name="account">做账会计</param>
        /// <param name="beginDate">支付开始时间</param>
        /// <param name="endDate">支付结束时间</param>
        /// <param name="paymentType">付款类型</param>
        /// <param name="endPaymentDate">到期月份</param>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetPaymentByInfo(string unitName, string account, string beginDate, string endDate, string paymentType
            , string endPaymentDate, string manager, string isPay, string zeroAccount)
        {
            string strPrc = "CalUserProc";
            SqlStruct prc = new SqlStruct(strPrc, CommandType.StoredProcedure);
            ServiceManager.GetDatabase().ExecuteNonQuery(prc);

            string strSql = @"select t.*,tc.初始做账时间,tc.首年提成结束期 from TW_Payment t  
                                left join [dbo].[TW_Client] tc
                                on t.客户名称ID =tc.客户名称ID where 1=1  ";

            string strSqlMain = @"select t.*,tc.初始做账时间,tc.首年提成结束期 from TW_PaymentMain t  
                                left join TW_Client tc
                                on t.客户名称ID = tc.客户名称ID where 1 = 1";
            if (!string.IsNullOrEmpty(unitName))
            {
                strSql += " and t.支付单位 like '%" + unitName + "%'";
                strSqlMain += " and t.支付单位 like '%" + unitName + "%'";
            }
            if (manager == "注册主管")
            {
                if (!string.IsNullOrEmpty(account))
                {
                    strSql += " and  (t.注册员='" + account + "') ";
                    strSqlMain += " and  (t.注册员='" + account + "') ";
                }

            }
            else
            if (!string.IsNullOrEmpty(account))
            {
                strSql += " and  ((t.做账会计 = '" + account + "' or t.业务员='" + account + "' or t.注册员='" + account +
                @"') or t.TW_PaymentID in ( select t2.TW_PaymentID from [dbo].[TW_PaymentDetail] t2 where t2.业务员 = '" + account + "' or 注册员 = '" + account + "' or 做账会计 = '" + account + "')) ";
                strSqlMain += " and  ((t.做账会计 = '" + account + "' or t.业务员='" + account + "' or t.注册员='" + account +
                @"') or t.TW_PaymentID in ( select t2.TW_PaymentID from [dbo].[TW_PaymentDetail] t2 where t2.业务员 = '" + account + "' or 注册员 = '" + account + "' or 做账会计 = '" + account + "')) ";
            }
            if (!string.IsNullOrEmpty(beginDate))
            {
                strSql += " and t.支付日期>='" + beginDate + "'";
                strSqlMain += " and t.支付日期>='" + beginDate + "'";

            }
            if (!string.IsNullOrEmpty(endDate))
            {
                strSql += " and t.支付日期<='" + endDate + "'";
                strSqlMain += " and t.支付日期<='" + endDate + "'";
            }
            if (!string.IsNullOrEmpty(paymentType))
            {
                strSql += " and t.收款类别 ='" + paymentType + "'";
                strSqlMain += " and t.收款类别 ='" + paymentType + "'";
            }
            if (!string.IsNullOrEmpty(endPaymentDate))
            {
                DateTime paymentEndDate = DateTime.Parse(endPaymentDate);
                int year = paymentEndDate.Year;
                int month = paymentEndDate.Month;
                strSql += " and Year(t.本次到期月份)=" + year.ToString() + " and Month(t.本次到期月份)=" + month;
                strSqlMain += " and Year(t.本次到期月份)=" + year.ToString() + " and Month(t.本次到期月份)=" + month;
            }

            if (isPay == "是")
            {
                strSql += " and t.不收款=1 ";
                strSqlMain += " and t.不收款=1 ";
            }
            else if (isPay == "否")
            {
                strSql += " and ( t.不收款=0 or t.不收款 is null ) ";
                strSqlMain += " and ( t.不收款=0 or t.不收款 is null ) ";
            }
            if (zeroAccount == "是")
            {
                strSql += " and t.零申报=1 ";
                strSqlMain += " and t.零申报=1 ";
            }
            else if (zeroAccount == "否")
            {
                strSql += " and ( t.零申报=0 or t.零申报 is null ) ";
                strSqlMain += " and ( t.零申报=0 or t.零申报 is null ) ";
            }

            DataSet dst = ServiceManager.GetDatabase().GetEntity(strSql, "TW_Payment");
            ServiceManager.GetDatabase().FillEntity(strSql, dst, "TW_PaymentMain");
            return dst;
        }

        /// <summary>
        /// 获取审批的收款信息
        /// </summary>
        /// <param name="spType"></param>
        /// <param name="unitName"></param>
        /// <param name="account"></param>
        /// <param name="beginDate"></param>
        /// <param name="endDate"></param>
        /// <param name="paymentType"></param>
        /// <param name="endPaymentDate"></param>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetPaymentByInfoSP(string spType, string unitName, string account, string beginDate, string endDate
            , string paymentType, string endPaymentDate, string isPay, string zeroAccount, string bcdqDate1, string bcdqDate2
            , string cszzDate1, string cszzDate2)
        {
            string strSql = @"
                            select t.*,t2.初始做账时间,t2.首年提成结束期 from TW_Payment t
                            left join[dbo].[TW_Client] t2
                            on t.客户名称ID =t2.客户名称ID where 1=1 ";
            if (!string.IsNullOrEmpty(unitName))
            {
                strSql += " and t.支付单位 like '%" + unitName + "%'";
            }
            if (!string.IsNullOrEmpty(account))
            {
                strSql += " and t.做账会计 like '%" + account + "%'";
            }
            if (!string.IsNullOrEmpty(beginDate))
            {
                strSql += " and t.支付日期>='" + beginDate + "'";
            }
            if (!string.IsNullOrEmpty(endDate))
            {
                strSql += " and t.支付日期<='" + endDate + "'";
            }
            if (!string.IsNullOrEmpty(paymentType))
            {
                strSql += " and t.收款类别 ='" + paymentType + "'";
            }
            if (!string.IsNullOrEmpty(endPaymentDate))
            {
                DateTime paymentEndDate = DateTime.Parse(endPaymentDate);
                int year = paymentEndDate.Year;
                int month = paymentEndDate.Month;
                strSql += " and Year(t.本次到期月份)=" + year.ToString() + " and Month(t.本次到期月份)=" + month;
            }
            if (spType == "未审批")
            {
                strSql += " and ( t.是否审核=0 or t.是否审核 is null )";
            }
            if (spType == "已审批")
            {
                strSql += " and t.是否审核=1 ";
            }
            if (isPay == "是")
            {
                strSql += " and t.不收款=1 ";
            }
            else if (isPay == "否")
            {
                strSql += " and ( t.不收款=0 or t.不收款 is null ) ";
            }
            if (zeroAccount == "是")
            {
                strSql += " and t.零申报=1 ";
            }
            else if (zeroAccount == "否")
            {
                strSql += " and ( t.零申报=0 or t.零申报 is null ) ";
            }

            if (!string.IsNullOrEmpty(bcdqDate1))
            {
                strSql += " and t.本次到期月份>='" + bcdqDate1 + "'";
            }

            if (!string.IsNullOrEmpty(bcdqDate2))
            {
                strSql += " and t.本次到期月份<='" + bcdqDate2 + "'";
            }
            if (!string.IsNullOrEmpty(cszzDate1))
            {
                strSql += " and t2.初始做账时间>='" + cszzDate1 + "'";
            }
            if (!string.IsNullOrEmpty(cszzDate2))
            {
                strSql += " and t2.初始做账时间<='" + cszzDate2 + "'";
            }
            DataSet dst = ServiceManager.GetDatabase().GetEntity(strSql, "TW_Payment");
            return dst;
        }

        /// <summary>
        /// 获取付款明细
        /// </summary>
        /// <param name="paymentID"></param>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetPaymentDetailID(string paymentID)
        {
            string strSql = string.Format("select * from TW_PaymentDetail where TW_PaymentID='{0}'", paymentID);
            DataSet dst = ServiceManager.GetDatabase().GetEntity(strSql, "TW_PaymentDetail");
            return dst;
        }

        #region 业务员 业绩统计

        /// <summary>
        /// 获取业务员业绩明细
        /// </summary>
        /// <param name="businessID"></param>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetBusinessSum(string businessID, int year, int month)
        {
            //获取一个业务员的做账费收款额
            string strSql = string.Format(@"select
        NEWID() as TW_SalarySumID,
        t.支付单位 as 客户名称,
        t.客户名称ID as 客户名称Id,
        t.支付金额 as 做账收款额,
        t.工本费 as 工本收款费,
        t.开票费 as 开票收款费,
        0 as 做账提成 ,
        0 as 工本费开票费提成,
        t.业务员 as 员工,
        t.业务员ID as 员工ID,
        t.支付日期,
        0 as 注册费收款额,
        0 as 注册提成,
        t.收款类别,
        t.月做账费,
        t.月做账费 * 12 as 年做账费,
        0 as 注册费,
        0 as 图章,
        0 as 银行,
        0 as 其他,
        0 as 注册利润,
        '业务员做账费' as 工资统计类型
        ,t2.初始做账时间
        ,t2.首年提成结束期
        ,t.本次到期月份
       from TW_Payment  t,[dbo].[TW_Client] t2
        where
		t.客户名称ID=t2.客户名称ID
        and t.本次到期月份 <= t2.首年提成结束期
        and  year(t.支付日期)= " + year + " and month(t.支付日期) = " + month + @"
        and t.收款类别 = '常规收款'
        and t.业务员ID = '{0}'
        and t.是否审核=1
        union
        select
        NEWID() as TW_SalarySumID,
        t.客户名称,
        t.客户名称ID,
        t.做账费收款额 as 做账收款额,
        t.工本费收款额 as 工本收款额,
        t.开票费收款额 as 开票收款额,
        0 as 做账提成,
        0 as 工本费开票费提成,
        t.业务员 as 员工,
        t.业务员ID as 员工ID,
        t.收款日期 as 支付日期,
        t.注册费收款额,
        0 as 注册提成,
        '注册收款' as 收款类别,
        t.月做账费 ,
        t.年做账费,
        t.注册费,
        t.图章,
        t.银行,
        t.其他,
        t.注册利润,
        '业务员注册费' as 工资统计类型
        ,t.初始做账时间
        ,t.首年提成结束期
        ,t.做账到期月
        from VW_PaymentDetail t
        where  t.注册费<=t.注册费收款额 and (注册类型='注册' or  注册类型='设立'
or 注册类型='变更' or 注册类型='注销')
        and Year(t.收款日期)=" + year + " and MONTH(t.收款日期)=" + month + @"
        and t.业务员ID='{1}'  ", businessID, businessID);
            DataSet dst = ServiceManager.GetDatabase().GetEntity(strSql, "TW_SalarySum");
            return dst;
        }



        /// <summary>
        /// 获取业务员业绩明细2021
        /// </summary>
        /// <param name="businessID"></param>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetBusinessSum2021(string businessID, int year, int month)
        {
            //获取一个业务员的做账费收款额
            string strSql = string.Format(@"select
        NEWID() as TW_SalarySumID,
        t.支付单位 as 客户名称,
        t.客户名称ID as 客户名称Id,
        t.支付金额 as 做账收款额,
        t.工本费 as 工本收款费,
        t.开票费 as 开票收款费,
        0 as 做账提成 ,
        0 as 工本费开票费提成,
        t.业务员 as 员工,
        t.业务员ID as 员工ID,
        t.支付日期,
        0 as 注册费收款额,
        0 as 注册提成,
        t.收款类别,
        t.月做账费,
        t.月做账费 * 12 as 年做账费,
        0 as 注册费,
        0 as 其他一次性业务,
	    0 as 成长版,
        0 as 图章,
        0 as 银行,
        0 as 其他,
        0 as 注册利润,
        '业务员做账费' as 工资统计类型
        ,t2.初始做账时间
        ,t2.首年提成结束期
        ,t.本次到期月份
       from TW_Payment  t,[dbo].[TW_Client] t2
        where
		t.客户名称ID=t2.客户名称ID
        and t.本次到期月份 <= t2.首年提成结束期
        and  year(t.支付日期)= " + year + " and month(t.支付日期) = " + month + @"
        and t.收款类别 = '常规收款'
        and t.业务员ID = '{0}'
        and t.是否审核=1
        union
        select
        NEWID() as TW_SalarySumID,
        t.客户名称,
        t.客户名称ID,
        t.做账费收款额 as 做账收款额,
        t.工本费收款额 as 工本收款额,
        t.开票费收款额 as 开票收款额,
        0 as 做账提成,
        0 as 工本费开票费提成,
        t.业务员 as 员工,
        t.业务员ID as 员工ID,
        t.收款日期 as 支付日期,
        t.注册费收款额,
        0 as 注册提成,
        '注册收款' as 收款类别,
        t.月做账费 ,
        t.年做账费,
        t.注册费,
        0 as 其他一次性业务,
	    0 as 成长版,
        t.图章,
        t.银行,
        t.其他,
        t.注册利润,
        '业务员注册费' as 工资统计类型
        ,t.初始做账时间
        ,t.首年提成结束期
        ,t.做账到期月
        from VW_PaymentDetail t
        where  t.注册费<=t.注册费收款额 and (注册类型='注册' or  注册类型='设立'
or 注册类型='变更' or 注册类型='注销')
        and Year(t.收款日期)=" + year + " and MONTH(t.收款日期)=" + month + @"
        and t.业务员ID='{1}'  ", businessID, businessID);
            DataSet dst = ServiceManager.GetDatabase().GetEntity(strSql, "TW_SalarySum");
            return dst;
        }


        /// <summary>
        /// 获取业务员业绩明细2021  成长版
        /// </summary>
        /// <param name="businessID"></param>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetBusinessSumCZB2021(string businessID, int year, int month)
        {
            //获取一个业务员的做账费收款额
            string strSql = string.Format(@"
        select
        NEWID() as TW_SalarySumID,
        t.客户名称,
        t.客户名称ID,
        t.做账费收款额 as 做账收款额,
        t.工本费收款额 as 工本收款额,
        t.开票费收款额 as 开票收款额,
        0 as 做账提成,
        0 as 工本费开票费提成,
        t.业务员 as 员工,
        t.业务员ID as 员工ID,
        t.收款日期 as 支付日期,
        t.注册费收款额,
        0 as 注册提成,
        '注册收款' as 收款类别,
        t.月做账费 ,
        t.年做账费,
        t.注册费,
        t.图章,
        t.银行,
        t.其他,
        t.注册利润,
        '业务员注册费' as 工资统计类型
        ,t.初始做账时间
        ,t.首年提成结束期
        ,t.做账到期月
        from VW_PaymentDetail t
        where  t.注册费<=t.注册费收款额 and (注册类型='成长版')
        and Year(t.收款日期)=" + year + " and MONTH(t.收款日期)=" + month + @"
        and t.业务员ID='{1}'  ", businessID, businessID);
            DataSet dst = ServiceManager.GetDatabase().GetEntity(strSql, "TW_SalarySum");
            return dst;
        }


        /// <summary>
        /// 获取业务员业绩明细2021 一次性业务
        /// </summary>
        /// <param name="businessID"></param>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetBusinessSumYCX2021(string businessID, int year, int month)
        {
            //获取一个业务员的做账费收款额
            string strSql = string.Format(@"
        select
        NEWID() as TW_SalarySumID,
        t.客户名称,
        t.客户名称ID,
        t.做账费收款额 as 做账收款额,
        t.工本费收款额 as 工本收款额,
        t.开票费收款额 as 开票收款额,
        0 as 做账提成,
        0 as 工本费开票费提成,
        t.业务员 as 员工,
        t.业务员ID as 员工ID,
        t.收款日期 as 支付日期,
        t.注册费收款额,
        0 as 注册提成,
        '注册收款' as 收款类别,
        t.月做账费 ,
        t.年做账费,
        t.注册费,
        t.图章,
        t.银行,
        t.其他,
        t.注册利润,
        '业务员注册费' as 工资统计类型
        ,t.初始做账时间
        ,t.首年提成结束期
        ,t.做账到期月
        from VW_PaymentDetail t
        where  t.注册费<=t.注册费收款额 and (注册类型='验资' or  注册类型='审计' or  注册类型='商标')
        and Year(t.收款日期)=" + year + " and MONTH(t.收款日期)=" + month + @"
        and t.业务员ID='{1}'  ", businessID, businessID);
            DataSet dst = ServiceManager.GetDatabase().GetEntity(strSql, "TW_SalarySum");
            return dst;
        }

        /// <summary>
        /// 获取所有业务员的业绩，包括主管的业绩，包括团队业绩
        /// </summary>
        /// <param name="year">年</param>
        /// <param name="month">月</param>
        /// <param name="userManagerID">业务主管</param>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetAllBusinessSum(int year, int month, string userManagerID, string userName)
        {
            string sqlUser = "select * from TCOM_USER where workType='业务主管'";
            DataSet dstuser = ServiceManager.GetDatabase().GetEntity(sqlUser, "TCOM_USER");
            if (dstuser.Tables["TCOM_USER"].Rows.Count > 0)
            {
                userManagerID = dstuser.Tables["TCOM_USER"].Rows[0]["USERID"].ToString();
            }
            string strSql = @"select
             tt.员工,tt.员工ID,tt.做账收款额 as 做账收款额 ,tt.做账提成 * tc.业务_注册提成 as 做账提成
            ,tt.工本收款费 as 工本收款费 ,tt.开票收款费 as 开票收款费,
            (tt.工本收款费+tt.开票收款费) * tc.业务_工本提成 as 工本费开票费提成
            ,tt.注册提成 * tc.业务_注册提成 as 注册提成 ,tt.注册利润 as 注册利润 , tt.注册费收款额 as 注册费收款额,0 as 团队提成
            from (
            select ts.员工,ts.员工ID,sum(ts.做账收款额) as 做账收款额 ,sum(ts.做账收款额)  as 做账提成
            ,sum(ts.工本收款费) as 工本收款费 ,sum(ts.开票收款费) as 开票收款费,
            sum(ts.工本收款费+ts.开票收款费)  as 工本费开票费提成
            ,sum(ts.注册利润)  as 注册提成 ,sum(ts.注册利润) as 注册利润 , sum(ts.注册费收款额) as 注册费收款额  from (
            select
            t.支付单位 as 客户名称,
            newid() as  客户名称ID,
            t.支付金额 as 做账收款额,
            t.工本费 as 工本收款费,
            t.开票费 as 开票收款费,
            0 as 做账提成 ,
            0 as 工本费开票费提成,
            t.业务员 as 员工,
            t.业务员ID as 员工ID,
            t.支付日期 as 支付日期,
            0 as 注册费收款额,
            0 as 注册提成,
            t.收款类别,
            t.月做账费,
            t.月做账费 * 12 as 年做账费,
            0 as 注册费,
            0 as 图章,
            0 as 银行,
            0 as 其他,
            0 as 注册利润,
            '业务员做账费' as 工资统计类型
            from TW_Payment  t,[dbo].[TW_Client] t2
            where
		    t.客户名称ID=t2.客户名称ID
            and  t.本次到期月份 <= t2.首年提成结束期
            and  year(t.支付日期)= " + year + @" and month(t.支付日期) = " + month + @"
            and t.收款类别 = '常规收款'
            and t.业务员ID is not null
            and t.是否审核=1
            union
		    select
            t.客户名称,
             newid() as  客户名称ID,
            t.做账费收款额 as 做账收款额,
            t.工本费收款额 as 工本收款额,
            t.开票费收款额 as 开票收款额,
            0 as 做账提成,
            0 as 工本费开票费提成,
            t.业务员 as 员工,
            t.业务员ID as 员工ID,
            t.收款日期 as 支付日期,
            t.注册费收款额,
            0 as 注册提成,
            '注册收款' as 收款类别,
            t.月做账费 ,
            t.年做账费,
            t.注册费,
            t.图章,
            t.银行,
            t.其他,
            t.注册利润,
            '业务员注册费' as 工资统计类型
            from VW_PaymentDetail t
            where t.注册费<=t.注册费收款额
            and (注册类型='注册' or  注册类型='设立'
            or 注册类型='变更' or 注册类型='注销' or 注册类型='验资')
            and Year(t.收款日期)=" + year + " and MONTH(t.收款日期)=" + month + @"
		    ) as ts
		    group by ts.员工,ts.员工ID
		    ) as tt,TCOM_USER tuser,
		    TWS_Commission as tc
		    where tt.员工ID = tuser.USERID and tuser.DEPTNAME='业务部' and tc.TWS_CommissionID='1'";
            DataSet dst = ServiceManager.GetDatabase().GetEntity(strSql, "TW_SalarySumAll");
            decimal tuanDuiPrice = 0;

            foreach (DataRow row in dst.Tables["TW_SalarySumAll"].Rows)
            {
                if (row["员工ID"].ToString() == userManagerID)
                    continue;
                tuanDuiPrice += decimal.Parse(row["做账收款额"].ToString()) + decimal.Parse(row["注册利润"].ToString());
            }
            DataRow[] selRows = dst.Tables["TW_SalarySumAll"].Select("员工ID='" + userManagerID + "'");
            if (selRows.Length > 0)
            {
                tuanDuiPrice = tuanDuiPrice * (decimal)0.05;
                selRows[0].BeginEdit();
                selRows[0]["团队提成"] = tuanDuiPrice;
                selRows[0].EndEdit();
                selRows[0].AcceptChanges();
            }

            if (!string.IsNullOrEmpty(userName))
            {
                int rowCount = dst.Tables["TW_SalarySumAll"].Rows.Count;
                int i = 0;
                while (i < dst.Tables["TW_SalarySumAll"].Rows.Count)
                {
                    DataRow row = dst.Tables["TW_SalarySumAll"].Rows[i];
                    string rowUserName = row["员工"].ToString();
                    if (rowUserName != userName)
                    {
                        dst.Tables["TW_SalarySumAll"].Rows.Remove(row);
                    }
                    else
                        i++;
                }
            }
            dst.Tables[0].AcceptChanges();

            return dst;
        }

        /// <summary>
        /// 获取所有业务员的业绩，包括主管的业绩，包括团队业绩
        /// </summary>
        /// <param name="year">年</param>
        /// <param name="month">月</param>
        /// <param name="userManagerID">业务主管</param>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetAllBusinessSumZC(int year, int month, string userManagerID, string userName)
        {
            string sqlUser = "select * from TCOM_USER where workType='业务主管'";
            DataSet dstuser = ServiceManager.GetDatabase().GetEntity(sqlUser, "TCOM_USER");
            if (dstuser.Tables["TCOM_USER"].Rows.Count > 0)
            {
                userManagerID = dstuser.Tables["TCOM_USER"].Rows[0]["USERID"].ToString();
            }
            string strSql = @"select
             tt.员工,tt.员工ID,tt.做账收款额 as 做账收款额 ,tt.做账提成 * tc.业务_注册提成 as 做账提成
            ,tt.工本收款费 as 工本收款费 ,tt.开票收款费 as 开票收款费,
            (tt.工本收款费+tt.开票收款费) * tc.业务_工本提成 as 工本费开票费提成
            ,tt.注册提成 * tc.业务_注册提成 as 注册提成 ,tt.注册利润 as 注册利润 , tt.注册费收款额 as 注册费收款额,0 as 团队提成
            from (
            select ts.员工,ts.员工ID,sum(ts.做账收款额) as 做账收款额 ,sum(ts.做账收款额)  as 做账提成
            ,sum(ts.工本收款费) as 工本收款费 ,sum(ts.开票收款费) as 开票收款费,
            sum(ts.工本收款费+ts.开票收款费)  as 工本费开票费提成
            ,sum(ts.注册利润)  as 注册提成 ,sum(ts.注册利润) as 注册利润 , sum(ts.注册费收款额) as 注册费收款额  from (
            select
            t.支付单位 as 客户名称,
            newid() as  客户名称ID,
            t.支付金额 as 做账收款额,
            t.工本费 as 工本收款费,
            t.开票费 as 开票收款费,
            0 as 做账提成 ,
            0 as 工本费开票费提成,
            t.业务员 as 员工,
            t.业务员ID as 员工ID,
            t.支付日期 as 支付日期,
            0 as 注册费收款额,
            0 as 注册提成,
            t.收款类别,
            t.月做账费,
            t.月做账费 * 12 as 年做账费,
            0 as 注册费,
            0 as 图章,
            0 as 银行,
            0 as 其他,
            0 as 注册利润,
            '业务员做账费' as 工资统计类型
            from TW_Payment  t,[dbo].[TW_Client] t2
            where
		    t.客户名称ID=t2.客户名称ID
            and  t.本次到期月份 <= t2.首年提成结束期
            and  year(t.支付日期)= " + year + @" and month(t.支付日期) = " + month + @"
            and t.收款类别 = '常规收款'
            and t.业务员ID is not null
            and t.是否审核=1
            union
		    select
            t.客户名称,
             newid() as  客户名称ID,
            t.做账费收款额 as 做账收款额,
            t.工本费收款额 as 工本收款额,
            t.开票费收款额 as 开票收款额,
            0 as 做账提成,
            0 as 工本费开票费提成,
            t.业务员 as 员工,
            t.业务员ID as 员工ID,
            t.收款日期 as 支付日期,
            t.注册费收款额,
            0 as 注册提成,
            '注册收款' as 收款类别,
            t.月做账费 ,
            t.年做账费,
            t.注册费,
            t.图章,
            t.银行,
            t.其他,
            t.注册利润,
            '业务员注册费' as 工资统计类型
            from VW_PaymentDetail t
            where t.注册费<=t.注册费收款额
            and (注册类型='注册' or  注册类型='设立'
            or 注册类型='变更' or 注册类型='注销' or 注册类型='验资')
            and Year(t.收款日期)=" + year + " and MONTH(t.收款日期)=" + month + @"
		    ) as ts
		    group by ts.员工,ts.员工ID
		    ) as tt,TCOM_USER tuser,
		    TWS_Commission as tc
		    where tt.员工ID = tuser.USERID and tuser.DEPTNAME='注册部' and tc.TWS_CommissionID='1'";
            DataSet dst = ServiceManager.GetDatabase().GetEntity(strSql, "TW_SalarySumAll");
            decimal tuanDuiPrice = 0;

            foreach (DataRow row in dst.Tables["TW_SalarySumAll"].Rows)
            {
                if (row["员工ID"].ToString() == userManagerID)
                    continue;
                tuanDuiPrice += decimal.Parse(row["做账收款额"].ToString()) + decimal.Parse(row["注册利润"].ToString());
            }
            DataRow[] selRows = dst.Tables["TW_SalarySumAll"].Select("员工ID='" + userManagerID + "'");
            if (selRows.Length > 0)
            {
                tuanDuiPrice = tuanDuiPrice * (decimal)0.05;
                selRows[0].BeginEdit();
                selRows[0]["团队提成"] = tuanDuiPrice;
                selRows[0].EndEdit();
                selRows[0].AcceptChanges();
            }

            if (!string.IsNullOrEmpty(userName))
            {
                int rowCount = dst.Tables["TW_SalarySumAll"].Rows.Count;
                int i = 0;
                while (i < dst.Tables["TW_SalarySumAll"].Rows.Count)
                {
                    DataRow row = dst.Tables["TW_SalarySumAll"].Rows[i];
                    string rowUserName = row["员工"].ToString();
                    if (rowUserName != userName)
                    {
                        dst.Tables["TW_SalarySumAll"].Rows.Remove(row);
                    }
                    else
                        i++;
                }
            }
            dst.Tables[0].AcceptChanges();

            return dst;
        }



        /// <summary>
        /// 获取业务员业绩，2021新版
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="userManagerID"></param>
        /// <param name="userName"></param>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetAllBusinessSum2021(int year, int month, string userManagerID, string userName)
        {

            string strSql = @"select
             tt.员工,tt.员工ID,tt.做账收款额 as 做账收款额 ,tt.做账提成 * tc.业务_做账提成 as 做账提成
            ,tt.工本收款费 as 工本收款费 ,tt.开票收款费 as 开票收款费,
            (tt.工本收款费+tt.开票收款费) * tc.业务_工本提成 as 工本费开票费提成
            ,tt.注册提成 * tc.业务_注册提成 as 注册提成 ,tt.注册利润-tt.成长版 -tt.其他一次性业务 as 注册利润 , tt.注册费收款额 as 注册费收款额,0 as 团队提成
            , tt.其他一次性业务,tt.其他一次性业务 * tc.业务_一次性业务其他 as 其他一次性业务提成 ,tt.成长版  ,tt.成长版*tc.业务_一次性业务成长版 as 成长版提成
            from (
            select ts.员工,ts.员工ID,sum(ts.做账收款额) as 做账收款额 ,sum(ts.做账收款额)  as 做账提成
            ,sum(ts.工本收款费) as 工本收款费 ,sum(ts.开票收款费) as 开票收款费,
            sum(ts.工本收款费+ts.开票收款费)  as 工本费开票费提成
            ,sum(ts.注册利润-ts.成长版-ts.其他一次性业务)  as 注册提成 ,sum(ts.注册利润) as 注册利润 , sum(ts.注册费收款额) as 注册费收款额 
            ,sum(ts.其他一次性业务) as 其他一次性业务,sum(ts.成长版) as 成长版
            from (
            select
            t.支付单位 as 客户名称,
            newid() as  客户名称ID,
            t.支付金额 as 做账收款额,
            t.工本费 as 工本收款费,
            t.开票费 as 开票收款费,
            0 as 做账提成 ,
            0 as 工本费开票费提成,
            t.业务员 as 员工,
            t.业务员ID as 员工ID,
            t.支付日期 as 支付日期,
            0 as 注册费收款额,
            0 as 注册提成,
            t.收款类别,
            t.月做账费,
            t.月做账费 * 12 as 年做账费,
            0 as 注册费,
            0 as 其他一次性业务,
			0 as 成长版,
            0 as 图章,
            0 as 银行,
            0 as 其他,
            0 as 注册利润,
            '业务员做账费' as 工资统计类型
            from TW_Payment  t,[dbo].[TW_Client] t2
            where
		    t.客户名称ID=t2.客户名称ID
            and  t.本次到期月份 <= t2.首年提成结束期
            and  year(t.支付日期)= " + year + @" and month(t.支付日期) = " + month + @"
            and t.收款类别 = '常规收款'
            and t.业务员ID is not null
            and t.是否审核=1
            union
		    select
            t.客户名称,
             newid() as  客户名称ID,
            t.做账费收款额 as 做账收款额,
            t.工本费收款额 as 工本收款额,
            t.开票费收款额 as 开票收款额,
            0 as 做账提成,
            0 as 工本费开票费提成,
            t.业务员 as 员工,
            t.业务员ID as 员工ID,
            t.收款日期 as 支付日期,
            t.注册费收款额,
            0 as 注册提成,
            '注册收款' as 收款类别,
            t.月做账费 ,
            t.年做账费,
            t.注册费,
            0 as 其他一次性业务,
			0 as 成长版,
            t.图章,
            t.银行,
            t.其他,
            t.注册利润,
            '业务员注册费' as 工资统计类型
            from VW_PaymentDetail t
            where t.注册费<=t.注册费收款额   and (注册类型='注册' or  注册类型='设立'
            or 注册类型='变更' or 注册类型='注销')
            and Year(t.收款日期)=" + year + " and MONTH(t.收款日期)=" + month + @"
            union
            select
            t.客户名称,
             newid() as  客户名称ID,
            t.做账费收款额 as 做账收款额,
            t.工本费收款额 as 工本收款额,
            t.开票费收款额 as 开票收款额,
            0 as 做账提成,
            0 as 工本费开票费提成,
            t.业务员 as 员工,
            t.业务员ID as 员工ID,
            t.收款日期 as 支付日期,
            0 as 注册费收款额,
            0 as 注册提成,
            '注册收款' as 收款类别,
            t.月做账费 ,
            t.年做账费,
			0 as 注册费,
            t.注册利润 as 其他一次性业务,
			0 as 成长版,
            t.图章,
            t.银行,
            t.其他,
            t.注册利润,
            '一次性业务' as 工资统计类型
            from VW_PaymentDetail t
            where t.注册费<=t.注册费收款额  and (注册类型='验资' or  注册类型='审计' or  注册类型='商标')
            and Year(t.收款日期)=" + year + " and MONTH(t.收款日期)=" + month + @"
			union
		    select
            t.客户名称,
             newid() as  客户名称ID,
            t.做账费收款额 as 做账收款额,
            t.工本费收款额 as 工本收款额,
            t.开票费收款额 as 开票收款额,
            0 as 做账提成,
            0 as 工本费开票费提成,
            t.业务员 as 员工,
            t.业务员ID as 员工ID,
            t.收款日期 as 支付日期,
            0 as 注册费收款额,
            0 as 注册提成,
            '注册收款' as 收款类别,
            t.月做账费 ,
            t.年做账费,
			0 as 注册费,
            0 as 其他一次性业务,
			t.注册利润 as 成长版,
            t.图章,
            t.银行,
            t.其他,
            t.注册利润,
            '成长版' as 工资统计类型
            from VW_PaymentDetail t
            where t.注册费<=t.注册费收款额  and (注册类型='成长版')
             and Year(t.收款日期)=" + year + " and MONTH(t.收款日期)=" + month + @" ";
            // if (userManagerID== 'ace8a3bf-76bf-4539-b696-4ada998000b5' ||
            //     userManagerID== '320581199105263423'  || userManagerID=="") 

            strSql += @"
            union
            select
            '' as 客户名称,
             newid() as  客户名称ID,
            0 as 做账收款额,
            0 as 工本收款额,
            0 as 开票收款额,
            0 as 做账提成,
            0 as 工本费开票费提成,
            t.username as 员工,
            t.userid as 员工ID,
            getdate() as 支付日期,
            0 as 注册费收款额,
            0 as 注册提成,
            '注册收款' as 收款类别,
            0 as 月做账费 ,
            0 as 年做账费,
            0 as 注册费,
            0 as 其他一次性业务,
			0 as 成长版,
            0 as 图章,
            0 as 银行,
            0 as 其他,
            0 as 注册利润,
            '0业绩' as 工资统计类型
            from [TCOM_USER] t where DEPTNAME='业务部' and OutDate is null   ";
            strSql += @"
		    ) as ts
		    group by ts.员工,ts.员工ID
		    ) as tt,TCOM_USER tuser,
		    TWS_Commission as tc
		    where tt.员工ID = tuser.USERID and tuser.DEPTNAME='业务部' and tc.TWS_CommissionID='1'";
            DataSet dst = ServiceManager.GetDatabase().GetEntity(strSql, "TW_SalarySumAll");
            decimal tuanDuiPrice = 0;


            string sqlUser = "select * from TCOM_USER where workType='业务主管'";
            DataSet dstuser = ServiceManager.GetDatabase().GetEntity(sqlUser, "TCOM_USER");
            if (dstuser.Tables["TCOM_USER"].Rows.Count > 0)
            {
                userManagerID = dstuser.Tables["TCOM_USER"].Rows[0]["USERID"].ToString();
            }


            foreach (DataRow row in dst.Tables["TW_SalarySumAll"].Rows)
            {
                if (row["员工ID"].ToString() == userManagerID)
                    continue;
                tuanDuiPrice += decimal.Parse(row["做账收款额"].ToString()) + decimal.Parse(row["注册利润"].ToString());
            }
            DataRow[] selRows = dst.Tables["TW_SalarySumAll"].Select("员工ID='" + userManagerID + "'");
            if (selRows.Length > 0)
            {
                tuanDuiPrice = tuanDuiPrice * (decimal)0.05;
                selRows[0].BeginEdit();
                selRows[0]["团队提成"] = tuanDuiPrice;
                selRows[0].EndEdit();
                selRows[0].AcceptChanges();
            }

            if (!string.IsNullOrEmpty(userName))
            {
                int rowCount = dst.Tables["TW_SalarySumAll"].Rows.Count;
                int i = 0;
                while (i < dst.Tables["TW_SalarySumAll"].Rows.Count)
                {
                    DataRow row = dst.Tables["TW_SalarySumAll"].Rows[i];
                    string rowUserName = row["员工"].ToString();
                    if (rowUserName != userName)
                    {
                        dst.Tables["TW_SalarySumAll"].Rows.Remove(row);
                    }
                    else
                        i++;
                }
            }
            dst.Tables[0].AcceptChanges();

            return dst;
        }

        /// <summary>
        /// 获取业务员业绩，2021新版
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="userManagerID"></param>
        /// <param name="userName"></param>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetAllBusinessSumZC2021(int year, int month, string userManagerID, string userName)
        {
            string sqlUser = "select * from TCOM_USER where workType='业务主管'";
            DataSet dstuser = ServiceManager.GetDatabase().GetEntity(sqlUser, "TCOM_USER");
            if (dstuser.Tables["TCOM_USER"].Rows.Count > 0)
            {
                userManagerID = dstuser.Tables["TCOM_USER"].Rows[0]["USERID"].ToString();
            }
            string strSql = @"select
             tt.员工,tt.员工ID,tt.做账收款额 as 做账收款额 ,tt.做账提成 * tc.业务_做账提成 as 做账提成
            ,tt.工本收款费 as 工本收款费 ,tt.开票收款费 as 开票收款费,
            (tt.工本收款费+tt.开票收款费) * tc.业务_工本提成 as 工本费开票费提成
            ,tt.注册提成 * tc.业务_注册提成 as 注册提成 ,tt.注册利润-tt.成长版 -tt.其他一次性业务 as 注册利润 , tt.注册费收款额 as 注册费收款额,0 as 团队提成
            , tt.其他一次性业务,tt.其他一次性业务 * tc.业务_一次性业务其他 as 其他一次性业务提成 ,tt.成长版  ,tt.成长版*tc.业务_一次性业务成长版 as 成长版提成
            from (
            select ts.员工,ts.员工ID,sum(ts.做账收款额) as 做账收款额 ,sum(ts.做账收款额)  as 做账提成
            ,sum(ts.工本收款费) as 工本收款费 ,sum(ts.开票收款费) as 开票收款费,
            sum(ts.工本收款费+ts.开票收款费)  as 工本费开票费提成
            ,sum(ts.注册利润-ts.成长版-ts.其他一次性业务)  as 注册提成 ,sum(ts.注册利润) as 注册利润 , sum(ts.注册费收款额) as 注册费收款额 
            ,sum(ts.其他一次性业务) as 其他一次性业务,sum(ts.成长版) as 成长版
            from (
            select
            t.支付单位 as 客户名称,
            newid() as  客户名称ID,
            t.支付金额 as 做账收款额,
            t.工本费 as 工本收款费,
            t.开票费 as 开票收款费,
            0 as 做账提成 ,
            0 as 工本费开票费提成,
            t.业务员 as 员工,
            t.业务员ID as 员工ID,
            t.支付日期 as 支付日期,
            0 as 注册费收款额,
            0 as 注册提成,
            t.收款类别,
            t.月做账费,
            t.月做账费 * 12 as 年做账费,
            0 as 注册费,
            0 as 其他一次性业务,
			0 as 成长版,
            0 as 图章,
            0 as 银行,
            0 as 其他,
            0 as 注册利润,
            '业务员做账费' as 工资统计类型
            from TW_Payment  t,[dbo].[TW_Client] t2
            where
		    t.客户名称ID=t2.客户名称ID
            and  t.本次到期月份 <= t2.首年提成结束期
            and  year(t.支付日期)= " + year + @" and month(t.支付日期) = " + month + @"
            and t.收款类别 = '常规收款'
            and t.业务员ID is not null
            and t.是否审核=1
            union
		    select
            t.客户名称,
             newid() as  客户名称ID,
            t.做账费收款额 as 做账收款额,
            t.工本费收款额 as 工本收款额,
            t.开票费收款额 as 开票收款额,
            0 as 做账提成,
            0 as 工本费开票费提成,
            t.业务员 as 员工,
            t.业务员ID as 员工ID,
            t.收款日期 as 支付日期,
            t.注册费收款额,
            0 as 注册提成,
            '注册收款' as 收款类别,
            t.月做账费 ,
            t.年做账费,
            t.注册费,
            0 as 其他一次性业务,
			0 as 成长版,
            t.图章,
            t.银行,
            t.其他,
            t.注册利润,
            '业务员注册费' as 工资统计类型
            from VW_PaymentDetail t
            where t.注册费<=t.注册费收款额   and (注册类型='注册' or  注册类型='设立'
            or 注册类型='变更' or 注册类型='注销')
            and Year(t.收款日期)=" + year + " and MONTH(t.收款日期)=" + month + @"
            union
            select
            t.客户名称,
             newid() as  客户名称ID,
            t.做账费收款额 as 做账收款额,
            t.工本费收款额 as 工本收款额,
            t.开票费收款额 as 开票收款额,
            0 as 做账提成,
            0 as 工本费开票费提成,
            t.业务员 as 员工,
            t.业务员ID as 员工ID,
            t.收款日期 as 支付日期,
            0 as 注册费收款额,
            0 as 注册提成,
            '注册收款' as 收款类别,
            t.月做账费 ,
            t.年做账费,
			0 as 注册费,
            t.注册利润 as 其他一次性业务,
			0 as 成长版,
            t.图章,
            t.银行,
            t.其他,
            t.注册利润,
            '一次性业务' as 工资统计类型
            from VW_PaymentDetail t
            where t.注册费<=t.注册费收款额  and (注册类型='验资' or  注册类型='审计' or  注册类型='商标')
            and Year(t.收款日期)=" + year + " and MONTH(t.收款日期)=" + month + @"
			union
		    select
            t.客户名称,
             newid() as  客户名称ID,
            t.做账费收款额 as 做账收款额,
            t.工本费收款额 as 工本收款额,
            t.开票费收款额 as 开票收款额,
            0 as 做账提成,
            0 as 工本费开票费提成,
            t.业务员 as 员工,
            t.业务员ID as 员工ID,
            t.收款日期 as 支付日期,
            0 as 注册费收款额,
            0 as 注册提成,
            '注册收款' as 收款类别,
            t.月做账费 ,
            t.年做账费,
			0 as 注册费,
            0 as 其他一次性业务,
			t.注册利润 as 成长版,
            t.图章,
            t.银行,
            t.其他,
            t.注册利润,
            '成长版' as 工资统计类型
            from VW_PaymentDetail t
            where t.注册费<=t.注册费收款额  and (注册类型='成长版')
             and Year(t.收款日期)=" + year + " and MONTH(t.收款日期)=" + month + @"

		    ) as ts
		    group by ts.员工,ts.员工ID
		    ) as tt,TCOM_USER tuser,
		    TWS_Commission as tc
		    where tt.员工ID = tuser.USERID and tuser.DEPTNAME='注册部' and tc.TWS_CommissionID='1'";
            DataSet dst = ServiceManager.GetDatabase().GetEntity(strSql, "TW_SalarySumAll");
            decimal tuanDuiPrice = 0;

            foreach (DataRow row in dst.Tables["TW_SalarySumAll"].Rows)
            {
                if (row["员工ID"].ToString() == userManagerID)
                    continue;
                tuanDuiPrice += decimal.Parse(row["做账收款额"].ToString()) + decimal.Parse(row["注册利润"].ToString());
            }
            DataRow[] selRows = dst.Tables["TW_SalarySumAll"].Select("员工ID='" + userManagerID + "'");
            if (selRows.Length > 0)
            {
                tuanDuiPrice = tuanDuiPrice * (decimal)0.05;
                selRows[0].BeginEdit();
                selRows[0]["团队提成"] = tuanDuiPrice;
                selRows[0].EndEdit();
                selRows[0].AcceptChanges();
            }

            if (!string.IsNullOrEmpty(userName))
            {
                int rowCount = dst.Tables["TW_SalarySumAll"].Rows.Count;
                int i = 0;
                while (i < dst.Tables["TW_SalarySumAll"].Rows.Count)
                {
                    DataRow row = dst.Tables["TW_SalarySumAll"].Rows[i];
                    string rowUserName = row["员工"].ToString();
                    if (rowUserName != userName)
                    {
                        dst.Tables["TW_SalarySumAll"].Rows.Remove(row);
                    }
                    else
                        i++;
                }
            }
            dst.Tables[0].AcceptChanges();

            return dst;
        }


        /// <summary>
        /// 做账会计的业务提层
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="userManagerID"></param>
        /// <param name="userName"></param>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetAllBusinessSumOther(int year, int month, string userManagerID, string userName, string deptid)
        {
            //string sqlUser = "select * from TCOM_USER where workType='业务主管'";
            //DataSet dstuser = ServiceManager.GetDatabase().GetEntity(sqlUser, "TCOM_USER");
            //if (dstuser.Tables["TCOM_USER"].Rows.Count > 0)
            //{
            //    userManagerID = dstuser.Tables["TCOM_USER"].Rows[0]["USERID"].ToString();
            //}
            string strSql = @"select
             tt.员工,tt.员工ID,tt.做账收款额 as 做账收款额 ,tt.做账提成 * tc.其他业务提成 as 做账提成
            ,tt.工本收款费 as 工本收款费 ,tt.开票收款费 as 开票收款费,
            (tt.工本收款费+tt.开票收款费) * tc.业务_工本提成 as 工本费开票费提成
            ,tt.注册提成 * tc.其他业务提成 as 注册提成 ,tt.注册利润 as 注册利润 , tt.注册费收款额 as 注册费收款额,0 as 团队提成
            from (
            select ts.员工,ts.员工ID,sum(ts.做账收款额) as 做账收款额 ,sum(ts.做账收款额)  as 做账提成
            ,sum(ts.工本收款费) as 工本收款费 ,sum(ts.开票收款费) as 开票收款费,
            sum(ts.工本收款费+ts.开票收款费)  as 工本费开票费提成
            ,sum(ts.注册利润)  as 注册提成 ,sum(ts.注册利润) as 注册利润 , sum(ts.注册费收款额) as 注册费收款额  from (
            select
            t.支付单位 as 客户名称,
             newid() as  客户名称ID,
            t.支付金额 as 做账收款额,
            t.工本费 as 工本收款费,
            t.开票费 as 开票收款费,
            0 as 做账提成 ,
            0 as 工本费开票费提成,
            t.业务员 as 员工,
            t.业务员ID as 员工ID,
            t.支付日期 as 支付日期,
            0 as 注册费收款额,
            0 as 注册提成,
            t.收款类别,
            t.月做账费,
            t.月做账费 * 12 as 年做账费,
            0 as 注册费,
            0 as 图章,
            0 as 银行,
            0 as 其他,
            0 as 注册利润,
            '业务员做账费' as 工资统计类型
            from TW_Payment  t,[dbo].[TW_Client] t2
            where
		    t.客户名称ID=t2.客户名称ID
            and  t.本次到期月份 <= t2.首年提成结束期
            and  year(t.支付日期)= " + year + @" and month(t.支付日期) = " + month + @"
            and t.收款类别 = '常规收款'
            and t.业务员ID is not null
            and t.是否审核=1
            union
		    select
            t.客户名称,
             newid() as  客户名称ID,
            t.做账费收款额 as 做账收款额,
            t.工本费收款额 as 工本收款额,
            t.开票费收款额 as 开票收款额,
            0 as 做账提成,
            0 as 工本费开票费提成,
            t.业务员 as 员工,
            t.业务员ID as 员工ID,
            t.收款日期 as 支付日期,
            t.注册费收款额,
            0 as 注册提成,
            '注册收款' as 收款类别,
            t.月做账费 ,
            t.年做账费,
            t.注册费,
            t.图章,
            t.银行,
            t.其他,
            t.注册利润,
            '业务员注册费' as 工资统计类型
            from VW_PaymentDetail t
            where t.注册费<=t.注册费收款额
             and (注册类型='注册' or  注册类型='设立'
            or 注册类型='变更' or 注册类型='注销')
            and Year(t.收款日期)=" + year + " and MONTH(t.收款日期)=" + month + @"
		    ) as ts
		    group by ts.员工,ts.员工ID
		    ) as tt ";

            if (!string.IsNullOrEmpty(deptid))
            {
                strSql += " join [TCOM_USER] on tt.员工ID =[TCOM_USER].USERID and[TCOM_USER].deptid = '" + deptid + "' ";
            }

            strSql += @" ,TWS_Commission as tc
		    where tc.TWS_CommissionID='1' ";
            DataSet dst = ServiceManager.GetDatabase().GetEntity(strSql, "TW_SalarySumAll");

            return dst;
        }

        /// <summary>
        /// 做账会计的业务提层2021
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="userManagerID"></param>
        /// <param name="userName"></param>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetAllBusinessSumOther2021(int year, int month, string userManagerID, string userName, string deptId)
        {

            string strSql = @"select
             tt.员工,tt.员工ID,tt.做账收款额 as 做账收款额 ,tt.做账提成 * tc.其他业务提成 as 做账提成
            ,tt.工本收款费 as 工本收款费 ,tt.开票收款费 as 开票收款费,
            (tt.工本收款费+tt.开票收款费) * tc.业务_工本提成 as 工本费开票费提成
            ,tt.注册提成 * tc.业务_注册提成 as 注册提成 ,tt.注册利润-tt.成长版 -tt.其他一次性业务 as 注册利润 , tt.注册费收款额 as 注册费收款额,0 as 团队提成
            , tt.其他一次性业务,tt.其他一次性业务 * tc.业务_一次性业务其他 as 其他一次性业务提成 ,tt.成长版  ,tt.成长版*tc.业务_一次性业务成长版 as 成长版提成
            from (
             select ts.员工,ts.员工ID,sum(ts.做账收款额) as 做账收款额 ,sum(ts.做账收款额)  as 做账提成
            ,sum(ts.工本收款费) as 工本收款费 ,sum(ts.开票收款费) as 开票收款费,
            sum(ts.工本收款费+ts.开票收款费)  as 工本费开票费提成
            ,sum(ts.注册利润-ts.成长版-ts.其他一次性业务)  as 注册提成 ,sum(ts.注册利润) as 注册利润 , sum(ts.注册费收款额) as 注册费收款额 
            ,sum(ts.其他一次性业务) as 其他一次性业务,sum(ts.成长版) as 成长版
            from (
            select
            t.支付单位 as 客户名称,
             newid() as  客户名称ID,
            t.支付金额 as 做账收款额,
            t.工本费 as 工本收款费,
            t.开票费 as 开票收款费,
            0 as 做账提成 ,
            0 as 工本费开票费提成,
            t.业务员 as 员工,
            t.业务员ID as 员工ID,
            t.支付日期 as 支付日期,
            0 as 注册费收款额,
            0 as 注册提成,
            t.收款类别,
            t.月做账费,
            t.月做账费 * 12 as 年做账费,
            0 as 注册费,
            0 as 其他一次性业务,
			0 as 成长版,
            0 as 图章,
            0 as 银行,
            0 as 其他,
            0 as 注册利润,
            '业务员做账费' as 工资统计类型
            from TW_Payment  t,[dbo].[TW_Client] t2
            where
		    t.客户名称ID=t2.客户名称ID
            and  t.本次到期月份 <= t2.首年提成结束期
            and  year(t.支付日期)= " + year + @" and month(t.支付日期) = " + month + @"
            and t.收款类别 = '常规收款'
            and t.业务员ID is not null
            and t.是否审核=1
            union
		    select
            t.客户名称,
             newid() as  客户名称ID,
            t.做账费收款额 as 做账收款额,
            t.工本费收款额 as 工本收款额,
            t.开票费收款额 as 开票收款额,
            0 as 做账提成,
            0 as 工本费开票费提成,
            t.业务员 as 员工,
            t.业务员ID as 员工ID,
            t.收款日期 as 支付日期,
            t.注册费收款额,
            0 as 注册提成,
            '注册收款' as 收款类别,
            t.月做账费 ,
            t.年做账费,
            t.注册费,
            0 as 其他一次性业务,
			0 as 成长版,
            t.图章,
            t.银行,
            t.其他,
            t.注册利润,
            '业务员注册费' as 工资统计类型
            from VW_PaymentDetail t
            where t.注册费<=t.注册费收款额
             and (注册类型='注册' or  注册类型='设立'
            or 注册类型='变更' or 注册类型='注销')
            and Year(t.收款日期)=" + year + " and MONTH(t.收款日期)=" + month + @"
            union
		    select
            t.客户名称,
             newid() as  客户名称ID,
            t.做账费收款额 as 做账收款额,
            t.工本费收款额 as 工本收款额,
            t.开票费收款额 as 开票收款额,
            0 as 做账提成,
            0 as 工本费开票费提成,
            t.业务员 as 员工,
            t.业务员ID as 员工ID,
            t.收款日期 as 支付日期,
            0 as 注册费收款额,
            0 as 注册提成,
            '注册收款' as 收款类别,
            t.月做账费 ,
            t.年做账费,
            0 as 注册费,
            t.注册利润 as 其他一次性业务,
			0 as 成长版,
            t.图章,
            t.银行,
            t.其他,
            t.注册利润,
            '业务员注册费' as 工资统计类型
            from VW_PaymentDetail t
            where t.注册费<=t.注册费收款额
            and (注册类型='验资' or  注册类型='审计' or  注册类型='商标')
            and Year(t.收款日期)=" + year + " and MONTH(t.收款日期)=" + month + @"
            union
		    select
            t.客户名称,
             newid() as  客户名称ID,
            t.做账费收款额 as 做账收款额,
            t.工本费收款额 as 工本收款额,
            t.开票费收款额 as 开票收款额,
            0 as 做账提成,
            0 as 工本费开票费提成,
            t.业务员 as 员工,
            t.业务员ID as 员工ID,
            t.收款日期 as 支付日期,
            0 as 注册费收款额,
            0 as 注册提成,
            '注册收款' as 收款类别,
            t.月做账费 ,
            t.年做账费,
            0 as 注册费,
            0 as 其他一次性业务,
			 t.注册利润  as 成长版,
            t.图章,
            t.银行,
            t.其他,
            t.注册利润,
            '业务员注册费' as 工资统计类型
            from VW_PaymentDetail t
            where t.注册费<=t.注册费收款额 and (注册类型='成长版')
            and Year(t.收款日期)=" + year + " and MONTH(t.收款日期)=" + month + @"
		    ) as ts
		    group by ts.员工,ts.员工ID
		    ) as tt";

            if (!string.IsNullOrWhiteSpace(deptId))
            {
                strSql += " join [TCOM_USER] on tt.员工ID =[TCOM_USER].USERID and[TCOM_USER].deptid = '" + deptId + "' ";
            }

            strSql += @",TWS_Commission as tc
		    where tc.TWS_CommissionID='1' ";
            if (!string.IsNullOrEmpty(userManagerID))
            {
                strSql += " and tt.员工ID='" + userManagerID + "'";
            }
            DataSet dst = ServiceManager.GetDatabase().GetEntity(strSql, "TW_SalarySumAll");

            return dst;
        }
        /// <summary>
        /// 查询会计经理团队提成
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="userManagerID"></param>
        /// <param name="userName"></param>
        /// <param name="deptId"></param>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetAllBusinessGroupTC2021(int year, int month, string userManagerID, string userName, string deptId)
        {

            string strSql = @"
             select tg.DEPTID,'' as USERID ,SUM(tg.做账收款额) as 做账收款额,SUM(tg.注册利润) as 注册利润,sum(经理提成) as 经理提成   from (
              select   [TCOM_USER].deptid,tt.做账收款额*tc.[做账_经理提层] as 经理提成,
             tt.员工,tt.员工ID,tt.做账收款额 as 做账收款额 ,tt.做账提成 * tc.其他业务提成 as 做账提成
            ,tt.工本收款费 as 工本收款费 ,tt.开票收款费 as 开票收款费,
            (tt.工本收款费+tt.开票收款费) * tc.业务_工本提成 as 工本费开票费提成
            ,tt.注册提成 * tc.业务_注册提成 as 注册提成 ,tt.注册利润-tt.成长版 -tt.其他一次性业务 as 注册利润 , tt.注册费收款额 as 注册费收款额,0 as 团队提成
            , tt.其他一次性业务,tt.其他一次性业务 * tc.业务_一次性业务其他 as 其他一次性业务提成 ,tt.成长版  ,tt.成长版*tc.业务_一次性业务成长版 as 成长版提成
            from (
             select ts.员工,ts.员工ID,sum(ts.做账收款额) as 做账收款额 ,sum(ts.做账收款额)  as 做账提成
            ,sum(ts.工本收款费) as 工本收款费 ,sum(ts.开票收款费) as 开票收款费,
            sum(ts.工本收款费+ts.开票收款费)  as 工本费开票费提成
            ,sum(ts.注册利润-ts.成长版-ts.其他一次性业务)  as 注册提成 ,sum(ts.注册利润) as 注册利润 , sum(ts.注册费收款额) as 注册费收款额 
            ,sum(ts.其他一次性业务) as 其他一次性业务,sum(ts.成长版) as 成长版
            from (
            select
            t.支付单位 as 客户名称,
             newid() as  客户名称ID,
            t.支付金额 as 做账收款额,
            t.工本费 as 工本收款费,
            t.开票费 as 开票收款费,
            0 as 做账提成 ,
            0 as 工本费开票费提成,
            t.业务员 as 员工,
            t.业务员ID as 员工ID,
            t.支付日期 as 支付日期,
            0 as 注册费收款额,
            0 as 注册提成,
            t.收款类别,
            t.月做账费,
            t.月做账费 * 12 as 年做账费,
            0 as 注册费,
            0 as 其他一次性业务,
			0 as 成长版,
            0 as 图章,
            0 as 银行,
            0 as 其他,
            0 as 注册利润,
            '业务员做账费' as 工资统计类型
            from TW_Payment  t,[dbo].[TW_Client] t2
            where
		    t.客户名称ID=t2.客户名称ID
            and  t.本次到期月份 <= t2.首年提成结束期
            and  year(t.支付日期)= " + year + @" and month(t.支付日期) = " + month + @"
            and t.收款类别 = '常规收款'
            and t.业务员ID is not null
            and t.是否审核=1
            union
		    select
            t.客户名称,
             newid() as  客户名称ID,
            t.做账费收款额 as 做账收款额,
            t.工本费收款额 as 工本收款额,
            t.开票费收款额 as 开票收款额,
            0 as 做账提成,
            0 as 工本费开票费提成,
            t.业务员 as 员工,
            t.业务员ID as 员工ID,
            t.收款日期 as 支付日期,
            t.注册费收款额,
            0 as 注册提成,
            '注册收款' as 收款类别,
            t.月做账费 ,
            t.年做账费,
            t.注册费,
            0 as 其他一次性业务,
			0 as 成长版,
            t.图章,
            t.银行,
            t.其他,
            t.注册利润,
            '业务员注册费' as 工资统计类型
            from VW_PaymentDetail t
            where t.注册费<=t.注册费收款额
             and (注册类型='注册' or  注册类型='设立'
            or 注册类型='变更' or 注册类型='注销')
            and Year(t.收款日期)=" + year + " and MONTH(t.收款日期)=" + month + @"
            union
		    select
            t.客户名称,
             newid() as  客户名称ID,
            t.做账费收款额 as 做账收款额,
            t.工本费收款额 as 工本收款额,
            t.开票费收款额 as 开票收款额,
            0 as 做账提成,
            0 as 工本费开票费提成,
            t.业务员 as 员工,
            t.业务员ID as 员工ID,
            t.收款日期 as 支付日期,
            0 as 注册费收款额,
            0 as 注册提成,
            '注册收款' as 收款类别,
            t.月做账费 ,
            t.年做账费,
            0 as 注册费,
            t.注册利润 as 其他一次性业务,
			0 as 成长版,
            t.图章,
            t.银行,
            t.其他,
            t.注册利润,
            '业务员注册费' as 工资统计类型
            from VW_PaymentDetail t
            where t.注册费<=t.注册费收款额
            and (注册类型='验资' or  注册类型='审计' or  注册类型='商标')
            and Year(t.收款日期)=" + year + " and MONTH(t.收款日期)=" + month + @"
            union
		    select
            t.客户名称,
             newid() as  客户名称ID,
            t.做账费收款额 as 做账收款额,
            t.工本费收款额 as 工本收款额,
            t.开票费收款额 as 开票收款额,
            0 as 做账提成,
            0 as 工本费开票费提成,
            t.业务员 as 员工,
            t.业务员ID as 员工ID,
            t.收款日期 as 支付日期,
            0 as 注册费收款额,
            0 as 注册提成,
            '注册收款' as 收款类别,
            t.月做账费 ,
            t.年做账费,
            0 as 注册费,
            0 as 其他一次性业务,
			 t.注册利润  as 成长版,
            t.图章,
            t.银行,
            t.其他,
            t.注册利润,
            '业务员注册费' as 工资统计类型
            from VW_PaymentDetail t
            where t.注册费<=t.注册费收款额 and (注册类型='成长版')
            and Year(t.收款日期)=" + year + " and MONTH(t.收款日期)=" + month + @"
		    ) as ts
		    group by ts.员工,ts.员工ID
		    ) as tt";


            strSql += " join [TCOM_USER] on tt.员工ID =[TCOM_USER].USERID ";


            strSql += @",TWS_Commission as tc
		    where tc.TWS_CommissionID='1'
            ) tg
			group by tg.DEPTID ";

            DataSet dst = ServiceManager.GetDatabase().GetEntity(strSql, "TW_SalarySumAll");

            //补充经理的ID
            string JLsql = " select USERID, USERNAME, DEPTID from TCOM_USER where WorkType = '二级部门经理' ";
            DataSet jlds = ServiceManager.GetDatabase().GetEntity(JLsql, "TCOMUSER");
            foreach (DataRow row in jlds.Tables[0].Rows)
            {
                string jldeptId = row["DEPTID"].ToString();
                string jluserid = row["USERID"].ToString();
                DataRow[] rows = dst.Tables[0].Select("DEPTID = '" + jldeptId + "'");
                if (rows.Length > 0)
                {
                    rows[0].BeginEdit();
                    rows[0]["USERID"] = jluserid;
                    rows[0].EndEdit();
                }
            }


            return dst;
        }

        /// <summary>
        /// 查询一个团队的收款额
        /// </summary>
        /// <param name="businessID"></param>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetBussinessManagerDept(string businessID)
        {
            //获取一个业务员的做账费收款额
            string strSql = string.Format(@"select
        t.支付单位 as 客户名称,
        t.客户名称ID as 客户名称Id,
        t.支付金额 as 做账收款额,
        t.工本费 as 工本收款费,
        t.开票费 as 开票收款费,
        0 as 做账提成 ,
        0 as 工本费开票费提成,
        t.业务员 as 员工,
        t.业务员ID as 员工ID,
        t.支付日期,
        0 as 注册费收款额,
        0 as 注册提成,
        t.收款类别,
        t.月做账费,
        t.月做账费 * 12 as 年做账费,
        0 as 注册费,
        0 as 图章,
        0 as 银行,
        0 as 其他,
        0 as 注册利润,
        '业务员做账费' as 工资统计类型
        from TW_Payment  t
        where
         t.本次到期月份 <= t.首年提成结束期
        and year(t.支付日期)= 2017 and month(t.支付日期) = 11
        and t.收款类别 = '常规收款'
        and t.是否审核=1
        and t.业务员ID<>'{0}' and t.业务员ID in (select USERID from [dbo].[TCOM_USER] where DEPTNAME='业务部') ", businessID);
            DataSet dst = ServiceManager.GetDatabase().GetEntity(strSql, "TW_SalarySum");
            //注册费收款额
            string strSql2 = string.Format(@"select
        t.客户名称,
        t.客户名称ID,
        t.做账费收款额 as 做账收款额,
        t.工本费收款额 as 工本收款额,
        t.开票费收款额 as 开票收款额,
        0 as 做账提成,
        0 as 工本费开票费提成,
        t.业务员 as 员工,
        t.业务员ID as 员工ID,
        t.收款日期 as 支付日期,
        t.注册费收款额,
        0 as 注册提成,
        '注册收款' as 收款类别,
        t.月做账费 ,
        t.年做账费,
        t.注册费,
        t.图章,
        t.银行,
        t.其他,
        t.注册利润,
        '业务员注册费' as 工资统计类型
        from VW_PaymentDetail t
        where  t.注册费<=t.注册费收款额
        and Year(t.收款日期)=2017 and MONTH(t.收款日期)=10
        and t.业务员ID<>'{0}' and t.业务员ID in (select USERID from [dbo].[TCOM_USER] where DEPTNAME='注册部')   ", businessID);
            ServiceManager.GetDatabase().FillEntity(strSql, dst, "TW_SalarySum");

            return dst;
        }

        /// <summary>
        /// 业务员上年业绩明细
        /// </summary>
        /// <param name="Year"></param>
        /// <param name="businessManID"></param>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetBussinessSumByYear(int Year, string businessManID)
        {
            string strSql = @"select
                  NEWID() as TW_SalarySumID,
                  t.支付单位 as 客户名称,
                  t.客户名称ID as 客户名称Id,
                  t.支付金额 as 做账收款额,
                  t.工本费 as 工本收款费,
                  t.开票费 as 开票收款费,
                  0 as 做账提成 ,
                  0 as 工本费开票费提成,
                  t.业务员 as 员工,
                  t.业务员ID as 员工ID,
                  t.支付日期,
                  0 as 注册费收款额,
                  0 as 注册提成,
                  t.收款类别,
                  t.月做账费,
                  t.月做账费 * 12 as 年做账费,
                  0 as 注册费,
                  0 as 图章,
                  0 as 银行,
                  0 as 其他,
                  0 as 注册利润,
                  '业务员做账费上年' as 工资统计类型,
                    t2.首年提成结束期,
                    t2.初始做账时间,
                        t.本次到期月份
                      from [TW_Payment] t,[TW_Client] t2
                      where   t.客户名称ID=t2.客户名称ID
                      and t.本次到期月份>  t2.首年提成结束期
                      and year(t.本次到期月份)=" + Year + @"
                      and t.收款类别='常规收款'
                      and t.是否审核=1
                      and t.业务员ID='" + businessManID + "'";
            DataSet dst = ServiceManager.GetDatabase().GetEntity(strSql, "TW_SalarySum");
            return dst;
        }

        /// <summary>
        /// 获取上一年的业务员业绩
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetBusinessLastYear(int year, string userName)
        {

            string strSql = "";
            if (string.IsNullOrEmpty(userName))
            {
                strSql = string.Format(@"select tt.*,tt.做账收款额*tc.业务_做账次年提成 as 做账收款次年提层 from (
				 select ts.员工,ts.员工ID ,sum(ts.做账收款额) as 做账收款额  from (
				 select  t.支付单位 as 客户名称,
                  t.客户名称ID as 客户名称Id,
                  t.支付金额 as 做账收款额,
                  t.工本费 as 工本收款费,
                  t.开票费 as 开票收款费,
                  0 as 做账提成 ,
                  0 as 工本费开票费提成,
                  t.业务员 as 员工,
                  t.业务员ID as 员工ID,
                  t.支付日期 as 支付日期,
                  0 as 注册费收款额,
                  0 as 注册提成,
                  t.收款类别,
                  t.月做账费,
                  t.月做账费 * 12 as 年做账费,
                  0 as 注册费,
                  0 as 图章,
                  0 as 银行,
                  0 as 其他,
                  0 as 注册利润,
                  '业务员做账费上年' as 工资统计类型
                      from [TW_Payment] t,TCOM_USER tu,[TW_Client] t2
					  where t.客户名称ID=t2.客户名称ID and  t.业务员ID =tu.USERID
                      and t.是否审核=1
                      and t.本次到期月份>  t2.首年提成结束期
                      and year(t.本次到期月份)={0}
                      and t.收款类别='常规收款'
                      and tu.DEPTNAME='业务部' ) ts
					  group by ts.员工,ts.员工ID) tt,[dbo].[TWS_Commission] tc
					  where tc.TWS_CommissionID='1' ", year);
            }
            else
            {
                strSql = string.Format(@"select tt.*,tt.做账收款额*tc.业务_做账次年提成 as 做账收款次年提层 from (
				 select ts.员工,ts.员工ID ,sum(ts.做账收款额) as 做账收款额  from (
				 select  t.支付单位 as 客户名称,
                  t.客户名称ID as 客户名称Id,
                  t.支付金额 as 做账收款额,
                  t.工本费 as 工本收款费,
                  t.开票费 as 开票收款费,
                  0 as 做账提成 ,
                  0 as 工本费开票费提成,
                  t.业务员 as 员工,
                  t.业务员ID as 员工ID,
                  t.支付日期 as 支付日期,
                  0 as 注册费收款额,
                  0 as 注册提成,
                  t.收款类别,
                  t.月做账费,
                  t.月做账费 * 12 as 年做账费,
                  0 as 注册费,
                  0 as 图章,
                  0 as 银行,
                  0 as 其他,
                  0 as 注册利润,
                  '业务员做账费上年' as 工资统计类型
                      from [TW_Payment] t,TCOM_USER tu,[TW_Client] t2
					  where t.客户名称ID=t2.客户名称ID and  t.业务员ID =tu.USERID
                      and t.业务员='{0}'
                      and t.是否审核=1
                      and t.本次到期月份>  t2.首年提成结束期
                      and year(t.本次到期月份)={1}
                      and t.收款类别='常规收款'
                      and tu.DEPTNAME='业务部' ) ts
					  group by ts.员工,ts.员工ID) tt,[dbo].[TWS_Commission] tc
					  where tc.TWS_CommissionID='1' ", userName, year);
            }
            DataSet dst = ServiceManager.GetDatabase().GetEntity(strSql, "VW_AllBusinessSalaryYear");
            return dst;
        }

        #endregion 业务员 业绩统计

        #region 注册员业绩统计

        /// <summary>
        /// 获取注册员月业绩情况
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetRegSum(int year, int month, string userName)
        {
            string strSql = @"select
     tt.员工,tt.员工ID,tt.做账收款额 as 做账收款额 ,tt.做账提成 * tc.注册_年做账费提成 as 做账提成
    ,tt.注册提成 as 注册提成, 0 as 团队提成
    from (
    select ts.员工,ts.员工ID,sum(ts.做账收款额) as 做账收款额 ,sum(ts.做账收款额)  as 做账提成
    ,sum(ts.注册费)  as 注册提成  from (
    select
    newID() as ID,
    t.支付单位 as 客户名称,
    t.客户名称ID as 客户名称Id,
    t.支付金额 as 做账收款额,
    t.工本费 as 工本收款费,
    t.开票费 as 开票收款费,
    0 as 做账提成 ,
    0 as 工本费开票费提成,
    t.注册员 as 员工,
    t.注册员ID as 员工ID,
     t.支付日期 as 支付日期,
    0 as 注册费收款额,
    0 as 注册提成,
    t.收款类别,
    t.月做账费,
    t.月做账费 * 12 as 年做账费,
    0 as 注册费,
    0 as 图章,
    0 as 银行,
    0 as 其他,
    0 as 注册利润,
    '注册员做账费' as 工资统计类型
    from TW_Payment  t,TW_Client t2,[TW_BusinessReg] t3
    where
    t.客户名称ID = t2.客户名称ID
    and t.本次到期月份 <= t2.首年提成结束期
    and year(t.支付日期)= " + year + " and month(t.支付日期) = " + month + @"
    and t.收款类别 = '常规收款'
    and t.注册员ID is not null
    and t.是否审核=1
	and t2.初始做账时间>'2017-12-31'
    and t2.客户名称= t3.公司预核名称 and ( t3.注册类型 like '%注册%' or t3.注册类型='设立') and t.注册员ID=t3.注册员ID
    union
    select
    newID(),
    t.公司预核名称,
    newid(),
    0 as 做账收款额,
    0 as 工本收款额,
    0 as 开票收款额,
    0 as 做账提成,
    0 as 工本费开票费提成,
    t.注册员 as 员工,
    t.注册员ID as 员工ID,
    null as 支付日期,
    0,
    0 as 注册提成,
    '注册收款数' as 收款类别,
    t.月做账费 ,
    t.年做账费,
    dbo.GetRegPrice(t.注册类型) as 注册费,
    t.图章,
    t.银行,
    t.其他,
    t.注册利润,
    '业务员注册费' as 工资统计类型
    from [dbo].[TW_BusinessReg] t
    where t.注册进度 like  '%完成%'
    and Year(t.[注册完成时间])=" + year + " and MONTH(t.[注册完成时间])= " + month + @"

	) as ts
    group by ts.员工,ts.员工ID
	) as tt,
	TWS_Commission as tc
    where tc.TWS_CommissionID = '1'";



            //        @union
            //select
            //t.客户名称,
            //t.客户名称ID,
            //t.做账费收款额 as 做账收款额,
            //t.工本费收款额 as 工本收款额,
            //t.开票费收款额 as 开票收款额,
            //0 as 做账提成,
            //0 as 工本费开票费提成,
            //t.注册员 as 员工,
            //t.注册员ID as 员工ID,
            //t.收款日期 as 支付日期,
            //t.注册费收款额,
            //0 as 注册提成,
            //'注册收款数' as 收款类别,
            //t.月做账费 ,
            //t.年做账费,
            //0 as 注册费,
            //--dbo.GetRegPrice(t.注册类型) as 注册费,
            //t.图章,
            //t.银行,
            //t.其他,
            //t.注册利润,
            //'业务员注册费' as 工资统计类型
            //from VW_PaymentDetail t
            //where t.注册费 <= t.注册费收款额 and t.注册进度 = '完成'
            //and Year(t.收款日期)= " + year + " and MONTH(t.收款日期)= " + month + @"

            DataSet dst = ServiceManager.GetDatabase().GetEntity(strSql, "TW_SalarySumAll");

            string userManagerID = "";
            string userManagerName = "";
            string sqlUser = "select * from TCOM_USER where workType='注册主管'";
            DataSet dstuser = ServiceManager.GetDatabase().GetEntity(sqlUser, "TCOM_USER");
            if (dstuser.Tables["TCOM_USER"].Rows.Count > 0)
            {
                userManagerID = dstuser.Tables["TCOM_USER"].Rows[0]["USERID"].ToString();
                userManagerName = dstuser.Tables["TCOM_USER"].Rows[0]["USERNAME"].ToString();
            }
            decimal tuanDuiPrice = 0;
            decimal regTotalPrice = 0;
            foreach (DataRow row in dst.Tables["TW_SalarySumAll"].Rows)
            {
                if (row["员工ID"].ToString() == userManagerID)
                    continue;
                tuanDuiPrice += decimal.Parse(row["做账收款额"].ToString());
                decimal RegPrice = decimal.Parse(row["注册提成"].ToString());
                RegPrice = RegPrice / 2;
                regTotalPrice += RegPrice;
            }

            DataRow[] selRows = dst.Tables["TW_SalarySumAll"].Select("员工ID='" + userManagerID + "'");

            if (selRows.Length > 0)
            {
                tuanDuiPrice = tuanDuiPrice * (decimal)0.025;
                selRows[0].BeginEdit();
                selRows[0]["团队提成"] = regTotalPrice;
                selRows[0]["做账提成"] = tuanDuiPrice;
                selRows[0].EndEdit();
                selRows[0].AcceptChanges();
            }
            else
            {
                tuanDuiPrice = tuanDuiPrice * (decimal)0.025;
                DataRow ManagerRow = dst.Tables["TW_SalarySumAll"].NewRow();
                ManagerRow["员工ID"] = userManagerID;
                ManagerRow["员工"] = userManagerName;
                ManagerRow["团队提成"] = regTotalPrice;
                ManagerRow["做账提成"] = tuanDuiPrice;
                dst.Tables["TW_SalarySumAll"].Rows.Add(ManagerRow);
            }

            if (!string.IsNullOrEmpty(userName))
            {
                int rowCount = dst.Tables["TW_SalarySumAll"].Rows.Count;
                int i = 0;
                while (i < dst.Tables["TW_SalarySumAll"].Rows.Count)
                {
                    DataRow row = dst.Tables["TW_SalarySumAll"].Rows[i];
                    string rowUserName = row["员工"].ToString();
                    if (rowUserName != userName)
                    {
                        dst.Tables["TW_SalarySumAll"].Rows.Remove(row);
                    }
                    else
                        i++;
                }
            }
            dst.Tables[0].AcceptChanges();

            return dst;
        }


        /// <summary>
        /// 获取注册员月业绩情况
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetRegSum2021(int year, int month, string userName)
        {
            string strSql = @"select
     tt.员工,tt.员工ID,tt.做账收款额 as 做账收款额 ,tt.做账提成 * tc.注册_年做账费提成 as 做账提成
    ,tt.注册提成 as 注册提成, 0 as 团队提成
    from (
    select ts.员工,ts.员工ID,sum(ts.做账收款额) as 做账收款额 ,sum(ts.做账收款额)  as 做账提成
    ,sum(ts.注册费)  as 注册提成  from (
    select
    newID() as ID,
    t.支付单位 as 客户名称,
    t.客户名称ID as 客户名称Id,
    t.支付金额 as 做账收款额,
    t.工本费 as 工本收款费,
    t.开票费 as 开票收款费,
    0 as 做账提成 ,
    0 as 工本费开票费提成,
    t.注册员 as 员工,
    t.注册员ID as 员工ID,
     t.支付日期 as 支付日期,
    0 as 注册费收款额,
    0 as 注册提成,
    t.收款类别,
    t.月做账费,
    t.月做账费 * 12 as 年做账费,
    0 as 注册费,
    0 as 图章,
    0 as 银行,
    0 as 其他,
    0 as 注册利润,
    '注册员做账费' as 工资统计类型
    from TW_Payment  t,TW_Client t2,[TW_BusinessReg] t3
    where
    t.客户名称ID = t2.客户名称ID
    and t.本次到期月份 <= t2.首年提成结束期
    and year(t.支付日期)= " + year + " and month(t.支付日期) = " + month + @"
    and t.收款类别 = '常规收款'
    and t.注册员ID is not null
    and t.是否审核=1
	and t2.初始做账时间>'2017-12-31'
    and t2.客户名称= t3.公司预核名称 and ( t3.注册类型 like '%注册%' or t3.注册类型='设立') and t.注册员ID=t3.注册员ID
    union
    select
    newID(),
    t.公司预核名称,
    newid(),
    0 as 做账收款额,
    0 as 工本收款额,
    0 as 开票收款额,
    0 as 做账提成,
    0 as 工本费开票费提成,
    t.注册员 as 员工,
    t.注册员ID as 员工ID,
    null as 支付日期,
    0,
    0 as 注册提成,
    '注册收款数' as 收款类别,
    t.月做账费 ,
    t.年做账费,
    dbo.GetRegPrice(t.注册类型) as 注册费,
    t.图章,
    t.银行,
    t.其他,
    t.注册利润,
    '业务员注册费' as 工资统计类型
    from [dbo].[TW_BusinessReg] t
    where t.注册进度 like  '%完成%'
    and Year(t.[注册完成时间])=" + year + " and MONTH(t.[注册完成时间])= " + month + @"

	) as ts
    group by ts.员工,ts.员工ID
	) as tt,
	TWS_Commission as tc
    where tc.TWS_CommissionID = '1'";



            //        @union
            //select
            //t.客户名称,
            //t.客户名称ID,
            //t.做账费收款额 as 做账收款额,
            //t.工本费收款额 as 工本收款额,
            //t.开票费收款额 as 开票收款额,
            //0 as 做账提成,
            //0 as 工本费开票费提成,
            //t.注册员 as 员工,
            //t.注册员ID as 员工ID,
            //t.收款日期 as 支付日期,
            //t.注册费收款额,
            //0 as 注册提成,
            //'注册收款数' as 收款类别,
            //t.月做账费 ,
            //t.年做账费,
            //0 as 注册费,
            //--dbo.GetRegPrice(t.注册类型) as 注册费,
            //t.图章,
            //t.银行,
            //t.其他,
            //t.注册利润,
            //'业务员注册费' as 工资统计类型
            //from VW_PaymentDetail t
            //where t.注册费 <= t.注册费收款额 and t.注册进度 = '完成'
            //and Year(t.收款日期)= " + year + " and MONTH(t.收款日期)= " + month + @"

            DataSet dst = ServiceManager.GetDatabase().GetEntity(strSql, "TW_SalarySumAll");

            string userManagerID = "";
            string userManagerName = "";
            string sqlUser = "select * from TCOM_USER where workType='注册主管'";
            DataSet dstuser = ServiceManager.GetDatabase().GetEntity(sqlUser, "TCOM_USER");
            if (dstuser.Tables["TCOM_USER"].Rows.Count > 0)
            {
                userManagerID = dstuser.Tables["TCOM_USER"].Rows[0]["USERID"].ToString();
                userManagerName = dstuser.Tables["TCOM_USER"].Rows[0]["USERNAME"].ToString();
            }
            decimal tuanDuiPrice = 0;
            decimal regTotalPrice = 0;
            foreach (DataRow row in dst.Tables["TW_SalarySumAll"].Rows)
            {
                if (row["员工ID"].ToString() == userManagerID)
                    continue;
                tuanDuiPrice += decimal.Parse(row["做账收款额"].ToString());
                decimal RegPrice = decimal.Parse(row["注册提成"].ToString());
                RegPrice = RegPrice / 2;
                regTotalPrice += RegPrice;
            }

            DataRow[] selRows = dst.Tables["TW_SalarySumAll"].Select("员工ID='" + userManagerID + "'");

            if (selRows.Length > 0)
            {
                tuanDuiPrice = tuanDuiPrice * (decimal)0.025;
                selRows[0].BeginEdit();
                selRows[0]["团队提成"] = regTotalPrice;
                selRows[0]["做账提成"] = tuanDuiPrice;
                selRows[0].EndEdit();
                selRows[0].AcceptChanges();
            }
            else
            {
                tuanDuiPrice = tuanDuiPrice * (decimal)0.025;
                DataRow ManagerRow = dst.Tables["TW_SalarySumAll"].NewRow();
                ManagerRow["员工ID"] = userManagerID;
                ManagerRow["员工"] = userManagerName;
                ManagerRow["团队提成"] = regTotalPrice;
                ManagerRow["做账提成"] = tuanDuiPrice;
                dst.Tables["TW_SalarySumAll"].Rows.Add(ManagerRow);
            }

            if (!string.IsNullOrEmpty(userName))
            {
                int rowCount = dst.Tables["TW_SalarySumAll"].Rows.Count;
                int i = 0;
                while (i < dst.Tables["TW_SalarySumAll"].Rows.Count)
                {
                    DataRow row = dst.Tables["TW_SalarySumAll"].Rows[i];
                    string rowUserName = row["员工"].ToString();
                    if (rowUserName != userName)
                    {
                        dst.Tables["TW_SalarySumAll"].Rows.Remove(row);
                    }
                    else
                        i++;
                }
            }
            dst.Tables[0].AcceptChanges();

            return dst;
        }

        /// <summary>
        /// 查询注册费用明细信息
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetRegSumDetail(int year, int month, string userID)
        {
            string strSql = @"select
            newID() as TW_SalarySumID,
            t.支付单位 as 客户名称,
            t.客户名称ID as 客户名称Id,
            t.支付金额 as 做账收款额,
            t.注册员 as 员工,
            t.注册员ID as 员工ID,
            t.支付日期 as 支付日期,
            0 as 注册费收款额,
            t.收款类别,
            t.月做账费,
            t.月做账费 * 12 as 年做账费,
            0 as 注册费,
            '注册员做账费' as 工资统计类型,
            '无' as 注册类型
            from TW_Payment  t,TW_Client t2,[TW_BusinessReg] t3
            where
            t.客户名称ID = t2.客户名称ID
            and t.本次到期月份 <= t2.首年提成结束期
            and  year(t.支付日期)= " + year + " and month(t.支付日期) = " + month + @"
            and t.收款类别 = '常规收款'
            and t.注册员ID='" + userID + @"'
            and t.是否审核=1 and t2.初始做账时间>'2017-12-31'
            and t2.客户名称= t3.公司预核名称 and ( t3.注册类型 like '%注册%' or t3.注册类型='设立')  and t.注册员ID=t3.注册员ID ";
            //验资也做提成

            //   @" union
            //select
            //   newID() as TW_SalarySumID,
            //   t.客户名称,
            //   t.客户名称ID,
            //   t.做账费收款额 as 做账收款额,
            //   t.注册员 as 员工,
            //   t.注册员ID as 员工ID,
            //   t.收款日期 as 支付日期,
            //   t.注册费收款额,
            //   '注册收款数' as 收款类别,
            //   t.月做账费 ,
            //   t.年做账费,
            //   0 as 注册费,
            //   '业务员注册费' as 工资统计类型
            //   ,t.注册类型
            //   from VW_PaymentDetail t
            //   where t.注册费 <= t.注册费收款额 and t.注册进度 = '完成'
            //   and t.注册员ID='" + userID + @"'
            //   and Year(t.收款日期)= " + year + " and MONTH(t.收款日期)=  " + month;"




            DataSet dst = ServiceManager.GetDatabase().GetEntity(strSql, "TW_SalarySum");

            strSql = @" select
   newID() as TW_SalarySumID,
    t.公司预核名称 as 客户名称,
    newid(),
    0 as 做账收款额,
    t.注册员 as 员工,
    t.注册员ID as 员工ID,
    null as 支付日期,
    0 as 注册费收款额,
    '注册收款数' as 收款类别,
    t.月做账费 ,
    t.年做账费,
    dbo.GetRegPrice(t.注册类型) as 注册费,
	  '注册员注册提成' as 工资统计类型,
    t.注册类型
    from[dbo].[TW_BusinessReg]
        t
   where t.注册进度 like  '%完成%'  and t.注册员ID='" + userID + @"'
    and Year(t.[注册完成时间])= " + year + " and MONTH(t.[注册完成时间])= " + month + "";
            ServiceManager.GetDatabase().FillEntity(strSql, dst, "TW_SalarySumReg");

            return dst;
        }

        #endregion 注册员业绩统计

        #region 做账业绩统计

        /// <summary>
        /// 查询做账会计的业绩
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetAccountantSum(int year, int month, string userName, string deptid)
        {
            DateTime date = new DateTime(year, month, DateTime.DaysInMonth(year, month));
            DateTime pdate = date.AddMonths(-1);//减少一个月
            pdate = new DateTime(pdate.Year, pdate.Month, DateTime.DaysInMonth(pdate.Year, pdate.Month));
            //做账费,零申报费
            string strSql = @"
            select tp.DEPTID, tp.员工,tp.员工ID,sum(tp.做账收款额) 做账收款额  ,sum(tp.做账提成) 做账提成
           ,sum(tp.工本收款费) 工本收款费 ,sum(tp.开票收款费) 开票收款费,
           sum(tp.工本费开票费提成) 工本费开票费提成
           ,sum(tp.团队提成) 团队提成 ,sum(tp.学徒提成) 学徒提成, sum(tp.实习工资) 实习工资,tp.TeacherID,sum(tp.月做账费) 月做账费 from
		   (
            select tu.DEPTID,
            tt.员工,tt.员工ID,tt.做账收款额 as 做账收款额 ,tt.做账提成 * tc.做账_提成 as 做账提成
           ,tt.工本收款费 as 工本收款费 ,tt.开票收款费 as 开票收款费,
           (tt.工本收款费+tt.开票收款费) * tc.做账_工本提成 as 工本费开票费提成
           ,0 as 团队提成 ,0 as 学徒提成 , 0 as 实习工资,tu.TeacherID,月做账费
           from (
           select ts.员工,ts.员工ID,sum(ts.做账收款额) as 做账收款额 ,sum(ts.月做账费)  as 做账提成,sum(ts.月做账费) as 月做账费
           ,sum(ts.工本收款费) as 工本收款费 ,sum(ts.开票收款费) as 开票收款费,
           sum(ts.工本收款费+ts.开票收款费)  as 工本费开票费提成
           , sum(ts.注册费收款额) as 注册费收款额  from (
           select
            t.支付单位 as 客户名称,
            newid() as  客户名称ID,
           t.支付金额 as 做账收款额,
           t.工本费 as 工本收款费,
           t.开票费 as 开票收款费,
           0 as 做账提成 ,
           0 as 工本费开票费提成,
           t.做账会计 as 员工,
           t.做账会计ID as 员工ID,
           t.支付日期 as 支付日期,
           0 as 注册费收款额,
           0 as 注册提成,
           t.收款类别,
           t.月平均费 as 月做账费,
           t.月做账费 * 12 as 年做账费,
           '业务员做账费' as 工资统计类型
           from TW_Payment  t,[dbo].[TW_Client] t2,TCOM_USER tuu
           where
           t.客户名称ID = t2.客户名称ID
           and isnull(t.零申报,0)=0
           and  '" + date.ToString("yyyy-MM-dd") + @"' <= t.本次到期月份
           and  '" + date.ToString("yyyy-MM-dd") + "' > isnull(t.上次到期月份,'1900-1-1')" + @"
           and t.收款类别 = '常规收款'
           and t.支付日期<='" + date.ToString("yyyy-MM-dd") + @"'
           and t.是否审核=1
           and tuu.userid =  t.做账会计ID ";
            if (!string.IsNullOrEmpty(deptid))
                strSql += " and tuu.deptid = '" + deptid + "'";

            //加入补收款 收款日期这个月，但是到期月份是小于这个月
            strSql += @" union
			select
            t.支付单位 as 客户名称,
           newid() as  客户名称ID,
           t.支付金额 as 做账收款额,
           t.工本费 as 工本收款费,
           t.开票费 as 开票收款费,
           0 as 做账提成 ,
           0 as 工本费开票费提成,
           t.做账会计 as 员工,
           t.做账会计ID as 员工ID,
           t.支付日期 as 支付日期,
           0 as 注册费收款额,
           0 as 注册提成,
           t.收款类别,
           t.支付金额 as 月做账费,
           t.月做账费 * 12 as 年做账费,
           '业务员做账费' as 工资统计类型
           from TW_Payment  t,[dbo].[TW_Client] t2,TCOM_USER tuu
           where
           t.客户名称ID = t2.客户名称ID
           and isnull(t.零申报,0)=0
		   and YEAR(t.支付日期)=" + year + @" and  month(t.支付日期)=" + month + @"

           and  '" + pdate.ToString("yyyy-MM-dd") + @"' > isnull(t.上次到期月份,'1900-1-1')
           and t.收款类别 = '常规收款'
           and t.是否审核=1
           and tuu.userid =  t.做账会计ID ";

            if (!string.IsNullOrEmpty(deptid))
                strSql += " and tuu.deptid = '" + deptid + "'";

            strSql += @" union
           select
           t.客户名称,
           newid() as  客户名称ID,
           t.做账费收款额 as 做账收款额,
           t.工本费收款额 as 工本收款额,
           t.开票费收款额 as 开票收款额,
           0 as 做账提成,
           0 as 工本费开票费提成,
           t.做账会计 as 员工,
           t.做账会计ID as 员工ID,
           t.收款日期 as 支付日期,
           t.注册费收款额,
           0 as 注册提成,
           '注册收款' as 收款类别,
           t.月平均费 as 月做账费 ,
           t.年做账费,
           '业务员注册费' as 工资统计类型
           from VW_PaymentDetail t, TW_Client t2,TCOM_USER tuu
           where
           t.客户名称ID=t2.客户名称ID
           and tuu.userid =  t.做账会计ID ";
            if (!string.IsNullOrEmpty(deptid))
                strSql += " and tuu.deptid = '" + deptid + "'";
            strSql += @" and isnull(t.零申报,0)=0
	        and  '" + date.ToString("yyyy-MM-dd") + @"' <= t.做账到期月
	        and t.注册费<=t.注册费收款额
            and (注册类型='注册' or  注册类型='设立'
            or 注册类型='变更' or 注册类型='注销')
            
         union
			    select
            t.客户名称,
           newid() as  客户名称ID,
           t.做账费收款额 as 做账收款额,
           t.工本费收款额 as 工本收款额,
           t.开票费收款额 as 开票收款额,
           0 as 做账提成,
           0 as 工本费开票费提成,
           t.做账会计 as 员工,
           t.做账会计ID as 员工ID,
           t.收款日期 as 支付日期,
           t.注册费收款额,
           0 as 注册提成,
           '注册收款' as 收款类别,
           t.做账费收款额 as 月做账费 ,
           t.年做账费,
           '业务员注册费' as 工资统计类型
           from VW_PaymentDetail t, TW_Client t2,TCOM_USER tuu
           where
           t.客户名称ID=t2.客户名称ID
           and tuu.userid =  t.做账会计ID ";
            if (!string.IsNullOrEmpty(deptid))
                strSql += " and tuu.deptid = '" + deptid + "'";
            strSql += @" and isnull(t.零申报,0)=0
	        and  '" + pdate.ToString("yyyy-MM-dd") + @"' <= t.做账到期月
	        and t.注册费<=t.注册费收款额
             and (注册类型='注册' or  注册类型='设立'
            or 注册类型='变更' or 注册类型='注销')
			and YEAR(t.收款日期)=" + year + @" and  month(t.收款日期)=" + month + @"
            ) as ts
           group by ts.员工,ts.员工ID
           ) as tt,TCOM_USER tu,
           TWS_Commission as tc
           where  tt.员工ID=tu.USERID and  tc.TWS_CommissionID='1'
           union
           select
            tu.deptID ,tt.员工,tt.员工ID,tt.做账收款额 as 做账收款额 ,tt.做账提成 * tc.做账_零申报提成 as 做账提成
           ,tt.工本收款费 as 工本收款费 ,tt.开票收款费 as 开票收款费,
           (tt.工本收款费+tt.开票收款费) * tc.做账_工本提成 as 工本费开票费提成
           ,0 as 团队提成,0 as 学徒提成,0 as 实习工资,tu.TeacherID,月做账费
           from (
           select ts.员工,ts.员工ID,sum(ts.做账收款额) as 做账收款额 ,sum(ts.月做账费)  as 做账提成,sum(ts.月做账费) as 月做账费
           ,sum(ts.工本收款费) as 工本收款费 ,sum(ts.开票收款费) as 开票收款费,
           sum(ts.工本收款费+ts.开票收款费)  as 工本费开票费提成
           , sum(ts.注册费收款额) as 注册费收款额  from (
           select
           t.支付单位 as 客户名称,
           newid() as  客户名称ID,
           t.支付金额 as 做账收款额,
           t.工本费 as 工本收款费,
           t.开票费 as 开票收款费,
           0 as 做账提成 ,
           0 as 工本费开票费提成,
           t.做账会计 as 员工,
           t.做账会计ID as 员工ID,
           t.支付日期,
           0 as 注册费收款额,
           0 as 注册提成,
           t.收款类别,
           t.月平均费 as 月做账费,
           t.月做账费 * 12 as 年做账费,
           '业务员做账费' as 工资统计类型
           from TW_Payment  t,[dbo].[TW_Client] t2,TCOM_USER tuu
           where
           t.客户名称ID = t2.客户名称ID
            and tuu.userid =  t.做账会计ID
           and isnull(t.零申报,0)=1 ";
            if (!string.IsNullOrEmpty(deptid))
                strSql += " and tuu.deptid = '" + deptid + "'";
            strSql += @" and  '" + date.ToString("yyyy-MM-dd") + @"' <= t.本次到期月份
           and  '" + date.ToString("yyyy-MM-dd") + "' > isnull(t.上次到期月份,'1900-1-1')" + @"
           and t.收款类别 = '常规收款'
           and t.支付日期<='" + date.ToString("yyyy-MM-dd") + @"'
           and t.是否审核=1
            union
             select
           t.支付单位 as 客户名称,
           newid() as  客户名称ID,
           t.支付金额 as 做账收款额,
           t.工本费 as 工本收款费,
           t.开票费 as 开票收款费,
           0 as 做账提成 ,
           0 as 工本费开票费提成,
           t.做账会计 as 员工,
           t.做账会计ID as 员工ID,
           t.支付日期,
           0 as 注册费收款额,
           0 as 注册提成,
           t.收款类别,
           t.月平均费 as 月做账费,
           t.月做账费 * 12 as 年做账费,
           '业务员做账费' as 工资统计类型
           from TW_Payment  t,[dbo].[TW_Client] t2,TCOM_USER tuu
           where
           t.客户名称ID = t2.客户名称ID
            and tuu.userid =  t.做账会计ID ";
            if (!string.IsNullOrEmpty(deptid))
                strSql += " and tuu.deptid = '" + deptid + "'";

            strSql += @" and isnull(t.零申报,0)=1
           and YEAR(t.支付日期)=" + year + @" and  month(t.支付日期)=" + month + @"

           --  and  '" + date.ToString() + @"' <= t.本次到期月份
          and  '" + date.ToString("yyyy-MM-dd") + "' > isnull(t.上次到期月份,'1900-1-1')" + @"
           and t.收款类别 ='常规收款'
           and t.是否审核=1
           union
           select
           t.客户名称,
           newid() as  客户名称ID,
           t.做账费收款额 as 做账收款额,
           t.工本费收款额 as 工本收款额,
           t.开票费收款额 as 开票收款额,
           0 as 做账提成,
           0 as 工本费开票费提成,
           t.做账会计 as 员工,
           t.做账会计ID as 员工ID,
           t.收款日期 as 支付日期,
           t.注册费收款额,
           0 as 注册提成,
           '注册收款' as 收款类别,
           t.月平均费 as 月做账费 ,
           t.年做账费,
           '业务员注册费' as 工资统计类型
           from VW_PaymentDetail t, TW_Client t2,TCOM_USER tuu
           where
           t.客户名称ID=t2.客户名称ID
            and tuu.userid =  t.做账会计ID
           and isnull(t.零申报,0)=1 ";
            if (!string.IsNullOrEmpty(deptid))
                strSql += " and tuu.deptid = '" + deptid + "'";
            strSql += @" and  '" + date.ToString("yyyy-MM-dd") + @"' <= t.做账到期月
	       and t.注册费<=t.注册费收款额
            and (注册类型='注册' or  注册类型='设立'
            or 注册类型='变更' or 注册类型='注销')
           union
           select
           t.客户名称,
           newid() as  客户名称ID,
           t.做账费收款额 as 做账收款额,
           t.工本费收款额 as 工本收款额,
           t.开票费收款额 as 开票收款额,
           0 as 做账提成,
           0 as 工本费开票费提成,
           t.做账会计 as 员工,
           t.做账会计ID as 员工ID,
           t.收款日期 as 支付日期,
           t.注册费收款额,
           0 as 注册提成,
           '注册收款' as 收款类别,
           t.月平均费 as 月做账费 ,
           t.年做账费,
           '业务员注册费' as 工资统计类型
           from VW_PaymentDetail t, TW_Client t2,TCOM_USER tuu
           where
           t.客户名称ID=t2.客户名称ID
            and tuu.userid =  t.做账会计ID ";
            if (!string.IsNullOrEmpty(deptid))
                strSql += " and tuu.deptid = '" + deptid + "'";

            strSql += @" and isnull(t.零申报,0)=1
	       and  '" + pdate.ToString("yyyy-MM-dd") + @"' <= t.做账到期月
	        and t.注册费<=t.注册费收款额
            and (注册类型='注册' or  注册类型='设立'
            or 注册类型='变更' or 注册类型='注销')
			and YEAR(t.收款日期)=" + year + @" and  month(t.收款日期)=" + month + @"
           ) as ts
           group by ts.员工,ts.员工ID
           ) as tt,TCOM_USER tu,
           TWS_Commission as tc
           where tt.员工ID=tu.USERID and  tc.TWS_CommissionID='1' ";

            //if (!string.IsNullOrEmpty(deptid))
            //{
            //    strSql += "  and tu.deptid ='" + deptid + "'";
            //}

            strSql += @" ) as tp
		   group by tp.员工,tp.员工ID,tp.TeacherID,tp.DEPTID ";


            DataSet dst = ServiceManager.GetDatabase().GetEntity(strSql, "VW_AllAccountantSalary");

            string strUserSql = "select DEPTID ,USERNAME as 员工,USERID as 员工ID  from [dbo].[TCOM_USER] where 1=1 and OutDate is null ";  //查询所有员工
            if (!string.IsNullOrEmpty(deptid))
            {
                strUserSql += " and DEPTID ='" + deptid + "'";
            }
            if (!string.IsNullOrEmpty(userName))
            {
                strUserSql += " and USERNAME ='" + userName + "'";
            }
            ///没做账收入，添加0记录
            DataSet userDst = ServiceManager.GetDatabase().GetEntity(strUserSql, "TCOM_USER");
            foreach (DataRow row in userDst.Tables[0].Rows)
            {
                string userid = row["员工ID"].ToString();
                DataRow[] frows = dst.Tables[0].Select("员工ID='" + userid + "'");
                if (frows.Length == 0)
                {
                    var newRow = dst.Tables[0].NewRow();
                    newRow["DEPTID"] = row["DEPTID"].ToString();
                    newRow["员工ID"] = row["员工ID"].ToString();
                    newRow["员工"] = row["员工"].ToString();
                    newRow["做账收款额"] = 0;
                    newRow["做账提成"] = 0;
                    newRow["工本收款费"] = 0;
                    newRow["开票收款费"] = 0;
                    newRow["工本费开票费提成"] = 0;
                    newRow["团队提成"] = 0;
                    newRow["学徒提成"] = 0;
                    newRow["实习工资"] = 0;
                    newRow["月做账费"] = 0;
                    dst.Tables[0].Rows.Add(newRow);
                }

            }

            #region 学徒提层去掉
            //       //带人费,学徒
            //       string Sql = @"select
            //       tt.员工,tt.员工ID,tt.做账收款额 as 做账收款额 ,tt.做账提成 * tc.做账_带人提成 as 做账提成
            //      ,tt.工本收款费 as 工本收款费 ,tt.开票收款费 as 开票收款费,
            //      (tt.工本收款费+tt.开票收款费) * tc.做账_工本提成 as 工本费开票费提成
            //      ,0 as 团队提成,tt.师父ID
            //      from (
            //      select ts.员工,ts.员工ID,sum(ts.做账收款额) as 做账收款额 ,sum(ts.月做账费)  as 做账提成
            //      ,sum(ts.工本收款费) as 工本收款费 ,sum(ts.开票收款费) as 开票收款费,
            //      sum(ts.工本收款费+ts.开票收款费)  as 工本费开票费提成
            //      , sum(ts.注册费收款额) as 注册费收款额,ts.师父ID  from (
            //      select
            //      t.支付单位 as 客户名称,
            //      newid() as  客户名称ID,
            //      t.支付金额 as 做账收款额,
            //      t.工本费 as 工本收款费,
            //      t.开票费 as 开票收款费,
            //      0 as 做账提成 ,
            //      0 as 工本费开票费提成,
            //      t.做账会计 as 员工,
            //      t.做账会计ID as 员工ID,
            //      t.支付日期,
            //      0 as 注册费收款额,
            //      0 as 注册提成,
            //      t.收款类别,
            //      t.月平均费 as 月做账费,
            //      t.月做账费 * 12 as 年做账费,
            //      '业务员做账费' as 工资统计类型,
            //      t3.TeacherID as 师父ID
            //      from TW_Payment  t,[dbo].[TW_Client] t2,[dbo].[TCOM_USER] t3
            //      where
            //      t.客户名称ID = t2.客户名称ID
            //      and t.做账会计ID = t3.USERID
            //      and t3.EMPLOYEETYPE='学徒'
            //      and isnull(t.零申报,0)=0
            //       and  '" + date.ToString("yyyy-MM-dd") + @"' <= t.本次到期月份
            //      and  '" + date.ToString("yyyy-MM-dd") + "' > isnull(t.上次到期月份,'1900-1-1')" + @"
            //      and t.操作时间<='" + date.ToString("yyyy-MM-dd") + @"'
            //      and t.收款类别 = '常规收款'
            //      and t.是否审核=1
            //      union
            //      select
            //      t.支付单位 as 客户名称,
            //      newid() as  客户名称ID,
            //      t.支付金额 as 做账收款额,
            //      t.工本费 as 工本收款费,
            //      t.开票费 as 开票收款费,
            //      0 as 做账提成 ,
            //      0 as 工本费开票费提成,
            //      t.做账会计 as 员工,
            //      t.做账会计ID as 员工ID,
            //      t.支付日期,
            //      0 as 注册费收款额,
            //      0 as 注册提成,
            //      t.收款类别,
            //      t.支付金额 as 月做账费,
            //      t.月做账费 * 12 as 年做账费,
            //      '业务员做账费' as 工资统计类型,
            //      t3.TeacherID as 师父ID
            //      from TW_Payment  t,[dbo].[TW_Client] t2,[dbo].[TCOM_USER] t3
            //      where
            //      t.客户名称ID = t2.客户名称ID
            //      and t.做账会计ID = t3.USERID
            //      and t3.EMPLOYEETYPE='学徒'
            //      and isnull(t.零申报,0)=0
            //      and YEAR(t.操作时间)=" + year + @" and  month(t.操作时间)=" + month + @"
            //      and  '" + pdate.ToString("yyyy-MM-dd") + @"' >= t.本次到期月份
            //       and  '" + pdate.ToString("yyyy-MM-dd") + @"' > isnull(t.上次到期月份,'1900-1-1')
            //      and t.操作时间<='" + date.ToString("yyyy-MM-dd") + @"'
            //      and t.收款类别 = '常规收款'
            //      and t.是否审核=1
            //      union
            //      select
            //      t.客户名称,
            //      newid() as  客户名称ID,
            //      t.做账费收款额 as 做账收款额,
            //      t.工本费收款额 as 工本收款额,
            //      t.开票费收款额 as 开票收款额,
            //      0 as 做账提成,
            //      0 as 工本费开票费提成,
            //      t.做账会计 as 员工,
            //      t.做账会计ID as 员工ID,
            //      t.收款日期 as 支付日期,
            //      t.注册费收款额,
            //      0 as 注册提成,
            //      '注册收款' as 收款类别,
            //      t.月平均费 as 月做账费 ,
            //      t.年做账费,
            //      '业务员注册费' as 工资统计类型,t3.TeacherID as 师父ID
            //      from VW_PaymentDetail t, TW_Client t2,TCOM_USER t3
            //      where
            //      t.客户名称ID=t2.客户名称ID
            //      and t.做账会计ID = t3.USERID
            //      and t3.EMPLOYEETYPE='学徒'
            //      and isnull(t.零申报,0)=0
            //    and  '" + date.ToString("yyyy-MM-dd") + @"' <= t.做账到期月
            //   and t.注册费<=t.注册费收款额
            //      and Year(t.收款日期)=" + year + " and MONTH(t.收款日期)=" + month + @"
            //      union
            //      select
            //      t.客户名称,
            //      newid() as  客户名称ID,
            //      t.做账费收款额 as 做账收款额,
            //      t.工本费收款额 as 工本收款额,
            //      t.开票费收款额 as 开票收款额,
            //      0 as 做账提成,
            //      0 as 工本费开票费提成,
            //      t.做账会计 as 员工,
            //      t.做账会计ID as 员工ID,
            //      t.收款日期 as 支付日期,
            //      t.注册费收款额,
            //      0 as 注册提成,
            //      '注册收款' as 收款类别,
            //      t.月平均费 as 月做账费 ,
            //      t.年做账费,
            //      '业务员注册费' as 工资统计类型,t3.TeacherID as 师父ID
            //      from VW_PaymentDetail t, TW_Client t2,TCOM_USER t3
            //      where
            //      t.客户名称ID=t2.客户名称ID
            //      and t.做账会计ID = t3.USERID
            //      and t3.EMPLOYEETYPE='学徒'
            //      and isnull(t.零申报,0)=0
            //   and  '" + pdate.ToString("yyyy-MM-dd") + @"'<= t.做账到期月
            //   and t.注册费<=t.注册费收款额
            //and YEAR(t.收款日期)=" + year + @" and  month(t.收款日期)=" + month + @"
            //      ) as ts
            //      group by ts.员工,ts.员工ID,ts.师父ID
            //      ) as tt,
            //      TWS_Commission as tc
            //      where tc.TWS_CommissionID='1'";
            //       DataSet dst1 = ServiceManager.GetDatabase().GetEntity(Sql, "VW_AllAccountantSalary");

            //       foreach (DataRow row in dst1.Tables[0].Rows)
            //       {
            //           string teacherID = row["师父ID"].ToString();
            //           DataRow[] rows = dst.Tables[0].Select("员工ID='" + teacherID + "'");
            //           if (rows.Length > 0)
            //           {
            //               decimal xtTC = decimal.Parse(rows[0]["学徒提成"].ToString());
            //               xtTC += decimal.Parse(row["做账提成"].ToString());
            //               rows[0].BeginEdit();
            //               rows[0]["学徒提成"] = xtTC;
            //               rows[0].EndEdit();
            //           }
            //       }
            #endregion

            string userManagerID = "";
            string worktype = "";
            //获取主管/经理USERID
            userManagerID = GetManagerID(deptid, userManagerID, out worktype);
            //获取其他员工做账明细
            DataSet dstDetail = GetAccountantDetail(year, month, deptid);
            decimal sumMonthPrice = 0;
            foreach (DataRow row in dstDetail.Tables["VW_AllAccountantSalaryDetail"].Rows)
            {

                //自己排除
                if (row["员工ID"].ToString() == userManagerID)
                    continue;
                if (!string.IsNullOrEmpty(row["月平均费"].ToString()))
                    sumMonthPrice += decimal.Parse(row["月平均费"].ToString());
            }
            //零申报

            decimal sumLSB = 0;
            if (string.IsNullOrEmpty(deptid))
            {
                DataSet dstLSBDetail = GetLSBAccountantDetail(year, month);
                foreach (DataRow row in dstLSBDetail.Tables["VW_AllAccountantSalaryDetail"].Rows)
                {
                    if (row["员工ID"].ToString() == userManagerID)
                        continue;
                    if (!string.IsNullOrEmpty(row["月平均费"].ToString()))
                        sumLSB += decimal.Parse(row["月平均费"].ToString());
                }
            }
            if (worktype == "代账主管")  //计算其他经理的团队提成
            {
                string JLsql = " select USERID, USERNAME, DEPTID from TCOM_USER where WorkType = '二级部门经理' ";
                DataSet jlds = ServiceManager.GetDatabase().GetEntity(JLsql, "TCOMUSER");
                foreach (DataRow row in jlds.Tables[0].Rows)
                {
                    string jluserId = row["USERID"].ToString();
                    string jluserName = row["USERNAME"].ToString();
                    string jlDeptID = row["DEPTID"].ToString();
                    decimal jlsumMonthPrice = 0;//经理团队收款总额;

                    DataRow[] tdrows = dstDetail.Tables["VW_AllAccountantSalaryDetail"].Select("DEPTID = '" + jlDeptID + "'");
                    foreach (DataRow tdrow in tdrows)
                    {

                        //自己排除
                        if (tdrow["员工ID"].ToString() == jluserId)
                            continue;
                        if (!string.IsNullOrEmpty(tdrow["月平均费"].ToString()))
                            jlsumMonthPrice += decimal.Parse(tdrow["月平均费"].ToString());
                    }
                    DataRow[] managerRows = dst.Tables["VW_AllAccountantSalary"].Select("员工ID='" + jluserId + "'");
                    if (managerRows.Length > 0)
                    {
                        managerRows[0].BeginEdit();
                        managerRows[0]["团队提成"] = jlsumMonthPrice * (decimal)0.05;
                        managerRows[0].EndEdit();
                    }

                }
            }


            if (worktype == "二级部门经理")  //二级部门经理提层5%
            {
                DataRow[] managerRows = dst.Tables["VW_AllAccountantSalary"].Select("员工ID='" + userManagerID + "'");
                if (managerRows.Length > 0)
                {
                    managerRows[0].BeginEdit();
                    managerRows[0]["团队提成"] = sumMonthPrice * (decimal)0.05;
                    managerRows[0].EndEdit();
                }
            }
            else if (worktype == "代账主管")  //主管提层1%
            {
                DataRow[] managerRows = dst.Tables["VW_AllAccountantSalary"].Select("员工ID='" + userManagerID + "'");
                if (managerRows.Length > 0)
                {
                    managerRows[0].BeginEdit();
                    managerRows[0]["团队提成"] = sumMonthPrice * (decimal)0.01 + sumLSB * (decimal)0.005;
                    managerRows[0].EndEdit();
                }
            }
            #region 实习工资
            //string SqlUser = @"select t.TeacherID,sum(t.Salary) as Salary  from TCOM_USER t
            //where t.EMPLOYEETYPE='实习'
            //group by t.TeacherID";
            //DataSet dstUser = ServiceManager.GetDatabase().GetEntity(SqlUser, "TCOM_USER");
            //foreach (DataRow row in dstUser.Tables[0].Rows)
            //{
            //    string teacherID = row["TeacherID"].ToString();
            //    decimal salary = 0;
            //    if (!string.IsNullOrEmpty(row["Salary"].ToString()))
            //    {
            //        salary = decimal.Parse(row["Salary"].ToString());
            //    }
            //    DataRow[] rows = dst.Tables[0].Select("员工ID='" + teacherID + "'");
            //    if (rows.Length > 0)
            //    {
            //        rows[0].BeginEdit();
            //        rows[0]["实习工资"] = salary;
            //        rows[0].EndEdit();
            //    }
            //}
            #endregion
            if (!string.IsNullOrEmpty(userName))
            {
                int rowCount = dst.Tables["VW_AllAccountantSalary"].Rows.Count;
                int i = 0;
                while (i < dst.Tables["VW_AllAccountantSalary"].Rows.Count)
                {
                    DataRow row = dst.Tables["VW_AllAccountantSalary"].Rows[i];
                    string rowUserName = row["员工"].ToString();
                    if (rowUserName != userName)
                    {
                        dst.Tables["VW_AllAccountantSalary"].Rows.Remove(row);
                    }
                    else
                        i++;
                }
            }
            dst.Tables[0].AcceptChanges();
            return dst;
        }

        private static string GetManagerID(string deptid, string userManagerID, out string worktype)
        {
            if (!string.IsNullOrEmpty(deptid))
            {
                string sqlUser = "select * from TCOM_USER where workType='二级部门经理' and deptid ='" + deptid + "'";
                DataSet dstuser = ServiceManager.GetDatabase().GetEntity(sqlUser, "TCOM_USER");
                if (dstuser.Tables["TCOM_USER"].Rows.Count > 0)
                {
                    userManagerID = dstuser.Tables["TCOM_USER"].Rows[0]["USERID"].ToString();
                    worktype = "二级部门经理";
                }
                else
                    worktype = "";
            }
            else
            {
                string sqlUser = "select * from TCOM_USER where workType='会计主管' or  workType='代账主管' ";
                DataSet dstuser = ServiceManager.GetDatabase().GetEntity(sqlUser, "TCOM_USER");
                if (dstuser.Tables["TCOM_USER"].Rows.Count > 0)
                {
                    userManagerID = dstuser.Tables["TCOM_USER"].Rows[0]["USERID"].ToString();
                    worktype = "代账主管";
                }
                else
                    worktype = "";
            }

            return userManagerID;
        }



        /// <summary>
        /// 查询做账会计的业绩
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetAccountantSum2021(int year, int month, string userName, string deptid)
        {
            DateTime date = new DateTime(year, month, DateTime.DaysInMonth(year, month));
            DateTime pdate = date.AddMonths(-1);//减少一个月
            pdate = new DateTime(pdate.Year, pdate.Month, DateTime.DaysInMonth(pdate.Year, pdate.Month));
            //做账费,零申报费
            string strSql = @"
            select  tp.员工,tp.员工ID,sum(tp.做账收款额) 做账收款额  ,sum(tp.做账提成) 做账提成
           ,sum(tp.工本收款费) 工本收款费 ,sum(tp.开票收款费) 开票收款费,
           sum(tp.工本费开票费提成) 工本费开票费提成
           ,sum(tp.团队提成) 团队提成 ,sum(tp.学徒提成) 学徒提成, sum(tp.实习工资) 实习工资,tp.TeacherID,sum(tp.月做账费) 月做账费 from
		   (
            select
            tt.员工,tt.员工ID,tt.做账收款额 as 做账收款额 ,tt.做账提成 * tc.做账_提成 as 做账提成
           ,tt.工本收款费 as 工本收款费 ,tt.开票收款费 as 开票收款费,
           (tt.工本收款费+tt.开票收款费) * tc.做账_工本提成 as 工本费开票费提成
           ,0 as 团队提成 ,0 as 学徒提成 , 0 as 实习工资,tu.TeacherID,月做账费
           from (
           select ts.员工,ts.员工ID,sum(ts.做账收款额) as 做账收款额 ,sum(ts.月做账费)  as 做账提成,sum(ts.月做账费) as 月做账费
           ,sum(ts.工本收款费) as 工本收款费 ,sum(ts.开票收款费) as 开票收款费,
           sum(ts.工本收款费+ts.开票收款费)  as 工本费开票费提成
           , sum(ts.注册费收款额) as 注册费收款额  from (
           select
           t.支付单位 as 客户名称,
            newid() as  客户名称ID,
           t.支付金额 as 做账收款额,
           t.工本费 as 工本收款费,
           t.开票费 as 开票收款费,
           0 as 做账提成 ,
           0 as 工本费开票费提成,
           t.做账会计 as 员工,
           t.做账会计ID as 员工ID,
           t.支付日期 as 支付日期,
           0 as 注册费收款额,
           0 as 注册提成,
           t.收款类别,
           t.月平均费 as 月做账费,
           t.月做账费 * 12 as 年做账费,
           '业务员做账费' as 工资统计类型
           from TW_Payment  t,[dbo].[TW_Client] t2
           where
           t.客户名称ID = t2.客户名称ID
           and isnull(t.零申报,0)=0
           and  '" + date.ToString("yyyy-MM-dd") + @"' <= t.本次到期月份
           and  '" + date.ToString("yyyy-MM-dd") + "' > isnull(t.上次到期月份,'1900-1-1')" + @"
           and t.收款类别 = '常规收款'
           and t.支付日期<='" + date.ToString("yyyy-MM-dd") + @"'
           and t.是否审核=1
--加入补收款 收款日期这个月，但是到期月份是小于这个月
             union
			select
           t.支付单位 as 客户名称,
           newid() as  客户名称ID,
           t.支付金额 as 做账收款额,
           t.工本费 as 工本收款费,
           t.开票费 as 开票收款费,
           0 as 做账提成 ,
           0 as 工本费开票费提成,
           t.做账会计 as 员工,
           t.做账会计ID as 员工ID,
           t.支付日期 as 支付日期,
           0 as 注册费收款额,
           0 as 注册提成,
           t.收款类别,
           t.支付金额 as 月做账费,
           t.月做账费 * 12 as 年做账费,
           '业务员做账费' as 工资统计类型
           from TW_Payment  t,[dbo].[TW_Client] t2
           where
           t.客户名称ID = t2.客户名称ID
           and isnull(t.零申报,0)=0
		   and YEAR(t.支付日期)=" + year + @" and  month(t.支付日期)=" + month + @"

           and  '" + pdate.ToString("yyyy-MM-dd") + @"' > isnull(t.上次到期月份,'1900-1-1')
           and t.收款类别 = '常规收款'
           and t.是否审核=1
           union
           select
           t.客户名称,
           newid() as  客户名称ID,
           t.做账费收款额 as 做账收款额,
           t.工本费收款额 as 工本收款额,
           t.开票费收款额 as 开票收款额,
           0 as 做账提成,
           0 as 工本费开票费提成,
           t.做账会计 as 员工,
           t.做账会计ID as 员工ID,
           t.收款日期 as 支付日期,
           t.注册费收款额,
           0 as 注册提成,
           '注册收款' as 收款类别,
           t.月平均费 as 月做账费 ,
           t.年做账费,
           '业务员注册费' as 工资统计类型
           from VW_PaymentDetail t, TW_Client t2
           where
           t.客户名称ID=t2.客户名称ID
           and isnull(t.零申报,0)=0
	        and  '" + date.ToString("yyyy-MM-dd") + @"' <= t.做账到期月
	        and t.注册费<=t.注册费收款额
         union
			    select
           t.客户名称,
           newid() as  客户名称ID,
           t.做账费收款额 as 做账收款额,
           t.工本费收款额 as 工本收款额,
           t.开票费收款额 as 开票收款额,
           0 as 做账提成,
           0 as 工本费开票费提成,
           t.做账会计 as 员工,
           t.做账会计ID as 员工ID,
           t.收款日期 as 支付日期,
           t.注册费收款额,
           0 as 注册提成,
           '注册收款' as 收款类别,
           t.做账费收款额 as 月做账费 ,
           t.年做账费,
           '业务员注册费' as 工资统计类型
           from VW_PaymentDetail t, TW_Client t2
           where
           t.客户名称ID=t2.客户名称ID
           and isnull(t.零申报,0)=0
	        and  '" + pdate.ToString("yyyy-MM-dd") + @"' <= t.做账到期月
	        and t.注册费<=t.注册费收款额
			and YEAR(t.收款日期)=" + year + @" and  month(t.收款日期)=" + month + @"
            ) as ts
           group by ts.员工,ts.员工ID
           ) as tt,TCOM_USER tu,
           TWS_Commission as tc
           where  tt.员工ID=tu.USERID and  tc.TWS_CommissionID='1'
           union
           select
            tt.员工,tt.员工ID,tt.做账收款额 as 做账收款额 ,tt.做账提成 * tc.做账_零申报提成 as 做账提成
           ,tt.工本收款费 as 工本收款费 ,tt.开票收款费 as 开票收款费,
           (tt.工本收款费+tt.开票收款费) * tc.做账_工本提成 as 工本费开票费提成
           ,0 as 团队提成,0 as 学徒提成,0 as 实习工资,tu.TeacherID,月做账费
           from (
           select ts.员工,ts.员工ID,sum(ts.做账收款额) as 做账收款额 ,sum(ts.月做账费)  as 做账提成,sum(ts.月做账费) as 月做账费
           ,sum(ts.工本收款费) as 工本收款费 ,sum(ts.开票收款费) as 开票收款费,
           sum(ts.工本收款费+ts.开票收款费)  as 工本费开票费提成
           , sum(ts.注册费收款额) as 注册费收款额  from (
           select
           t.支付单位 as 客户名称,
           newid() as  客户名称ID,
           t.支付金额 as 做账收款额,
           t.工本费 as 工本收款费,
           t.开票费 as 开票收款费,
           0 as 做账提成 ,
           0 as 工本费开票费提成,
           t.做账会计 as 员工,
           t.做账会计ID as 员工ID,
           t.支付日期,
           0 as 注册费收款额,
           0 as 注册提成,
           t.收款类别,
           t.月平均费 as 月做账费,
           t.月做账费 * 12 as 年做账费,
           '业务员做账费' as 工资统计类型
           from TW_Payment  t,[dbo].[TW_Client] t2
           where
           t.客户名称ID = t2.客户名称ID
           and isnull(t.零申报,0)=1
           
           and  '" + date.ToString("yyyy-MM-dd") + @"' <= t.本次到期月份
           and  '" + date.ToString("yyyy-MM-dd") + "' > isnull(t.上次到期月份,'1900-1-1')" + @"
           and t.收款类别 = '常规收款'
           and t.支付日期<='" + date.ToString("yyyy-MM-dd") + @"'
           and t.是否审核=1
            union
             select
           t.支付单位 as 客户名称,
           newid() as  客户名称ID,
           t.支付金额 as 做账收款额,
           t.工本费 as 工本收款费,
           t.开票费 as 开票收款费,
           0 as 做账提成 ,
           0 as 工本费开票费提成,
           t.做账会计 as 员工,
           t.做账会计ID as 员工ID,
           t.支付日期,
           0 as 注册费收款额,
           0 as 注册提成,
           t.收款类别,
           t.月平均费 as 月做账费,
           t.月做账费 * 12 as 年做账费,
           '业务员做账费' as 工资统计类型
           from TW_Payment  t,[dbo].[TW_Client] t2
           where
           t.客户名称ID = t2.客户名称ID
           and isnull(t.零申报,0)=1
           and YEAR(t.支付日期)=" + year + @" and  month(t.支付日期)=" + month + @"

           --  and  '" + date.ToString() + @"' <= t.本次到期月份
          and  '" + date.ToString("yyyy-MM-dd") + "' > isnull(t.上次到期月份,'1900-1-1')" + @"
           and t.收款类别 ='常规收款'
           and t.是否审核=1
           union
           select
           t.客户名称,
           newid() as  客户名称ID,
           t.做账费收款额 as 做账收款额,
           t.工本费收款额 as 工本收款额,
           t.开票费收款额 as 开票收款额,
           0 as 做账提成,
           0 as 工本费开票费提成,
           t.做账会计 as 员工,
           t.做账会计ID as 员工ID,
           t.收款日期 as 支付日期,
           t.注册费收款额,
           0 as 注册提成,
           '注册收款' as 收款类别,
           t.月平均费 as 月做账费 ,
           t.年做账费,
           '业务员注册费' as 工资统计类型
           from VW_PaymentDetail t, TW_Client t2
           where
           t.客户名称ID=t2.客户名称ID
           and isnull(t.零申报,0)=1
	       and  '" + date.ToString("yyyy-MM-dd") + @"' <= t.做账到期月
	       and t.注册费<=t.注册费收款额
           union
           select
           t.客户名称,
           newid() as  客户名称ID,
           t.做账费收款额 as 做账收款额,
           t.工本费收款额 as 工本收款额,
           t.开票费收款额 as 开票收款额,
           0 as 做账提成,
           0 as 工本费开票费提成,
           t.做账会计 as 员工,
           t.做账会计ID as 员工ID,
           t.收款日期 as 支付日期,
           t.注册费收款额,
           0 as 注册提成,
           '注册收款' as 收款类别,
           t.月平均费 as 月做账费 ,
           t.年做账费,
           '业务员注册费' as 工资统计类型
           from VW_PaymentDetail t, TW_Client t2
           where
           t.客户名称ID=t2.客户名称ID
           and isnull(t.零申报,0)=1
	       and  '" + pdate.ToString("yyyy-MM-dd") + @"' <= t.做账到期月
	        and t.注册费<=t.注册费收款额
			and YEAR(t.收款日期)=" + year + @" and  month(t.收款日期)=" + month + @"
           ) as ts
           group by ts.员工,ts.员工ID
           ) as tt,TCOM_USER tu,
           TWS_Commission as tc
           where tt.员工ID=tu.USERID and  tc.TWS_CommissionID='1'";



            if (!string.IsNullOrEmpty(deptid))
            {
                strSql += "  and tu.deptid ='" + deptid + "'";
            }

            strSql += @" ) as tp
		   group by tp.员工,tp.员工ID,tp.TeacherID ";


            DataSet dst = ServiceManager.GetDatabase().GetEntity(strSql, "VW_AllAccountantSalary");
            //带人费,学徒
            string Sql = @"select
            tt.员工,tt.员工ID,tt.做账收款额 as 做账收款额 ,tt.做账提成 * tc.做账_带人提成 as 做账提成
           ,tt.工本收款费 as 工本收款费 ,tt.开票收款费 as 开票收款费,
           (tt.工本收款费+tt.开票收款费) * tc.做账_工本提成 as 工本费开票费提成
           ,0 as 团队提成,tt.师父ID
           from (
           select ts.员工,ts.员工ID,sum(ts.做账收款额) as 做账收款额 ,sum(ts.月做账费)  as 做账提成
           ,sum(ts.工本收款费) as 工本收款费 ,sum(ts.开票收款费) as 开票收款费,
           sum(ts.工本收款费+ts.开票收款费)  as 工本费开票费提成
           , sum(ts.注册费收款额) as 注册费收款额,ts.师父ID  from (
           select
           t.支付单位 as 客户名称,
           newid() as  客户名称ID,
           t.支付金额 as 做账收款额,
           t.工本费 as 工本收款费,
           t.开票费 as 开票收款费,
           0 as 做账提成 ,
           0 as 工本费开票费提成,
           t.做账会计 as 员工,
           t.做账会计ID as 员工ID,
           t.支付日期,
           0 as 注册费收款额,
           0 as 注册提成,
           t.收款类别,
           t.月平均费 as 月做账费,
           t.月做账费 * 12 as 年做账费,
           '业务员做账费' as 工资统计类型,
           t3.TeacherID as 师父ID
           from TW_Payment  t,[dbo].[TW_Client] t2,[dbo].[TCOM_USER] t3
           where
           t.客户名称ID = t2.客户名称ID
           and t.做账会计ID = t3.USERID
           and t3.EMPLOYEETYPE='学徒'
           and isnull(t.零申报,0)=0
            and  '" + date.ToString("yyyy-MM-dd") + @"' <= t.本次到期月份
           and  '" + date.ToString("yyyy-MM-dd") + "' > isnull(t.上次到期月份,'1900-1-1')" + @"
           and t.支付日期<='" + date.ToString("yyyy-MM-dd") + @"'
           and t.收款类别 = '常规收款'
           and t.是否审核=1
           union
           select
           t.支付单位 as 客户名称,
           newid() as  客户名称ID,
           t.支付金额 as 做账收款额,
           t.工本费 as 工本收款费,
           t.开票费 as 开票收款费,
           0 as 做账提成 ,
           0 as 工本费开票费提成,
           t.做账会计 as 员工,
           t.做账会计ID as 员工ID,
           t.支付日期,
           0 as 注册费收款额,
           0 as 注册提成,
           t.收款类别,
           t.支付金额 as 月做账费,
           t.月做账费 * 12 as 年做账费,
           '业务员做账费' as 工资统计类型,
           t3.TeacherID as 师父ID
           from TW_Payment  t,[dbo].[TW_Client] t2,[dbo].[TCOM_USER] t3
           where
           t.客户名称ID = t2.客户名称ID
           and t.做账会计ID = t3.USERID
           and t3.EMPLOYEETYPE='学徒'
           and isnull(t.零申报,0)=0
           and YEAR(t.支付日期)=" + year + @" and  month(t.支付日期)=" + month + @"
           and  '" + pdate.ToString("yyyy-MM-dd") + @"' >= t.本次到期月份
            and  '" + pdate.ToString("yyyy-MM-dd") + @"' > isnull(t.上次到期月份,'1900-1-1')
           and t.支付日期<='" + date.ToString("yyyy-MM-dd") + @"'
           and t.收款类别 = '常规收款'
           and t.是否审核=1
           union
           select
           t.客户名称,
           newid() as  客户名称ID,
           t.做账费收款额 as 做账收款额,
           t.工本费收款额 as 工本收款额,
           t.开票费收款额 as 开票收款额,
           0 as 做账提成,
           0 as 工本费开票费提成,
           t.做账会计 as 员工,
           t.做账会计ID as 员工ID,
           t.收款日期 as 支付日期,
           t.注册费收款额,
           0 as 注册提成,
           '注册收款' as 收款类别,
           t.月平均费 as 月做账费 ,
           t.年做账费,
           '业务员注册费' as 工资统计类型,t3.TeacherID as 师父ID
           from VW_PaymentDetail t, TW_Client t2,TCOM_USER t3
           where
           t.客户名称ID=t2.客户名称ID
           and t.做账会计ID = t3.USERID
           and t3.EMPLOYEETYPE='学徒'
           and isnull(t.零申报,0)=0
	        and  '" + date.ToString("yyyy-MM-dd") + @"' <= t.做账到期月
	       and t.注册费<=t.注册费收款额
           and Year(t.收款日期)=" + year + " and MONTH(t.收款日期)=" + month + @"
           union
           select
           t.客户名称,
           newid() as  客户名称ID,
           t.做账费收款额 as 做账收款额,
           t.工本费收款额 as 工本收款额,
           t.开票费收款额 as 开票收款额,
           0 as 做账提成,
           0 as 工本费开票费提成,
           t.做账会计 as 员工,
           t.做账会计ID as 员工ID,
           t.收款日期 as 支付日期,
           t.注册费收款额,
           0 as 注册提成,
           '注册收款' as 收款类别,
           t.月平均费 as 月做账费 ,
           t.年做账费,
           '业务员注册费' as 工资统计类型,t3.TeacherID as 师父ID
           from VW_PaymentDetail t, TW_Client t2,TCOM_USER t3
           where
           t.客户名称ID=t2.客户名称ID
           and t.做账会计ID = t3.USERID
           and t3.EMPLOYEETYPE='学徒'
           and isnull(t.零申报,0)=0
	       and  '" + pdate.ToString("yyyy-MM-dd") + @"'<= t.做账到期月
	       and t.注册费<=t.注册费收款额
		   and YEAR(t.收款日期)=" + year + @" and  month(t.收款日期)=" + month + @"
           ) as ts
           group by ts.员工,ts.员工ID,ts.师父ID
           ) as tt,
           TWS_Commission as tc
           where tc.TWS_CommissionID='1'";
            DataSet dst1 = ServiceManager.GetDatabase().GetEntity(Sql, "VW_AllAccountantSalary");

            foreach (DataRow row in dst1.Tables[0].Rows)
            {
                string teacherID = row["师父ID"].ToString();
                DataRow[] rows = dst.Tables[0].Select("员工ID='" + teacherID + "'");
                if (rows.Length > 0)
                {
                    decimal xtTC = decimal.Parse(rows[0]["学徒提成"].ToString());
                    xtTC += decimal.Parse(row["做账提成"].ToString());
                    rows[0].BeginEdit();
                    rows[0]["学徒提成"] = xtTC;
                    rows[0].EndEdit();
                }
            }
            string userManagerID = "";
            string worktype = "";
            userManagerID = GetManagerID(deptid, userManagerID, out worktype);


            //获取其他员工做账明细
            DataSet dstDetail = GetAccountantDetail(year, month, deptid);
            decimal sumMonthPrice = 0;
            foreach (DataRow row in dstDetail.Tables["VW_AllAccountantSalaryDetail"].Rows)
            {
                if (row["员工ID"].ToString() == userManagerID || row["TeacherID"].ToString() == userManagerID)
                    continue;
                if (!string.IsNullOrEmpty(row["月平均费"].ToString()))
                    sumMonthPrice += decimal.Parse(row["月平均费"].ToString());
            }

            //零申报
            decimal sumLSB = 0;
            if (string.IsNullOrEmpty(deptid))
            {
                DataSet dstLSBDetail = GetLSBAccountantDetail(year, month);

                foreach (DataRow row in dstLSBDetail.Tables["VW_AllAccountantSalaryDetail"].Rows)
                {
                    if (row["员工ID"].ToString() == userManagerID || row["TeacherID"].ToString() == userManagerID)
                        continue;
                    if (!string.IsNullOrEmpty(row["月平均费"].ToString()))
                        sumLSB += decimal.Parse(row["月平均费"].ToString());
                }
            }

            if (worktype == "二级部门经理")  //二级部门经理提层5%
            {
                DataRow[] managerRows = dst.Tables["VW_AllAccountantSalary"].Select("员工ID='" + userManagerID + "'");
                if (managerRows.Length > 0)
                {
                    managerRows[0].BeginEdit();
                    managerRows[0]["团队提成"] = sumMonthPrice * (decimal)0.05 + sumLSB * (decimal)0.002;
                    managerRows[0].EndEdit();
                }
            }
            else if (worktype == "代账主管")  //主管提层1%
            {
                DataRow[] managerRows = dst.Tables["VW_AllAccountantSalary"].Select("员工ID='" + userManagerID + "'");
                if (managerRows.Length > 0)
                {
                    managerRows[0].BeginEdit();
                    managerRows[0]["团队提成"] = sumMonthPrice * (decimal)0.01 + sumLSB * (decimal)0.002;
                    managerRows[0].EndEdit();
                }
            }

            string SqlUser = @"select t.TeacherID,sum(t.Salary) as Salary  from TCOM_USER t
            where t.EMPLOYEETYPE='实习'
            group by t.TeacherID";
            DataSet dstUser = ServiceManager.GetDatabase().GetEntity(SqlUser, "TCOM_USER");
            foreach (DataRow row in dstUser.Tables[0].Rows)
            {
                string teacherID = row["TeacherID"].ToString();
                decimal salary = 0;
                if (!string.IsNullOrEmpty(row["Salary"].ToString()))
                {
                    salary = decimal.Parse(row["Salary"].ToString());
                }
                DataRow[] rows = dst.Tables[0].Select("员工ID='" + teacherID + "'");
                if (rows.Length > 0)
                {
                    rows[0].BeginEdit();
                    rows[0]["实习工资"] = salary;
                    rows[0].EndEdit();
                }
            }

            if (!string.IsNullOrEmpty(userName))
            {
                int rowCount = dst.Tables["VW_AllAccountantSalary"].Rows.Count;
                int i = 0;
                while (i < dst.Tables["VW_AllAccountantSalary"].Rows.Count)
                {
                    DataRow row = dst.Tables["VW_AllAccountantSalary"].Rows[i];
                    string rowUserName = row["员工"].ToString();
                    if (rowUserName != userName)
                    {
                        dst.Tables["VW_AllAccountantSalary"].Rows.Remove(row);
                    }
                    else
                        i++;
                }
            }
            dst.Tables[0].AcceptChanges();
            return dst;
        }



        /// <summary>
        /// 查询做账会计明细
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="userID"></param>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetAccountantSumDetail(int year, int month, string userID)
        {
            DateTime date = new DateTime(year, month, DateTime.DaysInMonth(year, month));
            DateTime pdate = date.AddMonths(-1);//减少一个月
            pdate = new DateTime(pdate.Year, pdate.Month, DateTime.DaysInMonth(pdate.Year, pdate.Month));
            string strSql = @" select
          	t.TW_PaymentID,
          t.支付单位 as 客户名称,
          newid() as  客户名称ID,
          t.支付金额 as 做账收款额,
          t.工本费 as 工本收款费,
          t.开票费 as 开票收款费,
          0 as 做账提成,
          0 as 工本费开票费提成,
          t.做账会计 as 员工,
          t.做账会计ID as 员工ID,
          t.支付日期 as 支付日期,
          0 as 注册费收款额,
          0 as 注册提成,
          t.收款类别,
          t.月平均费 as 月做账费,
          t.月平均费 * 12 as 年做账费,
          '做账会计常规' as 工资统计类型
           ,t.上次到期月份 as 开始时间,
		   t.本次到期月份 as 结束时间
          from TW_Payment t,[dbo].[TW_Client] t2
          where
          t.客户名称ID = t2.客户名称ID
          and isnull(t.零申报,0) = 0
          and  '" + date.ToString("yyyy-MM-dd") + @"' <= t.本次到期月份
          and  '" + date.ToString("yyyy-MM-dd") + "' > isnull(t.上次到期月份,'1900-1-1')" + @"
          and t.收款类别 = '常规收款'
          and t.支付日期<='" + date.ToString("yyyy-MM-dd") + @"'
          and t.做账会计ID='" + userID + @"'
          and t.是否审核=1
          union
          select
        	t.TW_PaymentID,
          t.支付单位 as 客户名称,
          newid() as  客户名称ID,
          t.支付金额 as 做账收款额,
          t.工本费 as 工本收款费,
          t.开票费 as 开票收款费,
          0 as 做账提成,
          0 as 工本费开票费提成,
          t.做账会计 as 员工,
          t.做账会计ID as 员工ID,
          t.支付日期 as 支付日期,
          0 as 注册费收款额,
          0 as 注册提成,
          t.收款类别,
          t.支付金额 as 月做账费,
          t.月平均费 * 12 as 年做账费,
          '做账会计常规' as 工资统计类型
        ,t.上次到期月份 as 开始时间,
		   t.本次到期月份 as 结束时间
           from TW_Payment  t,[dbo].[TW_Client] t2
           where
           t.客户名称ID = t2.客户名称ID
           and isnull(t.零申报,0)=0
		   and YEAR(t.支付日期)=" + year + @" and  month(t.支付日期)=" + month + @"
                      and  '" + pdate.ToString("yyyy-MM-dd") + @"' > isnull(t.上次到期月份,'1900-1-1')
          and  '" + pdate.ToString("yyyy-MM-dd") + @"' >= isnull(t.本次到期月份,'1900-1-1')
            and t.收款类别 = '常规收款'
           and t.做账会计ID='" + userID + @"'
           and t.是否审核=1
          union
          select
          newid(),
          t.客户名称,
          t.客户名称ID,
          t.做账费收款额 as 做账收款额,
          t.工本费收款额 as 工本收款额,
          t.开票费收款额 as 开票收款额,
          0 as 做账提成,
          0 as 工本费开票费提成,
          t.做账会计 as 员工,
          t.做账会计ID as 员工ID,
          t.收款日期 as 支付日期,
          t.注册费收款额,
          0 as 注册提成,
          '注册收款' as 收款类别,
          t.月平均费,
          t.年做账费,
          '做账会计注册' as 工资统计类型
            ,t.上次到期月
            ,t.做账到期月
          from VW_PaymentDetail t, TW_Client t2
          where
          t.客户名称ID = t2.客户名称ID
          and isnull(t.零申报,0) = 0
           and  '" + date.ToString("yyyy-MM-dd") + @"' <= t.做账到期月
          and t.注册费 <= t.注册费收款额
          and t.做账会计ID='" + userID + @"'
          union
			select
            newid(),
           t.客户名称,
          t.客户名称ID,
          t.做账费收款额 as 做账收款额,
          t.工本费收款额 as 工本收款额,
          t.开票费收款额 as 开票收款额,
          0 as 做账提成,
          0 as 工本费开票费提成,
          t.做账会计 as 员工,
          t.做账会计ID as 员工ID,
          t.收款日期 as 支付日期,
          t.注册费收款额,
          0 as 注册提成,
          '注册收款' as 收款类别,
          t.月平均费,
          t.年做账费,
          '做账会计注册' as 工资统计类型
            ,t.上次到期月
            ,t.做账到期月
           from VW_PaymentDetail t, TW_Client t2
           where
           t.客户名称ID=t2.客户名称ID
           and isnull(t.零申报,0)=0
	        and  '" + pdate.ToString("yyyy-MM-dd") + @"' <= t.做账到期月
	        and t.注册费<=t.注册费收款额
			and YEAR(t.收款日期)=" + year + @" and  month(t.收款日期)=" + month + @"
           and t.做账会计ID='" + userID + @"'  ";
            DataSet dst = ServiceManager.GetDatabase().GetEntity(strSql, "VW_AllAccountantSalaryDetail");
            string lsbSql = @"
          select
            	t.TW_PaymentID,
          t.支付单位 as 客户名称,
          t.客户名称ID as 客户名称Id,
          t.支付金额 as 做账收款额,
          t.工本费 as 工本收款费,
          t.开票费 as 开票收款费,
          0 as 做账提成 ,
          0 as 工本费开票费提成,
          t.做账会计 as 员工,
          t.做账会计ID as 员工ID,
          t.支付日期 as 支付日期,
          0 as 注册费收款额,
          0 as 注册提成,
          t.收款类别,
          t.月平均费 as 月做账费,
          t.月平均费 * 12 as 年做账费,
          '业务员做账费' as 工资统计类型
            ,t.上次到期月份 as 开始时间,
		   t.本次到期月份 as 结束时间
          from TW_Payment  t,[dbo].[TW_Client] t2
          where
          t.客户名称ID = t2.客户名称ID
          and isnull(t.零申报,0)=1 
           and  '" + date.ToString("yyyy-MM-dd") + @"' <= t.本次到期月份
           and  '" + date.ToString("yyyy-MM-dd") + "' > isnull(t.上次到期月份,'1900-1-1')" + @"
           and t.收款类别 = '常规收款'
           and t.支付日期<='" + date.ToString("yyyy-MM-dd") + @"'
          and t.做账会计ID='" + userID + @"'
          and t.是否审核=1
          union
          select
            	t.TW_PaymentID,
          t.支付单位 as 客户名称,
          t.客户名称ID as 客户名称Id,
          t.支付金额 as 做账收款额,
          t.工本费 as 工本收款费,
          t.开票费 as 开票收款费,
          0 as 做账提成 ,
          0 as 工本费开票费提成,
          t.做账会计 as 员工,
          t.做账会计ID as 员工ID,
          t.支付日期 as 支付日期,
          0 as 注册费收款额,
          0 as 注册提成,
          t.收款类别,
          t.月平均费 as 月做账费,
          t.月平均费 * 12 as 年做账费,
          '业务员做账费' as 工资统计类型
            ,t.上次到期月份 as 开始时间,
		   t.本次到期月份 as 结束时间
           from TW_Payment  t,[dbo].[TW_Client] t2,[dbo].[TCOM_USER] t3
           where
           t.客户名称ID = t2.客户名称ID
           and t.做账会计ID = t3.USERID
           and t3.EMPLOYEETYPE='学徒'
           and isnull(t.零申报,0)=1
           and YEAR(t.支付日期)=" + year + @" and  month(t.支付日期)=" + month + @"
           -- and  '" + pdate.ToString("yyyy-MM-dd") + @"' <= t.本次到期月份
           and  '" + pdate.ToString("yyyy-MM-dd") + @"' > isnull(t.上次到期月份,'1900-1-1')
           and t.收款类别 = '常规收款'
           and t.做账会计ID='" + userID + @"'
           and t.是否审核=1
          union
          select
	        t.TW_PaymentID,
           t.支付单位 as 客户名称,
           t.客户名称ID as 客户名称Id,
           t.支付金额 as 做账收款额,
           t.工本费 as 工本收款费,
           t.开票费 as 开票收款费,
           0 as 做账提成 ,
           0 as 工本费开票费提成,
           t.做账会计 as 员工,
           t.做账会计ID as 员工ID,
           t.支付日期 as 支付日期,
           0 as 注册费收款额,
           0 as 注册提成,
           t.收款类别,
           t.月平均费 as 月做账费,
           t.月做账费 * 12 as 年做账费,
           '业务员做账费' as 工资统计类型
            ,t.上次到期月份 as 开始时间,
		   t.本次到期月份 as 结束时间
           from TW_Payment  t,[dbo].[TW_Client] t2
           where
           t.客户名称ID = t2.客户名称ID
           and isnull(t.零申报,0)=1
           and YEAR(t.支付日期)=" + year + @" and  month(t.支付日期)=" + month + @"
           --and  '" + pdate.ToString("yyyy-MM-dd") + @"' <= t.本次到期月份
           and  '" + pdate.ToString("yyyy-MM-dd") + @"' > isnull(t.上次到期月份,'1900-1-1')
           and t.收款类别 ='常规收款'
           and t.是否审核=1
          and t.做账会计ID='" + userID + @"'
          union
          select
            newid(),
          t.客户名称,
          t.客户名称ID,
          t.做账费收款额 as 做账收款额,
          t.工本费收款额 as 工本收款额,
          t.开票费收款额 as 开票收款额,
          0 as 做账提成,
          0 as 工本费开票费提成,
          t.做账会计 as 员工,
          t.做账会计ID as 员工ID,
          t.收款日期 as 支付日期,
          t.注册费收款额,
          0 as 注册提成,
          '注册收款' as 收款类别,
          t.月平均费 ,
          t.年做账费,
          '业务员注册费' as 工资统计类型
            ,t.上次到期月
            ,t.做账到期月
          from VW_PaymentDetail t, TW_Client t2
          where
          t.客户名称ID=t2.客户名称ID
          and isnull(t.零申报,0)=1
           and  '" + date.ToString("yyyy-MM-dd") + @"' <= t.做账到期月
          and t.注册费<=t.注册费收款额
          and t.做账会计ID='" + userID + "' " +
          @"
            union
           select
            newid(),
           t.客户名称,
           t.客户名称ID,
           t.做账费收款额 as 做账收款额,
           t.工本费收款额 as 工本收款额,
           t.开票费收款额 as 开票收款额,
           0 as 做账提成,
           0 as 工本费开票费提成,
           t.做账会计 as 员工,
           t.做账会计ID as 员工ID,
           t.收款日期 as 支付日期,
           t.注册费收款额,
           0 as 注册提成,
           '注册收款' as 收款类别,
           t.月平均费 as 月做账费 ,
           t.年做账费,
           '业务员注册费' as 工资统计类型
            ,t.上次到期月
            ,t.做账到期月
           from VW_PaymentDetail t, TW_Client t2
           where
           t.客户名称ID=t2.客户名称ID
           and isnull(t.零申报,0)=1
	       and  '" + pdate.ToString("yyyy-MM-dd") + @"' <= t.做账到期月
	        and t.注册费<=t.注册费收款额
            and t.做账会计ID='" + userID + @"'
			and YEAR(t.收款日期)=" + year + @" and  month(t.收款日期)=" + month + @"";
            //零申报
            ServiceManager.GetDatabase().FillEntity(lsbSql, dst, "VW_AllAccountantSalaryDetailZ");

            string teacherSQL = @"
            select ty.*,tu.USERNAME as 师父 from (
          select
           t.支付单位 as 客户名称,
           newid() as  客户名称ID,
           t.支付金额 as 做账收款额,
           t.工本费 as 工本收款费,
           t.开票费 as 开票收款费,

           t.做账会计 as 员工,
           t.做账会计ID as 员工ID,
           t.支付日期,

           t.收款类别,
           t.月平均费 as 月做账费,
           t.月做账费 * 12 as 年做账费,
           '业务员做账费' as 工资统计类型,
           t3.TeacherID as 师父ID
           ,t.上次到期月份 as 开始时间,
		   t.本次到期月份 as 结束时间
           from TW_Payment  t,[dbo].[TW_Client] t2,[dbo].[TCOM_USER] t3
           where
           t.客户名称ID = t2.客户名称ID
           and t.做账会计ID = t3.USERID
           and t3.EMPLOYEETYPE='学徒'
           and isnull(t.零申报,0)=0
            and  '" + date.ToString("yyyy-MM-dd") + @"' <= t.本次到期月份
           and  '" + date.ToString("yyyy-MM-dd") + "' > isnull(t.上次到期月份,'1900-1-1')" + @"
           and t.支付日期<='" + date.ToString("yyyy-MM-dd") + @"'
           and t.收款类别 = '常规收款'
           and t3.TeacherID='" + userID + @"'
            and t.是否审核=1
           union
           select
           t.支付单位 as 客户名称,
           newid() as  客户名称ID,
           t.支付金额 as 做账收款额,
           t.工本费 as 工本收款费,
           t.开票费 as 开票收款费,
           t.做账会计 as 员工,
           t.做账会计ID as 员工ID,
           t.支付日期,
           t.收款类别,
           t.支付金额 as 月做账费,
           t.月做账费 * 12 as 年做账费,
           '业务员做账费' as 工资统计类型,
           t3.TeacherID as 师父ID
          ,t.上次到期月份 as 开始时间,
		   t.本次到期月份 as 结束时间
           from TW_Payment  t,[dbo].[TW_Client] t2,[dbo].[TCOM_USER] t3
           where
           t.客户名称ID = t2.客户名称ID
           and t.做账会计ID = t3.USERID
           and t3.EMPLOYEETYPE='学徒'
           and isnull(t.零申报,0)=0
           and YEAR(t.支付日期)=" + year + @" and  month(t.支付日期)=" + month + @"
           and  '" + pdate.ToString("yyyy-MM-dd") + @"' >= t.本次到期月份
           and  '" + pdate.ToString("yyyy-MM-dd") + @"' > isnull(t.上次到期月份,'1900-1-1')
           and t.支付日期<='" + date.ToString("yyyy-MM-dd") + @"'
           and t.收款类别 = '常规收款'
           and t3.TeacherID='" + userID + @"'
           and t.是否审核=1
           union
           select
           t.客户名称,
           t.客户名称ID,
           t.做账费收款额 as 做账收款额,
           t.工本费收款额 as 工本收款额,
           t.开票费收款额 as 开票收款额,
           t.做账会计 as 员工,
           t.做账会计ID as 员工ID,
           t.收款日期 as 支付日期,
           '注册收款' as 收款类别,
           t.月平均费 ,
           t.年做账费,
           '做账会计注册' as 工资统计类型
		   ,t3.TeacherID as 师父ID
            ,t.上次到期月
            ,t.做账到期月
           from VW_PaymentDetail t, TW_Client t2,TCOM_USER t3
           where
           t.客户名称ID=t2.客户名称ID
           and t.做账会计ID = t3.USERID
           and t3.EMPLOYEETYPE='学徒'
           and isnull(t.零申报,0)=0
	        and  '" + date.ToString("yyyy-MM-dd") + @"' <= t.做账到期月
           and t.注册费<=t.注册费收款额
           and t3.TeacherID='" + userID + @"'
           union
           select
           t.客户名称,
           t.客户名称ID,
           t.做账费收款额 as 做账收款额,
           t.工本费收款额 as 工本收款额,
           t.开票费收款额 as 开票收款额,
           t.做账会计 as 员工,
           t.做账会计ID as 员工ID,
           t.收款日期 as 支付日期,
           '注册收款' as 收款类别,
           t.月平均费 ,
           t.年做账费,
           '做账会计注册' as 工资统计类型
		   ,t3.TeacherID as 师父ID
            ,t.上次到期月
            ,t.做账到期月
           from VW_PaymentDetail t, TW_Client t2,TCOM_USER t3
           where
           t.客户名称ID=t2.客户名称ID
           and t.做账会计ID = t3.USERID
           and t3.EMPLOYEETYPE='学徒'
           and isnull(t.零申报,0)=0
           and  '" + pdate.ToString("yyyy-MM-dd") + @"' <= t.做账到期月
	       and t.注册费<=t.注册费收款额
		   and YEAR(t.收款日期)=" + year + @" and  month(t.收款日期)=" + month + @"
           and t3.TeacherID='" + userID + @"'
           ) as ty,TCOM_USER tu
		  where ty.员工ID = tu.USERID
            and tu.TeacherID='" + userID + "'  ";

            //徒弟提成
            ServiceManager.GetDatabase().FillEntity(teacherSQL, dst, "VW_AllAccountantSalaryTeacher");

            //实习工资
            string userSalary = @"select tc.USERID,tc.USERNAME,tc.Salary,tc.EMPLOYEETYPE,tc.WorkType,tu.USERNAME as teacherName ,tc.TeacherID from TCOM_USER tc,
            TCOM_USER tu
            where tc.TeacherID = tu.USERID and tc.TeacherID='" + userID + "' and tc.EMPLOYEETYPE='实习' ";
            ServiceManager.GetDatabase().FillEntity(userSalary, dst, "VW_AllAccountantSalaryUser");

            return dst;
        }

        /// <summary>
        /// 获取做账月明细
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="userID"></param>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetAccountantDetail(int year, int month, string deptid)
        {
            DateTime date = new DateTime(year, month, DateTime.DaysInMonth(year, month));
            DateTime pdate = date.AddMonths(-1);//减少一个月
            pdate = new DateTime(pdate.Year, pdate.Month, DateTime.DaysInMonth(pdate.Year, pdate.Month));
            string strSql = "";
            if (!string.IsNullOrEmpty(deptid))
            {
                strSql = @" select
          t.TW_PaymentID,
          t.支付单位 as 客户名称,
          t.客户名称ID as 客户名称Id,
          t.支付金额 as 做账收款额,
          t.工本费 as 工本收款费,
          t.开票费 as 开票收款费,
          0 as 做账提成,
          0 as 工本费开票费提成,
          t.做账会计 as 员工,
          t.做账会计ID as 员工ID,
          t.支付日期 as 支付日期,
          0 as 注册费收款额,
          0 as 注册提成,
          t.收款类别,
          t.月平均费,
          t.月平均费 * 12 as 年做账费,
          '做账会计常规' as 工资统计类型
          ,tu.TeacherID
            ,tu.DEPTID
          from TW_Payment t,[dbo].[TW_Client] t2,
          TCOM_USER tu
          where
          t.客户名称ID = t2.客户名称ID
          and t.做账会计ID=tu.USERID
          and isnull(t.零申报,0) = 0
          and  '" + date.ToString("yyyy-MM-dd") + @"' <= t.本次到期月份
          and  '" + date.ToString("yyyy-MM-dd") + "' > isnull(t.上次到期月份,'1900-1-1')" + @"
          and t.收款类别 = '常规收款'
          and t.是否审核=1 
          and tu.deptid ='" + deptid + @"'
          union
          select
	      t.TW_PaymentID,
          t.支付单位 as 客户名称,
          t.客户名称ID as 客户名称Id,
          t.支付金额 as 做账收款额,
          t.工本费 as 工本收款费,
          t.开票费 as 开票收款费,
          0 as 做账提成,
          0 as 工本费开票费提成,
          t.做账会计 as 员工,
          t.做账会计ID as 员工ID,
          t.支付日期 as 支付日期,
          0 as 注册费收款额,
          0 as 注册提成,
          t.收款类别,
          t.支付金额 as 月平均费,
          t.月平均费 * 12 as 年做账费,
          '做账会计常规' as 工资统计类型
          ,tu.TeacherID
         ,tu.DEPTID
          from TW_Payment t,[dbo].[TW_Client] t2,
          TCOM_USER tu
          where
          t.客户名称ID = t2.客户名称ID
          and t.做账会计ID=tu.USERID
          and isnull(t.零申报,0) = 0
          and YEAR(t.支付日期)=" + year + @" and  month(t.支付日期)=" + month + @"
          and  '" + pdate.ToString("yyyy-MM-dd") + @"' >=isnull(t.本次到期月份,'1900-1-1')
          and  '" + pdate.ToString("yyyy-MM-dd") + @"' > isnull(t.上次到期月份,'1900-1-1')
          and t.收款类别 = '常规收款'
          and t.是否审核=1
          and tu.deptid ='" + deptid + @"'
          union
          select
          newid(),
          t.客户名称,
          t.客户名称ID,
          t.做账费收款额 as 做账收款额,
          t.工本费收款额 as 工本收款额,
          t.开票费收款额 as 开票收款额,
          0 as 做账提成,
          0 as 工本费开票费提成,
          t.做账会计 as 员工,
          t.做账会计ID as 员工ID,
          t.收款日期 as 支付日期,
          t.注册费收款额,
          0 as 注册提成,
          '注册收款' as 收款类别,
          t.月平均费,
          t.年做账费,
          '做账会计注册' as 工资统计类型
          ,tu.TeacherID
              ,tu.DEPTID
          from VW_PaymentDetail t, TW_Client t2,TCOM_USER tu
          where
          t.客户名称ID = t2.客户名称ID
          and t.做账会计ID=tu.USERID
          and isnull(t.零申报,0) = 0
           and  '" + date.ToString("yyyy-MM-dd") + @"' <= t.做账到期月
          and t.注册费 <= t.注册费收款额
            and tu.deptid ='" + deptid + @"'
          union
            select
            newid(),
          t.客户名称,
          t.客户名称ID,
          t.做账费收款额 as 做账收款额,
          t.工本费收款额 as 工本收款额,
          t.开票费收款额 as 开票收款额,
          0 as 做账提成,
          0 as 工本费开票费提成,
          t.做账会计 as 员工,
          t.做账会计ID as 员工ID,
          t.收款日期 as 支付日期,
          t.注册费收款额,
          0 as 注册提成,
          '注册收款' as 收款类别,
          t.月平均费,
          t.年做账费,
          '做账会计注册' as 工资统计类型
          ,tu.TeacherID
              ,tu.DEPTID
          from VW_PaymentDetail t, TW_Client t2,TCOM_USER tu
          where
          t.客户名称ID = t2.客户名称ID
          and t.做账会计ID=tu.USERID
          and isnull(t.零申报,0) = 0
           and tu.deptid ='" + deptid + @"'
           and  '" + pdate.ToString("yyyy-MM-dd") + @"' <= t.做账到期月
	       and t.注册费<=t.注册费收款额
		   and YEAR(t.收款日期)=" + year + @" and  month(t.收款日期)=" + month + "";
            }
            else
            {
                strSql = @" select
	        t.TW_PaymentID,
          t.支付单位 as 客户名称,
          t.客户名称ID as 客户名称Id,
          t.支付金额 as 做账收款额,
          t.工本费 as 工本收款费,
          t.开票费 as 开票收款费,
          0 as 做账提成,
          0 as 工本费开票费提成,
          t.做账会计 as 员工,
          t.做账会计ID as 员工ID,
          t.支付日期 as 支付日期,
          0 as 注册费收款额,
          0 as 注册提成,
          t.收款类别,
          t.月平均费,
          t.月平均费 * 12 as 年做账费,
          '做账会计常规' as 工资统计类型
          ,tu.TeacherID
            ,tu.DEPTID
          from TW_Payment t,[dbo].[TW_Client] t2,
          TCOM_USER tu
          where
          t.客户名称ID = t2.客户名称ID
          and t.做账会计ID=tu.USERID
          and isnull(t.零申报,0) = 0
          and  '" + date.ToString("yyyy-MM-dd") + @"' <= t.本次到期月份
          and  '" + date.ToString("yyyy-MM-dd") + "' > isnull(t.上次到期月份,'1900-1-1')" + @"
          and t.收款类别 = '常规收款'
          and t.是否审核=1 
          union
          select
        	t.TW_PaymentID,
          t.支付单位 as 客户名称,
          t.客户名称ID as 客户名称Id,
          t.支付金额 as 做账收款额,
          t.工本费 as 工本收款费,
          t.开票费 as 开票收款费,
          0 as 做账提成,
          0 as 工本费开票费提成,
          t.做账会计 as 员工,
          t.做账会计ID as 员工ID,
          t.支付日期 as 支付日期,
          0 as 注册费收款额,
          0 as 注册提成,
          t.收款类别,
          t.支付金额 as 月平均费,
          t.月平均费 * 12 as 年做账费,
          '做账会计常规' as 工资统计类型
          ,tu.TeacherID
         ,tu.DEPTID
          from TW_Payment t,[dbo].[TW_Client] t2,
          TCOM_USER tu
          where
          t.客户名称ID = t2.客户名称ID
          and t.做账会计ID=tu.USERID
          and isnull(t.零申报,0) = 0
          and YEAR(t.支付日期)=" + year + @" and  month(t.支付日期)=" + month + @"
          and  '" + pdate.ToString("yyyy-MM-dd") + @"' >=isnull(t.本次到期月份,'1900-1-1')
          and  '" + pdate.ToString("yyyy-MM-dd") + @"' > isnull(t.上次到期月份,'1900-1-1')
          and t.收款类别 = '常规收款'
          and t.是否审核=1
          union
          select
            newid(),
          t.客户名称,
          t.客户名称ID,
          t.做账费收款额 as 做账收款额,
          t.工本费收款额 as 工本收款额,
          t.开票费收款额 as 开票收款额,
          0 as 做账提成,
          0 as 工本费开票费提成,
          t.做账会计 as 员工,
          t.做账会计ID as 员工ID,
          t.收款日期 as 支付日期,
          t.注册费收款额,
          0 as 注册提成,
          '注册收款' as 收款类别,
          t.月平均费,
          t.年做账费,
          '做账会计注册' as 工资统计类型
          ,tu.TeacherID
              ,tu.DEPTID
          from VW_PaymentDetail t, TW_Client t2,TCOM_USER tu
          where
          t.客户名称ID = t2.客户名称ID
          and t.做账会计ID=tu.USERID
          and isnull(t.零申报,0) = 0
           and  '" + date.ToString("yyyy-MM-dd") + @"' <= t.做账到期月
          and t.注册费 <= t.注册费收款额
          union
            select
            newid(),
          t.客户名称,
          t.客户名称ID,
          t.做账费收款额 as 做账收款额,
          t.工本费收款额 as 工本收款额,
          t.开票费收款额 as 开票收款额,
          0 as 做账提成,
          0 as 工本费开票费提成,
          t.做账会计 as 员工,
          t.做账会计ID as 员工ID,
          t.收款日期 as 支付日期,
          t.注册费收款额,
          0 as 注册提成,
          '注册收款' as 收款类别,
          t.月平均费,
          t.年做账费,
          '做账会计注册' as 工资统计类型
          ,tu.TeacherID
              ,tu.DEPTID
          from VW_PaymentDetail t, TW_Client t2,TCOM_USER tu
          where
          t.客户名称ID = t2.客户名称ID
          and t.做账会计ID=tu.USERID
          and isnull(t.零申报,0) = 0
           and  '" + pdate.ToString("yyyy-MM-dd") + @"' <= t.做账到期月
	       and t.注册费<=t.注册费收款额
		   and YEAR(t.收款日期)=" + year + @" and  month(t.收款日期)=" + month + "";
            }
            DataSet dst = ServiceManager.GetDatabase().GetEntity(strSql, "VW_AllAccountantSalaryDetail");
            return dst;
        }

        /// <summary>
        /// 获取零申报做账月明细
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="userID"></param>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetLSBAccountantDetail(int year, int month)
        {
            DateTime date = new DateTime(year, month, DateTime.DaysInMonth(year, month));

            string strSql = @" select
        	t.TW_PaymentID,
          t.支付单位 as 客户名称,
          t.客户名称ID as 客户名称Id,
          t.支付金额 as 做账收款额,
          t.工本费 as 工本收款费,
          t.开票费 as 开票收款费,
          0 as 做账提成,
          0 as 工本费开票费提成,
          t.做账会计 as 员工,
          t.做账会计ID as 员工ID,
          t.支付日期 as 支付日期,
          0 as 注册费收款额,
          0 as 注册提成,
          t.收款类别,
          t.月平均费,
          t.月平均费 * 12 as 年做账费,
          '做账会计常规' as 工资统计类型
          ,tu.TeacherID
          from TW_Payment t,[dbo].[TW_Client] t2,
          TCOM_USER tu
          where
          t.客户名称ID = t2.客户名称ID
          and t.做账会计ID=tu.USERID
          and isnull(t.零申报,0) = 1
          and  '" + date.ToString("yyyy-MM-dd") + @"' <= t.本次到期月份
          and  '" + date.ToString("yyyy-MM-dd") + "' > isnull(t.上次到期月份,'1900-1-1')" + @"
          and t.收款类别 = '常规收款'
          and t.是否审核=1
          union
          select
          newid(),
          t.客户名称,
          t.客户名称ID,
          t.做账费收款额 as 做账收款额,
          t.工本费收款额 as 工本收款额,
          t.开票费收款额 as 开票收款额,
          0 as 做账提成,
          0 as 工本费开票费提成,
          t.做账会计 as 员工,
          t.做账会计ID as 员工ID,
          t.收款日期 as 支付日期,
          t.注册费收款额,
          0 as 注册提成,
          '注册收款' as 收款类别,
          t.月平均费,
          t.年做账费,
          '做账会计注册' as 工资统计类型
          ,tu.TeacherID
          from VW_PaymentDetail t, TW_Client t2,TCOM_USER tu
          where
          t.客户名称ID = t2.客户名称ID
          and t.做账会计ID=tu.USERID
          and isnull(t.零申报,0) = 1
           and  '" + date.ToString("yyyy-MM-dd") + @"' <= t.做账到期月
          and t.注册费 <= t.注册费收款额";
            DataSet dst = ServiceManager.GetDatabase().GetEntity(strSql, "VW_AllAccountantSalaryDetail");
            return dst;
        }

        #endregion 做账业绩统计

        /// <summary>
        /// 更新业务员信息
        /// </summary>
        [WebMethod]
        public void UpdateYWY()
        {
            try
            {
                var db = ServiceManager.GetDatabase();
                string strSql = @"update [TW_Client]
set 业务员ID=(select [USERID] from TCOM_User where USERNAME= TW_Client.业务员 )
where isnull(业务员,'')<>'' and 业务员ID is null";
                db.ExecuteNonQuery(strSql);
                strSql = @"update [dbo].[TW_Payment]
set[TW_Payment].业务员 = (select 业务员 from[TW_Client] where 客户名称 = TW_Payment.支付单位)
where isnull(业务员,'')= ''";
                db.ExecuteNonQuery(strSql);
                strSql = @"update [TW_Payment]
set 业务员ID=(select [USERID] from TCOM_User where USERNAME= [TW_Payment].业务员 )
where isnull(业务员,'')<>'' and 业务员ID is null";
                db.ExecuteNonQuery(strSql);
                strSql = @"update [TW_Client]
set 首年提成结束期 = DATEADD(mm, 12, 初始做账时间)
where 首年提成结束期 is null and 初始做账时间 is not null";
                db.ExecuteNonQuery(strSql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 同步客户信息
        /// </summary>
        [WebMethod]
        public void UpdateClient()
        {
            var db = ServiceManager.GetDatabase();
            try
            {

                string strSql = @" update[TW_Client] set 客户名称 = TRIM(客户名称)";
                db.ExecuteNonQuery(strSql);

                strSql = @"update [TW_BusinessReg] set 公司预核名称=trim(公司预核名称)";
                db.ExecuteNonQuery(strSql);



                string updateSQL = @"insert Into  [TW_Client] ([客户名称ID],[客户名称],[业务员],[业务员ID],[注册员],[注册员ID],[做账会计],[做账会计ID],[收费标准],[公司类型],[零申报],自动通过)
	    select NEWID(),a.公司预核名称,a.业务员,a.业务员ID,a.注册员,a.注册员ID,a.做账会计,a.做账会计ID,a.月做账费,a.公司类型,a.零申报,0
	     from [dbo].[TW_BusinessReg] a
        left join [TW_Client] b
        on a.公司预核名称 = b.客户名称
        where
         b.客户名称  is null
         and ( a.注册类型='注册' or a.注册类型='做账' or a.注册类型='设立' )";
                db.ExecuteNonQuery(updateSQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        /// <summary>
        /// 单次交接
        /// </summary>
        /// <param name="kuaiji">会计</param>
        /// <param name="kuaijiId">会计Id</param>
        /// <param name="JJDate">交接起始月</param>
        /// <param name="clientName">客户名称</param>
        [WebMethod]
        public void JiaoJieOnce(string kuaiji, string kuaijiId, string JJDate, string clientName)
        {
            string strSql = @"update [TW_Payment]
                                set 做账会计='{0}',
                                做账会计ID='{1}'
                                where 支付单位='{2}'
                                and 上次到期月份>='{3}'";
            strSql = String.Format(strSql, kuaiji, kuaijiId, clientName, JJDate);
            var db = ServiceManager.GetDatabase();
            db.ExecuteNonQuery(strSql);

            strSql = @"update [TW_Client]
                        set 做账会计 = '{0}',
                        做账会计ID = '{1}'
                        where 客户名称 = '{2}'";
            strSql = string.Format(strSql, kuaiji, kuaijiId, clientName);
            db.ExecuteNonQuery(strSql);

        }


        /// <summary>
        /// 按照会计批量交接
        /// </summary>
        /// <param name="kuaiji">会计</param>
        /// <param name="kuaijiId">会计Id</param>
        /// <param name="JJDate">交接起始月</param>
        /// <param name="clientName">客户名称</param>
        [WebMethod]
        public void JiaoJieByKuaiji(string kuaiji, string kuaijiId, string JJDate, string oldKuaijiId)
        {
            string strSql = @"update [TW_Payment]
                                set 做账会计='{0}',
                                做账会计ID='{1}'
                                where 做账会计ID='{2}'
                                and 上次到期月份>='{3}'";
            strSql = String.Format(strSql, kuaiji, kuaijiId, oldKuaijiId, JJDate);
            var db = ServiceManager.GetDatabase();
            db.ExecuteNonQuery(strSql);

            strSql = @"update [TW_Client]
                        set 做账会计 = '{0}',
                        做账会计ID = '{1}'
                        where 做账会计ID = '{2}'";
            strSql = string.Format(strSql, kuaiji, kuaijiId, oldKuaijiId);
            db.ExecuteNonQuery(strSql);

        }

        /// <summary>
        /// 获取待拆分数据集
        /// </summary>
        /// <param name="beginDate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetCFDataSet(string beginDate, string endDate)
        {
            string strSql = string.Format(@"select * from [dbo].[TW_Payment]
                                where 缴费月数> 1 and 收款类别 = '常规收款'
                                and 支付日期>= '{0}' and 支付日期<= '{1}'", beginDate, endDate);

            var db = ServiceManager.GetDatabase();
            DataSet dst = db.GetEntity(strSql, "strSql");
            return dst;
        }
        /// <summary>
        /// 获取提成设置
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetCommission()
        {
            string strSql = "select * from TWS_Commission";
            var db = ServiceManager.GetDatabase();
            DataSet dst = db.GetEntity(strSql, "TWS_Commission");
            return dst;
        }
        /// <summary>
        /// 根据ID查询三个人
        /// </summary>
        /// <param name="zcyId">注册员ID</param>
        /// <param name="ywyId">业务员ID</param>
        /// <param name="zzkjId">做账会计ID</param>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetUserBy3(string zcyId, string ywyId, string zzkjId)
        {
            string strSql = @"select DEPTNAME ,USERID,USERNAME ,WorkType from TCOM_USER
                                where USERID = '{0}' or USERID = '{1}' or USERID = '{2}'";
            strSql = string.Format(strSql, zcyId, ywyId, zzkjId);
            var db = ServiceManager.GetDatabase();
            DataSet dst = db.GetEntity(strSql, "TCOM_USER");
            return dst;
        }
        /// <summary>
        /// 更新费用到期时间
        /// </summary>
        /// <param name="payEndDate"></param>
        /// <param name="clientId"></param>
        [WebMethod]
        public void UpdateClientPaymentDate(string payEndDate, string clientId)
        {
            string strSql = string.Format(" update TW_Client set 费用到期月份='{0}' where 客户名称ID ='{1}'", DateTime.Parse(payEndDate).ToString("yyyy-MM-dd"), clientId);
            var db = ServiceManager.GetDatabase();
            db.ExecuteNonQuery(strSql);
        }

        /// <summary>
        /// 按照客户统计全年利润
        /// </summary>
        /// <param name="zzKSDate">做账开始时间</param>
        /// <param name="zzDQDate">做账到期时间</param>
        /// <param name="zfKSData">支付开始时间</param>
        /// <param name="zfJSData">支付到期时间</param>
        /// <param name="clientName"></param>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetClientFX(string zzKSDate, string zzDQDate, string zfKSData, string zfJSData, string clientName)
        {
            string strSql = @"select 
	t1.支付单位
,sum(t1.收款金额) as 收款金额
      ,sum(t1.[工本费]) as [工本费]
      ,sum(t1.[开票费]) as [开票费]
      ,min(t1.上次到期月份) as [上次到期月份]
      ,max(t1.[本次到期月份]) as [本次到期月份]
      ,sum(t1.注册员提成) as 注册员提成
      ,sum(t1.业务员提成) as 业务员提成
      ,sum(t1.做账提成) as 做账提成
      ,sum(t1.做账部经理提成) as 做账部经理提成
      ,sum(t1.业务主管团队提成) as 业务主管团队提成
      ,sum(t1.做账主管团队提成) as 做账主管团队提成
      ,sum(t1.注册主管提成) as 注册主管提成
      ,sum(t1.注册员做账费提成) as 注册员做账费提成
     -- ,sum([业务年提成]) as [业务年提成]
      ,sum(t1.累计工本开票提成) as 累计工本开票提成
      ,sum(t1.做账部经理业务团队提成) as 做账部经理业务团队提成
from 
(SELECT
      [支付单位]
      ,sum([支付金额]) as 收款金额
      ,sum([工本费]) as [工本费]
      ,sum([开票费]) as [开票费]
      ,min(isnull([上次到期月份],'1900-1-1')) as [上次到期月份]
      ,max(isnull([本次到期月份],'1900-1-1')) as [本次到期月份]
      ,sum([注册提成月]) as 注册员提成
      ,sum([业务提成月]) as 业务员提成
      ,sum([做账提成月]) as 做账提成
      ,sum([做账团队提成]) as 做账部经理提成
      ,sum([业务团队提成]) as 业务主管团队提成
      ,sum([做账主管提成]) as 做账主管团队提成
      ,sum([注册团队提成]) as 注册主管提成
      ,sum([注册年提成]) as 注册员做账费提成
     -- ,sum([业务年提成]) as [业务年提成]
      ,sum([工本开票提成]) as 累计工本开票提成
      ,sum([做账业务团队提成]) as 做账部经理业务团队提成
  FROM [dbo].[TW_Payment]
  where {0}
  group by 支付单位
  union
  SELECT
      [支付单位]
      ,sum([支付金额]) as 收款金额
      ,sum([工本费]) as [工本费]
      ,sum([开票费]) as [开票费]
      ,min(isnull([上次到期月份],'1900-1-1')) as [上次到期月份]
      ,max(isnull([本次到期月份],'1900-1-1')) as [本次到期月份]
      ,sum([注册提成月]) as 注册员提成
      ,sum([业务提成月]) as 业务员提成
      ,sum([做账提成月]) as 做账提成
      ,sum([做账团队提成]) as 做账部经理提成
      ,sum([业务团队提成]) as 业务主管团队提成
      ,sum([做账主管提成]) as 做账主管团队提成
      ,sum([注册团队提成]) as 注册主管提成
      ,sum([注册年提成]) as 注册员做账费提成
     -- ,sum([业务年提成]) as [业务年提成]
      ,sum([工本开票提成]) as 累计工本开票提成
      ,sum([做账业务团队提成]) as 做账部经理业务团队提成
  FROM [dbo].[TW_Payment]
  where ( [本次到期月份] is null   and [本次到期月份] is null )
    {1} group by 支付单位 ) t1
  group by t1.支付单位";

            string strSql2 = " 1=1 ";
            string strSql3 = " ";
            if (!string.IsNullOrEmpty(zzKSDate) && !string.IsNullOrEmpty(zzDQDate))
            {
                strSql2 += " and (本次到期月份>'" + zzKSDate + "' and 本次到期月份<='" + zzDQDate + "' )";
                strSql3 += " and  ( 支付日期>'" + zzKSDate + "' and 支付日期<='" + zzDQDate + "' )";
            }
            if (!string.IsNullOrEmpty(zfKSData) && !string.IsNullOrEmpty(zfJSData))
            {
                strSql2 += " and  ( 支付日期>'" + zfKSData + "' and 支付日期<='" + zfJSData + "' )";
                strSql3 += " and  ( 支付日期>'" + zfKSData + "' and 支付日期<='" + zfJSData + "' )";
            }

            if (!string.IsNullOrEmpty(clientName))
            {
                strSql2 += " and 支付单位 like '%clientName%'";
                strSql3 += " and 支付单位 like '%clientName%'";
            }
            strSql = string.Format(strSql, strSql2, strSql3);
            var db = ServiceManager.GetDatabase();
            DataSet dst = db.GetEntity(strSql, "VW_ClientFX");
            return dst;
        }

        /// <summary>
        /// 按照年月分析全年利润情况
        /// </summary>
        /// <param name="beginDate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetLRByDate(string beginDate, string endDate)
        {
            string strSql = @"select t1.月份
            ,sum(t1.总收款额) as 总收款额 
                 ,sum(t1.[工本费]) as [工本费]
                  ,sum(t1.[开票费]) as [开票费]
                  ,sum(做账提成) as 做账提成
                  ,sum(做账部经理提成) as 做账部经理提成
                  ,sum(做账主管团队提成) as 做账主管团队提成
	              ,sum(累计工本开票提成) as 累计工本开票提成
                  ,sum(做账部经理业务团队提成) as 做账部经理业务团队提成
	              ,sum(注册员提成) as 注册员提成
	              ,sum(注册主管提成) as 注册主管提成
                  ,sum(注册员做账费提成) as 注册员做账费提成
                  ,sum(业务员提成) as 业务员提成
                  ,sum(业务主管团队提成) as 业务主管团队提成
            from (
            select 
            DATEPART(mm,上次到期月份) as 月份
	             ,sum(t1.支付金额) as 总收款额 
                 ,sum(t1.[工本费]) as [工本费]
                  ,sum(t1.[开票费]) as [开票费]
                  ,sum([做账提成月]) as 做账提成
                  ,sum([做账团队提成]) as 做账部经理提成
                  ,sum([做账主管提成]) as 做账主管团队提成
	              ,sum([工本开票提成]) as 累计工本开票提成
                  ,sum([做账业务团队提成]) as 做账部经理业务团队提成
	              ,sum([注册提成月]) as 注册员提成
	              ,sum([注册团队提成]) as 注册主管提成
                  ,sum([注册年提成]) as 注册员做账费提成
                  ,sum([业务提成月]) as 业务员提成
                  ,sum([业务团队提成]) as 业务主管团队提成
            from [dbo].[TW_Payment] t1
            where 收款类别 ='常规收款' and [本次到期月份]>='" + beginDate + "' and [本次到期月份]<='" + endDate + @"'
            group by DATEPART(mm,上次到期月份) 
            union 
            select 
            DATEPART(mm,支付日期) as 月份
	             ,sum(t1.支付金额) as 总收款额 
                 ,sum(t1.[工本费]) as [工本费]
                  ,sum(t1.[开票费]) as [开票费]
                  ,sum([做账提成月]) as 做账提成
                  ,sum([做账团队提成]) as 做账部经理提成
                  ,sum([做账主管提成]) as 做账主管团队提成
	              ,sum([工本开票提成]) as 累计工本开票提成
                  ,sum([做账业务团队提成]) as 做账部经理业务团队提成
	              ,sum([注册提成月]) as 注册员提成
	              ,sum([注册团队提成]) as 注册主管提成
                  ,sum([注册年提成]) as 注册员做账费提成
                  ,sum([业务提成月]) as 业务员提成
                  ,sum([业务团队提成]) as 业务主管团队提成
            from [dbo].[TW_Payment] t1
            where 收款类别 !='常规收款' and 支付日期>='" + beginDate + "' and 支付日期<='" + endDate + @"'
            group by DATEPART(mm,支付日期) ) t1
            group by 月份 ";
            var db = ServiceManager.GetDatabase();
            DataSet dst = db.GetEntity(strSql, "VW_月份统计表");
            return dst;

        }

        /// <summary>
        /// 查询到截止日的应收款和牵收款，以及每家公司的预收款
        /// </summary>
        /// <param name="beginDate">开始时间</param>
        /// <param name="endDate">截止时间</param>
        /// <param name="clientName">客户名称</param>
        /// <param name="kuaiji">会计</param>
        /// <param name="yewuyuan">业务员</param>
        /// <param name="zhuceyuan">注册员</param>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetYingShou(string beginDate, string endDate, string clientName, string userid)
        {
            string deptid = "";
            string sqlUser = "select DEPTID,DEPTNAME,WorkType from TCOM_USER where USERID='" + userid + "' ";

            DataSet dstuser = ServiceManager.GetDatabase().GetEntity(sqlUser, "TCOM_USER");
            if (dstuser.Tables["TCOM_USER"].Rows.Count > 0)
            {
                DataRow row = dstuser.Tables["TCOM_USER"].Rows[0];
                string worktype = row["WorkType"].ToString();
                if (worktype == "二级部门经理" || worktype == "业务主管" || worktype == "注册主管")
                {
                    deptid = row["DEPTID"].ToString();
                }
            }

            string strSql = @"select 客户名称,tp.收款金额 as 已收款金额,月收费标准,初始做账时间,费用到期月份,欠费月数,欠费月数*月收费标准 as 欠费金额,到期欠缴月数 as 预期应收月数,到期欠缴月数* 月收费标准 预期应收 ,预交月数,预交月数*月收费标准 as 预交金额 
            ,联系电话,客户姓名,业务员,做账会计,注册员,公司地址,业务员ID,注册员ID,做账会计ID,td1.DEPTID as 做账部门ID,td1.DEPTNAME as 做账部门
            ,td2.DEPTID as 业务部门ID,td2.DEPTNAME as 业务部门,td3.DEPTID as 注册部门ID,td3.DEPTNAME as 注册部门
            from [dbo].[TW_Client] tc
            join (
            select 
            t1.客户名称ID,
	            t1.支付单位
            ,sum(t1.收款金额) as 收款金额
                  ,sum(t1.[工本费]) as [工本费]
                  ,sum(t1.[开票费]) as [开票费]
                  ,min(t1.上次到期月份) as [上次到期月份]
                  ,max(t1.[本次到期月份]) as [本次到期月份]
	              ,dbo.GetMonthCount(DATEPART(mm,GETDATE()) - DATEPART(mm,max(t1.[本次到期月份]))) as 欠费月数
	              ,DATEPART(mm,'" + endDate + @"') - DATEPART(mm,max(t1.[本次到期月份])) as 到期欠缴月数
	              ,dbo.GetMonthCount(DATEPART(mm,max(t1.[本次到期月份])) -DATEPART(mm,GETDATE())) as 预交月数
            from 
            (SELECT
	            客户名称ID,
                  [支付单位]
                  ,sum([支付金额]) as 收款金额
                  ,sum([工本费]) as [工本费]
                  ,sum([开票费]) as [开票费]
                  ,min(isnull([上次到期月份],'1900-1-1')) as [上次到期月份]
                  ,max(isnull([本次到期月份],'1900-1-1')) as [本次到期月份]
              FROM [dbo].[TW_Payment]
              where 本次到期月份>'" + beginDate + @"' and 本次到期月份<='" + endDate + @"'
              group by 支付单位,客户名称ID
              union
              SELECT
		            客户名称ID,
                  [支付单位]
                  ,sum([支付金额]) as 收款金额
                  ,sum([工本费]) as [工本费]
                  ,sum([开票费]) as [开票费]
                  ,min(isnull([上次到期月份],'1900-1-1')) as [上次到期月份]
                  ,max(isnull([本次到期月份],'1900-1-1')) as [本次到期月份]
              FROM [dbo].[TW_Payment]
              where ( [本次到期月份] is null   and [本次到期月份] is null )
               and 支付日期>='" + beginDate + @"' and 支付日期<='" + endDate + @"' group by 支付单位,客户名称ID ) t1
              group by t1.支付单位,t1.客户名称ID
            ) tp
            on tc.客户名称ID =tp.客户名称ID
            left join [dbo].[TCOM_USER] td1
            on tc.做账会计ID = td1.USERID 
            left join [dbo].[TCOM_USER] td2
            on tc.业务员ID = td2.USERID 
            left join [dbo].[TCOM_USER] td3
            on tc.注册员ID = td3.USERID 
            where (isnull(tc.客户状态,'')=''  or tc.客户状态='正常')  ";
            if (string.IsNullOrEmpty(clientName))
            {
                strSql += " and tc.客户名称 like '%" + clientName + "%'";
            }

            if (deptid != "")
            {
                strSql += " and (td1.DEPTID = '" + deptid + "' or td2.DEPTID='" + deptid + "' or td3.DEPTID='" + deptid + "' )";
            }
            else
            {
                if (string.IsNullOrEmpty(userid))
                {
                    strSql += " and (tc.做账会计ID = '" + userid + "' or tc.业务员ID='" + userid + "' or tc.注册员ID='" + userid + "' )";
                }

            }

            var db = ServiceManager.GetDatabase();
            DataSet dst = db.GetEntity(strSql, "VM_应收款");
            return dst;
        }


        /// <summary>
        /// 获取工本费开票费
        /// </summary>
        /// <param name="year"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetGongbenKaipiao(string year, string userId, string deptName)
        {
            string strSql = string.Format("select * from VW_工本开票费提成 where 年 = '{0}'", year);
            if (!string.IsNullOrEmpty(userId))
            {
                strSql += " and 做账会计ID='" + userId + "'";
            }
            if (!string.IsNullOrEmpty(deptName))
            {
                strSql += " and DEPTNAME='" + deptName + "'";
            }
            var db = ServiceManager.GetDatabase();
            DataSet dst = db.GetEntity(strSql, "VW_工本开票费提成");
            return dst;
        }
        /// <summary>
        /// 根据客户名称获取付款信息
        /// </summary>
        /// <param name="clientName"></param>
        /// <param name="beginDate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetPaymentByClient(string clientName, string beginDate, string endDate, string zfDate1, string zfDate2)
        {
            string strSql = " select * from VW_Payment where 1=1 ";
            if (!string.IsNullOrEmpty(clientName))
            {
                strSql += string.Format(" and 支付单位='{0}' ", clientName);
            }

            if (!string.IsNullOrEmpty(beginDate) && !string.IsNullOrEmpty(endDate))
            {
                strSql += string.Format(" and ((本次到期月份 is not null and 本次到期月份>'{0}' and  本次到期月份<='{1}')", beginDate, endDate);
                strSql += string.Format(" or (本次到期月份 is null and 支付日期>='{0}' and  支付日期<='{1}'))", beginDate, endDate);
            }


            if (!string.IsNullOrEmpty(zfDate1))
            {
                strSql += string.Format(" and 支付日期>='{0}' ", zfDate1);
            }

            if (!string.IsNullOrEmpty(zfDate2))
            {
                strSql += string.Format(" and 支付日期<='{0}' ", zfDate2);
            }


            var db = ServiceManager.GetDatabase();
            DataSet dst = db.GetEntity(strSql, "TW_Payment");
            return dst;
        }

        /// <summary>
        /// 根据付款批次号查询付款记录
        /// </summary>
        /// <param name="pch"></param>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetPaymentByPch(string pch)
        {
            string strSql = string.Format("select * from [dbo].[TW_Payment] where 批次号='{0}'", pch);
            var db = ServiceManager.GetDatabase();
            DataSet dst = db.GetEntity(strSql, "TW_Payment");
            return dst;
        }
        /// <summary>
        /// 获取付款主记录
        /// </summary>
        /// <param name="id">主记录ID</param>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetPaymentMainById(string id)
        {
            string strSql = string.Format(" select * from TW_PaymentMain where [TW_PaymentID]='{0}'", id);
            var db = ServiceManager.GetDatabase();
            DataSet dst = db.GetEntity(strSql, "TW_PaymentMain");
            strSql = string.Format("select * from [dbo].[TW_Payment] where 批次号='{0}'", id);
            db.FillEntity(strSql, dst, "TW_Payment");
            return dst;
        }


        /// <summary>
        /// 获取审批的收款信息
        /// </summary>
        /// <param name="spType"></param>
        /// <param name="unitName"></param>
        /// <param name="account"></param>
        /// <param name="beginDate"></param>
        /// <param name="endDate"></param>
        /// <param name="paymentType"></param>
        /// <param name="endPaymentDate"></param>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetPaymentByInfoSP2021(string spType, string unitName, string account, string beginDate, string endDate
            , string paymentType, string endPaymentDate, string isPay, string zeroAccount, string bcdqDate1, string bcdqDate2
            , string cszzDate1, string cszzDate2)
        {
            string strSql = @" select t.*,t2.初始做账时间,t2.首年提成结束期 from TW_PaymentMain t
                            left join TW_Client t2
                            on t.客户名称ID =t2.客户名称ID where 1=1 ";
            if (!string.IsNullOrEmpty(unitName))
            {
                strSql += " and t.支付单位 like '%" + unitName + "%'";
            }
            if (!string.IsNullOrEmpty(account))
            {
                strSql += " and t.做账会计 like '%" + account + "%'";
            }
            if (!string.IsNullOrEmpty(beginDate))
            {
                strSql += " and t.支付日期>='" + beginDate + "'";
            }
            if (!string.IsNullOrEmpty(endDate))
            {
                strSql += " and t.支付日期<='" + endDate + "'";
            }
            if (!string.IsNullOrEmpty(paymentType))
            {
                strSql += " and t.收款类别 ='" + paymentType + "'";
            }
            if (!string.IsNullOrEmpty(endPaymentDate))
            {
                DateTime paymentEndDate = DateTime.Parse(endPaymentDate);
                int year = paymentEndDate.Year;
                int month = paymentEndDate.Month;
                strSql += " and Year(t.本次到期月份)=" + year.ToString() + " and Month(t.本次到期月份)=" + month;
            }
            if (spType == "未审批")
            {
                strSql += " and ( t.是否审核=0 or t.是否审核 is null )";
            }
            if (spType == "已审批")
            {
                strSql += " and t.是否审核=1 ";
            }
            if (isPay == "是")
            {
                strSql += " and t.不收款=1 ";
            }
            else if (isPay == "否")
            {
                strSql += " and ( t.不收款=0 or t.不收款 is null ) ";
            }
            if (zeroAccount == "是")
            {
                strSql += " and t.零申报=1 ";
            }
            else if (zeroAccount == "否")
            {
                strSql += " and ( t.零申报=0 or t.零申报 is null ) ";
            }

            if (!string.IsNullOrEmpty(bcdqDate1))
            {
                strSql += " and t.本次到期月份>='" + bcdqDate1 + "'";
            }

            if (!string.IsNullOrEmpty(bcdqDate2))
            {
                strSql += " and t.本次到期月份<='" + bcdqDate2 + "'";
            }
            if (!string.IsNullOrEmpty(cszzDate1))
            {
                strSql += " and t2.初始做账时间>='" + cszzDate1 + "'";
            }
            if (!string.IsNullOrEmpty(cszzDate2))
            {
                strSql += " and t2.初始做账时间<='" + cszzDate2 + "'";
            }
            DataSet dst = ServiceManager.GetDatabase().GetEntity(strSql, "TW_Payment");
            return dst;
        }

        /// <summary>
        /// 更新子审批记录
        /// </summary>
        [WebMethod]
        public void UpdatePaymentSpDate()
        {
            string strSql = @"update [TW_Payment]
                  set [TW_Payment].审核人 =[dbo].[TW_PaymentMain].审核人,
                  [TW_Payment].审核时间=[dbo].[TW_PaymentMain].审核时间,
                  [TW_Payment].是否审核=[dbo].[TW_PaymentMain].是否审核
                from
                [TW_Payment], [TW_PaymentMain]
                  where [TW_Payment].批次号=[TW_PaymentMain].[TW_PaymentID]
                 and [TW_PaymentMain].审核时间>= CONVERT(varchar(10) ,getdate(), 120) ";

            ServiceManager.GetDatabase().ExecuteNonQuery(strSql);
        }

        /// <summary>
        /// 更新主记录值
        /// </summary>
        /// <param name="pch"></param>
        [WebMethod]
        public void UpdatePaymentMain(string pch)
        {
            string strSql = string.Format(@"update
                    [dbo].[TW_PaymentMain]
                    set 支付金额=t2.支付金额,
                    开票费=t2.开票费,
                    工本费=t2.工本费,
                    本次到期月份 =t2.本次到期月份,
                    上次到期月份=t2.上次到期月份
                    from [TW_PaymentMain] t1,(
                    select  批次号, sum(支付金额) 支付金额,SUM(开票费) 开票费,sum(工本费) 工本费,
                    max([本次到期月份]) [本次到期月份],min([上次到期月份]) [上次到期月份] from [TW_Payment]
                    where 批次号='{0}' group by 批次号) t2
                    where t1.TW_PaymentID = t2.批次号 and t1.TW_PaymentID='{1}'", pch, pch);
            ServiceManager.GetDatabase().ExecuteNonQuery(strSql);
        }

    }
}