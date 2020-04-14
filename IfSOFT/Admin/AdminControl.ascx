<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AdminControl.ascx.cs" Inherits="IfSOFT.Admin.AdminCotrol" %>
<%@ Register src="Menu.ascx" tagname="Menu" tagprefix="uc1" %>
<div>Banner Admin</div>
<table style="width: 100%;" cellspacing ="0" cellpadding="0">
    <tr>
        <td style="width:200px;">
            <uc1:Menu ID="Menu1" runat="server" />
        </td>
        <td style="width:10px;">&nbsp;</td>
        <td><asp:PlaceHolder ID="plLoad" runat="server"></asp:PlaceHolder></td>
    </tr>
</table>
