using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using EAMUI.Models;

namespace EAMUI.Admin.Consequence
{
    public partial class Add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            eamrepo repo = new eamrepo();
            List<AssetSubType> AssetSubTypeList = repo.popAssetSubTypeSelect();
            for (int i=0; i< AssetSubTypeList.Count; i++)
            {
                assetsubtypeList.Items.Add(new ListItem(AssetSubTypeList[i].AssetSubtype, AssetSubTypeList[i].AssetSubtypeID));
            }
        }
        protected void btnCreate(object sender, EventArgs e)
        {
            int newid = 0;

            string cs = WebConfigurationManager.AppSettings["DBConnectionStr"];
            using (SqlConnection conn = new SqlConnection(cs))
            {
                using (SqlCommand cmmd = new SqlCommand())
                {
                    cmmd.Connection = conn;
                    cmmd.CommandType = CommandType.Text;
                    cmmd.CommandText = "SELECT * FROM CONSEQUENCE";
                    conn.Open();

                    SqlDataAdapter da = new SqlDataAdapter(cmmd);
                    DataTable dt = new DataTable();
                    cmmd.Connection = conn;
                    da.SelectCommand = cmmd;

                    da.Fill(dt);

                    
                    foreach (DataRow row in dt.Rows)
                    {
                        newid++;
                    }
                    conn.Close();
                }
            }



            string con = WebConfigurationManager.AppSettings["DBConnectionStr"];
            SqlConnection db = new SqlConnection(con);
            db.Open();
            string insert = "insert into CONSEQUENCE (ID,ASSETSUBTYPE,SCORE) values ('" + (newid+1) + "','" + assetsubtypeList.SelectedValue + "','" + score.Text + "')";
            SqlCommand cmd = new SqlCommand(insert, db);
            int m = cmd.ExecuteNonQuery();
            if (m != 0)
            {
                Label1.Text = "Data Inserted !!";
            }
            else
            {
                Label1.Text = "Data Inserted !!";
            }
            db.Close();
            Response.Redirect("default.aspx");
        }
    }
}