using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HealthWebUI.Management.Alarms
{
    public partial class HomeAlarms : System.Web.UI.Page
    {
        private static AlarmServiceReference.AlarmServiceClient alarmService = new AlarmServiceReference.AlarmServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                RepeaterDataBinding();
            }
        }

        protected void AlarmRepeater_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            switch (e.CommandName.ToString())
            {
                case "updateAlarm":
                    string alarmName = Convert.ToString(e.CommandArgument);
                    Session["alarmName"] = alarmName;
                    Response.Redirect("/Management/Alarms/HomeAlarms.aspx");
                    break;
                case "deleteAlarm":
                    string alarmName2 = Convert.ToString(e.CommandArgument);
                    alarmService.deleteAlarm(alarmName2);
                    Response.Redirect(Request.RawUrl);
                    break;
                case "getAttendants":
                    string alarmName3 = Convert.ToString(e.CommandArgument);
                    Session["alarmName"] = alarmName3;
                    Response.Redirect("/Management/User/AlarmAttendants.aspx");
                    break;
                default:
                    break;
            }
        }

        public void RepeaterDataBinding()
        {
            this.AlarmRepeater.DataSource = alarmService.getAlarms();
            this.AlarmRepeater.DataBind();
        }
    }
}