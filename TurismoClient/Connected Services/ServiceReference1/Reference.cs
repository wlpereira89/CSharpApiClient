//------------------------------------------------------------------------------
// <gerado automaticamente>
//     Esse código foi gerado por uma ferramenta.
//     //
//     As alterações no arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </gerado automaticamente>
//------------------------------------------------------------------------------

using System;

namespace ServiceReference1
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://org.servicoturismo/", ConfigurationName="ServiceReference1.VoosWebService")]
    public interface VoosWebService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://org.servicoturismo/VoosWebService/inserirVooRequest", ReplyAction="http://org.servicoturismo/VoosWebService/inserirVooResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReference1.inserirVooResponse> inserirVooAsync(ServiceReference1.inserirVooRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://org.servicoturismo/VoosWebService/listarVoosRequest", ReplyAction="http://org.servicoturismo/VoosWebService/listarVoosResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReference1.listarVoosResponse> listarVoosAsync(ServiceReference1.listarVoosRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://org.servicoturismo/VoosWebService/obterVoosRequest", ReplyAction="http://org.servicoturismo/VoosWebService/obterVoosResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReference1.obterVoosResponse> obterVoosAsync(ServiceReference1.obterVoosRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://org.servicoturismo/VoosWebService/consultarVoosRequest", ReplyAction="http://org.servicoturismo/VoosWebService/consultarVoosResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReference1.consultarVoosResponse> consultarVoosAsync(ServiceReference1.consultarVoosRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://org.servicoturismo/VoosWebService/reservarPassagemRequest", ReplyAction="http://org.servicoturismo/VoosWebService/reservarPassagemResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReference1.reservarPassagemResponse> reservarPassagemAsync(ServiceReference1.reservarPassagemRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="inserirVoo", WrapperNamespace="http://org.servicoturismo/", IsWrapped=true)]
    public partial class inserirVooRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://org.servicoturismo/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string arg0;
        
        public inserirVooRequest()
        {
        }
        
        public inserirVooRequest(string arg0)
        {
            this.arg0 = arg0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="inserirVooResponse", WrapperNamespace="http://org.servicoturismo/", IsWrapped=true)]
    public partial class inserirVooResponse
    {
        
        public inserirVooResponse()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listarVoos", WrapperNamespace="http://org.servicoturismo/", IsWrapped=true)]
    public partial class listarVoosRequest
    {
        
        public listarVoosRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listarVoosResponse", WrapperNamespace="http://org.servicoturismo/", IsWrapped=true)]
    public partial class listarVoosResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://org.servicoturismo/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string @return;
        
        public listarVoosResponse()
        {
        }
        
        public listarVoosResponse(string @return)
        {
            this.@return = @return;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://org.servicoturismo/")]
    public partial class voo
    {
        public DateTime data;
        public string origem;
        public string destino;
        public double valor;
        public int vagas;
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="obterVoos", WrapperNamespace="http://org.servicoturismo/", IsWrapped=true)]
    public partial class obterVoosRequest
    {
        
        public obterVoosRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="obterVoosResponse", WrapperNamespace="http://org.servicoturismo/", IsWrapped=true)]
    public partial class obterVoosResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://org.servicoturismo/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ServiceReference1.voo[] @return;
        
        public obterVoosResponse()
        {
        }
        
        public obterVoosResponse(ServiceReference1.voo[] @return)
        {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="consultarVoos", WrapperNamespace="http://org.servicoturismo/", IsWrapped=true)]
    public partial class consultarVoosRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://org.servicoturismo/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string arg0;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://org.servicoturismo/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string arg1;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://org.servicoturismo/", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string arg2;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://org.servicoturismo/", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int arg3;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://org.servicoturismo/", Order=4)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int arg4;
        
        public consultarVoosRequest()
        {
        }
        
        public consultarVoosRequest(string arg0, string arg1, string arg2, int arg3, int arg4)
        {
            this.arg0 = arg0;
            this.arg1 = arg1;
            this.arg2 = arg2;
            this.arg3 = arg3;
            this.arg4 = arg4;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="consultarVoosResponse", WrapperNamespace="http://org.servicoturismo/", IsWrapped=true)]
    public partial class consultarVoosResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://org.servicoturismo/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string @return;
        
        public consultarVoosResponse()
        {
        }
        
        public consultarVoosResponse(string @return)
        {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="reservarPassagem", WrapperNamespace="http://org.servicoturismo/", IsWrapped=true)]
    public partial class reservarPassagemRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://org.servicoturismo/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int arg0;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://org.servicoturismo/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int arg1;
        
        public reservarPassagemRequest()
        {
        }
        
        public reservarPassagemRequest(int arg0, int arg1)
        {
            this.arg0 = arg0;
            this.arg1 = arg1;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="reservarPassagemResponse", WrapperNamespace="http://org.servicoturismo/", IsWrapped=true)]
    public partial class reservarPassagemResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://org.servicoturismo/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool @return;
        
        public reservarPassagemResponse()
        {
        }
        
        public reservarPassagemResponse(bool @return)
        {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    public interface VoosWebServiceChannel : ServiceReference1.VoosWebService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    public partial class VoosWebServiceClient : System.ServiceModel.ClientBase<ServiceReference1.VoosWebService>, ServiceReference1.VoosWebService
    {
        
    /// <summary>
    /// Implemente este método parcial para configurar o ponto de extremidade de serviço.
    /// </summary>
    /// <param name="serviceEndpoint">O ponto de extremidade a ser configurado</param>
    /// <param name="clientCredentials">As credenciais do cliente</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public VoosWebServiceClient() : 
                base(VoosWebServiceClient.GetDefaultBinding(), VoosWebServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.VoosWebServicePort.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public VoosWebServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(VoosWebServiceClient.GetBindingForEndpoint(endpointConfiguration), VoosWebServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public VoosWebServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(VoosWebServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public VoosWebServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(VoosWebServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public VoosWebServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1.inserirVooResponse> ServiceReference1.VoosWebService.inserirVooAsync(ServiceReference1.inserirVooRequest request)
        {
            return base.Channel.inserirVooAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.inserirVooResponse> inserirVooAsync(string arg0)
        {
            ServiceReference1.inserirVooRequest inValue = new ServiceReference1.inserirVooRequest();
            inValue.arg0 = arg0;
            return ((ServiceReference1.VoosWebService)(this)).inserirVooAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1.listarVoosResponse> ServiceReference1.VoosWebService.listarVoosAsync(ServiceReference1.listarVoosRequest request)
        {
            return base.Channel.listarVoosAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.listarVoosResponse> listarVoosAsync()
        {
            ServiceReference1.listarVoosRequest inValue = new ServiceReference1.listarVoosRequest();
            return ((ServiceReference1.VoosWebService)(this)).listarVoosAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1.obterVoosResponse> ServiceReference1.VoosWebService.obterVoosAsync(ServiceReference1.obterVoosRequest request)
        {
            return base.Channel.obterVoosAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.obterVoosResponse> obterVoosAsync()
        {
            ServiceReference1.obterVoosRequest inValue = new ServiceReference1.obterVoosRequest();
            return ((ServiceReference1.VoosWebService)(this)).obterVoosAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1.consultarVoosResponse> ServiceReference1.VoosWebService.consultarVoosAsync(ServiceReference1.consultarVoosRequest request)
        {
            return base.Channel.consultarVoosAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.consultarVoosResponse> consultarVoosAsync(string arg0, string arg1, string arg2, int arg3, int arg4)
        {
            ServiceReference1.consultarVoosRequest inValue = new ServiceReference1.consultarVoosRequest();
            inValue.arg0 = arg0;
            inValue.arg1 = arg1;
            inValue.arg2 = arg2;
            inValue.arg3 = arg3;
            inValue.arg4 = arg4;
            return ((ServiceReference1.VoosWebService)(this)).consultarVoosAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1.reservarPassagemResponse> ServiceReference1.VoosWebService.reservarPassagemAsync(ServiceReference1.reservarPassagemRequest request)
        {
            return base.Channel.reservarPassagemAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.reservarPassagemResponse> reservarPassagemAsync(int arg0, int arg1)
        {
            ServiceReference1.reservarPassagemRequest inValue = new ServiceReference1.reservarPassagemRequest();
            inValue.arg0 = arg0;
            inValue.arg1 = arg1;
            return ((ServiceReference1.VoosWebService)(this)).reservarPassagemAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.VoosWebServicePort))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Não foi possível encontrar o ponto de extremidade com o nome \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.VoosWebServicePort))
            {
                return new System.ServiceModel.EndpointAddress("http://192.168.6.173:8080/WebServTurismo/ServicoTurismo");
            }
            throw new System.InvalidOperationException(string.Format("Não foi possível encontrar o ponto de extremidade com o nome \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return VoosWebServiceClient.GetBindingForEndpoint(EndpointConfiguration.VoosWebServicePort);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return VoosWebServiceClient.GetEndpointAddress(EndpointConfiguration.VoosWebServicePort);
        }
        
        public enum EndpointConfiguration
        {
            
            VoosWebServicePort,
        }
    }
}
