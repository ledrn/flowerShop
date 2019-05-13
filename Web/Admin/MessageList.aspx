<%@ Page Title="网站后台-短消息列表" Language="C#" MasterPageFile="~/Admin/AdminPage.master" AutoEventWireup="true" CodeFile="MessageList.aspx.cs" Inherits="Admin_MessageList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div style=" line-height:28px;">
<br />
    <div id="adminsearchmessage">
    发消息人：<asp:TextBox ID="txtFromUser" runat="server" CssClass="admintextbox" 
            Width="120px"></asp:TextBox>&nbsp;
      <asp:Button ID="btnSearch" runat="server" CssClass="adminbottonsearch" onclick="btnSearch_Click" /><br /><br />
  </div>
    <div>
        <asp:GridView ID="gdvData" runat="server" BorderStyle="None" BorderWidth="1px" CellPadding="4"
                DataKeyNames="ID" OnRowDeleting="gdvData_RowDeleting" Width="100%" 
                onrowdatabound="gdvData_RowDataBound" AutoGenerateColumns="False">
                <RowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="ID" HeaderText="编号" />
                    <asp:BoundField DataField="Title" HeaderText="标题" />
                    <asp:BoundField DataField="FromUser" HeaderText="发消息人" />
                    <asp:BoundField DataField="IsNew" HeaderText="阅读状态" />
                    <asp:BoundField DataField="WriteTime" DataFormatString="{0:d}" 
                        HeaderText="发消息时间" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button ID="btnDelete" runat="server" OnClientClick='return confirm("确实要删除吗?");'
                                CommandName="Delete" CssClass="adminbottondelete" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button ID="btnEdit" runat="server" CssClass="adminbottonread" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    
                </Columns>
            </asp:GridView>
    </div>
    <div>
        <asp:LinkButton ID="lbtnFirstpage" runat="server" CommandName="0" OnCommand="Page_OnClick" target="_self">首页</asp:LinkButton>
                <asp:LinkButton ID="lbtnPrevpage" runat="server"  CommandName="prev" OnCommand="Page_OnClick" target="_self">上一页</asp:LinkButton>
                <asp:LinkButton ID="lbtnNextpage" runat="server"  CommandName="next" OnCommand="Page_OnClick" target="_self">下一页</asp:LinkButton>
                <asp:LinkButton ID="lbtnLastpage" runat="server"  CommandName="last" OnCommand="Page_OnClick" target="_self">尾页</asp:LinkButton>
                第<asp:Label ID="lbCurrentPage" runat="server" ></asp:Label>页/共<asp:Label ID="lbPageCount" runat="server" ></asp:Label>页
                转到:第<asp:TextBox ID="tbGogoPage" runat="server" CssClass="admintextbox" Width="19px" OnTextChanged="tbGogoPage_TextChanged"></asp:TextBox>页
    </div>
</div>
</asp:Content>

