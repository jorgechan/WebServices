﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebService.ConsoleClient.LibraryServiceASMX {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Libros", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Libros : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int IdLibroField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TituloField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EditorialField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AreaField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int IdLibro {
            get {
                return this.IdLibroField;
            }
            set {
                if ((this.IdLibroField.Equals(value) != true)) {
                    this.IdLibroField = value;
                    this.RaisePropertyChanged("IdLibro");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Titulo {
            get {
                return this.TituloField;
            }
            set {
                if ((object.ReferenceEquals(this.TituloField, value) != true)) {
                    this.TituloField = value;
                    this.RaisePropertyChanged("Titulo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Editorial {
            get {
                return this.EditorialField;
            }
            set {
                if ((object.ReferenceEquals(this.EditorialField, value) != true)) {
                    this.EditorialField = value;
                    this.RaisePropertyChanged("Editorial");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string Area {
            get {
                return this.AreaField;
            }
            set {
                if ((object.ReferenceEquals(this.AreaField, value) != true)) {
                    this.AreaField = value;
                    this.RaisePropertyChanged("Area");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="LibraryServiceASMX.LibraryServiceSoap")]
    public interface LibraryServiceSoap {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento GetBooksResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetBooks", ReplyAction="*")]
        WebService.ConsoleClient.LibraryServiceASMX.GetBooksResponse GetBooks(WebService.ConsoleClient.LibraryServiceASMX.GetBooksRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetBooks", ReplyAction="*")]
        System.Threading.Tasks.Task<WebService.ConsoleClient.LibraryServiceASMX.GetBooksResponse> GetBooksAsync(WebService.ConsoleClient.LibraryServiceASMX.GetBooksRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetBooksRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetBooks", Namespace="http://tempuri.org/", Order=0)]
        public WebService.ConsoleClient.LibraryServiceASMX.GetBooksRequestBody Body;
        
        public GetBooksRequest() {
        }
        
        public GetBooksRequest(WebService.ConsoleClient.LibraryServiceASMX.GetBooksRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetBooksRequestBody {
        
        public GetBooksRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetBooksResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetBooksResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebService.ConsoleClient.LibraryServiceASMX.GetBooksResponseBody Body;
        
        public GetBooksResponse() {
        }
        
        public GetBooksResponse(WebService.ConsoleClient.LibraryServiceASMX.GetBooksResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetBooksResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WebService.ConsoleClient.LibraryServiceASMX.Libros[] GetBooksResult;
        
        public GetBooksResponseBody() {
        }
        
        public GetBooksResponseBody(WebService.ConsoleClient.LibraryServiceASMX.Libros[] GetBooksResult) {
            this.GetBooksResult = GetBooksResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface LibraryServiceSoapChannel : WebService.ConsoleClient.LibraryServiceASMX.LibraryServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LibraryServiceSoapClient : System.ServiceModel.ClientBase<WebService.ConsoleClient.LibraryServiceASMX.LibraryServiceSoap>, WebService.ConsoleClient.LibraryServiceASMX.LibraryServiceSoap {
        
        public LibraryServiceSoapClient() {
        }
        
        public LibraryServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LibraryServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LibraryServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LibraryServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebService.ConsoleClient.LibraryServiceASMX.GetBooksResponse WebService.ConsoleClient.LibraryServiceASMX.LibraryServiceSoap.GetBooks(WebService.ConsoleClient.LibraryServiceASMX.GetBooksRequest request) {
            return base.Channel.GetBooks(request);
        }
        
        public WebService.ConsoleClient.LibraryServiceASMX.Libros[] GetBooks() {
            WebService.ConsoleClient.LibraryServiceASMX.GetBooksRequest inValue = new WebService.ConsoleClient.LibraryServiceASMX.GetBooksRequest();
            inValue.Body = new WebService.ConsoleClient.LibraryServiceASMX.GetBooksRequestBody();
            WebService.ConsoleClient.LibraryServiceASMX.GetBooksResponse retVal = ((WebService.ConsoleClient.LibraryServiceASMX.LibraryServiceSoap)(this)).GetBooks(inValue);
            return retVal.Body.GetBooksResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebService.ConsoleClient.LibraryServiceASMX.GetBooksResponse> WebService.ConsoleClient.LibraryServiceASMX.LibraryServiceSoap.GetBooksAsync(WebService.ConsoleClient.LibraryServiceASMX.GetBooksRequest request) {
            return base.Channel.GetBooksAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebService.ConsoleClient.LibraryServiceASMX.GetBooksResponse> GetBooksAsync() {
            WebService.ConsoleClient.LibraryServiceASMX.GetBooksRequest inValue = new WebService.ConsoleClient.LibraryServiceASMX.GetBooksRequest();
            inValue.Body = new WebService.ConsoleClient.LibraryServiceASMX.GetBooksRequestBody();
            return ((WebService.ConsoleClient.LibraryServiceASMX.LibraryServiceSoap)(this)).GetBooksAsync(inValue);
        }
    }
}
