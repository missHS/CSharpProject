﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MagicTrainingConsoleClient.MagicTrainingConsoleReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfString", Namespace="http://tempuri.org/", ItemName="string")]
    [System.SerializableAttribute()]
    public class ArrayOfString : System.Collections.Generic.List<string> {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MagicTrainingConsoleReference.MagicTrainingServiceSoap")]
    public interface MagicTrainingServiceSoap {
        
        // CODEGEN: Generating message contract since element name name from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FindTableByName", ReplyAction="*")]
        MagicTrainingConsoleClient.MagicTrainingConsoleReference.FindTableByNameResponse FindTableByName(MagicTrainingConsoleClient.MagicTrainingConsoleReference.FindTableByNameRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FindTableByName", ReplyAction="*")]
        System.Threading.Tasks.Task<MagicTrainingConsoleClient.MagicTrainingConsoleReference.FindTableByNameResponse> FindTableByNameAsync(MagicTrainingConsoleClient.MagicTrainingConsoleReference.FindTableByNameRequest request);
        
        // CODEGEN: Generating message contract since element name FindTableNamesResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FindTableNames", ReplyAction="*")]
        MagicTrainingConsoleClient.MagicTrainingConsoleReference.FindTableNamesResponse FindTableNames(MagicTrainingConsoleClient.MagicTrainingConsoleReference.FindTableNamesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FindTableNames", ReplyAction="*")]
        System.Threading.Tasks.Task<MagicTrainingConsoleClient.MagicTrainingConsoleReference.FindTableNamesResponse> FindTableNamesAsync(MagicTrainingConsoleClient.MagicTrainingConsoleReference.FindTableNamesRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class FindTableByNameRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="FindTableByName", Namespace="http://tempuri.org/", Order=0)]
        public MagicTrainingConsoleClient.MagicTrainingConsoleReference.FindTableByNameRequestBody Body;
        
        public FindTableByNameRequest() {
        }
        
        public FindTableByNameRequest(MagicTrainingConsoleClient.MagicTrainingConsoleReference.FindTableByNameRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class FindTableByNameRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string name;
        
        public FindTableByNameRequestBody() {
        }
        
        public FindTableByNameRequestBody(string name) {
            this.name = name;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class FindTableByNameResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="FindTableByNameResponse", Namespace="http://tempuri.org/", Order=0)]
        public MagicTrainingConsoleClient.MagicTrainingConsoleReference.FindTableByNameResponseBody Body;
        
        public FindTableByNameResponse() {
        }
        
        public FindTableByNameResponse(MagicTrainingConsoleClient.MagicTrainingConsoleReference.FindTableByNameResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class FindTableByNameResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public MagicTrainingConsoleClient.MagicTrainingConsoleReference.ArrayOfString FindTableByNameResult;
        
        public FindTableByNameResponseBody() {
        }
        
        public FindTableByNameResponseBody(MagicTrainingConsoleClient.MagicTrainingConsoleReference.ArrayOfString FindTableByNameResult) {
            this.FindTableByNameResult = FindTableByNameResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class FindTableNamesRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="FindTableNames", Namespace="http://tempuri.org/", Order=0)]
        public MagicTrainingConsoleClient.MagicTrainingConsoleReference.FindTableNamesRequestBody Body;
        
        public FindTableNamesRequest() {
        }
        
        public FindTableNamesRequest(MagicTrainingConsoleClient.MagicTrainingConsoleReference.FindTableNamesRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class FindTableNamesRequestBody {
        
        public FindTableNamesRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class FindTableNamesResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="FindTableNamesResponse", Namespace="http://tempuri.org/", Order=0)]
        public MagicTrainingConsoleClient.MagicTrainingConsoleReference.FindTableNamesResponseBody Body;
        
        public FindTableNamesResponse() {
        }
        
        public FindTableNamesResponse(MagicTrainingConsoleClient.MagicTrainingConsoleReference.FindTableNamesResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class FindTableNamesResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public MagicTrainingConsoleClient.MagicTrainingConsoleReference.ArrayOfString FindTableNamesResult;
        
        public FindTableNamesResponseBody() {
        }
        
        public FindTableNamesResponseBody(MagicTrainingConsoleClient.MagicTrainingConsoleReference.ArrayOfString FindTableNamesResult) {
            this.FindTableNamesResult = FindTableNamesResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface MagicTrainingServiceSoapChannel : MagicTrainingConsoleClient.MagicTrainingConsoleReference.MagicTrainingServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MagicTrainingServiceSoapClient : System.ServiceModel.ClientBase<MagicTrainingConsoleClient.MagicTrainingConsoleReference.MagicTrainingServiceSoap>, MagicTrainingConsoleClient.MagicTrainingConsoleReference.MagicTrainingServiceSoap {
        
        public MagicTrainingServiceSoapClient() {
        }
        
        public MagicTrainingServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MagicTrainingServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MagicTrainingServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MagicTrainingServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        MagicTrainingConsoleClient.MagicTrainingConsoleReference.FindTableByNameResponse MagicTrainingConsoleClient.MagicTrainingConsoleReference.MagicTrainingServiceSoap.FindTableByName(MagicTrainingConsoleClient.MagicTrainingConsoleReference.FindTableByNameRequest request) {
            return base.Channel.FindTableByName(request);
        }
        
        public MagicTrainingConsoleClient.MagicTrainingConsoleReference.ArrayOfString FindTableByName(string name) {
            MagicTrainingConsoleClient.MagicTrainingConsoleReference.FindTableByNameRequest inValue = new MagicTrainingConsoleClient.MagicTrainingConsoleReference.FindTableByNameRequest();
            inValue.Body = new MagicTrainingConsoleClient.MagicTrainingConsoleReference.FindTableByNameRequestBody();
            inValue.Body.name = name;
            MagicTrainingConsoleClient.MagicTrainingConsoleReference.FindTableByNameResponse retVal = ((MagicTrainingConsoleClient.MagicTrainingConsoleReference.MagicTrainingServiceSoap)(this)).FindTableByName(inValue);
            return retVal.Body.FindTableByNameResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<MagicTrainingConsoleClient.MagicTrainingConsoleReference.FindTableByNameResponse> MagicTrainingConsoleClient.MagicTrainingConsoleReference.MagicTrainingServiceSoap.FindTableByNameAsync(MagicTrainingConsoleClient.MagicTrainingConsoleReference.FindTableByNameRequest request) {
            return base.Channel.FindTableByNameAsync(request);
        }
        
        public System.Threading.Tasks.Task<MagicTrainingConsoleClient.MagicTrainingConsoleReference.FindTableByNameResponse> FindTableByNameAsync(string name) {
            MagicTrainingConsoleClient.MagicTrainingConsoleReference.FindTableByNameRequest inValue = new MagicTrainingConsoleClient.MagicTrainingConsoleReference.FindTableByNameRequest();
            inValue.Body = new MagicTrainingConsoleClient.MagicTrainingConsoleReference.FindTableByNameRequestBody();
            inValue.Body.name = name;
            return ((MagicTrainingConsoleClient.MagicTrainingConsoleReference.MagicTrainingServiceSoap)(this)).FindTableByNameAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        MagicTrainingConsoleClient.MagicTrainingConsoleReference.FindTableNamesResponse MagicTrainingConsoleClient.MagicTrainingConsoleReference.MagicTrainingServiceSoap.FindTableNames(MagicTrainingConsoleClient.MagicTrainingConsoleReference.FindTableNamesRequest request) {
            return base.Channel.FindTableNames(request);
        }
        
        public MagicTrainingConsoleClient.MagicTrainingConsoleReference.ArrayOfString FindTableNames() {
            MagicTrainingConsoleClient.MagicTrainingConsoleReference.FindTableNamesRequest inValue = new MagicTrainingConsoleClient.MagicTrainingConsoleReference.FindTableNamesRequest();
            inValue.Body = new MagicTrainingConsoleClient.MagicTrainingConsoleReference.FindTableNamesRequestBody();
            MagicTrainingConsoleClient.MagicTrainingConsoleReference.FindTableNamesResponse retVal = ((MagicTrainingConsoleClient.MagicTrainingConsoleReference.MagicTrainingServiceSoap)(this)).FindTableNames(inValue);
            return retVal.Body.FindTableNamesResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<MagicTrainingConsoleClient.MagicTrainingConsoleReference.FindTableNamesResponse> MagicTrainingConsoleClient.MagicTrainingConsoleReference.MagicTrainingServiceSoap.FindTableNamesAsync(MagicTrainingConsoleClient.MagicTrainingConsoleReference.FindTableNamesRequest request) {
            return base.Channel.FindTableNamesAsync(request);
        }
        
        public System.Threading.Tasks.Task<MagicTrainingConsoleClient.MagicTrainingConsoleReference.FindTableNamesResponse> FindTableNamesAsync() {
            MagicTrainingConsoleClient.MagicTrainingConsoleReference.FindTableNamesRequest inValue = new MagicTrainingConsoleClient.MagicTrainingConsoleReference.FindTableNamesRequest();
            inValue.Body = new MagicTrainingConsoleClient.MagicTrainingConsoleReference.FindTableNamesRequestBody();
            return ((MagicTrainingConsoleClient.MagicTrainingConsoleReference.MagicTrainingServiceSoap)(this)).FindTableNamesAsync(inValue);
        }
    }
}
