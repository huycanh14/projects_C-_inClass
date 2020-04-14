<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frm_money.aspx.cs" Inherits="Web_Bai3_Control.frm_money" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Chương trình tính tiền<br />
            Nhập số tiền tiêu thụ
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <asp:TextBox ID="TextBox2" runat="server" TextMode="MultiLine">Mức 1: </asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
            <br />
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
