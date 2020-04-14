<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="B2_1621050058_ĐặngHuyCảnh.form.register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../css/bootstrap.min.css" rel="stylesheet" />
    <link href="../css/register.css" rel="stylesheet" />
    <title>Đăng ký</title>
    <style>
        .content .row{
            padding: 1% 0%;
        }
        .content img{
            border: 1px solid #000000;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container-fluid">
            <div class="row">
                <div class="col-xl-12 title">
                    <img src="../image/AYS1.gif" /> Môn học lập trình .Net 2 - Phát triển ứng dụng web với ASP.Net 
                    <img src="../image/calendar_16.png" />
                    <asp:Label ID="lblTitle" runat="server" Text=""></asp:Label>
                </div>
            </div>
            <div class="row content justify-content-center">
                <div class=" col-6">
                    <div class="row">
                        <div class="col-xl-8 offset-4 tieude">
                            THÔNG TIN CÁ NHÂN CỦA THÀNH VIÊN
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-4">
                            <img src="../image/user.png" />
                        </div>
                        <div class="col-xl-8">
                                <div class="row">
                                    <div class="col-3">Họ và tên (*):</div>
                                    <div class="col-8">
                                        <asp:TextBox ID="txtHovaTen" runat="server" CssClass="form-control"></asp:TextBox>
                                    </div>
                                    <div class="col-1">
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Bạn chưa nhập tên!" ControlToValidate="txtHovaTen" ForeColor="Red">(*)</asp:RequiredFieldValidator>

                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-3">Ngày sinh:</div>
                                    <div class="col-9">
                                        Ngày <asp:DropDownList ID="drpNgay" runat="server" ></asp:DropDownList>
                                        Tháng <asp:DropDownList ID="drpThang" runat="server" OnSelectedIndexChanged="drpThang_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
                                        Năm <asp:DropDownList ID="drpNam" runat="server" OnSelectedIndexChanged="drpNam_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-3">
                                        Giới tính:
                                    </div>
                                    <div class="col-9">
                                        <asp:RadioButton ID="radNam" GroupName="GioiTinh" runat="server" value="1" Checked="True" /> &nbsp;Nam&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                        <asp:RadioButton ID="radNu" GroupName="GioiTinh" runat="server" value="0" /> &nbsp;Nữ
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-3">Điện thoai (*):</div>
                                    <div class="col-8">
                                        <asp:TextBox ID="txtSoDienThoai" runat="server" CssClass="form-control"></asp:TextBox>
                                    </div>
                                    <div class="col-1">
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Chưa nhập điện thoại!" ControlToValidate="txtSoDienThoai" ForeColor="Red">(*)</asp:RequiredFieldValidator>
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtSoDienThoai" ForeColor="Red" ValidationExpression="0\d{9}">(*)</asp:RegularExpressionValidator>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-3">Email (*):</div>
                                    <div class="col-8">
                                        <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" TextMode="Email"></asp:TextBox>
                                    </div>
                                    <div class="col-1">
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Chưa nhập Email!" ControlToValidate="txtEmail" ForeColor="Red">(*)</asp:RequiredFieldValidator>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-3">Địa chỉ:</div>
                                    <div class="col-9">
                                        <%--<textarea id="txtrDiaChi" cols="20" rows="2" class="form-control"></textarea>--%>
                                        <asp:TextBox ID="txtDiaChi" runat="server" cols="20" rows="2" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="row justify-content-center">
                                    <div class="col-3">
                                        <asp:Button ID="btnSubmit" runat="server" Text="Đồng ý" CssClass="form-control btn btn-success" OnClick="btnSubmit_Click" PostBackUrl="~/form/Default.aspx"/>
                                    </div>
                                    <div class="col-3">
                                        <asp:Button ID="btnCancel" runat="server" Text="Hủy" CssClass="form-control btn btn-danger" OnClick="btnCancel_Click"/>
                                    </div>
                                </div>
                            </div>
                        </div>
                </div>
            </div>
            <div class="row">
                <div class="col-4"></div>
                <div class="col-8">
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" HeaderText="Danh sách lỗi:" ForeColor="Red"  />
                </div>
            </div>
        </div>
    </form>
    <script src="../js/jquery-3.4.0.min.js"></script>
    <script src="../js/bootstrap.min.js"></script>
    <script src="../js/popper.min.js"></script>
</body>
</html>
