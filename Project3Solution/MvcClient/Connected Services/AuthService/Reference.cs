﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcClient.AuthService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Ad", Namespace="http://schemas.datacontract.org/2004/07/Model")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(MvcClient.AuthService.Ad[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(MvcClient.AuthService.Post))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(MvcClient.AuthService.User))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(MvcClient.AuthService.Price))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(MvcClient.AuthService.PriceType))]
    public partial class Ad : MvcClient.AuthService.Post {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private object CategoriesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> ExpDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MvcClient.AuthService.Price PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ViewsField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public object Categories {
            get {
                return this.CategoriesField;
            }
            set {
                if ((object.ReferenceEquals(this.CategoriesField, value) != true)) {
                    this.CategoriesField = value;
                    this.RaisePropertyChanged("Categories");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> ExpDate {
            get {
                return this.ExpDateField;
            }
            set {
                if ((this.ExpDateField.Equals(value) != true)) {
                    this.ExpDateField = value;
                    this.RaisePropertyChanged("ExpDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public MvcClient.AuthService.Price Price {
            get {
                return this.PriceField;
            }
            set {
                if ((object.ReferenceEquals(this.PriceField, value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Views {
            get {
                return this.ViewsField;
            }
            set {
                if ((this.ViewsField.Equals(value) != true)) {
                    this.ViewsField = value;
                    this.RaisePropertyChanged("Views");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Post", Namespace="http://schemas.datacontract.org/2004/07/Model")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(MvcClient.AuthService.Ad))]
    public partial class Post : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MvcClient.AuthService.User AuthorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ContentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DatePostedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ImageSourceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> LastEditedField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public MvcClient.AuthService.User Author {
            get {
                return this.AuthorField;
            }
            set {
                if ((object.ReferenceEquals(this.AuthorField, value) != true)) {
                    this.AuthorField = value;
                    this.RaisePropertyChanged("Author");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Content {
            get {
                return this.ContentField;
            }
            set {
                if ((object.ReferenceEquals(this.ContentField, value) != true)) {
                    this.ContentField = value;
                    this.RaisePropertyChanged("Content");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DatePosted {
            get {
                return this.DatePostedField;
            }
            set {
                if ((this.DatePostedField.Equals(value) != true)) {
                    this.DatePostedField = value;
                    this.RaisePropertyChanged("DatePosted");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Id {
            get {
                return this.IdField;
            }
            set {
                if ((object.ReferenceEquals(this.IdField, value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ImageSource {
            get {
                return this.ImageSourceField;
            }
            set {
                if ((object.ReferenceEquals(this.ImageSourceField, value) != true)) {
                    this.ImageSourceField = value;
                    this.RaisePropertyChanged("ImageSource");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> LastEdited {
            get {
                return this.LastEditedField;
            }
            set {
                if ((this.LastEditedField.Equals(value) != true)) {
                    this.LastEditedField = value;
                    this.RaisePropertyChanged("LastEdited");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/Model")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int BoostsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateRegisteredField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] PasswordHashField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PictureURLField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ReservationsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] SaltField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Boosts {
            get {
                return this.BoostsField;
            }
            set {
                if ((this.BoostsField.Equals(value) != true)) {
                    this.BoostsField = value;
                    this.RaisePropertyChanged("Boosts");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DateRegistered {
            get {
                return this.DateRegisteredField;
            }
            set {
                if ((this.DateRegisteredField.Equals(value) != true)) {
                    this.DateRegisteredField = value;
                    this.RaisePropertyChanged("DateRegistered");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Id {
            get {
                return this.IdField;
            }
            set {
                if ((object.ReferenceEquals(this.IdField, value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] PasswordHash {
            get {
                return this.PasswordHashField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordHashField, value) != true)) {
                    this.PasswordHashField = value;
                    this.RaisePropertyChanged("PasswordHash");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PictureURL {
            get {
                return this.PictureURLField;
            }
            set {
                if ((object.ReferenceEquals(this.PictureURLField, value) != true)) {
                    this.PictureURLField = value;
                    this.RaisePropertyChanged("PictureURL");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Reservations {
            get {
                return this.ReservationsField;
            }
            set {
                if ((this.ReservationsField.Equals(value) != true)) {
                    this.ReservationsField = value;
                    this.RaisePropertyChanged("Reservations");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] Salt {
            get {
                return this.SaltField;
            }
            set {
                if ((object.ReferenceEquals(this.SaltField, value) != true)) {
                    this.SaltField = value;
                    this.RaisePropertyChanged("Salt");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Price", Namespace="http://schemas.datacontract.org/2004/07/Model")]
    [System.SerializableAttribute()]
    public partial class Price : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int HighField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int LowField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MvcClient.AuthService.PriceType TypeField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int High {
            get {
                return this.HighField;
            }
            set {
                if ((this.HighField.Equals(value) != true)) {
                    this.HighField = value;
                    this.RaisePropertyChanged("High");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Low {
            get {
                return this.LowField;
            }
            set {
                if ((this.LowField.Equals(value) != true)) {
                    this.LowField = value;
                    this.RaisePropertyChanged("Low");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public MvcClient.AuthService.PriceType Type {
            get {
                return this.TypeField;
            }
            set {
                if ((this.TypeField.Equals(value) != true)) {
                    this.TypeField = value;
                    this.RaisePropertyChanged("Type");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PriceType", Namespace="http://schemas.datacontract.org/2004/07/Model")]
    public enum PriceType : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Range = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Free = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Unspecified = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Bid = 3,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AuthService.IAuthService")]
    public interface IAuthService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthService/Login", ReplyAction="http://tempuri.org/IAuthService/LoginResponse")]
        bool Login(string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthService/Login", ReplyAction="http://tempuri.org/IAuthService/LoginResponse")]
        System.Threading.Tasks.Task<bool> LoginAsync(string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthService/Register", ReplyAction="http://tempuri.org/IAuthService/RegisterResponse")]
        bool Register(string email, string name, string password, string pictureUrl);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthService/Register", ReplyAction="http://tempuri.org/IAuthService/RegisterResponse")]
        System.Threading.Tasks.Task<bool> RegisterAsync(string email, string name, string password, string pictureUrl);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthService/GetAds", ReplyAction="http://tempuri.org/IAuthService/GetAdsResponse")]
        MvcClient.AuthService.Ad[] GetAds(int skip, int amount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthService/GetAds", ReplyAction="http://tempuri.org/IAuthService/GetAdsResponse")]
        System.Threading.Tasks.Task<MvcClient.AuthService.Ad[]> GetAdsAsync(int skip, int amount);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAuthServiceChannel : MvcClient.AuthService.IAuthService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AuthServiceClient : System.ServiceModel.ClientBase<MvcClient.AuthService.IAuthService>, MvcClient.AuthService.IAuthService {
        
        public AuthServiceClient() {
        }
        
        public AuthServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AuthServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AuthServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AuthServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool Login(string email, string password) {
            return base.Channel.Login(email, password);
        }
        
        public System.Threading.Tasks.Task<bool> LoginAsync(string email, string password) {
            return base.Channel.LoginAsync(email, password);
        }
        
        public bool Register(string email, string name, string password, string pictureUrl) {
            return base.Channel.Register(email, name, password, pictureUrl);
        }
        
        public System.Threading.Tasks.Task<bool> RegisterAsync(string email, string name, string password, string pictureUrl) {
            return base.Channel.RegisterAsync(email, name, password, pictureUrl);
        }
        
        public MvcClient.AuthService.Ad[] GetAds(int skip, int amount) {
            return base.Channel.GetAds(skip, amount);
        }
        
        public System.Threading.Tasks.Task<MvcClient.AuthService.Ad[]> GetAdsAsync(int skip, int amount) {
            return base.Channel.GetAdsAsync(skip, amount);
        }
    }
}
