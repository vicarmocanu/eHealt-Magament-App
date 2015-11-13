using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HealthWebUI.Management.Tasks
{
    public partial class InsertTask : System.Web.UI.Page
    {
        private static TaskServiceReference.TaskServiceClient taskService = new TaskServiceReference.TaskServiceClient();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddTask_OnClick(object sender, EventArgs e)
        {
            string taskName = Convert.ToString(txtTaskName.Text);
            string status = Convert.ToString(txtStatus.Text);
            string description = Convert.ToString(txtDescription.Text);

            taskService.createTask(taskName, status, description);

            Response.Redirect("~/Management/Tasks/HomeTasks.aspx");
        }
    }
}