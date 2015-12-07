using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HealthWebUI.Management.User
{
    public partial class AddAssignedUser : System.Web.UI.Page
    {
        string taskName = "";
        private static ExtendedServiceReference.ExtendedServiceClient extendedService = new ExtendedServiceReference.ExtendedServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            taskName = Convert.ToString(Session["taskName"]);
            bountTxtTaskName.Text = taskName;
        }
        protected void btnAddAssignedUser_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text.ToString();

            extendedService.createAssignedTask(taskName, userName);

            Response.Redirect("/Management/User/AssignedUsers.aspx");
        }
        protected void btnCancelAll_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Management/User/AssignedUsers.aspx");
        }
    }
}