﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcClient.SocialAdService {
    using System.Runtime.Serialization;
    using System;
    
    
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Ad", Namespace="http://schemas.datacontract.org/2004/07/Model")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(MvcClient.SocialAdService.User))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(MvcClient.SocialAdService.User[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(MvcClient.SocialAdService.Ad[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(MvcClient.SocialAdService.Post))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(MvcClient.SocialAdService.Location))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(MvcClient.SocialAdService.LocationType))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(MvcClient.SocialAdService.Price))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(MvcClient.SocialAdService.PriceType))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(MvcClient.SocialAdService.AdType))]
    public partial class Ad : MvcClient.SocialAdService.Post {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private object CategoriesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> EventDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> ExpDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MvcClient.SocialAdService.Location LocationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MvcClient.SocialAdService.Price PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MvcClient.SocialAdService.User ReservedByField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MvcClient.SocialAdService.AdType TypeField;
        
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
        public System.Nullable<System.DateTime> EventDate {
            get {
                return this.EventDateField;
            }
            set {
                if ((this.EventDateField.Equals(value) != true)) {
                    this.EventDateField = value;
                    this.RaisePropertyChanged("EventDate");
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
        public MvcClient.SocialAdService.Location Location {
            get {
                return this.LocationField;
            }
            set {
                if ((object.ReferenceEquals(this.LocationField, value) != true)) {
                    this.LocationField = value;
                    this.RaisePropertyChanged("Location");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public MvcClient.SocialAdService.Price Price {
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
        public MvcClient.SocialAdService.User ReservedBy {
            get {
                return this.ReservedByField;
            }
            set {
                if ((object.ReferenceEquals(this.ReservedByField, value) != true)) {
                    this.ReservedByField = value;
                    this.RaisePropertyChanged("ReservedBy");
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
        public MvcClient.SocialAdService.AdType Type {
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
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(MvcClient.SocialAdService.Ad))]
    public partial class Post : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MvcClient.SocialAdService.User AuthorField;
        
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
        public MvcClient.SocialAdService.User Author {
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Location", Namespace="http://schemas.datacontract.org/2004/07/Model")]
    [System.SerializableAttribute()]
    public partial class Location : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MvcClient.SocialAdService.Location ParentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MvcClient.SocialAdService.LocationType TypeField;
        
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
        public MvcClient.SocialAdService.Location Parent {
            get {
                return this.ParentField;
            }
            set {
                if ((object.ReferenceEquals(this.ParentField, value) != true)) {
                    this.ParentField = value;
                    this.RaisePropertyChanged("Parent");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public MvcClient.SocialAdService.LocationType Type {
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
        private string IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int LowField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MvcClient.SocialAdService.PriceType TypeField;
        
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
        public MvcClient.SocialAdService.PriceType Type {
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
    [System.Runtime.Serialization.DataContractAttribute(Name="LocationType", Namespace="http://schemas.datacontract.org/2004/07/Model")]
    public enum LocationType : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Country = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Region = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        City = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Area = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Address = 4,
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AdType", Namespace="http://schemas.datacontract.org/2004/07/Model")]
    public enum AdType : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Other = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Selling = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Buying = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ServiceRequest = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ServiceOffer = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Event = 5,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SocialAdService.ISocialAdService")]
    public interface ISocialAdService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISocialAdService/Register", ReplyAction="http://tempuri.org/ISocialAdService/RegisterResponse")]
        void Register(string email, string password, string name, string pictureURL);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISocialAdService/Register", ReplyAction="http://tempuri.org/ISocialAdService/RegisterResponse")]
        System.Threading.Tasks.Task RegisterAsync(string email, string password, string name, string pictureURL);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISocialAdService/Authenticate", ReplyAction="http://tempuri.org/ISocialAdService/AuthenticateResponse")]
        void Authenticate(string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISocialAdService/Authenticate", ReplyAction="http://tempuri.org/ISocialAdService/AuthenticateResponse")]
        System.Threading.Tasks.Task AuthenticateAsync(string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISocialAdService/GetAuthenticatedUser", ReplyAction="http://tempuri.org/ISocialAdService/GetAuthenticatedUserResponse")]
        MvcClient.SocialAdService.User GetAuthenticatedUser();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISocialAdService/GetAuthenticatedUser", ReplyAction="http://tempuri.org/ISocialAdService/GetAuthenticatedUserResponse")]
        System.Threading.Tasks.Task<MvcClient.SocialAdService.User> GetAuthenticatedUserAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISocialAdService/LogOut", ReplyAction="http://tempuri.org/ISocialAdService/LogOutResponse")]
        void LogOut();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISocialAdService/LogOut", ReplyAction="http://tempuri.org/ISocialAdService/LogOutResponse")]
        System.Threading.Tasks.Task LogOutAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISocialAdService/GetUser", ReplyAction="http://tempuri.org/ISocialAdService/GetUserResponse")]
        MvcClient.SocialAdService.User GetUser(string userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISocialAdService/GetUser", ReplyAction="http://tempuri.org/ISocialAdService/GetUserResponse")]
        System.Threading.Tasks.Task<MvcClient.SocialAdService.User> GetUserAsync(string userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISocialAdService/CountUsers", ReplyAction="http://tempuri.org/ISocialAdService/CountUsersResponse")]
        int CountUsers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISocialAdService/CountUsers", ReplyAction="http://tempuri.org/ISocialAdService/CountUsersResponse")]
        System.Threading.Tasks.Task<int> CountUsersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISocialAdService/GetUsers", ReplyAction="http://tempuri.org/ISocialAdService/GetUsersResponse")]
        MvcClient.SocialAdService.User[] GetUsers(int skip, int amount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISocialAdService/GetUsers", ReplyAction="http://tempuri.org/ISocialAdService/GetUsersResponse")]
        System.Threading.Tasks.Task<MvcClient.SocialAdService.User[]> GetUsersAsync(int skip, int amount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISocialAdService/GetData", ReplyAction="http://tempuri.org/ISocialAdService/GetDataResponse")]
        int GetData();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISocialAdService/GetData", ReplyAction="http://tempuri.org/ISocialAdService/GetDataResponse")]
        System.Threading.Tasks.Task<int> GetDataAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISocialAdService/FetchAds", ReplyAction="http://tempuri.org/ISocialAdService/FetchAdsResponse")]
        MvcClient.SocialAdService.Ad[] FetchAds(int skip, int amount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISocialAdService/FetchAds", ReplyAction="http://tempuri.org/ISocialAdService/FetchAdsResponse")]
        System.Threading.Tasks.Task<MvcClient.SocialAdService.Ad[]> FetchAdsAsync(int skip, int amount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISocialAdService/PostAd", ReplyAction="http://tempuri.org/ISocialAdService/PostAdResponse")]
        void PostAd(string title, string content, string location);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISocialAdService/PostAd", ReplyAction="http://tempuri.org/ISocialAdService/PostAdResponse")]
        System.Threading.Tasks.Task PostAdAsync(string title, string content, string location);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISocialAdServiceChannel : MvcClient.SocialAdService.ISocialAdService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SocialAdServiceClient : System.ServiceModel.ClientBase<MvcClient.SocialAdService.ISocialAdService>, MvcClient.SocialAdService.ISocialAdService {
        
        public SocialAdServiceClient() {
        }
        
        public SocialAdServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SocialAdServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SocialAdServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SocialAdServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void Register(string email, string password, string name, string pictureURL) {
            base.Channel.Register(email, password, name, pictureURL);
        }
        
        public System.Threading.Tasks.Task RegisterAsync(string email, string password, string name, string pictureURL) {
            return base.Channel.RegisterAsync(email, password, name, pictureURL);
        }
        
        public void Authenticate(string email, string password) {
            base.Channel.Authenticate(email, password);
        }
        
        public System.Threading.Tasks.Task AuthenticateAsync(string email, string password) {
            return base.Channel.AuthenticateAsync(email, password);
        }
        
        public MvcClient.SocialAdService.User GetAuthenticatedUser() {
            return base.Channel.GetAuthenticatedUser();
        }
        
        public System.Threading.Tasks.Task<MvcClient.SocialAdService.User> GetAuthenticatedUserAsync() {
            return base.Channel.GetAuthenticatedUserAsync();
        }
        
        public void LogOut() {
            base.Channel.LogOut();
        }
        
        public System.Threading.Tasks.Task LogOutAsync() {
            return base.Channel.LogOutAsync();
        }
        
        public MvcClient.SocialAdService.User GetUser(string userId) {
            return base.Channel.GetUser(userId);
        }
        
        public System.Threading.Tasks.Task<MvcClient.SocialAdService.User> GetUserAsync(string userId) {
            return base.Channel.GetUserAsync(userId);
        }
        
        public int CountUsers() {
            return base.Channel.CountUsers();
        }
        
        public System.Threading.Tasks.Task<int> CountUsersAsync() {
            return base.Channel.CountUsersAsync();
        }
        
        public MvcClient.SocialAdService.User[] GetUsers(int skip, int amount) {
            return base.Channel.GetUsers(skip, amount);
        }
        
        public System.Threading.Tasks.Task<MvcClient.SocialAdService.User[]> GetUsersAsync(int skip, int amount) {
            return base.Channel.GetUsersAsync(skip, amount);
        }
        
        public int GetData() {
            return base.Channel.GetData();
        }
        
        public System.Threading.Tasks.Task<int> GetDataAsync() {
            return base.Channel.GetDataAsync();
        }
        
        public MvcClient.SocialAdService.Ad[] FetchAds(int skip, int amount) {
            return base.Channel.FetchAds(skip, amount);
        }
        
        public System.Threading.Tasks.Task<MvcClient.SocialAdService.Ad[]> FetchAdsAsync(int skip, int amount) {
            return base.Channel.FetchAdsAsync(skip, amount);
        }
        
        public void PostAd(string title, string content, string location) {
            base.Channel.PostAd(title, content, location);
        }
        
        public System.Threading.Tasks.Task PostAdAsync(string title, string content, string location) {
            return base.Channel.PostAdAsync(title, content, location);
        }
    }
}
