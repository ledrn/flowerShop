<%@ Page Title="会员中心" Language="C#" MasterPageFile="~/Base.master" AutoEventWireup="true" CodeFile="UserCenterDefault.aspx.cs" Inherits="UserCenterDefault" %>

<%@ Register src="UserCenterLeft.ascx" tagname="UserCenterLeft" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div id="usercentertitle"></div>
<div class="indextitleline"></div>
<div id="usercentertitleblank"></div>
<div id="usercenterleft">
    
    <uc1:UserCenterLeft ID="UserCenterLeft1" runat="server" />
    
   </div>
<div id="usercenterright">
    <p>
        欢迎您， <asp:Label ID="lblUserName" runat="server" Text=""></asp:Label> ！<br />
        您本次登录IP：<asp:Label ID="lblUserIP" runat="server" Text=""></asp:Label>
    </p>
</div>
    
</asp:Content>

