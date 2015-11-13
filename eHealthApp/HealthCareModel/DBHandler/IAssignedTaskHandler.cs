using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HealthCareModel.Object_Models;

namespace HealthCareModel.DBHandler
{
    interface IAssignedTaskHandler
    {
        List<Task> getUserTasks(string username);
    }
}
