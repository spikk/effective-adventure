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

namespace NavWindowApp.localhost {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1567.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="WebService1Soap", Namespace="http://tempuri.org/")]
    public partial class WebService1 : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetEmployeesOperationCompleted;
        
        private System.Threading.SendOrPostCallback ShowAllEmployeesListDALOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetEmployeesListOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public WebService1() {
            this.Url = global::NavWindowApp.Properties.Settings.Default.NavWindowApp_localhost_WebService1;
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
        public event GetEmployeesCompletedEventHandler GetEmployeesCompleted;
        
        /// <remarks/>
        public event ShowAllEmployeesListDALCompletedEventHandler ShowAllEmployeesListDALCompleted;
        
        /// <remarks/>
        public event GetEmployeesListCompletedEventHandler GetEmployeesListCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetEmployees", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string[] GetEmployees() {
            object[] results = this.Invoke("GetEmployees", new object[0]);
            return ((string[])(results[0]));
        }
        
        /// <remarks/>
        public void GetEmployeesAsync() {
            this.GetEmployeesAsync(null);
        }
        
        /// <remarks/>
        public void GetEmployeesAsync(object userState) {
            if ((this.GetEmployeesOperationCompleted == null)) {
                this.GetEmployeesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetEmployeesOperationCompleted);
            }
            this.InvokeAsync("GetEmployees", new object[0], this.GetEmployeesOperationCompleted, userState);
        }
        
        private void OnGetEmployeesOperationCompleted(object arg) {
            if ((this.GetEmployeesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetEmployeesCompleted(this, new GetEmployeesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ShowAllEmployeesListDAL", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public EmployeeModel[] ShowAllEmployeesListDAL() {
            object[] results = this.Invoke("ShowAllEmployeesListDAL", new object[0]);
            return ((EmployeeModel[])(results[0]));
        }
        
        /// <remarks/>
        public void ShowAllEmployeesListDALAsync() {
            this.ShowAllEmployeesListDALAsync(null);
        }
        
        /// <remarks/>
        public void ShowAllEmployeesListDALAsync(object userState) {
            if ((this.ShowAllEmployeesListDALOperationCompleted == null)) {
                this.ShowAllEmployeesListDALOperationCompleted = new System.Threading.SendOrPostCallback(this.OnShowAllEmployeesListDALOperationCompleted);
            }
            this.InvokeAsync("ShowAllEmployeesListDAL", new object[0], this.ShowAllEmployeesListDALOperationCompleted, userState);
        }
        
        private void OnShowAllEmployeesListDALOperationCompleted(object arg) {
            if ((this.ShowAllEmployeesListDALCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ShowAllEmployeesListDALCompleted(this, new ShowAllEmployeesListDALCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetEmployeesList", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayItemAttribute("ArrayOfString")]
        [return: System.Xml.Serialization.XmlArrayItemAttribute(NestingLevel=1)]
        public string[][] GetEmployeesList() {
            object[] results = this.Invoke("GetEmployeesList", new object[0]);
            return ((string[][])(results[0]));
        }
        
        /// <remarks/>
        public void GetEmployeesListAsync() {
            this.GetEmployeesListAsync(null);
        }
        
        /// <remarks/>
        public void GetEmployeesListAsync(object userState) {
            if ((this.GetEmployeesListOperationCompleted == null)) {
                this.GetEmployeesListOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetEmployeesListOperationCompleted);
            }
            this.InvokeAsync("GetEmployeesList", new object[0], this.GetEmployeesListOperationCompleted, userState);
        }
        
        private void OnGetEmployeesListOperationCompleted(object arg) {
            if ((this.GetEmployeesListCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetEmployeesListCompleted(this, new GetEmployeesListCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1567.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class EmployeeModel {
        
        private string timestampField;
        
        private string employee_No_Field;
        
        private string first_NameField;
        
        private string middle_NameField;
        
        private string last_NameField;
        
        private string initialsField;
        
        private string job_TitleField;
        
        private string search_NameField;
        
        private string addressField;
        
        private string address_2Field;
        
        private string cityField;
        
        private string post_CodeField;
        
        private string countyField;
        
        private string phone_No_Field;
        
        private string mobile_PhoneNo_Field;
        
        private string e_MailField;
        
        private string alt__Address_CodeField;
        
        private System.DateTime alt__Address_Start_DateField;
        
        private System.DateTime alt__Address_End_DateField;
        
        private string pictureField;
        
        private System.DateTime birth_DateField;
        
        private string social_Security_No_Field;
        
        private string union_CodeField;
        
        private string union_Membership_No_Field;
        
        private int sexField;
        
        private string country_Region_CodeField;
        
        private string manager_No_Field;
        
        private string emplymt__Contract_CodeField;
        
        private string statistics_Group_CodeField;
        
        private System.DateTime employment_DateField;
        
        private int statusField;
        
        private System.DateTime inactive_DateField;
        
        private string cause_of_Inactivity_CodeField;
        
        private System.DateTime termination_DateField;
        
        private string grounds_for_Term__CodeField;
        
        private string global_Dimension_1_CodeField;
        
        private string global_Dimension_2_CodeField;
        
        private string resource_No_Field;
        
        private System.DateTime last_Date_ModifiedField;
        
        private string extensionField;
        
        private string pagerField;
        
        private string fax_No_Field;
        
        private string company_E_MailField;
        
        private string titleField;
        
        private string salespers__Purch__CodeField;
        
        private string no__SeriesField;
        
        /// <remarks/>
        public string timestamp {
            get {
                return this.timestampField;
            }
            set {
                this.timestampField = value;
            }
        }
        
        /// <remarks/>
        public string Employee_No_ {
            get {
                return this.employee_No_Field;
            }
            set {
                this.employee_No_Field = value;
            }
        }
        
        /// <remarks/>
        public string First_Name {
            get {
                return this.first_NameField;
            }
            set {
                this.first_NameField = value;
            }
        }
        
        /// <remarks/>
        public string Middle_Name {
            get {
                return this.middle_NameField;
            }
            set {
                this.middle_NameField = value;
            }
        }
        
        /// <remarks/>
        public string Last_Name {
            get {
                return this.last_NameField;
            }
            set {
                this.last_NameField = value;
            }
        }
        
        /// <remarks/>
        public string Initials {
            get {
                return this.initialsField;
            }
            set {
                this.initialsField = value;
            }
        }
        
        /// <remarks/>
        public string Job_Title {
            get {
                return this.job_TitleField;
            }
            set {
                this.job_TitleField = value;
            }
        }
        
        /// <remarks/>
        public string Search_Name {
            get {
                return this.search_NameField;
            }
            set {
                this.search_NameField = value;
            }
        }
        
        /// <remarks/>
        public string Address {
            get {
                return this.addressField;
            }
            set {
                this.addressField = value;
            }
        }
        
        /// <remarks/>
        public string Address_2 {
            get {
                return this.address_2Field;
            }
            set {
                this.address_2Field = value;
            }
        }
        
        /// <remarks/>
        public string City {
            get {
                return this.cityField;
            }
            set {
                this.cityField = value;
            }
        }
        
        /// <remarks/>
        public string Post_Code {
            get {
                return this.post_CodeField;
            }
            set {
                this.post_CodeField = value;
            }
        }
        
        /// <remarks/>
        public string County {
            get {
                return this.countyField;
            }
            set {
                this.countyField = value;
            }
        }
        
        /// <remarks/>
        public string Phone_No_ {
            get {
                return this.phone_No_Field;
            }
            set {
                this.phone_No_Field = value;
            }
        }
        
        /// <remarks/>
        public string Mobile_PhoneNo_ {
            get {
                return this.mobile_PhoneNo_Field;
            }
            set {
                this.mobile_PhoneNo_Field = value;
            }
        }
        
        /// <remarks/>
        public string E_Mail {
            get {
                return this.e_MailField;
            }
            set {
                this.e_MailField = value;
            }
        }
        
        /// <remarks/>
        public string Alt__Address_Code {
            get {
                return this.alt__Address_CodeField;
            }
            set {
                this.alt__Address_CodeField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime Alt__Address_Start_Date {
            get {
                return this.alt__Address_Start_DateField;
            }
            set {
                this.alt__Address_Start_DateField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime Alt__Address_End_Date {
            get {
                return this.alt__Address_End_DateField;
            }
            set {
                this.alt__Address_End_DateField = value;
            }
        }
        
        /// <remarks/>
        public string Picture {
            get {
                return this.pictureField;
            }
            set {
                this.pictureField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime Birth_Date {
            get {
                return this.birth_DateField;
            }
            set {
                this.birth_DateField = value;
            }
        }
        
        /// <remarks/>
        public string Social_Security_No_ {
            get {
                return this.social_Security_No_Field;
            }
            set {
                this.social_Security_No_Field = value;
            }
        }
        
        /// <remarks/>
        public string Union_Code {
            get {
                return this.union_CodeField;
            }
            set {
                this.union_CodeField = value;
            }
        }
        
        /// <remarks/>
        public string Union_Membership_No_ {
            get {
                return this.union_Membership_No_Field;
            }
            set {
                this.union_Membership_No_Field = value;
            }
        }
        
        /// <remarks/>
        public int Sex {
            get {
                return this.sexField;
            }
            set {
                this.sexField = value;
            }
        }
        
        /// <remarks/>
        public string Country_Region_Code {
            get {
                return this.country_Region_CodeField;
            }
            set {
                this.country_Region_CodeField = value;
            }
        }
        
        /// <remarks/>
        public string Manager_No_ {
            get {
                return this.manager_No_Field;
            }
            set {
                this.manager_No_Field = value;
            }
        }
        
        /// <remarks/>
        public string Emplymt__Contract_Code {
            get {
                return this.emplymt__Contract_CodeField;
            }
            set {
                this.emplymt__Contract_CodeField = value;
            }
        }
        
        /// <remarks/>
        public string Statistics_Group_Code {
            get {
                return this.statistics_Group_CodeField;
            }
            set {
                this.statistics_Group_CodeField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime Employment_Date {
            get {
                return this.employment_DateField;
            }
            set {
                this.employment_DateField = value;
            }
        }
        
        /// <remarks/>
        public int Status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime Inactive_Date {
            get {
                return this.inactive_DateField;
            }
            set {
                this.inactive_DateField = value;
            }
        }
        
        /// <remarks/>
        public string Cause_of_Inactivity_Code {
            get {
                return this.cause_of_Inactivity_CodeField;
            }
            set {
                this.cause_of_Inactivity_CodeField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime Termination_Date {
            get {
                return this.termination_DateField;
            }
            set {
                this.termination_DateField = value;
            }
        }
        
        /// <remarks/>
        public string Grounds_for_Term__Code {
            get {
                return this.grounds_for_Term__CodeField;
            }
            set {
                this.grounds_for_Term__CodeField = value;
            }
        }
        
        /// <remarks/>
        public string Global_Dimension_1_Code {
            get {
                return this.global_Dimension_1_CodeField;
            }
            set {
                this.global_Dimension_1_CodeField = value;
            }
        }
        
        /// <remarks/>
        public string Global_Dimension_2_Code {
            get {
                return this.global_Dimension_2_CodeField;
            }
            set {
                this.global_Dimension_2_CodeField = value;
            }
        }
        
        /// <remarks/>
        public string Resource_No_ {
            get {
                return this.resource_No_Field;
            }
            set {
                this.resource_No_Field = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime Last_Date_Modified {
            get {
                return this.last_Date_ModifiedField;
            }
            set {
                this.last_Date_ModifiedField = value;
            }
        }
        
        /// <remarks/>
        public string Extension {
            get {
                return this.extensionField;
            }
            set {
                this.extensionField = value;
            }
        }
        
        /// <remarks/>
        public string Pager {
            get {
                return this.pagerField;
            }
            set {
                this.pagerField = value;
            }
        }
        
        /// <remarks/>
        public string Fax_No_ {
            get {
                return this.fax_No_Field;
            }
            set {
                this.fax_No_Field = value;
            }
        }
        
        /// <remarks/>
        public string Company_E_Mail {
            get {
                return this.company_E_MailField;
            }
            set {
                this.company_E_MailField = value;
            }
        }
        
        /// <remarks/>
        public string Title {
            get {
                return this.titleField;
            }
            set {
                this.titleField = value;
            }
        }
        
        /// <remarks/>
        public string Salespers__Purch__Code {
            get {
                return this.salespers__Purch__CodeField;
            }
            set {
                this.salespers__Purch__CodeField = value;
            }
        }
        
        /// <remarks/>
        public string No__Series {
            get {
                return this.no__SeriesField;
            }
            set {
                this.no__SeriesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1567.0")]
    public delegate void GetEmployeesCompletedEventHandler(object sender, GetEmployeesCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1567.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetEmployeesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetEmployeesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1567.0")]
    public delegate void ShowAllEmployeesListDALCompletedEventHandler(object sender, ShowAllEmployeesListDALCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1567.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ShowAllEmployeesListDALCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ShowAllEmployeesListDALCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public EmployeeModel[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((EmployeeModel[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1567.0")]
    public delegate void GetEmployeesListCompletedEventHandler(object sender, GetEmployeesListCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1567.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetEmployeesListCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetEmployeesListCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string[][] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string[][])(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591