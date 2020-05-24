﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Этот исходный текст был создан автоматически: Microsoft.VSDesigner, версия: 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace EmailRegistrationUi.EmailRegistrationWebService {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="WebServiceSoap", Namespace="http://microsoft.com/webservices/")]
    public partial class WebService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback AddNewEmailOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetAllEmailsOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetEmailInIdOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetEmailPeriodDateOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetEmailToOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetEmailFromOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetEmailTagOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public WebService() {
            this.Url = global::EmailRegistrationUi.Properties.Settings.Default.EmailRegistrationUi_EmailRegistrationWebService_WebService;
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
        public event AddNewEmailCompletedEventHandler AddNewEmailCompleted;
        
        /// <remarks/>
        public event GetAllEmailsCompletedEventHandler GetAllEmailsCompleted;
        
        /// <remarks/>
        public event GetEmailInIdCompletedEventHandler GetEmailInIdCompleted;
        
        /// <remarks/>
        public event GetEmailPeriodDateCompletedEventHandler GetEmailPeriodDateCompleted;
        
        /// <remarks/>
        public event GetEmailToCompletedEventHandler GetEmailToCompleted;
        
        /// <remarks/>
        public event GetEmailFromCompletedEventHandler GetEmailFromCompleted;
        
        /// <remarks/>
        public event GetEmailTagCompletedEventHandler GetEmailTagCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://microsoft.com/webservices/AddNewEmail", RequestNamespace="http://microsoft.com/webservices/", ResponseNamespace="http://microsoft.com/webservices/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int AddNewEmail(string emailName, System.DateTime emailRegistrationDate, string emailTo, string emailFrom, string emailTag, string emailContent) {
            object[] results = this.Invoke("AddNewEmail", new object[] {
                        emailName,
                        emailRegistrationDate,
                        emailTo,
                        emailFrom,
                        emailTag,
                        emailContent});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void AddNewEmailAsync(string emailName, System.DateTime emailRegistrationDate, string emailTo, string emailFrom, string emailTag, string emailContent) {
            this.AddNewEmailAsync(emailName, emailRegistrationDate, emailTo, emailFrom, emailTag, emailContent, null);
        }
        
        /// <remarks/>
        public void AddNewEmailAsync(string emailName, System.DateTime emailRegistrationDate, string emailTo, string emailFrom, string emailTag, string emailContent, object userState) {
            if ((this.AddNewEmailOperationCompleted == null)) {
                this.AddNewEmailOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAddNewEmailOperationCompleted);
            }
            this.InvokeAsync("AddNewEmail", new object[] {
                        emailName,
                        emailRegistrationDate,
                        emailTo,
                        emailFrom,
                        emailTag,
                        emailContent}, this.AddNewEmailOperationCompleted, userState);
        }
        
        private void OnAddNewEmailOperationCompleted(object arg) {
            if ((this.AddNewEmailCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AddNewEmailCompleted(this, new AddNewEmailCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://microsoft.com/webservices/GetAllEmails", RequestNamespace="http://microsoft.com/webservices/", ResponseNamespace="http://microsoft.com/webservices/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Email[] GetAllEmails() {
            object[] results = this.Invoke("GetAllEmails", new object[0]);
            return ((Email[])(results[0]));
        }
        
        /// <remarks/>
        public void GetAllEmailsAsync() {
            this.GetAllEmailsAsync(null);
        }
        
        /// <remarks/>
        public void GetAllEmailsAsync(object userState) {
            if ((this.GetAllEmailsOperationCompleted == null)) {
                this.GetAllEmailsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetAllEmailsOperationCompleted);
            }
            this.InvokeAsync("GetAllEmails", new object[0], this.GetAllEmailsOperationCompleted, userState);
        }
        
        private void OnGetAllEmailsOperationCompleted(object arg) {
            if ((this.GetAllEmailsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetAllEmailsCompleted(this, new GetAllEmailsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://microsoft.com/webservices/GetEmailInId", RequestNamespace="http://microsoft.com/webservices/", ResponseNamespace="http://microsoft.com/webservices/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Email GetEmailInId(int emailId) {
            object[] results = this.Invoke("GetEmailInId", new object[] {
                        emailId});
            return ((Email)(results[0]));
        }
        
        /// <remarks/>
        public void GetEmailInIdAsync(int emailId) {
            this.GetEmailInIdAsync(emailId, null);
        }
        
        /// <remarks/>
        public void GetEmailInIdAsync(int emailId, object userState) {
            if ((this.GetEmailInIdOperationCompleted == null)) {
                this.GetEmailInIdOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetEmailInIdOperationCompleted);
            }
            this.InvokeAsync("GetEmailInId", new object[] {
                        emailId}, this.GetEmailInIdOperationCompleted, userState);
        }
        
        private void OnGetEmailInIdOperationCompleted(object arg) {
            if ((this.GetEmailInIdCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetEmailInIdCompleted(this, new GetEmailInIdCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://microsoft.com/webservices/GetEmailPeriodDate", RequestNamespace="http://microsoft.com/webservices/", ResponseNamespace="http://microsoft.com/webservices/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Email[] GetEmailPeriodDate(System.DateTime start, System.DateTime end) {
            object[] results = this.Invoke("GetEmailPeriodDate", new object[] {
                        start,
                        end});
            return ((Email[])(results[0]));
        }
        
        /// <remarks/>
        public void GetEmailPeriodDateAsync(System.DateTime start, System.DateTime end) {
            this.GetEmailPeriodDateAsync(start, end, null);
        }
        
        /// <remarks/>
        public void GetEmailPeriodDateAsync(System.DateTime start, System.DateTime end, object userState) {
            if ((this.GetEmailPeriodDateOperationCompleted == null)) {
                this.GetEmailPeriodDateOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetEmailPeriodDateOperationCompleted);
            }
            this.InvokeAsync("GetEmailPeriodDate", new object[] {
                        start,
                        end}, this.GetEmailPeriodDateOperationCompleted, userState);
        }
        
        private void OnGetEmailPeriodDateOperationCompleted(object arg) {
            if ((this.GetEmailPeriodDateCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetEmailPeriodDateCompleted(this, new GetEmailPeriodDateCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://microsoft.com/webservices/GetEmailTo", RequestNamespace="http://microsoft.com/webservices/", ResponseNamespace="http://microsoft.com/webservices/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Email[] GetEmailTo(string emailTo) {
            object[] results = this.Invoke("GetEmailTo", new object[] {
                        emailTo});
            return ((Email[])(results[0]));
        }
        
        /// <remarks/>
        public void GetEmailToAsync(string emailTo) {
            this.GetEmailToAsync(emailTo, null);
        }
        
        /// <remarks/>
        public void GetEmailToAsync(string emailTo, object userState) {
            if ((this.GetEmailToOperationCompleted == null)) {
                this.GetEmailToOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetEmailToOperationCompleted);
            }
            this.InvokeAsync("GetEmailTo", new object[] {
                        emailTo}, this.GetEmailToOperationCompleted, userState);
        }
        
        private void OnGetEmailToOperationCompleted(object arg) {
            if ((this.GetEmailToCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetEmailToCompleted(this, new GetEmailToCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://microsoft.com/webservices/GetEmailFrom", RequestNamespace="http://microsoft.com/webservices/", ResponseNamespace="http://microsoft.com/webservices/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Email[] GetEmailFrom(string emailFrom) {
            object[] results = this.Invoke("GetEmailFrom", new object[] {
                        emailFrom});
            return ((Email[])(results[0]));
        }
        
        /// <remarks/>
        public void GetEmailFromAsync(string emailFrom) {
            this.GetEmailFromAsync(emailFrom, null);
        }
        
        /// <remarks/>
        public void GetEmailFromAsync(string emailFrom, object userState) {
            if ((this.GetEmailFromOperationCompleted == null)) {
                this.GetEmailFromOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetEmailFromOperationCompleted);
            }
            this.InvokeAsync("GetEmailFrom", new object[] {
                        emailFrom}, this.GetEmailFromOperationCompleted, userState);
        }
        
        private void OnGetEmailFromOperationCompleted(object arg) {
            if ((this.GetEmailFromCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetEmailFromCompleted(this, new GetEmailFromCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://microsoft.com/webservices/GetEmailTag", RequestNamespace="http://microsoft.com/webservices/", ResponseNamespace="http://microsoft.com/webservices/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Email[] GetEmailTag(string emailTag) {
            object[] results = this.Invoke("GetEmailTag", new object[] {
                        emailTag});
            return ((Email[])(results[0]));
        }
        
        /// <remarks/>
        public void GetEmailTagAsync(string emailTag) {
            this.GetEmailTagAsync(emailTag, null);
        }
        
        /// <remarks/>
        public void GetEmailTagAsync(string emailTag, object userState) {
            if ((this.GetEmailTagOperationCompleted == null)) {
                this.GetEmailTagOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetEmailTagOperationCompleted);
            }
            this.InvokeAsync("GetEmailTag", new object[] {
                        emailTag}, this.GetEmailTagOperationCompleted, userState);
        }
        
        private void OnGetEmailTagOperationCompleted(object arg) {
            if ((this.GetEmailTagCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetEmailTagCompleted(this, new GetEmailTagCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://microsoft.com/webservices/")]
    public partial class Email {
        
        private int emailIdField;
        
        private string emailNameField;
        
        private System.DateTime emailRegistrationDateField;
        
        private string emailToField;
        
        private string emailFromField;
        
        private string emailTagField;
        
        private string emailContentField;
        
        /// <remarks/>
        public int EmailId {
            get {
                return this.emailIdField;
            }
            set {
                this.emailIdField = value;
            }
        }
        
        /// <remarks/>
        public string EmailName {
            get {
                return this.emailNameField;
            }
            set {
                this.emailNameField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime EmailRegistrationDate {
            get {
                return this.emailRegistrationDateField;
            }
            set {
                this.emailRegistrationDateField = value;
            }
        }
        
        /// <remarks/>
        public string EmailTo {
            get {
                return this.emailToField;
            }
            set {
                this.emailToField = value;
            }
        }
        
        /// <remarks/>
        public string EmailFrom {
            get {
                return this.emailFromField;
            }
            set {
                this.emailFromField = value;
            }
        }
        
        /// <remarks/>
        public string EmailTag {
            get {
                return this.emailTagField;
            }
            set {
                this.emailTagField = value;
            }
        }
        
        /// <remarks/>
        public string EmailContent {
            get {
                return this.emailContentField;
            }
            set {
                this.emailContentField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    public delegate void AddNewEmailCompletedEventHandler(object sender, AddNewEmailCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AddNewEmailCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal AddNewEmailCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    public delegate void GetAllEmailsCompletedEventHandler(object sender, GetAllEmailsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetAllEmailsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetAllEmailsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Email[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Email[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    public delegate void GetEmailInIdCompletedEventHandler(object sender, GetEmailInIdCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetEmailInIdCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetEmailInIdCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Email Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Email)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    public delegate void GetEmailPeriodDateCompletedEventHandler(object sender, GetEmailPeriodDateCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetEmailPeriodDateCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetEmailPeriodDateCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Email[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Email[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    public delegate void GetEmailToCompletedEventHandler(object sender, GetEmailToCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetEmailToCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetEmailToCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Email[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Email[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    public delegate void GetEmailFromCompletedEventHandler(object sender, GetEmailFromCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetEmailFromCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetEmailFromCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Email[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Email[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    public delegate void GetEmailTagCompletedEventHandler(object sender, GetEmailTagCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetEmailTagCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetEmailTagCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Email[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Email[])(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591