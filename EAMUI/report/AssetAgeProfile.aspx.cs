using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EAMUI
{
    public partial class test1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Submit_Click(object sender, EventArgs e)
        {
            Response.Redirect("AssetAgeProfile.aspx?asset=" + assetTypeDropDown.SelectedValue); // redirect on itself
        }
    }
}