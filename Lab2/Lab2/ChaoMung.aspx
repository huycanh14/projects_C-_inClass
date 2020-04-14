<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChaoMung.aspx.cs" Inherits="Lab2.ChaoMung" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Chào mừng</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Chào mừng bạn <asp:Label ID="lblTen" runat="server"></asp:Label> đến với diễn đàn ASP.NET <br />
            <a href="Dangnhap.aspx?thongbao=thatbai">Đăng nhập</a>
        </div>
    </form>
</body>
</html>
