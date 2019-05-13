<%@ Page Title="订单查询结果" Language="C#" MasterPageFile="~/Base.master" AutoEventWireup="true" CodeFile="SearchOrder.aspx.cs" Inherits="SearchOrder" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div id="searchordertitle"></div>
<div class="indextitleline"></div>
<div id="searchordermain">
<asp:Label ID="lblOrderId" runat="server" Text="订单号："></asp:Label><asp:Label
    ID="lblSumPrice" runat="server" Text="，应付款金额：￥"></asp:Label><br />
    <asp:Label ID="lblOrderState" runat="server" Text="您的订单"></asp:Label>
</div>
</asp:Content>

