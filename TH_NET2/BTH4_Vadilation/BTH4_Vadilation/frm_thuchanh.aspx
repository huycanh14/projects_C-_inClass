<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frm_thuchanh.aspx.cs" Inherits="BTH4_Vadilation.frm_thuchanh" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Đăng ký khách hàng</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
    <style>
        .row{
            padding-top: 1%;
        }
        .title{
            background-color: #006699;
            color: white;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                <div class="col-12 text-center">
                    <h1>ĐĂNG KÝ KHÁCH HÀNG</h1>
                </div>
            </div>
            <div class="row">
                <div class="col-12 text-left title">Thông tin đăng nhập</div>
            </div>
            <div class="row">
                <div class="col-2">Tên đăng nhập:</div>
                <div class="col-9">
                    <asp:TextBox ID="txtTenDangNhap" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Tên đăng nhập trống"></asp:RequiredFieldValidator>
            <div class="row">
                <div class="col-2">Mật khẩu:</div>
                <div class="col-9">
                    <asp:TextBox ID="txtMatKhau" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="row">
                <div class="col-2">Nhập lại mật khẩu:</div>
                <div class="col-9">
                    <asp:TextBox ID="txtReMatKhau" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            
            <!---->
            <div class="row">
                <div class="col-12 text-left title">Thông tin cá nhân</div>
            </div>
            <div class="row">
                <div class="col-2">Họ và tên khách hàng(*):</div>
                <div class="col-9">
                    <asp:TextBox ID="txtTenKH" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="row">
                <div class="col-2">Ngày sinh(*):</div>
                <div class="col-9">
                    <asp:TextBox ID="txtNgaySinh" runat="server" CssClass="form-control" TextMode="Date"></asp:TextBox>
                </div>
            </div>
            <div class="row">
                <div class="col-2">Giới tính:</div>
                <div class="col-9">
                    <asp:RadioButton ID="radNam" runat="server" Checked="True" GroupName="GioiTinh" /> Nam
                    <asp:RadioButton ID="radNu" runat="server" GroupName="GioiTinh" /> Nữ
                </div>
            </div>
            <div class="row">
                <div class="col-2">Địa chỉ Mail(*):</div>
                <div class="col-9">
                    <asp:TextBox ID="txtMail" runat="server" CssClass="form-control" TextMode="Email"></asp:TextBox>
                </div>
            </div>
            <div class="row">
                <div class="col-2">Thu nhập:</div>
                <div class="col-9">
                    <asp:TextBox ID="txtThuNhap" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="row">
                <div class="col-12 text-center">
                    <asp:Button ID="btnDangKy" runat="server" Text="Đăng ký" CssClass="btn btn-dark"/>
                </div>
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" HeaderText="Danh sách các lỗi" />
            </div>
        </div>
    </form>
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>
</body>
</html>
