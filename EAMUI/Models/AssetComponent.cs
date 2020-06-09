using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EAMUI.Models
{
    public class AssetComponent
    {
        public string AssetComponentID { get; set; }
        public string AssetComponentName { get; set; }

        public AssetComponent() { }
        public AssetComponent(string AssetComponentID, string AssetComponentName)
        {
            this.AssetComponentID = AssetComponentID;
            this.AssetComponentName = AssetComponentName;
        }
    }
}