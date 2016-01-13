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
    public partial class Home : System.Web.UI.Page
    {
        private int alarmId = 0;
        private ExtendedServiceReference.ExtendedServiceClient extendedService = new ExtendedServiceReference.ExtendedServiceClient();
        private AlarmServiceReference.AlarmServiceClient alarmService = new AlarmServiceReference.AlarmServiceClient();
        private AttendAlarm attend = new AttendAlarm();
        private Alarm alarm = new Alarm();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.Page.User.Identity.IsAuthenticated)
            {
                FormsAuthentication.RedirectToLoginPage();
            }
            PageTime.Text = DateTime.Now.ToLongTimeString();
            //TestLabel.Text = attend.GetMQAlarmID().ToString();
            //TestLabel.Text = alarmService.getAlarmById(20).Name + alarmService.getAlarmById(20).Location;
            //alarm = alarmService.getAlarmById(20);
            //TestLabel.Text = Convert.ToString(alarm.Name);
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            //1. get the alarm id from RabbitMQ
            int passedId = 0;
            passedId = attend.GetMQAlarmID();
            if(passedId!= 0)
            {
                alarmId = passedId;
                alarm = alarmService.getAlarmById(alarmId);
                //2. make a nice body to show the attendant the alarm situation
                PublishedAlarm.Text = alarm.Name + alarm.Location;
                SecretLabel.Text = Convert.ToString(alarmId);
            }
        }

        protected void attendBtn_Click(object sender, EventArgs e)
        {
            Timer1.Enabled = false;

            if (SecretLabel.Text.Equals("") != true)
            {
                alarmId = Convert.ToInt32(SecretLabel.Text);
                alarm = alarmService.getAlarmById(alarmId);
                
                //3. update alarm status to attending                
                alarmService.updateAlarm(alarm.Name, alarm.Type, alarm.Location, "attending");

                //4. become an alarmAttendant
                string userName = Convert.ToString(Page.User.Identity.Name);
                extendedService.createAlarmAttendance(alarm.Name, userName);

                //5. make an alarmCount 
                extendedService.createAlarmCount(alarm.Name);

                //6. remove the alarm exchange from RabbitMQ
                AttendAlarm.DeleteAlarmQueue();

                //7. and logout...
                Response.Redirect("~/Login.aspx");

                //TestLabel.Text = Convert.ToString(alarmId);
            }
            
        }
    }
}