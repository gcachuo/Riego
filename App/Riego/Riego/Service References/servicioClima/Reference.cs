﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Riego.servicioClima {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://192.168.1.225/soap/sustentabilidadWS", ConfigurationName="servicioClima.sustentabilidadWSPortType")]
    public interface sustentabilidadWSPortType {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el espacio de nombres de contenedor (http://localhost/sustentabilidadWS/service.php) del mensaje getRainPobabilityRequest no coincide con el valor predeterminado (http://192.168.1.225/soap/sustentabilidadWS)
        [System.ServiceModel.OperationContractAttribute(Action="http://192.168.1.225/sustentabilidadWS/service.php/getRainPobability", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        Riego.servicioClima.getRainPobabilityResponse getRainPobability(Riego.servicioClima.getRainPobabilityRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://192.168.1.225/sustentabilidadWS/service.php/getRainPobability", ReplyAction="*")]
        System.Threading.Tasks.Task<Riego.servicioClima.getRainPobabilityResponse> getRainPobabilityAsync(Riego.servicioClima.getRainPobabilityRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getRainPobability", WrapperNamespace="http://localhost/sustentabilidadWS/service.php", IsWrapped=true)]
    public partial class getRainPobabilityRequest {
        
        public getRainPobabilityRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getRainPobabilityResponse", WrapperNamespace="http://localhost/sustentabilidadWS/service.php", IsWrapped=true)]
    public partial class getRainPobabilityResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string @return;
        
        public getRainPobabilityResponse() {
        }
        
        public getRainPobabilityResponse(string @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface sustentabilidadWSPortTypeChannel : Riego.servicioClima.sustentabilidadWSPortType, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class sustentabilidadWSPortTypeClient : System.ServiceModel.ClientBase<Riego.servicioClima.sustentabilidadWSPortType>, Riego.servicioClima.sustentabilidadWSPortType {
        
        public sustentabilidadWSPortTypeClient() {
        }
        
        public sustentabilidadWSPortTypeClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public sustentabilidadWSPortTypeClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public sustentabilidadWSPortTypeClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public sustentabilidadWSPortTypeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Riego.servicioClima.getRainPobabilityResponse Riego.servicioClima.sustentabilidadWSPortType.getRainPobability(Riego.servicioClima.getRainPobabilityRequest request) {
            return base.Channel.getRainPobability(request);
        }
        
        public string getRainPobability() {
            Riego.servicioClima.getRainPobabilityRequest inValue = new Riego.servicioClima.getRainPobabilityRequest();
            Riego.servicioClima.getRainPobabilityResponse retVal = ((Riego.servicioClima.sustentabilidadWSPortType)(this)).getRainPobability(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Riego.servicioClima.getRainPobabilityResponse> Riego.servicioClima.sustentabilidadWSPortType.getRainPobabilityAsync(Riego.servicioClima.getRainPobabilityRequest request) {
            return base.Channel.getRainPobabilityAsync(request);
        }
        
        public System.Threading.Tasks.Task<Riego.servicioClima.getRainPobabilityResponse> getRainPobabilityAsync() {
            Riego.servicioClima.getRainPobabilityRequest inValue = new Riego.servicioClima.getRainPobabilityRequest();
            return ((Riego.servicioClima.sustentabilidadWSPortType)(this)).getRainPobabilityAsync(inValue);
        }
    }
}