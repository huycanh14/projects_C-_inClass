<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frm_login.aspx.cs" Inherits="Web_Bai3_Control.frm_login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Đăng nhập</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            ĐĂNG NHẬP HỆ THỐNG
            <br />
            Tên đăng nhập&nbsp; <asp:TextBox ID="txtUser" runat="server"></asp:TextBox>
            <br />
            Mật khẩu:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtPass" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <asp:Label ID="lblError" runat="server" ForeColor="#FF3300"></asp:Label>
            <br />
            <asp:Button ID="btnDangNhap" runat="server" Text="Đăng nhập" OnClick="btnDangNhap_Click" />
            <asp:Button ID="btnHuy" runat="server" Text="-Hủy-" />
        </div>
    </form>
</body>
</html>
