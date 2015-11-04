using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareModel.DBHandler
{
    interface ITaskHandler
    {
        void createTask(string taskName, bool status, string description);

        void updateTask(string taskName, bool status, string description);

        Task getTask(string taskName);

        List<Task> getTasks();
    }
}
