using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HealthCareModel.Object_Models;

namespace HealthCareModel.DBHandler
{
    interface ISubTaskHandler
    {
        //create subtask
        void createSubtask(string taskName, string description, string status);

        //update subtask
        void updateSubtask(int id, string description, string status);

        //get subtask
        SubTask getSubtask(int id);

        //get all subtasks
        List<SubTask> getSubtasks();

        //delete subtask
        void deleteSubTask(int id);

        //get specific task subtasks
        List<SubTask> getTaskSubTasks(string taskName);
    }
}
