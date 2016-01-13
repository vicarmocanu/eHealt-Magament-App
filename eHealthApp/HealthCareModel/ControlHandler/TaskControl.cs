using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HealthCareModel.DBHandler;
using HealthCareModel.Object_Models;

namespace HealthCareModel.ControlHandler
{
    public static class TaskControl
    {
        private static ITaskHandler taskHandler = new TaskHandler();

        public static void createTask(string taskName, string status, string description)
        {
            taskHandler.createTask(taskName, status, description);
        }

        public static Task getTask(string taskName)
        {
            return taskHandler.getTask(taskName);
        }

        public static List<Task> getTasks()
        {
            return taskHandler.getTasks();
        }

        public static void updateTask(string taskName, string status, string description)
        {
            taskHandler.updateTask(taskName, status, description);
        }

        public static void deleteTask(string taskName)
        {
            taskHandler.deleteTask(taskName);
        }

        public static List<Task> taskStatusFilter(string status)
        {
            return taskHandler.taskStatusFilter(status);
        }
    }
}
