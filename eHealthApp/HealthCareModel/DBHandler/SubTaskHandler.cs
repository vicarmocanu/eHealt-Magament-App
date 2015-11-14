using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HealthCareModel.Object_Models;

namespace HealthCareModel.DBHandler
{
    class SubTaskHandler : ISubTaskHandler
    {
        //create SubTask
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

        //delete SubTask
        public void deleteSubTask(int id)
        {
            using (var db = new HealthModelsDataContext())
            {
                SubTask subTask = db.SubTasks.SingleOrDefault(targetSubTask => targetSubTask.id == id);

                if (subTask != null)
                {
                    db.SubTasks.DeleteOnSubmit(subTask);
                    db.SubmitChanges();
                }
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

        //get specific task subtasks
        public List<SubTask> getTaskSubTasks(string taskName)
        {
            List<SubTask> taskSubTasks = new List<SubTask>();

            using (var db = new HealthModelsDataContext())
            {
                Task task = db.Tasks.SingleOrDefault(targetTask => targetTask.taskName.Equals(taskName));
                if (task != null)
                {
                    var query = db.SubTasks.Where(subTask => subTask.taskId == task.id).ToList();
                    taskSubTasks = query;
                }
            }

            return taskSubTasks;
        }

    }

}
