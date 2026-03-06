
-- 每个客户最后一笔付款记录（推荐：CROSS APPLY）
SELECT c.客户名称ID,
       c.支付单位,
       p.[TW_PaymentID],
       p.支付日期,
       p.支付总额,
       p.收款类别,p.做账会计,p.做账会计ID,
       p.备注,p.缴费月数,p.上次到期月份,p.本次到期月份,p.注册员,p.注册员ID,p.业务员,p.业务员ID,月做账费,p.工本费,p.开票费
FROM (
    -- 客户维度（从付款表去重得到客户列表；也可改为从客户表）
    SELECT DISTINCT 客户名称ID, 支付单位
    FROM [dbo].[TW_PaymentMain] 
) AS c
CROSS APPLY (
    SELECT TOP (1) pm.*
    FROM [dbo].[TW_PaymentMain] pm
    WHERE pm.客户名称ID = c.客户名称ID and  [本次到期月份]>'2025-1-1' and 支付总额>0
    ORDER BY pm.支付日期 DESC, pm.[TW_PaymentID] DESC
) AS p ORDER by p.支付日期

go
select t1.*
,t2.合同编号,t2.合同金额
 from [dbo].[TW_ContractServiceInfo] t1,[dbo].[TW_Contract] t2 
where t1.ContractID=t2.ContractID
go
--25年新增客户
-- 方式二：仅列出客户及其首次付款日期（首次付款发生在2025年）
SELECT pm.客户名称ID,
       pm.支付单位,
       MIN(pm.支付日期) AS 首次付款日期
FROM [dbo].[TW_PaymentMain] pm
GROUP BY pm.客户名称ID, pm.支付单位
HAVING MIN(pm.支付日期) >= '2025-01-01'
   AND MIN(pm.支付日期) <  '2026-01-01';


go
--去除重复的客户名称
select 客户名称,COUNT(*) from [dbo].[TW_Client]
group by 客户名称
having COUNT(*)>1

go

select * from [TW_Client]
where 客户名称=
'苏州翰祥机器人技术有限公司'

delete from TW_Client where 客户名称ID='AA2E98F2-094C-4F33-B4F0-6D01AF8CB07E'
--增加客户名称唯一性约束


select * from [dbo].[TW_ContractServiceInfo]