<%@ Page Title="网站后台-添加各地花店" Language="C#" MasterPageFile="~/Admin/AdminPage.master" AutoEventWireup="true" CodeFile="AddFlowerShop.aspx.cs" Inherits="Admin_AddFlowerShop" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div>
<br /><br />
    <p>
        花店名称：<asp:TextBox ID="txtName" CssClass="admintextbox" runat="server" 
            Width="300px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorName" runat="server" 
            ControlToValidate="txtName" ErrorMessage="RequiredFieldValidator">*</asp:RequiredFieldValidator>
        <br />
    </p>
    <br />
        <asp:Button ID="btnSubmit" runat="server"  CssClass="adminbottonadd" onclick="btnSubmit_Click" />

</div>
</asp:Content>

