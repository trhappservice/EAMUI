using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EAMUI.Models;
using EAMUI.Common;
using System.IO;
using System.Web.Configuration;
using Newtonsoft.Json;
using EAMUI.Models.Chart;

namespace EAMUI.repo
{
    public class repo
    {
        public void genCostForcasting()
        {
            List<YearCost> resultList = new List<YearCost>();
            string result = "[]";

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
                                YearCost tmpChartElem = new YearCost();
                                tmpChartElem.costYear = DateTime.Now.AddYears(j-1).Year.ToString();
                                tmpChartElem.cost = cost;
                                resultList.Add(tmpChartElem);
                            }
                            tmpPQI = tmpPQIreset;

                        }
                        stream.WriteLine(csvRow);
                    }
                }
            }
            result = JsonConvert.SerializeObject(resultList, Formatting.Indented);
            System.IO.File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "\\resources\\costForecastResult.json", result);
        }
    }
}