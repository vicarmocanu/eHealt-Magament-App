using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HealthWebUI.Management.Tasks.SubTasks
{
    public partial class HomeSubTask : System.Web.UI.Page
    {
        string taskName = "";
        private static SubTaskServiceReference.SubTaskServiceClient subTaskService = new SubTaskServiceReference.SubTaskServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {           
            taskName = Convert.ToString(Session["taskName"]);
            boundTxtTaskName.Text = taskName;
            if (!IsPostBack)
            {
                RepeaterDataBinding();
            }
        }
        protected void SubTaskRepeater_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            switch(e.CommandName.ToString())
            {
                case "updateSubTask":
                    int id = Convert.ToInt32(e.CommandArgument);
                    Session["taskName"] = taskName;
                    Session["subTaskId"] = id;
                    Response.Redirect("/Management/Tasks/SubTasks/UpdateSubTask.aspx");
                    break;
                case "deleteSubTask":
                    int id2 = Convert.ToInt32(e.CommandArgument);
                    subTaskService.deleteSubTask(id2);
                    Response.Redirect(Request.RawUrl);
                    break;
                default:
                    break;
            }
        }
        protected void createButton_Click(object sender, EventArgs e)
        {
            Session["taskName"] = taskName;
            Response.Redirect("/Management/Tasks/SubTasks/InsertSubTask.aspx");
        }
        protected void returnToTasks_Click(object sender, EventArgs e)
        {
            Response.Redirect("Management/Tasks/HomeTasks.aspx");
        }
        public void RepeaterDataBinding()
        {
            this.SubTaskRepeater.DataSource = subTaskService.getTaskSubTasks(taskName);
            this.SubTaskRepeater.DataBind();
        }
    }
}