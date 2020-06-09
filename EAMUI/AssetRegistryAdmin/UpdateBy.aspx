<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UpdateBy.aspx.cs" Inherits="EAMUI.AssetRegistryAdmin.UpdateBy" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Enterprise Asset Management UI</h3>
        <p><b>Asset Registry Admin - Update By Asset Class/Type/Subtype</b></p>
        <p>
           I would like to all 
           <asp:DropDownList ID="DropDownList1" runat="server">
               <asp:ListItem Value=""> -- Asset Class -- </asp:ListItem>
               <asp:ListItem Value=""> Roads </asp:ListItem>
               <asp:ListItem Value=""> Municipal Structures </asp:ListItem>
               <asp:ListItem Value=""> Operations Fleet & Equipment </asp:ListItem>
               <asp:ListItem Value=""> Active Transportation within Right-of-Way </asp:ListItem>
           </asp:DropDownList> or 
            <asp:DropDownList ID="DropDownList3" runat="server">
               <asp:ListItem Value=""> -- Asset Type -- </asp:ListItem>
               <asp:ListItem Value=""> Above Ground Conveyance </asp:ListItem>
               <asp:ListItem Value=""> Architectural and Structural Components </asp:ListItem>
               <asp:ListItem Value=""> Bicycle Lanes </asp:ListItem>
               <asp:ListItem Value=""> Bicycle parking facility(short-term) </asp:ListItem>
           </asp:DropDownList> or 
            <asp:DropDownList ID="DropDownList4" runat="server">
               <asp:ListItem Value=""> -- Asset SubType -- </asp:ListItem>
               <asp:ListItem Value=""> Open Channels </asp:ListItem>
               <asp:ListItem Value=""> Storm Culverts (<3m) </asp:ListItem>
               <asp:ListItem Value=""> Exterior Closures </asp:ListItem>
               <asp:ListItem Value=""> Roofing </asp:ListItem>
           </asp:DropDownList> 
            <br />to<br />
            <asp:DropDownList ID="DropDownList2" runat="server">
                <asp:ListItem Value=""> -- Please select the data field -- </asp:ListItem>
                <asp:ListItem Value=""> Condition </asp:ListItem>
                <asp:ListItem Value=""> Installation Date </asp:ListItem>
           </asp:DropDownList>
            <asp:TextBox runat="server" ID="txtNewValue"></asp:TextBox>
            
        </p>
        <p><a href="./Default.aspx">Back to Asset Registry Admin</a></p>
        
</asp:Content>
