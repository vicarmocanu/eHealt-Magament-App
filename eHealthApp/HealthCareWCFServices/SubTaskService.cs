﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using HealthCareModel.Controller;

namespace HealthCareWCFServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SubTaskService" in both code and config file together.
    public class SubTaskService : ISubTaskService
    {
        //chk
        private static readonly System.Object obj1 = new System.Object();
        private static readonly System.Object obj2 = new System.Object();
        private static readonly System.Object obj3 = new System.Object();
        private static readonly System.Object obj4 = new System.Object();
        private static readonly System.Object obj5 = new System.Object();
        private static readonly System.Object obj6 = new System.Object();

        public void createSubtask(string taskName, string description, string status)
        {
            if (System.Threading.Monitor.TryEnter(obj1, 45000))
            {
                try
                {
                    SubTaskControl.createSubtask(taskName, description, status);
                }
                finally
                {
                    System.Threading.Monitor.Exit(obj1);
                }
            }
        }

        public void updateSubtask(int taskId, string description, string status)
        {
            if (System.Threading.Monitor.TryEnter(obj2, 45000))
            {
                try
                {
                    SubTaskControl.updateSubtask(taskId, description, status);
                }
                finally
                {
                    System.Threading.Monitor.Exit(obj2);
                }
            }
        }

        public SubTask getTask(int taskId)
        {
            SubTask serviceSubTask = new SubTask();
            if (System.Threading.Monitor.TryEnter(obj3, 45000))
            {
                try
                {
                    serviceSubTask.TaskId = SubTaskControl.getSubtask(taskId).taskId;
                    serviceSubTask.Status = SubTaskControl.getSubtask(taskId).status;
                    serviceSubTask.Description = SubTaskControl.getSubtask(taskId).description;
                }
                catch (NullReferenceException)
                {

                }
                finally
                {
                    System.Threading.Monitor.Exit(obj3);
                }
            }
            return serviceSubTask;
        }

        public List<SubTask> getSubTasks()
        {
            List<SubTask> subTsk = new List<SubTask>();

            if (System.Threading.Monitor.TryEnter(obj4, 45000))
            {
                try
                {

                    List<HealthCareModel.Object_Models.SubTask> returnList = SubTaskControl.getSubtasks();

                    if (returnList.Count != 0)
                    {
                        foreach (HealthCareModel.Object_Models.SubTask subTskHost in returnList)
                        {
                            SubTask serviceSubTask = new SubTask();

                            serviceSubTask.TaskId = subTskHost.taskId;
                            serviceSubTask.Status = subTskHost.status;
                            serviceSubTask.Description = subTskHost.description;

                            subTsk.Add(serviceSubTask);
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

            return subTsk;
        }

        public void deleteSubTask(int id)
        {
            if (System.Threading.Monitor.TryEnter(obj5, 45000))
            {
                try
                {
                    SubTaskControl.deleteSubTask(id);
                }
                finally
                {
                    System.Threading.Monitor.Exit(obj5);
                }
            }
        }

        public List<SubTask> getTaskSubTasks(string taskName)
        {
            List<SubTask> subTsk = new List<SubTask>();

            if (System.Threading.Monitor.TryEnter(obj6, 45000))
            {
                try
                {

                    List<HealthCareModel.Object_Models.SubTask> returnList = SubTaskControl.getTaskSubTasks(taskName);  

                    if (returnList.Count != 0)
                    {
                        foreach (HealthCareModel.Object_Models.SubTask subTskHost in returnList)
                        {
                            SubTask serviceSubTask = new SubTask();

                            serviceSubTask.TaskId = subTskHost.taskId;
                            serviceSubTask.Status = subTskHost.status;
                            serviceSubTask.Description = subTskHost.description;

                            subTsk.Add(serviceSubTask);
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

            return subTsk;
        }
    }
}
