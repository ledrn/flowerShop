<%@ Page Title="网站后台-修改商品信息" Language="C#" MasterPageFile="~/Admin/AdminPage.master" AutoEventWireup="true" CodeFile="EditGood.aspx.cs" Inherits="Admin_EditGood" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script language="javascript" type="text/javascript">
        function PreviewImg(imgFile) {
            var newPreview = document.getElementById("adminnewPreview");
            newPreview.filters.item("DXImageTransform.Microsoft.AlphaImageLoader").src = imgFile.value;
            newPreview.style.width = "160px";
            newPreview.style.height = "160px";
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div style=" width:430px; text-align:left; line-height:24px">
    <div style=" text-align:center">
    
        <asp:RadioButtonList ID="rblSpecial" runat="server" RepeatColumns="3">
            <asp:ListItem Selected="True" Value="0">普通商品</asp:ListItem>
            <asp:ListItem Value="1">附加商品</asp:ListItem>
            <asp:ListItem Value="2">配送方式</asp:ListItem>
        </asp:RadioButtonList></div>
      <p>  
      商品编号：&nbsp;&nbsp;<asp:Label ID="lblId" runat="server" Text=""></asp:Label><br />
        商品名称：&nbsp;&nbsp;<asp:TextBox ID="txtName" runat="server" 
              CssClass="admintextbox" Width="300px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorName" runat="server" 
            ErrorMessage="RequiredFieldValidator" Text="*" ControlToValidate="txtName"></asp:RequiredFieldValidator>
        <br />
        商品组成：&nbsp;&nbsp;<asp:TextBox ID="txtComponent" runat="server" 
              CssClass="admintextbox" Width="300px"></asp:TextBox><br />
        包装：&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="txtPackage" 
              runat="server" CssClass="admintextbox" Width="300px"></asp:TextBox><br />
        描述(花语)：<asp:TextBox ID="txtDescribe" runat="server" Height="80px" CssClass="admintextbox" 
            TextMode="MultiLine" Width="300px"></asp:TextBox><br />
        配送范围：&nbsp;&nbsp;<asp:TextBox ID="txtSendRange" runat="server" CssClass="admintextbox"  Width="300px"></asp:TextBox><br />
        价格：&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="txtPrice" 
              runat="server" CssClass="admintextbox" Width="80px">0</asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
            ControlToValidate="txtPrice" ErrorMessage="RegularExpressionValidator" 
            ValidationExpression="\d+">价格只能输入数字</asp:RegularExpressionValidator>
        <br />
        销售次数：&nbsp;&nbsp;<asp:TextBox ID="txtSellTime" runat="server" 
              CssClass="admintextbox" Width="80px"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
            ControlToValidate="txtSellTime" ErrorMessage="RegularExpressionValidator" 
            ValidationExpression="\d+">销售次数只能是数字</asp:RegularExpressionValidator>
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
        图片：&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:FileUpload ID="fileUploadPic" 
            runat="server" onchange="PreviewImg(this)" Width="200px" 
            BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" />&nbsp;
        <asp:Button ID="btnUploadImage" runat="server" CssClass="adminbottonupdatefile" 
            onclick="btnUploadImage_Click" /><br />
        图片地址：<asp:Label ID="lblImageURL" runat="server" Text=""></asp:Label><br />
    </p>
    <div id="adminnewPreview"></div>
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
            <asp:ListItem>菊花</asp:ListItem>
            <asp:ListItem>蓝色妖姬</asp:ListItem>
            <asp:ListItem>花篮</asp:ListItem>
            <asp:ListItem>花束</asp:ListItem>
            <asp:ListItem>瓶插花</asp:ListItem>
            <asp:ListItem>组合插花</asp:ListItem>
            <asp:ListItem>果篮</asp:ListItem>
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
        <asp:Button ID="btnSubmit" runat="server" CssClass="adminbottonupdate" onclick="btnSubmit_Click" />&nbsp;
        <asp:Button ID="btnReturn" runat="server" CssClass="adminbottonreturn" 
            PostBackUrl="GoodList.aspx" />
    </div>
</div>
</asp:Content>

