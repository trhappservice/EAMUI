using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EAMUI.Models
{
    public class Likelihood
    {
        public int score { get; set; }
        public double criticalStart { get; set; }
        public double criticalEnd { get; set; }

        public Likelihood() { }
        public Likelihood(int score, int criticalStart, int criticalEnd)
        {
            this.score = score;
            this.criticalStart = criticalStart;
            this.criticalEnd = criticalEnd;
        }
    }
}