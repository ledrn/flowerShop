<%@ Page Title="网站后台-修改付款方式" Language="C#" MasterPageFile="~/Admin/AdminPage.master" AutoEventWireup="true" CodeFile="EditPayType.aspx.cs" Inherits="Admin_EditPayType" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div style=" width:400px; text-align:left; line-height:28px">
<br />
    <p>
        编号：&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lblId" runat="server" Text=""></asp:Label><br />
        付款名称：<asp:TextBox ID="txtName" runat="server" Width="300px" CssClass="admintextbox"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorName" runat="server" 
            ControlToValidate="txtName" ErrorMessage="RequiredFieldValidator">*</asp:RequiredFieldValidator>
        <br />
        付款方式：<asp:TextBox ID="txtContent" runat="server" TextMode="MultiLine" CssClass="admintextbox" 
            Height="114px" Width="300px"></asp:TextBox><br /><br />
    </p>
    <div style=" text-align:center">
        <asp:Button ID="btnSubmit" runat="server" CssClass="adminbottonupdate" onclick="btnSubmit_Click" />&nbsp;&nbsp;
        <asp:Button ID="btnReturn" runat="server" CssClass="adminbottonreturn" PostBackUrl="PayTypeList.aspx" />
    </div>
    
</div>
</asp:Content>

