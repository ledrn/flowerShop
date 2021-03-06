﻿<%@ Page Language="C#" MasterPageFile="~/Admin/AdminPage.master" AutoEventWireup="true" CodeFile="ViewGood.aspx.cs" Inherits="Admin_ViewGood" Title="网站后台-查看商品信息" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div style=" width:430px; text-align:left; line-height:24px">
    <div style=" text-align:center">
        <asp:RadioButtonList ID="rblSpecial" runat="server" RepeatColumns="3">
            <asp:ListItem Selected="True" Value="0">普通商品</asp:ListItem>
            <asp:ListItem Value="1">附加商品</asp:ListItem>
            <asp:ListItem Value="2">配送方式</asp:ListItem>
        </asp:RadioButtonList><br />
     </div>
     <p> 
       商品编号：&nbsp;&nbsp;<asp:Label ID="lblId" runat="server" Text=""></asp:Label><br />
        商品名称：&nbsp;&nbsp;<asp:Label ID="lblName" runat="server" Text=""></asp:Label>
        <br />
        商品组成：&nbsp;&nbsp;<asp:Label ID="lblComponent" runat="server" Text=""></asp:Label><br />
        包装：&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lblPackage" runat="server" Text=""></asp:Label><br />
        描述(花语)：<asp:TextBox ID="txtDescribe" runat="server" Height="80px" CssClass="admintextbox" 
            TextMode="MultiLine" Width="300px"></asp:TextBox><br />
        配送范围：&nbsp;&nbsp;<asp:Label ID="lblSendRange" runat="server" Text=""></asp:Label><br />
        价格：&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="txtPrice"  CssClass="admintextbox"
             runat="server" Width="80px">0</asp:TextBox>
        <br />
        销售次数：&nbsp;&nbsp;<asp:TextBox ID="txtSellTime" runat="server" Width="80px" CssClass="admintextbox"></asp:TextBox>
        <br />
    </p>
    <p>
        商品类型：&nbsp;&nbsp;<asp:DropDownList ID="ddlGoodType" runat="server">
            <asp:ListItem>鲜花</asp:ListItem>
            <asp:ListItem>果篮</asp:ListItem>
            <asp:ListItem>蛋糕</asp:ListItem>
            <asp:ListItem>巧克力</asp:ListItem>
        </asp:DropDownList><br />
    </p>
    <p>
        
        图片：&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Image ID="imgPic" runat="server" BorderColor="Blue" BorderWidth="1px" Height="160px" Width="160px"/>
            <br />
    </p>
    <p>
        节日类型： <asp:CheckBoxList ID="cblFestivalType" runat="server" RepeatColumns="7">
            <asp:ListItem>元旦</asp:ListItem>
            <asp:ListItem>春节</asp:ListItem>
            <asp:ListItem>国庆节</asp:ListItem>
            <asp:ListItem>情人节</asp:ListItem>
            <asp:ListItem>妇女节</asp:ListItem>
            <asp:ListItem>母亲节</asp:ListItem>
            <asp:ListItem>父亲节</asp:ListItem>
            <asp:ListItem>七夕节</asp:ListItem>
            <asp:ListItem>中秋节</asp:ListItem>
            <asp:ListItem>教师节</asp:ListItem>
            <asp:ListItem>圣诞节</asp:ListItem>
            <asp:ListItem>感恩节</asp:ListItem>
            <asp:ListItem>儿童节</asp:ListItem>
            <asp:ListItem>清明节</asp:ListItem>
    </asp:CheckBoxList><br />
    </p>
    <p>
        用途类型：<asp:CheckBoxList ID="cblUseType" runat="server" RepeatColumns="6">
            <asp:ListItem>生日送花</asp:ListItem>
            <asp:ListItem>道歉用花</asp:ListItem>
            <asp:ListItem>爱情鲜花</asp:ListItem>
            <asp:ListItem>慰问送花</asp:ListItem>
            <asp:ListItem>友情送花</asp:ListItem>
            <asp:ListItem>祝贺送花</asp:ListItem>
            <asp:ListItem>婚庆用花</asp:ListItem>
            <asp:ListItem>庆典花篮</asp:ListItem>
            <asp:ListItem>商务用花</asp:ListItem>
            <asp:ListItem>祭奠鲜花</asp:ListItem>
            <asp:ListItem>会场布置</asp:ListItem>
            <asp:ListItem>乔迁之喜</asp:ListItem>
    </asp:CheckBoxList><br />
    </p>
    <p>
        花材类型：<asp:CheckBoxList ID="cblFlowerMaterial" runat="server" RepeatColumns="6">
            <asp:ListItem>玫瑰花</asp:ListItem>
            <asp:ListItem>百合花</asp:ListItem>
            <asp:ListItem>康乃馨</asp:ListItem>
            <asp:ListItem>郁金香</asp:ListItem>
            <asp:ListItem>扶郎花</asp:ListItem>
            <asp:ListItem>马蹄莲</asp:ListItem>
            <asp:ListItem>绿美人</asp:ListItem>
            <asp:ListItem>菊　花</asp:ListItem>
            <asp:ListItem>蓝色妖姬</asp:ListItem>
            <asp:ListItem>花　篮</asp:ListItem>
            <asp:ListItem>花　束</asp:ListItem>
            <asp:ListItem>瓶插花</asp:ListItem>
            <asp:ListItem>组合插花</asp:ListItem>
            <asp:ListItem>果　篮</asp:ListItem>
    </asp:CheckBoxList><br />
    </p>
    <p>
        玫瑰类型：<asp:CheckBoxList ID="cblRoseType" runat="server" RepeatColumns="6">
            <asp:ListItem>999朵玫瑰</asp:ListItem>
            <asp:ListItem>99朵玫瑰</asp:ListItem>
            <asp:ListItem>66朵玫瑰</asp:ListItem>
            <asp:ListItem>57朵玫瑰</asp:ListItem>
            <asp:ListItem>33朵玫瑰</asp:ListItem>
            <asp:ListItem>19朵玫瑰 </asp:ListItem>
            <asp:ListItem>11朵玫瑰</asp:ListItem>
            <asp:ListItem>9支玫瑰</asp:ListItem>
    </asp:CheckBoxList><br />
    </p>
    <p>
        送人类型：<asp:CheckBoxList ID="cblSendPerson" runat="server" RepeatColumns="8">
            <asp:ListItem>恋人</asp:ListItem>
            <asp:ListItem>父母</asp:ListItem>
            <asp:ListItem>朋友</asp:ListItem>
            <asp:ListItem>同事</asp:ListItem>
            <asp:ListItem>病人</asp:ListItem>
            <asp:ListItem>老师</asp:ListItem>
            <asp:ListItem>客户</asp:ListItem>
            <asp:ListItem>婴幼儿</asp:ListItem>
    </asp:CheckBoxList><br />
    </p>
    <div style=" text-align:center">
        <asp:Button ID="btnReturn" runat="server" CssClass="adminbottonreturn" onclick="btnReturn_Click" />
    </div>
</div>
</asp:Content>


