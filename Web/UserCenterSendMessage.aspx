<%@ Page Title="会员中心-发送短信" Language="C#" MasterPageFile="~/Base.master" AutoEventWireup="true" CodeFile="UserCenterSendMessage.aspx.cs" Inherits="UserCenterSendMessage" %>
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
<div id="usercentersendmessagemain">
    <div id="usercentersendmessagetitle">请填写您的短信息：</div>
    <div id="usercentersendmessagenameleft">消息标题：</div>
    <div id="usercentersendmessagenameright">
        <asp:TextBox ID="txtMessageTitle" runat="server" BorderColor="#999999" 
            BorderStyle="Solid" BorderWidth="1px" Height="24px" Width="300px"></asp:TextBox>
    </div>
    <div id="usercentersendmessagecontentleft">消息内容：</div>
    <div id="usercentersendmessagecontentright">
         <asp:TextBox ID="txtMessageContent" runat="server" BorderColor="#999999" 
            BorderStyle="Solid" BorderWidth="1px" Height="116px" Width="300px" 
             TextMode="MultiLine"></asp:TextBox>
    </div>
    <div id="usercentersendmessagebutton">
        <br /><br />
        <asp:ImageButton ID="imgBtnSubmit" runat="server" 
            ImageUrl="Image/usercenter_confirm.jpg" onclick="imgBtnSubmit_Click" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:ImageButton ID="imgBtnReturn" runat="server" 
            ImageUrl="Image/usercenter_cancel.jpg" 
            PostBackUrl="UserCenterDefault.aspx"/>
    </div>
</div>
</asp:Content>

