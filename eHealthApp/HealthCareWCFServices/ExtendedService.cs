using HealthCareModel.ControlHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

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


        public void createAlarmAttendance(string alarmName, string userName)
        {
            if (System.Threading.Monitor.TryEnter(obj1, 45000))
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

        public void deleteAlarmAttendance(int alarmId, int userId)
        {
            if (System.Threading.Monitor.TryEnter(obj2, 45000))
            {
                try
                {
                    ExtendedControl.deleteAlarmAttendance(alarmId, userId);
                }
                finally
                {
                    System.Threading.Monitor.Exit(obj2);
                }
            }
        }

        public List<User> getAllarmAttendants(int alarmId)
        {

            List<User> alarmAttendants = new List<User>();

            if (System.Threading.Monitor.TryEnter(obj3, 45000))
            {
                try
                {

                    List<HealthCareModel.Object_Models.User> returnList = ExtendedControl.getAllarmAttendants(alarmId);

                    if (returnList.Count != 0)
                    {
                        foreach (HealthCareModel.Object_Models.User attendantHome in returnList)
                        {
                            User srvUser = new User();

                            srvUser.FirstName = attendantHome.firstName;
                            srvUser.LastName = attendantHome.lastName;
                            srvUser.UserName = attendantHome.userName;

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
            if (System.Threading.Monitor.TryEnter(obj4, 45000))
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

        public ServiceAlarmCount getAlarmCount(int alarmId)
        {
            ServiceAlarmCount serviceCount = new ServiceAlarmCount();
            if (System.Threading.Monitor.TryEnter(obj6, 45000))
            {
                try
                {
                    serviceCount.AlarmId = ExtendedControl.getAlarmCount(alarmId).alarmId;
                    serviceCount.Count = ExtendedControl.getAlarmCount(alarmId).count;

                }
                catch (NullReferenceException)
                {

                }
                finally
                {
                    System.Threading.Monitor.Exit(obj6);
                }
            }
            return serviceCount;
        }

      //  public void incrementAlarmCount(int alarmId) { } - no practical implementation yet

        public List<User> getTaskUsers(string taskName)
        {
            List<User> srvTaskUsers = new List<User>();

            if (System.Threading.Monitor.TryEnter(obj8, 45000))
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

                            srvTaskUsers.Add(srvUser);
                        }
                    }
                }
                catch (NullReferenceException)
                {
                }
                finally
                {
                    System.Threading.Monitor.Exit(obj8);
                }
            }

            return srvTaskUsers;
        }

        public List<Task> getUserTasks(string username)
        {
            List<Task> tasks = new List<Task>();

            if (System.Threading.Monitor.TryEnter(obj9, 45000))
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
                    System.Threading.Monitor.Exit(obj9);
                }
            }

            return tasks;
        }

        public void createAssignedTask(string taskName, string username)
        {
            if (System.Threading.Monitor.TryEnter(obj10, 45000))
            {
                try
                {
                    ExtendedControl.createAssignedTask(taskName, username);
                }
                finally
                {
                    System.Threading.Monitor.Exit(obj10);
                }
            }
        }

        public void deleteAssignedTask(int taskId, int userId)
        {
            if (System.Threading.Monitor.TryEnter(obj11, 45000))
            {
                try
                {
                    ExtendedControl.deleteAssignedTask(taskId, userId);
                }
                finally
                {
                    System.Threading.Monitor.Exit(obj11);
                }
            }
        }
    }
}
