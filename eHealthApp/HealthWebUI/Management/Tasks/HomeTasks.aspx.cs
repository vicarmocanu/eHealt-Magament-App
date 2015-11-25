using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls; 

namespace HealthWebUI.Management.Tasks
{
    public partial class HomeTasks : System.Web.UI.Page
    {

        private TaskServiceReference.TaskServiceClient taskService = new TaskServiceReference.TaskServiceClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                RepeaterDataBinding();
            }
        }

        protected void TaskRepeater_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            switch (e.CommandName.ToString())
            {
                case "updateTask":
                    string taskName = "";
                    taskName = Convert.ToString(e.CommandArgument);
                    Session["taskName"] = taskName;
                    Response.Redirect("/Management/Tasks/UpdateTask.aspx");
                    break;
                case "deleteTask":
                    string taskName2 = Convert.ToString(e.CommandArgument);
                    taskService.deleteTask(taskName2);
                    Response.Redirect(Request.RawUrl);
                    break;
                default:
                    break;        
            }
        }

        protected void createButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Management/Tasks/InsertTask.aspx");
        }

        public void RepeaterDataBinding()
        {
            this.TaskRepeater.DataSource = taskService.getTasks();
            this.TaskRepeater.DataBind();
        }

       
    }
}