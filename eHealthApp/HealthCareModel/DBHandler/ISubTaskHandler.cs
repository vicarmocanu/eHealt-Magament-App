using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthCareModel.Object_Models;

namespace HealthCareModel.DBHandler
{
    interface ISubTaskHandler
    {
        //create subtask
        void createSubtask(int taskId, string description, string status);

        //update subtask
        void updateSubtask(int taskId, string description, string status);

        //get subtask

        SubTask getSubtask(int taskId);

        //get all subtasks

        List<SubTask> getSubtasks();
    }
}
