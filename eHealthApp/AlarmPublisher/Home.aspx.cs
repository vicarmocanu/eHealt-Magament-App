using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using HealthCareWCFServices;

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
            int publisherId = Convert.ToInt32(userName);

            //1. get the publisher data to use for the alarm he declares
            HealthCareWCFServices.AlarmPublisher alarmPublisher = publisherService.getAlarmPublisher(publisherId);
            //2. create the alarm
            alarmService.createAlarm(alarmPublisher.PacientName + " started an alarm " + DateTime.Now.ToLongTimeString() , "Pacient situation: " + alarmPublisher.Condition, "at " + alarmPublisher.Location, "started");
            //3. retrieve the fresh alarm id
            int alarmId = alarmService.getMaxId();
            //4. add an entry in the PublishedAlarms table
            extendedService.createPublishedAlarm(alarmId, publisherId);
            //5. RabbitMQ part to send the alarmId to the Alarm Receiver program           
            PanicButton.SendAlarmIdMQ(alarmId);   
        }
    }
}