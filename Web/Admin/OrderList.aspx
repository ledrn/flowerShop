<%@ Page Title="网站后台-订单列表" Language="C#" MasterPageFile="~/Admin/AdminPage.master" AutoEventWireup="true" CodeFile="OrderList.aspx.cs" Inherits="Admin_OrderList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div style=" line-height:28px">
<br />
    <div id="adminsearchgood">
    订单编号：<asp:TextBox ID="txtOrderId" runat="server" CssClass="admintextbox"></asp:TextBox>&nbsp;
    订单状态：<asp:DropDownList ID="ddlOrderState" runat="server">
            <asp:ListItem>-全部-</asp:ListItem>
            <asp:ListItem Value="0待处理">待处理</asp:ListItem>
            <asp:ListItem Value="1受理中">受理中</asp:ListItem>
            <asp:ListItem Value="2已完成">已完成</asp:ListItem>
            <asp:ListItem Value="3失效">失效</asp:ListItem>
            <asp:ListItem Value="4取消">取消</asp:ListItem>

        </asp:DropDownList>&nbsp;
         <asp:Button ID="btnSearch" runat="server" CssClass="adminbottonsearch" onclick="btnSearch_Click" /><br /><br />
  </div>
    <div>
        <asp:GridView ID="gdvData" runat="server" BorderStyle="None" BorderWidth="1px" CellPadding="4"
                DataKeyNames="ID" OnRowDeleting="gdvData_RowDeleting" Width="100%" 
                onrowdatabound="gdvData_RowDataBound" AutoGenerateColumns="False">
                <RowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="ID" HeaderText="订单编号" />
                    <asp:BoundField DataField="OrderState" HeaderText="订单状态" />
                    <asp:BoundField DataField="OrderTime" DataFormatString="{0:d}" 
                        HeaderText="订单时间" />
                   <asp:BoundField DataField="SendTime" DataFormatString="{0:d}" 
                        HeaderText="配送时间" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button ID="btnDelete" runat="server" OnClientClick='return confirm("确实要删除吗?");'
                                CommandName="Delete" CssClass="adminbottondelete" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button ID="btnEdit" runat="server" CssClass="adminbottonview" />
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

