using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HealthCareModel.Object_Models;

namespace HealthCareModel.DBHandler
{
    interface ITaskHandler
    {
        void createTask(string taskName, string status, string description);

        void updateTask(string taskName, string status, string description);

        Task getTask(string taskName);

        List<Task> getTasks();

        void deleteTask(string taskName);
    }
}
