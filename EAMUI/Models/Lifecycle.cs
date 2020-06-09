using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace EAMUI.Models
{
    public class Lifecycle
    {
        public string id { get; set; }
        public int c1 { get; set; }

        public Lifecycle() { }
        public Lifecycle(string id, int c1)
        {
            this.id = id;
            this.c1 = c1;
        }
    }
}