<%@ Page Title="订单完成" Language="C#" MasterPageFile="~/Base.master" AutoEventWireup="true" CodeFile="SubmitOrder.aspx.cs" Inherits="SubmitOrder" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div id="orderlisttitle"></div>
<div class="indextitleline"></div>
<div id="orderlistflow3"></div>
<div id="submitordermain">
&nbsp;&nbsp;&nbsp;&nbsp;尊敬的客户，请记住您的订单<b>（订单号：<asp:Label ID="lblOrderId" runat="server"
    Text=""></asp:Label>，应付款金额：￥<asp:Label ID="lblSumPrice" runat="server" Text=""></asp:Label>）</b>，方便以后查询，只有付款成功后，才能完成本次交易。您可选择在线实时支付，或通过邮局、银行柜台或网上银行办理付款手续。请在付款后尽快同我们联系，以确保按时完成您的订单。
</div>
<div id="submitorderbutton">
    <asp:ImageButton ID="imgBtnToAlipay" runat="server" 
        ImageUrl="~/Image/orderlist_alipay.jpg" /></div>
</asp:Content>

