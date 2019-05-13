<%@ Control Language="C#" AutoEventWireup="true" CodeFile="LeftMenu.ascx.cs" Inherits="Admin_LeftMenu" %>
<style type="text/css">body {  FONT: 9pt 宋体 }
	table { BORDER-RIGHT: 0px; BORDER-TOP: 0px; BORDER-LEFT: 0px; BORDER-BOTTOM: 0px }
	td { FONT: 12px 宋体 }
	img { BORDER-RIGHT: 0px; BORDER-TOP: 0px; VERTICAL-ALIGN: bottom; BORDER-LEFT: 0px; BORDER-BOTTOM: 0px }
	A { FONT: 12px 宋体; COLOR: #215dc6; TEXT-DECORATION: none }
	A:hover { COLOR: #428eff }
	.sec_menu { BORDER-RIGHT: white 1px solid; BACKGROUND: #d6dff7; OVERFLOW: hidden; BORDER-LEFT: white 1px solid; BORDER-BOTTOM: white 1px solid }
	.menu_title { }
	.menu_title SPAN { FONT-WEIGHT: bold; LEFT: 8px; COLOR: #215dc6; POSITION: relative; TOP: 2px }
	.menu_title2 { }
	.menu_title2 SPAN { FONT-WEIGHT: bold; LEFT: 8px; COLOR: #428eff; POSITION: relative; TOP: 2px }
</style>
<meta http-equiv="Content-Type" content="text/html; charset=gb2312">
<script type="text/javascript">
    function showsubmenu(sid)
    {
        whichEl = eval("submenu" + sid);
        if (whichEl.style.display == "none")
        {
            eval("submenu" + sid + ".style.display=\"\";");
        }
        else
        {
            eval("submenu" + sid + ".style.display=\"none\";");
        }
    }
</script>
<base target="main">
<body MS_POSITIONING="GridLayout" leftmargin="0" topmargin="0">
	<table cellSpacing="0" cellPadding="0" width="158px" align="left" border="0">
		<tbody>
			<tr>
				<td valign="top">
					<!--用户管理-->
					<asp:Panel id="Panel1" runat="server">
						<table cellSpacing="0" cellPadding="0" width="158" align="center">
							<tr style="CURSOR: hand">
								<td class="menu_title" id="menuTitle1" onmouseover="this.className='menu_title2';" onclick="showsubmenu(1)"
									onmouseout="this.className='menu_title';" background="../image/admin_title_show.gif"
									height="25"><SPAN>用户管理</SPAN>
								</td>
							</tr>
							<tr>
								<td>
									<div class="sec_menu" id="submenu1">
										<table style="POSITION: relative; TOP: 5px" cellSpacing="0" cellPadding="0" width="135"
											align="center">
											<tr>
												<td height="20"><img height="20" src="../image/bullet.gif" width="15" border="0"><A href="AddUser.aspx" target="_self">添加用户</A></td>
											</tr>
											<tr>
												<td height="20"><img height="20" src="../image/bullet.gif" width="15" border="0"><A href="UserList.aspx" target="_self">管理用户</A></td>
											</tr>
											<tr>
												<td height="20"><img height="20" src="../image/bullet.gif" width="15" border="0"><A href="MessageList.aspx" target="_self">管理短消息</A></td>
											</tr>
										</table>
									</div>
								</td>
							</tr>
							<tr>
								<td height="2"></td>
							</tr>
						</table>
					</asp:Panel>
					<!--商品管理-->
					<asp:Panel id="Panel2" runat="server">
						<table cellSpacing="0" cellPadding="0" width="158" align="center">
							<tr style="CURSOR: hand">
								<td class="menu_title" id="menuTitle1" onmouseover="this.className='menu_title2';" onclick="showsubmenu(2)"
									onmouseout="this.className='menu_title';" background="../image/admin_title_show.gif"
									height="25"><SPAN>商品管理</SPAN>
								</td>
							</tr>
							<tr>
								<td>
									<div class="sec_menu" id="submenu2">
										<table style="POSITION: relative; TOP: 5px" cellSpacing="0" cellPadding="0" width="135"
											align="center">
											<tr>
												<td height="20"><img height="20" src="../image/bullet.gif" width="15" border="0"><A href="AddGood.aspx" target="_self">添加商品</A></td>
											</tr>
											<tr>
												<td height="20"><img height="20" src="../image/bullet.gif" width="15" border="0"><A href="GoodList.aspx" target="_self">管理商品</A></td>
											</tr>
										</table>
									</div>
								</td>
							</tr>
							<tr>
								<td height="2"></td>
							</tr>
						</table>
					</asp:Panel>
					<!--订单管理-->
					<asp:Panel id="Panel3" runat="server">
						<table cellSpacing="0" cellPadding="0" width="158" align="center">
							<tr style="CURSOR: hand">
								<td class="menu_title" id="menuTitle1" onmouseover="this.className='menu_title2';" onclick="showsubmenu(3)"
									onmouseout="this.className='menu_title';" background="../image/admin_title_show.gif"
									height="25"><SPAN>订单管理</SPAN>
								</td>
							</tr>
							<tr>
								<td>
									<div class="sec_menu" id="submenu3">
										<table style="POSITION: relative; TOP: 5px" cellSpacing="0" cellPadding="0" width="135"
											align="center">
											<tr>
												<td height="20"><img height="20" src="../image/bullet.gif" width="15" border="0"><A href="OrderList.aspx" target="_self">管理订单</A></td>
											</tr>
											<tr>
												<td height="20"><img height="20" src="../image/bullet.gif" width="15" border="0"><A href="AddOrderQA.aspx" target="_self">添加订单常见问题</A></td>
											</tr>
                                            <tr>
												<td height="20"><img height="20" src="../image/bullet.gif" width="15" border="0"><A href="OrderQAList.aspx" target="_self">管理订单常见问题</A></td>
											</tr>
										</table>
									</div>
								</td>
							</tr>
							<tr>
								<td height="2"></td>
							</tr>
						</table>
					</asp:Panel>
					<!--加盟管理-->
					<asp:Panel id="Panel4" runat="server">
						<table cellSpacing="0" cellPadding="0" width="158" align="center">
							<tr style="CURSOR: hand">
								<td class="menu_title" id="menuTitle1" onmouseover="this.className='menu_title2';" onclick="showsubmenu(4)"
									onmouseout="this.className='menu_title';" background="../image/admin_title_show.gif"
									height="25"><SPAN>加盟管理</SPAN>
								</td>
							</tr>
							<tr>
								<td>
									<div class="sec_menu" id="submenu4">
										<table style="POSITION: relative; TOP: 5px" cellSpacing="0" cellPadding="0" width="135"
											align="center">
											<tr>
												<td height="20"><img height="20" src="../image/bullet.gif" width="15" border="0"><A href="LeagueList.aspx" target="_self">管理加盟</A></td>
											</tr>
											<tr>
												<td height="20"><img height="20" src="../image/bullet.gif" width="15" border="0"><A href="AddLeagueQA.aspx" target="_self">添加加盟常见问题</A></td>
											</tr>
											<tr>
												<td height="20"><img height="20" src="../image/bullet.gif" width="15" border="0"><A href="LeagueQAList.aspx" target="_self">管理加盟常见问题</A></td>
											</tr>
											<tr>
												<td height="20"><img height="20" src="../image/bullet.gif" width="15" border="0"><A href="AddFlowerShop.aspx" target="_self">添加加盟花店</A></td>
											</tr>
											<tr>
												<td height="20"><img height="20" src="../image/bullet.gif" width="15" border="0"><A href="FlowerShopList.aspx" target="_self">管理加盟花店</A></td>
											</tr>
										</table>
									</div>
								</td>
							</tr>
							<tr>
								<td height="2"></td>
							</tr>
						</table>
					</asp:Panel>
					<!--新闻管理-->
					<asp:Panel id="Panel5" runat="server">
						<table cellSpacing="0" cellPadding="0" width="158" align="center">
							<tr style="CURSOR: hand">
								<td class="menu_title" id="td1" onmouseover="this.className='menu_title2';" onclick="showsubmenu(5)"
									onmouseout="this.className='menu_title';" background="../image/admin_title_show.gif"
									height="25"><SPAN>新闻管理</SPAN>
								</td>
							</tr>
							<tr>
								<td>
									<div class="sec_menu" id="submenu5">
										<table style="POSITION: relative; TOP: 5px" cellSpacing="0" cellPadding="0" width="135"
											align="center">
											<tr>
												<td height="20"><img height="20" src="../image/bullet.gif" width="15" border="0"><A href="AddNew.aspx" target="_self">添加新闻</A></td>
											</tr>
											<tr>
												<td height="20"><img height="20" src="../image/bullet.gif" width="15" border="0"><A href="NewList.aspx" target="_self">管理新闻</A></td>
											</tr>
										</table>
									</div>
								</td>
							</tr>
							<tr>
								<td height="2"></td>
							</tr>
						</table>
					</asp:Panel>
					<!--服务中心管理-->
					<asp:Panel id="Panel6" runat="server" Height="186px">
						<table cellSpacing="0" cellPadding="0" width="158" align="center">
							<tr style="CURSOR: hand">
								<td class="menu_title" id="td2" onmouseover="this.className='menu_title2';" onclick="showsubmenu(6)"
									onmouseout="this.className='menu_title';" background="../image/admin_title_show.gif"
									height="25"><SPAN>服务中心管理</SPAN>
								</td>
							</tr>
							<tr>
								<td>
									<div class="sec_menu" id="submenu6">
										<table style="POSITION: relative; TOP: 4px; left: -1px; height: 157px;" 
                                            cellSpacing="0" cellPadding="0" width="135"
											align="center">
											<tr>
												<td height="20"><img height="20" src="../image/bullet.gif" width="15" border="0"><A href="AddPayType.aspx" target="_self">添加付款方式</A></td>
											</tr>
											<tr>
												<td height="20"><img height="20" src="../image/bullet.gif" width="15" border="0"><A href="PayTypeList.aspx" target="_self">管理付款方式</A></td>
											</tr>
											<tr>
												<td height="20"><img height="20" src="../image/bullet.gif" width="15" border="0"><A href="AddFriendLink.aspx" target="_self">添加友情链接</A></td>
											</tr>
											<tr>
												<td height="20"><img height="20" src="../image/bullet.gif" width="15" border="0"><A href="FriendLinkList.aspx" target="_self">管理友情链接</A></td>
											</tr>
											<tr>
												<td height="20"><img height="20" src="../image/bullet.gif" width="15" border="0"><A href="EditSendRange.aspx" target="_self">管理配送范围</A></td>
											</tr>
											<tr>
												<td height="20"><img height="20" src="../image/bullet.gif" width="15" border="0"><A href="EditAfterSell.aspx" target="_self">管理售后服务</A></td>
											</tr>
											<tr>
												<td height="20"><img height="20" src="../image/bullet.gif" width="15" border="0"><A href="EditAboutUs.aspx" target="_self">管理关于我们</A></td>
											</tr>
											<tr>
												<td height="20"><img height="20" src="../image/bullet.gif" width="15" border="0"><A href="EditSendmaincity.aspx" target="_self">管理城市配送详细</A></td>
											</tr>
										</table>
									</div>
								</td>
							</tr>
							<tr>
								<td height="2"></td>
							</tr>
						</table>
					</asp:Panel>
				</td>
			</tr>
		</TBODY>
	</table>
	<br>
	<br>

</body>
