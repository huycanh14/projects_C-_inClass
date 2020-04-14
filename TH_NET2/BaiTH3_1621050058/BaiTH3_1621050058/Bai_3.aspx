<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Bai_3.aspx.cs" Inherits="BaiTH3_1621050058.Bai_3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Chuyển đổi số thập phân</title>
    <link href="css/all.min.css" rel="stylesheet" />
    <link href="css/animate.css" rel="stylesheet" />
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <style>
        .row{
            padding: 1% 0%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container jumbotron">
            <div class="row">
                <div class="col-12 text-xl-center">
                    <h1>BỘ CHUYỂN ĐỔI SỐ THẬP PHÂN</h1>
                </div>
            </div>
            <div class="row">
                <div class="col-3 text-xl-right">
                    <h3>Số thập phân</h3>
                </div>
                <div class="col-9">
                    <asp:TextBox ID="txtSoNhap" runat="server" CssClass="form-control" TextMode="Number" required=""></asp:TextBox>
                </div>
            </div>
            <div class="row">
                <div class="col-1"></div>
                <div class="col-3">
                    <asp:RadioButton ID="radNhiPhan" runat="server" GroupName="LuaChon" Checked="true"/> Hệ nhi phân
                </div>
                <div class="col-3">
                    <asp:RadioButton ID="radBatPhan" runat="server" GroupName="LuaChon"/> Hệ bát phân
                </div>
                <div class="col-3">
                    <asp:RadioButton ID="radThapLucPhan" runat="server" GroupName="LuaChon"/> Hệ thập lục phân
                </div>
            </div>
            <div class="row justify-content-center">
                <div class="col-xl-3">
                    <asp:Button ID="btnSubmit" runat="server" Text="Chuyển đổi" OnClick="btnSubmit_Click" />
                </div>
            </div>
            <div class="row">
                <div class="col-12">
                    <asp:Label ID="lblKetQua" runat="server" Text="" CssClass="form-control"></asp:Label>
                </div>
            </div>
        </div>
    </form>
    <script src="js/jquery-3.3.1.min.js"></script>
    <script src="js/popper.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
</body>
</html>
