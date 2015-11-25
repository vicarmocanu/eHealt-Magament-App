using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HealthWebUI.Management.Tasks
{
    public partial class UpdateTask : System.Web.UI.Page
    {
        private string taskName = "";
        private static TaskServiceReference.TaskServiceClient taskService = new TaskServiceReference.TaskServiceClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            taskName = Convert.ToString(Session["taskName"]);
            boundTxtTaskName.Text = taskName;
        }

        protected void updateBtn_Click(object sender, EventArgs e)
        {
            string status = Convert.ToString(this.txtStatus.Text);
            string description = Convert.ToString(this.txtDescription.Text);

            taskService.updateTask(taskName, status, description);

            Response.Redirect("~/Management/Tasks/HomeTasks.aspx");
        }

        protected void cancelAll_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Management/Tasks/HomeTasks.aspx");
        }
    }
}