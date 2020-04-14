<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Diadanhdulich.aspx.cs" Inherits="Lab3.form.Diadanhdulich" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Địa danh du lịch</title>
</head>
<body>
    <form id="form1" runat="server">
        <table border="1px">
            <tr>
                <td colspan="2">
                    <h3>Địa danh du lịch</h3>
                </td>
            </tr>
            <tr>
                <td>Địa danh du lịch</td>
                <td>
                    <asp:ListBox ID="lstDiaDanh" Rows="4" SelectionMode="Multiple" runat="server"></asp:ListBox>
                </td>
            </tr>
            <tr>
                <td>Tổng số địa danh</td>
                <td>
                    <asp:Label ID="lblSoDD" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:Button ID="btnChon" runat="server" Text="Chọn" OnClick="btnChon_Click" />
                </td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:Label ID="lblDiaDanh" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
