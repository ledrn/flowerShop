<%@ Page Title="网站后台-添加付款方式" Language="C#" MasterPageFile="~/Admin/AdminPage.master" AutoEventWireup="true" CodeFile="AddPayType.aspx.cs" Inherits="Admin_AddPayType" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div style="width:400px;text-align:left; line-height:28px;">
<br />
    <p>
        付款名称：<asp:TextBox ID="txtName" runat="server" CssClass="admintextbox" Width="300px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorName" runat="server" 
            ControlToValidate="txtName" ErrorMessage="RequiredFieldValidator">*</asp:RequiredFieldValidator>
        <br />
        付款方式：<asp:TextBox ID="txtContent" CssClass="admintextbox" runat="server" TextMode="MultiLine" 
            Height="114px" Width="300px"></asp:TextBox><br />
    </p>
    <br />
    <div style=" text-align:center">
        <asp:Button ID="btnSubmit" runat="server" onclick="btnSubmit_Click" CssClass="adminbottonadd" />
    </div>
    
</div>
</asp:Content>

