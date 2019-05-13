<%@ Page Title="巧克力" Language="C#" MasterPageFile="~/MainPage.master" AutoEventWireup="true" CodeFile="ChocolateList.aspx.cs" Inherits="ChocolateList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div id="chocolatelisttitle"></div>
<div class="indextitleline">
    </div>
    <div id="flowermain">
    <asp:DataList ID="DataListFlower" runat="server" RepeatColumns="3" 
            onitemdatabound="DataListFlower_ItemDataBound" CellSpacing="14" >
            <ItemTemplate>
                <table border="0" cellspacing="0" cellpadding="0">
 
                  <tr>
                    <td colspan="4"><img alt="" src="image/flower_table_top.jpg" width="223" height="6" alt="" /></td>
                  </tr>
                  <tr>
                    <td><img alt="" src="image/flower_table_left.jpg" width="6" height="106" alt="" /></td>
                    <td><a href='FlowerInfo.aspx?id=<%#DataBinder.Eval(Container.DataItem,"ID")%>'>
                    <asp:Image ID="imgFlowerPic" runat="server" Width="120px" Height="102px"  ImageUrl='<%#DataBinder.Eval(Container.DataItem,"Photo")%>' />
                    </a></td>
                    <td><table width="88" border="0" cellspacing="0" cellpadding="0">
                      <tr>
                        <td height="30" style=" color:#D84399; text-align:center"><asp:Label ID="lblFlowerTitle" runat="server" Text="" Font-Bold="True" 
            Font-Size="12px" Height="22px"><%# DataBinder.Eval(Container.DataItem,"Name") %></asp:Label></td>
                      </tr>
                      <tr>
                        <td height="30" style=" text-align:center;color:#8A3AB5"><asp:Label ID="lblPrice" runat="server" Font-Size="12px" ForeColor="#762697" >￥<%# DataBinder.Eval(Container.DataItem,"Price") %></asp:Label> </td>
                      </tr>
                      <tr>
                        <td style="text-align:center"><a href='FlowerInfo.aspx?id=<%# DataBinder.Eval(Container.DataItem,"ID") %>'>
                        <asp:Image ID="imgOrder" runat="server" ImageUrl="image/flower_button.jpg"/></a></td>
                      </tr>
                    </table></td>
                    <td><img src="image/flower_table_right.jpg" width="6" height="106" alt="" /></td>
                  </tr>
                   <tr>
                    <td colspan="4">
                    <img alt="" src="image/flower_table_bottom.jpg" width="223" height="6" /></td>
                  </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
    </div>
    <div id="flowerlinkpage">
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