﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AWS_UX.AWSService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="InstanceDetails", Namespace="http://schemas.datacontract.org/2004/07/AWS_Service.Data")]
    [System.SerializableAttribute()]
    public partial class InstanceDetails : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AvailablityZoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string InstanceIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string InstanceNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string InstanceStateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string InstanceStatusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SystemNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SystemStateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SystemStatusField;
        
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
        public string AvailablityZone {
            get {
                return this.AvailablityZoneField;
            }
            set {
                if ((object.ReferenceEquals(this.AvailablityZoneField, value) != true)) {
                    this.AvailablityZoneField = value;
                    this.RaisePropertyChanged("AvailablityZone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string InstanceId {
            get {
                return this.InstanceIdField;
            }
            set {
                if ((object.ReferenceEquals(this.InstanceIdField, value) != true)) {
                    this.InstanceIdField = value;
                    this.RaisePropertyChanged("InstanceId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string InstanceName {
            get {
                return this.InstanceNameField;
            }
            set {
                if ((object.ReferenceEquals(this.InstanceNameField, value) != true)) {
                    this.InstanceNameField = value;
                    this.RaisePropertyChanged("InstanceName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string InstanceState {
            get {
                return this.InstanceStateField;
            }
            set {
                if ((object.ReferenceEquals(this.InstanceStateField, value) != true)) {
                    this.InstanceStateField = value;
                    this.RaisePropertyChanged("InstanceState");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string InstanceStatus {
            get {
                return this.InstanceStatusField;
            }
            set {
                if ((object.ReferenceEquals(this.InstanceStatusField, value) != true)) {
                    this.InstanceStatusField = value;
                    this.RaisePropertyChanged("InstanceStatus");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SystemName {
            get {
                return this.SystemNameField;
            }
            set {
                if ((object.ReferenceEquals(this.SystemNameField, value) != true)) {
                    this.SystemNameField = value;
                    this.RaisePropertyChanged("SystemName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SystemState {
            get {
                return this.SystemStateField;
            }
            set {
                if ((object.ReferenceEquals(this.SystemStateField, value) != true)) {
                    this.SystemStateField = value;
                    this.RaisePropertyChanged("SystemState");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SystemStatus {
            get {
                return this.SystemStatusField;
            }
            set {
                if ((object.ReferenceEquals(this.SystemStatusField, value) != true)) {
                    this.SystemStatusField = value;
                    this.RaisePropertyChanged("SystemStatus");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AWSService.IAWSService")]
    public interface IAWSService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAWSService/GetInstanceDetails", ReplyAction="http://tempuri.org/IAWSService/GetInstanceDetailsResponse")]
        AWS_UX.AWSService.InstanceDetails GetInstanceDetails(string instanceId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAWSService/GetInstanceDetails", ReplyAction="http://tempuri.org/IAWSService/GetInstanceDetailsResponse")]
        System.Threading.Tasks.Task<AWS_UX.AWSService.InstanceDetails> GetInstanceDetailsAsync(string instanceId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAWSServiceChannel : AWS_UX.AWSService.IAWSService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AWSServiceClient : System.ServiceModel.ClientBase<AWS_UX.AWSService.IAWSService>, AWS_UX.AWSService.IAWSService {
        
        public AWSServiceClient() {
        }
        
        public AWSServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AWSServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AWSServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AWSServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public AWS_UX.AWSService.InstanceDetails GetInstanceDetails(string instanceId) {
            return base.Channel.GetInstanceDetails(instanceId);
        }
        
        public System.Threading.Tasks.Task<AWS_UX.AWSService.InstanceDetails> GetInstanceDetailsAsync(string instanceId) {
            return base.Channel.GetInstanceDetailsAsync(instanceId);
        }
    }
}
