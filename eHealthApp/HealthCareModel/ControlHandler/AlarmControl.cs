﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HealthCareModel.DBHandler;
using HealthCareModel.Object_Models;


namespace HealthCareModel.ControlHandler
{
    public static class AlarmControl
    {
        private static IAlarmHandler alarmHandler = new AlarmHandler();

        public static void createAlarm(string name, string type, string location, string status)
        {
            alarmHandler.createAlarm(name, type, location, status);
        }

        public static void updateAlarm(string name, string type, string location, string status)
        {
            alarmHandler.updateAlarm(name, type, location, status);
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

        public static int getMaxId()
        {
            return alarmHandler.getMaxId();
        }

        public static Alarm getAlarmById(int id)
        {
            return alarmHandler.getAlarmById(id);
        }
    }
}
