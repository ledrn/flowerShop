<%@ Page Title="后台管理-添加用户" Language="C#" MasterPageFile="~/Admin/AdminPage.master" AutoEventWireup="true" CodeFile="AddUser.aspx.cs" Inherits="Admin_AddUser" StylesheetTheme="FlowerShopTheme" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div  style=" width:350px; text-align:left; line-height:28px">
    <br />
    <p>
        登录用户名：&nbsp;&nbsp;<asp:TextBox ID="txtUserName" runat="server" Width="200px" CssClass="admintextbox"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RFValidatorUserName" runat="server" 
            ErrorMessage="RequiredFieldValidator" ControlToValidate="txtUserName">*</asp:RequiredFieldValidator>
        <br />
        登录用户密码：<asp:TextBox ID="txtUserPwd" runat="server" TextMode="Password"  CssClass="admintextbox" 
            Width="200px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RFValidatorPwd" runat="server" 
            ErrorMessage="RequiredFieldValidator" ControlToValidate="txtUserPwd">*</asp:RequiredFieldValidator>
        <br />
        重新输入密码：<asp:TextBox ID="txtReUserPwd" runat="server" TextMode="Password" CssClass="admintextbox" 
            Width="200px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RFValidatorRePwd" runat="server" 
            ErrorMessage="RequiredFieldValidator" ControlToValidate="txtReUserPwd">*</asp:RequiredFieldValidator>
        <asp:CompareValidator ID="CompareValidatorRePwd" runat="server" 
            ErrorMessage="CompareValidator" ControlToCompare="txtUserPwd" 
            ControlToValidate="txtReUserPwd" Display="Dynamic">两次密码不一致，请重新输入</asp:CompareValidator>
        <br />
        真实姓名：&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="txtRealName" runat="server"  CssClass="admintextbox" 
            Width="200px"></asp:TextBox>
    </p>
    <br />
    <div style=" text-align:center">
        <asp:Button ID="btnSubmit" runat="server" CssClass="adminbottonadd" onclick="btnSubmit_Click" />&nbsp;&nbsp;
    </div>
</div>
</asp:Content>

