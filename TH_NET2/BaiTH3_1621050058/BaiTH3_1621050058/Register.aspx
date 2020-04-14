<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="BaiTH3_1621050058.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register Page</title>
    <link href="css/all.min.css" rel="stylesheet" />
    <link href="css/animate.css" rel="stylesheet" />
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <style>
        .row {
            padding: 1% 0%;
        }
        span {
            color: #3011ddc7;
            font-size: larger;
        }
    </style>
</head>
<body style="background-color: blanchedalmond;">
    <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                <div class="col-10 offset-4">
                    <h1>THÔNG TIN CÁ NHÂN CỦA THÀNH VIÊN</h1>
                </div>
            </div>
            <div class="row">
                <div class="col-4">
                    <asp:Image ID="imgHinhAnh" runat="server" ImageUrl="~/img/my-account-icon.png" />
                </div>
                <div class="col-8">
                    <form>
                        <div class="row">
                            <div class="col-3">
                                <span>Họ và tên (*)</span>
                            </div>
                            <div class="col-9">
                                <asp:TextBox ID="txtTen" runat="server" required="" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-3">
                                <span>Ngày sinh</span>
                            </div>
                            <div class="col-9">
                                Ngày
                                <asp:DropDownList ID="drpNgay" runat="server"></asp:DropDownList>
                                Tháng
                                <asp:DropDownList ID="drpThang" runat="server" AutoPostBack="True" OnSelectedIndexChanged="drpThang_SelectedIndexChanged"></asp:DropDownList>
                                Năm
                                <asp:DropDownList ID="drpNam" runat="server" AutoPostBack="True" OnSelectedIndexChanged="drpNam_SelectedIndexChanged"></asp:DropDownList>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-3">
                                <span>Giới tính</span>
                            </div>
                            <div class="col-9">
                                <asp:RadioButton ID="radNam" runat="server" GroupName="GioiTinh" value="Nam" Checked="true"/>
                                Nam
                                <asp:RadioButton ID="radNu" runat="server" GroupName="GioiTinh" value="Nữ"/>
                                Nữ
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-3">
                                <span>Số điện thoại (*)</span>
                            </div>
                            <div class="col-9">
                                <asp:TextBox ID="txtSoDienThoai" runat="server" required="" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-3">
                                <span>Email (*)</span>
                            </div>
                            <div class="col-9">
                                <asp:TextBox ID="txtEmail" runat="server" required="" CssClass="form-control" TextMode="Email"></asp:TextBox>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-3">
                                <span>Địa chỉ</span>
                            </div>
                            <div class="col-9">
                                <textarea id="txtaDiaChi" runat="server" rows="3" class="form-control"></textarea>
                            </div>
                        </div>
                        <div class="row justify-content-md-center">
                            <div class="col-2">
                                <%--<asp:Button ID="btnSubmit" runat="server" Text="Đồng ý" CssClass="btn btn-dark form-control" PostBackUrl="~/Infor_Register.aspx" />--%>
                                <asp:Button ID="btnSubmit" runat="server" Text="Đồng ý" CssClass="btn btn-dark form-control" OnClick="btnSubmit_Click" PostBackUrl="~/Infor_Register.aspx" />
                            </div>
                            <div class="col-2">
                                <asp:Button ID="btnReset" runat="server" Text="Hủy" CssClass="btn btn-dark form-control" />
                            </div>
                        </div>
                    </form>
                </div>
            </div>
        </div>
    </form>
    <script src="js/jquery-3.3.1.min.js"></script>
    <script src="js/popper.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
</body>
</html>
