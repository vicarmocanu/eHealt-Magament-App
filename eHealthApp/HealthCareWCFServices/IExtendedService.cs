using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace HealthCareWCFServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IExtendedService" in both code and config file together.
    [ServiceContract]
    public interface IExtendedService
    {
        [OperationContract]
        void createAlarmAttendance(string alarmName, string userName);

        [OperationContract]
        void deleteAlarmAttendance(string alarmName, string userName);

        [OperationContract]
        List<User> getAllarmAttendants(string alarmName);

        [OperationContract]
        void createAlarmCount(string alarmName);

        [OperationContract]
        ServiceAlarmCount getAlarmCount(int alarmId);

        [OperationContract]
        List<User> getTaskUsers(string taskName);

        [OperationContract]
        List<Task> getUserTasks(string username);

        [OperationContract]
        void createAssignedTask(string taskName, string username);

        [OperationContract]
        void deleteAssignedTask(string taskName, string username);

        [OperationContract]
        void createPublishedAlarm(int alarmId, int publisherId);

        [OperationContract]
        int getPublisherId(int alarmId);

    }

    [DataContract]
    public class ServiceAlarmCount
    {
        private int alarmId;
        private int count;

        [DataMemberAttribute]
        public int AlarmId
        {
            get
            {
                return alarmId;
            }

            set
            {
                alarmId = value;
            }
        }

        [DataMemberAttribute]
        public int Count
        {
            get
            {
                return count;
            }

            set
            {
                count = value;
            }
        }
    }
}
