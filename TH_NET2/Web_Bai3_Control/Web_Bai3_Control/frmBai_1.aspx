<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmBai_1.aspx.cs" Inherits="Web_Bai3_Control.Bai_1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sử dụng các Control</title>
    <link href="Style/style_1.css" rel="stylesheet" />

</head>
<body>
    <form id="form1" runat="server">
        <div class="display">
            <div class="title">
                Bộ Chuyển Điểm
            </div>
            <div class="panel_1">
                Điểm A: <asp:TextBox ID="tbx_A" runat="server"></asp:TextBox> <br />
                Điểm B: <asp:TextBox ID="tbx_B" runat="server"></asp:TextBox><br />
                Điểm C: <asp:TextBox ID="tbx_C" runat="server"></asp:TextBox>
            </div>
            <div class="panel_2">
                Ghi chú:
                <li> < 4.0          : F</li>
                <li> 4.0  --->: 5.5 : D</li>
                <li> 5.5  --->: 7.0 : C</li>
                <li> 7.0  --->: 8.5 : B</li>
                <li> >= 8.5 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; : A</li>
            </div>
            <div style="text-align: center;">
                <asp:Button ID="btnOK" runat="server" Text="-Tinh-" OnClick="btnOK_Click" />
                <asp:Button ID="btt_Centrol" runat="server" Text="-Hủy-" OnClick="btt_Centrol_Click" />
            </div>
            <div class="result">
                <asp:Label ID="lbl_kq" runat="server"></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>
