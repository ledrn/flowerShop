<%@ Page Title="会员中心-申请成功" Language="C#" MasterPageFile="~/Base.master" AutoEventWireup="true" CodeFile="RegisterSccess.aspx.cs" Inherits="RegisterSccess" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div id="usercentertitle"></div>
<div class="indextitleline"></div>
<div id="leaguesendsccess">注册成功,如果需要修改,请到用户中心修改您的个人资料。</div>
<div id="leaguesendsccessreturn"><asp:Image ID="Image1" runat="server" 
        ImageUrl="~/Image/main_small_flower.jpg" /><a style="text-decoration:none; font-size:16px;color:#752794; font-weight:bolder" href="UserCenterDefault.aspx">返回会员中心</a></div>
</asp:Content>

