<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div><a href="?id=1">Tin tức</a></div>
            <div><a href="?id=2">Sản phẩm</a></div>
            <asp:PlaceHolder ID="plLoad" runat="server" />
        </div>
    </form>
</body>
</html>
