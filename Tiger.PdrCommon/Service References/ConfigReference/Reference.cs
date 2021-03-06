﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tiger.PdrCommon.ConfigReference {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ConfigReference.ConfigSoap")]
    public interface ConfigSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetUserInfo", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetUserInfo(string p_strUserID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Login", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet Login(string p_strLogName, string p_strPassword);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SaveTable", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void SaveTable(System.Data.DataSet p_ds, string p_strTableName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetSystemFunction", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetSystemFunction();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetSystemFunctionByUser", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetSystemFunctionByUser(string p_strUserID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetSystemMenu", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetSystemMenu();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetSystemMenuByParent", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetSystemMenuByParent(string p_strParentMenuName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetSystemMenubyUser", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetSystemMenubyUser(string p_strUserID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetSystemCSMenuByUser", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetSystemCSMenuByUser(string userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetSystemRoot", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetSystemRoot(string p_strUserID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetCommonDateSet", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetCommonDateSet(string strSql);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ExeCommonSql", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int ExeCommonSql(string strSql);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetTCONF_WORDData", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetTCONF_WORDData(string groupName, string word);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ConfigSoapChannel : Tiger.PdrCommon.ConfigReference.ConfigSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ConfigSoapClient : System.ServiceModel.ClientBase<Tiger.PdrCommon.ConfigReference.ConfigSoap>, Tiger.PdrCommon.ConfigReference.ConfigSoap {
        
        public ConfigSoapClient() {
        }
        
        public ConfigSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ConfigSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ConfigSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ConfigSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet GetUserInfo(string p_strUserID) {
            return base.Channel.GetUserInfo(p_strUserID);
        }
        
        public System.Data.DataSet Login(string p_strLogName, string p_strPassword) {
            return base.Channel.Login(p_strLogName, p_strPassword);
        }
        
        public void SaveTable(System.Data.DataSet p_ds, string p_strTableName) {
            base.Channel.SaveTable(p_ds, p_strTableName);
        }
        
        public System.Data.DataSet GetSystemFunction() {
            return base.Channel.GetSystemFunction();
        }
        
        public System.Data.DataSet GetSystemFunctionByUser(string p_strUserID) {
            return base.Channel.GetSystemFunctionByUser(p_strUserID);
        }
        
        public System.Data.DataSet GetSystemMenu() {
            return base.Channel.GetSystemMenu();
        }
        
        public System.Data.DataSet GetSystemMenuByParent(string p_strParentMenuName) {
            return base.Channel.GetSystemMenuByParent(p_strParentMenuName);
        }
        
        public System.Data.DataSet GetSystemMenubyUser(string p_strUserID) {
            return base.Channel.GetSystemMenubyUser(p_strUserID);
        }
        
        public System.Data.DataSet GetSystemCSMenuByUser(string userId) {
            return base.Channel.GetSystemCSMenuByUser(userId);
        }
        
        public System.Data.DataSet GetSystemRoot(string p_strUserID) {
            return base.Channel.GetSystemRoot(p_strUserID);
        }
        
        public System.Data.DataSet GetCommonDateSet(string strSql) {
            return base.Channel.GetCommonDateSet(strSql);
        }
        
        public int ExeCommonSql(string strSql) {
            return base.Channel.ExeCommonSql(strSql);
        }
        
        public System.Data.DataSet GetTCONF_WORDData(string groupName, string word) {
            return base.Channel.GetTCONF_WORDData(groupName, word);
        }
    }
}
