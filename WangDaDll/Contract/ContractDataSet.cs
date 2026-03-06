using DevExpress.Utils.Extensions;
using System;
using System.Data;
using System.Linq;
using Tiger.Tools;

namespace WangDaDll.Contract
{


    partial class ContractDataSet
    {
        partial class VW_ContractServiceInfoDataTable
        {
        }

        partial class vw_ContractReceivablesPeriodAccountingDataTable
        {
        }

        partial class TW_ContractChangedDataTable
        {
        }

        partial class vw_ContractReceivablesAccountingDataTable
        {
        }

        partial class vw_ContractReceivablesPeriodDataTable
        {
        }

        public SysTools DBHelper = new SysTools();
        /// <summary>
        /// 添加周期性服务记录
        /// </summary>
        /// <param name="contractId"></param>
        /// <param name="clientId"></param>
        /// <param name="服务分类"></param>
        /// <param name="服务类别"></param>
        /// <param name="服务类型"></param>
        /// <param name="服务项目"></param>
        /// <param name="服务金额"></param>
        /// <param name="服务期限月"></param>
        /// <param name="开始服务月"></param>
        /// <param name="结束服务月"></param>
        /// <param name="服务总时长月"></param>
        /// <param name="赠送时长月"></param>
        public void AddTW_ContractServiceInfoRow(string contractId, string clientId, string 服务分类, string 服务类别, string 服务类型, string 服务项目, decimal 服务金额
            , decimal 服务期限月, DateTime 开始服务月, DateTime 结束服务月, decimal 服务总时长月, decimal 赠送时长月)
        {
            //根据contractI和服务类别：周期性服务，查询ContractServiceInfo是否存在，存在修改存在行，不存在添加
            DataRow[] foundRows = TW_ContractServiceInfo.Select($"ContractID = '{contractId}' AND 服务类别 = '周期性服务'");
            if (foundRows.Length > 0)
            {
                Console.WriteLine($"找到 {foundRows.Length} 行匹配的记录，准备更新。");
                foreach (DataRow foundRow in foundRows)
                {

                    // 更新列值
                    foundRow["客户名称ID"] = clientId;
                    foundRow["服务分类"] = 服务分类;
                    foundRow["服务类别"] = 服务类别;
                    foundRow["服务类型"] = 服务类型;
                    foundRow["服务金额"] = 服务金额;
                    foundRow["服务项目"] = 服务项目;
                    foundRow["服务期限月"] = 服务期限月;
                    foundRow["开始服务月"] = 开始服务月;
                    foundRow["结束服务月"] = 结束服务月;
                    foundRow["服务总时长月"] = 服务总时长月;
                    foundRow["赠送时长月"] = 赠送时长月;
                    // 特别处理“最后修改人”和“最后修改时间”
                    foundRow["最后修改人"] = Security.UserName;
                    foundRow["最后修改时间"] = DateTime.Now;
                    Console.WriteLine($"主键为 {foundRow["ContractServiceInfoID"]} 的行已更新。");
                    return;
                }
            }
            else
            {
                // 创建新行
                DataRow newRow = TW_ContractServiceInfo.NewRow();

                // 填充数据
                newRow["ContractID"] = contractId; // 假设是外键，需传入有效的合同ID
                newRow["客户名称ID"] = clientId;
                newRow["服务分类"] = 服务分类;
                newRow["服务类别"] = 服务类别;
                newRow["服务类型"] = 服务类型;
                newRow["服务金额"] = 服务金额;
                newRow["服务项目"] = 服务项目;
                newRow["服务期限月"] = 服务期限月;
                newRow["开始服务月"] = 开始服务月;
                newRow["结束服务月"] = 结束服务月;
                newRow["服务总时长月"] = 服务总时长月;
                newRow["赠送时长月"] = 赠送时长月;
                newRow["创建人"] = Security.UserName;
                newRow["创建时间"] = DateTime.Now;
                newRow["最后修改人"] = DBNull.Value; // 初始值为 null
                newRow["最后修改时间"] = DBNull.Value; // 初始值为 null
                newRow["ContractServiceInfoID"] = Guid.NewGuid().ToString(); // 假设是自增或由业务逻辑生成

                // 将新行添加到表中
                TW_ContractServiceInfo.Rows.Add(newRow);
                Console.WriteLine("新行已添加。");

                Console.WriteLine("未找到匹配的记录，准备添加新行。");

            }



        }


        /// <summary>
        /// 添加一次性服务记录
        /// </summary>
        /// <param name="contractId"></param>
        /// <param name="clientId"></param>
        /// <param name="服务分类"></param>
        /// <param name="服务类别"></param>
        /// <param name="服务类型"></param>
        /// <param name="服务项目"></param>
        /// <param name="服务金额"></param>
        public void AddTW_ContractServiceInfoRow(string contractId, string clientId, string 服务分类, string 服务类别
            , string 服务类型, string 服务项目, decimal 服务金额)
        {
            //根据contractI和服务类别：周期性服务，查询ContractServiceInfo是否存在，存在修改存在行，不存在添加
            DataRow[] foundRows = TW_ContractServiceInfo.Select($"ContractID = '{contractId}' AND 服务类别 = '一次性服务'");
            if (foundRows.Length > 0)
            {
                Console.WriteLine($"找到 {foundRows.Length} 行匹配的记录，准备更新。");
                foreach (DataRow foundRow in foundRows)
                {

                    // 更新列值
                    foundRow["客户名称ID"] = clientId;
                    foundRow["服务分类"] = 服务分类;
                    foundRow["服务类别"] = 服务类别;
                    foundRow["服务类型"] = 服务类型;
                    foundRow["服务金额"] = 服务金额;
                    foundRow["服务项目"] = 服务项目;

                    // 特别处理“最后修改人”和“最后修改时间”
                    foundRow["最后修改人"] = Security.UserName;
                    foundRow["最后修改时间"] = DateTime.Now;
                    Console.WriteLine($"主键为 {foundRow["ContractServiceInfoID"]} 的行已更新。");
                    return;
                }
            }
            else
            {
                Console.WriteLine("未找到匹配的记录，准备添加新行。");
                // 创建新行
                DataRow newRow = TW_ContractServiceInfo.NewRow();

                // 填充数据
                newRow["ContractID"] = contractId; // 假设是外键，需传入有效的合同ID
                newRow["客户名称ID"] = clientId;
                newRow["服务分类"] = 服务分类;
                newRow["服务类别"] = 服务类别;
                newRow["服务类型"] = 服务类型;
                newRow["服务金额"] = 服务金额;
                newRow["服务项目"] = 服务项目;
                newRow["创建人"] = Security.UserName;
                newRow["创建时间"] = DateTime.Now;
                newRow["最后修改人"] = DBNull.Value; // 初始值为 null
                newRow["最后修改时间"] = DBNull.Value; // 初始值为 null
                newRow["ContractServiceInfoID"] = Guid.NewGuid().ToString(); // 假设是自增或由业务逻辑生成

                // 将新行添加到表中
                TW_ContractServiceInfo.Rows.Add(newRow);
                Console.WriteLine("新行已添加。");
            }

        }


        public void DeleteTW_ContractServiceInfoRow(int contractServiceInfoID)
        {
            // 根据主键查找行
            DataRow rowToDelete = TW_ContractServiceInfo.Rows.Find(contractServiceInfoID);

            if (rowToDelete != null)
            {
                // 删除行
                rowToDelete.Delete();
                Console.WriteLine($"主键为 {contractServiceInfoID} 的行已删除。");
            }
            else
            {
                Console.WriteLine($"未找到主键为 {contractServiceInfoID} 的行。");
            }
        }

        /// <summary>
        /// 修改DataTable中指定主键的行，更新除主键、创建人、创建时间外的所有列。
        /// </summary>
        /// <param name="dt">要操作的DataTable。</param>
        /// <param name="contractServiceInfoID">要修改的行的主键值。</param>
        /// <param name="newValues">包含新值的DataRow，其字段与原始表对应。</param>
        public void UpdateTW_ContractServiceInfoRow(int contractServiceInfoID, DataRow newValues)
        {
            // 根据主键查找行
            DataRow rowToUpdate = TW_ContractServiceInfo.Rows.Find(contractServiceInfoID);

            if (rowToUpdate != null)
            {
                // 遍历所有列
                foreach (DataColumn column in TW_ContractServiceInfo.Columns)
                {
                    // 排除主键、创建人、创建时间
                    if (column.ColumnName != "ContractServiceInfoID" &&
                        column.ColumnName != "创建人" &&
                        column.ColumnName != "创建时间")
                    {
                        // 更新列值
                        // 假设 newValues 中包含了所有需要更新的列
                        rowToUpdate[column.ColumnName] = newValues[column.ColumnName];
                    }
                }

                // 特别处理“最后修改人”和“最后修改时间”
                rowToUpdate["最后修改人"] = "系统管理员"; // 或传入更新者的名字
                rowToUpdate["最后修改时间"] = DateTime.Now;

                Console.WriteLine($"主键为 {contractServiceInfoID} 的行已更新。");
            }
            else
            {
                Console.WriteLine($"未找到主键为 {contractServiceInfoID} 的行。");
            }
        }

        /// <summary>
        /// 添加一个新合同
        /// </summary>
        public DataRow AddTW_ContractRow()
        {

            DataRow newRow = TW_Contract.NewRow();

            // 填充数据
            newRow["ContractID"] = Guid.NewGuid().ToString(); // 假设是自增或由业务逻辑生成
            newRow["合同编号"] = DBHelper.WangDaSer.GenerateNewContractNumber();
            newRow["客户名称"] = DBNull.Value;
            newRow["客户名称ID"] = DBNull.Value;
            newRow["客户单价"] = 0.00m;
            newRow["工本费"] = 0.00m;
            newRow["开票费"] = 0.00m;
            newRow["定金金额"] = 0.00m;
            newRow["创建人"] = Security.UserName;
            newRow["创建时间"] = DateTime.Now;
            newRow["最后修改人"] = DBNull.Value;
            newRow["最后修改时间"] = DBNull.Value;
            newRow["客户来源"] = DBNull.Value;
            newRow["纳税性质"] = "一般纳税人";
            newRow["公司性质"] = "一般纳税人";
            newRow["所属行业"] = DBNull.Value;
            newRow["注册资金万元"] = 0.00m;
            newRow["法人"] = DBNull.Value;
            newRow["联系方式"] = DBNull.Value;
            newRow["身份证号"] = DBNull.Value;
            newRow["生日"] = DBNull.Value;
            newRow["联系人"] = DBNull.Value;
            newRow["联系人联系方式"] = DBNull.Value;
            newRow["职位"] = DBNull.Value;
            newRow["成立时间"] = DBNull.Value;
            newRow["所属区域"] = "常熟市";
            newRow["详细地址"] = DBNull.Value;
            newRow["备注"] = "";
            newRow["合同金额"] = 0.00m;
            newRow["审批状态"] = "未提交";
            newRow["审批日期"] = DBNull.Value;
            newRow["已付款金额"] = 0.00m;
            newRow["签约日期"] = DateTime.Today;
            newRow["未付款金额"] = 0.00m;
            newRow["做账会计"] = "";
            newRow["续签"] = false;
            newRow["补充金额"] = 0.00m;
            newRow["补贴"] = false;
            TW_Contract.Rows.Add(newRow);
            Console.WriteLine("新合同已添加。");
            return newRow;
        }

        /// <summary>
        /// 删除合同和合同服务信息
        /// </summary>
        /// <param name="contractID"></param>
        public void DeleteTW_ContractRow(string contractID)
        {
            // 先删除相关的合同服务信息
            foreach (DataRow row in TW_ContractServiceInfo.Select($"ContractID = '{contractID}'"))
            {
                row.Delete();
            }

            // 根据主键查找行
            DataRow rowToDelete = TW_Contract.Rows.Find(contractID);

            if (rowToDelete != null)
            {
                // 删除行
                rowToDelete.Delete();
                Console.WriteLine($"主键为 {contractID} 的行已删除。");
            }
            else
            {
                Console.WriteLine($"未找到主键为 {contractID} 的行。");
            }
        }

        /// <summary>
        /// 修改DataTable中指定主键的行，更新除主键、创建人、创建时间外的所有列。
        /// </summary>
        /// <param name="dt">要操作的DataTable。</param>
        /// <param name="contractID">要修改的行的主键值。</param>
        /// <param name="newValues">包含新值的DataRow，其字段与原始表对应。</param>
        public void UpdateTW_ContractRow(string contractID, DataRow newValues)
        {
            // 根据主键查找行
            DataRow rowToUpdate = TW_Contract.Rows.Find(contractID);

            if (rowToUpdate != null)
            {
                // 遍历所有列
                foreach (DataColumn column in TW_Contract.Columns)
                {
                    // 排除主键、创建人、创建时间
                    if (column.ColumnName != "ContractServiceInfoID" &&
                        column.ColumnName != "创建人" &&
                        column.ColumnName != "创建时间")
                    {
                        // 更新列值
                        // 假设 newValues 中包含了所有需要更新的列
                        rowToUpdate[column.ColumnName] = newValues[column.ColumnName];
                    }
                }

                // 特别处理“最后修改人”和“最后修改时间”
                rowToUpdate["最后修改人"] = "系统管理员"; // 或传入更新者的名字
                rowToUpdate["最后修改时间"] = DateTime.Now;

                Console.WriteLine($"主键为 {contractID} 的行已更新。");
            }
            else
            {
                Console.WriteLine($"未找到主键为 {contractID} 的行。");
            }
        }



        /// <summary>
        /// 查询合同信息
        /// </summary>
        /// <param name="clientName">客户名称</param>
        /// <param name="accountant">做账会计</param>
        /// <param name="endMonth">到期月</param>
        /// <param name="unpaidAmount">未付款情况：大于0 或 等于0</param>
        /// <param name="spState">审批情况</param>
        public void GetContract(string clientName, string accountant, int endMonth, string unpaidAmount, string spState)
        {
            DataSet dst = DBHelper.WangDaSer.GetContract(clientName, accountant, endMonth, unpaidAmount, spState);
            dst.Tables[0].ImpDataSet(TW_Contract);
            dst.Tables[1].ImpDataSet(TW_ContractServiceInfo);
        }
        /// <summary>
        /// 获取表TW_ContractServiceInfo最后一个周期性合同的结束服务月
        /// </summary>
        /// <returns>如果没有返回空，如果有返回最大值</returns>
        public string GetLastDate()
        {
            // 从强类型表枚举出 TW_ContractServiceInfoRow，筛选周期性服务且结束服务月不为空
            if (this.TW_ContractServiceInfo.Rows.Count == 0)
                return string.Empty;
            var rows = this.TW_ContractServiceInfo
                           .Cast<ContractDataSet.TW_ContractServiceInfoRow>()
                           .Where(r => r.服务类别 == "周期性服务" && !r.Is结束服务月Null());

            if (!rows.Any())
                return string.Empty; // 没有符合条件的记录则返回空字符串

            DateTime maxEnd = rows.Max(r => r.结束服务月);
            return maxEnd.ToString("yyyy-MM-dd");

        }
        /// <summary>
        /// 根据合同ID查询合同信息
        /// </summary>
        /// <param name="contractID"></param>
        public void GetContractByID(string contractID)
        {
            DataSet dst = DBHelper.WangDaSer.GetContractByID(contractID);
            dst.Tables[0].ImpDataSet(TW_Contract);
            dst.Tables[1].ImpDataSet(TW_ContractServiceInfo);
        }
        /// <summary>
        /// 添加合同变更记录
        /// </summary>
        /// <param name="contractId">合同Id</param>
        /// <param name="contractNo">合同编号</param>
        /// <exception cref="Exception"></exception>
        public void NewContractChangedRow(string contractId, string contractNo)
        {
            //根据合同编号，查询该合同的已收款信息
            GetReceivedPayment("", "", "", "", "", contractNo);
            decimal receivedAmount = 0.00m;//已收周期性服务费


            if (vw_ContractReceivablesPeriod.Rows.Count > 0)
            {
                foreach (var row in vw_ContractReceivablesPeriod.Rows)
                {
                    var rRow = row as ContractDataSet.vw_ContractReceivablesPeriodRow;
                    if (!rRow.Is已收周期性服务费Null())
                        receivedAmount += rRow.已收周期性服务费;

                }
            }


            var cRow = this.TW_Contract.FindByContractID(contractId);

            if (cRow == null)
                throw new Exception("未找到合同信息");

            //查找TW_ContractServiceInfo服务记录，用contractId，服务类别为'周期性服务'
            DataRow[] selRows = this.TW_ContractServiceInfo.Select($"ContractID = '{contractId}' AND 服务类别 = '周期性服务'");
            if (selRows.Length == 0)
                throw new Exception("未找到合同服务信息");





            var oldSerRow = selRows[0] as ContractDataSet.TW_ContractServiceInfoRow;


            //距离结束服务月还有几个月
            int months = 0;
            if (!oldSerRow.Is结束服务月Null())
            {
                DateTime endMonth = oldSerRow.结束服务月;
                DateTime now = DateTime.Now;
                months = (endMonth.Year - now.Year) * 12 + endMonth.Month - now.Month;
                if (months < 0) months = 0;
            }
            else
            {
                throw new Exception("合同服务信息的结束服务月不能为空");
            }
            //如果当前日期所在年月是结束服务月，则不能再变更
            if (months == 0)
                throw new Exception("合同服务信息的结束服务月是当前月，不能再变更");

            //添加一条新的变更记录
            var newRow = TW_ContractChanged.NewTW_ContractChangedRow();
            newRow["ContractChangedID"] = Guid.NewGuid().ToString();
            newRow["ContractID"] = contractId;
            newRow.客户名称 = cRow.客户名称;
            newRow.原合同金额 = cRow.合同金额;
            newRow.已收款额 = receivedAmount;
            newRow.原单价 = oldSerRow.服务金额;
            newRow.原服务期限 = oldSerRow.服务期限月;
            newRow.原开始服务月 = oldSerRow.开始服务月;
            newRow.原结束服务月 = oldSerRow.结束服务月;

            newRow.合同编号 = cRow.合同编号;
            newRow.涨价 = 0.0m;
            newRow.变更后合同金额 = 0.0m;
            newRow.新单价 = 0.0m;
            newRow.创建人 = Security.UserName;
            newRow.创建时间 = DateTime.Now;
            DateTime stratMonth = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            if (newRow.原开始服务月 > stratMonth)
                newRow.起始变更月 = newRow.原开始服务月;
            else
                newRow.起始变更月 = stratMonth;
            //变更月数=原开始服务月-起始变更月
            newRow.变更月数 = ((newRow.原结束服务月.Year - newRow.起始变更月.Year) * 12 + newRow.原结束服务月.Month - newRow.起始变更月.Month) + 1;



            TW_ContractChanged.Rows.Add(newRow);


        }

        /// <summary>
        /// 提交合同变更记录，设置审批状态为'=待审批'
        /// 同时更新合同的合同金额和客户单价，合同务信息的服务金额
        /// 最后保存数据
        /// </summary>
        public void PostChanges()
        {
            foreach (var row in TW_ContractChanged.Rows)
            {
                var cRow = row as ContractDataSet.TW_ContractChangedRow;
                cRow.审批状态 = "待审批";
            }
            //保存数据
            DataSet dst = new DataSet();
            DataTable tb2 = TW_ContractChanged.GetChanges();
            if (tb2 != null)
            {
                tb2.TableName = "TW_ContractChanged";
                dst.Tables.Add(tb2);
            }

            DBHelper.BasicSer.SaveDataSet(dst);
            TW_ContractChanged.AcceptChanges();
        }

        /// <summary>
        /// 保存变更记录
        /// </summary>
        public void SaveChanges()
        {//保存数据
            DataSet dst = new DataSet();
            DataTable tb2 = TW_ContractChanged.GetChanges();
            if (tb2 != null)
            {
                tb2.TableName = "TW_ContractChanged";
                dst.Tables.Add(tb2);
            }

            DBHelper.BasicSer.SaveDataSet(dst);
            TW_ContractChanged.AcceptChanges();

        }
        /// <summary>
        /// 根据条件查询合同变更记录
        /// </summary>
        /// <param name="constractNo">合同编号</param>
        /// <param name="clientName">客户名称</param>
        /// <param name="beginDate">创建时间1</param>
        /// <param name="endDate">创建时间2</param>
        public void GetTW_ContractChanged(string constractNo, string clientName, string beginDate, string endDate)
        {
            //如果用户不是管理员或者注册主管，则只能查看自己的变更记录
            string creater = "";
            if (!Security.UserBusiness.Contains("总经理") && Security.UserBusiness != "注册主管" && Security.UserName != "admin")
            {
                creater = Security.UserName;
            }

            DataSet dst = DBHelper.WangDaSer.GetTW_ContractChanged(constractNo, clientName, beginDate, endDate, creater);
            dst.Tables[0].ImpDataSet(TW_ContractChanged);
        }

        /// <summary>
        /// 审批变更记录,审批通过后，待终审
        /// </summary>
        public void ApprovalChanges(string approvalContent)
        {
            foreach (var row in TW_ContractChanged.Rows)
            {
                var cRow = row as ContractDataSet.TW_ContractChangedRow;
                if (cRow.审批状态 != "待审批")
                    continue;
                //根据合同ID，查询合同信息
                var oldContractRow = this.TW_Contract.FindByContractID(cRow.ContractID);
                if (oldContractRow == null)
                    throw new Exception("未找到合同信息");
                //查找TW_ContractServiceInfo服务记录，用contractId，服务类别为'周期性服务'
                DataRow[] selRows = this.TW_ContractServiceInfo.Select($"ContractID = '{cRow.ContractID}' AND 服务类别 = '周期性服务'");
                if (selRows.Length == 0)
                    throw new Exception("未找到合同服务信息");
                var oldSerRow = selRows[0] as ContractDataSet.TW_ContractServiceInfoRow;
                //更新变更记录的审批状态和审批日期
                cRow.审批状态 = "待终审";
                cRow.审批结果 = approvalContent;
                cRow.审批人 = Security.UserName;
                cRow.审批时间 = DateTime.Now;


            }
            //保存数据
            DataSet dst = new DataSet();


            DataTable tb2 = TW_ContractChanged.GetChanges();
            if (tb2 != null)
            {
                tb2.TableName = "TW_ContractChanged";
                dst.Tables.Add(tb2);
            }

            DBHelper.BasicSer.SaveDataSet(dst);
            TW_Contract.AcceptChanges();
            TW_ContractServiceInfo.AcceptChanges();


        }

        /// <summary>
        /// 审批变更记录，审批通过后，复制原来的合同，创新建一个新的合同记录
        /// 新合同合同编号原合同编号+“-变更”
        /// 新合同只包含周期性服务记录
        /// 新合同服务费用为变更记录涨价金额，服务期限为变更月数，服务开始月为原合同服务结束月减变更月数
        /// </summary>
        public void ZSApprovalChanges(string approvalContent)
        {
            foreach (var row in TW_ContractChanged.Rows)
            {
                var cRow = row as ContractDataSet.TW_ContractChangedRow;
                if (cRow.审批状态 != "待审批")
                    continue;
                //根据合同ID，查询合同信息
                var oldContractRow = this.TW_Contract.FindByContractID(cRow.ContractID);
                if (oldContractRow == null)
                    throw new Exception("未找到合同信息");
                //查找TW_ContractServiceInfo服务记录，用contractId，服务类别为'周期性服务'
                DataRow[] selRows = this.TW_ContractServiceInfo.Select($"ContractID = '{cRow.ContractID}' AND 服务类别 = '周期性服务'");
                if (selRows.Length == 0)
                    throw new Exception("未找到合同服务信息");
                var oldSerRow = selRows[0] as ContractDataSet.TW_ContractServiceInfoRow;
                //添加一个新的合同记录
                var newContractRow = this.TW_Contract.NewTW_ContractRow();
                newContractRow.ContractID = Guid.NewGuid().ToString();
                newContractRow.合同编号 = oldContractRow.合同编号 + "-变更";
                newContractRow.客户名称 = oldContractRow.客户名称;
                newContractRow.客户名称ID = oldContractRow.客户名称ID;
                newContractRow.创建人 = Security.UserName;
                newContractRow.创建时间 = DateTime.Now;
                newContractRow.合同金额 = cRow.涨价 * cRow.变更月数;
                newContractRow.审批状态 = "已审批";
                newContractRow.审批日期 = DateTime.Now;
                newContractRow.签约日期 = DateTime.Today;
                if (!oldContractRow.Is做账会计Null())
                    newContractRow.做账会计 = oldContractRow.做账会计;
                if (!oldContractRow.Is做账会计IDNull())
                    newContractRow.做账会计ID = oldContractRow.做账会计ID;
                if (!oldContractRow.Is注册员IDNull())
                    newContractRow.注册员 = oldContractRow.注册员;
                if (!oldContractRow.Is注册员IDNull())
                    newContractRow.注册员ID = oldContractRow.注册员ID;
                newContractRow.备注 = cRow.变更原因及说明;
                newContractRow.工本费 = 0.00m;
                newContractRow.开票费 = 0.00m;
                newContractRow.定金金额 = 0.00m;
                newContractRow.已付款金额 = 0.00m;
                newContractRow.未付款金额 = 0.00m;
                if (!oldContractRow.Is纳税性质Null())
                    newContractRow.纳税性质 = oldContractRow.纳税性质;
                else
                    newContractRow.纳税性质 = "一般纳税人";
                if (!oldContractRow.Is公司性质Null())
                    newContractRow.公司性质 = oldContractRow.公司性质;
                if (!oldContractRow.Is所属行业Null())
                    newContractRow.所属行业 = oldContractRow.所属行业;
                if (!oldContractRow.Is注册资金万元Null())
                    newContractRow.注册资金万元 = oldContractRow.注册资金万元;
                if (!oldContractRow.Is法人Null())
                    newContractRow.法人 = oldContractRow.法人;
                if (!oldContractRow.Is联系方式Null())
                    newContractRow.联系方式 = oldContractRow.联系方式;
                if (!oldContractRow.Is身份证号Null())
                    newContractRow.身份证号 = oldContractRow.身份证号;
                if (!oldContractRow.Is生日Null())
                    newContractRow.生日 = oldContractRow.生日;
                if (!oldContractRow.Is联系人Null())
                    newContractRow.联系人 = oldContractRow.联系人;
                if (!oldContractRow.Is联系人联系方式Null())
                    newContractRow.联系人联系方式 = oldContractRow.联系人联系方式;
                if (!oldContractRow.Is职位Null())
                    newContractRow.职位 = oldContractRow.职位;
                if (!oldContractRow.Is成立时间Null())
                    newContractRow.成立时间 = oldContractRow.成立时间;
                if (!oldContractRow.Is所属区域Null())
                    newContractRow.所属区域 = oldContractRow.所属区域;
                if (!oldContractRow.Is详细地址Null())
                    newContractRow.详细地址 = oldContractRow.详细地址;
                if (!oldContractRow.Is客户来源Null())
                    newContractRow.客户来源 = oldContractRow.客户来源;
                newContractRow.客户单价 = cRow.涨价;

                this.TW_Contract.Rows.Add(newContractRow);

                var newSerRow = this.TW_ContractServiceInfo.NewTW_ContractServiceInfoRow();
                newSerRow.ContractServiceInfoID = Guid.NewGuid().ToString();
                newSerRow.ContractID = newContractRow.ContractID;
                newSerRow.客户名称ID = newContractRow.客户名称ID;
                newSerRow.服务分类 = oldSerRow.服务分类;
                newSerRow.服务类别 = "周期性服务";
                newSerRow.服务类型 = oldSerRow.服务类型;
                newSerRow.服务项目 = oldSerRow.服务项目;
                newSerRow.服务金额 = cRow.涨价;
                newSerRow.服务期限月 = cRow.变更月数;
                newSerRow.开始服务月 = cRow.起始变更月;
                newSerRow.结束服务月 = cRow.起始变更月.AddMonths(cRow.变更月数).AddDays(-1);
                newSerRow.服务总时长月 = cRow.变更月数;
                newSerRow.赠送时长月 = 0;
                newSerRow.创建人 = Security.UserName;
                newSerRow.创建时间 = DateTime.Now;
                //DateTime beginDate = oldSerRow.结束服务月.AddMonths(-cRow.变更月数);
                ////从1号开始
                //newSerRow.开始服务月 = new DateTime(beginDate.Year, beginDate.Month, 1);
                this.TW_ContractServiceInfo.Rows.Add(newSerRow);

                //更新变更记录的审批状态和审批日期
                cRow.审批状态 = "已审批";
                cRow.审批结果 = approvalContent;
                cRow.终审人 = Security.UserName;
                cRow.终审时间 = DateTime.Now;


            }
            //保存数据
            DataSet dst = new DataSet();

            DataTable tb = TW_Contract.GetChanges();

            if (tb != null)
            {
                tb.TableName = "TW_Contract";
                dst.Tables.Add(tb);
            }
            DataTable tb1 = TW_ContractServiceInfo.GetChanges();
            if (tb1 != null)
            {
                tb1.TableName = "TW_ContractServiceInfo";
                dst.Tables.Add(tb1);
            }
            DataTable tb2 = TW_ContractChanged.GetChanges();
            if (tb2 != null)
            {
                tb2.TableName = "TW_ContractChanged";
                dst.Tables.Add(tb2);
            }

            DBHelper.BasicSer.SaveDataSet(dst);
            TW_Contract.AcceptChanges();
            TW_ContractServiceInfo.AcceptChanges();


        }

        /// <summary>
        /// 根据客户ID查询客户信息
        /// </summary>
        /// <param name="clientId"></param>
        public void GetTW_ClientByClientId(string clientId)
        {
            DataSet dst = DBHelper.WangDaSer.GetTW_ClientByClientId(clientId);
            dst.Tables[0].ImpDataSet(this.TW_Client);

        }

        /// <summary>
        /// 查询合同变更记录，返回变更记录数量
        /// </summary>
        /// <param name="constractId"></param>
        public int GetContractChanged(string constractId)
        {
            DataSet dst = DBHelper.WangDaSer.GetContractChanged(constractId);
            dst.Tables[0].ImpDataSet(this.TW_ContractChanged);
            if (TW_ContractChanged.Rows.Count > 0)
                return TW_ContractChanged.Rows.Count;
            else
                return 0;
        }



        /// <summary>
        /// 保存TW_Contract,TW_ContractServiceInfo数据
        /// </summary>
        /// <exception cref="Exception"></exception>
        public void SaveDataSet()
        {
            DataSet dst = new DataSet();

            DataTable tb = TW_Contract.GetChanges();

            if (tb != null)
            {
                tb.TableName = "TW_Contract";
                dst.Tables.Add(tb);
            }
            DataTable tb1 = TW_ContractServiceInfo.GetChanges();
            if (tb1 != null)
            {
                tb1.TableName = "TW_ContractServiceInfo";
                dst.Tables.Add(tb1);
            }

            DBHelper.BasicSer.SaveDataSet(dst);
            TW_Contract.AcceptChanges();
            TW_ContractServiceInfo.AcceptChanges();



        }
        /// <summary>
        /// 查询合同应收款
        /// </summary>
        /// <param name="beginDate"></param>
        /// <param name="endDate"></param>
        /// <param name="clientName"></param>
        public void GetContractReceivables(string beginDate, string endDate, string clientName)
        {
            DataSet dst = DBHelper.WangDaSer.GetReceivables(beginDate, endDate, clientName);
            dst.Tables[0].ImpDataSet(vw_ContractReceivables);
        }
        /// <summary>
        /// 查询合同应收款
        /// </summary>
        /// <param name="beginDate">开始时间</param>
        /// <param name="endDate">结束时间</param>
        /// <param name="clientName">客户名称</param>
        /// <param name="accountant">做账会计</param>
        public void GetContractReceivables(string clientName, string accountant, string beginDate, string endDate)
        {
            DataSet dst = DBHelper.WangDaSer.GetReceivablesByAccounting(beginDate, endDate, accountant, clientName);
            dst.Tables[0].ImpDataSet(vw_ContractReceivablesAccounting);
        }
        /// <summary>
        /// 查询做账会计的已收款
        /// </summary>
        /// <param name="receiptDate1"></param>
        /// <param name="receiptDate2"></param>
        /// <param name="clientName"></param>
        /// <param name="accountant">做账会计</param>
        public void GetContractReceivablesPeriod(string clientName, string accountant, string receiptDate1, string receiptDate2, string signDate1, string signDate2)
        {
            DataSet dst = DBHelper.WangDaSer.GetReceivedPaymentByAccounting(clientName, accountant, receiptDate1, receiptDate2, signDate1, signDate2);
            dst.Tables[0].ImpDataSet(vw_ContractReceivablesPeriodAccounting);
        }
        /// <summary>
        /// 查询已收款
        /// </summary>
        /// <param name="clientName"></param>
        /// <param name="receiptDate1"></param>
        /// <param name="receiptDate2"></param>
        /// <param name="signDate1"></param>
        /// <param name="signDate2"></param>
        /// <param name="contractNo">合同编号</param>
        public void GetReceivedPayment(string clientName, string receiptDate1, string receiptDate2, string signDate1, string signDate2, string contractNo)
        {
            DataSet dst = DBHelper.WangDaSer.GetReceivedPayment(clientName, receiptDate1, receiptDate2, signDate1, signDate2, contractNo);
            dst.Tables[0].ImpDataSet(vw_ContractReceivablesPeriod);
        }

        /// <summary>
        /// 获取没有登记业务的一次性合同信息
        /// </summary>
        public void GetNoRegContract(string clientName, string signDate1, string signDate2)
        {
            DataSet dst = DBHelper.WangDaSer.GetNoRegContract(clientName, signDate1, signDate2);
            dst.Tables[0].ImpDataSet(this.VM_一次性服务合同明细);

        }

        /// <summary>
        /// 根据数组ID更新合同信息的注册员，注册员ID
        /// </summary>
        /// <param name="regId"></param>
        public void UpdateRegName(string[] regIds)
        {
            DBHelper.WangDaSer.UpdateRegName(regIds);

        }
        /// <summary>
        /// 根据合同ID，续签合同
        /// 操作：复制合同信息，服务类别为'周期性服务'的合同服务信息，服务周期，按照服务期限月顺眼至下一个周期
        /// </summary>
        /// <param name="contractId"></param>
        public void RenewContract(string contractId)
        {
            var contractRow = this.TW_Contract.FindByContractID(contractId);
            if (contractRow == null)
                throw new Exception("未找到合同信息");
            var newContractRow = this.TW_Contract.NewTW_ContractRow();
            //复制合同信息,赋值除主键、审批状态、审批日期、签约日期以外的所有列
            newContractRow.ContractID = Guid.NewGuid().ToString();
            newContractRow.合同编号 = DBHelper.WangDaSer.GenerateNewContractNumber();
            newContractRow.客户名称 = contractRow.客户名称;
            newContractRow.客户名称ID = contractRow.客户名称ID;
            newContractRow.续签 = true;
            if (contractRow.Is客户单价Null())
                newContractRow.客户单价 = 0.00m;
            else
                newContractRow.客户单价 = contractRow.客户单价;
            if (contractRow.Is工本费Null())
                newContractRow.工本费 = 0.00m;
            else
                newContractRow.工本费 = contractRow.工本费;
            if (contractRow.Is开票费Null())
                newContractRow.开票费 = 0.00m;
            else
                newContractRow.开票费 = contractRow.开票费;
            newContractRow.定金金额 = 0.00m;
            newContractRow.创建人 = Security.UserName;
            newContractRow.创建时间 = DateTime.Now;
            //  newContractRow.最后修改人 = DBNull.Value;
            //      newContractRow.最后修改时间 = DBNull.Value;
            if (contractRow.Is客户来源Null())
                newContractRow.客户来源 = "";
            else
                newContractRow.客户来源 = contractRow.客户来源;
            if (contractRow.Is纳税性质Null())
                newContractRow.纳税性质 = "一般纳税人";
            else
                newContractRow.纳税性质 = contractRow.纳税性质;
            if (contractRow.Is公司性质Null())
                newContractRow.公司性质 = "一般纳税人";
            else
                newContractRow.公司性质 = contractRow.公司性质;
            if (contractRow.Is所属行业Null())
                newContractRow.所属行业 = "";
            else
                newContractRow.所属行业 = contractRow.所属行业;
            if (contractRow.Is注册资金万元Null())
                newContractRow.注册资金万元 = 0.00m;
            else
                newContractRow.注册资金万元 = contractRow.注册资金万元;
            if (contractRow.Is法人Null())
                newContractRow.法人 = "";
            else
                newContractRow.法人 = contractRow.法人;
            if (contractRow.Is联系方式Null())
                newContractRow.联系方式 = "";
            else
                newContractRow.联系方式 = contractRow.联系方式;
            if (contractRow.Is身份证号Null())
                newContractRow.身份证号 = "";
            else
                newContractRow.身份证号 = contractRow.身份证号;
            if (!contractRow.Is生日Null())
                newContractRow.生日 = contractRow.生日;
            if (contractRow.Is联系人Null())
                newContractRow.联系人 = "";
            else
                newContractRow.联系人 = contractRow.联系人;
            if (contractRow.Is联系人联系方式Null())
                newContractRow.联系人联系方式 = "";
            else
                newContractRow.联系人联系方式 = contractRow.联系人联系方式;
            if (contractRow.Is职位Null())
                newContractRow.职位 = "";
            else
                newContractRow.职位 = contractRow.职位;
            if (!contractRow.Is成立时间Null())
                newContractRow.成立时间 = contractRow.成立时间;
            if (contractRow.Is所属区域Null())
                newContractRow.所属区域 = "常熟市";
            else
                newContractRow.所属区域 = contractRow.所属区域;
            if (contractRow.Is详细地址Null())
                newContractRow.详细地址 = "";
            else
                newContractRow.详细地址 = contractRow.详细地址;
            if (contractRow.Is备注Null())
                newContractRow.备注 = "";
            else
                newContractRow.备注 = contractRow.备注;
            if (contractRow.Is未付款金额Null())
                newContractRow.未付款金额 = 0.00m;
            else
                newContractRow.未付款金额 = contractRow.未付款金额;
            if (contractRow.Is已付款金额Null())
                newContractRow.已付款金额 = 0.00m;
            else
                newContractRow.已付款金额 = contractRow.已付款金额;
            if (contractRow.Is定金金额Null())
                newContractRow.定金金额 = 0.00m;
            else
                newContractRow.定金金额 = contractRow.定金金额;
            if (contractRow.Is合同金额Null())
                newContractRow.合同金额 = 0.00m;
            else
                newContractRow.合同金额 = contractRow.合同金额;

            newContractRow.审批状态 = "未提交";
            //newContractRow.审批日期 = DBNull.Value;
            //newContractRow.已付款金额 = 0.00m;
            newContractRow.签约日期 = DateTime.Today;
            //newContractRow.未付款金额 = newContractRow.合同金额;
            if (contractRow.Is做账会计Null())
                newContractRow.做账会计 = "";
            else
                newContractRow.做账会计 = contractRow.做账会计;
            if (contractRow.Is做账会计IDNull())
                newContractRow.做账会计ID = "";
            else
                newContractRow.做账会计ID = contractRow.做账会计ID;
            this.TW_Contract.Rows.Add(newContractRow);
            //查找TW_ContractServiceInfo的记录，contractId，服务类别为'周期性服务'的记录
            var serviceRows = this.TW_ContractServiceInfo.Select($"ContractID = '{contractId}' AND 服务类别 = '周期性服务'");
            //定义总金额
            decimal totalAmount = 0.00m;
            //复制这些记录，赋值除主键、创建人、创建时间、最后修改人、最后修改时间外的所有列
            foreach (var serviceRow in serviceRows)
            {
                var sRow = serviceRow as ContractDataSet.TW_ContractServiceInfoRow;

                var newServiceRow = this.TW_ContractServiceInfo.NewTW_ContractServiceInfoRow();
                newServiceRow.ContractServiceInfoID = Guid.NewGuid().ToString();
                newServiceRow.ContractID = newContractRow.ContractID;
                newServiceRow.客户名称ID = sRow.客户名称ID;
                newServiceRow.服务分类 = sRow.服务分类;
                newServiceRow.服务类别 = sRow.服务类别;
                newServiceRow.服务类型 = sRow.服务类型;
                newServiceRow.服务项目 = sRow.服务项目;
                newServiceRow.服务金额 = sRow.服务金额;
                newServiceRow.服务期限月 = sRow.服务期限月;
                totalAmount = sRow.服务金额 * sRow.服务期限月;
                //服务周期，按照服务期限月顺延至下一个周期
                if (!sRow.Is开始服务月Null() && !sRow.Is结束服务月Null())
                {
                    DateTime newStartMonth = sRow.开始服务月.AddMonths((int)sRow.服务期限月);
                    DateTime newEndMonth = sRow.结束服务月.AddMonths((int)sRow.服务期限月);
                    newServiceRow.开始服务月 = newStartMonth;
                    newServiceRow.结束服务月 = newEndMonth;
                }

                newServiceRow.服务总时长月 = newServiceRow.服务期限月;
                newServiceRow.赠送时长月 = 0;
                newServiceRow.创建人 = Security.UserName;
                newServiceRow.创建时间 = DateTime.Now;
                // newServiceRow.最后修改人 = DBNull.Value;
                // newServiceRow.最后修改时间 = DBNull.Value;
                this.TW_ContractServiceInfo.Rows.Add(newServiceRow);
            }
            if (totalAmount > 0)
            {
                newContractRow.合同金额 = totalAmount;
                newContractRow.EndEdit();
            }


        }
        /// <summary>
        /// 生成补贴合同
        /// </summary>
        /// <param name="contractId"></param>
        /// <exception cref="Exception"></exception>
        public void BTContract(string contractId)
        {
            var contractRow = this.TW_Contract.FindByContractID(contractId);
            if (contractRow == null)
                throw new Exception("未找到合同信息");
            var newContractRow = this.TW_Contract.NewTW_ContractRow();
            //复制合同信息,赋值除主键、审批状态、审批日期、签约日期以外的所有列
            newContractRow.ContractID = Guid.NewGuid().ToString();
            newContractRow.合同编号 = contractRow.合同编号 + "-补贴";
            newContractRow.客户名称 = contractRow.客户名称;
            newContractRow.客户名称ID = contractRow.客户名称ID;
            newContractRow.续签 = contractRow.续签;
            newContractRow.补贴 = true;
            if (contractRow.Is客户单价Null())
                newContractRow.客户单价 = 0.00m;
            else
                newContractRow.客户单价 = contractRow.客户单价;
            if (contractRow.Is工本费Null())
                newContractRow.工本费 = 0.00m;
            else
                newContractRow.工本费 = contractRow.工本费;
            if (contractRow.Is开票费Null())
                newContractRow.开票费 = 0.00m;
            else
                newContractRow.开票费 = contractRow.开票费;
            newContractRow.定金金额 = 0.00m;
            newContractRow.创建人 = Security.UserName;
            newContractRow.创建时间 = DateTime.Now;
            //  newContractRow.最后修改人 = DBNull.Value;
            //      newContractRow.最后修改时间 = DBNull.Value;
            if (contractRow.Is客户来源Null())
                newContractRow.客户来源 = "";
            else
                newContractRow.客户来源 = contractRow.客户来源;
            if (contractRow.Is纳税性质Null())
                newContractRow.纳税性质 = "一般纳税人";
            else
                newContractRow.纳税性质 = contractRow.纳税性质;
            if (contractRow.Is公司性质Null())
                newContractRow.公司性质 = "一般纳税人";
            else
                newContractRow.公司性质 = contractRow.公司性质;
            if (contractRow.Is所属行业Null())
                newContractRow.所属行业 = "";
            else
                newContractRow.所属行业 = contractRow.所属行业;
            if (contractRow.Is注册资金万元Null())
                newContractRow.注册资金万元 = 0.00m;
            else
                newContractRow.注册资金万元 = contractRow.注册资金万元;
            if (contractRow.Is法人Null())
                newContractRow.法人 = "";
            else
                newContractRow.法人 = contractRow.法人;
            if (contractRow.Is联系方式Null())
                newContractRow.联系方式 = "";
            else
                newContractRow.联系方式 = contractRow.联系方式;
            if (contractRow.Is身份证号Null())
                newContractRow.身份证号 = "";
            else
                newContractRow.身份证号 = contractRow.身份证号;
            if (!contractRow.Is生日Null())
                newContractRow.生日 = contractRow.生日;
            if (contractRow.Is联系人Null())
                newContractRow.联系人 = "";
            else
                newContractRow.联系人 = contractRow.联系人;
            if (contractRow.Is联系人联系方式Null())
                newContractRow.联系人联系方式 = "";
            else
                newContractRow.联系人联系方式 = contractRow.联系人联系方式;
            if (contractRow.Is职位Null())
                newContractRow.职位 = "";
            else
                newContractRow.职位 = contractRow.职位;
            if (!contractRow.Is成立时间Null())
                newContractRow.成立时间 = contractRow.成立时间;
            if (contractRow.Is所属区域Null())
                newContractRow.所属区域 = "常熟市";
            else
                newContractRow.所属区域 = contractRow.所属区域;
            if (contractRow.Is详细地址Null())
                newContractRow.详细地址 = "";
            else
                newContractRow.详细地址 = contractRow.详细地址;
            if (contractRow.Is备注Null())
                newContractRow.备注 = "";
            else
                newContractRow.备注 = contractRow.备注;
            if (contractRow.Is未付款金额Null())
                newContractRow.未付款金额 = 0.00m;
            else
                newContractRow.未付款金额 = contractRow.未付款金额;
            if (contractRow.Is已付款金额Null())
                newContractRow.已付款金额 = 0.00m;
            else
                newContractRow.已付款金额 = contractRow.已付款金额;
            if (contractRow.Is定金金额Null())
                newContractRow.定金金额 = 0.00m;
            else
                newContractRow.定金金额 = contractRow.定金金额;
            if (contractRow.Is合同金额Null())
                newContractRow.合同金额 = 0.00m;
            else
                newContractRow.合同金额 = contractRow.合同金额;

            newContractRow.审批状态 = "未提交";
            //newContractRow.审批日期 = DBNull.Value;
            //newContractRow.已付款金额 = 0.00m;
            newContractRow.签约日期 = DateTime.Today;
            //newContractRow.未付款金额 = newContractRow.合同金额;
            if (contractRow.Is做账会计Null())
                newContractRow.做账会计 = "";
            else
                newContractRow.做账会计 = contractRow.做账会计;
            if (contractRow.Is做账会计IDNull())
                newContractRow.做账会计ID = "";
            else
                newContractRow.做账会计ID = contractRow.做账会计ID;
            this.TW_Contract.Rows.Add(newContractRow);
            //查找TW_ContractServiceInfo的记录，contractId，服务类别为'周期性服务'的记录
            var serviceRows = this.TW_ContractServiceInfo.Select($"ContractID = '{contractId}' AND 服务类别 = '周期性服务'");
            //定义总金额
            decimal totalAmount = 0.00m;
            //复制这些记录，赋值除主键、创建人、创建时间、最后修改人、最后修改时间外的所有列
            foreach (var serviceRow in serviceRows)
            {
                var sRow = serviceRow as ContractDataSet.TW_ContractServiceInfoRow;
                var newServiceRow = this.TW_ContractServiceInfo.NewTW_ContractServiceInfoRow();
                newServiceRow.ContractServiceInfoID = Guid.NewGuid().ToString();
                newServiceRow.ContractID = newContractRow.ContractID;
                newServiceRow.客户名称ID = sRow.客户名称ID;
                newServiceRow.服务分类 = sRow.服务分类;
                newServiceRow.服务类别 = sRow.服务类别;
                newServiceRow.服务类型 = sRow.服务类型;
                newServiceRow.服务项目 = sRow.服务项目;
                newServiceRow.服务金额 = sRow.服务金额;
                newServiceRow.服务期限月 = sRow.服务期限月;
                totalAmount = sRow.服务金额 * sRow.服务期限月;

                //补贴周期与原合同的周期一致
                if (!sRow.Is开始服务月Null() && !sRow.Is结束服务月Null())
                {
                    newServiceRow.开始服务月 = sRow.开始服务月;
                    newServiceRow.结束服务月 = sRow.结束服务月;
                }

                newServiceRow.服务总时长月 = newServiceRow.服务期限月;
                newServiceRow.赠送时长月 = 0;
                newServiceRow.创建人 = Security.UserName;
                newServiceRow.创建时间 = DateTime.Now;

                this.TW_ContractServiceInfo.Rows.Add(newServiceRow);
            }
            if (totalAmount > 0)
            {
                newContractRow.合同金额 = totalAmount;
                newContractRow.EndEdit();
            }


        }

        /// <summary>
        /// 根据客户名称查询客户信息
        /// </summary>
        /// <param name="clientName"></param>
        public void GetTW_ClientByClientName(string clientName)
        {
            DataSet dst = DBHelper.WangDaSer.GetTW_ClientByClientName(clientName);
            dst.Tables[0].ImpDataSet(this.TW_Client);
        }
        /// <summary>
        /// 根据客户ID和用户ID查询客户信息
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="userId"></param>
        public void GetTW_ClientByClientIdAndUserId(string clientId, string userId)
        {
            DataSet dst = DBHelper.WangDaSer.GetTW_ClientByUser(clientId, userId);
            dst.Tables[0].ImpDataSet(this.TW_Client);
        }
        /// <summary>
        /// 根据客户名称和用户ID查询客户信息
        /// </summary>
        /// <param name="clientName"></param>
        /// <param name="userId"></param>
        public void GetTW_ClientByClientNameAndUserName(string clientName, string userName)
        {
            DataSet dst = DBHelper.WangDaSer.GetTW_ClientByUserName(clientName, userName);
            dst.Tables[0].ImpDataSet(this.TW_Client);
        }
        /// <summary>
        /// 根据合同编号查询合同信息
        /// </summary>
        /// <param name="contractNo"></param>
        public void GetContractByNo(string contractNo)
        {
            DataSet dst = DBHelper.WangDaSer.GetContractByNo(contractNo);
            dst.Tables[0].ImpDataSet(TW_Contract);
            dst.Tables[1].ImpDataSet(TW_ContractServiceInfo);

        }

        /// <summary>
        /// 查询合同给服务信息通过客户ID
        /// </summary>
        /// <param name="ClientId"></param>
        public void GetContractInfoByClientId(string ClientId)
        {
            DataSet dst = DBHelper.WangDaSer.GetContractInfoByClientId(ClientId);

            dst.Tables[0].ImpDataSet(TW_ContractServiceInfo);


        }
        /// <summary>
        /// 找最后一个合同通过客户ID
        /// </summary>
        /// <param name="ClientId"></param>
        public void GetLastContractByClientId(string ClientId)
        {
            DataSet dst = DBHelper.WangDaSer.GetLastContractByClientId(ClientId);
            dst.Tables[0].ImpDataSet(TW_Contract);
        }
        /// <summary>
        /// 查询合同给服务信息通过客户ID，但排除contractId与参数contractId相同的行
        /// </summary>
        /// <param name="ClientId"></param>
        /// <param name="contractId"></param>
        public void GetContractInfoByClientId(string ClientId, string contractId)
        {
            DataSet dst = DBHelper.WangDaSer.GetContractInfoByClientId(ClientId);
            //排除contractId与参数contractId相同的行
            var filteredRows = dst.Tables[0].AsEnumerable()
                .Where(row => row.Field<string>("ContractID") != contractId);
            foreach (var row in filteredRows)
            {
                TW_ContractServiceInfo.ImportRow(row);
            }

        }

        /// <summary>
        /// 查询合同已经到期，但没有签订新合同的合同
        /// </summary>
        /// <param name="clientName">客户名称</param>
        /// <param name="endDate">服务到期月</param>
        /// <param name="Accounting">做账会计</param>
        public void GetNoSignContract(string clientName, string endDate, string Accounting)
        {
            if (Security.UserBusiness.Contains("总经理") || Security.UserBusiness.Contains("注册主管") || Security.UserName.ToLower() == "admin")
            {
            }
            else
            {
                Accounting = Security.UserName;
            }
            DataSet dst = DBHelper.WangDaSer.GetNoSignContract(clientName, endDate, Accounting);
            dst.Tables[0].ImpDataSet(VW_ContractServiceInfo);

        }

        /// <summary>
        /// 查询一个时间段内，新签订或者续签的周期类服务合同
        /// </summary>
        /// <param name="startDate">合同签订开始时间</param>
        /// <param name="endDate">合同签订结束时间</param>
        /// <param name="Accounting">做账会计</param>
        /// <param name="signState">合同续签状态</param>
        public void GetNewCycleContract(string startDate, string endDate, string Accounting, string signState)
        {
            if (Security.UserBusiness.Contains("总经理") || Security.UserBusiness.Contains("注册主管") || Security.UserName.ToLower() == "admin")
            {
            }
            else
            {
                Accounting = Security.UserName;
            }
            DataSet dst = DBHelper.WangDaSer.GetNewCycleContract(startDate, endDate, Accounting, signState);
            dst.Tables[0].ImpDataSet(VW_ContractServiceInfo);
        }

        /// <summary>
        /// 保存客户信息
        /// </summary>
        public void SaveClientData()
        {
            DataTable tb = this.TW_Client.GetChanges();
            if (tb != null && tb.Rows.Count > 0)
            {
                DataSet dst = new DataSet();
                tb.TableName = "TW_Client";
                dst.Tables.Add(tb);
                DBHelper.BasicSer.SaveTable(dst, tb.TableName);
                TW_Client.AcceptChanges();
            }

        }
        /// <summary>
        /// 修改付款记录的做账会计和做账会计ID根据相关条件
        /// </summary>
        /// <param name="startDate">起始月</param>
        /// <param name="accountName">做账会计</param>
        /// <param name="accountId">做账会计Id</param>
        /// <param name="contractNo">合同编号</param>
        /// <param name="clientId">客户名称ID</param>
        public void UpdatePaymentAccount(string startDate, string accountName, string accountId, string contractNo, string clientId)
        {
            DBHelper.WangDaSer.UpdatePaymentAccount(startDate, accountName, accountId, contractNo, clientId);
        }
    }
}
