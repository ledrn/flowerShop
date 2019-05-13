<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ServiceCenter.ascx.cs" Inherits="ServiceCenter" %>
<div id="mainrightservicecentertop"></div>
                <div id="mainrightservicecentermain">
                    <table width="235px" align="center">
                        <tr>
                            <td style="line-height:40px; height:40px; text-align:center">
                                <asp:ImageButton ID="ImageButton1" runat="server" 
                                    ImageUrl="~/Image/main_right_servicecenter_howtopay.jpg" 
                                    PostBackUrl="HowToPay.aspx" /></td>
                            <td style="line-height:40px; height:40px; text-align:center">
                                <asp:ImageButton ID="ImageButton2" runat="server" 
                                    ImageUrl="~/Image/main_right_servicecenter_howtobuy.jpg" PostBackUrl="HowToBuy.aspx" /></td>
                        </tr>
                        <tr>
                            <td style="line-height:40px; height:40px;text-align:center">
                                <asp:ImageButton ID="ImageButton3" runat="server" 
                                    ImageUrl="~/Image/main_right_servicecenter_sendarea.jpg" PostBackUrl="SendArea.aspx" /></td>
                            <td style="line-height:40px; height:40px;text-align:center">
                                <asp:ImageButton ID="ImageButton4" runat="server" 
                                    ImageUrl="~/Image/main_right_servicecenter_aftersell.jpg" PostBackUrl="AfterSell.aspx" /></td>
                        </tr>
                        
                        <tr>
                            <td style="line-height:40px; height:40px;text-align:center">
                                <asp:ImageButton ID="ImageButton7" runat="server" 
                                    ImageUrl="~/Image/main_right_servicecenter_orderqa.jpg"  PostBackUrl="OrderQA.aspx"/></td>
                            <td style="line-height:40px; height:40px;text-align:center">
                                <asp:ImageButton ID="ImageButton8" runat="server" 
                                    ImageUrl="~/Image/main_right_servicecenter_aboutus.jpg" PostBackUrl="AboutUs.aspx" /></td>
                        </tr>
                        <tr>
                            <td style="line-height:3px; font-size:3px; height:3px;vertical-align:top" colspan="2">
                            <asp:ImageButton ID="ImageButton5" runat="server" 
                                    ImageUrl="~/Image/main_right_servicecenter_line.jpg" />
                                </td>
                        </tr>
                         <tr>
                            <td style="line-height:45px; height:45px;text-align:center">
                                <asp:ImageButton ID="ImageButton6" runat="server" 
                                    ImageUrl="~/Image/main_right_servicecenter_leagueflow.jpg" PostBackUrl="LeagueFlow.aspx" /></td>
                            <td style="line-height:45px; height:45px;text-align:center">
                                <asp:ImageButton ID="ImageButton9" runat="server" 
                                    ImageUrl="~/Image/main_right_servicecenter_leagueqa.jpg" PostBackUrl="LeagueQA.aspx" /></td>
                        </tr>
                         <tr>
                            <td style="line-height:45px; height:45px;text-align:center">
                                <asp:ImageButton ID="ImageButton10" runat="server" 
                                    ImageUrl="~/Image/main_right_servicecenter_flowershop.jpg" PostBackUrl="FlowerShopList.aspx" /></td>
                            <%--<td style="line-height:45px; height:45px;text-align:center">
                                <asp:ImageButton ID="ImageButton11" runat="server" 
                                    ImageUrl="~/Image/main_right_servicecenter_flowershop.jpg" PostBackUrl="FlowerShopList.aspx" /></td>--%>
                        </tr>
                    </table>
                </div>