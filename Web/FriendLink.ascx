<%@ Control Language="C#" AutoEventWireup="true" CodeFile="FriendLink.ascx.cs" Inherits="FriendLink" %>
<asp:DataList ID="DataListFriendLink" runat="server" onitemdatabound="DataListFriendLink_ItemDataBound" 
    >
    <ItemTemplate>
        <table width="230px" >
            <tr>
                <td valign="middle" style="text-align:center; height:45px" >
                    <a href='<%#DataBinder.Eval(Container.DataItem,"LinkURL")%>'>
                    <asp:Image ID="imgPic" runat="server" Height="43px"  
                        ImageUrl='<%#DataBinder.Eval(Container.DataItem,"ImageURL")%>' 
                        Width="167px" BorderColor="#D4AFDB" BorderWidth="1px" 
                        ToolTip='<%#DataBinder.Eval(Container.DataItem,"Name")%>' />
                    </a>
                </td>
            </tr>
           
        </table>
    </ItemTemplate>
</asp:DataList>