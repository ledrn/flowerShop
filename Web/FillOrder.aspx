<%@ Page Title="订单信息-填写详细信息" Language="C#" MasterPageFile="~/Base.master" AutoEventWireup="true" CodeFile="FillOrder.aspx.cs" Inherits="FillOrder" EnableEventValidation="false"%>
<%@ Register assembly="DBUtility" namespace="RightWork" tagprefix="cc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div id="orderlisttitle"></div>
<div class="indextitleline"></div>
<div id="orderlistflow2"></div>
<div id="fillordertitle">请详细填写您的资料，以便我们更好的为您服务！</div>
<div id="fillorderbuytable">
    <div class="fillorderbuytabletitle">请填写购买人的详细资料</div>
    <div class="fillorderbuytableleft">
        &nbsp; &nbsp;<span style="color:Red">*</span>姓  名：<asp:TextBox 
            ID="txtBuyerName" runat="server" 
            BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" Width="150px" 
            Height="22px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ErrorMessage="RequiredFieldValidator" ControlToValidate="txtBuyerName">*</asp:RequiredFieldValidator>
    </div>
    <div class="fillorderbuytableright">
        &nbsp; &nbsp;<span style="color:Red">*</span>电  话：<asp:TextBox 
            ID="txtBuyerPhone" runat="server" 
            BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" Width="150px" 
            Height="22px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
            ErrorMessage="RequiredFieldValidator" ControlToValidate="txtBuyerPhone">*</asp:RequiredFieldValidator>
    </div>
    <div class="fillorderbuytableleft">
        &nbsp; &nbsp;QQ 号：&nbsp;<asp:TextBox ID="txtBuyerQQ" runat="server" 
            BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" Width="150px" 
            Height="22px"></asp:TextBox>
    </div>
    <div class="fillorderbuytableright">
        &nbsp; &nbsp;手  机：&nbsp;&nbsp;<asp:TextBox ID="txtBuyerMobilePhone" runat="server" 
            BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" Width="150px" 
            Height="22px"></asp:TextBox>
    </div>
    <div class="fillorderbuytablebottom">
    &nbsp; &nbsp;E-mail：&nbsp;<asp:TextBox ID="txtBuyerEmail" runat="server" 
            BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" Width="150px" 
            Height="22px"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
            Display="Dynamic" ErrorMessage="RegularExpressionValidator" 
            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
            ControlToValidate="txtBuyerEmail">Email格式不正确</asp:RegularExpressionValidator>
    </div>
    <div class="fillorderbuytablebottom">
    &nbsp; &nbsp;<span style="color:Red">*</span>地  址：<asp:TextBox ID="txtBuyerAddress" runat="server" 
            BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" Width="475px" 
            Height="22px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
            ControlToValidate="txtBuyerAddress" ErrorMessage="RequiredFieldValidator">*</asp:RequiredFieldValidator>
    </div>
    <div class="fillorderbuytableblank"></div>
    <div class="fillorderbuytabletitle">请填写收货人的详细资料</div>
    <div class="fillorderbuytableleft">
        &nbsp; &nbsp;<span style="color:Red">*</span>姓  名：<asp:TextBox 
            ID="txtConsigneeName" runat="server" 
            BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" Width="150px" 
            Height="22px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
            ErrorMessage="RequiredFieldValidator" ControlToValidate="txtConsigneeName">*</asp:RequiredFieldValidator>
    </div>
    <div class="fillorderbuytableright">
        &nbsp; &nbsp;<span style="color:Red">*</span>电  话：<asp:TextBox 
            ID="txtConsigneePhone" runat="server" 
            BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" Width="150px" 
            Height="22px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
            ErrorMessage="RequiredFieldValidator" ControlToValidate="txtConsigneePhone">*</asp:RequiredFieldValidator>
    </div>
    <div class="fillorderbuytableleft">
        &nbsp; &nbsp;QQ 号：&nbsp;<asp:TextBox ID="txtConsigneeQQ" runat="server" 
            BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" Width="150px" 
            Height="22px"></asp:TextBox>
    </div>
    <div class="fillorderbuytableright">
        &nbsp; &nbsp;手  机：&nbsp;&nbsp;<asp:TextBox ID="txtConsigneeMobilePhone" runat="server" 
            BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" Width="150px" 
            Height="22px"></asp:TextBox>
    </div>
    <div class="fillorderbuytablebottom">
    &nbsp; &nbsp;E-mail：&nbsp;<asp:TextBox ID="txtConsigneeEmail" runat="server" 
            BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" Width="150px" 
            Height="22px"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
            Display="Dynamic" ErrorMessage="RegularExpressionValidator" 
            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
            ControlToValidate="txtConsigneeEmail">Email格式不正确</asp:RegularExpressionValidator>
    </div>
    <div class="fillorderbuytablebottom">
        &nbsp; &nbsp;地 区：&nbsp;&nbsp;<asp:TextBox ID="txtLocation" runat="server" 
            BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" Height="24px" 
            Width="150px" ></asp:TextBox>
            </div>
     <div class="fillorderbuytablebottom">
    &nbsp; &nbsp;<span style="color:Red">*</span>地  址：<asp:TextBox ID="txtConsigneeAddress" runat="server" 
            BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" Width="475px" 
            Height="22px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
            ControlToValidate="txtConsigneeAddress" ErrorMessage="RequiredFieldValidator">*</asp:RequiredFieldValidator>
     </div>
     <div class="fillorderbuytableblank"></div>
    <div id="fillordersendtype">
         &nbsp; &nbsp;配送方式：&nbsp; &nbsp;<asp:DropDownList ID="ddlSendType" runat="server">
         </asp:DropDownList>
    </div>
    <div id="fillorderpaytypeleft">&nbsp; &nbsp;&nbsp;支付方式：</div>
    <div id="fillorderpaytyperight">
        <asp:RadioButtonList ID="rdoBtnListPayType" runat="server">
            <asp:ListItem Value="网上支付" Selected="True">网上支付(国内信用卡、银行卡在线付款)</asp:ListItem>
            <asp:ListItem Value="银行转帐">银行转帐(请您银行转账后务必与我们联系确认)</asp:ListItem>
            <asp:ListItem Value="邮局汇款">邮局汇款(如果您送货的时间很急，请把邮局汇款凭证传真给我们，传真：0311-*********，注明订单号)</asp:ListItem>
            <asp:ListItem Value="上门收款">上门收款(加收费用10元，远郊加收30元)</asp:ListItem>
            <asp:ListItem Value="其它方式">其它方式(请您尽快同我们联系，进行沟通后以确认具体的付款方式)</asp:ListItem>
    </asp:RadioButtonList>
    </div>
    <div id="fillordersendtime">
        &nbsp; &nbsp;配送日期：&nbsp; &nbsp;
        <cc2:Calendar ID="Calendar1" runat="server"></cc2:Calendar>
    </div>
    <div id="fillordersendperiodtime">
        &nbsp; &nbsp;送货时段：
        <asp:RadioButtonList ID="rdoBtnSendperiodTime" runat="server" RepeatColumns="4" 
            CellPadding="4" CellSpacing="4" RepeatDirection="Horizontal" 
            RepeatLayout="Flow">
            <asp:ListItem Selected="True">随时都可以</asp:ListItem>
            <asp:ListItem>上午9-12点</asp:ListItem>
            <asp:ListItem>下午12-17点</asp:ListItem>
            <asp:ListItem>晚上17-21点</asp:ListItem>
        </asp:RadioButtonList>
    </div>
    <div class="fillorderbuytableblank"></div>
    <div id="fillorderspecialorderleft">&nbsp; &nbsp;&nbsp; &nbsp;您对商品的配送、我们的服务各方面有什么要求，都可以在这里提出来！我们会尽我们最大努力满足您的要求！</div>
    <div id="fillorderspecialorderright">
        &nbsp;
        <asp:TextBox ID="txtSpecialOrder" runat="server" TextMode="MultiLine" 
            BorderColor="#999999" BorderWidth="1px" BorderStyle="Solid" Height="96px" 
            Width="338px"></asp:TextBox>
    
    </div>
    <div class="fillorderbuytableblank"></div>
    <div id="fillordermessageleft"><br />&nbsp;&nbsp;给收货人留言：<br />
    &nbsp;&nbsp;（卡片信息）
    </div>
    <div id="fillordermessageright">
        &nbsp;
        <asp:TextBox ID="txtMessage" runat="server" TextMode="MultiLine" 
            BorderColor="#999999" BorderWidth="1px" BorderStyle="Solid" Height="96px" 
            Width="428px"></asp:TextBox>
    </div>
    <div id="fillorderpennameleft">&nbsp;&nbsp;购买人署名：
    </div>
    <div id="fillorderpennameright">
    
        <asp:RadioButtonList ID="rdoBtnPenName" runat="server" CellPadding="4" 
            CellSpacing="4" RepeatDirection="Horizontal" RepeatLayout="Flow">
            <asp:ListItem Value="匿名" Selected="True">不，我想保密</asp:ListItem>
            <asp:ListItem>署名</asp:ListItem>
        </asp:RadioButtonList>
        &nbsp;<asp:TextBox ID="txtPenName" runat="server" BorderColor="#999999" 
            BorderStyle="Solid" BorderWidth="1px"></asp:TextBox>
    </div>
    <div class="fillorderbuytableblank"></div>
</div>
<div id="fillorderbutton">
<asp:ImageButton ID="imgBtnFront" runat="server" PostBackUrl="OrderList.aspx" 
        ImageUrl="~/Image/fillorder_front.jpg" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:ImageButton ID="imgBtnNext" runat="server" 
        ImageUrl="~/Image/fillorder_next.jpg" onclick="imgBtnNext_Click" />
</div>
    
    
</asp:Content>

