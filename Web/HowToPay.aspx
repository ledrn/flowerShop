<%@ Page Title="付款方式" Language="C#" MasterPageFile="~/Base.master" AutoEventWireup="true" CodeFile="HowToPay.aspx.cs" Inherits="HowToPay" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="howtopaytitle"></div>
    <div class="indextitleline"></div>
    <div id="howtopaytitleblank"></div>
    <div id="howtopaymain">
        <div id="howtopaymaintitle">支&nbsp;&nbsp;&nbsp;&nbsp;付&nbsp;&nbsp;&nbsp;&nbsp;方&nbsp;&nbsp;&nbsp;&nbsp;式</div>
        <div id="howtopaymaindatalist">
            <asp:DataList ID="DataListPayType" runat="server">
            <ItemTemplate>
                <div id="datalistpaytypeleft">&nbsp;&nbsp;<%# DataBinder.Eval(Container.DataItem,"Name") %></div>
                <div id="datalistpaytyperight">&nbsp;&nbsp;
                    <%# DataBinder.Eval(Container.DataItem,"PayContent") %></div>
            </ItemTemplate>
        </asp:DataList>
        </div>
    </div>
</asp:Content>

