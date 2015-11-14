﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HealthCareModel.Object_Models;

namespace HealthCareModel.DBHandler
{
    interface IAssignedTaskHandler
    {
        //to get the users assigned to a particular task
        List<User> getTaskUsers(string taskName);

        //to get the tasks assigned to a particular user
        List<Task> getUserTasks(string username);

        //create assigned tasks
        void createAssignedTask(int taskId, int userId);

        //delete assigned tasks
        void deleteAssignedTask(int taskId, int userId);
    }
}
