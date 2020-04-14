<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmBai_2.aspx.cs" Inherits="Web_Bai3_Control.frmBai_2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sử dụng Control Bài 2</title>
    <link href="Style/style_1.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="display">
            <h2 class="title">KHẢO SÁT SỞ THÍCH</h2>
            <div>
                Chọn giới tính
                <asp:RadioButton ID="rbt_nam" runat="server" GroupName="gioitinh" />Nam
                <asp:RadioButton ID="rbt_nu" runat="server" GroupName="gioitinh" />Nữ
                <asp:RadioButton ID="rbt_kxdinh" runat="server" GroupName="gioitinh" />Không xác định
            </div>
            <div>
                Chọn sở thích
                <asp:CheckBox ID="cbk_bongda" runat="server" />Bóng đá
                <asp:CheckBox ID="cbk_boiloi" runat="server" />Bơi lội
                <asp:CheckBox ID="cbk_covua" runat="server" />Cờ vua
                <asp:CheckBox ID="cbk_bongban" runat="server" />Bóng bàn
                <asp:CheckBox ID="cbk_nhayday" runat="server" />Nhảy dây
            </div>
            <div style="text-align:center;">
                <asp:Button ID="btnLuu" runat="server" Text="-Lưu-" OnClick="btnLuu_Click" />
            </div>
            <asp:Label ID="lbl_kq" runat="server" ForeColor="#FF6699"></asp:Label><br />
            <asp:Literal ID="ltr_kq" runat="server"></asp:Literal>
        </div>   
    </form>
</body>
</html>
