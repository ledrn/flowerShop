<%@ Page Title="后台管理-显示所有用户" Language="C#" MasterPageFile="~/Admin/AdminPage.master"
    AutoEventWireup="true" CodeFile="UserList.aspx.cs" Inherits="Admin_UserList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div style=" line-height:28px">
    <br />
  <div id="adminsearchuser">
    用户名称：<asp:TextBox ID="txtUserName" runat="server" CssClass="admintextbox"></asp:TextBox>&nbsp;
      <asp:Button ID="btnSearch" runat="server" CssClass="adminbottonsearch" onclick="btnSearch_Click" /><br /><br />
  </div>
    <div>
        <asp:GridView ID="gdvData" runat="server" BorderStyle="None" BorderWidth="1px" CellPadding="4"
                DataKeyNames="ID" OnRowDeleting="gdvData_RowDeleting" Width="100%" 
                onrowdatabound="gdvData_RowDataBound" AutoGenerateColumns="False">
                <RowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="ID" HeaderText="用户编号" />
                    <asp:BoundField DataField="UserName" HeaderText="名称" />
                    <asp:BoundField DataField="RealName" HeaderText="真实姓名" />
                    <asp:BoundField DataField="WriteTime" DataFormatString="{0:d}" 
                        HeaderText="注册日期" />
                    <asp:BoundField DataField="IsAdmin" HeaderText="用户类型" />
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
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button ID="btnUpdatePwd" runat="server" CssClass="adminbottonupdatepwd" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
    </div>
    <div>
        <asp:LinkButton ID="lbtnFirstpage" runat="server" CommandName="0" OnCommand="Page_OnClick" target="_self">首页</asp:LinkButton>
                <asp:LinkButton ID="lbtnPrevpage" runat="server"  CommandName="prev" OnCommand="Page_OnClick" target="_self">上一页</asp:LinkButton>
                <asp:LinkButton ID="lbtnNextpage" runat="server"  CommandName="next" OnCommand="Page_OnClick" target="_self">下一页</asp:LinkButton>
                <asp:LinkButton ID="lbtnLastpage" runat="server"  CommandName="last" OnCommand="Page_OnClick" target="_self">尾页</asp:LinkButton>
                第<asp:Label ID="lbCurrentPage" runat="server" ></asp:Label>页/共<asp:Label ID="lbPageCount" runat="server" ></asp:Label>页
                转到:第<asp:TextBox ID="tbGogoPage" runat="server" CssClass="admintextbox"  Width="19px" OnTextChanged="tbGogoPage_TextChanged"></asp:TextBox>页
    </div>
   </div>
</asp:Content>
