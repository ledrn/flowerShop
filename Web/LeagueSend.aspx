<%@ Page Title="加盟配送" Language="C#" MasterPageFile="~/Base.master" AutoEventWireup="true" CodeFile="LeagueSend.aspx.cs" Inherits="LeagueSend" EnableEventValidation="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="leaguetitle"></div>
    <div class="indextitleline"></div>
    <div id="leaguesendtitlename">配送店（免费加入）申请表按此格式发送邮件致：XXXXXX@qq.com</div>
    <div id="leaguesendtable">
        <div id="leaguesendtabletitle">加  盟  申  请  表</div>
        <div class="leaguesendtableleft">&nbsp;&nbsp;您的花店名称：</div>
        <div class="leaguesendtableright">
            &nbsp;&nbsp;<asp:TextBox ID="txtTitle" runat="server" Height="24px" Width="400px" 
                BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                ControlToValidate="txtTitle" ErrorMessage="RequiredFieldValidator">*</asp:RequiredFieldValidator>
        </div>
        <div class="leaguesendtableleft">&nbsp;&nbsp;花店所在地区：</div>
        <div class="leaguesendtableright">
            &nbsp;&nbsp;<asp:TextBox ID="txtLocation" runat="server" 
                BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" Height="24px" ></asp:TextBox>
        </div>
        <div class="leaguesendtableleft">&nbsp;&nbsp;花店负责人姓名：</div>
        <div class="leaguesendtableright">
            &nbsp;&nbsp;<asp:TextBox ID="txtName" runat="server" Height="24px" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                ControlToValidate="txtName" ErrorMessage="RequiredFieldValidator">*</asp:RequiredFieldValidator>
        </div>
        <div class="leaguesendtableleft">&nbsp;&nbsp;详细地址：</div>
        <div class="leaguesendtableright">
            &nbsp;&nbsp;<asp:TextBox ID="txtAddress" runat="server" Height="24px" Width="400px" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                ControlToValidate="txtAddress" ErrorMessage="RequiredFieldValidator">*</asp:RequiredFieldValidator>
        </div>
        <div class="leaguesendtableleft">&nbsp;&nbsp;电话：</div>
        <div class="leaguesendtableright">
            &nbsp;&nbsp;<asp:TextBox ID="txtPhone" runat="server" Height="24px" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                ControlToValidate="txtPhone" ErrorMessage="RequiredFieldValidator">*</asp:RequiredFieldValidator>
        </div>
        <div class="leaguesendtableleft">&nbsp;&nbsp;手机：</div>
        <div class="leaguesendtableright">
            &nbsp;&nbsp;<asp:TextBox ID="txtMobilePhone" runat="server" Height="24px" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px"></asp:TextBox>
        </div>
        <div class="leaguesendtableleft">&nbsp;&nbsp;传真：</div>
        <div class="leaguesendtableright">
            &nbsp;&nbsp;<asp:TextBox ID="txtFax" runat="server" Height="24px" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px"></asp:TextBox>
        </div>
         <div class="leaguesendtableleft">&nbsp;&nbsp;电子邮件（Email）：</div>
        <div class="leaguesendtableright">
            &nbsp;&nbsp;<asp:TextBox ID="txtEmail" runat="server" Height="24px" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px"></asp:TextBox>
        </div>
         <div class="leaguesendtableleft">&nbsp;&nbsp;QQ/MSN号：</div>
        <div class="leaguesendtableright">
            &nbsp;&nbsp;<asp:TextBox ID="txtQQ" runat="server" Height="24px" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px"></asp:TextBox>
        </div>
        <div class="leaguesendtableleft">&nbsp;&nbsp;开户行：</div>
        <div class="leaguesendtableright">
            &nbsp;&nbsp;<asp:TextBox ID="txtBank" runat="server" Height="24px" Width="400px" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px"></asp:TextBox>
        </div>
        <div class="leaguesendtableleft">&nbsp;&nbsp;账号：</div>
        <div class="leaguesendtableright">
            &nbsp;&nbsp;<asp:TextBox ID="txtAccountNumber" runat="server" Height="24px" Width="400px" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px"></asp:TextBox>
        </div>
        <div class="leaguesendtableleft">&nbsp;&nbsp;收款人姓名：</div>
        <div class="leaguesendtableright">
            &nbsp;&nbsp;<asp:TextBox ID="txtPayee" runat="server" Height="24px" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px"></asp:TextBox>
        </div>
        <div class="leaguesendtableleft">&nbsp;&nbsp;配送区域：</div>
        <div class="leaguesendtableright">
            &nbsp;&nbsp;<asp:TextBox ID="txtSendArea" runat="server" Height="24px" Width="400px" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px"></asp:TextBox>
        </div>
        <div id="leaguesendtableleft2">&nbsp;&nbsp;花店简介：</div>
        <div id="leaguesendtableright2">
            &nbsp;&nbsp;<asp:TextBox ID="txtShopSummary" runat="server" Height="130px" 
                TextMode="MultiLine" Width="417px" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px"></asp:TextBox>
        </div>
        <div id="leaguesendtablebottom">
            <asp:ImageButton ID="imgBtnSubmit" runat="server" 
                ImageUrl="~/Image/league_submit.jpg" onclick="imgBtnSubmit_Click" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            
        </div>
    </div>
</asp:Content>

