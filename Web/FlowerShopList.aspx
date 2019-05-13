<%@ Page Title="各地花店" Language="C#" MasterPageFile="~/Base.master" AutoEventWireup="true" CodeFile="FlowerShopList.aspx.cs" Inherits="FlowerShopList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <div id="flowershoplisttitle">
    </div>
    <div id="goodinfotitleline">
    </div>
<div id="newlistimgtop"></div>
    <div id="newlistimgleft">
        <div id="newlistimglefttop"></div>
        <div id="newlistimgleftmain"></div>
    </div>
    <div id="newlistmain">
        <div id="newlistmain_top"></div>
        <div id="newlistmain_datalist">
            <asp:DataList ID="DataListFlowerShops" runat="server" CellSpacing="7" 
                                            Width="660px" RepeatColumns="3" >
                        <ItemTemplate>
                            <table style="width: 100%; text-align:left;">
                                <tr>
                                    <td>
                                        <img alt="" src="image/main_flowernews_left.gif" width="16px" /><asp:Label 
                                            ID="lblShopName" runat="server" Width="190px">
                                <%# DataBinder.Eval(Container.DataItem,"Name") %></asp:Label>
                                    </td>
                                </tr>
                            </table>
                        </ItemTemplate>
                    </asp:DataList>
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
    </div>
    </div>
    <div id="newlistimgright">
        <div id="newlistimgrighttop"></div>    
        <div id="newlistimgrightmain"></div>
    </div>
    <div id="newlistimgbottom"></div>
</asp:Content>