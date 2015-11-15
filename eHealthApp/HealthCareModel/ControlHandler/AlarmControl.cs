using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HealthCareModel.DBHandler;
using HealthCareModel.Object_Models;


namespace HealthCareModel.Controller
{
    public static class AlarmControl
    {
        private static IAlarmHandler alarmHandler = new AlarmHandler();

        public static void createAlarm(string name, string type, string time, string location, string status)
        {
            alarmHandler.createAlarm(name, type, time, location, status);
        }

        public static void updateAlarm(string name, string type, string time, string location, string status)
        {
            alarmHandler.updateAlarm(name, type, time, location, status);
        }

        public static Alarm getAlarm(string name)
        {
            return alarmHandler.getAlarm(name);
        }

        public static List<Alarm> getAlarms()
        {
            return alarmHandler.getAlarms();
        }

        public static void deleteAlarm(string name)
        {
            alarmHandler.deleteAlarm(name);
        }        
    }
}
