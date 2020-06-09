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
    public partial class SearchAsset : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnSearch(object sender, EventArgs e)
        {
            string cs = WebConfigurationManager.AppSettings["DBConnectionStr"];

            using (SqlConnection con = new SqlConnection(cs))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = string.Format("SELECT * FROM EAMASSET E, EAMASSETCLASS AC, EAMASSETSERVICE AAS, EAMASSETTYPE AT , EAMASSETSUBTYPE AST where AssetID='{0}' and E.AssetClassCode = AC.AssetClassCode and E.ServiceID = AAS.ServiceID and E.AssetTypeCode = AT.AssetTypeCode and E.AssetSubtypeID = AST.AssetSubtypeID", txtAssetID.Text);
                    con.Open();

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    cmd.Connection = con;
                    da.SelectCommand = cmd;

                    da.Fill(dt);

                    string tnp = string.Empty;

                    tnp = "<table width=\"50%\" border=\"1\"><tr><td><b>EAMID</b></td><td><b>ASSETID</b></td><td><b>Service</b></td><td><b>Asset Class</b></td><td><b>Asset Type</b></td><td><b>Asset SubType</b></td><td><b>Asset</b></td><td><b>Construction Install Date</b></td><td><b>Condition</b></td><td><b>Action</b></td><td><b>Change Log</b></td></tr>";

                    foreach (DataRow row in dt.Rows)
                    {
                        tnp += string.Format("<tr><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td><td>{4}</td><td>{5}</td><td>{6}</td><td>{7}</td><td>{8}</td><td><a href='update.aspx?id={0}'>Edit</a></td><td><a href='update.aspx?id={0}'>View</a></td></tr>", row["EAMID"].ToString(), row["ASSETID"].ToString(), row["SERVICE"].ToString(), row["ASSETCLASS"].ToString(), row["ASSETTYPE"].ToString(), row["ASSETSUBTYPE"].ToString(), row["ASSET"].ToString(), row["ConstructionInstallDate"].ToString(), row["CONDITION"].ToString());
                    }

                    tnp += "</table>";

                    Label1.Text = tnp;

                    con.Close();
                }
            }
        }
    }
}