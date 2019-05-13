<%@ Page Title="会员中心-会员注册" Language="C#" MasterPageFile="~/Base.master" EnableEventValidation="false" AutoEventWireup="true" CodeFile="RegisterUser.aspx.cs" Inherits="RegisterUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div id="usercentertitle"></div>
<div class="indextitleline"></div>
<div id="usercenterregistermain">
    <div id="usercenterregistertitle">请填写您的基本资料</div>
    <div class="usercenterregistertableleft">&nbsp;&nbsp;登陆账号：<span style="color:Red">*</span></div>
    <div class="usercenterregistertableright">
        <asp:TextBox ID="txtUserName" runat="server" BorderColor="#999999" 
            BorderStyle="Solid" BorderWidth="1px" Height="24px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ControlToValidate="txtUserName" ErrorMessage="RequiredFieldValidator">*</asp:RequiredFieldValidator>
    </div>
            <div class="usercenterregistertableleft">&nbsp;&nbsp;真实姓名：<span style="color:Red">*</span></div>
    <div class="usercenterregistertableright">
        <asp:TextBox ID="txtRealName" runat="server" BorderColor="#999999" 
            BorderStyle="Solid" BorderWidth="1px" Height="24px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
            ControlToValidate="txtRealName" ErrorMessage="RequiredFieldValidator">*</asp:RequiredFieldValidator>
    </div>
            <div class="usercenterregistertableleft">&nbsp;&nbsp;登陆密码：<span style="color:Red">*</span></div>
    <div class="usercenterregistertableright">
        <asp:TextBox ID="txtUserPwd" runat="server" BorderColor="#999999" 
            BorderStyle="Solid" BorderWidth="1px" Height="24px" TextMode="Password" 
            Width="150px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
            ControlToValidate="txtUserPwd" ErrorMessage="RequiredFieldValidator">*</asp:RequiredFieldValidator>
    </div>
            <div class="usercenterregistertableleft">&nbsp;&nbsp;重复密码：<span style="color:Red">*</span></div>
    <div class="usercenterregistertableright">
        <asp:TextBox ID="txtUserRePwd" runat="server" BorderColor="#999999" 
            BorderStyle="Solid" BorderWidth="1px" Height="24px" TextMode="Password" 
            Width="150px"></asp:TextBox>
        <asp:CompareValidator ID="CompareValidator1" runat="server" 
            ControlToCompare="txtUserPwd" ControlToValidate="txtUserRePwd" 
            Display="Dynamic" ErrorMessage="CompareValidator">输入的密码不一致</asp:CompareValidator>
    </div>
            <div class="usercenterregistertableleft">&nbsp;&nbsp;电子邮箱：<span style="color:Red">*</span></div>
    <div class="usercenterregistertableright">
        <asp:TextBox ID="txtEmail" runat="server" BorderColor="#999999" 
            BorderStyle="Solid" BorderWidth="1px" Height="24px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
            ControlToValidate="txtEmail" ErrorMessage="RequiredFieldValidator">*</asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
            ControlToValidate="txtEmail" Display="Dynamic" 
            ErrorMessage="RegularExpressionValidator" 
            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">Email格式不正确</asp:RegularExpressionValidator>
    </div>
            <div class="usercenterregistertableleft">&nbsp;&nbsp;联系地址：</div>
    <div class="usercenterregistertableright">
        <asp:TextBox ID="txtAddress" runat="server" BorderColor="#999999" 
            BorderStyle="Solid" BorderWidth="1px" Height="24px" Width="270px"></asp:TextBox></div>
            <div class="usercenterregistertableleft">&nbsp;&nbsp;邮政编码：</div>
    <div class="usercenterregistertableright">
        <asp:TextBox ID="txtPostcode" runat="server" BorderColor="#999999" 
            BorderStyle="Solid" BorderWidth="1px" Height="24px"></asp:TextBox></div>
            <div class="usercenterregistertableleft">&nbsp;&nbsp;联系电话：</div>
    <div class="usercenterregistertableright">
        <asp:TextBox ID="txtPhone" runat="server" BorderColor="#999999" 
            BorderStyle="Solid" BorderWidth="1px" Height="24px"></asp:TextBox></div>
            <div class="usercenterregistertableleft">&nbsp;&nbsp;手    机：</div>
    <div class="usercenterregistertableright">
        <asp:TextBox ID="txtMobilePhone" runat="server" BorderColor="#999999" 
            BorderStyle="Solid" BorderWidth="1px" Height="24px"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" 
            ControlToValidate="txtMobilePhone" Display="Dynamic" 
            ErrorMessage="RegularExpressionValidator" ValidationExpression="^[0-9]*$">只能输入数字</asp:RegularExpressionValidator></div>
            <div class="usercenterregistertableleft">&nbsp;&nbsp;QQ 号：</div>
    <div class="usercenterregistertableright">
        <asp:TextBox ID="txtQQ" runat="server" BorderColor="#999999" 
            BorderStyle="Solid" BorderWidth="1px" Height="24px"></asp:TextBox></div>
            <div class="usercenterregistertableleft">&nbsp;&nbsp;省 份：</div>
    <div class="usercenterregistertableright">
        <asp:TextBox ID="txtParentLocation" runat="server" BorderColor="#999999" 
            BorderStyle="Solid" BorderWidth="1px" Height="24px"></asp:TextBox>
        </div>
            <div class="usercenterregistertableleft">&nbsp;&nbsp;城 市：</div>
    <div class="usercenterregistertableright">
       <asp:TextBox ID="txtChildLocation" runat="server" BorderColor="#999999" 
            BorderStyle="Solid" BorderWidth="1px" Height="24px" ></asp:TextBox>
        </div>
            <div class="usercenterregistertableleft">&nbsp;&nbsp;性 别：</div>
    <div class="usercenterregistertableright">
        
        <asp:RadioButtonList ID="rdoBtnSex" runat="server" BorderStyle="None" 
            RepeatColumns="2">
            <asp:ListItem Selected="True">男</asp:ListItem>
            <asp:ListItem>女</asp:ListItem>
        </asp:RadioButtonList>
        
        </div>
            <div class="usercenterregistertableleft">&nbsp;&nbsp;年 龄：</div>
    <div class="usercenterregistertableright">
        <asp:TextBox ID="txtAge" runat="server" BorderColor="#999999" 
            BorderStyle="Solid" BorderWidth="1px" Height="24px" Width="60px" Text="0"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
            ControlToValidate="txtAge" Display="Dynamic" 
            ErrorMessage="RegularExpressionValidator" ValidationExpression="^[0-9]*$">只能输入数字</asp:RegularExpressionValidator>
    </div>
            <div id="usercenterregistertableleft2">&nbsp;&nbsp;备 忘：</div>
    <div id="usercenterregistertableright2">
        <asp:TextBox ID="txtNote" runat="server" BorderColor="#999999" 
            BorderStyle="Solid" BorderWidth="1px" Height="50px" TextMode="MultiLine" 
            Width="270px"></asp:TextBox></div>
    <div id="usercenterregisterbottom" >
    <br />
        <asp:ImageButton ID="imgBtnSubmit" runat="server" 
            ImageUrl="~/Image/usercenter_submit.jpg" onclick="imgBtnSubmit_Click" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:ImageButton ID="imgBtnReturn" runat="server" 
            ImageUrl="~/Image/usercenter_cancel.jpg" 
            PostBackUrl="UserCenterDefault.aspx"/>&nbsp;<br />
    </div>
</div>
</asp:Content>

