using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HealthCareWCFServices;
using System.Web.Security;

namespace AlarmReceiver
{
    public partial class Login : System.Web.UI.Page
    {
        private UserServiceReference.UserServiceClient userService = new UserServiceReference.UserServiceClient();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ReceiverLogin_Authenticate(object sender, AuthenticateEventArgs e)
        {
            string username = ReceiverLogin.UserName.ToString();
            string password = ReceiverLogin.Password.ToString();

            HealthCareWCFServices.User targetUser = userService.getUser(username);

            if (targetUser.Password == null)
            {
                ReceiverLogin.FailureText = "That username is not registereded.";
            }
            else
            {
                if (targetUser.Password.Equals(password) != true)
                {
                    ReceiverLogin.FailureText = "Password is not correct.";
                }
                else
                {
                    FormsAuthentication.RedirectFromLoginPage(ReceiverLogin.UserName, ReceiverLogin.RememberMeSet);
                }
            }            
        }
    }
}