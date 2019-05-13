<%@ Page Title="配送范围" Language="C#" MasterPageFile="~/Base.master" AutoEventWireup="true" CodeFile="SendArea.aspx.cs" Inherits="SendArea" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div id="sendareatitle"></div>
<div class="indextitleline"></div>

<div id="sendareainfotitle">
我们配送下列城市3小时送达！下列城市郊区及未列县（市）一级地区如要派送需加收一定的投递费。<br />
<a style="color:#762697" href="Sendmaincity.aspx">>> 国内主要城市 市区/郊区查询</a>

</div>
<div id="aftersellmain">
    <asp:Label ID="lblSendArea" runat="server" Width="640px"></asp:Label></div>
</asp:Content>
