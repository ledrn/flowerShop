<%@ Page Title="网站后台-添加友情链接" Language="C#" MasterPageFile="~/Admin/AdminPage.master" AutoEventWireup="true" CodeFile="AddFriendLink.aspx.cs" Inherits="Admin_AddFriendLink" %>

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
<div style=" width:400px; text-align:left; line-height:20px;">
<br /><br />
    <p>
        名称：&nbsp;&nbsp;&nbsp;<asp:TextBox ID="txtName" runat="server" 
            CssClass="admintextbox" Width="300px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorName" runat="server" 
            ControlToValidate="txtName" ErrorMessage="RequiredFieldValidator">*</asp:RequiredFieldValidator>
        <br />
        URL地址：<asp:TextBox ID="txtURL" runat="server" CssClass="admintextbox" 
            Width="300px">Http://</asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorURL" runat="server" 
            ControlToValidate="txtURL" ErrorMessage="RequiredFieldValidator">*</asp:RequiredFieldValidator>
        <br />
        图片：&nbsp;&nbsp;&nbsp;<asp:FileUpload ID="fileUploadPic" runat="server" 
            onchange="PreviewImg(this)" BorderColor="#999999" BorderStyle="Solid" 
            BorderWidth="1px" Width="240px" />
        &nbsp;&nbsp;<asp:Button ID="btnUploadImage" runat="server" CssClass="adminbottonupdatefile" 
            onclick="btnUploadImage_Click" /><br />
        图片地址：<asp:Label ID="lblImageURL" runat="server" Text=""></asp:Label>
    </p>
    <div id="adminnewPreview"></div><br />
    <div style=" text-align:center">
        <asp:Button ID="btnSubmit" runat="server" CssClass="adminbottonadd" onclick="btnSubmit_Click" />
    </div>
</div>
</asp:Content>

