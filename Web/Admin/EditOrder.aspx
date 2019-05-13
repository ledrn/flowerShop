<%@ Page Language="C#" MasterPageFile="~/Admin/AdminPage.master" AutoEventWireup="true" CodeFile="EditOrder.aspx.cs" Inherits="Admin_EditOrder" Title="网站后台-查看订单详情" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div style=" text-align:left; line-height:24px;">
    <p>
       &nbsp;&nbsp;订单编号：<asp:Label ID="lblOrderId" runat="server" Text=""></asp:Label><br/>
        &nbsp;&nbsp;订单状态：<asp:Label ID="lblOrderState" runat="server" Text=""></asp:Label><br/>
        &nbsp;&nbsp;订单时间：<asp:Label ID="lblOrderTime" runat="server" Text=""></asp:Label><br/>
        &nbsp;&nbsp;配送方式：<asp:Label ID="lblSendType" runat="server" Text=""></asp:Label><br/>
        &nbsp;&nbsp;付款方式：<asp:Label ID="lblPayType" runat="server" Text=""></asp:Label><br/>
        &nbsp;&nbsp;配送时间：<asp:Label ID="lblSendTime" runat="server" Text=""></asp:Label><br/>
        &nbsp;&nbsp;配送时段：<asp:Label ID="lblSendperiodTime" runat="server" Text=""></asp:Label><br/>
        &nbsp;&nbsp;特殊要求：<asp:Label ID="lblSpecialOrder" runat="server" Text=""></asp:Label><br/>
        &nbsp;&nbsp;给收货人留言：<asp:Label ID="lblMessage" runat="server" Text=""></asp:Label><br/>
        &nbsp;&nbsp;署名：<asp:Label ID="lblPenName" runat="server" Text=""></asp:Label><br/>
    </p>
    <p>
        &nbsp;&nbsp;购买人姓名：<asp:Label ID="lblBuyerName" runat="server" Text=""></asp:Label><br/>
        &nbsp;&nbsp;购买人电话：<asp:Label ID="lblBuyerPhone" runat="server" Text=""></asp:Label><br/>
        &nbsp;&nbsp;购买人手机：<asp:Label ID="lblBuyerMobilePhone" runat="server" Text=""></asp:Label><br/>
        &nbsp;&nbsp;购买人QQ：<asp:Label ID="lblBuyerQQ" runat="server" Text=""></asp:Label><br/>
        &nbsp;&nbsp;购买人Email：<asp:Label ID="lblBuyerEmail" runat="server" Text=""></asp:Label><br/>
        &nbsp;&nbsp;购买人地址：<asp:Label ID="lblBuyerAddress" runat="server" Text=""></asp:Label><br/>
        &nbsp;&nbsp;购买人编号：<asp:Label ID="lblUserId" runat="server" Text=""></asp:Label><br/>
    </p>
    <p>
        &nbsp;&nbsp;收货人姓名：<asp:Label ID="lblConsigneeName" runat="server" Text=""></asp:Label><br/>
        &nbsp;&nbsp;收货人电话：<asp:Label ID="lblConsigneePhone" runat="server" Text=""></asp:Label><br/>
        &nbsp;&nbsp;收货人手机：<asp:Label ID="lblConsigneeMobilePhone" runat="server" Text=""></asp:Label><br/>
        &nbsp;&nbsp;收货人QQ：<asp:Label ID="lblConsigneeQQ" runat="server" Text=""></asp:Label><br/>
        &nbsp;&nbsp;收货人Email：<asp:Label ID="lblConsigneeEmail" runat="server" Text=""></asp:Label><br/>
        &nbsp;&nbsp;收货人地址：<asp:Label ID="lblConsigneeAddress" runat="server" Text=""></asp:Label><br/>
        &nbsp;&nbsp;收货人地区：<asp:Label ID="lblConsigneeArea" runat="server" Text=""></asp:Label><br/>
    </p>
    <br />
    <div style=" text-align:center">
        <asp:Button ID="btnAccepting" runat="server"  CssClass="adminbottonaccepting" 
            onclick="btnAccepting_Click" /> &nbsp;&nbsp;
        <asp:Button ID="btnAccepted" runat="server"  CssClass="adminbottonaccepted" 
            onclick="btnAccepted_Click" />&nbsp;&nbsp;
        <asp:Button ID="btnCancel" runat="server" onclick="btnCancel_Click" CssClass="adminbottoncancel" />&nbsp;&nbsp;
        <asp:Button ID="btnRetrun" runat="server"  CssClass="adminbottonreturn"
            PostBackUrl="OrderList.aspx" /><br /><br />
    </div>
    <div style=" text-align:center">
    <hr style="width:400px" />
    </div>
    <br/>
    
        <div style=" text-align:center">
        <asp:GridView ID="gdvData" runat="server" BorderStyle="None" BorderWidth="1px" CellPadding="4"
                DataKeyNames="ID" Width="100%" 
                onrowdatabound="gdvData_RowDataBound" AutoGenerateColumns="False" PageSize="20">
                <RowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="ID" HeaderText="编号" />
                    <asp:BoundField DataField="GoodId" HeaderText="商品编号" />
                    <asp:BoundField DataField="GoodName" HeaderText="商品名称" />
                    <asp:BoundField DataField="Price" HeaderText="商品单价" />
                    <asp:BoundField DataField="Num" HeaderText="数量" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button ID="btnEdit" runat="server" CssClass="adminbottonview" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
    </div>
    <br />
    &nbsp;&nbsp;总金额：<asp:Label ID="lblSumPrice" runat="server" Text=""></asp:Label>
    <br />
</div>
</asp:Content>

