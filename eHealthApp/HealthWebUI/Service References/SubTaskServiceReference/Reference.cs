﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HealthWebUI.SubTaskServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SubTaskServiceReference.ISubTaskService")]
    public interface ISubTaskService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISubTaskService/createSubtask", ReplyAction="http://tempuri.org/ISubTaskService/createSubtaskResponse")]
        void createSubtask(int taskId, string description, string status);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISubTaskService/createSubtask", ReplyAction="http://tempuri.org/ISubTaskService/createSubtaskResponse")]
        System.Threading.Tasks.Task createSubtaskAsync(int taskId, string description, string status);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISubTaskService/updateSubtask", ReplyAction="http://tempuri.org/ISubTaskService/updateSubtaskResponse")]
        void updateSubtask(int taskId, string description, string status);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISubTaskService/updateSubtask", ReplyAction="http://tempuri.org/ISubTaskService/updateSubtaskResponse")]
        System.Threading.Tasks.Task updateSubtaskAsync(int taskId, string description, string status);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISubTaskService/getTask", ReplyAction="http://tempuri.org/ISubTaskService/getTaskResponse")]
        HealthCareWCFServices.SubTask getTask(int taskId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISubTaskService/getTask", ReplyAction="http://tempuri.org/ISubTaskService/getTaskResponse")]
        System.Threading.Tasks.Task<HealthCareWCFServices.SubTask> getTaskAsync(int taskId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISubTaskService/getSubTasks", ReplyAction="http://tempuri.org/ISubTaskService/getSubTasksResponse")]
        HealthCareWCFServices.SubTask[] getSubTasks();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISubTaskService/getSubTasks", ReplyAction="http://tempuri.org/ISubTaskService/getSubTasksResponse")]
        System.Threading.Tasks.Task<HealthCareWCFServices.SubTask[]> getSubTasksAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISubTaskServiceChannel : HealthWebUI.SubTaskServiceReference.ISubTaskService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SubTaskServiceClient : System.ServiceModel.ClientBase<HealthWebUI.SubTaskServiceReference.ISubTaskService>, HealthWebUI.SubTaskServiceReference.ISubTaskService {
        
        public SubTaskServiceClient() {
        }
        
        public SubTaskServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SubTaskServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SubTaskServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SubTaskServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void createSubtask(int taskId, string description, string status) {
            base.Channel.createSubtask(taskId, description, status);
        }
        
        public System.Threading.Tasks.Task createSubtaskAsync(int taskId, string description, string status) {
            return base.Channel.createSubtaskAsync(taskId, description, status);
        }
        
        public void updateSubtask(int taskId, string description, string status) {
            base.Channel.updateSubtask(taskId, description, status);
        }
        
        public System.Threading.Tasks.Task updateSubtaskAsync(int taskId, string description, string status) {
            return base.Channel.updateSubtaskAsync(taskId, description, status);
        }
        
        public HealthCareWCFServices.SubTask getTask(int taskId) {
            return base.Channel.getTask(taskId);
        }
        
        public System.Threading.Tasks.Task<HealthCareWCFServices.SubTask> getTaskAsync(int taskId) {
            return base.Channel.getTaskAsync(taskId);
        }
        
        public HealthCareWCFServices.SubTask[] getSubTasks() {
            return base.Channel.getSubTasks();
        }
        
        public System.Threading.Tasks.Task<HealthCareWCFServices.SubTask[]> getSubTasksAsync() {
            return base.Channel.getSubTasksAsync();
        }
    }
}