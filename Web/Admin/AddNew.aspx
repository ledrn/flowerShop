<%@ Page Title="网站后台-添加新闻" Language="C#" MasterPageFile="~/Admin/AdminPage.master" AutoEventWireup="true" CodeFile="AddNew.aspx.cs" Inherits="Admin_AddNew" %>

<%@ Register assembly="FredCK.FCKeditorV2" namespace="FredCK.FCKeditorV2" tagprefix="FCKeditorV2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style=" text-align:left; line-height:28px">
    <br />
    <p>
        新闻标题：<asp:TextBox ID="txtNewTitle" runat="server" CssClass="admintextbox" 
            Width="450px" ></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorTitle" runat="server" 
            ErrorMessage="RequiredFieldValidator" ControlToValidate="txtNewTitle">*</asp:RequiredFieldValidator>
        <br />
        新闻内容：<FCKeditorV2:FCKeditor ID="FCKeditor1" runat="server" Height="450px">
        </FCKeditorV2:FCKeditor>
    </p>
    <div style=" text-align:center;">
        <asp:Button ID="btnSubmit" runat="server"  CssClass="adminbottonadd" onclick="btnSubmit_Click" />
    </div>
</div>
    
</asp:Content>

