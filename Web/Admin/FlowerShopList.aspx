<%@ Page Title="��վ��̨-�����б�" Language="C#" MasterPageFile="~/Admin/AdminPage.master" AutoEventWireup="true" CodeFile="FlowerShopList.aspx.cs" Inherits="Admin_FlowerShopList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div style=" line-height:28px">
<br />
    <div id="adminsearchflowershop">
    �������ƣ�<asp:TextBox ID="txtName" runat="server" CssClass="admintextbox" Width="200px"></asp:TextBox>&nbsp;
      <asp:Button ID="btnSearch" runat="server" CssClass="adminbottonsearch" onclick="btnSearch_Click" /><br /><br />
  </div>
   <div>
        <asp:GridView ID="gdvData" runat="server" BorderStyle="None" BorderWidth="1px" CellPadding="4"
                DataKeyNames="ID" OnRowDeleting="gdvData_RowDeleting" Width="100%" 
                onrowdatabound="gdvData_RowDataBound" AutoGenerateColumns="False">
                <RowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="ID" HeaderText="������" />
                    <asp:BoundField DataField="Name" HeaderText="����" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button ID="btnDelete" runat="server" OnClientClick='return confirm("ȷʵҪɾ����?");'
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
    <div>
        <asp:LinkButton ID="lbtnFirstpage" runat="server" CommandName="0" OnClick="Page_OnClick" target="_self">��ҳ</asp:LinkButton>
                <asp:LinkButton ID="lbtnPrevpage" runat="server"  CommandName="prev" 
            OnClick="Page_OnClick" target="_self">��һҳ</asp:LinkButton>
                <asp:LinkButton ID="lbtnNextpage" runat="server"  CommandName="next" 
            OnClick="Page_OnClick" target="_self" >��һҳ</asp:LinkButton>
                <asp:LinkButton ID="lbtnLastpage" runat="server"  CommandName="last" OnClick="Page_OnClick" target="_self">βҳ</asp:LinkButton>
                ��<asp:Label ID="lbCurrentPage" runat="server" ></asp:Label>ҳ/��<asp:Label ID="lbPageCount" runat="server" ></asp:Label>ҳ
                ת��:��<asp:TextBox ID="tbGogoPage" runat="server" CssClass="admintextbox" Width="19px" OnTextChanged="tbGogoPage_TextChanged"></asp:TextBox>ҳ
    </div>
</div>
</asp:Content>

