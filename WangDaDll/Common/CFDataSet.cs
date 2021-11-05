using System;
using System.Data;
using Tiger.Tools;

namespace WangDaDll.Common
{


    partial class CFDataSet
    {

        public SysTools DBHelper = new SysTools();


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
        /// 保存收款数据
        /// </summary>
        public void SaveDataSet()
        {
            DataTable tb1 = TW_Payment.GetChanges();
            if (tb1 != null)
            {
                tb1.TableName = "TW_Payment";
            }
            if (tb1 != null)
            {

                DataSet dst = new DataSet();
                dst.Tables.Add(tb1);
                DBHelper.BasicSer.SaveDataSet(dst);
            }
            else
            {
                throw new Exception("收款数据出错，请重新收款!");
            }

        }
        /// <summary>
        /// 查询待拆分的数据集
        /// </summary>
        /// <param name="beginDate"></param>
        /// <param name="endDate"></param>
        public void GetCFDataSet(string beginDate, string endDate)
        {
            DataSet dst = DBHelper.WangDaSer.GetCFDataSet(beginDate, endDate);
            DataManager.ImpDataSet(dst.Tables[0], this.TW_Payment);
        }


    }
}
