select 
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
        and t.业务员已提 = 0 and year(t.支付日期)= 2017 and month(t.支付日期) = 11
        and t.收款类别 = '常规收款'
		union 
		select
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
        where t.业务员已提=0
        and t.注册费<=t.注册费收款额
        and Year(t.收款日期)=2017 and MONTH(t.收款日期)=10
		) as ts 
		group by ts.员工,ts.员工ID
		) as tt,
		TWS_Commission as tc
		where tc.TWS_CommissionID='1'