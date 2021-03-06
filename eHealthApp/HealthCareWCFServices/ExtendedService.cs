﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using HealthCareModel.ControlHandler;

namespace HealthCareWCFServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ExtendedService" in both code and config file together.
    public class ExtendedService : IExtendedService
    {
        private static readonly System.Object obj1 = new System.Object();
        private static readonly System.Object obj2 = new System.Object();
        private static readonly System.Object obj3 = new System.Object();
        private static readonly System.Object obj4 = new System.Object();
        private static readonly System.Object obj5 = new System.Object();
        private static readonly System.Object obj6 = new System.Object();
        private static readonly System.Object obj7 = new System.Object();
        private static readonly System.Object obj8 = new System.Object();
        private static readonly System.Object obj9 = new System.Object();
        private static readonly System.Object obj10 = new System.Object();
        private static readonly System.Object obj11 = new System.Object();
        private static readonly System.Object obj12 = new System.Object();


        public void createAlarmAttendance(string alarmName, string userName)
        {
            if (System.Threading.Monitor.TryEnter(obj1, 10000))
            {
                try
                {
                    ExtendedControl.createAlarmAttendance(alarmName, userName);
                }
                finally
                {
                    System.Threading.Monitor.Exit(obj1);
                }
            }
        }

        public void deleteAlarmAttendance(string alarmName, string userName)
        {
            if (System.Threading.Monitor.TryEnter(obj2, 10000))
            {
                try
                {
                    ExtendedControl.deleteAlarmAttendance(alarmName, userName);
                }
                finally
                {
                    System.Threading.Monitor.Exit(obj2);
                }
            }
        }

        public List<User> getAllarmAttendants(string alarmName)
        {

            List<User> alarmAttendants = new List<User>();

            if (System.Threading.Monitor.TryEnter(obj3, 10000))
            {
                try
                {

                    List<HealthCareModel.Object_Models.User> returnList = ExtendedControl.getAllarmAttendants(alarmName);

                    if (returnList.Count != 0)
                    {
                        foreach (HealthCareModel.Object_Models.User attendantHome in returnList)
                        {
                            User srvUser = new User();

                            srvUser.FirstName = attendantHome.firstName;
                            srvUser.LastName = attendantHome.lastName;
                            srvUser.UserName = attendantHome.userName;
                            srvUser.Role = attendantHome.role;

                            alarmAttendants.Add(srvUser);
                        }
                    }
                }
                catch (NullReferenceException)
                {
                }
                finally
                {
                    System.Threading.Monitor.Exit(obj3);
                }
            }

            return alarmAttendants;
        }

        public void createAlarmCount(string alarmName)
        {
            if (System.Threading.Monitor.TryEnter(obj4, 10000))
            {
                try
                {
                    ExtendedControl.createAlarmCount(alarmName);
                }
                finally
                {
                    System.Threading.Monitor.Exit(obj4);
                }
            }
        }

       // public void deleteAlarmCount(int alarmId){    } - no practical implementation yet?

        public int getAlarmCount(int alarmId)
        {
            int counts = 0;
            //ServiceAlarmCount serviceCount = new ServiceAlarmCount();
            if (System.Threading.Monitor.TryEnter(obj5, 10000))
            {
                try
                {
                    //serviceCount.AlarmId = ExtendedControl.getAlarmCount(alarmId).alarmId;
                    //serviceCount.Count = ExtendedControl.getAlarmCount(alarmId).count;
                    counts = ExtendedControl.getAlarmCount(alarmId).count;

                }
                catch (NullReferenceException)
                {

                }
                finally
                {
                    System.Threading.Monitor.Exit(obj5);
                }
            }
            return counts;
        }

      //  public void incrementAlarmCount(int alarmId) { } - no practical implementation yet

        public List<User> getTaskUsers(string taskName)
        {
            List<User> srvTaskUsers = new List<User>();

            if (System.Threading.Monitor.TryEnter(obj6, 10000))
            {
                try
                {
                    List<HealthCareModel.Object_Models.User> returnList = ExtendedControl.getTaskUsers(taskName);

                    if (returnList.Count != 0)
                    {
                        foreach (HealthCareModel.Object_Models.User userHost in returnList)
                        {
                            User srvUser = new User();

                            srvUser.FirstName = userHost.firstName;
                            srvUser.LastName = userHost.lastName;
                            srvUser.UserName = userHost.userName;
                            srvUser.Role = userHost.role;

                            srvTaskUsers.Add(srvUser);
                        }
                    }
                }
                catch (NullReferenceException)
                {
                }
                finally
                {
                    System.Threading.Monitor.Exit(obj6);
                }
            }

            return srvTaskUsers;
        }

        public List<Task> getUserTasks(string username)
        {
            List<Task> tasks = new List<Task>();

            if (System.Threading.Monitor.TryEnter(obj7, 10000))
            {
                try
                {

                    List<HealthCareModel.Object_Models.Task> returnList = ExtendedControl.getUserTasks(username);

                    if (returnList.Count != 0)
                    {
                        foreach (HealthCareModel.Object_Models.Task tskHost in returnList)
                        {
                            Task srvTask = new Task();

                            srvTask.TaskName = tskHost.taskName;
                            srvTask.Status = tskHost.status;
                            srvTask.Description = tskHost.description;

                            tasks.Add(srvTask);
                        }
                    }
                }
                catch (NullReferenceException)
                {
                }
                finally
                {
                    System.Threading.Monitor.Exit(obj7);
                }
            }

            return tasks;
        }

        public void createAssignedTask(string taskName, string username)
        {
            if (System.Threading.Monitor.TryEnter(obj8, 10000))
            {
                try
                {
                    ExtendedControl.createAssignedTask(taskName, username);
                }
                finally
                {
                    System.Threading.Monitor.Exit(obj8);
                }
            }
        }

        public void deleteAssignedTask(string taskName, string username)
        {
            if (System.Threading.Monitor.TryEnter(obj9, 10000))
            {
                try
                {
                    ExtendedControl.deleteAssignedTask(taskName, username);
                }
                finally
                {
                    System.Threading.Monitor.Exit(obj9);
                }
            }
        }

        public void createPublishedAlarm(int alarmId, int publisherId)
        {
            if (System.Threading.Monitor.TryEnter(obj10, 10000))
            {
                try
                {
                    ExtendedControl.createPublishedAlarm(alarmId, publisherId);
                }
                finally
                {
                    System.Threading.Monitor.Exit(obj10);
                }
            }
        }

        public int getPublisherId(int alarmId)
        {
            int returnId = 0;

            if (System.Threading.Monitor.TryEnter(obj11, 10000))
            {
                try
                {
                    returnId = ExtendedControl.getPublisherId(alarmId);

                }
                catch (NullReferenceException)
                {

                }
                finally
                {
                    System.Threading.Monitor.Exit(obj11);
                }
            }

            return returnId;
        }

        public void incrementAlarmCount(int alarmId)
        {
            if (System.Threading.Monitor.TryEnter(obj12, 10000))
            {
                try
                {
                    ExtendedControl.incrementAlarmCount(alarmId);
                }
                finally
                {
                    System.Threading.Monitor.Exit(obj12);
                }
            }
        }
    }
}
