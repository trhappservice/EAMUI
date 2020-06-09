using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace EAMUI.AssetRegistryAdmin
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void BatchUpdate_Click(object sender, EventArgs e)
        {
            Response.Redirect("BatchUpdate.aspx");
        }
        protected void SearchAsset_Click(object sender, EventArgs e)
        {
            Response.Redirect("SearchAsset.aspx");
        }
        protected void Updateby_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateBy.aspx");
        }

    }
}