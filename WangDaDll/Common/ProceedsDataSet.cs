using Tiger.Tools;
using System.Data;
using System;

namespace WangDaDll.Common
{


    partial class ProceedsDataSet
    {
        partial class TW_PaymentDataTable
        {
        }

        public SysTools DBHelper = new SysTools();


        /// <summary>
        /// 根据收款请款查询
        /// </summary>
        /// <param name="businessMan"></param>
        /// <param name="regMan"></param>
        /// <param name="accountant"></param>
        /// <param name="isPayment"></param>
        public void GetNoPaymentReg(string accountant, string gsName,string isPayment)
        {
            try
            {
                DataSet dst = DBHelper.WangDaSer.GetNoPaymentReg(accountant, gsName ,isPayment);
                DataManager.ImpDataSet(dst.Tables[0], this.VW_PaymentDetail);
            }
            catch (Exception ex)
            {
                UserMessages.ShowErrorBox(ex.Message);
            }

        }
        /// <summary>
        /// 选择付款明细
        /// </summary>
        public void ImpPaymentDetail(string mainID)
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

                DataRow mainRow = this.TW_Payment.Rows[0];
                mainRow.BeginEdit();
                mainRow["支付单位"] = payCompany;
                mainRow["客户名称ID"] = payCompanyID;
                mainRow.EndEdit();

            }
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
            mainRow.TW_PaymentID = newID;
            TW_Payment.Rows.Add(mainRow);
            return newID;
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
            DataTable tb1 = TW_Payment.GetChanges();
            if (tb1 != null)
            {
                tb1.TableName = "TW_Payment";
            }
            DataTable tb2 = TW_PaymentDetail.GetChanges();
            if (tb2 != null)
                tb2.TableName = "TW_PaymentDetail";
            if (tb1 != null)
            {

                DataSet dst = new DataSet();
                dst.Tables.Add(tb1);
                if (tb2 != null)
                    dst.Tables.Add(tb2);
                DBHelper.BasicSer.SaveDataSet(dst);
            }
            else
            {
                throw new Exception("收款数据出错，请重新收款!");
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


        public void GetPaymentByInfo(string unitName, string account, string beginDate, string endDate, string paymentType
            , string endPaymentDate, string manager, string isPay, string zeroAccount)
        {
            try
            {

                DataSet dst = DBHelper.WangDaSer.GetPaymentByInfo(unitName, account, beginDate, endDate, paymentType, endPaymentDate
                    , manager,isPay,zeroAccount);
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
        public void GetPaymentByInfoSP(string spType, string unitName, string account, string beginDate, string endDate
            , string paymentType, string endPaymentDate,string isPay,string zeroAccount)
        {
            try
            {
                DataSet dst = DBHelper.WangDaSer.GetPaymentByInfoSP(spType, unitName, account, beginDate, endDate, paymentType, endPaymentDate,isPay,zeroAccount);
                DataManager.ImpDataSet(dst.Tables[0], this.TW_Payment);
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


    }
}
