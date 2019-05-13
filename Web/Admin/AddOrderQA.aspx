<%@ Page Title="网站后台-添加订单常见问题" Language="C#" MasterPageFile="~/Admin/AdminPage.master" AutoEventWireup="true" CodeFile="AddOrderQA.aspx.cs" Inherits="Admin_AddOrderQA" %>
<%@ Register assembly="FredCK.FCKeditorV2" namespace="FredCK.FCKeditorV2" tagprefix="FCKeditorV2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div style=" text-align:left; line-height:28px">
<br />
    <p>
        问题：<asp:TextBox ID="txtQuestion" runat="server" CssClass="admintextbox" 
            Width="450px"></asp:TextBox><br />
        解答：<FCKeditorV2:FCKeditor ID="FCKeditor1" runat="server" Height="450">
    </FCKeditorV2:FCKeditor><br />
    </p>
    <div style=" text-align:center">
        <asp:Button ID="btnSubmit" runat="server"  CssClass="adminbottonadd" onclick="btnSubmit_Click" />
    </div>
    
</div>
</asp:Content>

