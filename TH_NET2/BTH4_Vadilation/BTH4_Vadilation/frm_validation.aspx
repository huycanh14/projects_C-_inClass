<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frm_validation.aspx.cs" Inherits="BTH4_Vadilation.frm_validation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            TÍNH ĐIỂM<br />
            <br />
            Nhập điểm A (*):
            <asp:TextBox ID="txt_a" runat="server"></asp:TextBox>
            <br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txt_a" ErrorMessage="RequiredFieldValidator" ForeColor="Red">Vui lòng nhập vào điểm A</asp:RequiredFieldValidator>
            <br />
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="txt_a" ErrorMessage="CompareValidator" ForeColor="Red" Operator="DataTypeCheck" Type="Integer">Điểm nhập vào phải là số</asp:CompareValidator>
            <br />
            <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txt_a" ErrorMessage="RangeValidator" ForeColor="Red" MaximumValue="10" MinimumValue="0">Điểm nhập phải từ 0 đến 10</asp:RangeValidator>
            <br />
            <br />
            Ngày sinh: 
            <asp:TextBox ID="txtNgaySinh" runat="server"></asp:TextBox>
            <br />
            <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToValidate="txtNgaySinh" ErrorMessage="CompareValidator" ForeColor="Red" Operator="DataTypeCheck" Type="Date">Ngày sinh nhập vào không đúng</asp:CompareValidator>
&nbsp;<br />
            <br />
            Nhập mật khẩu&nbsp; (*)
            <asp:TextBox ID="txtPass1" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            Nhập lại mật khẩu (*)
            <asp:TextBox ID="txtPass2" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <asp:CompareValidator ID="CompareValidator3" runat="server" ControlToCompare="txtPass1" ControlToValidate="txtPass2" ErrorMessage="CompareValidator" ForeColor="Red">Mật khẩu không khớp, vui lòng nhập lại</asp:CompareValidator>
            <br />
            <br />
            Nhập email (*)
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <br />
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmail" ErrorMessage="RegularExpressionValidator" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">Địa chỉ Email nhập vào không đúng!</asp:RegularExpressionValidator>
            <br />
            <br />
            Nhập địa chủ URL (*):
            <asp:TextBox ID="txt_url" runat="server"></asp:TextBox>
            <br />
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txt_url" ErrorMessage="RegularExpressionValidator" ForeColor="Red" ValidationExpression="http(s)?://([\w-]+\.)+[\w-]+(/[\w- ./?%&amp;=]*)?">Bạn nhâp URL không đúng</asp:RegularExpressionValidator>
            <br />
            <br />
            Nhập tên vợ bạn (&quot;Hồng&quot;, &quot;Hà&quot;, &quot;Huyền&quot;, &quot;Hằng&quot;)
            <asp:TextBox ID="txt_tenvo" runat="server"></asp:TextBox>
            <br />
            <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="txt_tenvo" ErrorMessage="RegularExpressionValidator" ForeColor="Red" ValidationExpression="(Hồng)|(Hà)|(Huyền)|(Hằng)">Tên vợ không đúng</asp:RegularExpressionValidator>
            <br />
            <br />
            Biển số xe
            <asp:TextBox ID="txt_biensoxe" runat="server"></asp:TextBox>
            <br />
            <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="txt_biensoxe" ErrorMessage="RegularExpressionValidator" ForeColor="Red" ValidationExpression="((29)|(30)|(31)) \w{1}\-\d{3}\.d{2}">Bạn nhập biến số xe sai</asp:RegularExpressionValidator>
        </div>
        <asp:Button ID="Button1" runat="server" Text="Tính điểm" />
    </form>
</body>
</html>
