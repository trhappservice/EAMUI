﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace EAMUI.Admin.Lifecycle
{
    public partial class Update : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Request.QueryString["id"];
            if (!Page.IsPostBack)
            {
                string cs = WebConfigurationManager.AppSettings["DBConnectionStr"];

                using (SqlConnection con = new SqlConnection(cs))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "SELECT * FROM LIFECYCLE WHERE ID ='" + Request.QueryString["id"] + "'";
                        con.Open();

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        cmd.Connection = con;
                        da.SelectCommand = cmd;

                        da.Fill(dt);

                        foreach (DataRow row in dt.Rows)
                        {
                            c1.Text = row["C1"].ToString();
                        }

                        HiddenField1.Value = Request.QueryString["id"];
                        con.Close();
                    }
                }
            }
        }

        protected void btnUpdate(object sender, EventArgs e)
        {
            string con = WebConfigurationManager.AppSettings["DBConnectionStr"];
            SqlConnection db = new SqlConnection(con);
            db.Open();
            string sqlstr = "Update LIFECYCLE Set C1= '" + int.Parse(c1.Text) + "' WHERE ID='" + HiddenField1.Value + "'";
            SqlCommand cmd = new SqlCommand(sqlstr, db);
            int m = cmd.ExecuteNonQuery();
            if (m != 0)
            {
                Label1.Text = "Data Updated !!";
            }
            else
            {
                Label1.Text = "Data Update !!";
            }
            db.Close();
            Response.Redirect("default.aspx");
        }
    }
}