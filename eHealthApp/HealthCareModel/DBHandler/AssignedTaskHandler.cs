﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HealthCareModel.Object_Models;

namespace HealthCareModel.DBHandler
{
    class AssignedTaskHandler:IAssignedTaskHandler
    {
        //create assigned tasks
        public void createAssignedTask(string taskName, string username)
        {
            using (var db = new HealthModelsDataContext())
            {
                Task task = db.Tasks.SingleOrDefault(targetTask => targetTask.taskName.Equals(taskName));
                User user = db.Users.SingleOrDefault(targetUser => targetUser.userName.Equals(username));

                if(task!=null && user!=null)
                {
                    var assignedTask = new AssignedTask();

                    assignedTask.taskId = task.id;
                    assignedTask.userId = user.id;

                    db.AssignedTasks.InsertOnSubmit(assignedTask);
                    db.SubmitChanges();
                }

                
            }
        }

        //delete assigned tasks
        public void deleteAssignedTask(string taskName, string username)
        {
            using (var db = new HealthModelsDataContext())
            {
                Task task = db.Tasks.SingleOrDefault(targetTask => targetTask.taskName.Equals(taskName));
                User user = db.Users.SingleOrDefault(targetUser => targetUser.userName.Equals(username));

                if (task != null && user != null)
                {
                    AssignedTask assignedTask = db.AssignedTasks.SingleOrDefault(assigned => assigned.taskId == task.id && assigned.userId == user.id);

                    if (assignedTask != null)
                    {
                        db.AssignedTasks.DeleteOnSubmit(assignedTask);
                        db.SubmitChanges();
                    }
                }                    
            }
        }

        //to get the users assigned to a particular task
        public List<User> getTaskUsers(string taskName)
        {
            List<User> taskUsers = new List<User>();

            using (var db = new HealthModelsDataContext())
            {
                var taskQuery = db.Tasks.SingleOrDefault(targetTask => targetTask.taskName.Equals(taskName));
                if(taskQuery != null)
                {
                    Task task = taskQuery;
                    int taskId = task.id;

                    var query = db.AssignedTasks.Where(assigned => assigned.taskId == taskId).ToList();
                    List<AssignedTask> assignedTaskUsers = query;

                    foreach(AssignedTask assignedTask in assignedTaskUsers)
                    {
                        int userId = assignedTask.userId;
                        User taskUser = db.Users.SingleOrDefault(user => user.id == userId);
                        taskUsers.Add(taskUser);
                    }
                }
            }

            return taskUsers;
        }

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
