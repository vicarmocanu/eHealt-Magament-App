using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HealthWebUI.Login
{
    public partial class LogIn : System.Web.UI.Page
    {
        private static UserServiceReference.UserServiceClient userService = new UserServiceReference.UserServiceClient();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string givenUsername = Convert.ToString(this.usernameTxt.Text);
            string givenPassword = Convert.ToString(this.passwordTxt.Text);

            string result = "";  //    userService.userLogIn(givenUsername, givenPassword);  Function userLogIn to be implemented in the service. Code is good otherwise.
            switch (result)
            {
                case "Fail":
                    {
                        Response.Redirect("~/Login/Error.aspx");
                        break;
                    }
                case "Manager":
                    {
                        Response.Redirect("~/Views/Manager/Home.aspx");
                        break;
                    }
                case "Staff":
                    {
                        Response.Redirect("");
                        break;
                    }
                default:
                    {
                        Response.Redirect("~/Management/Tasks/HomeTasks.aspx");   //Replace with HomeManagement when functionality is finished.
                        break;
                    }
            }
        }
    }
}