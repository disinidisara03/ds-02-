﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WeatherDesktopClient.HelloWeatherDesktopService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="HelloWeatherDesktopService.IWeatherService")]
    public interface IWeatherService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWeatherService/MyFunction", ReplyAction="http://tempuri.org/IWeatherService/MyFunctionResponse")]
        string MyFunction();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWeatherService/MyFunction", ReplyAction="http://tempuri.org/IWeatherService/MyFunctionResponse")]
        System.Threading.Tasks.Task<string> MyFunctionAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWeatherServiceChannel : WeatherDesktopClient.HelloWeatherDesktopService.IWeatherService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WeatherServiceClient : System.ServiceModel.ClientBase<WeatherDesktopClient.HelloWeatherDesktopService.IWeatherService>, WeatherDesktopClient.HelloWeatherDesktopService.IWeatherService {
        
        public WeatherServiceClient() {
        }
        
        public WeatherServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WeatherServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WeatherServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WeatherServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string MyFunction() {
            return base.Channel.MyFunction();
        }
        
        public System.Threading.Tasks.Task<string> MyFunctionAsync() {
            return base.Channel.MyFunctionAsync();
        }
    }
}
