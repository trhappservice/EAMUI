using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EAMUI.Models.Chart;
using EAMUI.Models;
using Newtonsoft.Json;
using System.Web.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace EAMUI.api
{
    public partial class getTotalAssetByAssetClass : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string json = "";
            if (!Page.IsPostBack)
            {

                List<AssetCount> resultList = new List<AssetCount>();
                string result = "";

                string cs = WebConfigurationManager.AppSettings["DBConnectionStr"];
                using (SqlConnection con = new SqlConnection(cs))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.Text;
                        string sql = "";
                        sql += "SELECT EC.AssetClass, COUNT(*) as TOTAL ";
                        sql += "FROM EAMASSETCLASS EC ";
                        sql += "INNER JOIN EAMASSET ES ";
                        sql += "ON ES.AssetClassCode = EC.AssetClassCode ";
                        sql += "GROUP BY EC.AssetClass ";
                        sql += "ORDER BY COUNT(*) desc";

                        cmd.CommandText = sql;
                        con.Open();

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        cmd.Connection = con;
                        da.SelectCommand = cmd;

                        da.Fill(dt);


                        int i = 0;
                        foreach (DataRow row in dt.Rows)
                        {
                            if (i < 5)
                            {
                                AssetCount tmp = new AssetCount();
                                tmp.name = row["AssetClass"].ToString();
                                tmp.count = int.Parse(row["TOTAL"].ToString());
                                resultList.Add(tmp);
                                i++;
                            }
                        }

                        con.Close();
                    }
                }

                json = JsonConvert.SerializeObject(resultList, Formatting.Indented);

                Response.Clear();
                Response.ContentType = "application/json; charset=utf-8";
                Response.Write(json);
                Response.End();
            }
        }
    }
}