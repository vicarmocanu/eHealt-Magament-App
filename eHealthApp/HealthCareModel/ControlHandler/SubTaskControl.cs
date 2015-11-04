using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthCareModel.Object_Models;
using HealthCareModel.DBHandler;

namespace HealthCareModel.Controller
{
    public static class SubTaskControl
    {
        private static ISubTaskHandler subtaskHandler = new SubTaskHandler();

        public static void createSubtask(int taskId, string description, string status)
        {
            subtaskHandler.createSubtask(taskId, description, status);
        }

        public static void updateSubtask(int taskId, string description, string status)
        {
            subtaskHandler.updateSubtask(taskId, description, status);
        }

        public static SubTask getSubtask(int taskId)
        {
            return subtaskHandler.getSubtask(taskId);
        }

        public static List<SubTask> getSubtasks()
        {
            return subtaskHandler.getSubtasks();
        }
    }
}
