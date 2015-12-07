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
        void createSubtask(string taskName, string description, string status);

        [OperationContract]
        void updateSubtask(int id, string description, string status);

        [OperationContract]
        SubTask getSubTask(int id);

        [OperationContract]
        List<SubTask> getSubTasks();

        [OperationContract]
        void deleteSubTask(int id);

        [OperationContract]
        List<SubTask> getTaskSubTasks(string taskName);

    }

    [DataContract]
    public class SubTask
    {
        private int id;
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

        [DataMemberAttribute]
        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }
    }
}
