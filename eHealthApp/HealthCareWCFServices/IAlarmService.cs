﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace HealthCareWCFServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IAlarmService" in both code and config file together.
    [ServiceContract]
    public interface IAlarmService
    {
        [OperationContract]
        void createAlarm(string name, string type, string location, string status);

        [OperationContract]
        void updateAlarm(string name, string type, string location, string status);

        [OperationContract]
        Alarm getAlarm(string name);

        [OperationContract]
        List<Alarm> getAlarms();

        [OperationContract]
        void deleteAlarm(string name);

        
    }

    [DataContract]
    public class Alarm
    {
        private string name;
        private string type;
        private DateTime time;
        private string location;
        private string status;

        [DataMemberAttribute]
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        [DataMemberAttribute]
        public string Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
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
        public DateTime Time
        {
            get
            {
                return time;
            }

            set
            {
                time = value;
            }
        }
    }
}