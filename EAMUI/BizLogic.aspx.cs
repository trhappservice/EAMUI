using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using EAMUI.Common;
using EAMUI.Models;
using System.Diagnostics;
using System.Runtime.Remoting.Metadata;
using System.Web.Configuration;

namespace EAMUI
{
    public partial class _Default : Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        /**
        protected void genCostForcasting_Click(object sender, EventArgs e)
        {
            EAMUI.Models.eamrepo erepo = new EAMUI.Models.eamrepo();
            List<Consequence> conlist = erepo.popConsequenceDB();
            List<Likelihood> likeList = erepo.popLikelihoodDB();
            ActivityCost activityCost = erepo.popActivityCostDB();
            Lifecycle lifeCycle = erepo.popLifecycleDB();
            TLOS tlosInfo = erepo.popTLOSDB();
            buzlogic buz = new buzlogic();

            var lines = File.ReadAllLines("c:/temp/EAM_ROADSONLY_Fixed.csv");
            var file = @WebConfigurationManager.AppSettings["CostForecastFile"];

            string tmp = String.Empty;
            string csvRow = String.Empty;
            int consequenceScore = 0;
            int likeliHood = 0;
            int riskScore = 0;

            using (var stream = File.CreateText(file))
            {
                for (var i = 0; i < lines.Length; i++)
                {
                    var line = lines[i];
                    string[] strArr = line.Split(',');
                    string AssetSubtypeID = strArr[4];
                    string AssetID = strArr[6];
                    string ConstructionDate = strArr[9];
                    string Condition = strArr[10];
                    string Size1_Quantity = strArr[27];

                    if (i == 0)
                    {
                        csvRow = string.Format("{0},{1},{2},{3},{4},{5},{6},", "AssetSubtypeID", "AssetID", "ConstructionDate", "Condition", "Size1_Quantity", "Consequence", "Likelihood");
                        csvRow += string.Format("{0},{1},", "Risk Score", "Starting PQI");
                        for (int k = 1; k <= 5; k++)
                        {
                            csvRow += string.Format("{0},{1},{2},{3},", "PQI", "Intervention Needed?", "PQI after Reset", " Cost");
                        }
                        stream.WriteLine(csvRow);
                    }
                    else
                    {
                        if (AssetSubtypeID.Length > 0)
                        {
                            consequenceScore = buz.getConScore(conlist, AssetSubtypeID);
                            if (Condition.Length > 0)
                            {
                                likeliHood = buz.getLikelihood(likeList, double.Parse(Condition));
                            }
                            else
                            {
                                likeliHood = 0;
                            }
                            riskScore = consequenceScore * likeliHood;
                            csvRow = string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},", AssetSubtypeID, AssetID, ConstructionDate, Condition, Size1_Quantity, consequenceScore, likeliHood, riskScore, Condition);
                            double tmpPQI = double.Parse(Condition);
                            double cost = 0;
                            for (int j = 1; j <= 5; j++)
                            {
                                double tmpPQIreset = 0.0;
                                string tmpIntervention = "";
                                tmpPQI = tmpPQI + (lifeCycle.c1);

                                if (Math.Round(tmpPQI) >= tlosInfo.target)
                                {
                                    tmpIntervention = "NO";
                                    tmpPQIreset = tmpPQI;
                                    cost = 0.0;
                                    csvRow += string.Format("{0},{1},{2},$ -,", tmpPQI, tmpIntervention, tmpPQIreset);
                                }
                                else
                                {
                                    tmpIntervention = "YES";
                                    //tmpPQIreset = 90.0;
                                    tmpPQIreset = activityCost.reset;
                                    cost = double.Parse(Size1_Quantity) * activityCost.unitCost;
                                    csvRow += string.Format("{0},{1},{2},$ {3},", tmpPQI, tmpIntervention, tmpPQIreset, Math.Round(cost));
                                }
                                tmpPQI = tmpPQIreset;

                            }
                            stream.WriteLine(csvRow);

                        }
                    }


                }
            }
            tsList.Text = string.Format("<a href='Output/EAM_Output_CostForcasting.csv' target='_blank'>Cost Forcasting Excel Generated!</a>");
        }
        **/
        protected void genCostForcasting_Click(object sender, EventArgs e)
        {
            Response.Redirect("genCostForecast.aspx");
        }
        
        protected void genRiskForcasting_Click(object sender, EventArgs e)
        {
            EAMUI.Models.eamrepo erepo = new EAMUI.Models.eamrepo();
            List<Consequence> conlist = erepo.popConsequenceDB();
            List<Likelihood> likeList = erepo.popLikelihoodDB();
            ActivityCost activityCost = erepo.popActivityCostDB();
            Lifecycle lifeCycle = erepo.popLifecycleDB();
            TLOS tlosInfo = erepo.popTLOSDB();
            buzlogic buz = new buzlogic();

            var lines = File.ReadAllLines("c:/temp/EAM_ROADSONLY_Fixed.csv");
            var file = @WebConfigurationManager.AppSettings["RiskForecastFile"];

            string tmp = String.Empty;
            string csvRow = String.Empty;
            int consequenceScore = 0;
            int likeliHood = 0;
            int riskScore = 0;

            using (var stream = File.CreateText(file))
            {
                for (var i = 0; i < lines.Length; i++)
                {
                    var line = lines[i];
                    string[] strArr = line.Split(',');
                    string AssetSubtypeID = strArr[4];
                    string AssetID = strArr[6];
                    string ConstructionDate = strArr[9];
                    string Condition = strArr[10];
                    string Size1_Quantity = strArr[27];

                    if (i == 0)
                    {
                        csvRow = string.Format("{0},{1},{2},{3},{4},{5},{6},", "AssetSubtypeID", "AssetID", "ConstructionDate", "Condition", "Size1_Quantity", "Consequence", "Likelihood");
                        csvRow += string.Format("{0},{1},", "Risk Score", "Starting PQI");
                        for (int k = 1; k <= 5; k++)
                        {
                            csvRow += string.Format("{0},{1},{2},", "PQI", "Likelihood_New", "Risk Score");
                        }
                        stream.WriteLine(csvRow);
                    }
                    else
                    {
                        if (AssetSubtypeID.Length > 0)
                        {
                            consequenceScore = buz.getConScore(conlist, AssetSubtypeID);
                            if (Condition.Length > 0)
                            {
                                likeliHood = buz.getLikelihood(likeList, double.Parse(Condition));
                            }
                            else
                            {
                                likeliHood = 0;
                            }
                            riskScore = consequenceScore * likeliHood;
                            csvRow = string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},", AssetSubtypeID, AssetID, ConstructionDate, Condition, Size1_Quantity, consequenceScore, likeliHood, riskScore, Condition);
                            double tmpPQI = double.Parse(Condition);
                            double cost = 0;
                            for (int j = 1; j <= 5; j++)
                            {
                                int tmpLikeScore = 0;
                                int tmpRiskScore = 0;

                                tmpPQI = tmpPQI + (lifeCycle.c1);
                                tmpLikeScore = buz.getLikelihood(likeList, tmpPQI);
                                tmpRiskScore = consequenceScore * tmpLikeScore;

                                csvRow += string.Format("{0},{1},{2},", tmpPQI, tmpLikeScore, tmpRiskScore);
                            }
                            stream.WriteLine(csvRow);

                        }
                    }


                }
            }
            tsList.Text = string.Format("<a href='Output/EAM_Output_RiskForcasting.csv' target='_blank'>Risk Forcasting Excel Generated!</a>");
        }

        protected void genPriority_Click(object sender, EventArgs e)
        {
            EAMUI.Models.eamrepo erepo = new EAMUI.Models.eamrepo();
            List<Consequence> conlist = erepo.popConsequenceDB();
            List<Likelihood> likeList = erepo.popLikelihoodDB();
            ActivityCost activityCost = erepo.popActivityCostDB();
            Lifecycle lifeCycle = erepo.popLifecycleDB();
            TLOS tlosInfo = erepo.popTLOSDB();
            buzlogic buz = new buzlogic();
            double budget = buz.getBudget(erepo.popBudgetForecastDB(),"2021");

            Likelihood test = new Likelihood();
            List<Likelihood> sortedList = likeList.OrderBy(Likelihood => Likelihood.criticalEnd).ToList();

            var lines = File.ReadAllLines("c:/temp/EAM_ROADSONLY_Fixed.csv");
            var file = @WebConfigurationManager.AppSettings["PriorityForecastFile"];

            string tmp = String.Empty;
            string csvRow = String.Empty;
            int consequenceScore = 0;
            int likeliHood = 0;
            int riskScore = 0;

            using (var stream = File.CreateText(file))
            {
                List<PriorityResult> resultList = new List<PriorityResult>();
                for (var i = 0; i < lines.Length; i++)
                {
                    var line = lines[i];
                    string[] strArr = line.Split(',');
                    string AssetSubtypeID = strArr[4];
                    string AssetID = strArr[6];
                    string ConstructionDate = strArr[9];
                    string Condition = strArr[10];
                    string Size1_Quantity = strArr[27];
                    PriorityResult tmpresult = new PriorityResult();

                    if (i == 0)
                    {
                        csvRow = string.Format("{0},{1},{2},{3},{4},{5},{6},", "AssetSubtypeID", "AssetID", "ConstructionDate", "Condition", "Size1_Quantity", "Consequence", "Likelihood");
                        csvRow += string.Format("{0},{1},", "Risk Score", "Starting PQI");
                        csvRow += string.Format("{0},{1},{2},{3},{4},{5}", "PQI", "Intervention Needed?", "PQI after Reset", " Cost", "Budget Remaining", "Include in Prioritized List?");
                        stream.WriteLine(csvRow);
                    }
                    else
                    {
                        if (AssetSubtypeID.Length > 0)
                        {
                            consequenceScore = buz.getConScore(conlist, AssetSubtypeID);
                            if (Condition.Length > 0)
                            {
                                likeliHood = buz.getLikelihood(likeList, double.Parse(Condition));
                            }
                            else
                            {
                                likeliHood = 0;
                            }
                            riskScore = consequenceScore * likeliHood;
                            csvRow = string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},", AssetSubtypeID, AssetID, ConstructionDate, Condition, Size1_Quantity, consequenceScore, likeliHood, riskScore, Condition);
                            double tmpPQI = double.Parse(Condition);
                            double cost = 0;
                            double tmpPQIreset = 0.0;
                            string tmpIntervention = "";
                            tmpPQI = tmpPQI + (lifeCycle.c1);

                            if (Math.Round(tmpPQI) >= tlosInfo.target)
                            {
                                tmpIntervention = "NO";
                                tmpPQIreset = tmpPQI;
                                cost = 0.0;
                                csvRow += string.Format("{0},{1},{2},$ -,", tmpPQI, tmpIntervention, tmpPQIreset);
                            }
                            else
                            {
                                if (Math.Round(tmpPQI) >= tlosInfo.failure) { 
                                    tmpIntervention = "YES";
                                    //tmpPQIreset = 90.0;
                                    tmpPQIreset = activityCost.reset;
                                    cost = double.Parse(Size1_Quantity) * activityCost.unitCost;
                                    csvRow += string.Format("{0},{1},{2},$ {3},", tmpPQI, tmpIntervention, tmpPQIreset, Math.Round(cost));
                                }
                                else
                                {
                                    tmpIntervention = "NO";
                                    tmpPQIreset = tmpPQI;
                                    cost = 0.0;
                                    csvRow += string.Format("{0},{1},{2},$ -,", tmpPQI, tmpIntervention, tmpPQIreset);
                                }
                            }
                            tmpPQI = tmpPQIreset;
                            if (tmpIntervention == "YES")
                            {
                                tmpresult.AssetSubtypeID = AssetSubtypeID;
                                tmpresult.AssetID = AssetID;
                                tmpresult.ConstructionDate = ConstructionDate;
                                tmpresult.Condition = Condition;
                                tmpresult.Size1_Quantity = Size1_Quantity;
                                tmpresult.consequenceScore = consequenceScore;
                                tmpresult.likeliHood = likeliHood;
                                tmpresult.riskScore = riskScore;
                                tmpresult.Condition = Condition;
                                tmpresult.tmpPQI = tmpPQI;
                                tmpresult.tmpIntervention = tmpIntervention;
                                tmpresult.tmpPQIreset = tmpPQIreset;
                                tmpresult.cost = cost;
                                resultList.Add(tmpresult);
                            }

                        }
                    }
                }

                List<PriorityResult> sortedList1 = resultList.OrderByDescending(PriorityResult => PriorityResult.riskScore).ToList();
                List<PriorityResult> sortedList2 = sortedList1.OrderByDescending(PriorityResult => PriorityResult.tmpPQI).ToList();

                double runningBudgetRemain = 0;

                for (int i = 0; i < sortedList2.Count; i++)
                {
                    if (budget - sortedList2[i].cost > 0 )
                    {
                        sortedList2[i].budgetRemain = budget - sortedList2[i].cost;
                        sortedList2[i].included = "YES";
                        budget = sortedList2[i].budgetRemain;
                        runningBudgetRemain = sortedList2[i].budgetRemain;
                    } else
                    {
                        sortedList2[i].included = "NO";
                        sortedList2[i].budgetRemain = runningBudgetRemain;
                    }
                }

                for (int i = 0; i < sortedList2.Count; i++)
                {
                    csvRow = string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},", sortedList2[i].AssetSubtypeID, sortedList2[i].AssetID, sortedList2[i].ConstructionDate, sortedList2[i].Condition, sortedList2[i].Size1_Quantity, sortedList2[i].consequenceScore, sortedList2[i].likeliHood, sortedList2[i].riskScore, sortedList2[i].Condition);
                    csvRow += string.Format("{0},{1},{2},$ {3},$ {4},{5}", sortedList2[i].tmpPQI, sortedList2[i].tmpIntervention, sortedList2[i].tmpPQIreset, Math.Round(sortedList2[i].cost), Math.Round(sortedList2[i].budgetRemain), sortedList2[i].included);
                    stream.WriteLine(csvRow);
                }
            }
            tsList.Text = string.Format("<a href='Output/EAM_Output_Priority.csv' target='_blank'>Priority Forcasting Excel Generated!!</a>");
        }

        protected void refresh_Click(object sender, EventArgs e)
        {

        }

        protected void refreshReporting_Click(object sender, EventArgs e)
        {
            Response.Redirect("RefreshDB/default.aspx");
        }
    }
}