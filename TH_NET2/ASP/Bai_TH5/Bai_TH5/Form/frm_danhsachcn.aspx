<%@ Page Title="" Language="C#" MasterPageFile="~/Form/Site1.Master" AutoEventWireup="true" CodeBehind="frm_danhsachcn.aspx.cs" Inherits="Bai_TH5.Form.frm_chitietsv" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Hệ thống quản lý sinh viên</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%--<asp:Literal ID="lit_sv_cn" runat="server"></asp:Literal>--%>
    <div class="row mb-4">
        <div class="col-xl-12 text-uppercase font-weight-bold s2">Danh sách sinh viên theo chuyên ngành</div>
    </div>
    <div class="row">
        <div class="col-xl-12 text-xl-right text-warning s2">Tổng số bản ghi: <asp:Label ID="lblCount_BanGhi" runat="server"></asp:Label></div>
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
                <asp:Literal ID="lit_sv_cn" runat="server"></asp:Literal>
              </tbody>
            </table>
        </div>
    </div>
</asp:Content>
