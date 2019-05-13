<%@ Page Title="会员中心-用户订单管理" Language="C#" MasterPageFile="~/Base.master" AutoEventWireup="true" CodeFile="UserCenterOrder.aspx.cs" Inherits="UserCenterOrder" %>
<%@ Register src="UserCenterLeft.ascx" tagname="UserCenterLeft" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div id="usercentertitle"></div>
<div class="indextitleline"></div>
<div id="usercentertitleblank"></div>
<div id="usercenterleft">
    
    <uc1:UserCenterLeft ID="UserCenterLeft1" runat="server" />
    
</div>
<div id="usercenterorderright">
    <div id="usercenterordertitle">以下是您的个人订单：</div>
    <div id="usercenterorderrightdatalist">
        <asp:GridView ID="gdvData" runat="server" BorderStyle="None" BorderWidth="1px" CellPadding="4"
                DataKeyNames="ID" OnRowDeleting="gdvData_RowDeleting" Width="480px" 
                onrowdatabound="gdvData_RowDataBound" AutoGenerateColumns="False">
                <RowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="ID" HeaderText="订单编号" />
                    <asp:BoundField DataField="OrderTime" DataFormatString="{0:d}" 
                        HeaderText="下单时间" />
                    <asp:TemplateField HeaderText="总金额">
                        <ItemTemplate>
                                ￥<asp:Label ID="lblSumPrice" runat="server"></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="ConsigneeName" HeaderText="收货人" />
                    <asp:BoundField DataField="OrderState" HeaderText="订单状态" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:ImageButton ID="imgBtnDelete" runat="server" OnClientClick='return confirm("确实要取消此订单吗?");' CommandName="Delete" ImageUrl="Image/usercenter_order_cancel.gif" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
    </div>
</div>
</asp:Content>

