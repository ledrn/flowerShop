<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>
<%@ Register src="HotSell.ascx" tagname="HotSell" tagprefix="uc1" %>
<%@ Register src="Bottom.ascx" tagname="Bottom" tagprefix="uc2" %>
<%@ Register src="Head.ascx" tagname="Head" tagprefix="uc3" %>
<%@ Register src="ServiceCenter.ascx" tagname="ServiceCenter" tagprefix="uc4" %>
<%@ Register src="GoodClass.ascx" tagname="GoodClass" tagprefix="uc5" %>
<%@ Register src="FriendLink.ascx" tagname="FriendLink" tagprefix="uc6" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>鲜花速递网站-首页</title>
</head>
<body>
    <div id="mainpage">
<form id="form1" runat="server">
    <div id="mainhead">
    
        <uc3:Head ID="Head1" runat="server" />
    
    </div>
    <div id="main">
        <div id="mainleft">
            <div id="maintopunderbanner"></div>
            <div id="maintopunderbanner2"></div>
            <div id="maintopsearchorder">
            <div id="maintopsearchblank"></div>
                订单查询：
                <asp:TextBox ID="txtSearchOrderById"
                    runat="server" Height="18px" BorderColor="#FCAEA1" 
                    BorderStyle="Solid" BorderWidth="1px" Width="210px"></asp:TextBox>
            </div>
            <div id="maintopsearchorderbtn">
                <asp:ImageButton ID="imgBtnSearch" runat="server" 
                    ImageUrl="~/Image/main_top_search.jpg" onclick="imgBtnSearch_Click" />
            </div>
            <div id="maincenterright">
                <div id="indexflowertitle"></div>
                <div class="indextitleline"></div>
                <div id="indexflowerdatalist">
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
                <div class="indextitleblank"></div>
                <div id="indexflash">
                <object classid="clsid:D27CDB6E-AE6D-11cf-96B8-444553540000" codebase="http://download.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=6,0,29,0"
                          width="706px" height="86px">
                       <param name="movie" value="image/index_flash.swf" />
                       <param name="quality" value="high" />
                       <embed src="image/index_flash.swf" quality="high" pluginspage="http://www.macromedia.com/go/getflashplayer"
                            type="application/x-shockwave-flash" width="706px" height="86px"></embed>
                     </object>
                </div>
                
                <div class="indextitleblank"></div>
                <br />
                <div id="indexfriuttitle"></div>
                <div class="indextitleline"></div>
                <div id="indexfriutdatalist">
                     <asp:DataList ID="DataListFriut" runat="server" RepeatColumns="5" 
                         CellSpacing="7" onitemdatabound="DataListFriut_ItemDataBound" >
                        <ItemTemplate>
                            <table border="0" cellspacing="0" cellpadding="0">
                             <tr>
                                <td ><a href='FlowerInfo.aspx?id=<%#DataBinder.Eval(Container.DataItem,"ID")%>'>
                                <asp:Image ID="imgFriutPic" runat="server" Width="135px" Height="147px"  
                                        ImageUrl='<%#DataBinder.Eval(Container.DataItem,"Photo")%>' 
                                        BorderColor="#A3D483" BorderWidth="1px" />
                                </a></td>
                              </tr>
                              <tr>
                                <td></td>
                              </tr>
                              <tr>
                                <td height="22" style=" text-align:center;color:#3A6F0F" ><asp:Label ID="lblFriutTitle" runat="server" Text="" Font-Bold="True" 
                        Font-Size="12px" Height="22px"><%# DataBinder.Eval(Container.DataItem,"Name") %></asp:Label></td>
                              </tr>
                              <tr>
                                <td height="22" style=" text-align:center;color:#3A6F0F" ><asp:Label ID="lblPrice" runat="server" Font-Size="12px" >￥<%# DataBinder.Eval(Container.DataItem,"Price") %></asp:Label></td>
                              </tr>
                              <tr>
                                <td height="22" style=" text-align:center;"><a href='FlowerInfo.aspx?id=<%# DataBinder.Eval(Container.DataItem,"ID") %>'>
                                    <asp:Image ID="imgOrder" runat="server" ImageUrl="image/friut_button.jpg"/></a></td>
                              </tr>
                            </table>
                        </ItemTemplate>
                    </asp:DataList>

                </div>
                <div class="indextitleblank"></div>
                <br />
                <div id="indexcaketitle"></div>
                <div class="indextitleline"></div>
                <div id="indexcakedatalist">
                    <asp:DataList ID="DataListCake" runat="server" RepeatColumns="5" 
                         CellSpacing="7" onitemdatabound="DataListCake_ItemDataBound" >
                        <ItemTemplate>
                            <table border="0" cellspacing="0" cellpadding="0">
                             <tr>
                                <td ><a href='FlowerInfo.aspx?id=<%#DataBinder.Eval(Container.DataItem,"ID")%>'>
                                <asp:Image ID="imgCakePic" runat="server" Width="135px" Height="147px"  
                                        ImageUrl='<%#DataBinder.Eval(Container.DataItem,"Photo")%>' 
                                        BorderColor="#A3D483" BorderWidth="1px" />
                                </a></td>
                              </tr>
                              <tr>
                                <td></td>
                              </tr>
                              <tr>
                                <td height="22" style=" text-align:center;color:#3A6F0F" ><asp:Label ID="lblFriutTitle" runat="server" Text="" Font-Bold="True" 
                        Font-Size="12px" Height="22px"><%# DataBinder.Eval(Container.DataItem,"Name") %></asp:Label></td>
                              </tr>
                              <tr>
                                <td height="22" style=" text-align:center;color:#3A6F0F" ><asp:Label ID="lblPrice" runat="server" Font-Size="12px" >￥<%# DataBinder.Eval(Container.DataItem,"Price") %></asp:Label></td>
                              </tr>
                              <tr>
                                <td height="22" style=" text-align:center;"><a href='FlowerInfo.aspx?id=<%# DataBinder.Eval(Container.DataItem,"ID") %>'>
                                    <asp:Image ID="imgOrder" runat="server" ImageUrl="image/friut_button.jpg"/></a></td>
                              </tr>
                            </table>
                        </ItemTemplate>
                    </asp:DataList>

                </div>
                <div class="indextitleblank"></div>
                <br />
                <div id="indexchocolatetitle"></div>
                <div class="indextitleline"></div>
                <div id="indexchocolatedatalist">
                      <asp:DataList ID="DataListChocolate" runat="server" RepeatColumns="5" 
                         CellSpacing="7" onitemdatabound="DataListChocolate_ItemDataBound" >
                        <ItemTemplate>
                            <table border="0" cellspacing="0" cellpadding="0">
                             <tr>
                                <td ><a href='FlowerInfo.aspx?id=<%#DataBinder.Eval(Container.DataItem,"ID")%>'>
                                <asp:Image ID="imgChocolatePic" runat="server" Width="135px" Height="147px"  
                                        ImageUrl='<%#DataBinder.Eval(Container.DataItem,"Photo")%>' 
                                        BorderColor="#A3D483" BorderWidth="1px" />
                                </a></td>
                              </tr>
                              <tr>
                                <td></td>
                              </tr>
                              <tr>
                                <td height="22" style=" text-align:center;color:#3A6F0F" ><asp:Label ID="lblFriutTitle" runat="server" Text="" Font-Bold="True" 
                        Font-Size="12px" Height="22px"><%# DataBinder.Eval(Container.DataItem,"Name") %></asp:Label></td>
                              </tr>
                              <tr>
                                <td height="22" style=" text-align:center;color:#3A6F0F" ><asp:Label ID="lblPrice" runat="server" Font-Size="12px" >￥<%# DataBinder.Eval(Container.DataItem,"Price") %></asp:Label></td>
                              </tr>
                              <tr>
                                <td height="22" style=" text-align:center;"><a href='FlowerInfo.aspx?id=<%# DataBinder.Eval(Container.DataItem,"ID") %>'>
                                    <asp:Image ID="imgOrder" runat="server" ImageUrl="image/friut_button.jpg"/></a></td>
                              </tr>
                            </table>
                        </ItemTemplate>
                    </asp:DataList>

                </div>
                <div class="indextitleblank"></div>
                <br />
                
                <div id="indexflowernews">
                    <div id="indexflowernewsleftblank"></div>
                    <div id="indexflowernewstop">
                        
                        <table style=" width:341px; height:36px;">
                            <tr>
                                <td style=" width:280px">
                                    &nbsp;</td>
                                <td>
                                    <a href="NewList.aspx"><asp:Image ID="imgFlowerNewMore" runat="server" ImageUrl="Image/main_more.jpg" /></a>
                                </td>
                            </tr>
                        </table>
                        
                    </div>
                    <div id="indexflowernewsmain">
                        <asp:DataList ID="DataListFlowerNews" runat="server" CellSpacing="7" 
                            onitemdatabound="DataListFlowerNews_ItemDataBound" Width="320px" >
                        <ItemTemplate>
                            <table border="0" cellspacing="0" cellpadding="0" style=" text-align:left; width:320px">
                             <tr>
                                <td style=" color:Black" ><img alt="" src="image/main_flowernews_left.gif" width="16" />
                                &nbsp;
                                <asp:Label ID="lblNewTitle" runat="server" Width="220"><a class="agoodclass" href='NewInfo.aspx?id=<%# DataBinder.Eval(Container.DataItem,"ID") %>'>
                                <%# DataBinder.Eval(Container.DataItem,"Title") %></a></asp:Label>
                                &nbsp;<asp:Label ID="lblNewTime" runat="server" Width="55px" Text='<%# DataBinder.Eval(Container.DataItem,"WriteTime") %>' ></asp:Label><br />
                                   </td>
                                
                              </tr>
                              
                            </table>
                        </ItemTemplate>
                    </asp:DataList>

                    </div>
                    <div id="indexflowernewsbottom"></div>
                </div>
                <div id="indexnewleague">
                    <div id="indexnewleaguerightblank"></div>
                    <div id="indexnewleaguetop">
                        <table style=" width:341px; height:36px;">
                            <tr>
                                <td style=" width:280px">
                                    &nbsp;</td>
                                <td>
                                    <a href="FlowerShopList.aspx"><asp:Image ID="imgNewLeague" runat="server" ImageUrl="Image/main_more.jpg" /></a>
                                </td>
                            </tr>
                        </table>
                    </div>
                    <div id="indexnewleaguemain">
                      <asp:DataList ID="DataListNewLeague" runat="server" CellSpacing="7" 
                             Width="320px" >
                        <ItemTemplate>
                            <table border="0" cellspacing="0" cellpadding="0" style=" text-align:left; width:320px">
                             <tr>
                                <td style=" color:Black" ><img alt="" src="image/main_flowernews_left.gif" width="16px" />
                                &nbsp;
                                <asp:Label ID="lblName" runat="server" Width="280px"><a class="agoodclass" href="FlowerShopList.aspx">
                                <%# DataBinder.Eval(Container.DataItem,"Name") %></a></asp:Label>
                                <br />
                                   </td>
                              </tr>
                            </table>
                        </ItemTemplate>
                    </asp:DataList>

                    </div>
                    <div id="indexnewleaguebottom"></div>
                </div>
                
                
            </div>
        </div>
        <div id="mainright">
            <div id="mainrightcenter">
                
               <div id="mainrightgoodclasstop"></div>
                 <div id="mainrightgoodclassmain">
                
                     <uc5:GoodClass ID="GoodClass1" runat="server" />
                
                </div>
                
                <div class="mainrightblank"></div>
                <div id="mainrighthotselltop"></div>
                <div id="mainrighthotsellmain" >
                    <div id="mainrighthotsellmainblank"></div>
                    <div id="mainrighthotsell">
                    
                        <uc1:HotSell ID="HotSell1" runat="server" />
                    
                    </div>
                </div>
                <div class="mainrightblank"></div>
                <div id="servicecenter">
                
                    <uc4:ServiceCenter ID="ServiceCenter1" runat="server" />
                
                </div>
                <div class="mainrightblank"></div>
                <div id="mainrightfriendlinktop"></div>
                <div id="mainrightfriendlinkmain">
                    <div id="mainrightfriendlinkblank"></div>
                    <div id="mainrightfriendlink">
                        
                        <uc6:FriendLink ID="FriendLink1" runat="server" />
                        
                    </div>
                </div>
            </div>
           
        </div>
    </div>
    <div id="mainbottonline"></div>
    <div id="mainbotton">
        
        <uc2:Bottom ID="Bottom1" runat="server" />
        
    </div>
    </form>
</div>
</body>
</html>
