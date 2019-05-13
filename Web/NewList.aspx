<%@ Page Title="花言花语" Language="C#" MasterPageFile="~/Base.master" AutoEventWireup="true" CodeFile="NewList.aspx.cs" Inherits="NewList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div id="newlisttitle">
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
            <asp:DataList ID="DataListFlowerNews" runat="server" CellSpacing="7" 
                            onitemdatabound="DataListFlowerNews_ItemDataBound" Width="620px" >
                        <ItemTemplate>
                            <table border="0" cellspacing="0" cellpadding="0" style=" text-align:left; width:620px">
                             <tr>
                                <td style=" color:Black" ><img alt="" src="image/main_flowernews_left.gif" width="16" />
                                &nbsp;
                                <asp:Label ID="lblNewTitle" runat="server" Width="520"><a class="agoodclass" href='NewInfo.aspx?id=<%# DataBinder.Eval(Container.DataItem,"ID") %>'>
                                <%# DataBinder.Eval(Container.DataItem,"Title") %></a></asp:Label>
                                &nbsp;<asp:Label ID="lblNewTime" runat="server" Width="60px" Text='<%# DataBinder.Eval(Container.DataItem,"WriteTime") %>' ></asp:Label><br />
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

