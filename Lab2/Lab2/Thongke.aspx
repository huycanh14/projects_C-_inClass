<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Thongke.aspx.cs" Inherits="Lab2.Thongke" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Thống kê</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Thống kê Website
            Online: <asp:Label ID="lblOnline" runat="server" ></asp:Label> <br />
            Tổng lượt truy cập: <asp:Label ID="lblTong" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
