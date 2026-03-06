
--已收款信息
SELECT [TW_PaymentID]
      ,[支付单位]
      ,[支付金额]
      ,[支付日期]
      ,[支付方式]
      ,[收款人]
      ,[收款类别]
      ,[备注]
      ,[客户名称ID]
      ,[操作人]
      ,[操作时间]
      ,[工本费]
      ,[开票费]
      ,[做账会计]
      ,[上次到期月份]
      ,[本次到期月份]
      ,[做账会计ID]
      ,[做账会计已提]
      ,[注册员已提]
      ,[首年提成结束期]
      ,[业务员已提]
      ,[业务员]
      ,[业务员ID]
      ,[注册员]
      ,[注册员ID]
      ,[月做账费]
      ,[缴费月数]
      ,[月平均费]
      ,[不收款]
      ,[银行账号]
      ,[是否审核]
      ,[审核人]
      ,[审核时间]
      ,[零申报]
      ,[批次号]
      ,[ContractID]
      ,[ContractServiceInfoID]
      ,[合同编号]
  FROM [dbo].[TW_PaymentMain]
go
--合同信息
SELECT [ContractID]
      ,[客户名称]
      ,[合同编号]
      ,[客户名称ID]
      ,[客户单价]
      ,[工本费]
      ,[开票费]
      ,[定金金额]
      ,[合同附件ID]
      ,[创建人]
      ,[创建时间]
      ,[最后修改人]
      ,[最后修改时间]
      ,[客户来源]
      ,[纳税性质]
      ,[公司性质]
      ,[所属行业]
      ,[注册资金万元]
      ,[法人]
      ,[联系方式]
      ,[身份证号]
      ,[生日]
      ,[联系人]
      ,[联系人联系方式]
      ,[职位]
      ,[成立时间]
      ,[所属区域]
      ,[详细地址]
      ,[备注]
      ,[营业执照附件ID]
      ,[合同金额]
      ,[审批状态]
      ,[审批日期]
      ,[已付款金额]
      ,[签约日期]
      ,[审批人]
      ,[审批意见]
      ,[做账会计]
  FROM [dbo].[TW_Contract]

go
--合同服务信息
select ContractID,服务类别,开始服务月,结束服务月  from TW_ContractServiceInfo
--根据这三张表的内容，
--查询应收款的信息，查询列包括客户名称，合同编号，签约日期，合同金额，已收款金额，应收款金额,最后收款日期,费用截止月，一个合同可能有多条收款记录
--仅查询仍有应收款余额的合同
SELECT * FROM (
    SELECT
        c.[客户名称],
        c.[合同编号],
        c.[签约日期],
        c.[合同金额],
        ISNULL(p.[已收款金额], 0) AS [已收款金额],
        c.[合同金额] - ISNULL(p.[已收款金额], 0) AS [应收款金额],
        p.[最后收款日期],
        p.费用截止月
    FROM [dbo].[TW_Contract] c
    LEFT JOIN (
        SELECT
            pm.[ContractID],
            SUM(pm.[支付金额]) AS [已收款金额],
            MAX(pm.[支付日期]) AS [最后收款日期],
            max(pm.本次到期月份) as [费用截止月]
        FROM [dbo].[TW_PaymentMain] pm
        WHERE (pm.[是否审核] = 1) and pm.ContractID is not null
        GROUP BY pm.[ContractID]
    ) p ON c.[ContractID] = p.[ContractID]
) t
WHERE t.[应收款金额] > 0;

--查询一个时间段的已收款情况，包括客户名称，合同编号，签约日期，已收款金额,最后收款日期，应收款金额
/*
伪代码/思路：
1. 定义查询时间范围参数 @StartDate, @EndDate
2. PayOverall: 汇总所有已审核（或未设置审核）的付款：按合同分组求总已收款金额
3. PayPeriod: 汇总时间段内付款：按合同分组求本期已收款金额与本期最后收款日期
4. 关联合同表：
   - 仅返回在时间段内有收款的合同（INNER JOIN PayPeriod）
   - 已收款金额 = 本期已收款金额
   - 最后收款日期 = 本期最后收款日期
   - 应收款金额 = 合同金额 - 总已收款金额(累计，不仅限期间)
5. 可选：再加一个 WHERE 过滤 仍有应收款余额 的合同 (示例中注释给出)
6. 结束
*/

DECLARE @StartDate DATE = '2024-01-01';
DECLARE @EndDate   DATE = '2024-12-31';

WITH PayOverall AS (
    SELECT
        pm.ContractID,
        SUM(pm.支付金额) AS 总已收款金额
    FROM dbo.TW_PaymentMain pm
    WHERE (pm.是否审核 = 1 OR pm.是否审核 IS NULL)
      AND pm.ContractID IS NOT NULL
    GROUP BY pm.ContractID
),
PayPeriod AS (
    SELECT
        pm.ContractID,
        SUM(pm.支付金额)          AS 期间已收款金额,
        MAX(pm.支付日期)          AS 期间最后收款日期
    FROM dbo.TW_PaymentMain pm
    WHERE (pm.是否审核 = 1 OR pm.是否审核 IS NULL)
      AND pm.ContractID IS NOT NULL
      AND pm.支付日期 >= @StartDate
      AND pm.支付日期 < DATEADD(DAY, 1, @EndDate) -- 使结束日期包含当日
    GROUP BY pm.ContractID
)
SELECT
    c.客户名称,
    c.合同编号,
    c.签约日期,
    ISNULL(pp.期间已收款金额, 0)                        AS 已收款金额,
    pp.期间最后收款日期                                 AS 最后收款日期,
    c.合同金额 - ISNULL(po.总已收款金额, 0)             AS 应收款金额
FROM dbo.TW_Contract c
INNER JOIN PayPeriod pp ON c.ContractID = pp.ContractID       -- 仅含本期有收款的合同
LEFT  JOIN PayOverall po ON c.ContractID = po.ContractID
-- 如需仅显示仍有应收款余额合同，取消下行注释
-- WHERE c.合同金额 - ISNULL(po.总已收款金额, 0) > 0
ORDER BY c.签约日期, c.合同编号;

-- 如果还需要展示“累计已收款金额”，可改写选择列为：
-- ISNULL(po.总已收款金额,0) AS 累计已收款金额

-- 查询一个时间段的已收款情况，包括：
-- 客户名称，合同编号，签约日期，期间已收款金额，期间最后收款日期，剩余应收款金额，期间涉及的做账会计(去重拼接)
create view vw_ContractReceivablesPeriod
AS
WITH PayOverall AS (
    SELECT
        pm.ContractID,
        SUM(pm.支付金额) AS 总已收款金额
    FROM dbo.TW_PaymentMain pm
    WHERE (pm.是否审核 = 1 )
      AND pm.ContractID IS NOT NULL
    GROUP BY pm.ContractID
),
PayPeriod AS (
    SELECT
        pm.ContractID,
        SUM(pm.支付金额)  AS 期间已收款金额,
        MAX(pm.支付日期)  AS 期间最后收款日期,
        -- 期间内所有(去重)做账会计拼接
        做账会计 = STUFF((
            SELECT DISTINCT N'、' + ISNULL(pm2.做账会计, N'')
            FROM dbo.TW_PaymentMain pm2
            WHERE (pm2.是否审核 = 1 )
              AND pm2.ContractID = pm.ContractID
              AND pm2.支付日期 >='2025-1-1'
              AND pm2.支付日期 < DATEADD(DAY, 1, '2025-8-31')
              AND ISNULL(pm2.做账会计, '') <> ''
            FOR XML PATH(''), TYPE
        ).value('.', 'nvarchar(max)'), 1, 1, '')
    FROM dbo.TW_PaymentMain pm
    WHERE (pm.是否审核 = 1)
      AND pm.ContractID IS NOT NULL
      AND pm.支付日期 >= '205-1-1'
      AND pm.支付日期 < DATEADD(DAY, 1, '2025-8-31')
    GROUP BY pm.ContractID
)
SELECT
    c.客户名称,
    c.合同编号,
    c.签约日期,
    pp.期间已收款金额        AS 期间已收款金额,
    pp.期间最后收款日期     AS 最后收款日期,
    c.合同金额 - ISNULL(po.总已收款金额, 0) AS 应收款金额,
    c.合同金额,
    po.总已收款金额 AS 累计已收款金额,
    pp.做账会计
FROM dbo.TW_Contract c
INNER JOIN PayPeriod pp ON c.ContractID = pp.ContractID
LEFT  JOIN PayOverall po ON c.ContractID = po.ContractID
-- 如需仅显示仍有应收款余额合同，取消下行注释
-- WHERE c.合同金额 - ISNULL(po.总已收款金额, 0) > 0
--ORDER BY c.签约日期, c.合同编号;
go 




/* 需求：查询仍有应收款余额的合同
   输出列：
     客户名称，合同编号，签约日期，合同金额，
     已收款金额，应收款金额，最后收款日期，费用截止月，合同结束服务月
   说明：
     1. 已收款金额：TW_PaymentMain 中 已审核(是否审核=1) 的支付金额汇总
     2. 最后收款日期：同一聚合内最大支付日期
     3. 费用截止月：支付记录中最大 本次到期月份
     4. 合同结束服务月：TW_ContractServiceInfo 中同合同最大 结束服务月
     5. 仅返回 (合同金额 - 已收款金额) > 0 的合同
     6. 排序：签约日期，合同编号
*/

SELECT
    c.客户名称,
    c.合同编号,
    c.签约日期,
    c.合同金额,
    ISNULL(p.已收款金额, 0) AS 已收款金额,
    c.合同金额 - ISNULL(p.已收款金额, 0) AS 应收款金额,
    p.最后收款日期,
    p.费用截止月,
    cs.合同结束服务月
FROM dbo.TW_Contract c
LEFT JOIN (
    SELECT
        pm.ContractID,
        SUM(pm.支付金额)    AS 已收款金额,
        MAX(pm.支付日期)    AS 最后收款日期,
        MAX(pm.本次到期月份) AS 费用截止月
    FROM dbo.TW_PaymentMain pm
    WHERE pm.是否审核 = 1
      AND pm.ContractID IS NOT NULL
    GROUP BY pm.ContractID
) p ON c.ContractID = p.ContractID
LEFT JOIN (
    SELECT
        csi.ContractID,
        MAX(csi.结束服务月) AS 合同结束服务月
    FROM dbo.TW_ContractServiceInfo csi
    GROUP BY csi.ContractID
) cs ON c.ContractID = cs.ContractID
WHERE c.合同金额 - ISNULL(p.已收款金额, 0) > 0
ORDER BY c.签约日期, c.合同编号;

go

create view vw_ContractReceivables AS
/* 需求：查询仍有应收款余额的合同
   输出列：
     客户名称，合同编号，签约日期，合同金额，
     已收款金额，应收款金额，最后收款日期，费用截止月，合同结束服务月
   说明：
     1. 已收款金额：TW_PaymentMain 中 已审核(是否审核=1) 的支付金额汇总
     2. 最后收款日期：同一聚合内最大支付日期
     3. 费用截止月：支付记录中最大 本次到期月份
     4. 合同结束服务月：TW_ContractServiceInfo 中同合同最大 结束服务月
     5. 仅返回 (合同金额 - 已收款金额) > 0 的合同
     6. 排序：签约日期，合同编号
*/
SELECT
    c.客户名称,
    c.合同编号,
    c.签约日期,
    c.合同金额,
    ISNULL(p.已收款金额, 0) AS 已收款金额,
    c.合同金额 - ISNULL(p.已收款金额, 0) AS 应收款金额,
    p.最后收款日期,
    p.费用截止月,
    cs.合同结束服务月,
    c.做账会计,
    newid() as CID
FROM dbo.TW_Contract c
LEFT JOIN (
    SELECT
        pm.ContractID,
        SUM(pm.支付金额)    AS 已收款金额,
        MAX(pm.支付日期)    AS 最后收款日期,
        MAX(pm.本次到期月份) AS 费用截止月
    FROM dbo.TW_PaymentMain pm
    WHERE pm.是否审核 = 1
      AND pm.ContractID IS NOT NULL
    GROUP BY pm.ContractID
) p ON c.ContractID = p.ContractID
LEFT JOIN (
    SELECT
        csi.ContractID,
        MAX(csi.结束服务月) AS 合同结束服务月
    FROM dbo.TW_ContractServiceInfo csi
    GROUP BY csi.ContractID
) cs ON c.ContractID = cs.ContractID
WHERE c.合同金额 - ISNULL(p.已收款金额, 0) > 0
--ORDER BY c.签约日期, c.合同编号;
