<%@ Page Title="网站后台-修改新闻" Language="C#" MasterPageFile="~/Admin/AdminPage.master" AutoEventWireup="true" CodeFile="EditNew.aspx.cs" Inherits="Admin_EditNew" %>
<%@ Register assembly="FredCK.FCKeditorV2" namespace="FredCK.FCKeditorV2" tagprefix="FCKeditorV2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div style=" text-align:left; line-height:28px;">
<br />
    <p>
        新闻编号：<asp:Label ID="lblNewId" runat="server" Text=""></asp:Label><br />
        新闻标题：<asp:TextBox ID="txtNewTitle" runat="server" Width="450px" CssClass="admintextbox"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorTitle" runat="server" 
            ErrorMessage="RequiredFieldValidator" ControlToValidate="txtNewTitle">*</asp:RequiredFieldValidator>
        <br />
        新闻内容：<FCKeditorV2:FCKeditor ID="FCKeditor1" runat="server" Height="450px">
        </FCKeditorV2:FCKeditor><br />
        发布时间：<asp:Label ID="lblWriteTime" runat="server" Text=""></asp:Label>
    </p>
    <div style=" text-align:center">
        <asp:Button ID="btnSubmit" runat="server" CssClass="adminbottonupdate" onclick="btnSubmit_Click" />&nbsp;&nbsp;
        <asp:Button ID="btnReturn" runat="server" CssClass="adminbottonreturn" PostBackUrl="NewList.aspx" />
    </div>
</div>
    
</asp:Content>

