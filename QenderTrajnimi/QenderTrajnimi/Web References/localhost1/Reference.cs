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

namespace QenderTrajnimi.localhost1 {
    using System.Diagnostics;
    using System;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System.Web.Services;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="faxSoap", Namespace="http://www.webserviceX.NET")]
    public partial class fax : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback SendTextToFaxOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public fax() {
            this.Url = global::QenderTrajnimi.Properties.Settings.Default.QenderTrajnimi_localhost1_fax;
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
        public event SendTextToFaxCompletedEventHandler SendTextToFaxCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.webserviceX.NET/SendTextToFax", RequestNamespace="http://www.webserviceX.NET", ResponseNamespace="http://www.webserviceX.NET", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string SendTextToFax(string FromEmail, string Subject, string FaxNumber, string BodyText, string ToName) {
            object[] results = this.Invoke("SendTextToFax", new object[] {
                        FromEmail,
                        Subject,
                        FaxNumber,
                        BodyText,
                        ToName});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void SendTextToFaxAsync(string FromEmail, string Subject, string FaxNumber, string BodyText, string ToName) {
            this.SendTextToFaxAsync(FromEmail, Subject, FaxNumber, BodyText, ToName, null);
        }
        
        /// <remarks/>
        public void SendTextToFaxAsync(string FromEmail, string Subject, string FaxNumber, string BodyText, string ToName, object userState) {
            if ((this.SendTextToFaxOperationCompleted == null)) {
                this.SendTextToFaxOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSendTextToFaxOperationCompleted);
            }
            this.InvokeAsync("SendTextToFax", new object[] {
                        FromEmail,
                        Subject,
                        FaxNumber,
                        BodyText,
                        ToName}, this.SendTextToFaxOperationCompleted, userState);
        }
        
        private void OnSendTextToFaxOperationCompleted(object arg) {
            if ((this.SendTextToFaxCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SendTextToFaxCompleted(this, new SendTextToFaxCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    public delegate void SendTextToFaxCompletedEventHandler(object sender, SendTextToFaxCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SendTextToFaxCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SendTextToFaxCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
}

#pragma warning restore 1591