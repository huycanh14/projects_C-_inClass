<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dangnhap.aspx.cs" Inherits="Lab2.Dangnhap" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
	<meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <title>Đăng nhập</title>
    <link href="css/all.min.css" rel="stylesheet" />
    <link href="css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="frmDangNhap" runat="server" method="post">
        <div class="container">
            <div class="row">
                <div class="col-12 text-xl-center">ĐĂNG NHẬP</div>
            </div>
            <div class="row">
                <div class="col-6 text-xl-right">Tên đăng nhập:</div> 
                <div class="col-6 text-xl-left">
                    <asp:TextBox ID="txtTenDangNhap" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="row">
                    <div class="col-6 text-xl-right">Mật khẩu:</div>
                   <div class="col-6 text-xl-left">
                        <asp:TextBox ID="txtMatKhau" TextMode="Password" runat="server"></asp:TextBox>
                    </div>
                </div>
            <div class="row">
                <div class="col-12 text-xl-center">
                    <%--<asp:Button ID="btnDangNhap" runat="server" Text="Đăng nhập" OnClick="btnDangNhap_Click" />--%>
                    <asp:Button ID="btnDangNhap" runat="server" Text="Đăng nhập" OnClick="btnDangNhap_Click" PostBackUrl="~/ChaoMung.aspx" />
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-12 text-xl-center">
                <asp:Label ID="lblThongbao" runat="server" ForeColor="Red"></asp:Label>
            </div>
        </div>
    </form>
    <script src="js/jquery-3.3.1.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
    <script src="js/popper.min.js"></script>
</body>
</html>
