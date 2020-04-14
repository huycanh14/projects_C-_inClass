<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Tinhtoan.aspx.cs" Inherits="Lab1.Tinhtoan" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tính toán</title>
    <link rel="shortcut icon" href="#" />
    <link href="css/all.min.css" rel="stylesheet" />
    <link href="css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container" runat="server">
            <table>
                <thead>
                    <tr><th>Tính toán</th></tr>
                </thead>
                <tbody>
                    <tr>
                        <td>Số lượng:</td>
                        <td> <asp:TextBox ID="txtSoLuong" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>Đơn giá:</td>
                        <td> <asp:TextBox ID="txtDonGia" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>Thành tiền:</td>
                        <td> <asp:TextBox ID="txtThanhTien" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td><asp:Button ID="btnTinhTien" runat="server" Text="Tính tiền" OnClick="btnTinhTien_Click" /></td>
                    </tr>
                </tbody>
            </table>
        </div>
    </form>
    <script src="js/jquery-3.3.1.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
    <script src="js/popper.min.js"></script>
</body>
</html>
