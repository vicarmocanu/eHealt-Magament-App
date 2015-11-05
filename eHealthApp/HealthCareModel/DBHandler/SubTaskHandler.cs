using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthCareModel.Object_Models;

namespace HealthCareModel.DBHandler
{
    class SubTaskHandler : ISubTaskHandler
    {
        //create Task
        public void createSubtask(int taskId, string description, string status)
        {
            using (var db = new HealthModelsDataContext())
            {
                var subtask = new SubTask();

                subtask.taskId = taskId;
                subtask.description = description;
                subtask.status = status;

                db.SubTasks.InsertOnSubmit(subtask);
                db.SubmitChanges();
            }
        }
        //get SubTask
        public SubTask getSubtask(int taskId)
        {
            var subtask = new SubTask();

            using (var db = new HealthModelsDataContext())
            {
                var query = db.SubTasks.SingleOrDefault(targetSubtask => targetSubtask.taskId.Equals(taskId));
                subtask = query;
            }

            return subtask;
        }
        //get SubTasks
        public List<SubTask> getSubtasks()
        {
            List<SubTask> subtask = new List<SubTask>();

            using (var db = new HealthModelsDataContext())
            {
                var query = db.SubTasks.ToList();
                subtask = query;
            }

            return subtask;
        }
        //update SubTask
        public void updateSubtask(int taskId, string description, string status)
        {
            var subtask = new SubTask();

            using (var db = new HealthModelsDataContext())
            {
                subtask = db.SubTasks.SingleOrDefault(targetSubtask => targetSubtask.taskId.Equals(taskId));

                if (subtask != null)
                {
                    subtask.taskId = taskId;
                    subtask.description = description;
                    subtask.status = status;

                    db.SubmitChanges();
                }
            }
        }

        //delete SubTask
    }

}
