using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace EAMUI.Admin.Likelihood
{
    public partial class Delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Request.QueryString["id"];
            string cs = WebConfigurationManager.AppSettings["DBConnectionStr"];

            using (SqlConnection con = new SqlConnection(cs))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT * FROM LIKELIHOOD WHERE ID ='" + Request.QueryString["id"] + "'";
                    con.Open();

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    cmd.Connection = con;
                    da.SelectCommand = cmd;

                    da.Fill(dt);

                    string tnp = string.Empty;

                    tnp = "<table cellpadding=\"5\" width=\"50%\" border=\"1\"><tr><td><b>Score</b></td><td><b>Critical Start</b></td><td><b>Critical End</b></td></tr>";

                    foreach (DataRow row in dt.Rows)
                    {
                        tnp += string.Format("<tr><td>{0}</td><td>{1}</td><td>{2}</td></tr>", row["SCORE"].ToString(), row["CRITICALSTART"].ToString(), row["CRITICALEND"].ToString());
                    }

                    tnp += "</table><br><br>";

                    Label1.Text = tnp;
                    HiddenField1.Value = Request.QueryString["id"];
                    con.Close();
                }
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            string test = "test=";
            test += HiddenField1.Value;


            string con = WebConfigurationManager.AppSettings["DBConnectionStr"];
            SqlConnection db = new SqlConnection(con);
            db.Open();
            string insert = "DELETE FROM LIKELIHOOD Where ID='" + HiddenField1.Value + "'";
            SqlCommand cmd = new SqlCommand(insert, db);
            int m = cmd.ExecuteNonQuery();
            if (m != 0)
            {
                Response.Redirect("default.aspx");
            }
            else
            {
                Response.Redirect("default.aspx");
            }
            db.Close();

        }
    }
}