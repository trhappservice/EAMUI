<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="EAMUI.AssetRegistryAdmin.Add" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Enterprise Asset Management UI</h3>
        <p><b>Asset Registry Admin - Add</b></p>
        <table border="0" cellpadding="5" cellspacing="5">
        <tr><td>
        <b>Asset ID</b>: </td>
        <td>
        <asp:TextBox ID="txtAssetID" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" id="RequiredFieldValidator1" 
            controltovalidate="txtAssetID" errormessage="Please enter Asset ID!" 
            SetFocusOnError="true" display="Dynamic" ForeColor="#FF0000"/>
        </td>
        </tr>
        <tr>
        <td>
        <b>AssetType</b>: 
        </td>
        <td><asp:DropDownList ID="assetTypeList" runat="server">
                        <asp:ListItem value="">Please select one:</asp:ListItem>
                      </asp:DropDownList>
        <asp:RequiredFieldValidator runat="server" id="RequiredFieldValidator2" 
            controltovalidate="assetTypeList" errormessage="Please enter Asset Type!" 
            SetFocusOnError="true" display="Dynamic" ForeColor="#FF0000"/>
        </td>
        </tr>
        <tr>
        <td>
        <b>AssetSubType</b>: </td>
        <td><asp:DropDownList ID="assetSubTypeList" runat="server">
                        <asp:ListItem value="">Please select one:</asp:ListItem>
                      </asp:DropDownList>
        <asp:RequiredFieldValidator runat="server" id="RequiredFieldValidator3" 
            controltovalidate="assetSubTypeList" errormessage="Please enter Asset Subtype!" 
            SetFocusOnError="true" display="Dynamic" ForeColor="#FF0000"/>
        </td>
        </tr>
        <tr>
        <td>
        <b>Asset Class</b>: </td>
        <td><asp:DropDownList ID="assetClassList" runat="server">
                        <asp:ListItem value="">Please select one:</asp:ListItem>
                      </asp:DropDownList>
        <asp:RequiredFieldValidator runat="server" id="RequiredFieldValidator4" 
            controltovalidate="assetClassList" errormessage="Please enter Asset Class!" 
            SetFocusOnError="true" display="Dynamic" ForeColor="#FF0000"/>
        </td>
        </tr>
        <tr>
        <td>
        <b>Asset Service</b>: </td>
        <td><asp:DropDownList ID="assetServiceList" runat="server">
                        <asp:ListItem value="">Please select one:</asp:ListItem>
                      </asp:DropDownList>
        <asp:RequiredFieldValidator runat="server" id="RequiredFieldValidator5" 
            controltovalidate="assetServiceList" errormessage="Please enter Asset Service!" 
            SetFocusOnError="true" display="Dynamic" ForeColor="#FF0000"/>
        </td>
        </tr>
        <tr>
        <td>
        <b>Asset Component</b>: </td>
        <td><asp:DropDownList ID="assetComponentList" runat="server">
                        <asp:ListItem value="">Please select one:</asp:ListItem>
                      </asp:DropDownList>
        <asp:RequiredFieldValidator runat="server" id="RequiredFieldValidator6" 
            controltovalidate="assetComponentList" errormessage="Please enter Asset Component!" 
            SetFocusOnError="true" display="Dynamic" ForeColor="#FF0000"/>
        </td>
        </tr>
        <tr>
        <td>
        <b>Data Source</b>: </td>
        <td><asp:TextBox ID="txtDataSource" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" id="RequiredFieldValidator7" 
            controltovalidate="txtDataSource" errormessage="Please enter the data source of the asset!" 
            SetFocusOnError="true" display="Dynamic" ForeColor="#FF0000"/>
        </td></tr>
        <tr><td>
        <b>Construction Install Date</b>: </td>
        <td><asp:TextBox ID="txtConstructionInstallDate" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" id="RequiredFieldValidator8" 
            controltovalidate="txtConstructionInstallDate" errormessage="Please enter the construction install date of the asset!" 
            SetFocusOnError="true" display="Dynamic" ForeColor="#FF0000"/>
        </td></tr>
        <tr>
        <td><b>Condition</b>: </td>
        <td><asp:TextBox ID="txtCondition" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" id="RequiredFieldValidator9" 
            controltovalidate="txtCondition" errormessage="Please enter the condition of the asset!" 
            SetFocusOnError="true" display="Dynamic" ForeColor="#FF0000"/>
        </td></tr>
        <tr>
        <td>
        <b>Model Class</b>: </td>
        <td><asp:TextBox ID="txtModelCLass" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" id="RequiredFieldValidator10" 
            controltovalidate="txtModelCLass" errormessage="Please enter the model class of the asset!" 
            SetFocusOnError="true" display="Dynamic" ForeColor="#FF0000"/>
        </td></tr>
        <tr><td>
        <b>NonSequentialLocation</b>: </td>
        <td><asp:TextBox ID="txtNonSequentialLocation" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" id="RequiredFieldValidator11" 
            controltovalidate="txtNonSequentialLocation" errormessage="Please enter the non sequential location!" 
            SetFocusOnError="true" display="Dynamic" ForeColor="#FF0000"/>
        </td></tr>
        <tr><td>
        <b>Size1 Quantity</b>: </td>
        <td><asp:TextBox ID="txtSize1Quantity" runat="server"></asp:TextBox>
        </td></tr>
        <tr><td colspan="2">
        <asp:Button  class="btn btn-primary" ID="Button2" runat="server" Text="Submit!"  OnClick="btnCreate"/>
        </td></tr>
        </table>
        <br /><br />
        <a href="./Default.aspx">Back to admin</a>
        <br /><br />
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
</asp:Content>
