using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HealthWebUI.Management.Tasks.SubTasks
{
    public partial class UpdateSubTask : System.Web.UI.Page
    {
        private static SubTaskServiceReference.SubTaskServiceClient subTaskService = new SubTaskServiceReference.SubTaskServiceClient();
        int subTaskId = 0;
        string taskName = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            subTaskId = Convert.ToInt32(Session["subTaskId"]);
            taskName = Convert.ToString(Session["taskName"]);
            boundTxtTaskName.Text = taskName;
        }
        protected void updateBtn_Click(object sender, EventArgs e)
        {
            string status = Convert.ToString(txtStatus.Text);
            string description = Convert.ToString(txtDescription.Text);

            subTaskService.updateSubtask(subTaskId, description, status);

            Response.Redirect("/Management/Tasks/SubTasks/HomeSubTask.aspx");
        }
        protected void cancelAll_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Management/Tasks/SubTasks/HomeSubTask.aspx");
        }
    }
}