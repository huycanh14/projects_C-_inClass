<%@ Page Title="" Language="C#" MasterPageFile="~/Form/Site1.Master" AutoEventWireup="true" CodeBehind="frm_doanview.aspx.cs" Inherits="Bai_TH5.Form.frm_doanview" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Hệ thống quản lý sinh viên</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row mb-4">
        <div class="col-xl-12 text-uppercase font-weight-bold">Hồ sơ đồ án tốt nghiệp trong cơ sở dữ liệu</div>
    </div>
    <div class="row mb-4">
        <div class="col-xl-4">
            <asp:TextBox ID="txtTimKiem" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="col-xl-1">
            <asp:Button ID="btnTimKiem" runat="server" Text="Tìm kiếm" CssClass="btn btn-success" />
        </div>
        <div class="col-xl-2">
            <asp:DropDownList ID="drlLinhVuc" runat="server" DataSourceID="SqlListChuyenNganh" DataTextField="tenlv" DataValueField="malv" CssClass="form-control"></asp:DropDownList>
            <asp:SqlDataSource ID="SqlListChuyenNganh" runat="server" ConnectionString="<%$ ConnectionStrings:connec_DATN %>" ProviderName="<%$ ConnectionStrings:connec_DATN.ProviderName %>" SelectCommand="SELECT [malv], [tenlv] FROM [tbl_linhvuc]"></asp:SqlDataSource>
        </div>
        <div class="col-xl-3">
            <asp:DropDownList ID="drlGiaoVien" runat="server" DataSourceID="SqlListGiaoVien" DataTextField="Expr1" DataValueField="magv" CssClass="form-control"></asp:DropDownList>
            <asp:SqlDataSource ID="SqlListGiaoVien" runat="server" ConnectionString="<%$ ConnectionStrings:connec_DATN %>" ProviderName="<%$ ConnectionStrings:connec_DATN.ProviderName %>" SelectCommand="SELECT magv, CONCAT_WS(' - ', magv, tengv) AS Expr1 FROM tbl_giangvien"></asp:SqlDataSource>
        </div>
        <div class="col-xl-2">
            <asp:DropDownList ID="drlLuaChonDiem" runat="server" CssClass="form-control">
                <asp:ListItem Value="0">Điểm &lt;= 7</asp:ListItem>
                <asp:ListItem Value="1">Điểm 7.1 -&gt; 8.0</asp:ListItem>
                <asp:ListItem Value="3">Điểm 8.1 -&gt; 9.0</asp:ListItem>
                <asp:ListItem Value="4">Điểm &gt;= 9.1</asp:ListItem>
            </asp:DropDownList>
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
                    <th scope="col">Tên đồ án</th>
                    <th scope="col">GVHD</th>
                    <th scope="col">GVPB</th>
                    <th scope="col">Lĩnh vực</th>
                    <th scope="col">Điểm</th>
                    <th scope="col">Năm TN</th>
                </tr>
              </thead>
              <tbody>
                <asp:Literal ID="lit_da" runat="server"></asp:Literal>
              </tbody>
            </table>
        </div>
    </div>
</asp:Content>
