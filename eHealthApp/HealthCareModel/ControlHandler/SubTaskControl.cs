using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HealthCareModel.Object_Models;
using HealthCareModel.DBHandler;

namespace HealthCareModel.ControlHandler
{
    public static class SubTaskControl
    {
        private static ISubTaskHandler subtaskHandler = new SubTaskHandler();

        public static void createSubtask(string taskName, string description, string status)
        {
            subtaskHandler.createSubtask(taskName, description, status);
        }

        public static void updateSubtask(int id, string description, string status)
        {
            subtaskHandler.updateSubtask(id, description, status);
        }

        public static SubTask getSubtask(int id)
        {
            return subtaskHandler.getSubtask(id);
        }

        public static List<SubTask> getSubtasks()
        {
            return subtaskHandler.getSubtasks();
        }

        public static void deleteSubTask(int id)
        {
            subtaskHandler.deleteSubTask(id);
        }

        public static List<SubTask> getTaskSubTasks(string taskName)
        {
            return subtaskHandler.getTaskSubTasks(taskName);
        }
    }
}
