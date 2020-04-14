<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Downloadfile.aspx.cs" Inherits="Lab2.Downloadfile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Download</title>
    <link href="css/all.min.css" rel="stylesheet" />
    <style>
        .fas{
            color: #FDF1B9;
        }
    </style>
</head>
<body>
    <form id="frmDownload" runat="server">
        <div>
            <i class="fas fa-star"></i> Bài tập thực hành Lab02
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Download/Lab02.pdf">Click để download</asp:HyperLink>
        </div>
        <div>
            <asp:ImageButton ID="ImageButton1" runat="server" OnClick="ImageButton1_Click" style="height: 16px" />
        </div>
    </form>
</body>
</html>
