using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;

namespace EAMUI.Models
{
    public class PriorityResult
    {
        public string AssetSubtypeID { get; set; }
        public string AssetID { get; set; }
        public string ConstructionDate { get; set; }
        public string Condition { get; set; }

        public string Size1_Quantity { get; set; }

        public int consequenceScore { get; set; }
        public int likeliHood { get; set; }
        public int riskScore { get; set; }
        public double tmpPQI { get; set; }
        public double cost { get; set; }
        public double tmpPQIreset { get; set; }
        public string tmpIntervention { get; set; }
        public double budgetRemain { get; set; }
        public string included { get; set; }
        public PriorityResult() { }
        
        public PriorityResult(string AssetSubtypeID,string AssetID, string ConstructionDate, string Condition,string Size1_Quantity, 
            int consequenceScore, int likeliHood, int riskScore, double tmpPQI, double cost, double tmpPQIreset, string tmpIntervention,
            double budgeRemain, string included)
        {
            this.AssetSubtypeID = AssetSubtypeID;
            this.AssetID = AssetID;
            this.ConstructionDate = ConstructionDate;
            this.Condition = Condition;
            this.Size1_Quantity = Size1_Quantity;
            this.consequenceScore = consequenceScore;
            this.likeliHood = likeliHood;
            this.riskScore = riskScore;
            this.tmpPQI = tmpPQI;
            this.cost = cost;
            this.tmpPQIreset = tmpPQIreset;
            this.tmpIntervention = tmpIntervention;
        }

    }
}