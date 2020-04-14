<%@ Page Title="" Language="C#" MasterPageFile="~/Form/Site1.Master" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="Bai_TH5.Form.home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Hệ thống quản lý sinh viên</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%-- Thống kê hồ sơ --%>
    <div class="row text-uppercase font-weight-bold">
        <div class="col-xl-12">
            <i class="fas fa-palette"></i>&ensp; Tổng hợp hệ thống dữ liệu
        </div>
    </div>
    <div class="row">
        <div class="col-xl-3">
            <div class="pl-3 pr-3"style="background:#CDDC39;">
                <div class="row">
                    <div class="col-xl-5 float-left align-self-center">
                        <i class="fas fa-users fa-2x"></i>
                    </div>
                    <div class="col-xl-7 float-right text-xl-right align-self-center text-uppercase font-weight-bold fa-2x">
                        <asp:Label ID="lblCountHoSoSV" runat="server"></asp:Label>
                    </div>
                </div>
                <div class="row">
                    <div class="col-xl-12 text-xl-left">Hồ sơ sinh viên</div>
                </div>
            </div>
        </div>
        <div class="col-xl-3">
            <div class="pl-3 pr-3 badge-warning">
                <div class="row">
                    <div class="col-xl-5 float-left align-self-center">
                        <i class="fas fa-user-times fa-2x"></i>
                    </div>
                    <div class="col-xl-7 float-right text-xl-right align-self-center text-uppercase font-weight-bold fa-2x">
                        <asp:Label ID="lblCountHoSoGV" runat="server"></asp:Label>
                    </div>
                </div>
                <div class="row">
                    <div class="col-xl-12 text-xl-left">Hồ sơ giáo viên</div>
                </div>
            </div>
        </div>
        <div class="col-xl-3">
            <div class="pl-3 pr-3 badge-success">
                <div class="row">
                    <div class="col-xl-5 float-left align-self-center">
                        <i class="fas fa-chart-pie fa-2x"></i>
                    </div>
                    <div class="col-xl-7 float-right text-xl-right align-self-center text-uppercase font-weight-bold fa-2x">
                        <asp:Label ID="lblCount_DoAnTN" runat="server"></asp:Label>
                    </div>
                </div>
                <div class="row">
                    <div class="col-xl-12 text-xl-left">Đồ án tốt nghiệp</div>
                </div>
            </div>
        </div>
        <div class="col-xl-3">
            <div class="pl-3 pr-3 badge-danger">
                <div class="row">
                    <div class="col-xl-5 float-left align-self-center">
                        <i class="fas fa-lock fa-2x"></i>
                    </div>
                    <div class="col-xl-7 float-right text-xl-right align-self-center text-uppercase font-weight-bold fa-2x">
                        <asp:Label ID="lblCount_ChuyenNganh" runat="server"></asp:Label>
                    </div>
                </div>
                <div class="row">
                    <div class="col-xl-12 text-xl-left">Số chuyên ngành</div>
                </div>
            </div>
        </div>
    </div>
    <%-- end Thống kê hồ sơ --%>
    <%-- Thống kê chuyên ngành --%>
    <div class="row">
        <div class="col-xl-12 text-xl-left text-uppercase font-weight-bold">
            Thống kê sinh viên theo chuyên ngành:
        </div>
    </div>
    <div class="row">
        <div class="col-xl-12">
            <table class="table table-striped">
              <thead class="badge-success">
                <tr>
                  <th scope="col">STT</th>
                  <th scope="col">Chuyên ngành</th>
                  <th scope="col">Số sinh viên</th>
                  <th scope="col">Chi tiết</th>
                </tr>
              </thead>
              <tbody>
                <asp:Literal ID="lit_sv_cn" runat="server" Mode="Transform"></asp:Literal>
              </tbody>
            </table>
        </div>
    </div>
    <%-- end Thống kê chuyên ngành --%>

    <%-- Thống kê đồ án theo điểm --%>
    <div class="row">
        <div class="col-xl-12 text-uppercase font-weight-bold">Thống kê đồ án theo điểm</div>
    </div>
    <div class="ml-3 mr-3 mb-5">
        <div class="row badge-warning text-body pt-2 pb-2 font-weight-bold" style="cursor:pointer" onclick="replaceDiemDA(1)">
            <div class="col-xl-6">
                <span class="w3-circle text-uppercase font-weight-bold boder rounded-circle border border-dark pl-1 pr-1">7</span>
                <span>Điểm đồ án <= 7.0 -------------------</span> <asp:Label ID="lblCount_DALoai1" runat="server" Text=""></asp:Label>
            </div>
            <div class="col-xl-6">
                <button type="button" class="close float-right" aria-label="Close"><span aria-hidden="true">&times;</span></button>
            </div>
        </div>
        <div class="row badge-info text-body pt-2 pb-2 font-weight-bold" style="cursor:pointer" onclick="replaceDiemDA(2)">
            <div class="col-xl-6">
                <span class="w3-circle text-uppercase font-weight-bold boder rounded-circle border border-dark pl-1 pr-1">8</span>
                <span>Điểm đồ án từ 7.1 đến 8.0 -----------</span> <asp:Label ID="lblCount_DALoai2" runat="server" Text=""></asp:Label>
            </div>
            <div class="col-xl-6">
                <button type="button" class="close float-right" aria-label="Close"><span aria-hidden="true">&times;</span></button>
            </div>
        </div>
        <div class="row badge-primary text-body pt-2 pb-2 font-weight-bold" style="cursor:pointer" onclick="replaceDiemDA(3)">
            <div class="col-xl-6">
                <span class="w3-circle text-uppercase font-weight-bold boder rounded-circle border border-dark pl-1 pr-1">9</span>
                <span>Điểm đồ án từ 8.1 đến 9.0 -----------</span> <asp:Label ID="lblCount_DALoai3" runat="server" Text=""></asp:Label>
            </div>
            <div class="col-xl-6">
                <button type="button" class="close float-right" aria-label="Close"><span aria-hidden="true">&times;</span></button>
            </div>
        </div>
        <div class="row text-body pt-2 pb-2 font-weight-bold" style="background:#CDDC39; cursor:pointer" onclick="replaceDiemDA(4)">
                <div class="col-xl-6">
                    <span class="w3-circle text-uppercase font-weight-bold boder rounded-circle border border-dark pl-1 pr-1">10</span>
                    <span>Điểm đồ án từ 9.1 đến 10 ----------</span> <asp:Label ID="lblCount_DALoai4" runat="server" Text=""></asp:Label>
                </div>
                <div class="col-xl-6">
                    <button type="button" class="close float-right" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                </div>
            </div>
    </div>
    
    <%-- end thống kê đồ án theo điểm --%>

    <%-- Thống kê đồ án tốt nghiệp theo lĩnh vực --%>
    <div class="row">
        <div class="col-xl-12 text-xl-left text-uppercase font-weight-bold">
            Thống kê sinh viên theo chuyên ngành:
        </div>
    </div>
    <div class="row">
        <div class="col-xl-12">
            <table class="table table-striped">
              <thead class="badge-success">
                <tr>
                  <th scope="col">STT</th>
                  <th scope="col">Lĩnh vực</th>
                  <th scope="col">Số đồ án</th>
                  <th scope="col">Chi tiết</th>
                </tr>
              </thead>
              <tbody>
                <asp:Literal ID="lit_da_lv" runat="server" Mode="Transform"></asp:Literal>
              </tbody>
            </table>
        </div>
    </div>
    <%-- end Thống kê chuyên ngành --%>

</asp:Content>
