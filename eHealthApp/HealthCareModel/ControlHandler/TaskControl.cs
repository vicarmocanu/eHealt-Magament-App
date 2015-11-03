using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthCareModel.DBHandler;
using HealthCareModel.Object_Models;

namespace HealthCareModel.Controller
{
    public static class TaskControl
    {
        private static ITaskHandler taskHandler = new TaskHandler();

        public static void createTask(string taskName, bool status, string description)
        {
            taskHandler.createTask(taskName, status, description);
        }
    }
}
