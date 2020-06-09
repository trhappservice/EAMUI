using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EAMUI.Models
{
    public class AssetService
    {
        public string ServiceID { get; set; }
        public string Service { get; set; }
        public string SubService { get; set; }

        public AssetService() { }
        public AssetService(string ServiceID, string Service, string SubService)
        {
            this.ServiceID = ServiceID;
            this.Service = Service;
            this.SubService = SubService;
        }
    }
}