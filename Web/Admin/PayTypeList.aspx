<%@ Page Title="网站后台-付款方式列表" Language="C#" MasterPageFile="~/Admin/AdminPage.master" AutoEventWireup="true" CodeFile="PayTypeList.aspx.cs" Inherits="Admin_PayTypeList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div style=" line-height:28px">
<br />
    <div>
        <asp:GridView ID="gdvData" runat="server" BorderStyle="None" BorderWidth="1px" CellPadding="4"
                DataKeyNames="ID" OnRowDeleting="gdvData_RowDeleting" Width="100%" 
                onrowdatabound="gdvData_RowDataBound" AutoGenerateColumns="False" PageSize="20">
                <RowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="ID" HeaderText="编号" />
                    <asp:BoundField DataField="Name" HeaderText="付款名称" />
                    <asp:BoundField DataField="PayContent" HeaderText="付款方式" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button ID="btnDelete" runat="server" OnClientClick='return confirm("确实要删除吗?");'
                                CommandName="Delete" CssClass="adminbottondelete" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button ID="btnEdit" runat="server" CssClass="adminbottonedit" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
    </div>
</div>
</asp:Content>

