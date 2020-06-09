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

namespace EAMUI
{
    public partial class output : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string json = "";
                List<YearCost> resultList = new List<YearCost>();

                string cs = WebConfigurationManager.AppSettings["DBConnectionStr"];
                using (SqlConnection con = new SqlConnection(cs))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.Text;
                        string sql = "SELECT * from EAMASSET ";
                        if (Request["asset"] != null) {
                            if (Request["asset"].Length>0)
                            {
                                sql += string.Format("WHERE ASSET LIKE '%{0}%'", Request["asset"]);
                            }
                            else
                            {
                                sql += string.Format("WHERE ASSET LIKE '%{0}%'", "Brid");
                            }
                        } else
                        {
                            sql += string.Format("WHERE ASSET LIKE '%{0}%'", "Brid");
                        }

                        sql += " ORDER BY ConstructionInstallDate";

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
                            
                            YearCost tmp = new YearCost();
                            tmp.costYear = row["ConstructionInstallDate"].ToString();
                            if (Request["asset"] != null)
                            {
                                if (Request["asset"] == "Road Segment")
                                {
                                    if (row["Size1_Quantity"].ToString().Length>0)
                                    {
                                        string tmpStr = "";
                                        tmpStr = row["Size1_Quantity"].ToString();
                                        tmp.cost = double.Parse(tmpStr) * 60.0;
                                    } else
                                    {
                                        tmp.cost = 0.0;
                                    }
                                } else
                                {
                                    tmp.cost = double.Parse(row["ReplacementCost"].ToString());
                                }
                            } else
                            {
                                tmp.cost = double.Parse(row["ReplacementCost"].ToString());
                                
                            }
                            resultList.Add(tmp);
                            
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