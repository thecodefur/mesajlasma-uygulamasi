﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Bu kod bir araç tarafından oluşturuldu.
//
//     Bu dosyada yapılacak değişiklikler hatalı davranışa neden olabilir ve
//     kod yeniden oluşturulursa kaybolur.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace ServiceReference1
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/MesajEkIe", ReplyAction="http://tempuri.org/IService1/MesajEkIeResponse")]
        string MesajEkIe(string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/MesajEkIe", ReplyAction="http://tempuri.org/IService1/MesajEkIeResponse")]
        System.Threading.Tasks.Task<string> MesajEkIeAsync(string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/MesajGetir", ReplyAction="http://tempuri.org/IService1/MesajGetirResponse")]
        string MesajGetir();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/MesajGetir", ReplyAction="http://tempuri.org/IService1/MesajGetirResponse")]
        System.Threading.Tasks.Task<string> MesajGetirAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/MesajlarıSil", ReplyAction="http://tempuri.org/IService1/MesajlarıSilResponse")]
        void MesajlarıSil();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/MesajlarıSil", ReplyAction="http://tempuri.org/IService1/MesajlarıSilResponse")]
        System.Threading.Tasks.Task MesajlarıSilAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public interface IService1Channel : ServiceReference1.IService1, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<ServiceReference1.IService1>, ServiceReference1.IService1
    {
        
        /// <summary>
        /// Hizmet uç noktasını yapılandırmak için bu kısmi metodu uygulayın.
        /// </summary>
        /// <param name="serviceEndpoint">Yapılandırılacak uç nokta</param>
        /// <param name="clientCredentials">İstemci kimlik bilgileri</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public Service1Client() : 
                base(Service1Client.GetDefaultBinding(), Service1Client.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IService1.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Service1Client(EndpointConfiguration endpointConfiguration) : 
                base(Service1Client.GetBindingForEndpoint(endpointConfiguration), Service1Client.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Service1Client(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(Service1Client.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Service1Client(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(Service1Client.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public string MesajEkIe(string value)
        {
            return base.Channel.MesajEkIe(value);
        }
        
        public System.Threading.Tasks.Task<string> MesajEkIeAsync(string value)
        {
            return base.Channel.MesajEkIeAsync(value);
        }
        
        public string MesajGetir()
        {
            return base.Channel.MesajGetir();
        }
        
        public System.Threading.Tasks.Task<string> MesajGetirAsync()
        {
            return base.Channel.MesajGetirAsync();
        }
        
        public void MesajlarıSil()
        {
            base.Channel.MesajlarıSil();
        }
        
        public System.Threading.Tasks.Task MesajlarıSilAsync()
        {
            return base.Channel.MesajlarıSilAsync();
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IService1))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("\'{0}\' adlı uç nokta bulunamadı.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IService1))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:51969/Service1.svc");
            }
            throw new System.InvalidOperationException(string.Format("\'{0}\' adlı uç nokta bulunamadı.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return Service1Client.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IService1);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return Service1Client.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IService1);
        }

        internal List<string> MesajlarıGetir()
        {
            throw new NotImplementedException();
        }

        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IService1,
        }
    }
}