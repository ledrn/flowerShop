<%@ Page Title="网站后台-修改友情链接" Language="C#" MasterPageFile="~/Admin/AdminPage.master" AutoEventWireup="true" CodeFile="EditFriendLink.aspx.cs" Inherits="Admin_EditFriendLink" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script language="javascript" type="text/javascript">
        function PreviewImg(imgFile) {
            var newPreview = document.getElementById("adminnewPreview");
            newPreview.filters.item("DXImageTransform.Microsoft.AlphaImageLoader").src = imgFile.value;
            newPreview.style.width = "160px";
            newPreview.style.height = "50px";
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div style=" text-align:left; width:400px; line-height:28px">
<br />
    <p>
        编号：&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lblId" runat="server" Text=""></asp:Label><br />
        名称：&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="txtName" runat="server" CssClass="admintextbox" 
            Width="200px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorName" runat="server" 
            ControlToValidate="txtName" ErrorMessage="RequiredFieldValidator">*</asp:RequiredFieldValidator>
        <br />
        URL地址：&nbsp;<asp:TextBox ID="txtURL" runat="server" Width="200px" CssClass="admintextbox">Http://</asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorURL" runat="server" 
            ControlToValidate="txtURL" ErrorMessage="RequiredFieldValidator">*</asp:RequiredFieldValidator>
        <br />
        图片地址：<asp:Label ID="lblImageURL" runat="server" Text=""></asp:Label><br />
        图片：&nbsp;&nbsp;&nbsp;&nbsp;<asp:FileUpload ID="fileUploadPic" runat="server" 
            onchange="PreviewImg(this)" Width="200px" BorderColor="#999999" 
            BorderStyle="Solid" BorderWidth="1px" />&nbsp;
        <asp:Button ID="btnUploadImage" runat="server" CssClass="adminbottonupdatefile" 
            onclick="btnUploadImage_Click" /><br />
    </p>
    <div id="adminnewPreview"></div><br />
    <div style=" text-align:center">
        <asp:Button ID="btnSubmit" runat="server" CssClass="adminbottonupdate" onclick="btnSubmit_Click" />&nbsp;
        <asp:Button ID="btnReturn" runat="server" CssClass="adminbottonreturn" PostBackUrl="FriendLinkList.aspx" />
    </div>   
</div>
</asp:Content>