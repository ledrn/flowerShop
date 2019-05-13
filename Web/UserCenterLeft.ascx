<%@ Control Language="C#" AutoEventWireup="true" CodeFile="UserCenterLeft.ascx.cs" Inherits="UserCenterLeft" %>
<asp:ImageButton ID="ImageButton1" runat="server" 
        ImageUrl="Image/usercenter_default.jpg" PostBackUrl="UserCenterDefault.aspx" /><br />
    <asp:ImageButton ID="ImageButton2" runat="server" 
        ImageUrl="Image/usercenter_userinfo.jpg" PostBackUrl="UserCenterUpdateUserInfo.aspx" /><br />
    <asp:ImageButton ID="ImageButton3" runat="server" 
        ImageUrl="Image/usercenter_userorder.jpg" PostBackUrl="UserCenterOrder.aspx" /><br />
    <asp:ImageButton ID="ImageButton4" runat="server" 
        ImageUrl="Image/usercenter_getmessage.jpg" PostBackUrl="UserCenterGetMessage.aspx" /><br />
    <asp:ImageButton ID="ImageButton5" runat="server" 
        ImageUrl="Image/usercenter_sendmessage.jpg" PostBackUrl="UserCenterSendMessage.aspx" /><br />
    <asp:ImageButton ID="ImageButton6" runat="server" 
        ImageUrl="Image/usercenter_exit.jpg" onclick="ImageButton6_Click" /><br />