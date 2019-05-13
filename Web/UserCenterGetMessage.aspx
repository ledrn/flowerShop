<%@ Page Title="会员中心-商城短信" Language="C#" MasterPageFile="~/Base.master" AutoEventWireup="true" CodeFile="UserCenterGetMessage.aspx.cs" Inherits="UserCenterGetMessage" %>
<%@ Register src="UserCenterLeft.ascx" tagname="UserCenterLeft" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div id="usercentertitle"></div>
<div class="indextitleline"></div>
<div id="usercentertitleblank"></div>
<div id="usercenterleft">
    
    <uc1:UserCenterLeft ID="UserCenterLeft1" runat="server" />
    
   </div>
   <div id="usercentergetmessage">
    <div id="usercentergetmessagetitle">以下是您的商城短信：</div>
    <div id="usercentergetmessagemain">
        <asp:GridView ID="gdvData" runat="server" BorderStyle="None" BorderWidth="1px" CellPadding="4"
                DataKeyNames="ID" OnRowDeleting="gdvData_RowDeleting" Width="488px" 
            AutoGenerateColumns="False">
                <RowStyle BackColor="White" />
                <Columns>
                    <asp:TemplateField ShowHeader="False">
                        <ItemTemplate>
                        <div id="datalistgetmessagetitleleft">&nbsp;短信标题：</div>
                <div id="datalistgetmessagetitleright">
                    <asp:Label Width="400px" ID="lblTitle" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "Title")%>'></asp:Label>
                </div>
                <div id="datalistgetmessagemainleft">&nbsp;短信内容：</div>
                <div id="datalistgetmessagemainright">
                    <asp:Label Width="400px" ID="lblMessage" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "Message")%>'></asp:Label>
                    </div>
                    <div id="datalistgetmessagetimeleft">&nbsp;短信时间：</div>
                <div id="datalistgetmessagetimeright">
                    <asp:Label Width="348px" ID="lblTime" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "WriteTime")%>'></asp:Label>
                    <asp:ImageButton ID="imgBtnDelete" runat="server" OnClientClick='return confirm("确实要删除此消息吗?");' CommandName="Delete" 
                        ImageUrl="Image/usercenter_message_delete.gif" />
                </div>
                    <div id="datalistgetmessagemainblank">
                        <asp:Label ID="lblID" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "ID")%>' Visible="False"></asp:Label></div>
                        </ItemTemplate>
                        <HeaderStyle BorderStyle="None" />
                        <ItemStyle BorderStyle="None" />
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
    </div>
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
   </div>
</asp:Content>

