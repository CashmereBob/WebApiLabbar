﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace F03L01___KlientUppgift.addSoapServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://free-web-services.com/soap", ConfigurationName="addSoapServiceReference.addSoap")]
    public interface addSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://free-web-services.com/soap", ReplyAction="*")]
        F03L01___KlientUppgift.addSoapServiceReference.addResponse add(F03L01___KlientUppgift.addSoapServiceReference.addRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://free-web-services.com/soap", ReplyAction="*")]
        System.Threading.Tasks.Task<F03L01___KlientUppgift.addSoapServiceReference.addResponse> addAsync(F03L01___KlientUppgift.addSoapServiceReference.addRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="addRequest", WrapperNamespace="http://free-web-services.com/soap", IsWrapped=true)]
    public partial class addRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public int a;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=1)]
        public int b;
        
        public addRequest() {
        }
        
        public addRequest(int a, int b) {
            this.a = a;
            this.b = b;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="addResponse", WrapperNamespace="http://free-web-services.com/soap", IsWrapped=true)]
    public partial class addResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public int sum;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=1)]
        public double time;
        
        public addResponse() {
        }
        
        public addResponse(int sum, double time) {
            this.sum = sum;
            this.time = time;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface addSoapChannel : F03L01___KlientUppgift.addSoapServiceReference.addSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class addSoapClient : System.ServiceModel.ClientBase<F03L01___KlientUppgift.addSoapServiceReference.addSoap>, F03L01___KlientUppgift.addSoapServiceReference.addSoap {
        
        public addSoapClient() {
        }
        
        public addSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public addSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public addSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public addSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        F03L01___KlientUppgift.addSoapServiceReference.addResponse F03L01___KlientUppgift.addSoapServiceReference.addSoap.add(F03L01___KlientUppgift.addSoapServiceReference.addRequest request) {
            return base.Channel.add(request);
        }
        
        public int add(int a, int b, out double time) {
            F03L01___KlientUppgift.addSoapServiceReference.addRequest inValue = new F03L01___KlientUppgift.addSoapServiceReference.addRequest();
            inValue.a = a;
            inValue.b = b;
            F03L01___KlientUppgift.addSoapServiceReference.addResponse retVal = ((F03L01___KlientUppgift.addSoapServiceReference.addSoap)(this)).add(inValue);
            time = retVal.time;
            return retVal.sum;
        }
        
        public System.Threading.Tasks.Task<F03L01___KlientUppgift.addSoapServiceReference.addResponse> addAsync(F03L01___KlientUppgift.addSoapServiceReference.addRequest request) {
            return base.Channel.addAsync(request);
        }
    }
}
