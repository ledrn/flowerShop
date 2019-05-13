<%@ Page Title="网站后台-修改加盟常见问题" Language="C#" MasterPageFile="~/Admin/AdminPage.master" AutoEventWireup="true" CodeFile="EditLeagueQA.aspx.cs" Inherits="Admin_EditLeagueQA" %>
<%@ Register assembly="FredCK.FCKeditorV2" namespace="FredCK.FCKeditorV2" tagprefix="FCKeditorV2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div style=" text-align:left; line-height:28px">
<br />
    <p>
        编号：<asp:Label ID="lblId" runat="server" Text=""></asp:Label><br />
        问题：<asp:TextBox ID="txtQuestion" runat="server" Width="450px" CssClass="admintextbox"></asp:TextBox><br />
        解答：<FCKeditorV2:FCKeditor ID="FCKeditor1" runat="server" Height="450">
    </FCKeditorV2:FCKeditor>
    </p>
    <div style=" text-align:center">
        <asp:Button ID="btnSubmit" runat="server" CssClass="adminbottonupdate" onclick="btnSubmit_Click" />&nbsp;
        <asp:Button ID="btnReturn" runat="server" CssClass="adminbottonreturn" PostBackUrl="LeagueQAList.aspx" />
    </div>
    
</div>
</asp:Content>

