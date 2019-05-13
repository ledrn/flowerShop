<%@ Page Title="后台管理-更新管理员信息" Language="C#" MasterPageFile="~/Admin/AdminPage.master" AutoEventWireup="true" CodeFile="EditAdmin.aspx.cs" Inherits="Admin_EditAdmin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div style=" text-align:left; line-height:28px; width:300px;">
<br />
    管理员编号：<asp:Label ID="lblUserId" runat="server" Text=""></asp:Label><br/>
    管理员名称：<asp:Label ID="lblUserName" runat="server" Text=""></asp:Label><br/>
    真实姓名：&nbsp;&nbsp;<asp:TextBox ID="txtRealName" runat="server" 
        CssClass="admintextbox" Width="150px"></asp:TextBox><br />
        <br />
   <div  style=" text-align:center"> 
    <asp:Button ID="btnSubmit" runat="server" CssClass="adminbottonupdate" onclick="btnSubmit_Click" />
    &nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="btnReturn" runat="server"
        PostBackUrl="UserList.aspx" CssClass="adminbottonreturn"/>
        </div>
</div>
    
</asp:Content>

