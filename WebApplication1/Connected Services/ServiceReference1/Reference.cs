﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://org.servicoturismo/", ConfigurationName="ServiceReference1.VoosWebService")]
    public interface VoosWebService {
        
        // CODEGEN: O parâmetro 'arg0' requer informações adicionais de esquema que não podem ser capturadas usando o modo do parâmetro. O atributo específico é 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://org.servicoturismo/VoosWebService/inserirVooRequest", ReplyAction="http://org.servicoturismo/VoosWebService/inserirVooResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        WebApplication1.ServiceReference1.inserirVooResponse inserirVoo(WebApplication1.ServiceReference1.inserirVooRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://org.servicoturismo/VoosWebService/inserirVooRequest", ReplyAction="http://org.servicoturismo/VoosWebService/inserirVooResponse")]
        System.Threading.Tasks.Task<WebApplication1.ServiceReference1.inserirVooResponse> inserirVooAsync(WebApplication1.ServiceReference1.inserirVooRequest request);
        
        // CODEGEN: O parâmetro 'return' requer informações adicionais de esquema que não podem ser capturadas usando o modo do parâmetro. O atributo específico é 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://org.servicoturismo/VoosWebService/listarVoosRequest", ReplyAction="http://org.servicoturismo/VoosWebService/listarVoosResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        WebApplication1.ServiceReference1.listarVoosResponse listarVoos(WebApplication1.ServiceReference1.listarVoosRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://org.servicoturismo/VoosWebService/listarVoosRequest", ReplyAction="http://org.servicoturismo/VoosWebService/listarVoosResponse")]
        System.Threading.Tasks.Task<WebApplication1.ServiceReference1.listarVoosResponse> listarVoosAsync(WebApplication1.ServiceReference1.listarVoosRequest request);
        
        // CODEGEN: O parâmetro 'return' requer informações adicionais de esquema que não podem ser capturadas usando o modo do parâmetro. O atributo específico é 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://org.servicoturismo/VoosWebService/obterVoosRequest", ReplyAction="http://org.servicoturismo/VoosWebService/obterVoosResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        WebApplication1.ServiceReference1.obterVoosResponse obterVoos(WebApplication1.ServiceReference1.obterVoosRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://org.servicoturismo/VoosWebService/obterVoosRequest", ReplyAction="http://org.servicoturismo/VoosWebService/obterVoosResponse")]
        System.Threading.Tasks.Task<WebApplication1.ServiceReference1.obterVoosResponse> obterVoosAsync(WebApplication1.ServiceReference1.obterVoosRequest request);
        
        // CODEGEN: O parâmetro 'return' requer informações adicionais de esquema que não podem ser capturadas usando o modo do parâmetro. O atributo específico é 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://org.servicoturismo/VoosWebService/consultarVoosRequest", ReplyAction="http://org.servicoturismo/VoosWebService/consultarVoosResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        WebApplication1.ServiceReference1.consultarVoosResponse consultarVoos(WebApplication1.ServiceReference1.consultarVoosRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://org.servicoturismo/VoosWebService/consultarVoosRequest", ReplyAction="http://org.servicoturismo/VoosWebService/consultarVoosResponse")]
        System.Threading.Tasks.Task<WebApplication1.ServiceReference1.consultarVoosResponse> consultarVoosAsync(WebApplication1.ServiceReference1.consultarVoosRequest request);
        
        // CODEGEN: O parâmetro 'return' requer informações adicionais de esquema que não podem ser capturadas usando o modo do parâmetro. O atributo específico é 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://org.servicoturismo/VoosWebService/reservarPassagemRequest", ReplyAction="http://org.servicoturismo/VoosWebService/reservarPassagemResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        WebApplication1.ServiceReference1.reservarPassagemResponse reservarPassagem(WebApplication1.ServiceReference1.reservarPassagemRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://org.servicoturismo/VoosWebService/reservarPassagemRequest", ReplyAction="http://org.servicoturismo/VoosWebService/reservarPassagemResponse")]
        System.Threading.Tasks.Task<WebApplication1.ServiceReference1.reservarPassagemResponse> reservarPassagemAsync(WebApplication1.ServiceReference1.reservarPassagemRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="inserirVoo", WrapperNamespace="http://org.servicoturismo/", IsWrapped=true)]
    public partial class inserirVooRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://org.servicoturismo/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string arg0;
        
        public inserirVooRequest() {
        }
        
        public inserirVooRequest(string arg0) {
            this.arg0 = arg0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="inserirVooResponse", WrapperNamespace="http://org.servicoturismo/", IsWrapped=true)]
    public partial class inserirVooResponse {
        
        public inserirVooResponse() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listarVoos", WrapperNamespace="http://org.servicoturismo/", IsWrapped=true)]
    public partial class listarVoosRequest {
        
        public listarVoosRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listarVoosResponse", WrapperNamespace="http://org.servicoturismo/", IsWrapped=true)]
    public partial class listarVoosResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://org.servicoturismo/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string @return;
        
        public listarVoosResponse() {
        }
        
        public listarVoosResponse(string @return) {
            this.@return = @return;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2117.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://org.servicoturismo/")]
    public partial class voo : object, System.ComponentModel.INotifyPropertyChanged {
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="obterVoos", WrapperNamespace="http://org.servicoturismo/", IsWrapped=true)]
    public partial class obterVoosRequest {
        
        public obterVoosRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="obterVoosResponse", WrapperNamespace="http://org.servicoturismo/", IsWrapped=true)]
    public partial class obterVoosResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://org.servicoturismo/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public WebApplication1.ServiceReference1.voo[] @return;
        
        public obterVoosResponse() {
        }
        
        public obterVoosResponse(WebApplication1.ServiceReference1.voo[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="consultarVoos", WrapperNamespace="http://org.servicoturismo/", IsWrapped=true)]
    public partial class consultarVoosRequest {
        
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
        
        public consultarVoosRequest() {
        }
        
        public consultarVoosRequest(string arg0, string arg1, string arg2, int arg3, int arg4) {
            this.arg0 = arg0;
            this.arg1 = arg1;
            this.arg2 = arg2;
            this.arg3 = arg3;
            this.arg4 = arg4;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="consultarVoosResponse", WrapperNamespace="http://org.servicoturismo/", IsWrapped=true)]
    public partial class consultarVoosResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://org.servicoturismo/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string @return;
        
        public consultarVoosResponse() {
        }
        
        public consultarVoosResponse(string @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="reservarPassagem", WrapperNamespace="http://org.servicoturismo/", IsWrapped=true)]
    public partial class reservarPassagemRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://org.servicoturismo/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int arg0;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://org.servicoturismo/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int arg1;
        
        public reservarPassagemRequest() {
        }
        
        public reservarPassagemRequest(int arg0, int arg1) {
            this.arg0 = arg0;
            this.arg1 = arg1;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="reservarPassagemResponse", WrapperNamespace="http://org.servicoturismo/", IsWrapped=true)]
    public partial class reservarPassagemResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://org.servicoturismo/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool @return;
        
        public reservarPassagemResponse() {
        }
        
        public reservarPassagemResponse(bool @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface VoosWebServiceChannel : WebApplication1.ServiceReference1.VoosWebService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class VoosWebServiceClient : System.ServiceModel.ClientBase<WebApplication1.ServiceReference1.VoosWebService>, WebApplication1.ServiceReference1.VoosWebService {
        
        public VoosWebServiceClient() {
        }
        
        public VoosWebServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public VoosWebServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public VoosWebServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public VoosWebServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebApplication1.ServiceReference1.inserirVooResponse WebApplication1.ServiceReference1.VoosWebService.inserirVoo(WebApplication1.ServiceReference1.inserirVooRequest request) {
            return base.Channel.inserirVoo(request);
        }
        
        public void inserirVoo(string arg0) {
            WebApplication1.ServiceReference1.inserirVooRequest inValue = new WebApplication1.ServiceReference1.inserirVooRequest();
            inValue.arg0 = arg0;
            WebApplication1.ServiceReference1.inserirVooResponse retVal = ((WebApplication1.ServiceReference1.VoosWebService)(this)).inserirVoo(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebApplication1.ServiceReference1.inserirVooResponse> WebApplication1.ServiceReference1.VoosWebService.inserirVooAsync(WebApplication1.ServiceReference1.inserirVooRequest request) {
            return base.Channel.inserirVooAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebApplication1.ServiceReference1.inserirVooResponse> inserirVooAsync(string arg0) {
            WebApplication1.ServiceReference1.inserirVooRequest inValue = new WebApplication1.ServiceReference1.inserirVooRequest();
            inValue.arg0 = arg0;
            return ((WebApplication1.ServiceReference1.VoosWebService)(this)).inserirVooAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebApplication1.ServiceReference1.listarVoosResponse WebApplication1.ServiceReference1.VoosWebService.listarVoos(WebApplication1.ServiceReference1.listarVoosRequest request) {
            return base.Channel.listarVoos(request);
        }
        
        public string listarVoos() {
            WebApplication1.ServiceReference1.listarVoosRequest inValue = new WebApplication1.ServiceReference1.listarVoosRequest();
            WebApplication1.ServiceReference1.listarVoosResponse retVal = ((WebApplication1.ServiceReference1.VoosWebService)(this)).listarVoos(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebApplication1.ServiceReference1.listarVoosResponse> WebApplication1.ServiceReference1.VoosWebService.listarVoosAsync(WebApplication1.ServiceReference1.listarVoosRequest request) {
            return base.Channel.listarVoosAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebApplication1.ServiceReference1.listarVoosResponse> listarVoosAsync() {
            WebApplication1.ServiceReference1.listarVoosRequest inValue = new WebApplication1.ServiceReference1.listarVoosRequest();
            return ((WebApplication1.ServiceReference1.VoosWebService)(this)).listarVoosAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebApplication1.ServiceReference1.obterVoosResponse WebApplication1.ServiceReference1.VoosWebService.obterVoos(WebApplication1.ServiceReference1.obterVoosRequest request) {
            return base.Channel.obterVoos(request);
        }
        
        public WebApplication1.ServiceReference1.voo[] obterVoos() {
            WebApplication1.ServiceReference1.obterVoosRequest inValue = new WebApplication1.ServiceReference1.obterVoosRequest();
            WebApplication1.ServiceReference1.obterVoosResponse retVal = ((WebApplication1.ServiceReference1.VoosWebService)(this)).obterVoos(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebApplication1.ServiceReference1.obterVoosResponse> WebApplication1.ServiceReference1.VoosWebService.obterVoosAsync(WebApplication1.ServiceReference1.obterVoosRequest request) {
            return base.Channel.obterVoosAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebApplication1.ServiceReference1.obterVoosResponse> obterVoosAsync() {
            WebApplication1.ServiceReference1.obterVoosRequest inValue = new WebApplication1.ServiceReference1.obterVoosRequest();
            return ((WebApplication1.ServiceReference1.VoosWebService)(this)).obterVoosAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebApplication1.ServiceReference1.consultarVoosResponse WebApplication1.ServiceReference1.VoosWebService.consultarVoos(WebApplication1.ServiceReference1.consultarVoosRequest request) {
            return base.Channel.consultarVoos(request);
        }
        
        public string consultarVoos(string arg0, string arg1, string arg2, int arg3, int arg4) {
            WebApplication1.ServiceReference1.consultarVoosRequest inValue = new WebApplication1.ServiceReference1.consultarVoosRequest();
            inValue.arg0 = arg0;
            inValue.arg1 = arg1;
            inValue.arg2 = arg2;
            inValue.arg3 = arg3;
            inValue.arg4 = arg4;
            WebApplication1.ServiceReference1.consultarVoosResponse retVal = ((WebApplication1.ServiceReference1.VoosWebService)(this)).consultarVoos(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebApplication1.ServiceReference1.consultarVoosResponse> WebApplication1.ServiceReference1.VoosWebService.consultarVoosAsync(WebApplication1.ServiceReference1.consultarVoosRequest request) {
            return base.Channel.consultarVoosAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebApplication1.ServiceReference1.consultarVoosResponse> consultarVoosAsync(string arg0, string arg1, string arg2, int arg3, int arg4) {
            WebApplication1.ServiceReference1.consultarVoosRequest inValue = new WebApplication1.ServiceReference1.consultarVoosRequest();
            inValue.arg0 = arg0;
            inValue.arg1 = arg1;
            inValue.arg2 = arg2;
            inValue.arg3 = arg3;
            inValue.arg4 = arg4;
            return ((WebApplication1.ServiceReference1.VoosWebService)(this)).consultarVoosAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebApplication1.ServiceReference1.reservarPassagemResponse WebApplication1.ServiceReference1.VoosWebService.reservarPassagem(WebApplication1.ServiceReference1.reservarPassagemRequest request) {
            return base.Channel.reservarPassagem(request);
        }
        
        public bool reservarPassagem(int arg0, int arg1) {
            WebApplication1.ServiceReference1.reservarPassagemRequest inValue = new WebApplication1.ServiceReference1.reservarPassagemRequest();
            inValue.arg0 = arg0;
            inValue.arg1 = arg1;
            WebApplication1.ServiceReference1.reservarPassagemResponse retVal = ((WebApplication1.ServiceReference1.VoosWebService)(this)).reservarPassagem(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebApplication1.ServiceReference1.reservarPassagemResponse> WebApplication1.ServiceReference1.VoosWebService.reservarPassagemAsync(WebApplication1.ServiceReference1.reservarPassagemRequest request) {
            return base.Channel.reservarPassagemAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebApplication1.ServiceReference1.reservarPassagemResponse> reservarPassagemAsync(int arg0, int arg1) {
            WebApplication1.ServiceReference1.reservarPassagemRequest inValue = new WebApplication1.ServiceReference1.reservarPassagemRequest();
            inValue.arg0 = arg0;
            inValue.arg1 = arg1;
            return ((WebApplication1.ServiceReference1.VoosWebService)(this)).reservarPassagemAsync(inValue);
        }
    }
}
