using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace HealthCareWCFServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ITaskService" in both code and config file together.
    [ServiceContract]
    public interface ITaskService
    {
        [OperationContract]
        void createTask(string taskName, string status, string description);

        [OperationContract]
        void updateTask(string taskName, string status, string description);

        [OperationContract]
        Task getTask(string taskName);

        [OperationContract]
        List<Task> getTasks();

        [OperationContract]
        void deleteTask(string taskName);

        [OperationContract]
        List<Task> taskStatusFilter(string status);
    }

    [DataContract]
    public class Task
    {
        private string taskName;
        private string status;
        private string description;

        [DataMemberAttribute]
        public string TaskName
        {
            get
            {
                return taskName;
            }

            set
            {
                taskName = value;
            }
        }

        [DataMemberAttribute]
        public string Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }

        [DataMemberAttribute]
        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }
    }
}
