select TW_BusinessRegID,公司预核名称,注册员,注册员ID from TW_BusinessReg
go
select ContractID,注册员,注册员ID,客户名称,客户名称ID from TW_Contract
go

--TW_BusinessReg的TW_BusinessRegID与TW_Contract的ContractID关联,用TW_BusinessReg表的注册员和注册员ID更新TW_Contract表的注册员和注册员ID
update TW_Contract set 注册员=a.注册员,注册员ID=a.注册员ID from TW_Contract b
inner join TW_BusinessReg a on b.ContractID=a.TW_BusinessRegID
where a.TW_BusinessRegID in ('','','');
go
