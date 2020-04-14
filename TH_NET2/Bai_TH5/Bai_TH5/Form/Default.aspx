<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Bai_TH5.Form.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Đăng nhập hệ thống</title>
    <link href="../css/w3.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous" />
    <style>
        .container .col-6.offset-3.form{
            box-shadow: 0 4px 10px 0 rgba(0,0,0,0.2), 0 4px 20px 0 rgba(0,0,0,0.19);
            margin-top: 3%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                <div class="col-6 offset-3 form">
                    <div class="row">
                        <div class="col-xl-12 text-center" style="font-size: 30px; padding-top: 5%;">
                            HỆ THỐNG THÔNG TIN
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-xl-12 text-center">
                            <img src="https://images.blog.romyn.ca/blogimages/azure-key-vault.png" alt="Alternate Text" width="50%"/>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-xl-12">
                            <form action="/" method="post">
                                <div class="form-group">
                                    <label for="usr">Tên đưng nhập:</label>
                                    <asp:TextBox ID="txtTenDangNhap" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <label for="pwd">Mật khẩu:</label>
                                    <asp:TextBox ID="txtMatKhau" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
                                </div>
                                <div class="form-group card container-fluid" style="padding: 3% 2%;">
                                    <div class="row">
                                        <div class="col-12">
                                            <asp:Button ID="btnDangNhap" runat="server" Text="Đăng Nhập Hệ Thống" CssClass="form-control btn btn-info" />
                                        </div>
                                    </div>
                                    <div class="row" style="padding-top: 3%;">
                                        <div class="col-3">
                                            <asp:Button ID="btnHuyBo" runat="server" Text="Hủy Bỏ" CssClass="btn btn-danger form-control" />
                                        </div>
                                        <div class="col-6 offset-3">
                                            <asp:CheckBox ID="chkNho" runat="server" />Nhớ mật khẩu!  
                                            <a href="#">Quên mật khẩu</a>
                                        </div>
                                    </div>
                                </div>
                            </form>
                            
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>
</body>
</html>
