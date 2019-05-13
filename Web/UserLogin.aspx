<%@ Page Title="会员中心-登录" Language="C#" MasterPageFile="~/Base.master" AutoEventWireup="true" CodeFile="UserLogin.aspx.cs" Inherits="UserLogin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div id="usercentertitle"></div>
<div class="indextitleline"></div>
 <div id="userloginpagemain">
    <div id="userlogintop">会员登录</div>
    <div id="userlogintopinfo">
        <img width="16" height="16" alt="" src="Image/user_login_warning.gif" /> 请输入登陆的用户和密码
    </div>
    <div id="userlogininfo">
        用户名<br/>
        <asp:Image ID="imgUser" runat="server" 
            ImageUrl="image/user_login_username.gif" />
        <asp:TextBox ID="txtUserName" runat="server" Width="125px" 
            BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorName" runat="server" 
            ErrorMessage="RequiredFieldValidator" ControlToValidate="txtUserName" 
            Display="Dynamic">*</asp:RequiredFieldValidator><br />
        密码：<br />
        <asp:Image ID="imgPwd" runat="server" 
            ImageUrl="image/user_login_password.gif" />
        <asp:TextBox ID="txtUserPwd" runat="server" TextMode="Password" Width="125px" 
            BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px"></asp:TextBox><br />
        <a href="RegisterUser.aspx" style="color:#FF6600">没有用户名？</a>
        
    </div>
    <div id="userloginbutton">
        <asp:ImageButton ID="imgBtnSubmit" runat="server" 
            ImageUrl="image/user_login_loginin.gif" onclick="imgBtnSubmit_Click" />
    </div>
 </div>
</asp:Content>

