<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Tinh.aspx.cs" Inherits="Lab1.Tinh" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Trang tính</title>
	<link rel="shortcut icon" href="#" />
    <link href="css/all.min.css" rel="stylesheet" />
    <link href="css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="text-left">
    <div class="jumbotron">
        <h1 class="text-center"><strong>Tính toán</strong></h1>
    </div>
    <script src="js/jquery-3.3.1.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
    <script src="js/popper.min.js"></script>
            Số n:
            <asp:TextBox ID="txtSon" runat="server" Height="24px" Width="247px"></asp:TextBox>
            <br />
            <br />
        </div>
        <p class="text-left">
             Số m:
             <asp:TextBox ID="txtSom" runat="server" Width="232px"></asp:TextBox>
            </p>
        <asp:Button ID="btnCong" runat="server" OnClick="btnCong_Click" Text="+" Width="54px" />
        <asp:Button ID="btnTru" runat="server" OnClick="btnTru_Click" Text="-" Width="49px" />
        <asp:Button ID="btnNha" runat="server" Text="x" Width="55px" OnClick="btnNha_Click" />
        <asp:Button ID="btnChia" runat="server" Text=":" Width="64px" OnClick="btnChia_Click" />
        <asp:Button ID="btnXoa" runat="server" Text="Xóa" />
        <p>
            <asp:Label ID="Label1" runat="server" Text="Kết quả"></asp:Label>
            <asp:TextBox ID="txtKetQua" runat="server" Height="36px" ReadOnly="True" Width="269px"></asp:TextBox>
        </p>
    </form>
</body>
</html>
