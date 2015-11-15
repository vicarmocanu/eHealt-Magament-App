﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HealthWebUI.UserServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="UserServiceReference.IUserService")]
    public interface IUserService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/createUser", ReplyAction="http://tempuri.org/IUserService/createUserResponse")]
        void createUser(string firstName, string lastName, string username, string password, string role);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/createUser", ReplyAction="http://tempuri.org/IUserService/createUserResponse")]
        System.Threading.Tasks.Task createUserAsync(string firstName, string lastName, string username, string password, string role);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/updateUser", ReplyAction="http://tempuri.org/IUserService/updateUserResponse")]
        void updateUser(string firstName, string lastName, string username, string password, string role);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/updateUser", ReplyAction="http://tempuri.org/IUserService/updateUserResponse")]
        System.Threading.Tasks.Task updateUserAsync(string firstName, string lastName, string username, string password, string role);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/getUser", ReplyAction="http://tempuri.org/IUserService/getUserResponse")]
        HealthCareWCFServices.User getUser(string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/getUser", ReplyAction="http://tempuri.org/IUserService/getUserResponse")]
        System.Threading.Tasks.Task<HealthCareWCFServices.User> getUserAsync(string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/getUsers", ReplyAction="http://tempuri.org/IUserService/getUsersResponse")]
        HealthCareWCFServices.User[] getUsers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/getUsers", ReplyAction="http://tempuri.org/IUserService/getUsersResponse")]
        System.Threading.Tasks.Task<HealthCareWCFServices.User[]> getUsersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/deleteUser", ReplyAction="http://tempuri.org/IUserService/deleteUserResponse")]
        void deleteUser(string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/deleteUser", ReplyAction="http://tempuri.org/IUserService/deleteUserResponse")]
        System.Threading.Tasks.Task deleteUserAsync(string userName);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IUserServiceChannel : HealthWebUI.UserServiceReference.IUserService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UserServiceClient : System.ServiceModel.ClientBase<HealthWebUI.UserServiceReference.IUserService>, HealthWebUI.UserServiceReference.IUserService {
        
        public UserServiceClient() {
        }
        
        public UserServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UserServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void createUser(string firstName, string lastName, string username, string password, string role) {
            base.Channel.createUser(firstName, lastName, username, password, role);
        }
        
        public System.Threading.Tasks.Task createUserAsync(string firstName, string lastName, string username, string password, string role) {
            return base.Channel.createUserAsync(firstName, lastName, username, password, role);
        }
        
        public void updateUser(string firstName, string lastName, string username, string password, string role) {
            base.Channel.updateUser(firstName, lastName, username, password, role);
        }
        
        public System.Threading.Tasks.Task updateUserAsync(string firstName, string lastName, string username, string password, string role) {
            return base.Channel.updateUserAsync(firstName, lastName, username, password, role);
        }
        
        public HealthCareWCFServices.User getUser(string userName) {
            return base.Channel.getUser(userName);
        }
        
        public System.Threading.Tasks.Task<HealthCareWCFServices.User> getUserAsync(string userName) {
            return base.Channel.getUserAsync(userName);
        }
        
        public HealthCareWCFServices.User[] getUsers() {
            return base.Channel.getUsers();
        }
        
        public System.Threading.Tasks.Task<HealthCareWCFServices.User[]> getUsersAsync() {
            return base.Channel.getUsersAsync();
        }
        
        public void deleteUser(string userName) {
            base.Channel.deleteUser(userName);
        }
        
        public System.Threading.Tasks.Task deleteUserAsync(string userName) {
            return base.Channel.deleteUserAsync(userName);
        }
    }
}
