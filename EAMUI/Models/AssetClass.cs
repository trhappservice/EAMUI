using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EAMUI.Models
{
    public class AssetClass
    {
        public string AssetClassCode { get; set; }
        public string AssetClassName { get; set; }

        public AssetClass() { }
        public AssetClass(string AssetClassCode, string AssetClassName)
        {
            this.AssetClassCode = AssetClassCode;
            this.AssetClassName = AssetClassName;
        }
    }
}