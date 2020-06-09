using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EAMUI.Models
{
    public class Consequence
    {
        public int score { get; set; }
        public string assetSubType { get; set; }

        public Consequence() { }

        public Consequence(int score, string assetSubType)
        {
            this.score = score;
            this.assetSubType = assetSubType;
        }
    }
}