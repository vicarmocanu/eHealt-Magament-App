using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HealthCareModel.Object_Models;

namespace HealthCareModel.DBHandler
{
    class AssignedTaskHandler:IAssignedTaskHandler
    {
        //get user tasks
        public List<Task> getUserTasks(string username)
        {
            List<Task> userTasks = new List<Task>();

            using (var db = new HealthModelsDataContext())
            {
                var userQuery = db.Users.SingleOrDefault(targetUser => targetUser.userName.Equals(username));
                if (userQuery != null)
                {
                    User user = userQuery;
                    int userId = user.id;

                    var query = db.AssignedTasks.Where(assigned => assigned.userId == userId).ToList();
                    List<AssignedTask> assignedUserTasks = query;

                    foreach (AssignedTask assignedTask in assignedUserTasks)
                    {
                        int taskId = assignedTask.taskId;
                        Task userTask = db.Tasks.SingleOrDefault(task => task.id == taskId);
                        userTasks.Add(userTask);
                    }
                }
            }

            return userTasks;
        }
    }
}
