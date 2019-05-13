<%@ Page Title="网站后台-审核申请加盟信息" Language="C#" MasterPageFile="~/Admin/AdminPage.master" AutoEventWireup="true" CodeFile="ViewLeague.aspx.cs" Inherits="Admin_ViewLeague" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div style=" text-align:left; line-height:28px; width:400px;">
    <br />
    <p>
        编号：&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lblId" runat="server" Text=""></asp:Label><br />
        花店名称：&nbsp;&nbsp;<asp:Label ID="lblTitle" runat="server" Text=""></asp:Label><br />
        所在地区：&nbsp;&nbsp;<asp:Label ID="lblArea" runat="server" Text=""></asp:Label><br />
        花店负责人：<asp:Label ID="lblName" runat="server" Text=""></asp:Label><br />
        花店地址：&nbsp;&nbsp;<asp:Label ID="lblAddress" runat="server" Text=""></asp:Label><br />
        联系电话：&nbsp;&nbsp;<asp:Label ID="lblPhone" runat="server" Text=""></asp:Label><br />
        手机：&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lblMobilePhone" runat="server" Text=""></asp:Label><br />
        传真：&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lblFax" runat="server" Text=""></asp:Label><br />
        电子邮件：&nbsp;&nbsp;<asp:Label ID="lblEmail" runat="server" Text=""></asp:Label><br />
        QQ号：&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lblQQ" runat="server" Text=""></asp:Label><br />
    </p>
    <p>
        开户行：&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lblBank" runat="server" Text=""></asp:Label><br />
        账号：&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lblAccountNumber" runat="server" Text=""></asp:Label><br />
        收款人：&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lblPayee" runat="server" Text=""></asp:Label><br />
        配送区域：&nbsp;&nbsp;<asp:Label ID="lblSendArea" runat="server" Text=""></asp:Label><br />
        花店简介：&nbsp;&nbsp;<asp:Label ID="lblShopSummary" Width="300px" runat="server" Text=""></asp:Label><br />
        申请时间：&nbsp;&nbsp;<asp:Label ID="lblWriteTime" runat="server" Text=""></asp:Label><br />
        申请状态：&nbsp;&nbsp;<asp:Label ID="lblLeagueState" runat="server" Text=""></asp:Label><br />
    </p>
    <br />
    <div style=" text-align:center">
        <asp:Button ID="btnApply" runat="server" CssClass="adminbottonpass" OnClientClick='return confirm("确认审核通过吗?");' onclick="btnApply_Click" />&nbsp;&nbsp;
        <asp:Button ID="btnReturn" runat="server" CssClass="adminbottonreturn" 
            PostBackUrl="LeagueList.aspx" />
    </div>
    
</div>
</asp:Content>

