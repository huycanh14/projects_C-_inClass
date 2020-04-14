<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Infor_Register.aspx.cs" Inherits="BaiTH3_1621050058.Infor_Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Thông tin thành viên</title>
    <link href="css/all.min.css" rel="stylesheet" />
    <link href="css/animate.css" rel="stylesheet" />
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <style>
        li {
            color: red;
        }
        .container {
            border: 1px solid;
            padding: 2%;
            margin-top: 2%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                <div class="col-12">
                    <h2>THÔNG TIN THÀNH VIÊN ĐÃ ĐĂNG KÝ</h2>
                    <ul class="list-group">
                        <li class="list-group-item">Họ tên:
                            <asp:Label ID="lblHoTen" runat="server"></asp:Label>
                        </li>
                        <li class="list-group-item">Ngày sinh:
                            <asp:Label ID="lblNgaySinh" runat="server"></asp:Label>
                        </li>
                        <li class="list-group-item">Giới tính:
                            <asp:Label ID="lblGioiTinh" runat="server"></asp:Label>
                        </li>
                        <li class="list-group-item">Điện thoại:
                            <asp:Label ID="lblDienThoai" runat="server"></asp:Label>
                        </li>
                        <li class="list-group-item">Email:
                            <asp:Label ID="lblEmail" runat="server"></asp:Label>
                        </li>
                        <li class="list-group-item">Địa chỉ:
                            <asp:Label ID="lblDiaChi" runat="server"></asp:Label>
                        </li>
                    </ul>
                </div>
            </div>
        </div>
    </form>
    <script src="js/jquery-3.3.1.min.js"></script>
    <script src="js/popper.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
</body>
</html>
