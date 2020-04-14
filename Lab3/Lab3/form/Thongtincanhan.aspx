<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Thongtincanhan.aspx.cs" Inherits="Lab3.form.Thongtincanhan" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Thông tin cá nhân</title>
</head>
<body>
    <form id="form1" runat="server">
        <table border="1px">
            <tr>
                <td></td>
                <td>
                    <h3>THÔNG TIN CÁ NHÂN</h3>
                </td>
            </tr>
            <tr>
                <td>Họ và tên:</td>
                <td>
                    <asp:TextBox ID="txtTen" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Giới tính</td>
                <td>
                    <asp:RadioButton ID="radNam" runat="server" Text="Nam" GroupName="GioiTinh" />
                    <asp:RadioButton ID="radNu" runat="server" Text="Nữ" GroupName="GioiTinh" />
                </td>
            </tr>
            <tr>
                <td>Ngoại ngữ</td>
                <td>
                    <asp:CheckBox ID="chkAnhVan" runat="server"  Text="Anh văn"/>
                    <asp:CheckBox ID="chkPhapVan" runat="server"  Text="Pháp văn"/>
                </td>
            </tr>
            <tr>
                <td>Thu nhập</td>
                <td>
                    <asp:RadioButton ID="radThuNhapA" runat="server" GroupName="ThuNhap" Text="Dưới 1 triệu"/>
                    <asp:RadioButton ID="radThuNhapB" runat="server" GroupName="ThuNhap" Text="1-3 triệu"/>
                    <asp:RadioButton ID="radThuNhapC" runat="server" GroupName="ThuNhap" Text ="Trên 3 triệu"/>
                </td>
            </tr>
            <tr>
                <td>Trình độ học</td>
                <td>
                    <asp:RadioButton ID="radTrinhDoA" runat="server" GroupName="TrinhDo" Text="Sau đại học"/>
                    <asp:RadioButton ID="radTrinhDoB" runat="server" GroupName="TrinhDo" Text="Đại học"/>
                    <asp:RadioButton ID="radTrinhDoC" runat="server" GroupName="TrinhDo" Text ="Cao đẳng"/>
                </td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:Button ID="btnDangKy" runat="server" Text="Đăng ký" />
                </td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:Label ID="lblThongTin" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
