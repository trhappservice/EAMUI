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
using Newtonsoft.Json;

namespace EAMUI
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
                    cmd.CommandText = "SELECT count(*) as total FROM EAMASSET";
                    con.Open();

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    cmd.Connection = con;
                    da.SelectCommand = cmd;

                    da.Fill(dt);

                    string tnp = string.Empty;

                    foreach (DataRow row in dt.Rows)
                    {
                        tnp = row["total"].ToString();
                    }

                    lblTotalAssetCount.Text = tnp;

                    con.Close();
                }
            }
            getTotalAssetByAssetClass();
            lblAdminServ.Text = printAssetNumByService("Administration");
            lblEnvServ.Text = printAssetNumByService("Environmental Services");
            lblProtServ.Text = printAssetNumByService("Protection Services");
            lblRecServ.Text = printAssetNumByService("Recreation");
            lblTranServ.Text= printAssetNumByService("Transportation Services");
            lblInstallDateCnt.Text = printHealthCheckInfo("InstallationDate");
            lblBlkInstallDateCnt.Text = printHealthCheckInfo("BlkInstallationDate");
            lblConditionCnt.Text = printHealthCheckInfo("ConditionCnt");
            lblBlkConditionCnt.Text = printHealthCheckInfo("BlkConditionCnt");
        }

        private string printAssetNumByService(string service)
        {
            string result = "";

            string cs = WebConfigurationManager.AppSettings["DBConnectionStr"];
            using (SqlConnection con = new SqlConnection(cs))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    string sql = "";
                    switch (service)
                    {
                        case "Transportation Services":
                            sql = "Select count(*) as total from EAMASSET where serviceid = 'as001' or serviceid = 'as002'";
                            break;
                        case "Environmental Services":
                            sql = "Select count(*) as total from EAMASSET where serviceid = 'as003' or serviceid = 'as004' or serviceid = 'as005'";
                            break;
                        case "Recreation":
                            sql = "Select count(*) as total from EAMASSET where serviceid = 'as006' or serviceid = 'as007' or serviceid = 'as008' or serviceid = 'as009' or serviceid = 'as010'";
                            break;
                        case "Protection Services":
                            sql = "Select count(*) as total from EAMASSET where serviceid = 'as011'";
                            break;
                        case "Administration":
                            sql = "Select count(*) as total from EAMASSET where serviceid = 'as012'";
                            break;
                    }
                        
                    cmd.CommandText = sql;
                    con.Open();

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    cmd.Connection = con;
                    da.SelectCommand = cmd;

                    da.Fill(dt);

                    string tnp = string.Empty;

                    foreach (DataRow row in dt.Rows)
                    {
                        tnp = row["total"].ToString();
                    }

                    result = tnp;

                    con.Close();
                }
            }

            return result;
        }

        private string printHealthCheckInfo(string fieldname)
        {
            string result = "";

            string cs = WebConfigurationManager.AppSettings["DBConnectionStr"];
            using (SqlConnection con = new SqlConnection(cs))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    string sql = "";
                    switch (fieldname)
                    {
                        case "InstallationDate":
                            sql = "Select count(*) as Total from EAMASSET WHERE ConstructionInstallDate is not null";
                            break;
                        case "BlkInstallationDate":
                            sql = "Select count(*) as Total from EAMASSET WHERE ConstructionInstallDate is null";
                            break;
                        case "ConditionCnt":
                            sql = "Select count(*) as Total from EAMASSET WHERE Condition is not null";
                            break;
                        case "BlkConditionCnt":
                            sql = "Select count(*) as Total from EAMASSET WHERE Condition is null";
                            break;
                    }

                    cmd.CommandText = sql;
                    con.Open();

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    cmd.Connection = con;
                    da.SelectCommand = cmd;

                    da.Fill(dt);

                    string tnp = string.Empty;

                    foreach (DataRow row in dt.Rows)
                    {
                        tnp = row["total"].ToString();
                    }

                    result = tnp;

                    con.Close();
                }
            }

            return result;
        }

        private void getTotalAssetByAssetClass()
        {
            List <AssetCount> resultList = new List<AssetCount>();
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
                        if (i < 5) { 
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

            result = JsonConvert.SerializeObject(resultList, Formatting.Indented);
            System.IO.File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "\\resources\\totalAssetByAssetClass.json", result);
        }

    }
}