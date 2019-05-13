<%@ Control Language="C#" AutoEventWireup="true" CodeFile="HotSell.ascx.cs" Inherits="HotSell" %>
<div id="link_logo" style="OVERFLOW: hidden; WIDTH: 230px; HEIGHT: 335px">
<div id="link_logo1" style="OVERFLOW: hidden">
<asp:DataList ID="DataListHotSell" runat="server" 
    onitemdatabound="DataListHotSell_ItemDataBound" >
    <ItemTemplate>
        <table width="230px" style=" text-align:left" >
            <tr>
                <td style="background-color: #F6ECF7; " colspan="2" valign="middle" >
                    <asp:Image ID="Image1" runat="server" 
                        ImageUrl="~/Image/hotsell_title_front.jpg" />
                    <asp:Label ID="lblHotSellTitle" runat="server" Text="" Font-Bold="True" 
                        Font-Size="12px" ForeColor="#762697" Height="22px"><%# DataBinder.Eval(Container.DataItem,"Name") %></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="height:4px; font-size:4px">
                    &nbsp;</td>
                <td style="height:4px; font-size:4px">
                    &nbsp;</td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="lblFlowerSay" runat="server" Font-Size="12px" ForeColor="#9A5EB2" 
                        Height="19px" Width="225px"><%# DataBinder.Eval(Container.DataItem, "Describe")%></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="height:4px; font-size:4px">
                    &nbsp;</td>
                <td style="height:4px; font-size:4px">
                    &nbsp;</td>
            </tr>
            <tr>
                <td rowspan="3">&nbsp;
                    <a href='FlowerInfo.aspx?id=<%#DataBinder.Eval(Container.DataItem,"ID")%>'>
                    <asp:Image ID="imgPic" runat="server" Width="100px" Height="100px"  ImageUrl='<%#DataBinder.Eval(Container.DataItem,"Photo")%>' />
                    </a>
                    </td>
                <td style="text-align:center">
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="text-align:center">
                    <asp:Label ID="lblPrice" runat="server" Font-Size="12px" ForeColor="#762697" >￥<%# DataBinder.Eval(Container.DataItem,"Price") %></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="text-align:center">
                    <a href='FlowerInfo.aspx?id=<%# DataBinder.Eval(Container.DataItem,"ID") %>'><asp:Image ID="imgOrder" runat="server" ImageUrl="~/Image/hotsell_button.jpg"/>
                    </a>
                </td>
            </tr>
        </table>
    </ItemTemplate>
</asp:DataList>
</div>
<div id="link_logo2"></div>
</div>
<script type="text/javascript">
    var speed = 65
    link_logo2.innerHTML = link_logo1.innerHTML
    function Marquee2() {
        if (link_logo2.offsetTop - link_logo.scrollTop <= 0)
            link_logo.scrollTop -= link_logo1.offsetHeight
        else {
            link_logo.scrollTop++
        }
    }
    var MyMar2 = setInterval(Marquee2, speed)
    link_logo.onmouseover = function() { clearInterval(MyMar2) }
    link_logo.onmouseout = function() { MyMar2 = setInterval(Marquee2, speed) }
</script>