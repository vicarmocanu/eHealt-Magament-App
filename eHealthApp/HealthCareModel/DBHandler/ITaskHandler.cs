using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HealthCareModel.Object_Models;

namespace HealthCareModel.DBHandler
{
    interface ITaskHandler
    {
        //create task
        void createTask(string taskName, string status, string description);

        //update task
        void updateTask(string taskName, string status, string description);

        //get task
        Task getTask(string taskName);

        //get tasks
        List<Task> getTasks();

        //delete task
        void deleteTask(string taskName);

        //status filter
        List<Task> taskStatusFilter(string status);
    }
}
