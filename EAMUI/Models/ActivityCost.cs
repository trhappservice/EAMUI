using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EAMUI.Models
{
    public class ActivityCost
    {
        public string id { get; set; }
        public string name { get; set; }
        public string desc { get; set; }
        public int startTrigger { get; set; }
        public int endTrigger { get; set; }
        public int reset { get; set; }
        public double unitCost { get; set; }

        public ActivityCost() { }
        public ActivityCost(string id, string name, string desc, int startTrigger, int endTrigger, int reset, double unitCost)
        {
            this.id = id;
            this.name = name;
            this.desc = desc;
            this.startTrigger = startTrigger;
            this.endTrigger = endTrigger;
            this.reset = reset;
            this.unitCost = unitCost;
        }
    }
}