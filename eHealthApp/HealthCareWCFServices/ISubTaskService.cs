using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace HealthCareWCFServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISubTaskService" in both code and config file together.
    [ServiceContract]
    public interface ISubTaskService
    {
        [OperationContract]
        void createSubtask(int taskId, string description, string status);

        [OperationContract]
        void updateSubtask(int taskId, string description, string status);

        [OperationContract]
        SubTask getTask(int taskId);

        [OperationContract]
        List<SubTask> getSubTasks();

    }

    [DataContract]
    public class SubTask
    {
        private int taskId;
        private string status;
        private string description;

        [DataMemberAttribute]
        public int TaskId
        {
            get
            {
                return taskId;
            }

            set
            {
                taskId = value;
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
