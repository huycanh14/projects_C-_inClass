<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmWinForm.aspx.cs" Inherits="Web_Bai3_Control.frmWinForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Đăng ký</title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="drlNamSinh">
            <div>
                Thông tin thành viên
            </div>
            <div>
                Họ và tên: <asp:TextBox ID="txbUser" runat="server"></asp:TextBox>
            </div>
            <div>
                Giới tính 
                <asp:RadioButton ID="rdbNam" runat="server" Checked="True" GroupName="GioiTinh" value="Nam"/> Nam
                <asp:RadioButton ID="rdbNu" runat="server" GroupName="GioiTinh" value="Nữ"/>Nữ
            </div>
            <div>
                Năm sinh<asp:DropDownList ID="drlNamS" runat="server"></asp:DropDownList>
            </div>
            <div>
                <asp:Button ID="btnDangKy" runat="server" Text="Đăng ký" PostBackUrl="~/frm_show_info.aspx" />
                <asp:Button ID="btnHuy" runat="server" Text="-Hủy-" />
            </div>
        </div>
    </form>
</body>
</html>
