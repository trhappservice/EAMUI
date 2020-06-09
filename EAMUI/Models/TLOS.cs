using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EAMUI.Models
{
    public class TLOS
    {
        public string id { get; set; }
        public string name { get; set; }
        public int target { get; set; }
        public int failure { get; set; }

        public TLOS() { }
        public TLOS(string id, string name, int target, int failure)
        {
            this.id = id;
            this.name = name;
            this.target = target;
            this.failure = failure;
        }
    }
}