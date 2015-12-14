using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HealthCareWCFServices;
using System.Web.Security;

namespace AlarmPublisher
{
    public partial class Login : System.Web.UI.Page
    {
        private PublisherServiceReference.AlarmPublisherServiceClient publisherService = new PublisherServiceReference.AlarmPublisherServiceClient();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void PublisherLogin_Authenticate(object sender, AuthenticateEventArgs e)
        {
            string username = PublisherLogin.UserName.ToString();
            string password = PublisherLogin.Password.ToString();
            int publisherId = Convert.ToInt32(username);

            HealthCareWCFServices.AlarmPublisher targetPublisher = publisherService.getAlarmPublisher(publisherId);

            if (targetPublisher.Password == null)
            {
                PublisherLogin.FailureText = "That username is not registereded.";
            }
            else
            {
                if (targetPublisher.Password.Equals(password) != true)
                {
                    PublisherLogin.FailureText = "Password is not correct.";
                }
                else
                {
                    FormsAuthentication.RedirectFromLoginPage(PublisherLogin.UserName, PublisherLogin.RememberMeSet);
                }
            }
        }
    }
}