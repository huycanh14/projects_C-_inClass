<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Thuchienpheptinh.aspx.cs" Inherits="Lab1.Thuchienpheptinh" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Thực hiện phép tính</title>
    <link rel="shortcut icon" href="#" />
    <link href="css/all.min.css" rel="stylesheet" />
    <link href="css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                Thực hiện phép tính
            </div>
            <div class="row">
                A: <asp:TextBox ID="txtSoA" runat="server"></asp:TextBox>
            </div>
            <div class="row">
                B: <asp:TextBox ID="txtSoB" runat="server"></asp:TextBox>
            </div>
            <div class="row">
                <asp:Button ID="btnTong" runat="server" Text="A+B" CssClass="btn btn-danger" OnClick="btnTong_Click" />
                <asp:Button ID="btnHieu" runat="server" Text="A-B" CssClass="btn btn-danger" />
                <asp:Button ID="btnTich" runat="server" Text="A*B" CssClass="btn btn-danger" />
                <asp:Button ID="btnThuong" runat="server" Text="A/B" CssClass="btn btn-danger" />
                <asp:Button ID="btnPhanDu" runat="server" Text="A%B" CssClass="btn btn-danger" />
            </div>
            <div class="row">
                <asp:Label ID="lblKetQua" runat="server" ></asp:Label>
            </div>
        </div>
    </form>
    <script src="js/jquery-3.3.1.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
    <script src="js/popper.min.js"></script>
</body>
</html>
