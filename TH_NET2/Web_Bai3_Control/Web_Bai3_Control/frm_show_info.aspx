<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frm_show_info.aspx.cs" Inherits="Web_Bai3_Control.frm_show_info" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hiển thị thông tin</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Thông tin thành viên đăng ký: 
            <br />
            Họ tên: <asp:Label ID="lblHoTen" runat="server" Text=""></asp:Label>
            <br />
            Giới tính: <asp:Label ID="lblGioiTinh" runat="server" Text=""></asp:Label>
            <br />
            Năm sinh: <asp:Label ID="lblNamSinh" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
