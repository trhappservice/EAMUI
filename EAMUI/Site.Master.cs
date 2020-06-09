using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EAMUI.Common;
using EAMUI.Models;

namespace EAMUI
{
    public partial class SiteMaster : MasterPage
    {
        string UserName = "";
        string Department = "";
        string Division = "";
        string Manager = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            /**
            Session["loginUserName"] = auth.GetCurrentUserName();
            TimeSpan start = TimeSpan.Parse("08:30"); // 10 PM
            TimeSpan end = TimeSpan.Parse("16:00");   // 2 AM
            TimeSpan now = DateTime.Now.TimeOfDay;

            UserInfo userInfo = new UserInfo();
            userInfo = auth.SearchUser(Session["loginUserName"].ToString());

            string tmpStr = string.Format("<b>Welcome</b>, {0} {1}<br />", userInfo.firstName, userInfo.lastName);
            //tmpStr += string.Format("<b>Division</b>: {0}<br />", userInfo.division);
            //tmpStr += string.Format("<b>Department</b>: {0}<br />", userInfo.department);
            //tmpStr += string.Format("<b>Manager</b>: {0}<br />", userInfo.manager);
            lbl1.Text = tmpStr;
            

            UserName = userInfo.firstName + " " + userInfo.lastName;
            Department = userInfo.department;
            Division = userInfo.division;
            Manager = userInfo.manager;
            Session["userinfo"] = userInfo;
            Session["mgrEmail"] = userInfo.mgrEmail;
            Session["email"] = userInfo.email;
            **/
        }
    }
}