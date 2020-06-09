using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EAMUI.Models
{
    public class AssetSubType
    {
        public string AssetSubtypeID { get; set; }
        public string AssetSubtype { get; set; }
        
        public AssetSubType() { }
        public AssetSubType(string AssetSubtypeID, string AssetSubtype)
        {
            this.AssetSubtypeID = AssetSubtypeID;
            this.AssetSubtype = AssetSubtype;
        }
    }
}