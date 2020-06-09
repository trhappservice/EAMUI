using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using EAMUI.Models;

namespace EAMUI.AssetRegistryAdmin
{
    public partial class Add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            eamrepo repo = new eamrepo();
            List<AssetType> AssetTypeList = repo.popAssetTypeSelect();
            for (int i = 0; i < AssetTypeList.Count; i++)
            {
                assetTypeList.Items.Add(new ListItem(AssetTypeList[i].AssetTypeName, AssetTypeList[i].AssetTypeID));
            }

            List<AssetSubType> AssetSubTypeList = repo.popAssetSubTypeSelect();
            for (int i = 0; i < AssetSubTypeList.Count; i++)
            {
                assetSubTypeList.Items.Add(new ListItem(AssetSubTypeList[i].AssetSubtype, AssetSubTypeList[i].AssetSubtypeID));
            }

            List<AssetClass> AssetClassList = repo.popAssetClassSelect();
            for (int i = 0; i < AssetClassList.Count; i++)
            {
                assetClassList.Items.Add(new ListItem(AssetClassList[i].AssetClassName, AssetClassList[i].AssetClassCode));
            }

            List<AssetService> AssetServiceList = repo.popAssetServiceSelect();
            for (int i = 0; i < AssetServiceList.Count; i++)
            {
                assetServiceList.Items.Add(new ListItem(AssetServiceList[i].Service+", "+ AssetServiceList[i].SubService, AssetServiceList[i].ServiceID));
            }

            List<AssetComponent> AssetComponentList = repo.popAssetComponentSelect();
            for (int i = 0; i < AssetComponentList.Count; i++)
            {
                assetComponentList.Items.Add(new ListItem(AssetComponentList[i].AssetComponentName, AssetComponentList[i].AssetComponentID));
            }
        }
        protected void btnCreate(object sender, EventArgs e)
        {
        }
    }
}