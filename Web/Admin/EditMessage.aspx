<%@ Page Title="网站后台-阅读消息" Language="C#" MasterPageFile="~/Admin/AdminPage.master" AutoEventWireup="true" CodeFile="EditMessage.aspx.cs" Inherits="Admin_EditMessage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div style=" text-align:left; line-height:28px; width:450px">
    <p>
        消息编号：<asp:Label ID="lblId" runat="server" Text=""></asp:Label><br />
        发消息人：<asp:Label ID="lblFromUser" runat="server" Text=""></asp:Label><br />
        消息标题：<asp:Label ID="lblTitle" runat="server" Text=""></asp:Label><br />
        消息内容：<asp:Label ID="lblMessage" runat="server" Text="" Width="300px" ></asp:Label><br />
        消息时间：<asp:Label ID="lblWriteTime" runat="server" Text=""></asp:Label><br />
    </p>
    <br />
    <hr style="width:400px" />
    <br />
    <p>
        回复标题：<asp:TextBox ID="txtReTitle" runat="server" CssClass="admintextbox" 
            Width="300px"></asp:TextBox><br />
        回复内容：<asp:TextBox ID="txtReMessage" runat="server" Height="100px" 
            TextMode="MultiLine" Width="300px" CssClass="admintextbox"></asp:TextBox><br /><br />
    </p>
    <div style=" text-align:center">
        <asp:Button ID="btnSubmit" runat="server" CssClass="adminbottonresend" onclick="btnSubmit_Click" />&nbsp;
        <asp:Button ID="btnReturn" runat="server" CssClass="adminbottonreturn"  
            PostBackUrl="~/Admin/MessageList.aspx" />
    </div>
</div>
</asp:Content>

