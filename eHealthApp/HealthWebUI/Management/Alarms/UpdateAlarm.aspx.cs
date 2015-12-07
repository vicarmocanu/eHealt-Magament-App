using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HealthWebUI.Management.Alarms
{
    public partial class UpdateAlarm : System.Web.UI.Page
    {
        private string alarmName = "";
        private static AlarmServiceReference.AlarmServiceClient alarmService = new AlarmServiceReference.AlarmServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            alarmName = Convert.ToString(Session["alarmName"]);
            bountTxtAlarmName.Text = alarmName;
        }

        protected void updateBtn_Click(object sender, EventArgs e)
        {
            string type = txtType.Text.ToString();
            string location = txtLocation.Text.ToString();
            string status = txtStatus.Text.ToString();

            alarmService.updateAlarm(alarmName, type, location, status);

            Response.Redirect("Management/Alarms/HomeAlarms.aspx");
        }

        protected void cancelAll_Click(object sender, EventArgs e)
        {
            Response.Redirect("Management/Alarms/HomeAlarms.aspx");
        }
    }
}