<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminLogin.aspx.cs" Inherits="AdminLogin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>网站后台-管理员登录</title>
</head>
<body id="adminloginpagemain">
    <form id="form1" runat="server">
    <div id="adminloginmain">
        <div id="adminlogintop">
        </div>
        <div id="adminlogincenter">
            <div id="adminloginleft">
            </div>
            <div id="adminlogincentermain">
                <div id="adminlogincentercontent">
                <div id="adminlogincenterblank"></div>
                    <p>
                        管理员：<asp:TextBox ID="txtUserName" runat="server" Width="100px" 
                            BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorUserName" runat="server" 
                            ErrorMessage="RequiredFieldValidator" ControlToValidate="txtUserName" 
                            Display="Dynamic">*</asp:RequiredFieldValidator>
                        <br />
                        密&nbsp;&nbsp;&nbsp;&nbsp;码：<asp:TextBox ID="txtPwd" runat="server" 
                            Width="100px" TextMode="Password" BorderColor="#999999" 
                            BorderStyle="Solid" BorderWidth="1px"></asp:TextBox><br />
                        验证码：<asp:TextBox ID="txtCheckCode" runat="server" MaxLength="4" Width="40px" 
                            BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px"></asp:TextBox>
                        <img src="ValidateCodeHandler.ashx" alt="单击图片，可以换一个验证码." style="cursor: pointer"
                                            onclick="this.src='ValidateCodeHandler.ashx?'+new Date()" />
                    </p>
                </div>
                <div id="adminlogincenterbutton">
                    <asp:ImageButton ID="btnLogin" runat="server" 
                        ImageUrl="~/Image/admin_login_button.jpg" onclick="btnLogin_Click" />
                </div>
            </div>
            <div id="adminloginright">
            </div>
        </div>
        <div id="adminloginbottom">
        </div>
    </div>
    </form>
</body>
</html>
