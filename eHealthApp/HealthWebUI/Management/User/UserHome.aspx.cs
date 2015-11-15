using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HealthWebUI.UserServiceReference;
using HealthCareModel.Object_Models;

namespace HealthWebUI.Management.User
{
    public partial class UserHome : System.Web.UI.Page
    {
        private UserServiceReference.UserServiceClient userService = new UserServiceReference.UserServiceClient();
        

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                RepeaterDataBinding();
            }
        }

        protected void UserRepeater_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            switch (e.CommandName.ToString())
            {
               case "updateUser":
                    string userName = Convert.ToString(e.CommandArgument);
                    Session["userName"] = userName;
                    Response.Redirect("~/Management/User/UpdateUser.aspx");
                    break;
                case "deleteUser":
                    string userName2 = Convert.ToString(e.CommandArgument);
                    //user service delete user with function using userName2 as variable
                    Response.Redirect(Request.RawUrl);
                    break;                                        
                default:
                    break;
            }
        } 

        protected void createButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Management/User/CreateUser.aspx");
        }

        public void RepeaterDataBinding()
        {
            try
            {
                this.UserRepeater.DataSource = userService.getUsers();
                this.UserRepeater.DataBind();
            }
            catch (NullReferenceException) { }
        }
    }
}