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
        void createSubtask(string taskName, string description, string status);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISubTaskService/createSubtask", ReplyAction="http://tempuri.org/ISubTaskService/createSubtaskResponse")]
        System.Threading.Tasks.Task createSubtaskAsync(string taskName, string description, string status);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISubTaskService/updateSubtask", ReplyAction="http://tempuri.org/ISubTaskService/updateSubtaskResponse")]
        void updateSubtask(int id, string description, string status);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISubTaskService/updateSubtask", ReplyAction="http://tempuri.org/ISubTaskService/updateSubtaskResponse")]
        System.Threading.Tasks.Task updateSubtaskAsync(int id, string description, string status);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISubTaskService/getSubTask", ReplyAction="http://tempuri.org/ISubTaskService/getSubTaskResponse")]
        HealthCareWCFServices.SubTask getSubTask(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISubTaskService/getSubTask", ReplyAction="http://tempuri.org/ISubTaskService/getSubTaskResponse")]
        System.Threading.Tasks.Task<HealthCareWCFServices.SubTask> getSubTaskAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISubTaskService/getSubTasks", ReplyAction="http://tempuri.org/ISubTaskService/getSubTasksResponse")]
        HealthCareWCFServices.SubTask[] getSubTasks();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISubTaskService/getSubTasks", ReplyAction="http://tempuri.org/ISubTaskService/getSubTasksResponse")]
        System.Threading.Tasks.Task<HealthCareWCFServices.SubTask[]> getSubTasksAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISubTaskService/deleteSubTask", ReplyAction="http://tempuri.org/ISubTaskService/deleteSubTaskResponse")]
        void deleteSubTask(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISubTaskService/deleteSubTask", ReplyAction="http://tempuri.org/ISubTaskService/deleteSubTaskResponse")]
        System.Threading.Tasks.Task deleteSubTaskAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISubTaskService/getTaskSubTasks", ReplyAction="http://tempuri.org/ISubTaskService/getTaskSubTasksResponse")]
        HealthCareWCFServices.SubTask[] getTaskSubTasks(string taskName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISubTaskService/getTaskSubTasks", ReplyAction="http://tempuri.org/ISubTaskService/getTaskSubTasksResponse")]
        System.Threading.Tasks.Task<HealthCareWCFServices.SubTask[]> getTaskSubTasksAsync(string taskName);
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
        
        public void createSubtask(string taskName, string description, string status) {
            base.Channel.createSubtask(taskName, description, status);
        }
        
        public System.Threading.Tasks.Task createSubtaskAsync(string taskName, string description, string status) {
            return base.Channel.createSubtaskAsync(taskName, description, status);
        }
        
        public void updateSubtask(int id, string description, string status) {
            base.Channel.updateSubtask(id, description, status);
        }
        
        public System.Threading.Tasks.Task updateSubtaskAsync(int id, string description, string status) {
            return base.Channel.updateSubtaskAsync(id, description, status);
        }
        
        public HealthCareWCFServices.SubTask getSubTask(int id) {
            return base.Channel.getSubTask(id);
        }
        
        public System.Threading.Tasks.Task<HealthCareWCFServices.SubTask> getSubTaskAsync(int id) {
            return base.Channel.getSubTaskAsync(id);
        }
        
        public HealthCareWCFServices.SubTask[] getSubTasks() {
            return base.Channel.getSubTasks();
        }
        
        public System.Threading.Tasks.Task<HealthCareWCFServices.SubTask[]> getSubTasksAsync() {
            return base.Channel.getSubTasksAsync();
        }
        
        public void deleteSubTask(int id) {
            base.Channel.deleteSubTask(id);
        }
        
        public System.Threading.Tasks.Task deleteSubTaskAsync(int id) {
            return base.Channel.deleteSubTaskAsync(id);
        }
        
        public HealthCareWCFServices.SubTask[] getTaskSubTasks(string taskName) {
            return base.Channel.getTaskSubTasks(taskName);
        }
        
        public System.Threading.Tasks.Task<HealthCareWCFServices.SubTask[]> getTaskSubTasksAsync(string taskName) {
            return base.Channel.getTaskSubTasksAsync(taskName);
        }
    }
}
