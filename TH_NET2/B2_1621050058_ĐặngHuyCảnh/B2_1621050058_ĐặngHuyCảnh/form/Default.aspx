<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="B2_1621050058_ĐặngHuyCảnh.form.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../css/bootstrap.min.css" rel="stylesheet" />
    <link href="../css/Default.css" rel="stylesheet" />
    <title>THÔNG TIN ĐĂNG KÝ</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="row justify-content-center">
                <div class=" col-6 form">
                    <div class="row title">
                        <div class="col-xl-12 text-xl-center">
                            Thông tin thành viên
                        </div>
                    </div>
                    <div class="row content">
                        <div class="col-xl-12">
                            <div class="container-fluid">
                                <div class="row content-title">
                                    <div class="col-xl-12 title">
                                        <asp:Label ID="lblInfo" runat="server" Text=""></asp:Label>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-4 d-flex align-items-center">
                                        <%--<img src="../image/pic_Nu.png" />--%>
                                        <asp:Image ID="imgGioiTinh" runat="server"  />
                                    </div>
                                    <div class="col-8">
                                        <form>
                                          <div class="form-group">
                                            <label for="">Ngày sinh:</label>
                                              <asp:TextBox ID="txtNgaySinh" runat="server" CssClass="form-control" ReadOnly="True"></asp:TextBox>
                                          </div>
                                          <div class="form-group">
                                            <label for="">Email:</label>
                                              <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" ReadOnly="True"></asp:TextBox>
                                          </div>
                                            <div class="form-group">
                                            <label for="">Điện thoại:</label>
                                              <asp:TextBox ID="txtDienThoai" runat="server" CssClass="form-control" ReadOnly="True"></asp:TextBox>
                                          </div>
                                            <div class="form-group">
                                            <label for="">Địa chỉ:</label>
                                              <asp:TextBox ID="txtDiaChi" runat="server" CssClass="form-control" ReadOnly="True"></asp:TextBox>
                                          </div>
                                        </form>
                                    </div>
                                </div>
                                <div class="row content-title">
                                    <div class="col-xl-12 title">
                                        <asp:Label ID="lblTho" runat="server" Text="Label"></asp:Label>
                                    </div>
                                </div>
                                <div class="row tho">
                                    <div class="col-6 d-flex align-items-center">
                                        <%--<img src="../image/muathu.JPG" />--%>
                                        <asp:Image ID="imgMua" runat="server" />
                                    </div>
                                    <div class="col-6 text-xl-center">
                                       <asp:Label ID="lblMua" runat="server" Text=""></asp:Label>
                                        <%--<asp:TextBox ID="txtTho" runat="server"></asp:TextBox>--%>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="row date">
                        <div class="col-xl-12 text-xl-center">
                            <asp:Label ID="lblNgay" runat="server" Text=""></asp:Label>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
    <script src="../js/jquery-3.4.0.min.js"></script>
    <script src="../js/bootstrap.min.js"></script>
    <script src="../js/popper.min.js"></script>
</body>
</html>
