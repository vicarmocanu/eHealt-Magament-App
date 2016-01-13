using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HealthCareModel.Object_Models;


namespace HealthCareModel.DBHandler
{
    interface IAlarmCountHandler
    {
        //create
        void createAlarmCount(string alarmName);

        //delete
        void deleteAlarmCount(int alarmId);

        //get
        AlarmCount getAlarmCount(int alarmId);

        //increment the count whenever a new user decides to attend a nearby alarm
        void incrementAlarmCount(int alarmId);
    }
}
