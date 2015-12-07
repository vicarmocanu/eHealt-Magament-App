using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HealthWebUI.Management.User
{
    public partial class TaskAttendant : System.Web.UI.Page
    {
        string taskName = "";
        private static ExtendedServiceReference.ExtendedServiceClient extendedService = new ExtendedServiceReference.ExtendedServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            taskName = Convert.ToString(Session["taskName"]);
            boundTxtTaskName.Text = taskName;
            if (!IsPostBack)
            {
                RepeaterDataBinding();
            }
        }
        protected void UserRepeater_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            switch (e.CommandName.ToString())
            {
                case "deleteAssignedUser":
                    string userName = Convert.ToString(e.CommandArgument);
                    extendedService.deleteAssignedTask(taskName, userName);
                    Response.Redirect(Request.RawUrl);
                    break;
                default:
                    break;
            }
        }
        protected void addAttendant_Click(object sender, EventArgs e)
        {
            Session["taskName"] = taskName;
            Response.Redirect("/Management/User/AddAssignedUser.aspx");
        }
        public void RepeaterDataBinding()
        {
            this.UserRepeater.DataSource = extendedService.getTaskUsers(taskName);
            this.UserRepeater.DataBind();
        }
    }
}