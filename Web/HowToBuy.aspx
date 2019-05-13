<%@ Page Title="购买流程" Language="C#" MasterPageFile="~/Base.master" AutoEventWireup="true" CodeFile="HowToBuy.aspx.cs" Inherits="HowToBuy" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="howtobuytitle"></div>
<div class="indextitleline"></div>
<div id="howtobuyblank"></div>
<div id="howtobuystep1">
    <div class="howtobuysteptitle">&nbsp;&nbsp;第一步：选择商品加入购物篮</div>
    <div id="howtobuystep1main">
        <asp:Image ID="Image1" runat="server" ImageUrl="~/Image/howtobuy_step1.jpg" 
            Width="620px" />
    </div>
    
</div>
<div id="howtobuystep2">
    <div class="howtobuysteptitle">&nbsp;&nbsp;第二步：显示购物清单，计算商品价格</div>
    <div id="howtobuystep2main">
        <asp:Image ID="Image2" runat="server" ImageUrl="~/Image/howtobuy_step2.jpg" 
            Width="620px" />
    </div>
</div>
<div id="howtobuystep3">
    <div class="howtobuysteptitle">
        &nbsp;&nbsp;第三步：填写购物详细信息
    </div>
    <div id="howtobuystep3main">
    <asp:Image ID="Image3" runat="server" ImageUrl="~/Image/howtobuy_step3.jpg" 
            Width="620px" />
    </div>
</div>
<div id="howtobuystep4">
    <div class="howtobuysteptitle">
        &nbsp;&nbsp;第四步：生成订单号
    </div>
    <div id="howtobuystep4main">
    <asp:Image ID="Image4" runat="server" ImageUrl="~/Image/howtobuy_step4.jpg" 
            Width="620px" />
    </div>
</div>
</asp:Content>

