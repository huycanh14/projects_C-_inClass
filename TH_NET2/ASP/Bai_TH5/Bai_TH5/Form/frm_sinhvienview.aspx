<%@ Page Title="" Language="C#" MasterPageFile="~/Form/Site1.Master" AutoEventWireup="true" CodeBehind="frm_sinhvienview.aspx.cs" Inherits="Bai_TH5.Form.frm_sinhvienview" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Hệ thống quản lý sinh viên</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row mb-4">
        <div class="col-xl-12 text-uppercase font-weight-bold">Hồ sơ sinh viên trong cơ sở dữ liệu</div>
    </div>
    <div class="row mb-4">
        <div class="col-xl-4">
            <asp:TextBox ID="txtTimKiem" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="col-xl-1">
            <asp:Button ID="btnTimKiem" runat="server" Text="Tìm kiếm" CssClass="btn btn-success" />
        </div>
        <div class="col-xl-2"></div>
        <div class="col-xl-2">
            <asp:DropDownList ID="drlKhoa" runat="server" DataSourceID="SqlDataSource1" DataTextField="tenkhoa" DataValueField="makh" CssClass="form-control" OnSelectedIndexChanged="drlKhoa_SelectedIndexChanged"></asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:connec_DATN %>" ProviderName="<%$ ConnectionStrings:connec_DATN.ProviderName %>" SelectCommand="SELECT [makh], [tenkhoa] FROM [tbl_khoahoc] ORDER BY [makh]" OnSelecting="SqlDataSource1_Selecting"></asp:SqlDataSource>
        </div>
        <div class="col-xl-3">
            <asp:DropDownList ID="drlChuyenNganh" runat="server" DataSourceID="SqlListChuyenNganh" DataTextField="tencn" DataValueField="macn" CssClass="form-control"></asp:DropDownList>
            <asp:SqlDataSource ID="SqlListChuyenNganh" runat="server" ConnectionString="<%$ ConnectionStrings:connec_DATN %>" ProviderName="<%$ ConnectionStrings:connec_DATN.ProviderName %>" SelectCommand="SELECT macn, CONCAT_WS(' - ', macn, tencn) AS 'tencn' FROM tbl_chuyennganh"></asp:SqlDataSource>
        </div>
    </div>
    <div class="row">
        <div class="col-xl-12">
            <table class="table table-striped" border="1">
              <thead class="badge-primary">
                <tr>
                    <th scope="col">STT</th>
                    <th scope="col">Mã sinh viên</th>
                    <th scope="col">Tên sinh viên</th>
                    <th scope="col">Ngày sinh</th>
                    <th scope="col">Giới tính</th>
                    <th scope="col">Khóa</th>
                    <th scope="col">Chuyên ngành</th>
                    <th scope="col">Email</th>
                    <th scope="col">Điện thoại</th>
                    <th scope="col">Địa chỉ</th>
                </tr>
              </thead>
              <tbody>
                <asp:Literal ID="lit_sv" runat="server"></asp:Literal>
              </tbody>
            </table>
        </div>
    </div>
</asp:Content>
