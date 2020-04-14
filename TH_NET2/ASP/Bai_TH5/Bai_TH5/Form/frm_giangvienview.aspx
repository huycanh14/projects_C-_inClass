<%@ Page Title="" Language="C#" MasterPageFile="~/Form/Site1.Master" AutoEventWireup="true" CodeBehind="frm_giangvienview.aspx.cs" Inherits="Bai_TH5.Form.frm_giangvienview" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Hệ thống quản lý sinh viên</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row mb-4">
        <div class="col-xl-12 text-uppercase font-weight-bold">Hồ sơ giảng viên trong cơ sở dữ liệu</div>
    </div>
    <div class="row mb-4">
        <div class="col-xl-4">
            <asp:TextBox ID="txtTimKiem" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="col-xl-1">
            <asp:Button ID="btnTimKiem" runat="server" Text="Tìm kiếm" CssClass="btn btn-success" />
        </div>
    </div>
    <div class="row">
        <div class="col-xl-12">
            <table class="table table-striped" border="1">
              <thead class="badge-primary">
                <tr>
                    <th scope="col">STT</th>
                    <th scope="col">Mã GV</th>
                    <th scope="col">Tên giảng viên</th>
                    <th scope="col">Năm sinh</th>
                    <th scope="col">Giới tính</th>
                    <th scope="col">Học vị</th>
                    <th scope="col">Email</th>
                    <th scope="col">Điện thoại</th>
                    <th scope="col">Địa chỉ</th>
                </tr>
              </thead>
              <tbody>
                <asp:Literal ID="lit_gv" runat="server"></asp:Literal>
              </tbody>
            </table>
        </div>
    </div>
</asp:Content>
