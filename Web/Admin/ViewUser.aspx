<%@ Page Title="后台管理-查看用户信息" Language="C#" MasterPageFile="~/Admin/AdminPage.master" AutoEventWireup="true" CodeFile="ViewUser.aspx.cs" Inherits="Admin_ViewUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div style=" text-align:left; line-height:28px; width:400px;">
    <div style=" text-align:center; height:40px; line-height:40px;">
        <b>用户信息</b>
    </div>
    <p>
        用户编号：<asp:Label ID="lblUserId" runat="server" Text=""></asp:Label><br />
        用户名称：<asp:Label ID="lblUserName" runat="server" Text=""></asp:Label><br />
        真实姓名：<asp:Label ID="lblRealName" runat="server" Text=""></asp:Label><br />
        
        年龄：&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lblAge" runat="server" Text=""></asp:Label><br />
        性别：&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lblSex" runat="server" Text=""></asp:Label><br />
    </p>
    <p>
        电子邮件：<asp:Label ID="lblEmail" runat="server" Text=""></asp:Label><br />
        省份：&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lblProvinces" runat="server" Text=""></asp:Label><br />
        城市：&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lblCity" runat="server" Text=""></asp:Label><br />
        联系地址：<asp:Label ID="lblAddress" runat="server" Text=""></asp:Label><br />
        邮政编码：<asp:Label ID="lblPostcode" runat="server" Text=""></asp:Label><br />
        联系电话：<asp:Label ID="lblPhone" runat="server" Text=""></asp:Label><br />
        手机：&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lblMobilePhone" runat="server" Text=""></asp:Label><br />
        QQ号：&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lblQQ" runat="server" Text=""></asp:Label><br />
    </p>
    <p>
        申请时间：<asp:Label ID="lblWriteTime" runat="server" Text=""></asp:Label><br />
        备注：&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="txtNote" runat="server" TextMode="MultiLine" CssClass="admintextbox" 
            ReadOnly="True" Height="66px" Width="300px"></asp:TextBox><br />
    </p>
    <br />
    <div style=" text-align:center">
        <asp:Button ID="btnReturn" runat="server" CssClass="adminbottonreturn" PostBackUrl="UserList.aspx" />
    </div>
</div>
</asp:Content>

