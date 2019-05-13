<%@ Page Title="花言花语" Language="C#" MasterPageFile="~/Base.master" AutoEventWireup="true" CodeFile="NewInfo.aspx.cs" Inherits="NewInfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div id="newlisttitle">
    </div>
    <div id="goodinfotitleline">
    </div>
    <div id="newlistimgtop"></div>
    <div id="newbgmain">
    <div id="newlistimgleft">
        <div id="newlistimglefttop"></div>
        <div id="newlistimgleftmain"></div>
    </div>
    <div id="newlistmain">
        <div id="newlistmain_top"></div>
        <div id="newlistmain_datalist">
            <div id="newinfomaintitle">
                <asp:Label ID="lbltitle" runat="server" Text=""></asp:Label></div>
            <div id="newinfomainline"></div>
            <div id="newinfomaintime">
                发布时间：<asp:Label ID="lblTime" runat="server" Text=""></asp:Label>
            </div>
            <div id="newinfomaincontent">
            
                <asp:Label ID="lblContent" runat="server" Text="" Width="620px"></asp:Label>
            
            </div>
        </div>
    </div>
    <div id="newlistimgright">
        <div id="newlistimgrighttop"></div>    
        <div id="newlistimgrightmain"></div>
    </div>
    </div>
    <div id="newlistimgbottom"></div>
</asp:Content>

