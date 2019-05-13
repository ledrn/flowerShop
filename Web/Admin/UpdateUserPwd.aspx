<%@ Page Title="后台管理-修改用户密码" Language="C#" MasterPageFile="~/Admin/AdminPage.master" AutoEventWireup="true" CodeFile="UpdateUserPwd.aspx.cs" Inherits="Admin_UpdateUserPwd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div style=" line-height:28px; text-align:left; width:300px">
    <br />
    <p>
        用户编号：&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lblUserId" runat="server" Text=""></asp:Label><br />
        用户名称：&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lblUserName" runat="server" Text=""></asp:Label><br />
        设置新密码：&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="txtPwd" runat="server" TextMode="Password" CssClass="admintextbox"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RFValidatorPwd" runat="server" 
            ControlToValidate="txtPwd" ErrorMessage="RequiredFieldValidator">*</asp:RequiredFieldValidator>
        <br />
        重新输入新密码：<asp:TextBox ID="txtRePwd" runat="server" TextMode="Password" CssClass="admintextbox"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RFValidatorRePwd" runat="server" 
            ControlToValidate="txtRePwd" ErrorMessage="RequiredFieldValidator">*</asp:RequiredFieldValidator>
        <asp:CompareValidator ID="CompareValidatorRePwd" runat="server" 
            ControlToCompare="txtPwd" ControlToValidate="txtRePwd" Display="Dynamic" 
            ErrorMessage="CompareValidator">两次输入密码不一致，请重新输入！</asp:CompareValidator>
        <br />
    </p>
    <br />
    <div style=" text-align:center">
        <asp:Button ID="btnSubmit" runat="server" CssClass="adminbottonupdate" onclick="btnSubmit_Click" />&nbsp;
        
    </div>
</div>
</asp:Content>

