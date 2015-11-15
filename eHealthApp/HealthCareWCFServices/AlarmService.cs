﻿using System;
using System.Collections.Generic;
using HealthCareModel.ControlHandler;
using HealthCareModel.Controller;

namespace HealthCareWCFServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AlarmService" in both code and config file together.
    public class AlarmService : IAlarmService
    {
        private static readonly System.Object obj1 = new System.Object();
        private static readonly System.Object obj2 = new System.Object();
        private static readonly System.Object obj3 = new System.Object();
        private static readonly System.Object obj4 = new System.Object();
        private static readonly System.Object obj5 = new System.Object();

        public void createAlarm(string name, string type, string location, string status)
        {
            if (System.Threading.Monitor.TryEnter(obj1, 45000))
            {
                try
                {
                    AlarmControl.createAlarm(name, type, location, status);
                }
                finally
                {
                    System.Threading.Monitor.Exit(obj1);
                }
            }
        }
        public void updateAlarm(string name, string type, string location, string status)
        {
            if (System.Threading.Monitor.TryEnter(obj2, 45000))
            {
                try
                {
                    AlarmControl.updateAlarm(name, type, location, status);
                }
                finally
                {
                    System.Threading.Monitor.Exit(obj2);
                }
            }
        }
        public Alarm getAlarm(string name)
        {
            Alarm serviceAlarm = new Alarm();
            if (System.Threading.Monitor.TryEnter(obj3, 45000))
            {
                try
                {
                    serviceAlarm.Name = AlarmControl.getAlarm(name).name;
                    serviceAlarm.Type = AlarmControl.getAlarm(name).type;
                    
                    serviceAlarm.Location = AlarmControl.getAlarm(name).location;
                    serviceAlarm.Status = AlarmControl.getAlarm(name).status;
                    

                }
                catch (NullReferenceException)
                {

                }
                finally
                {
                    System.Threading.Monitor.Exit(obj3);
                }
            }
            return serviceAlarm;
        }
        public List<Alarm> getAlarms()
        {
            List<Alarm> alarms = new List<Alarm>();

            if (System.Threading.Monitor.TryEnter(obj4, 45000))
            {
                try
                {

                    List<HealthCareModel.Object_Models.Alarm> returnList = AlarmControl.getAlarms();

                    if (returnList.Count != 0)
                    {
                        foreach (HealthCareModel.Object_Models.Alarm alarmHost in returnList)
                        {
                            Alarm serviceAlarm = new Alarm();

                            serviceAlarm.Name = alarmHost.name;
                            serviceAlarm.Type = alarmHost.type;
                            serviceAlarm.Location = alarmHost.location;
                            serviceAlarm.Status = alarmHost.status;


                            alarms.Add(serviceAlarm);
                        }
                    }
                }
                catch (NullReferenceException)
                {
                }
                finally
                {
                    System.Threading.Monitor.Exit(obj4);
                }
            }

            return alarms;
        }
        public void deleteAlarm(string name)
        {
            if (System.Threading.Monitor.TryEnter(obj5, 45000))
            {
                try
                {
                    AlarmControl.deleteAlarm(name);
                }
                finally
                {
                    System.Threading.Monitor.Exit(obj1);
                }
            }
        }

      
    }
}