using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HealthWebUI.Management.User
{
    
    public partial class AlarmAttendants : System.Web.UI.Page
    {
        private string alarmName = "";
        private static ExtendedServiceReference.ExtendedServiceClient extendedService = new ExtendedServiceReference.ExtendedServiceClient();
            protected void Page_Load(object sender, EventArgs e)
        {
            alarmName = Convert.ToString(Session["alarmName"]);
            boundTxtAlarmName.Text = alarmName;
            if (!IsPostBack)
            {
                RepeaterDataBinding();
            }
        }

        protected void UserRepeater_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            switch (e.CommandName.ToString())
            {
                case "deleteAttendant":
                    string username = Convert.ToString(e.CommandArgument);
                    extendedService.deleteAlarmAttendance(alarmName, username);
                    Response.Redirect(Request.RawUrl);
                    break;
                default:
                    break;
            }            
        }

        public void RepeaterDataBinding()
        {
            this.UserRepeater.DataSource = extendedService.getAllarmAttendants(alarmName);
            this.UserRepeater.DataBind();
        }
    }
}