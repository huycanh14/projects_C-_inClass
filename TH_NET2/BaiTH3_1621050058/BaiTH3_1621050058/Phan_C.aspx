<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Phan_C.aspx.cs" Inherits="BaiTH3_1621050058.Phan_C" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>CKEditor và CKFinder</title>
    <link href="css/all.min.css" rel="stylesheet" />
    <link href="css/animate.css" rel="stylesheet" />
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <style>
        .row{
            padding: 1% 0%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                <div class="col-2">Địa chỉ email:</div>
                <div class="col-10">
                    <asp:TextBox ID="txtEmail" runat="server" TextMode="Email" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="row">
                <div class="col-2">Nội dung email:</div>
                <div class="col-10">
                    <textarea id="NoiDung" name="NoiDung"></textarea>
                </div>
            </div>
            <div class="row">
                <div class="col-2">
                    <asp:Button ID="btnSubmit" runat="server" Text="Gửi Email" CssClass="btn btn-info"/>
                </div>
            </div>
        </div>
    </form>
    <script src="js/jquery-3.3.1.min.js"></script>
    <script src="js/popper.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
    <script src="ckeditor/ckeditor.js"></script>
    <script>
        CKEDITOR.replace("NoiDung");
    </script>
</body>
</html>
