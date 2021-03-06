﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace EAMUI.TrhWS {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="WebServiceSoap", Namespace="http://richmondhill.local/")]
    public partial class WebService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback HelloWorldOperationCompleted;
        
        private System.Threading.SendOrPostCallback getADUserInfoOperationCompleted;
        
        private System.Threading.SendOrPostCallback getAllADUserInfofromDeptOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public WebService() {
            this.Url = global::EAMUI.Properties.Settings.Default.EAMUI_TrhWS_WebService;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event HelloWorldCompletedEventHandler HelloWorldCompleted;
        
        /// <remarks/>
        public event getADUserInfoCompletedEventHandler getADUserInfoCompleted;
        
        /// <remarks/>
        public event getAllADUserInfofromDeptCompletedEventHandler getAllADUserInfofromDeptCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://richmondhill.local/HelloWorld", RequestNamespace="http://richmondhill.local/", ResponseNamespace="http://richmondhill.local/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string HelloWorld(string inputStr) {
            object[] results = this.Invoke("HelloWorld", new object[] {
                        inputStr});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void HelloWorldAsync(string inputStr) {
            this.HelloWorldAsync(inputStr, null);
        }
        
        /// <remarks/>
        public void HelloWorldAsync(string inputStr, object userState) {
            if ((this.HelloWorldOperationCompleted == null)) {
                this.HelloWorldOperationCompleted = new System.Threading.SendOrPostCallback(this.OnHelloWorldOperationCompleted);
            }
            this.InvokeAsync("HelloWorld", new object[] {
                        inputStr}, this.HelloWorldOperationCompleted, userState);
        }
        
        private void OnHelloWorldOperationCompleted(object arg) {
            if ((this.HelloWorldCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.HelloWorldCompleted(this, new HelloWorldCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://richmondhill.local/getADUserInfo", RequestNamespace="http://richmondhill.local/", ResponseNamespace="http://richmondhill.local/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public UserInfo[] getADUserInfo(string start) {
            object[] results = this.Invoke("getADUserInfo", new object[] {
                        start});
            return ((UserInfo[])(results[0]));
        }
        
        /// <remarks/>
        public void getADUserInfoAsync(string start) {
            this.getADUserInfoAsync(start, null);
        }
        
        /// <remarks/>
        public void getADUserInfoAsync(string start, object userState) {
            if ((this.getADUserInfoOperationCompleted == null)) {
                this.getADUserInfoOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetADUserInfoOperationCompleted);
            }
            this.InvokeAsync("getADUserInfo", new object[] {
                        start}, this.getADUserInfoOperationCompleted, userState);
        }
        
        private void OngetADUserInfoOperationCompleted(object arg) {
            if ((this.getADUserInfoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getADUserInfoCompleted(this, new getADUserInfoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://richmondhill.local/getAllADUserInfofromDept", RequestNamespace="http://richmondhill.local/", ResponseNamespace="http://richmondhill.local/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public UserInfo[] getAllADUserInfofromDept(string deptdiv) {
            object[] results = this.Invoke("getAllADUserInfofromDept", new object[] {
                        deptdiv});
            return ((UserInfo[])(results[0]));
        }
        
        /// <remarks/>
        public void getAllADUserInfofromDeptAsync(string deptdiv) {
            this.getAllADUserInfofromDeptAsync(deptdiv, null);
        }
        
        /// <remarks/>
        public void getAllADUserInfofromDeptAsync(string deptdiv, object userState) {
            if ((this.getAllADUserInfofromDeptOperationCompleted == null)) {
                this.getAllADUserInfofromDeptOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetAllADUserInfofromDeptOperationCompleted);
            }
            this.InvokeAsync("getAllADUserInfofromDept", new object[] {
                        deptdiv}, this.getAllADUserInfofromDeptOperationCompleted, userState);
        }
        
        private void OngetAllADUserInfofromDeptOperationCompleted(object arg) {
            if ((this.getAllADUserInfofromDeptCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getAllADUserInfofromDeptCompleted(this, new getAllADUserInfofromDeptCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3190.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://richmondhill.local/")]
    public partial class UserInfo {
        
        private string firstNameField;
        
        private string lastNameField;
        
        private string companyField;
        
        private string departmentField;
        
        private string divisionField;
        
        private string phoneField;
        
        private string managerField;
        
        private string mobileField;
        
        private string streetAddressField;
        
        private string titleField;
        
        private string samAccountNameField;
        
        private string displayNameField;
        
        private string mailField;
        
        private string streetField;
        
        private string officeField;
        
        private string postalCodeField;
        
        private string facsimileTelephoneNumberField;
        
        private string telephoneNumberField;
        
        private string otherPhoneField;
        
        private byte[] thumbnailPhotoField;
        
        private string distinguishedNameField;
        
        /// <remarks/>
        public string firstName {
            get {
                return this.firstNameField;
            }
            set {
                this.firstNameField = value;
            }
        }
        
        /// <remarks/>
        public string lastName {
            get {
                return this.lastNameField;
            }
            set {
                this.lastNameField = value;
            }
        }
        
        /// <remarks/>
        public string company {
            get {
                return this.companyField;
            }
            set {
                this.companyField = value;
            }
        }
        
        /// <remarks/>
        public string department {
            get {
                return this.departmentField;
            }
            set {
                this.departmentField = value;
            }
        }
        
        /// <remarks/>
        public string division {
            get {
                return this.divisionField;
            }
            set {
                this.divisionField = value;
            }
        }
        
        /// <remarks/>
        public string phone {
            get {
                return this.phoneField;
            }
            set {
                this.phoneField = value;
            }
        }
        
        /// <remarks/>
        public string manager {
            get {
                return this.managerField;
            }
            set {
                this.managerField = value;
            }
        }
        
        /// <remarks/>
        public string mobile {
            get {
                return this.mobileField;
            }
            set {
                this.mobileField = value;
            }
        }
        
        /// <remarks/>
        public string streetAddress {
            get {
                return this.streetAddressField;
            }
            set {
                this.streetAddressField = value;
            }
        }
        
        /// <remarks/>
        public string title {
            get {
                return this.titleField;
            }
            set {
                this.titleField = value;
            }
        }
        
        /// <remarks/>
        public string samAccountName {
            get {
                return this.samAccountNameField;
            }
            set {
                this.samAccountNameField = value;
            }
        }
        
        /// <remarks/>
        public string displayName {
            get {
                return this.displayNameField;
            }
            set {
                this.displayNameField = value;
            }
        }
        
        /// <remarks/>
        public string mail {
            get {
                return this.mailField;
            }
            set {
                this.mailField = value;
            }
        }
        
        /// <remarks/>
        public string street {
            get {
                return this.streetField;
            }
            set {
                this.streetField = value;
            }
        }
        
        /// <remarks/>
        public string office {
            get {
                return this.officeField;
            }
            set {
                this.officeField = value;
            }
        }
        
        /// <remarks/>
        public string postalCode {
            get {
                return this.postalCodeField;
            }
            set {
                this.postalCodeField = value;
            }
        }
        
        /// <remarks/>
        public string facsimileTelephoneNumber {
            get {
                return this.facsimileTelephoneNumberField;
            }
            set {
                this.facsimileTelephoneNumberField = value;
            }
        }
        
        /// <remarks/>
        public string telephoneNumber {
            get {
                return this.telephoneNumberField;
            }
            set {
                this.telephoneNumberField = value;
            }
        }
        
        /// <remarks/>
        public string otherPhone {
            get {
                return this.otherPhoneField;
            }
            set {
                this.otherPhoneField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] thumbnailPhoto {
            get {
                return this.thumbnailPhotoField;
            }
            set {
                this.thumbnailPhotoField = value;
            }
        }
        
        /// <remarks/>
        public string distinguishedName {
            get {
                return this.distinguishedNameField;
            }
            set {
                this.distinguishedNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    public delegate void HelloWorldCompletedEventHandler(object sender, HelloWorldCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class HelloWorldCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal HelloWorldCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    public delegate void getADUserInfoCompletedEventHandler(object sender, getADUserInfoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getADUserInfoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getADUserInfoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public UserInfo[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((UserInfo[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    public delegate void getAllADUserInfofromDeptCompletedEventHandler(object sender, getAllADUserInfofromDeptCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getAllADUserInfofromDeptCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getAllADUserInfofromDeptCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public UserInfo[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((UserInfo[])(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591