using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthCareModel.Object_Models;

namespace HealthCareModel.DBHandler
{
    class TaskHandler : ITaskHandler
    {
        public void createTask(string taskName, bool status, string description)
        {
            using (var db = new HealthModelsDataContext())
            {
                var task = new Object_Models.Task();

                task.taskName = taskName;
                task.status = status;
                task.description = description;

                db.Tasks.InsertOnSubmit(task);
                db.SubmitChanges();
            }
        }
        //to finish

        public System.Threading.Tasks.Task getTask(string taskName)
        {
            throw new NotImplementedException();
        }

        public List<System.Threading.Tasks.Task> getTasks()
        {
            throw new NotImplementedException();
        }

        public void updateTask(string taskName, bool status, string description)
        {
            throw new NotImplementedException();
        }
    }
}
