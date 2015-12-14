using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace AlarmPublisher
{
    public partial class Home : System.Web.UI.Page
    {
        private PublisherServiceReference.AlarmPublisherServiceClient publisherService = new PublisherServiceReference.AlarmPublisherServiceClient();
        private AlarmServiceReference.AlarmServiceClient alarmService = new AlarmServiceReference.AlarmServiceClient();
        private ExtendedServiceReference.ExtendedServiceClient extendedService = new ExtendedServiceReference.ExtendedServiceClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.Page.User.Identity.IsAuthenticated)
            {
                FormsAuthentication.RedirectToLoginPage();
            }
        }

        protected void panicButton_Click(object sender, EventArgs e)
        {
            string userName = Page.User.Identity.Name;
        }
    }
}