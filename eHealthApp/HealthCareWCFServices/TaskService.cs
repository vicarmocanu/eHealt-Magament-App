using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using HealthCareModel.ControlHandler;

namespace HealthCareWCFServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "TaskService" in both code and config file together.
    public class TaskService : ITaskService
    {
        private static readonly System.Object obj1 = new System.Object();
        private static readonly System.Object obj2 = new System.Object();
        private static readonly System.Object obj3 = new System.Object();
        private static readonly System.Object obj4 = new System.Object();
        private static readonly System.Object obj5 = new System.Object();
        private static readonly System.Object obj6 = new System.Object();

        public void createTask(string taskName, string status, string description)
        {
            if (System.Threading.Monitor.TryEnter(obj1, 10000))
            {
                try
                {
                   TaskControl.createTask(taskName, status, description);
                }
                finally
                {
                    System.Threading.Monitor.Exit(obj1);
                }
            }
        }

        public void updateTask(string taskName, string status, string description)
        {
            if (System.Threading.Monitor.TryEnter(obj2, 10000))
            {
                try
                {
                    TaskControl.updateTask(taskName, status, description);
                }
                finally
                {
                    System.Threading.Monitor.Exit(obj2);
                }
            }
        }

        public Task getTask(string taskName)
        {
            Task serviceTask = new Task();
            if (System.Threading.Monitor.TryEnter(obj3, 10000))
            {
                try
                {
                    serviceTask.TaskName = TaskControl.getTask(taskName).taskName;
                    serviceTask.Status = TaskControl.getTask(taskName).status;
                    serviceTask.Description = TaskControl.getTask(taskName).description;
                }
                catch (NullReferenceException)
                {

                }
                finally
                {
                    System.Threading.Monitor.Exit(obj3);
                }
            }
            return serviceTask;
        }

        public List<Task> getTasks()
        {
            List<Task> tsk = new List<Task>();

            if (System.Threading.Monitor.TryEnter(obj4, 10000))
            {
                try
                {

                    List<HealthCareModel.Object_Models.Task> returnList = TaskControl.getTasks();

                    if (returnList.Count != 0)
                    {
                        foreach (HealthCareModel.Object_Models.Task tskHost in returnList)
                        {
                            Task serviceTask = new Task();

                            serviceTask.TaskName = tskHost.taskName;
                            serviceTask.Status = tskHost.status;
                            serviceTask.Description = tskHost.description;

                            tsk.Add(serviceTask);
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

            return tsk;
        }

        public void deleteTask(string taskName)
        {
            if (System.Threading.Monitor.TryEnter(obj5, 10000))
            {
                try
                {
                    TaskControl.deleteTask(taskName);
                }
                finally
                {
                    System.Threading.Monitor.Exit(obj5);
                }
            }
        }

        public List<Task> taskStatusFilter(string status)
        {
            List<Task> tsk = new List<Task>();

            if (System.Threading.Monitor.TryEnter(obj6, 10000))
            {
                try
                {

                    List<HealthCareModel.Object_Models.Task> returnList = TaskControl.taskStatusFilter(status);

                    if (returnList.Count != 0)
                    {
                        foreach (HealthCareModel.Object_Models.Task tskHost in returnList)
                        {
                            Task serviceTask = new Task();

                            serviceTask.TaskName = tskHost.taskName;
                            serviceTask.Status = tskHost.status;
                            serviceTask.Description = tskHost.description;

                            tsk.Add(serviceTask);
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

            return tsk;
        }

    }
}
