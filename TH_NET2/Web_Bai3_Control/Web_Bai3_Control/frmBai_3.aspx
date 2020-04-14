<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmBai_3.aspx.cs" Inherits="Web_Bai3_Control.frmBai_3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sử dụng Control Bài 3</title>
    <link href="Style/style_1.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="display">
            <div class="title">
                THỰC HIỆN UPLOAD ẢNH LÊN SERVER
            </div>
            <asp:Label ID="lblKetQua" runat="server" Text="Label"></asp:Label>
            <asp:FileUpload ID="FileUpload1" runat="server" /> <br />
            <asp:Button ID="btt_upload" runat="server" Text="-Lưu-" OnClick="btt_upload_Click" /> <br />
            <asp:Image ID="img_view" runat="server" Height="123px" Width="123px" /><br />
            <asp:Label ID="lbl_thongbao" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
