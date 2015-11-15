using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HealthCareModel.Object_Models;

namespace HealthWebUI.Management.User
{
    public partial class UpdateUser : System.Web.UI.Page
    {
        private string userName = "";
        private static UserServiceReference.UserServiceClient userService = new UserServiceReference.UserServiceClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            userName = Convert.ToString(Session["userName"]);
            boundTxtUserName.Text = userName;
        }

        protected void updateBtn_Click(object sender, EventArgs e)
        {
            string fName = Convert.ToString(this.txtFName.Text);
            string lName = Convert.ToString(this.txtLName.Text);
            //string userName = Convert.ToString(this.txtUserName.Text);
            string password = Convert.ToString(this.txtPassword.Text);
            string role = Convert.ToString(this.txtRole.Text);

            userService.updateUser(fName, lName, userName, password, role);

            Response.Redirect("~/Management/User/UserHome.aspx");
        }

        protected void cancelAll_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Management/User/UserHome.aspx");
        }
    }
}