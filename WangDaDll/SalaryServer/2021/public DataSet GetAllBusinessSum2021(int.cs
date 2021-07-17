     public DataSet GetAllBusinessSum2021(int year, int month, string userManagerID, string userName)
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
            t.操作时间 as 支付日期,
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
            and  year(t.操作时间)= " + year + @" and month(t.操作时间) = " + month + @"
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
            t.注册费收款额 as 其他一次性业务,
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
			t.注册费收款额 as 成长版,
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
