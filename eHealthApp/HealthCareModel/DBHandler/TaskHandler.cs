using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HealthCareModel.Object_Models;

namespace HealthCareModel.DBHandler
{
    class TaskHandler : ITaskHandler
    {
        //create task
        public void createTask(string taskName, string status, string description)
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
        //get task
        public Task getTask(string taskName)
        {
            var task = new Task();

            using (var db = new HealthModelsDataContext())
            {
                var query = db.Tasks.SingleOrDefault(targetTask => targetTask.taskName.Equals(taskName));
                task = query;
            }

            return task;
        }

        //get tasks
        public List<Task> getTasks()
        {
            List<Task> tasks = new List<Task>();

            using (var db = new HealthModelsDataContext())
            {
                var query = db.Tasks.ToList();
                tasks = query;
            }

            return tasks;
        }

        //update task
        public void updateTask(string taskName, string status, string description)
        {
            var task = new Task();

            using (var db = new HealthModelsDataContext())
            {
                task = db.Tasks.SingleOrDefault(targetTask => targetTask.taskName.Equals(taskName));

                if (task != null)
                {
                    task.taskName = taskName;
                    task.status = status;
                    task.description = description;

                    db.SubmitChanges();
                }
            }
        }

        //delete task
        public void deleteTask(string taskName)
        {
            using (var db = new HealthModelsDataContext())
            {
                var task = new Task();

                task = db.Tasks.SingleOrDefault(targetTask => targetTask.taskName.Equals(taskName));

                if(task != null)
                {
                    db.Tasks.DeleteOnSubmit(task);
                    db.SubmitChanges();
                }
            }
        }

        

    }
}
