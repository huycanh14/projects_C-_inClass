<%@ Page Title="" Language="C#" MasterPageFile="~/Form/Site1.Master" AutoEventWireup="true" CodeBehind="frm_sinhvienchitiet.aspx.cs" Inherits="Bai_TH5.Form.frm_sinhvienchitiet" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Chi tiết thông tin sinh viên</h2>
    Mã sinh viên:&nbsp; <asp:TextBox ID="txtMaSinhVien" runat="server"></asp:TextBox>
    <br />
    Họ và tên:&nbsp;
    <asp:TextBox ID="txt" runat="server"></asp:TextBox>
    <br />
</asp:Content>
