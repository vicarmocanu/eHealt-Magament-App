using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HealthWebUI.UserServiceReference;

namespace HealthWebUI.Management.User
{
    public partial class InsertUser : System.Web.UI.Page
    {
        private static UserServiceReference.IUserService userService = new UserServiceClient();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddUser_OnClick(object sender, EventArgs e)
        {
            string fName = Convert.ToString(txtFirstName.Text);
            string lName = Convert.ToString(txtLastName.Text);
            string username = Convert.ToString(txtUsername.Text);
            string password = Convert.ToString(txtPassword.Text);
            string role = Convert.ToString(txtType.Text);

            userService.createUser(fName, lName, username, password, role);
            Response.Redirect("~/Management/User/UserHome.aspx");
        }
    }
}