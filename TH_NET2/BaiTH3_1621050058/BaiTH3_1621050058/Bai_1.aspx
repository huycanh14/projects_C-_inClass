<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Bai_1.aspx.cs" Inherits="BaiTH3_1621050058.Bai_1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Lập trình C# 2:</title>
    <link href="css/all.min.css" rel="stylesheet" />
    <link href="css/animate.css" rel="stylesheet" />
    <link href="css/bootstrap.min.css" rel="stylesheet" />
</head>
<body style="background: #41d54c;">
    <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                <div class="col-12 text-xl-center">
                    Tổng 4 chữ số tự nhiên có phần dư khi chia hết cho 10 = :
                </div>
            </div>
            <div class="row">
                <div class="col-10">
                    <asp:TextBox ID="txtSoDu" runat="server" CssClass="form-control" TextMode="Number" MaxLength="1" required=""></asp:TextBox>
                </div>
                <div class="col-2">
                    <asp:Button ID="btnSubmit" runat="server" Text="- Xác Định -" CssClass="btn btn-info btn-outline-info " OnClick="btnSubmit_Click" ForeColor="White"/>
                </div>
            </div>
            <div class="row">
                <div class="col-10 text-xl-left" style="background:white;">
                    <asp:Label ID="lblKetQua" runat="server" CssClass="form-text"></asp:Label>
                </div>
            </div>
        </div>
    </form>
    <script src="js/jquery-3.3.1.min.js"></script>
    <script src="js/popper.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
</body>
</html>
