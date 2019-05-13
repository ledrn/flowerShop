<%@ Page Title="订单答疑" Language="C#" MasterPageFile="~/Base.master" AutoEventWireup="true" CodeFile="OrderQA.aspx.cs" Inherits="OrderQA" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div id="orderqatitle"></div>
    <div class="indextitleline"></div>
    <div id="orderqatitlename">订单答疑：</div>
    <div id="orderqamain">
        <asp:DataList ID="DataListOrderQA" runat="server" CellSpacing="4">
            <ItemTemplate>
                <div id="datalistleagueqatitle">&nbsp;&nbsp;Q：<%# DataBinder.Eval(Container.DataItem, "Question")%></div>
                <div id="datalistleagueqamain">
                    <%# DataBinder.Eval(Container.DataItem, "Answer")%></div>
            </ItemTemplate>
        </asp:DataList>
    </div>
    <div id="leagueqablank"></div>
    <div id="leagueqalinkpage">
        <asp:LinkButton ID="lbtnFirstpage" runat="server" CommandName="0" 
            OnCommand="Page_OnClick" target="_self" ForeColor="#752795">首页</asp:LinkButton>
                <asp:LinkButton ID="lbtnPrevpage" runat="server"  CommandName="prev" 
            OnCommand="Page_OnClick" target="_self" ForeColor="#752795">上一页</asp:LinkButton>
                <asp:LinkButton ID="lbtnNextpage" runat="server"  CommandName="next" 
            OnCommand="Page_OnClick" target="_self" ForeColor="#752795">下一页</asp:LinkButton>
                <asp:LinkButton ID="lbtnLastpage" runat="server"  CommandName="last" 
            OnCommand="Page_OnClick" target="_self" ForeColor="#752795">尾页</asp:LinkButton>
                第<asp:Label ID="lbCurrentPage" runat="server" ></asp:Label>页/共<asp:Label ID="lbPageCount" runat="server" ></asp:Label>页
                转到:第<asp:TextBox ID="tbGogoPage" runat="server"  Width="19px" 
            OnTextChanged="tbGogoPage_TextChanged" BorderColor="#752795" 
            BorderStyle="Solid" BorderWidth="1px"></asp:TextBox>页
    </div>
</asp:Content>

