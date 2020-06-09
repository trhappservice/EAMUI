using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace EAMUI.Admin.TLOS
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string cs = WebConfigurationManager.AppSettings["DBConnectionStr"];

            using (SqlConnection con = new SqlConnection(cs))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT * FROM TLOS";
                    con.Open();

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    cmd.Connection = con;
                    da.SelectCommand = cmd;

                    da.Fill(dt);

                    string tnp = string.Empty;

                    tnp = "<table width=\"50%\" border=\"1\"><tr><td><b>Name</b></td><td><b>Target</b></td><td><b>Failure</b></td><td colspan='2' align='center'><b>Action</b></td></tr>";

                    foreach (DataRow row in dt.Rows)
                    {
                        //tnp += string.Format("<tr><td>{0}</td><td>{1}</td><td>{2}</td><td align='center'><a href='./Update.aspx?id={3}'>Edit</a></td><td align='center'><a href='./Delete.aspx?id={4}'>Delete</a></td></tr>", row["NAME"].ToString(), row["TARGET"].ToString(), row["FAILURE"].ToString(), row["ID"].ToString(), row["ID"].ToString());
                        tnp += string.Format("<tr><td>{0}</td><td>{1}</td><td>{2}</td><td align='center'><a href='./Update.aspx?id={3}'>Edit</a></td></tr>", row["NAME"].ToString(), row["TARGET"].ToString(), row["FAILURE"].ToString(), row["ID"].ToString());
                    }

                    tnp += "</table>";

                    Label1.Text = tnp;

                    con.Close();
                }
            }
        }
    }
}