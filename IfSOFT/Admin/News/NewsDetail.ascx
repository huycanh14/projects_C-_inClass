<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="NewsDetail.ascx.cs" Inherits="IfSOFT.Admin.News.NewsDetail" %>
<div>Danh sách tin tức</div>
<div>
    <asp:Repeater ID="rptNewsCategory" runat="server">
        <HeaderTemplate>
            <table style="width: 100%">
                <tr>
                    <td style="width: 300px">Category Name</td>
                    <td style="width: 50px">Order</td>
                    <td style="width: 100px">Active</td>
                    <td></td>
                </tr>
            </table>
        </HeaderTemplate>
        <ItemTemplate>
            <tr>
                <%#:Eval("CategoryName") %>
            </tr>
            <tr>
                <%#:Eval("Order") %>
            </tr>
            <tr>
                <%#:Eval("Active") %>
            </tr>
        </ItemTemplate>
        <FooterTemplate>

        </FooterTemplate>
    </asp:Repeater>
</div>
