﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WhoIsBetter.WSREST.WSUsuario {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WSUsuario.IUsuarioService")]
    public interface IUsuarioService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuarioService/CrearUsuario", ReplyAction="http://tempuri.org/IUsuarioService/CrearUsuarioResponse")]
        int CrearUsuario(WhoIsBetter.Entity.Usuario usuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuarioService/CrearUsuario", ReplyAction="http://tempuri.org/IUsuarioService/CrearUsuarioResponse")]
        System.Threading.Tasks.Task<int> CrearUsuarioAsync(WhoIsBetter.Entity.Usuario usuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuarioService/ObtenerUsuarioPorID", ReplyAction="http://tempuri.org/IUsuarioService/ObtenerUsuarioPorIDResponse")]
        WhoIsBetter.Entity.Usuario ObtenerUsuarioPorID(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuarioService/ObtenerUsuarioPorID", ReplyAction="http://tempuri.org/IUsuarioService/ObtenerUsuarioPorIDResponse")]
        System.Threading.Tasks.Task<WhoIsBetter.Entity.Usuario> ObtenerUsuarioPorIDAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuarioService/ObtenerUsuarioPorCorreo", ReplyAction="http://tempuri.org/IUsuarioService/ObtenerUsuarioPorCorreoResponse")]
        WhoIsBetter.Entity.Usuario ObtenerUsuarioPorCorreo(string correo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuarioService/ObtenerUsuarioPorCorreo", ReplyAction="http://tempuri.org/IUsuarioService/ObtenerUsuarioPorCorreoResponse")]
        System.Threading.Tasks.Task<WhoIsBetter.Entity.Usuario> ObtenerUsuarioPorCorreoAsync(string correo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuarioService/ActualizarUsuario", ReplyAction="http://tempuri.org/IUsuarioService/ActualizarUsuarioResponse")]
        void ActualizarUsuario(WhoIsBetter.Entity.Usuario usuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuarioService/ActualizarUsuario", ReplyAction="http://tempuri.org/IUsuarioService/ActualizarUsuarioResponse")]
        System.Threading.Tasks.Task ActualizarUsuarioAsync(WhoIsBetter.Entity.Usuario usuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuarioService/EliminarUsuario", ReplyAction="http://tempuri.org/IUsuarioService/EliminarUsuarioResponse")]
        void EliminarUsuario(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuarioService/EliminarUsuario", ReplyAction="http://tempuri.org/IUsuarioService/EliminarUsuarioResponse")]
        System.Threading.Tasks.Task EliminarUsuarioAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuarioService/ListarUsuarios", ReplyAction="http://tempuri.org/IUsuarioService/ListarUsuariosResponse")]
        System.Collections.Generic.List<WhoIsBetter.Entity.Usuario> ListarUsuarios();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuarioService/ListarUsuarios", ReplyAction="http://tempuri.org/IUsuarioService/ListarUsuariosResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<WhoIsBetter.Entity.Usuario>> ListarUsuariosAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IUsuarioServiceChannel : WhoIsBetter.WSREST.WSUsuario.IUsuarioService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UsuarioServiceClient : System.ServiceModel.ClientBase<WhoIsBetter.WSREST.WSUsuario.IUsuarioService>, WhoIsBetter.WSREST.WSUsuario.IUsuarioService {
        
        public UsuarioServiceClient() {
        }
        
        public UsuarioServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UsuarioServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UsuarioServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UsuarioServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int CrearUsuario(WhoIsBetter.Entity.Usuario usuario) {
            return base.Channel.CrearUsuario(usuario);
        }
        
        public System.Threading.Tasks.Task<int> CrearUsuarioAsync(WhoIsBetter.Entity.Usuario usuario) {
            return base.Channel.CrearUsuarioAsync(usuario);
        }
        
        public WhoIsBetter.Entity.Usuario ObtenerUsuarioPorID(int id) {
            return base.Channel.ObtenerUsuarioPorID(id);
        }
        
        public System.Threading.Tasks.Task<WhoIsBetter.Entity.Usuario> ObtenerUsuarioPorIDAsync(int id) {
            return base.Channel.ObtenerUsuarioPorIDAsync(id);
        }
        
        public WhoIsBetter.Entity.Usuario ObtenerUsuarioPorCorreo(string correo) {
            return base.Channel.ObtenerUsuarioPorCorreo(correo);
        }
        
        public System.Threading.Tasks.Task<WhoIsBetter.Entity.Usuario> ObtenerUsuarioPorCorreoAsync(string correo) {
            return base.Channel.ObtenerUsuarioPorCorreoAsync(correo);
        }
        
        public void ActualizarUsuario(WhoIsBetter.Entity.Usuario usuario) {
            base.Channel.ActualizarUsuario(usuario);
        }
        
        public System.Threading.Tasks.Task ActualizarUsuarioAsync(WhoIsBetter.Entity.Usuario usuario) {
            return base.Channel.ActualizarUsuarioAsync(usuario);
        }
        
        public void EliminarUsuario(int id) {
            base.Channel.EliminarUsuario(id);
        }
        
        public System.Threading.Tasks.Task EliminarUsuarioAsync(int id) {
            return base.Channel.EliminarUsuarioAsync(id);
        }
        
        public System.Collections.Generic.List<WhoIsBetter.Entity.Usuario> ListarUsuarios() {
            return base.Channel.ListarUsuarios();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<WhoIsBetter.Entity.Usuario>> ListarUsuariosAsync() {
            return base.Channel.ListarUsuariosAsync();
        }
    }
}
