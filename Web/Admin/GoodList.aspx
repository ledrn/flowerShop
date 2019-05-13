<%@ Page Title="网站后台-商品列表" Language="C#" MasterPageFile="~/Admin/AdminPage.master" AutoEventWireup="true" CodeFile="GoodList.aspx.cs" Inherits="Admin_GoodList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div style=" line-height:28px">
<br />
    <div id="adminsearchgood">
    商品名称：<asp:TextBox ID="txtName" runat="server" CssClass="admintextbox"></asp:TextBox>&nbsp;
    商品类型：<asp:DropDownList ID="ddlGoodType" runat="server">
            <asp:ListItem>-全部-</asp:ListItem>
            <asp:ListItem>鲜花</asp:ListItem>
            <asp:ListItem>果篮</asp:ListItem>
            <asp:ListItem>蛋糕</asp:ListItem>
            <asp:ListItem>巧克力</asp:ListItem>
        </asp:DropDownList>&nbsp;
    分类：<asp:DropDownList ID="ddlSpecial" runat="server">
            <asp:ListItem>-全部-</asp:ListItem>
            <asp:ListItem Value="0">普通商品</asp:ListItem>
            <asp:ListItem Value="1">附加商品</asp:ListItem>
            <asp:ListItem Value="2">配送方式</asp:ListItem>
        </asp:DropDownList>&nbsp;
      <asp:Button ID="btnSearch" runat="server" CssClass="adminbottonsearch" onclick="btnSearch_Click" /><br /><br />
  </div>
    <div>
        <asp:GridView ID="gdvData" runat="server" BorderStyle="None" BorderWidth="1px" CellPadding="4"
                DataKeyNames="ID" OnRowDeleting="gdvData_RowDeleting" Width="100%" 
                onrowdatabound="gdvData_RowDataBound" AutoGenerateColumns="False">
                <RowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="ID" HeaderText="编号" />
                    <asp:BoundField DataField="Name" HeaderText="商品名称" />
                    <asp:BoundField DataField="GoodType" HeaderText="商品类型" />
                    <asp:BoundField DataField="IsSpecial" HeaderText="分类" />
                    <asp:BoundField DataField="SellTime" HeaderText="销售次数" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button ID="btnDelete" runat="server" OnClientClick='return confirm("确实要删除吗?");'
                                CommandName="Delete" CssClass="adminbottondelete" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button ID="btnEdit" runat="server" CssClass="adminbottonedit" />
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
                转到:第<asp:TextBox ID="tbGogoPage" runat="server" CssClass="admintextbox"  Width="19px" OnTextChanged="tbGogoPage_TextChanged"></asp:TextBox>页
    </div>
</div>
</asp:Content>

