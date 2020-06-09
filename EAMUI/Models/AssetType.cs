using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EAMUI.Models
{
    public class AssetType
    {
        public string AssetTypeID { get; set; }
        public string AssetTypeName { get; set; }

        public AssetType() { }
        public AssetType(string AssetTypeID, string AssetTypeName)
        {
            this.AssetTypeID = AssetTypeID;
            this.AssetTypeName = AssetTypeName;
        }
    }
}