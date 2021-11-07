using Tiger.Tools;
using System.Data;
using System;
using System.Collections;

namespace WangDaDll.Common
{


    partial class ProceedsDataSet
    {
        partial class TW_PaymentDataTable
        {
        }

        public SysTools DBHelper = new SysTools();

        /// <summary>
        /// 查询用户信息
        /// </summary>
        /// <param name="zcyId">注册员ID</param>
        /// <param name="ywyId">业务员ID</param>
        /// <param name="zzkjId">做账会计ID</param>
        public void GetUsers(string zcyId, string ywyId, string zzkjId)
        {
            DataSet dst = DBHelper.WangDaSer.GetUserBy3(zcyId, ywyId, zzkjId);
            DataManager.ImpDataSet(dst.Tables[0], this.TCOM_USER);
        }
        /// <summary>
        /// 计算做账提成
        /// </summary>
        public void GetZCTC(TW_PaymentRow mainRow)
        {
            var comRow = GetCommissionRow();
            if (mainRow.零申报 == false)
            {
                var kjrow = TCOM_USER.FindByUSERID(mainRow.做账会计ID);
                switch (kjrow.WorkType)
                {
                    case "二级部门经理":
                        mainRow.做账提成月 = mainRow.月平均费 * comRow.做账_提成;
                        mainRow.工本开票提成 = (mainRow.工本费 + mainRow.开票费) * comRow.做账_工本提成;
                        mainRow.做账主管提成 = mainRow.月平均费 * comRow.做账_团队提成;
                        break;
                    case "会计主管":
                        mainRow.做账提成月 = mainRow.月平均费 * comRow.做账_提成;
                        mainRow.工本开票提成 = (mainRow.工本费 + mainRow.开票费) * comRow.做账_工本提成;
                        break;
                    default:
                        mainRow.做账提成月 = mainRow.月平均费 * comRow.做账_提成;
                        mainRow.工本开票提成 = (mainRow.工本费 + mainRow.开票费) * comRow.做账_工本提成;
                        mainRow.做账团队提成 = mainRow.月平均费 * comRow.做账_经理提层;
                        mainRow.做账主管提成 = mainRow.月平均费 * comRow.做账_团队提成;
                        break;
                }
                if (!string.IsNullOrEmpty(mainRow.业务员ID))
                {
                    var ywyRow = TCOM_USER.FindByUSERID(mainRow.业务员ID);
                    if (ywyRow == null)
                    {
                        throw new Exception("做账会计ID出错!");
                    }
                    switch (ywyRow.WorkType)
                    {
                        case "业务主管":

                            if (mainRow.首年提成结束期 >= mainRow.本次到期月份)
                                mainRow.业务提成月 = mainRow.月平均费 * comRow.业务_做账提成;
                            else
                                mainRow.业务提成月 = mainRow.月平均费 * comRow.业务_做账次年提成;


                            break;
                        case "二级部门经理":
                        case "会计主管":
                            {
                                mainRow.业务提成月 = mainRow.月平均费 * comRow.其他业务提成;
                            }
                            break;
                        default:
                            if (ywyRow.DEPTNAME != "业务部")  //其他部门
                            {
                                mainRow.业务提成月 = mainRow.月平均费 * comRow.其他业务提成;
                                if (ywyRow.DEPTNAME != "注册部")
                                    mainRow.做账业务团队提成 = mainRow.月平均费 * comRow.做账_经理提层;

                            }
                            else //业务部
                            {
                                if (mainRow.首年提成结束期 >= mainRow.本次到期月份)
                                    mainRow.业务提成月 = mainRow.月平均费 * comRow.业务_做账提成;
                                else
                                    mainRow.业务提成月 = mainRow.月平均费 * comRow.业务_做账次年提成;

                                mainRow.业务团队提成 = mainRow.月平均费 * comRow.业务_主管团队提成;

                            }
                            break;
                    }
                }
                if (!string.IsNullOrEmpty(mainRow.注册员ID))
                {
                    var zycRow = TCOM_USER.FindByUSERID(mainRow.注册员ID);
                    {
                        if (mainRow.首年提成结束期 >= mainRow.本次到期月份)
                            mainRow.注册年提成 = mainRow.月平均费 * comRow.注册_年做账费提成;
                    }
                }
            }
            else //零申报
            {

            }



        }


        /// <summary>
        /// 拆分收款，才分成每个月一笔收款
        /// </summary>
        public void CFPayment(int month, DataRow aRow)
        {

            TW_PaymentRow paymentRow = aRow as TW_PaymentRow;
            string pch = paymentRow.TW_PaymentID;
            DateTime startDate = paymentRow.上次到期月份;
            decimal sumprice = paymentRow.月平均费 * month;
            decimal firstmonth = paymentRow.支付金额 - sumprice;
            //开始拆分记录
            for (int i = 1; i <= month; i++)
            {
                var row = this.TW_Payment.NewTW_PaymentRow();
                row.TW_PaymentID = Guid.NewGuid().ToString();
                row.上次到期月份 = new DateTime(startDate.Year, startDate.Month, 1);  //一号
                row.本次到期月份 = new DateTime(startDate.Year, startDate.Month, DateTime.DaysInMonth(startDate.Year, startDate.Month));  //月末
                row.缴费月数 = 1;
                row.客户名称ID = paymentRow.客户名称ID;
                row.支付单位 = paymentRow.支付单位;
                row.做账会计 = paymentRow.做账会计;
                row.做账会计ID = paymentRow.做账会计ID;
                row.业务员 = paymentRow.业务员;
                row.业务员ID = paymentRow.业务员ID;
                row.注册员 = paymentRow.注册员;
                row.注册员ID = paymentRow.注册员ID;

                if (i == 1)
                {
                    row.月平均费 = paymentRow.月平均费 + firstmonth;
                    row.月做账费 = paymentRow.月平均费 + firstmonth;
                    row.支付金额 = paymentRow.月平均费 + firstmonth;
                }
                else
                {
                    row.月平均费 = paymentRow.月平均费;
                    row.月做账费 = paymentRow.月平均费;
                    row.支付金额 = paymentRow.月平均费;
                }

                if (!paymentRow.Is备注Null())
                    row.备注 = string.Format("自动拆分,源金额：{0}元", paymentRow.支付金额) + "  " + paymentRow.备注;
                else
                    row.备注 = string.Format("自动拆分,源金额：{0}元", paymentRow.支付金额);


                row.支付日期 = paymentRow.支付日期;
                row.支付单位 = paymentRow.支付单位;
                row.支付方式 = paymentRow.支付方式;
                row.收款人 = paymentRow.收款人;
                row.收款类别 = paymentRow.收款类别;
                row.是否审核 = false;
                row.注册提成月 = 0;
                row.业务提成月 = 0;
                row.做账提成月 = 0;
                row.做账团队提成 = 0;
                row.业务团队提成 = 0;
                row.做账主管提成 = 0;
                row.注册团队提成 = 0;
                row.注册年提成 = 0;
                row.业务年提成 = 0;
                row.工本开票提成 = 0;
                row.做账业务团队提成 = 0;
                row.批次号 = pch;


                if (!paymentRow.Is零申报Null())
                    row.零申报 = paymentRow.零申报;
                else
                    row.零申报 = false;
                if (!paymentRow.Is首年提成结束期Null())
                    row.首年提成结束期 = paymentRow.首年提成结束期;
                if (!paymentRow.Is银行账号Null())
                    row.银行账号 = paymentRow.银行账号;
                //if (!paymentRow.Is初始做账时间Null())
                //    row.初始做账时间 = paymentRow.初始做账时间;
                if (!paymentRow.Is不收款Null())
                {
                    row.不收款 = paymentRow.不收款;
                }
                else
                {
                    row.不收款 = false;
                }
                row.操作人 = Security.UserName;
                row.操作时间 = DateTime.Now;
                if (i == 1)
                {
                    row.工本费 = paymentRow.工本费;
                    row.开票费 = paymentRow.开票费;
                }
                else
                {
                    row.工本费 = 0;
                    row.开票费 = 0;
                }
                GetZCTC(row);
                this.TW_Payment.AddTW_PaymentRow(row);

                startDate = startDate.AddMonths(1);
            }
            this.TW_Payment.RemoveTW_PaymentRow(paymentRow);  //删除源记录
        }


        /// <summary>
        /// 拆分收款，才分成每个月一笔收款
        /// </summary>
        public void CFPayments(int month, DataRow aRow)
        {
            TW_PaymentRow paymentRow = aRow as TW_PaymentRow;
            DateTime startDate = paymentRow.上次到期月份;
            //开始拆分记录
            for (int i = 1; i <= month; i++)
            {
                var row = this.TW_Payment.NewTW_PaymentRow();
                row.TW_PaymentID = Guid.NewGuid().ToString();
                row.上次到期月份 = new DateTime(startDate.Year, startDate.Month, 1);  //一号
                row.本次到期月份 = new DateTime(startDate.Year, startDate.Month, DateTime.DaysInMonth(startDate.Year, startDate.Month));  //月末
                row.缴费月数 = 1;
                if (!paymentRow.Is客户名称IDNull())
                    row.客户名称ID = paymentRow.客户名称ID;
                row.支付单位 = paymentRow.支付单位;
                row.做账会计 = paymentRow.做账会计;
                row.做账会计ID = paymentRow.做账会计ID;
                if (!paymentRow.Is业务员Null())
                    row.业务员 = paymentRow.业务员;
                if (!paymentRow.Is业务员IDNull())
                    row.业务员ID = paymentRow.业务员ID;
                if (!paymentRow.Is注册员Null())
                    row.注册员 = paymentRow.注册员;
                if (!paymentRow.Is注册员IDNull())
                    row.注册员ID = paymentRow.注册员ID;
                row.做账会计 = paymentRow.做账会计;
                row.做账会计ID = paymentRow.做账会计ID;
                row.月平均费 = paymentRow.月平均费;
                row.月做账费 = paymentRow.月平均费;
                if (!paymentRow.Is备注Null())
                    row.备注 = string.Format("自动拆分,源金额：{0}元", paymentRow.支付金额) + "  " + paymentRow.备注;
                else
                    row.备注 = string.Format("自动拆分,源金额：{0}元", paymentRow.支付金额);
                row.支付金额 = paymentRow.月平均费;
                row.支付日期 = paymentRow.支付日期;
                row.支付单位 = paymentRow.支付单位;
                if (!paymentRow.Is支付方式Null())
                    row.支付方式 = paymentRow.支付方式;
                else
                    row.支付方式 = "其他";
                row.收款人 = paymentRow.收款人;
                row.收款类别 = paymentRow.收款类别;
                if (!paymentRow.Is是否审核Null())
                {
                    row.是否审核 = paymentRow.是否审核;
                }
                else
                    row.是否审核 = false;
                if (!paymentRow.Is审核人Null())
                {
                    row.审核人 = paymentRow.审核人;
                }
                if (!paymentRow.Is审核时间Null())
                {
                    row.审核时间 = paymentRow.审核时间;
                }
                if (!paymentRow.Is零申报Null())
                    row.零申报 = paymentRow.零申报;
                else
                    row.零申报 = false;
                if (!paymentRow.Is首年提成结束期Null())
                    row.首年提成结束期 = paymentRow.首年提成结束期;
                if (!paymentRow.Is银行账号Null())
                    row.银行账号 = paymentRow.银行账号;

                if (!paymentRow.Is不收款Null())
                {
                    row.不收款 = paymentRow.不收款;
                }
                else
                {
                    row.不收款 = false;
                }
                row.操作人 = paymentRow.操作人;
                row.操作时间 = paymentRow.操作时间;
                if (i == 1)
                {
                    row.工本费 = paymentRow.工本费;
                    row.开票费 = paymentRow.开票费;
                }
                else
                {
                    row.工本费 = 0;
                    row.开票费 = 0;
                }
                this.TW_Payment.AddTW_PaymentRow(row);

                startDate = startDate.AddMonths(1);
            }
            //this.TW_Payment.RemoveTW_PaymentRow(paymentRow);  //删除源记录
        }

        /// <summary>
        /// 根据收款请款查询
        /// </summary>
        /// <param name="businessMan"></param>
        /// <param name="regMan"></param>
        /// <param name="accountant"></param>
        /// <param name="isPayment"></param>
        public void GetNoPaymentReg(string accountant, string gsName, string isPayment)
        {
            try
            {
                DataSet dst = DBHelper.WangDaSer.GetNoPaymentReg(accountant, gsName, isPayment);
                DataManager.ImpDataSet(dst.Tables[0], this.VW_PaymentDetail);
            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }

        }

        public void GetCommission()
        {
            try
            {
                DataSet dst = DBHelper.WangDaSer.GetCommission();
                DataManager.ImpDataSet(dst.Tables[0], this.TWS_Commission);
            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }
        }

        public TWS_CommissionRow GetCommissionRow()
        {
            return this.TWS_Commission.Rows[0] as TWS_CommissionRow;
        }
        /// <summary>
        /// 选择付款明细
        /// </summary>
        /// <param name="zclx">注册类型</param>
        /// <param name="mainID">付款ID</param>
        public void ImpPaymentDetail(string mainID, out string zclx)
        {
            foreach (DataRow row in VW_PaymentDetail.Rows)
            {
                var newRow = TW_PaymentDetail.NewTW_PaymentDetailRow();
                newRow.TW_BusinessRegID = row["TW_BusinessRegID"].ToString();
                newRow.TW_PaymentDetailID = Guid.NewGuid().ToString();
                newRow.业务员 = row["业务员"].ToString();
                newRow.业务员ID = row["业务员ID"].ToString();
                newRow.注册员 = row["注册员"].ToString();
                newRow.注册员ID = row["注册员ID"].ToString();
                newRow.做账会计 = row["做账会计"].ToString();
                newRow.做账会计ID = row["做账会计ID"].ToString();
                newRow.客户名称 = row["公司预核名称"].ToString();
                newRow.客户名称ID = row["TW_BusinessRegID"].ToString();
                newRow.注册费 = decimal.Parse(row["注册费未收款"].ToString());
                newRow.工本费 = decimal.Parse(row["工本费未收款"].ToString());
                newRow.开票费 = decimal.Parse(row["开票费未收款"].ToString());
                newRow.月做账费 = decimal.Parse(row["月做账费"].ToString());
                newRow.收款日期 = DateTime.Now;
                newRow.TW_PaymentID = mainID;
                TW_PaymentDetail.Rows.Add(newRow);
            }
            if (VW_PaymentDetail.Rows.Count == 1 && TW_Payment.Rows.Count == 1)
            {
                string payCompany = VW_PaymentDetail.Rows[0]["公司预核名称"].ToString();
                string payCompanyID = VW_PaymentDetail.Rows[0]["TW_BusinessRegID"].ToString();
                zclx = VW_PaymentDetail.Rows[0]["注册类型"].ToString();
                TW_PaymentRow mainRow = this.TW_Payment.Rows[0] as TW_PaymentRow;
                mainRow.BeginEdit();
                mainRow["支付单位"] = payCompany;
                mainRow["客户名称ID"] = payCompanyID;
                switch (zclx)
                {

                    case "成长版":
                        mainRow["收款类别"] = "成长版收款";
                        break;
                    case "验资":
                    case "审计":
                    case "商标":
                        mainRow["收款类别"] = "其他一次性业务收款";
                        break;
                    default:
                        mainRow["收款类别"] = "注册收款";
                        break;
                }


                mainRow.EndEdit();

            }
            else
                zclx = "其他";
        }
        /// <summary>
        /// 计算注册的各项费用提成
        /// </summary>
        /// <param name="zclx"></param>
        /// <param name="mainRow"></param>
        public void GetRegTC(string zclx)
        {
            TW_PaymentRow mainRow = null;
            if (TW_Payment.Rows.Count == 1)
                mainRow = TW_Payment.Rows[0] as TW_PaymentRow;
            else
                throw new Exception("收款出错，没有TW_Payment主记录");
            mainRow.BeginEdit();
            switch (zclx)
            {
                case "注册":
                    mainRow.注册提成月 = GetCommissionRow().注册_单价;
                    mainRow.注册团队提成 = GetCommissionRow().注册_单价 / 2;
                    break;
                case "设立":
                    mainRow.注册提成月 = GetCommissionRow().注册_单价;
                    mainRow.注册团队提成 = GetCommissionRow().注册_单价 / 2;
                    break;
                case "变更":
                case "注销":
                    mainRow.注册提成月 = GetCommissionRow().注册_变更单价;
                    mainRow.注册团队提成 = GetCommissionRow().注册_变更单价 / 2;
                    break;
                case "验资":
                    mainRow.注册提成月 = GetCommissionRow().注册_验资;
                    mainRow.业务提成月 = mainRow.支付金额 * GetCommissionRow().业务_一次性业务成长版;
                    break;
                case "审计":
                    mainRow.注册提成月 = GetCommissionRow().注册_审计;
                    mainRow.业务提成月 = mainRow.支付金额 * GetCommissionRow().业务_一次性业务其他;
                    break;
                case "成长版":
                    mainRow.注册提成月 = GetCommissionRow().注册_成长版;
                    mainRow.业务提成月 = mainRow.支付金额 * GetCommissionRow().业务_一次性业务成长版;//业务员提1000
                    break;
                case "商标":
                    mainRow.注册提成月 = GetCommissionRow().注册_商标;
                    mainRow.业务提成月 = mainRow.支付金额 * GetCommissionRow().业务_一次性业务其他;
                    break;
                default:
                    mainRow.注册提成月 = GetCommissionRow().注册_变更单价;
                    break;
            }
            mainRow.EndEdit();
        }
        /// <summary>
        /// 添加注册主记录
        /// </summary>
        public void AddmainRegRow()
        {
            TW_PaymentRow row = null;
            if (TW_Payment.Rows.Count == 1)
                row = TW_Payment.Rows[0] as TW_PaymentRow;
            AddPaymentMainRow(row);

        }

        /// <summary>
        /// 计算收款总额
        /// </summary>
        /// <returns></returns>
        public decimal SumRegPayment()
        {
            decimal sumPrice = 0;
            foreach (DataRow row in this.TW_PaymentDetail.Rows)
            {
                decimal sumPayment = decimal.Parse(row["总额"].ToString());
                sumPrice = sumPrice + sumPayment;
            }
            return sumPrice;
        }
        /// <summary>
        /// 新添加主收款
        /// </summary>
        /// <returns></returns>
        /// <param name="payType">常规收款，</param>
        public string NewPayment(string payType)
        {
            string newID = Guid.NewGuid().ToString();
            var mainRow = TW_Payment.NewTW_PaymentRow();
            mainRow.操作人 = Security.UserName;
            mainRow.收款人 = Security.UserName;
            mainRow.支付日期 = DateTime.Today;
            mainRow.操作时间 = DateTime.Now;
            mainRow.收款类别 = payType;
            //提成初始化设置
            mainRow.注册提成月 = 0;
            mainRow.业务提成月 = 0;
            mainRow.做账提成月 = 0;
            mainRow.做账团队提成 = 0;
            mainRow.业务团队提成 = 0;
            mainRow.做账主管提成 = 0;
            mainRow.注册团队提成 = 0;
            mainRow.注册年提成 = 0;
            mainRow.业务年提成 = 0;
            mainRow.工本开票提成 = 0;
            mainRow.做账业务团队提成 = 0;
            mainRow.TW_PaymentID = newID;
            TW_Payment.Rows.Add(mainRow);
            return newID;
        }
        /// <summary>
        /// 设置注册提成
        /// </summary>
        public void SetRegTC()
        {
            if (TW_Payment.Rows.Count > 0)
            {
                TW_PaymentRow payRow = TW_Payment.Rows[0] as TW_PaymentRow;
                payRow.注册提成月 = 0;
                payRow.业务提成月 = 0;
                payRow.做账提成月 = 0;
                payRow.做账团队提成 = 0;
                payRow.业务团队提成 = 0;
                payRow.做账主管提成 = 0;
                payRow.注册团队提成 = 0;
                payRow.注册年提成 = 0;
                payRow.业务年提成 = 0;
                payRow.工本开票提成 = 0;
                payRow.做账业务团队提成 = 0;
                payRow.EndEdit();
            }
        }
        /// <summary>
        /// 支付一半
        /// </summary>
        public void HalfPayment()
        {
            foreach (DataRow row in this.TW_PaymentDetail.Rows)
            {
                row.BeginEdit();
                row["注册费收款额"] = decimal.Parse(row["注册费"].ToString()) / 2;
                row.EndEdit();
            }
            decimal sumPrice = SumRegPayment();
            if (TW_Payment.Rows.Count > 0)
            {
                DataRow payRow = TW_Payment.Rows[0];
                payRow.BeginEdit();
                payRow["支付金额"] = sumPrice;
                payRow.EndEdit();
            }
        }
        /// <summary>
        /// 全部支付
        /// </summary>
        public void FullPayment()
        {
            foreach (DataRow row in this.TW_PaymentDetail.Rows)
            {
                row.BeginEdit();
                row["注册费收款额"] = decimal.Parse(row["注册费"].ToString());
                //row["工本费收款额"] = decimal.Parse(row["工本费"].ToString());
                //row["开票费收款额"] = decimal.Parse(row["开票费"].ToString());
                row.EndEdit();
            }
            decimal sumPrice = SumRegPayment();
            if (TW_Payment.Rows.Count > 0)
            {
                DataRow payRow = TW_Payment.Rows[0];
                payRow.BeginEdit();
                payRow["支付金额"] = sumPrice;
                payRow.EndEdit();
            }
        }

        /// <summary>
        /// 保存收款数据
        /// </summary>
        public void SaveDataSet()
        {
            DataTable tbm = this.TW_PaymentMain.GetChanges();
            
            if (tbm != null)
            {
                tbm.TableName = "TW_PaymentMain";
            }

        
            DataTable tb1 = TW_Payment.GetChanges();
            if (tb1 != null)
            {
                tb1.TableName = "TW_Payment";
            }

            DataTable tb2 = TW_PaymentDetail.GetChanges();
            if (tb2 != null)
                tb2.TableName = "TW_PaymentDetail";


            DataSet dst = new DataSet();
            if (tbm != null)
                dst.Tables.Add(tbm);
            if (tb1 != null)
                dst.Tables.Add(tb1);
            if (tb2 != null)
                dst.Tables.Add(tb2);
            //dst.Tables[0].GetChanges(DataRowState.)
            DBHelper.BasicSer.SaveDataSet(dst);



        }
        /// <summary>
        /// 批量删除付款记录
        /// </summary>
        /// <param name="pch"></param>
        public void DeletePaymentByPCH(string pch)
        {
            var mainRow = this.TW_PaymentMain.FindByTW_PaymentID(pch);
            mainRow.Delete();
          //  TW_PaymentMain.RemoveTW_PaymentMainRow(mainRow);
            ArrayList list = new ArrayList();
            foreach (DataRow row in this.TW_Payment.Rows)
            {
                if (row["批次号"].ToString() == pch)
                {
                    list.Add(row);
                }

            }
            foreach (var row in list)
            {
                var pRow = row as TW_PaymentRow;
                pRow.Delete();
            }
        }
        /// <summary>
        /// 根据ID获取收款信息
        /// </summary>
        /// <param name="paymentID"></param>
        /// <returns></returns>
        public DataSet GetPayment(string paymentID)
        {
            DataSet dst = DBHelper.WangDaSer.GetPayment(paymentID);
            return dst;
        }
        /// <summary>
        /// 获取paymentmain主记录和payment子记录
        /// </summary>
        /// <param name="id"></param>
        public void GetPaymentMainById(string id)
        {
            DataSet dst = DBHelper.WangDaSer.GetPaymentMainById(id);
            DataManager.ImpDataSet(dst.Tables["TW_PaymentMain"], this.TW_PaymentMain);
            DataManager.ImpDataSet(dst.Tables["TW_Payment"], this.TW_Payment);
        }
        /// <summary>
        /// 根据ID获取收款信息
        /// </summary>
        /// <param name="paymentID"></param>
        public void GetPaymentById(string paymentID)
        {
            DataSet dst = GetPayment(paymentID);
            if (dst.Tables["TW_Payment"] != null)
            {
                if (this.TW_Payment.FindByTW_PaymentID(paymentID) == null)
                {
                    this.TW_Payment.ImportRow(dst.Tables["TW_Payment"].Rows[0]);
                }
            }
            if (dst.Tables["TW_PaymentDetail"] != null)
            {
                foreach (DataRow row in dst.Tables["TW_PaymentDetail"].Rows)
                {
                    string paymentDetailID = row["TW_PaymentDetailID"].ToString();
                    if (this.TW_PaymentDetail.FindByTW_PaymentDetailID(paymentDetailID) == null)
                        this.TW_PaymentDetail.ImportRow(row);
                }
            }

        }




        /// <summary>
        /// 查询收款
        /// </summary>
        /// <param name="unitName"></param>
        /// <param name="account"></param>
        /// <param name="beginDate"></param>
        /// <param name="endDate"></param>
        /// <param name="paymentType"></param>
        /// <param name="endPaymentDate"></param>
        /// <param name="manager"></param>
        /// <param name="isPay"></param>
        /// <param name="zeroAccount"></param>
        public void GetPaymentByInfo(string unitName, string account, string beginDate, string endDate, string paymentType
            , string endPaymentDate, string manager, string isPay, string zeroAccount)
        {
            try
            {

                DataSet dst = DBHelper.WangDaSer.GetPaymentByInfo(unitName, account, beginDate, endDate, paymentType, endPaymentDate
                    , manager, isPay, zeroAccount);
                DataManager.ImpDataSet(dst.Tables[0], this.TW_Payment);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 获取付款审批信息
        /// </summary>
        /// <param name="spType"></param>
        /// <param name="unitName"></param>
        /// <param name="account"></param>
        /// <param name="beginDate"></param>
        /// <param name="endDate"></param>
        /// <param name="paymentType"></param>
        /// <param name="endPaymentDate"></param>
        /// <param name="cszzDate1">初始做账</param>
        /// <param name="dqDate1">支付日期</param>
        public void GetPaymentByInfoSP(string spType, string unitName, string account, string beginDate, string endDate
            , string paymentType, string endPaymentDate, string isPay, string zeroAccount, string cszzDate1, string cszzDate2, string dqDate1, string dqDate2)
        {
            try
            {
                DataSet dst = DBHelper.WangDaSer.GetPaymentByInfoSP(spType, unitName, account, beginDate, endDate, paymentType, endPaymentDate
                    , isPay, zeroAccount, dqDate1, dqDate2, cszzDate1, cszzDate2);
                DataManager.ImpDataSet(dst.Tables[0], this.TW_Payment);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 获取付款审批信息2021
        /// </summary>
        /// <param name="spType"></param>
        /// <param name="unitName"></param>
        /// <param name="account"></param>
        /// <param name="beginDate"></param>
        /// <param name="endDate"></param>
        /// <param name="paymentType"></param>
        /// <param name="endPaymentDate"></param>
        /// <param name="isPay"></param>
        /// <param name="zeroAccount"></param>
        /// <param name="cszzDate1"></param>
        /// <param name="cszzDate2"></param>
        /// <param name="dqDate1"></param>
        /// <param name="dqDate2"></param>
        public void GetPaymentByInfoSP2021(string spType, string unitName, string account, string beginDate, string endDate
         , string paymentType, string endPaymentDate, string isPay, string zeroAccount, string cszzDate1, string cszzDate2, string dqDate1, string dqDate2)
        {
            try
            {
                DataSet dst = DBHelper.WangDaSer.GetPaymentByInfoSP2021(spType, unitName, account, beginDate, endDate, paymentType, endPaymentDate
                    , isPay, zeroAccount, dqDate1, dqDate2, cszzDate1, cszzDate2);
                DataManager.ImpDataSet(dst.Tables[0], this.TW_PaymentMain);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        /// <summary>
        /// 获取付款明细
        /// </summary>
        /// <param name="paymentID"></param>
        /// <returns></returns>
        public void GetPaymentDetailID(string paymentID)
        {
            try
            {
                DataSet dst = DBHelper.WangDaSer.GetPaymentDetailID(paymentID);
                DataManager.ImpDataSet(dst.Tables[0], this.TW_PaymentDetail);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 根据批次号获取paymentrow
        /// </summary>
        /// <param name="pch"></param>
        public void GetPaymentByPch(string pch)
        {
            try
            {
                DataSet dst = DBHelper.WangDaSer.GetPaymentByPch(pch);
                DataManager.ImpDataSet(dst.Tables[0], this.TW_Payment);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 一次性交接
        /// </summary>
        /// <param name="kuaiji"></param>
        /// <param name="kuaijiId"></param>
        /// <param name="JJDate"></param>
        /// <param name="clientName"></param>
        public void JiaoJieOnce(string kuaiji, string kuaijiId, string JJDate, string clientName)
        {
            try
            {
                DBHelper.WangDaSer.JiaoJieOnce(kuaiji, kuaijiId, JJDate, clientName);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        /// <summary>
        /// 按照会计批量交接
        /// </summary>
        /// <param name="kuaiji">会计</param>
        /// <param name="kuaijiId">会计Id</param>
        /// <param name="JJDate">交接起始月</param>
        /// <param name="clientName">客户名称</param>
        public void JiaoJieByKuaiji(string kuaiji, string kuaijiId, string JJDate, string oldKuaijiId)
        {
            try
            {
                DBHelper.WangDaSer.JiaoJieByKuaiji(kuaiji, kuaijiId, JJDate, oldKuaijiId);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public void UpdateClientPaymentDate(string payEndDate, string clientId)
        {
            try
            {
                DBHelper.WangDaSer.UpdateClientPaymentDate(payEndDate, clientId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 更新主记录数据
        /// </summary>
        /// <param name="pch"></param>
        public void UpdatePaymentMainByPch(string pch)
        {
            try
            {
                DBHelper.WangDaSer.UpdatePaymentMain(pch);

            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }

        /// <summary>
        /// 获取客户的详细付款信息
        /// </summary>
        /// <param name="clientName"></param>
        /// <param name="beginDate"></param>
        /// <param name="endDate"></param>
        /// <param name="zfDate1"></param>
        /// <param name="zfDate2"></param>
        public void GetPaymentByClient(string clientName, string beginDate, string endDate, string zfDate1, string zfDate2)
        {
            try
            {
                DataSet dst = DBHelper.WangDaSer.GetPaymentByClient(clientName, beginDate, endDate, zfDate1, zfDate2);
                DataManager.ImpDataSet(dst.Tables[0], this.VW_Payment);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /// <summary>
        /// 更新子审批记录
        /// </summary>
        public void UpdatePaymentSpDate()
        {
            DBHelper.WangDaSer.UpdatePaymentSpDate();
        }



        /// <summary>
        /// 添加一个收款主记录
        /// </summary>
        /// <param name="mainRow"></param>
        public void AddPaymentMainRow(TW_PaymentRow mainRow)
        {
            TW_PaymentMainRow paymentMain = this.TW_PaymentMain.NewTW_PaymentMainRow();
            paymentMain.TW_PaymentID = mainRow.TW_PaymentID;
            paymentMain.批次号 = mainRow.TW_PaymentID;
            paymentMain.支付单位 = mainRow.支付单位;
            paymentMain.支付金额 = mainRow.支付金额;
            paymentMain.支付日期 = mainRow.支付日期;
            paymentMain.支付方式 = mainRow.支付方式;
            paymentMain.收款人 = mainRow.收款人;
            paymentMain.收款类别 = mainRow.收款类别;
            if (!mainRow.Is备注Null())
                paymentMain.备注 = mainRow.备注;
            paymentMain.客户名称ID = mainRow.客户名称ID;
            paymentMain.操作人 = mainRow.操作人;
            paymentMain.操作时间 = mainRow.操作时间;
            paymentMain.工本费 = mainRow.工本费;
            paymentMain.开票费 = mainRow.开票费;
            paymentMain.做账会计 = mainRow.做账会计;
            paymentMain.上次到期月份 = mainRow.上次到期月份;
            paymentMain.本次到期月份 = mainRow.本次到期月份;
            paymentMain.做账会计ID = mainRow.做账会计ID;
            paymentMain.业务员 = mainRow.业务员;
            paymentMain.业务员ID = mainRow.业务员ID;
            paymentMain.注册员 = mainRow.注册员;
            paymentMain.注册员ID = mainRow.注册员ID;

            paymentMain.缴费月数 = mainRow.缴费月数;
            paymentMain.月平均费 = mainRow.月平均费;
            paymentMain.月做账费 = mainRow.月平均费;

            if (!mainRow.Is零申报Null())
                paymentMain.零申报 = mainRow.零申报;
            else
                paymentMain.零申报 = false;
            if (!mainRow.Is首年提成结束期Null())
                paymentMain.首年提成结束期 = mainRow.首年提成结束期;
            if (!mainRow.Is银行账号Null())
                paymentMain.银行账号 = mainRow.银行账号;

            if (!mainRow.Is不收款Null())
            {
                paymentMain.不收款 = mainRow.不收款;
            }
            else
            {
                paymentMain.不收款 = false;
            }


            paymentMain.是否审核 = false;

            this.TW_PaymentMain.AddTW_PaymentMainRow(paymentMain);

            //paymentMain.做账会计已提 = mainRow.做账会计已提;
            //paymentMain.注册员已提 = mainRow.注册员已提;
            //paymentMain.业务员已提 = mainRow.业务员已提;

        }


        public void AddPaymentMainRows()
        {
            DataView dv = new DataView(this.TW_Payment);
            dv.Sort = "";
        }

    }
}
