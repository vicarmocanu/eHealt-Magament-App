using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthCareModel.Object_Models;

namespace HealthCareModel.DBHandler
{
    interface IAlarmHandler
    {
        //create alarm
        void createAlarm(string name, string type, string location, string status);

        //update alarm
        void updateAlarm(string name, string type, string time, string location, string status);

        //get alarm
        Alarm getAlarm(string name);

        //get all alarms
        List<Alarm> getAlarms();

        //delete alarm
        void deleteAlarm(string name);        
    }
}
