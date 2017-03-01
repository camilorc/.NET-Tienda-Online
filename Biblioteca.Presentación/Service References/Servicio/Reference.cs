﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Biblioteca.Presentación.Servicio {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/Servicios.Biblioteca")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
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
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Servicio.ITiendaOnline")]
    public interface ITiendaOnline {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITiendaOnline/GetData", ReplyAction="http://tempuri.org/ITiendaOnline/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITiendaOnline/GetDataUsingDataContract", ReplyAction="http://tempuri.org/ITiendaOnline/GetDataUsingDataContractResponse")]
        Biblioteca.Presentación.Servicio.CompositeType GetDataUsingDataContract(Biblioteca.Presentación.Servicio.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITiendaOnline/ValidarUsuario", ReplyAction="http://tempuri.org/ITiendaOnline/ValidarUsuarioResponse")]
        bool ValidarUsuario(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITiendaOnline/CalcularEstadisticas", ReplyAction="http://tempuri.org/ITiendaOnline/CalcularEstadisticasResponse")]
        string CalcularEstadisticas();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITiendaOnline/ListarProductos", ReplyAction="http://tempuri.org/ITiendaOnline/ListarProductosResponse")]
        string ListarProductos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITiendaOnline/ListarProductosFiltro", ReplyAction="http://tempuri.org/ITiendaOnline/ListarProductosFiltroResponse")]
        string ListarProductosFiltro(string tipo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITiendaOnline/CrearProducto", ReplyAction="http://tempuri.org/ITiendaOnline/CrearProductoResponse")]
        bool CrearProducto(string producto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITiendaOnline/ActualizarProdcuto", ReplyAction="http://tempuri.org/ITiendaOnline/ActualizarProdcutoResponse")]
        bool ActualizarProdcuto(string producto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITiendaOnline/EliminarProducto", ReplyAction="http://tempuri.org/ITiendaOnline/EliminarProductoResponse")]
        bool EliminarProducto(int idParametro);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITiendaOnline/LeerProductos", ReplyAction="http://tempuri.org/ITiendaOnline/LeerProductosResponse")]
        string LeerProductos(int idParametro);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITiendaOnlineChannel : Biblioteca.Presentación.Servicio.ITiendaOnline, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TiendaOnlineClient : System.ServiceModel.ClientBase<Biblioteca.Presentación.Servicio.ITiendaOnline>, Biblioteca.Presentación.Servicio.ITiendaOnline {
        
        public TiendaOnlineClient() {
        }
        
        public TiendaOnlineClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TiendaOnlineClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TiendaOnlineClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TiendaOnlineClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public Biblioteca.Presentación.Servicio.CompositeType GetDataUsingDataContract(Biblioteca.Presentación.Servicio.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public bool ValidarUsuario(string username, string password) {
            return base.Channel.ValidarUsuario(username, password);
        }
        
        public string CalcularEstadisticas() {
            return base.Channel.CalcularEstadisticas();
        }
        
        public string ListarProductos() {
            return base.Channel.ListarProductos();
        }
        
        public string ListarProductosFiltro(string tipo) {
            return base.Channel.ListarProductosFiltro(tipo);
        }
        
        public bool CrearProducto(string producto) {
            return base.Channel.CrearProducto(producto);
        }
        
        public bool ActualizarProdcuto(string producto) {
            return base.Channel.ActualizarProdcuto(producto);
        }
        
        public bool EliminarProducto(int idParametro) {
            return base.Channel.EliminarProducto(idParametro);
        }
        
        public string LeerProductos(int idParametro) {
            return base.Channel.LeerProductos(idParametro);
        }
    }
}
