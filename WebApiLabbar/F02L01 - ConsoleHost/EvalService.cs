﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EvalServiceLibrary
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Eval", Namespace="http://schemas.datacontract.org/2004/07/EvalServiceLibrary")]
    public partial class Eval : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string CommentsField;
        
        private string SubmitterField;
        
        private System.DateTime TimesentField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Comments
        {
            get
            {
                return this.CommentsField;
            }
            set
            {
                this.CommentsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Submitter
        {
            get
            {
                return this.SubmitterField;
            }
            set
            {
                this.SubmitterField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Timesent
        {
            get
            {
                return this.TimesentField;
            }
            set
            {
                this.TimesentField = value;
            }
        }
    }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="IEvalService")]
public interface IEvalService
{
    
    [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IEvalService/SubmitEval")]
    void SubmitEval(EvalServiceLibrary.Eval eval);
    
    [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IEvalService/SubmitEval")]
    System.Threading.Tasks.Task SubmitEvalAsync(EvalServiceLibrary.Eval eval);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEvalService/GetEvals", ReplyAction="http://tempuri.org/IEvalService/GetEvalsResponse")]
    EvalServiceLibrary.Eval[] GetEvals();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEvalService/GetEvals", ReplyAction="http://tempuri.org/IEvalService/GetEvalsResponse")]
    System.Threading.Tasks.Task<EvalServiceLibrary.Eval[]> GetEvalsAsync();
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IEvalServiceChannel : IEvalService, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class EvalServiceClient : System.ServiceModel.ClientBase<IEvalService>, IEvalService
{
    
    public EvalServiceClient()
    {
    }
    
    public EvalServiceClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public EvalServiceClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public EvalServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public EvalServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public void SubmitEval(EvalServiceLibrary.Eval eval)
    {
        base.Channel.SubmitEval(eval);
    }
    
    public System.Threading.Tasks.Task SubmitEvalAsync(EvalServiceLibrary.Eval eval)
    {
        return base.Channel.SubmitEvalAsync(eval);
    }
    
    public EvalServiceLibrary.Eval[] GetEvals()
    {
        return base.Channel.GetEvals();
    }
    
    public System.Threading.Tasks.Task<EvalServiceLibrary.Eval[]> GetEvalsAsync()
    {
        return base.Channel.GetEvalsAsync();
    }
}
