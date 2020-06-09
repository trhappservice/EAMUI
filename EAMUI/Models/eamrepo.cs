using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace EAMUI.Models
{
    public class eamrepo
    {
        public List<Consequence> popConsequence()
        {
            List<Consequence> resultList = new List<Consequence>();

            resultList.Add(new Consequence(1,""));
            resultList.Add(new Consequence(2, "ast00101"));
            resultList.Add(new Consequence(3, "ast00100"));
            resultList.Add(new Consequence(4, "ast00099"));
            resultList.Add(new Consequence(5, ""));

            return resultList;
        }

        public List<Consequence> popConsequenceDB()
        {
            List<Consequence> resultList = new List<Consequence>();

            /**resultList.Add(new Consequence(1, ""));
            resultList.Add(new Consequence(2, "ast00101"));
            resultList.Add(new Consequence(3, "ast00100"));
            resultList.Add(new Consequence(4, "ast00099"));
            resultList.Add(new Consequence(5, ""));**/


            string cs = WebConfigurationManager.AppSettings["DBConnectionStr"];

            using (SqlConnection con = new SqlConnection(cs))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT * FROM CONSEQUENCE";
                    con.Open();

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    cmd.Connection = con;
                    da.SelectCommand = cmd;

                    da.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        resultList.Add(new Consequence(int.Parse(row["SCORE"].ToString()), row["ASSETSUBTYPE"].ToString()));
                    }


                    con.Close();
                }
            }

            return resultList;
        }



        public List<Likelihood> popLikelihood()
        {
            List<Likelihood> resultList = new List<Likelihood>();

            resultList.Add(new Likelihood(1, 100, 80));
            resultList.Add(new Likelihood(2, 79, 60));
            resultList.Add(new Likelihood(3, 59, 40));
            resultList.Add(new Likelihood(4, 39, 20));
            resultList.Add(new Likelihood(5, 19, 0));

            return resultList;
        }

        public List<Likelihood> popLikelihoodDB()
        {
            List<Likelihood> resultList = new List<Likelihood>();

            /**resultList.Add(new Consequence(1, ""));
            resultList.Add(new Consequence(2, "ast00101"));
            resultList.Add(new Consequence(3, "ast00100"));
            resultList.Add(new Consequence(4, "ast00099"));
            resultList.Add(new Consequence(5, ""));**/


            string cs = WebConfigurationManager.AppSettings["DBConnectionStr"];

            using (SqlConnection con = new SqlConnection(cs))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT * FROM LIKELIHOOD";
                    con.Open();

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    cmd.Connection = con;
                    da.SelectCommand = cmd;

                    da.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        resultList.Add(new Likelihood(int.Parse(row["SCORE"].ToString()), int.Parse(row["CRITICALSTART"].ToString()), int.Parse(row["CRITICALEND"].ToString())));
                    }

                    con.Close();
                }
            }

            return resultList;
        }

        public List<BudgetForecast> popBudgetForecast()
        {
            List<BudgetForecast> resultList = new List<BudgetForecast>();

            resultList.Add(new BudgetForecast("2021", 1000000));
            resultList.Add(new BudgetForecast("2022", 1000000));
            resultList.Add(new BudgetForecast("2023", 2000000));
            resultList.Add(new BudgetForecast("2024", 2000000));
            resultList.Add(new BudgetForecast("2025", 3000000));

            return resultList;
        }

        public List<BudgetForecast> popBudgetForecastDB()
        {
            List<BudgetForecast> resultList = new List<BudgetForecast>();

            /**resultList.Add(new BudgetForecast("2021", 1000000));
            resultList.Add(new BudgetForecast("2022", 1000000));
            resultList.Add(new BudgetForecast("2023", 2000000));
            resultList.Add(new BudgetForecast("2024", 2000000));
            resultList.Add(new BudgetForecast("2025", 3000000));**/

            string cs = WebConfigurationManager.AppSettings["DBConnectionStr"];

            using (SqlConnection con = new SqlConnection(cs))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT * FROM BUDGETFORECAST";
                    con.Open();

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    cmd.Connection = con;
                    da.SelectCommand = cmd;

                    da.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        resultList.Add(new BudgetForecast(row["BUDGETYEAR"].ToString(), double.Parse(row["BUDGET"].ToString())));
                    }

                    con.Close();
                }
            }

            return resultList;
        }

        public ActivityCost popActivityCost()
        {
            return new ActivityCost("1", "Rehabilitate", "M ",70,30,90,60);
        }

        public ActivityCost popActivityCostDB()
        {
            /**return new ActivityCost("1", "Rehabilitate", "M ", 70, 30, 90, 60);**/

            ActivityCost resultList = new ActivityCost();

            string cs = WebConfigurationManager.AppSettings["DBConnectionStr"];

            using (SqlConnection con = new SqlConnection(cs))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT * FROM ACTIVITYCOST";
                    con.Open();

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    cmd.Connection = con;
                    da.SelectCommand = cmd;

                    da.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        resultList=new ActivityCost(row["ID"].ToString(),row["NAME"].ToString(), row["DESCRIPTION"].ToString(), int.Parse(row["STARTTRIGGER"].ToString()), int.Parse(row["ENDTRIGGER"].ToString()), int.Parse(row["RESET"].ToString()), double.Parse(row["UNITCOST"].ToString()));
                    }

                    con.Close();
                }
            }
            return resultList;
        }

        public Lifecycle popLifecycle()
        {
            return new Lifecycle("1", -4);
        }

        public Lifecycle popLifecycleDB()
        {
            Lifecycle resultList = new Lifecycle();

            string cs = WebConfigurationManager.AppSettings["DBConnectionStr"];

            using (SqlConnection con = new SqlConnection(cs))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT * FROM LIFECYCLE";
                    con.Open();

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    cmd.Connection = con;
                    da.SelectCommand = cmd;

                    da.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        resultList = new Lifecycle(row["ID"].ToString(), int.Parse(row["C1"].ToString()));
                    }

                    con.Close();
                }
            }
            return resultList;
        }

        public TLOS popTLOS()
        {
            return new TLOS("1", "Pavement Quality Index (PQI)",70,30);
        }

        public TLOS popTLOSDB()
        {
            /**return new TLOS("1", "Pavement Quality Index (PQI)", 70, 30);**/

            TLOS resultList = new TLOS();

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

                    foreach (DataRow row in dt.Rows)
                    {
                        resultList = new TLOS(row["ID"].ToString(), row["NAME"].ToString(), int.Parse(row["TARGET"].ToString()), int.Parse(row["FAILURE"].ToString()));
                    }

                    con.Close();
                }
            }

            return resultList;
        }


        public List<AssetSubType> popAssetSubTypeSelect()
        {
            List<AssetSubType> resultList = new List<AssetSubType>();

            string cs = WebConfigurationManager.AppSettings["DBConnectionStr"];

            using (SqlConnection con = new SqlConnection(cs))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT * FROM EAMASSETSUBTYPE order by AssetSubtype ASC";
                    con.Open();

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    cmd.Connection = con;
                    da.SelectCommand = cmd;

                    da.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        resultList.Add(new AssetSubType(row["AssetSubtypeID"].ToString(), row["AssetSubtype"].ToString()));
                    }

                    con.Close();
                }
            }
            return resultList;
        }

        public List<AssetType> popAssetTypeSelect()
        {
            List<AssetType> resultList = new List<AssetType>();

            string cs = WebConfigurationManager.AppSettings["DBConnectionStr"];

            using (SqlConnection con = new SqlConnection(cs))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT * FROM EAMASSETTYPE order by ASSETTYPE ASC";
                    con.Open();

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    cmd.Connection = con;
                    da.SelectCommand = cmd;

                    da.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        string tmp1 = row["ASSETTYPECODE"].ToString();
                        string tmp2 = row["ASSETTYPE"].ToString();
                        resultList.Add(new AssetType(tmp1, tmp2));
                    }

                    con.Close();
                }
            }
            return resultList;
        }

        public List<AssetComponent> popAssetComponentSelect()
        {
            List<AssetComponent> resultList = new List<AssetComponent>();

            string cs = WebConfigurationManager.AppSettings["DBConnectionStr"];

            using (SqlConnection con = new SqlConnection(cs))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT * FROM EAMCOMPONENT order by COMPONENT ASC";
                    con.Open();

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    cmd.Connection = con;
                    da.SelectCommand = cmd;

                    da.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        resultList.Add(new AssetComponent(row["COMPONENTCODE"].ToString(), row["COMPONENT"].ToString()));
                    }

                    con.Close();
                }
            }
            return resultList;
        }

        public List<AssetClass> popAssetClassSelect()
        {
            List<AssetClass> resultList = new List<AssetClass>();

            string cs = WebConfigurationManager.AppSettings["DBConnectionStr"];

            using (SqlConnection con = new SqlConnection(cs))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT * FROM EAMASSETCLASS order by ASSETCLASS ASC";
                    con.Open();

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    cmd.Connection = con;
                    da.SelectCommand = cmd;

                    da.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        resultList.Add(new AssetClass(row["ASSETCLASSCODE"].ToString(), row["ASSETCLASS"].ToString()));
                    }

                    con.Close();
                }
            }
            return resultList;
        }

        public List<AssetService> popAssetServiceSelect()
        {
            List<AssetService> resultList = new List<AssetService>();

            string cs = WebConfigurationManager.AppSettings["DBConnectionStr"];

            using (SqlConnection con = new SqlConnection(cs))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT * FROM EAMASSETSERVICE order by SERVICE ASC";
                    con.Open();

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    cmd.Connection = con;
                    da.SelectCommand = cmd;

                    da.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        resultList.Add(new AssetService(row["SERVICEID"].ToString(), row["SERVICE"].ToString(), row["SUBSERVICE"].ToString()));
                    }

                    con.Close();
                }
            }
            return resultList;
        }
    }
}
 