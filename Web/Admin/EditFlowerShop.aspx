<%@ Page Title="网站后台-修改各地花店" Language="C#" MasterPageFile="~/Admin/AdminPage.master" AutoEventWireup="true" CodeFile="EditFlowerShop.aspx.cs" Inherits="Admin_EditFlowerShop" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div style=" text-align:left; width:300px; line-height:28px">
<br />
    <p>
        花店编号：<asp:Label ID="lblFlowerShopId" runat="server" Text=""></asp:Label><br />
        花店名称：<asp:TextBox ID="txtName" runat="server" Width="200px" CssClass="admintextbox"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorName" runat="server" 
            ControlToValidate="txtName" ErrorMessage="RequiredFieldValidator">*</asp:RequiredFieldValidator>
        <br />
    </p>
    <br />
    <div style=" text-align:center">
        <asp:Button ID="btnSubmit" runat="server"  CssClass="adminbottonupdate"  onclick="btnSubmit_Click" />&nbsp;&nbsp;
        <asp:Button ID="btnReturn" runat="server" CssClass="adminbottonreturn"
            PostBackUrl="FlowerShopList.aspx" />
    </div>
</div>
</asp:Content>

