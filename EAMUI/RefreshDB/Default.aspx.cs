using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EAMUI.RefreshDB
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                
            }
        }



        protected void Confirm_Clicked(object sender, EventArgs e)
        {
            string tmp = "";
            tmp = "<p><b>Table of Discrepancy</b></p>";
            tmp += string.Format("<table border='0' cellspacing='5' cellpadding='5'>");
            tmp += string.Format("<tr><td><b>EAM ID</b></td><td><b>Asset</b></td><td><b>Asset Class</b></td><td><b>Asset Type</b></td><td><b>Asset SubType</b></td><td><b>AssetID</b></td><td><b>Condition</b></td><td><b>Action</b></td><td><b></b></td></tr>");
            for (int i = 0; i < 20; i++)
            {
                string tmpSelect = "<Select>";
                tmpSelect += "<option value=''> Please Select:";
                tmpSelect += "<option value='Copy'> Copy";
                tmpSelect += "<option value='Ignore'> Ignore";
                tmpSelect += "</Select>";
                tmp += string.Format("<tr><td><b><a href=''>{0}</a></b></td><td>Road Segment</td><td>ac00{1}</td><td>at00049</td><td>ast00101</td><td>{2}</td><td><b>{3}</b></td><td><b>{4}</b></td></tr>", 2184+i,i,i,"90", tmpSelect);
            }
            tmp += string.Format("</table>");
            Label1.Text = tmp;
        }
    }
}