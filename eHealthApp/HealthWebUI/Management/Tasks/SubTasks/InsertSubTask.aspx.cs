using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HealthWebUI.Management.Tasks.SubTasks
{
    public partial class InsertSubTask : System.Web.UI.Page
    {
        String taskName = "";
        private static SubTaskServiceReference.SubTaskServiceClient subTaskService = new SubTaskServiceReference.SubTaskServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            taskName = Convert.ToString(Session["taskName"]);
            boundTxtTaskName.Text = taskName;
        }
        protected void btnAddSubTask_Click(object sender, EventArgs e)
        {
            string status = txtStatus.Text.ToString();
            string description = txtDescription.Text.ToString();

            subTaskService.createSubtask(taskName, description, status);

            Response.Redirect("/Management/Tasks/SubTasks/HomeSubTask.aspx");
        }
        protected void btnCancelAll_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Management/Tasks/SubTasks/HomeSubTask.aspx");
        }
    }
}