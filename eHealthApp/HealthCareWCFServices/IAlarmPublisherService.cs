using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace HealthCareWCFServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IAlarmPublisherService" in both code and config file together.
    [ServiceContract]
    public interface IAlarmPublisherService
    {
        [OperationContract]
        void createAlarmPublisher(string pacientName, string condition, string location, string password);

        [OperationContract]
        void updateAlarmPublisher(int id, string pacientName, string condition, string location, string password);

        [OperationContract]
        AlarmPublisher getAlarmPublisher(int id);

        [OperationContract]
        List<AlarmPublisher> getAllAlarmPublishers();
    }

    [DataContract]
    public class AlarmPublisher
    {
        private int id;
        private string pacientName;
        private string condition;
        private string location;
        private string password;

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

        [DataMemberAttribute]
        public string PacientName
        {
            get
            {
                return pacientName;
            }

            set
            {
                pacientName = value;
            }
        }

        [DataMemberAttribute]
        public string Condition
        {
            get
            {
                return condition;
            }

            set
            {
                condition = value;
            }
        }

        [DataMemberAttribute]
        public string Location
        {
            get
            {
                return location;
            }

            set
            {
                location = value;
            }
        }

        [DataMemberAttribute]
        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }
    }
}
