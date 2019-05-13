<%@ Page Title="订单信息" Language="C#" MasterPageFile="~/Base.master" AutoEventWireup="true" CodeFile="OrderList.aspx.cs" Inherits="OrderList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div id="orderlisttitle"></div>
<div class="indextitleline"></div>
<div id="orderlistflow"></div>
<div id="orderlistmaintitle">以下是您选择的商品清单：</div>
<div id="orderlistmain">
    <div id="orderlistmaingoodlist">
        <asp:GridView ID="gdvData" runat="server" BorderStyle="None" BorderWidth="1px" CellPadding="0"
                DataKeyNames="ID" OnRowDeleting="gdvData_RowDeleting" Width="650px" 
                AutoGenerateColumns="False" onrowupdating="gdvData_RowUpdating" >
                <RowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="ID" HeaderText="商品编号" >
                    <HeaderStyle Height="24px" />
                    <ItemStyle Height="24px" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Name" HeaderText="商品名称" >
                    <HeaderStyle Height="24px" />
                    <ItemStyle Height="24px" />
                    </asp:BoundField>
                    <asp:TemplateField HeaderText="数量">
                        <ItemTemplate>
                            <asp:TextBox ID="txtNum" runat="server" Width="40px" BorderColor="#999999" 
                                BorderStyle="Solid" BorderWidth="1px" Text='<%# DataBinder.Eval(Container.DataItem, "Num")%>' Font-Size="12px" Height="20"></asp:TextBox>
                        </ItemTemplate>
                        <HeaderStyle Height="24px" />
                        <ItemStyle Height="24px" />
                    </asp:TemplateField>
                    <asp:BoundField DataField="Price" HeaderText="价格" >
                    <HeaderStyle Height="24px" />
                    <ItemStyle Height="24px" />
                    </asp:BoundField>
                    <asp:BoundField DataField="SumPrice" HeaderText="金额" >
                    <HeaderStyle Height="24px" />
                    <ItemStyle Height="24px" />
                    </asp:BoundField>
                    <asp:TemplateField HeaderText="操作">
                        <ItemTemplate>
                            <asp:ImageButton ID="imgBtnUpdate" runat="server" CommandName="Update" ImageUrl="Image/orderlist_updatenum.gif" />
                            <asp:ImageButton ID="imgBtnDelete" runat="server" OnClientClick='return confirm("确实要删除此商品吗?");' CommandName="Delete" ImageUrl="Image/usercenter_message_delete.gif" />
                        </ItemTemplate>
                        <HeaderStyle Height="24px" />
                        <ItemStyle Height="24px" Width="110px" />
                    </asp:TemplateField>
                </Columns>
                <EmptyDataTemplate>
                    <asp:Label ID="Label1" runat="server" Text="没有选择商品！" Font-Size="14px" ForeColor="#444444" Font-Bold="True"></asp:Label>
                </EmptyDataTemplate>
            </asp:GridView>
            <div id="orderlistmaingoodlistsum">
                <asp:Label ID="lblAllSumPrice" runat="server" Text="合计：元"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;</div>
            <div style="width:650px">
                <div id="orderlistmainservicegoodleft">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;增加服务</div>
                <div id="orderlistmainservicegoodmain">
                    <asp:CheckBoxList ID="chkBoxListServiceGood" runat="server" AutoPostBack="True" 
                        CellPadding="4" CellSpacing="10" Height="24px" 
                        onselectedindexchanged="chkBoxListServiceGood_SelectedIndexChanged" 
                        RepeatColumns="2" RepeatDirection="Horizontal" 
                        Width="550px">
                            </asp:CheckBoxList>
                </div>
                <div id="orderlistmaingoodinfo">
                  &nbsp;&nbsp;&nbsp;&nbsp;•&nbsp;如果要修改商品数量，请填写好新的数量，再单击“更新数量”按钮<br />
                   &nbsp;&nbsp;&nbsp;&nbsp;•&nbsp;如果要取消某个商品，单击“删除”按钮
                </div>
           </div>
    </div>
    <div id="orderlistbutton">
        <asp:ImageButton ID="imgBtnReturn" runat="server" 
            ImageUrl="Image/orderlist_return.jpg" PostBackUrl="Index.aspx" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:ImageButton ID="imgBtnToPay" runat="server" ImageUrl="Image/orderlist_topay.jpg" PostBackUrl="FillOrder.aspx"/>
    </div>
    
</div>
</asp:Content>

