<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="BTH4_Vadilation.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            ĐĂNG NHẬP HỆ THỐNG<br />
            Tên đăng nhập (*):
            <asp:TextBox ID="txtUser" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUser" ErrorMessage="Chưa nhập tên người dùng" ForeColor="Red">(*)</asp:RequiredFieldValidator>
            <br />
            Mật khẩu (*):
            <asp:TextBox ID="txtMatKhau" runat="server" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtMatKhau" ErrorMessage="Bạn chưa nhập mật khẩu" ForeColor="Red">(*)</asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="lblError" runat="server" ForeColor="#CC0000"></asp:Label>
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" HeaderText="Danh sách lỗi" ShowMessageBox="True" />
        </div>
        <asp:Button ID="btnDangNhap" runat="server" OnClick="btnDangNhap_Click" Text="Đăng nhập" />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnHuy" runat="server" CausesValidation="False" OnClick="btnHuy_Click" Text="Hủy bỏ" />
    </form>
</body>
</html>
