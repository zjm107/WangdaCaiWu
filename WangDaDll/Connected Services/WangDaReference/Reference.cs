﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WangDaDll.WangDaReference {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WangDaReference.WangDaSerSoap")]
    public interface WangDaSerSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CheckCompanyName", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool CheckCompanyName(string companyName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UpdateCUserID", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void UpdateCUserID();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UpdateUserID", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void UpdateUserID();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetClientId", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string GetClientId(string clientName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetImage", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetImage(string fkID, string fileType);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetImagebyID", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetImagebyID(string FileID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetClientInfo", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetClientInfo(string clientName, string clientType, string clientLevel, string clientPropety, string accountant);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetEndDateClient", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetEndDateClient(string clientName, string clientType, string clientLevel, string clientPropety, string accountant, string endDate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetSingleClient", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetSingleClient(string clientName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetBusinessRegData", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetBusinessRegData(string businessMan, string beginRegDate, string endRegDate, string companyName, string isPayment, string regState, string wqState, string deptName, string regTag, string wqTag, string frmType, string FbeginDate, string FendDate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetBusinessRegDataEdit", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetBusinessRegDataEdit(string businessMan, string beginRegDate, string endRegDate, string companyName, string isPayment, string regState, string wqState, string deptName, string regTag, string wqTag, string frmType, string regWC, string fBeginDate, string fEndDate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetBusinessRegByID", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetBusinessRegByID(string TW_BusinessRegID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetBusinessExamineData", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetBusinessExamineData(string businessMan, string beginRegDate, string endRegDate, string companyName, string isPayment, string regState, string wqState, string deptName, string regTag, string wqTag, string isExamine);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetNoPaymentReg", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetNoPaymentReg(string accountant, string gsName, string isPayment);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SavePayment", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void SavePayment(System.Data.DataSet dst);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetPayment", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetPayment(string paymentID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetPaymentByInfo", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetPaymentByInfo(string unitName, string account, string beginDate, string endDate, string paymentType, string endPaymentDate, string manager, string isPay, string zeroAccount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetPaymentByInfoSP", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetPaymentByInfoSP(string spType, string unitName, string account, string beginDate, string endDate, string paymentType, string endPaymentDate, string isPay, string zeroAccount, string bcdqDate1, string bcdqDate2, string cszzDate1, string cszzDate2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetPaymentDetailID", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetPaymentDetailID(string paymentID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetBusinessSum", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetBusinessSum(string businessID, int year, int month);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetBusinessSum2021", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetBusinessSum2021(string businessID, int year, int month);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetBusinessSumCZB2021", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetBusinessSumCZB2021(string businessID, int year, int month);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetBusinessSumYCX2021", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetBusinessSumYCX2021(string businessID, int year, int month);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAllBusinessSum", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetAllBusinessSum(int year, int month, string userManagerID, string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAllBusinessSumZC", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetAllBusinessSumZC(int year, int month, string userManagerID, string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAllBusinessSum2021", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetAllBusinessSum2021(int year, int month, string userManagerID, string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAllBusinessSumZC2021", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetAllBusinessSumZC2021(int year, int month, string userManagerID, string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAllBusinessSumOther", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetAllBusinessSumOther(int year, int month, string userManagerID, string userName, string deptid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAllBusinessSumOther2021", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetAllBusinessSumOther2021(int year, int month, string userManagerID, string userName, string deptId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetBussinessManagerDept", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetBussinessManagerDept(string businessID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetBussinessSumByYear", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetBussinessSumByYear(int Year, string businessManID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetBusinessLastYear", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetBusinessLastYear(int year, string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetRegSum", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetRegSum(int year, int month, string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetRegSum2021", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetRegSum2021(int year, int month, string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetRegSumDetail", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetRegSumDetail(int year, int month, string userID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAccountantSum", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetAccountantSum(int year, int month, string userName, string deptid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAccountantSum2021", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetAccountantSum2021(int year, int month, string userName, string deptid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAccountantSumDetail", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetAccountantSumDetail(int year, int month, string userID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAccountantDetail", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetAccountantDetail(int year, int month, string deptid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetLSBAccountantDetail", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetLSBAccountantDetail(int year, int month);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UpdateYWY", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void UpdateYWY();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UpdateClient", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void UpdateClient();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WangDaSerSoapChannel : WangDaDll.WangDaReference.WangDaSerSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WangDaSerSoapClient : System.ServiceModel.ClientBase<WangDaDll.WangDaReference.WangDaSerSoap>, WangDaDll.WangDaReference.WangDaSerSoap {
        
        public WangDaSerSoapClient() {
        }
        
        public WangDaSerSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WangDaSerSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WangDaSerSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WangDaSerSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool CheckCompanyName(string companyName) {
            return base.Channel.CheckCompanyName(companyName);
        }
        
        public void UpdateCUserID() {
            base.Channel.UpdateCUserID();
        }
        
        public void UpdateUserID() {
            base.Channel.UpdateUserID();
        }
        
        public string GetClientId(string clientName) {
            return base.Channel.GetClientId(clientName);
        }
        
        public System.Data.DataSet GetImage(string fkID, string fileType) {
            return base.Channel.GetImage(fkID, fileType);
        }
        
        public System.Data.DataSet GetImagebyID(string FileID) {
            return base.Channel.GetImagebyID(FileID);
        }
        
        public System.Data.DataSet GetClientInfo(string clientName, string clientType, string clientLevel, string clientPropety, string accountant) {
            return base.Channel.GetClientInfo(clientName, clientType, clientLevel, clientPropety, accountant);
        }
        
        public System.Data.DataSet GetEndDateClient(string clientName, string clientType, string clientLevel, string clientPropety, string accountant, string endDate) {
            return base.Channel.GetEndDateClient(clientName, clientType, clientLevel, clientPropety, accountant, endDate);
        }
        
        public System.Data.DataSet GetSingleClient(string clientName) {
            return base.Channel.GetSingleClient(clientName);
        }
        
        public System.Data.DataSet GetBusinessRegData(string businessMan, string beginRegDate, string endRegDate, string companyName, string isPayment, string regState, string wqState, string deptName, string regTag, string wqTag, string frmType, string FbeginDate, string FendDate) {
            return base.Channel.GetBusinessRegData(businessMan, beginRegDate, endRegDate, companyName, isPayment, regState, wqState, deptName, regTag, wqTag, frmType, FbeginDate, FendDate);
        }
        
        public System.Data.DataSet GetBusinessRegDataEdit(string businessMan, string beginRegDate, string endRegDate, string companyName, string isPayment, string regState, string wqState, string deptName, string regTag, string wqTag, string frmType, string regWC, string fBeginDate, string fEndDate) {
            return base.Channel.GetBusinessRegDataEdit(businessMan, beginRegDate, endRegDate, companyName, isPayment, regState, wqState, deptName, regTag, wqTag, frmType, regWC, fBeginDate, fEndDate);
        }
        
        public System.Data.DataSet GetBusinessRegByID(string TW_BusinessRegID) {
            return base.Channel.GetBusinessRegByID(TW_BusinessRegID);
        }
        
        public System.Data.DataSet GetBusinessExamineData(string businessMan, string beginRegDate, string endRegDate, string companyName, string isPayment, string regState, string wqState, string deptName, string regTag, string wqTag, string isExamine) {
            return base.Channel.GetBusinessExamineData(businessMan, beginRegDate, endRegDate, companyName, isPayment, regState, wqState, deptName, regTag, wqTag, isExamine);
        }
        
        public System.Data.DataSet GetNoPaymentReg(string accountant, string gsName, string isPayment) {
            return base.Channel.GetNoPaymentReg(accountant, gsName, isPayment);
        }
        
        public void SavePayment(System.Data.DataSet dst) {
            base.Channel.SavePayment(dst);
        }
        
        public System.Data.DataSet GetPayment(string paymentID) {
            return base.Channel.GetPayment(paymentID);
        }
        
        public System.Data.DataSet GetPaymentByInfo(string unitName, string account, string beginDate, string endDate, string paymentType, string endPaymentDate, string manager, string isPay, string zeroAccount) {
            return base.Channel.GetPaymentByInfo(unitName, account, beginDate, endDate, paymentType, endPaymentDate, manager, isPay, zeroAccount);
        }
        
        public System.Data.DataSet GetPaymentByInfoSP(string spType, string unitName, string account, string beginDate, string endDate, string paymentType, string endPaymentDate, string isPay, string zeroAccount, string bcdqDate1, string bcdqDate2, string cszzDate1, string cszzDate2) {
            return base.Channel.GetPaymentByInfoSP(spType, unitName, account, beginDate, endDate, paymentType, endPaymentDate, isPay, zeroAccount, bcdqDate1, bcdqDate2, cszzDate1, cszzDate2);
        }
        
        public System.Data.DataSet GetPaymentDetailID(string paymentID) {
            return base.Channel.GetPaymentDetailID(paymentID);
        }
        
        public System.Data.DataSet GetBusinessSum(string businessID, int year, int month) {
            return base.Channel.GetBusinessSum(businessID, year, month);
        }
        
        public System.Data.DataSet GetBusinessSum2021(string businessID, int year, int month) {
            return base.Channel.GetBusinessSum2021(businessID, year, month);
        }
        
        public System.Data.DataSet GetBusinessSumCZB2021(string businessID, int year, int month) {
            return base.Channel.GetBusinessSumCZB2021(businessID, year, month);
        }
        
        public System.Data.DataSet GetBusinessSumYCX2021(string businessID, int year, int month) {
            return base.Channel.GetBusinessSumYCX2021(businessID, year, month);
        }
        
        public System.Data.DataSet GetAllBusinessSum(int year, int month, string userManagerID, string userName) {
            return base.Channel.GetAllBusinessSum(year, month, userManagerID, userName);
        }
        
        public System.Data.DataSet GetAllBusinessSumZC(int year, int month, string userManagerID, string userName) {
            return base.Channel.GetAllBusinessSumZC(year, month, userManagerID, userName);
        }
        
        public System.Data.DataSet GetAllBusinessSum2021(int year, int month, string userManagerID, string userName) {
            return base.Channel.GetAllBusinessSum2021(year, month, userManagerID, userName);
        }
        
        public System.Data.DataSet GetAllBusinessSumZC2021(int year, int month, string userManagerID, string userName) {
            return base.Channel.GetAllBusinessSumZC2021(year, month, userManagerID, userName);
        }
        
        public System.Data.DataSet GetAllBusinessSumOther(int year, int month, string userManagerID, string userName, string deptid) {
            return base.Channel.GetAllBusinessSumOther(year, month, userManagerID, userName, deptid);
        }
        
        public System.Data.DataSet GetAllBusinessSumOther2021(int year, int month, string userManagerID, string userName, string deptId) {
            return base.Channel.GetAllBusinessSumOther2021(year, month, userManagerID, userName, deptId);
        }
        
        public System.Data.DataSet GetBussinessManagerDept(string businessID) {
            return base.Channel.GetBussinessManagerDept(businessID);
        }
        
        public System.Data.DataSet GetBussinessSumByYear(int Year, string businessManID) {
            return base.Channel.GetBussinessSumByYear(Year, businessManID);
        }
        
        public System.Data.DataSet GetBusinessLastYear(int year, string userName) {
            return base.Channel.GetBusinessLastYear(year, userName);
        }
        
        public System.Data.DataSet GetRegSum(int year, int month, string userName) {
            return base.Channel.GetRegSum(year, month, userName);
        }
        
        public System.Data.DataSet GetRegSum2021(int year, int month, string userName) {
            return base.Channel.GetRegSum2021(year, month, userName);
        }
        
        public System.Data.DataSet GetRegSumDetail(int year, int month, string userID) {
            return base.Channel.GetRegSumDetail(year, month, userID);
        }
        
        public System.Data.DataSet GetAccountantSum(int year, int month, string userName, string deptid) {
            return base.Channel.GetAccountantSum(year, month, userName, deptid);
        }
        
        public System.Data.DataSet GetAccountantSum2021(int year, int month, string userName, string deptid) {
            return base.Channel.GetAccountantSum2021(year, month, userName, deptid);
        }
        
        public System.Data.DataSet GetAccountantSumDetail(int year, int month, string userID) {
            return base.Channel.GetAccountantSumDetail(year, month, userID);
        }
        
        public System.Data.DataSet GetAccountantDetail(int year, int month, string deptid) {
            return base.Channel.GetAccountantDetail(year, month, deptid);
        }
        
        public System.Data.DataSet GetLSBAccountantDetail(int year, int month) {
            return base.Channel.GetLSBAccountantDetail(year, month);
        }
        
        public void UpdateYWY() {
            base.Channel.UpdateYWY();
        }
        
        public void UpdateClient() {
            base.Channel.UpdateClient();
        }
    }
}
