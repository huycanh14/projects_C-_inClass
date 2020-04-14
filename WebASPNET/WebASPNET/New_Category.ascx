<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="New_Category.ascx.cs" Inherits="WebASPNET.New_Category" %>
<asp:DropDownList ID="drpNewCategory" runat="server" OnSelectedIndexChanged="drpNewCategory_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
<asp:Repeater ID="rptNews" runat="server">
    <ItemTemplate><%#:Eval("Title") %></ItemTemplate>
</asp:Repeater>