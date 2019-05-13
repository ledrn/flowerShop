<%@ Page Title="网站后台-修改城市配送详细信息" Language="C#" MasterPageFile="~/Admin/AdminPage.master" AutoEventWireup="true" CodeFile="EditSendmaincity.aspx.cs" Inherits="Admin_EditSendmaincity" %>
<%@ Register assembly="FredCK.FCKeditorV2" namespace="FredCK.FCKeditorV2" tagprefix="FCKeditorV2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div style=" text-align:left; line-height:28px">
<br />城市配送详细信息：
    <FCKeditorV2:FCKeditor ID="FCKeditor1" runat="server" Height="450">
    </FCKeditorV2:FCKeditor><br />
    <div style=" text-align:center">
        <asp:Button ID="btnSubmit" runat="server" CssClass="adminbottonupdate" onclick="btnSubmit_Click" />
    </div>
</div>
</asp:Content>

