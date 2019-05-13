<%@ Control Language="C#" AutoEventWireup="true" CodeFile="GoodClass.ascx.cs" Inherits="GoodClass" %>

<div id="mainrightgoodclassleft"></div>
                    <div id="mainrightgoodclass">
                    <table width="237" border="0" cellspacing="0" cellpadding="0" style="text-align:left">
                        <tr>
                            <td width="237">
                                 <table width="100%" border="0" cellspacing="0" cellpadding="0">
                                    <tr>
                                        <td height="9" colspan="3"></td>
                                    </tr>
                                    <tr>
                                        <td width="8"></td>
                                        <td><img src="image/main_right_goodclass_byprice.jpg" width="157" height="30" alt="" /></td>
                                        <td width="80">&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td colspan="2">
                                        <table width="100%" border="0" cellspacing="0" cellpadding="0">
                                            <tr>
                                                <td width="41%" height="8"></td>
                                                <td width="59%" height="8"></td>
                                            </tr>
                                            <tr>
                                                <td width="41%" height="23" >&nbsp;&nbsp;<img alt="" src="image/main_right_goodclass_flag.gif" width="9" height="10" />
                                                &nbsp;<a class="agoodclass" href="FlowerList.aspx?type=price&price1=0&price2=100">100元以内</a></td>
                                                <td height="23">&nbsp;&nbsp;<img alt="" src="image/main_right_goodclass_flag.gif" width="9" height="10" />&nbsp;
                                                <a class="agoodclass" href="FlowerList.aspx?type=price&price1=100&price2=200">100元-200元</a></td>
                                          </tr>
                                          <tr>
                                            <td height="23" >&nbsp;&nbsp;<img alt="" src="image/main_right_goodclass_flag.gif" width="9" height="10" />&nbsp;
                                            <a class="agoodclass" href="FlowerList.aspx?type=price&price1=200&price2=300">200元-300元</a></td>
                                            <td height="23">&nbsp;&nbsp;<img alt="" src="image/main_right_goodclass_flag.gif" width="9" height="10" />&nbsp;
                                            <a class="agoodclass" href="FlowerList.aspx?type=price&price1=300&price2=500">300元-500元</a></td>
                                          </tr>
                                          <tr>
                                            <td>&nbsp;&nbsp;<img alt="" src="image/main_right_goodclass_flag.gif" width="9" height="10" />&nbsp;
                                            <a class="agoodclass" href="FlowerList.aspx?type=price&price1=500&price2=800">500元-800元</a></td>
                                            <td height="23" >&nbsp;&nbsp;<img alt="" src="image/main_right_goodclass_flag.gif" width="9" height="10" />&nbsp;
                                            <a class="agoodclass" href="FlowerList.aspx?type=price&price1=800&price2=-1">800元以上</a></td>
                                          </tr>
                                        </table>
                                        </td>
                                </tr>
                                </table>
                                </td>
                              </tr>
                              <tr>
                                <td width="237">
                                <table width="100%" border="0" cellspacing="0" cellpadding="0">
                                  <tr>
                                    <td height="9" colspan="3"></td>
                                  </tr>
                                  <tr>
                                    <td width="8"></td>
                                    <td><img alt="" src="image/main_right_goodclass_bydate.jpg" width="157" height="30" /></td>
                                    <td width="80">&nbsp;</td>
                                  </tr>
                                  <tr>
                                    <td>&nbsp;</td>
                                    <td colspan="2">
                                    <table width="100%" border="0" cellspacing="0" cellpadding="0">
                                        <tr>
                                          <td width="41%" height="8"></td>
                                          <td width="59%" height="8"></td>
                                        </tr>
                                        <tr>
                                          <td width="41%" height="23" >&nbsp;&nbsp;<img alt="" src="image/main_right_goodclass_flag.gif" width="9" height="10" />&nbsp;
                                          <a class="agoodclass" href='FlowerList.aspx?type=date&where=<%=Server.UrlEncode("情人节") %>'>情人节</a></td>
                                          <td height="23">&nbsp;&nbsp;<img alt="" src="image/main_right_goodclass_flag.gif" width="9" height="10" />&nbsp;
                                          <a class="agoodclass" href='FlowerList.aspx?type=date&where=<%=Server.UrlEncode("父亲节") %>'>父亲节</a></td>
                                        </tr>
                                        <tr>
                                          <td height="23">&nbsp;&nbsp;<img alt="" src="image/main_right_goodclass_flag.gif" width="9" height="10" />&nbsp;
                                          <a class="agoodclass" href='FlowerList.aspx?type=date&where=<%=Server.UrlEncode("七夕节") %>'>七夕节</a></td>
                                          <td height="23" >&nbsp;&nbsp;<img alt="" src="image/main_right_goodclass_flag.gif" width="9" height="10" />&nbsp;
                                          <a class="agoodclass" href='FlowerList.aspx?type=date&where=<%=Server.UrlEncode("中秋节") %>'>中秋节</a></td>
                                        </tr>
                                        <tr>
                                          <td height="23" >&nbsp;&nbsp;<img alt="" src="image/main_right_goodclass_flag.gif" width="9" height="10" />&nbsp;
                                          <a class="agoodclass" href='FlowerList.aspx?type=date&where=<%=Server.UrlEncode("教师节") %>'>教师节</a></td>
                                          <td height="23">&nbsp;&nbsp;<img alt="" src="image/main_right_goodclass_flag.gif" width="9" height="10" />&nbsp;
                                          <a class="agoodclass" href='FlowerList.aspx?type=date&where=<%=Server.UrlEncode("圣诞节") %>'>圣诞节</a></td>
                                        </tr>
                                        <tr>
                                          <td height="23" >&nbsp;&nbsp;<img alt="" src="image/main_right_goodclass_flag.gif" width="9" height="10" />&nbsp;
                                          <a class="agoodclass" href='FlowerList.aspx?type=date&where=<%=Server.UrlEncode("春节") %>'>春  节</a></td>
                                          <td height="23" >&nbsp;&nbsp;<img alt="" src="image/main_right_goodclass_flag.gif" width="9" height="10" />&nbsp;
                                          <a class="agoodclass" href='FlowerList.aspx?type=date&where=<%=Server.UrlEncode("母亲节") %>'>母亲节</a></td>
                                        </tr>
                                        <tr>
                                          <td height="23">&nbsp;&nbsp;<img alt="" src="image/main_right_goodclass_flag.gif" width="9" height="10" />&nbsp;
                                          <a class="agoodclass" href='FlowerList.aspx?type=date&where=<%=Server.UrlEncode("妇女节") %>'>妇女节</a></td>
                                          <td height="23" >&nbsp;&nbsp;<img alt="" src="image/main_right_goodclass_flag.gif" width="9" height="10" />&nbsp;
                                          <a class="agoodclass" href='FlowerList.aspx?type=date&where=<%=Server.UrlEncode("元旦") %>'>元  旦</a></td>
                                        </tr>
                                        <tr>
                                          <td height="23" >&nbsp;&nbsp;<img alt="" src="image/main_right_goodclass_flag.gif" width="9" height="10" />&nbsp;
                                          <a class="agoodclass" href='FlowerList.aspx?type=date&where=<%=Server.UrlEncode("国庆节") %>'>国庆节</a></td>
                                          <td height="23" >&nbsp;&nbsp;<img alt="" src="image/main_right_goodclass_flag.gif" width="9" height="10" />&nbsp;
                                          <a class="agoodclass" href='FlowerList.aspx?type=date&where=<%=Server.UrlEncode("感恩节") %>'>感恩节</a></td>
                                        </tr>
                                        
                                    </table></td>
                                  </tr>
                                </table></td>
                              </tr>
                              <tr>
                                <td width="237">
                                <table width="100%" border="0" cellspacing="0" cellpadding="0">
                                  <tr>
                                    <td height="9" colspan="3"></td>
                                  </tr>
                                  <tr>
                                    <td width="8"></td>
                                    <td><img alt="" src="image/main_right_goodclass_byusing.jpg" width="157" height="30" /></td>
                                    <td width="80">&nbsp;</td>
                                  </tr>
                                  <tr>
                                    <td>&nbsp;</td>
                                    <td colspan="2">
                                    <table width="100%" border="0" cellspacing="0" cellpadding="0">
                                        <tr>
                                          <td width="41%" height="8"></td>
                                          <td width="59%" height="8"></td>
                                        </tr>
                                        <tr>
                                          <td width="41%" height="23" >&nbsp;&nbsp;<img alt="" src="image/main_right_goodclass_flag.gif" width="9" height="10" />&nbsp;
                                          <a class="agoodclass" href='FlowerList.aspx?type=using&where=<%=Server.UrlEncode("生日送花") %>'>生日送花</a></td>
                                          <td height="23">&nbsp;&nbsp;<img alt="" src="image/main_right_goodclass_flag.gif" width="9" height="10" />&nbsp;
                                          <a class="agoodclass" href='FlowerList.aspx?type=using&where=<%=Server.UrlEncode("道歉用花") %>'>道歉用花</a></td>
                                        </tr>
                                        <tr>
                                          <td height="23">&nbsp;&nbsp;<img alt="" src="image/main_right_goodclass_flag.gif" width="9" height="10" />&nbsp;
                                          <a class="agoodclass" href='FlowerList.aspx?type=using&where=<%=Server.UrlEncode("慰问送花") %>'>慰问送花</a></td>
                                          <td height="23" >&nbsp;&nbsp;<img alt="" src="image/main_right_goodclass_flag.gif" width="9" height="10" />&nbsp;
                                          <a class="agoodclass" href='FlowerList.aspx?type=using&where=<%=Server.UrlEncode("友情送花") %>'>友情送花</a></td>
                                        </tr>
                                        <tr>
                                          <td height="23" >&nbsp;&nbsp;<img alt="" src="image/main_right_goodclass_flag.gif" width="9" height="10" />&nbsp;
                                          <a class="agoodclass" href='FlowerList.aspx?type=using&where=<%=Server.UrlEncode("祝贺送花") %>'>祝贺送花</a></td>
                                          <td height="23">&nbsp;&nbsp;<img alt="" src="image/main_right_goodclass_flag.gif" width="9" height="10" />&nbsp;
                                          <a class="agoodclass" href='FlowerList.aspx?type=using&where=<%=Server.UrlEncode("婚庆用花") %>'>婚庆用花</td>
                                        </tr>
                                        <tr>
                                          <td height="23" >&nbsp;&nbsp;<img alt="" src="image/main_right_goodclass_flag.gif" width="9" height="10" />&nbsp;
                                          <a class="agoodclass" href='FlowerList.aspx?type=using&where=<%=Server.UrlEncode("庆典花篮") %>'>庆典花篮</a></td>
                                          <td height="23" >&nbsp;&nbsp;<img alt="" src="image/main_right_goodclass_flag.gif" width="9" height="10" />&nbsp;
                                          <a class="agoodclass" href='FlowerList.aspx?type=using&where=<%=Server.UrlEncode("商务用花") %>'>商务用花</a></td>
                                        </tr>
                                        <tr>
                                          <td height="23">&nbsp;&nbsp;<img alt="" src="image/main_right_goodclass_flag.gif" width="9" height="10" />&nbsp;
                                          <a class="agoodclass" href='FlowerList.aspx?type=using&where=<%=Server.UrlEncode("祭奠鲜花") %>'>祭奠鲜花</a></td>
                                          <td height="23" >&nbsp;&nbsp;<img alt="" src="image/main_right_goodclass_flag.gif" width="9" height="10" />&nbsp;
                                          <a class="agoodclass" href='FlowerList.aspx?type=using&where=<%=Server.UrlEncode("会场布置") %>'>会场布置</a></td>
                                        </tr>
                                        <tr>
                                          <td height="23" >&nbsp;&nbsp;<img alt="" src="image/main_right_goodclass_flag.gif" width="9" height="10" />&nbsp;
                                          <a class="agoodclass" href='FlowerList.aspx?type=using&where=<%=Server.UrlEncode("爱情鲜花") %>'>爱情鲜花</a></td>
                                          <td height="23" >&nbsp;&nbsp;<img alt="" src="image/main_right_goodclass_flag.gif" width="9" height="10" />&nbsp;
                                          <a class="agoodclass" href='FlowerList.aspx?type=using&where=<%=Server.UrlEncode("乔迁之喜") %>'>乔迁之喜</td>
                                        </tr>
                                        
                                    </table></td>
                                  </tr>
                                </table></td>
                              </tr>
                              <tr>
                                <td width="237">
                                <table width="100%" border="0" cellspacing="0" cellpadding="0">
                                  <tr>
                                    <td height="9" colspan="3"></td>
                                  </tr>
                                  <tr>
                                    <td width="8"></td>
                                    <td><img alt="" src="image/main_right_goodclass_byflower.jpg" width="157" height="30" /></td>
                                    <td width="80">&nbsp;</td>
                                  </tr>
                                  <tr>
                                    <td>&nbsp;</td>
                                    <td colspan="2">
                                    <table width="100%" border="0" cellspacing="0" cellpadding="0">
                                        <tr>
                                          <td width="41%" height="8"></td>
                                          <td width="59%" height="8"></td>
                                        </tr>
                                        <tr>
                                          <td width="41%" height="23" >&nbsp;&nbsp;<img alt="" src="image/main_right_goodclass_flag.gif" width="9" height="10" />&nbsp;
                                          <a class="agoodclass" href='FlowerList.aspx?type=flower&where=<%=Server.UrlEncode("玫瑰花") %>'>玫瑰花</a></td>
                                          <td height="23">&nbsp;&nbsp;<img alt="" src="image/main_right_goodclass_flag.gif" width="9" height="10" />&nbsp;
                                          <a class="agoodclass" href='FlowerList.aspx?type=flower&where=<%=Server.UrlEncode("百合花") %>'>百合花</a></td>
                                        </tr>
                                        <tr>
                                          <td height="23" >&nbsp;&nbsp;<img alt="" src="image/main_right_goodclass_flag.gif" width="9" height="10" />&nbsp;
                                          <a class="agoodclass" href='FlowerList.aspx?type=flower&where=<%=Server.UrlEncode("康乃馨") %>'>康乃馨</a></td>
                                          <td height="23" >&nbsp;&nbsp;<img alt="" src="image/main_right_goodclass_flag.gif" width="9" height="10" />&nbsp;
                                          <a class="agoodclass" href='FlowerList.aspx?type=flower&where=<%=Server.UrlEncode("郁金香") %>'>郁金香</a></td>
                                        </tr>
                                        <tr>
                                          <td height="23" >&nbsp;&nbsp;<img alt="" src="image/main_right_goodclass_flag.gif" width="9" height="10" />&nbsp;
                                          <a class="agoodclass" href='FlowerList.aspx?type=flower&where=<%=Server.UrlEncode("扶郎花") %>'>扶郎花</a></td>
                                          <td height="23" >&nbsp;&nbsp;<img alt="" src="image/main_right_goodclass_flag.gif" width="9" height="10" />&nbsp;
                                          <a class="agoodclass" href='FlowerList.aspx?type=flower&where=<%=Server.UrlEncode("马蹄莲") %>'>马蹄莲</a></td>
                                        </tr>
                                        <tr>
                                          <td height="23" >&nbsp;&nbsp;<img alt="" src="image/main_right_goodclass_flag.gif" width="9" height="10" />&nbsp;
                                          <a class="agoodclass" href='FlowerList.aspx?type=flower&where=<%=Server.UrlEncode("花篮") %>'>花　篮</a></td>
                                          <td height="23">&nbsp;&nbsp;<img alt="" src="image/main_right_goodclass_flag.gif" width="9" height="10" />&nbsp;
                                          <a class="agoodclass" href='FlowerList.aspx?type=flower&where=<%=Server.UrlEncode("花束") %>'>花　束</a></td>
                                        </tr>
                                        <tr>
                                          <td height="23" >&nbsp;&nbsp;<img alt="" src="image/main_right_goodclass_flag.gif" width="9" height="10" />&nbsp;
                                          <a class="agoodclass" href='FlowerList.aspx?type=flower&where=<%=Server.UrlEncode("果篮") %>'>果　篮</a></td>
                                          <td height="23" >&nbsp;&nbsp;<img alt="" src="image/main_right_goodclass_flag.gif" width="9" height="10" />&nbsp;
                                          <a class="agoodclass" href='FlowerList.aspx?type=flower&where=<%=Server.UrlEncode("蓝色妖姬") %>'>蓝色妖姬</a></td>
                                        </tr>
                                        <tr>
                                          <td height="23">&nbsp;&nbsp;<img alt="" src="image/main_right_goodclass_flag.gif" width="9" height="10" />&nbsp;
                                          <a class="agoodclass" href='FlowerList.aspx?type=flower&where=<%=Server.UrlEncode("绿美人") %>'>绿美人</a></td>
                                          <td height="23">&nbsp;&nbsp;<img alt="" src="image/main_right_goodclass_flag.gif" width="9" height="10" />&nbsp;
                                          <a class="agoodclass" href='FlowerList.aspx?type=flower&where=<%=Server.UrlEncode("菊花") %>'>菊　花</a></td>
                                        </tr>
					                      <tr>
                                          <td height="23">&nbsp;&nbsp;<img alt="" src="image/main_right_goodclass_flag.gif" width="9" height="10" />&nbsp;
                                          <a class="agoodclass" href='FlowerList.aspx?type=flower&where=<%=Server.UrlEncode("瓶插花") %>'>瓶插花</a></td>
                                          <td height="23">&nbsp;&nbsp;<img alt="" src="image/main_right_goodclass_flag.gif" width="9" height="10" />&nbsp;
                                          <a class="agoodclass" href='FlowerList.aspx?type=flower&where=<%=Server.UrlEncode("组合插花") %>'>组合插花</a></td>
                                        </tr>
                                    </table></td>
                                  </tr>
                                </table></td>
                              </tr>
                              <tr>
                                <td width="237">
                                <table width="100%" border="0" cellspacing="0" cellpadding="0">
                                  <tr>
                                    <td height="9" colspan="3"></td>
                                  </tr>
                                  <tr>
                                    <td width="8"></td>
                                    <td><img alt="" src="image/main_right_goodclass_byrose.jpg" width="157" height="30" /></td>
                                    <td width="80">&nbsp;</td>
                                  </tr>
                                  <tr>
                                    <td>&nbsp;</td>
                                    <td colspan="2">
                                    <table width="100%" border="0" cellspacing="0" cellpadding="0">
                                        <tr>
                                          <td width="41%" height="8"></td>
                                          <td width="59%" height="8"></td>
                                        </tr>
                                        <tr>
                                          <td width="41%" height="23" >&nbsp;&nbsp;<img alt="" src="image/main_right_goodclass_flag.gif" width="9" height="10" />&nbsp;
                                          <a class="agoodclass" href='FlowerList.aspx?type=rose&where=<%=Server.UrlEncode("9朵玫瑰") %>'>9朵玫瑰</a></td>
                                          <td height="23">&nbsp;&nbsp;<img alt="" src="image/main_right_goodclass_flag.gif" width="9" height="10" />&nbsp;
                                          <a class="agoodclass" href='FlowerList.aspx?type=rose&where=<%=Server.UrlEncode("11朵玫瑰") %>'>11朵玫瑰</a></td>
                                        </tr>
                                        <tr>
                                          <td height="23">&nbsp;&nbsp;<img alt="" src="image/main_right_goodclass_flag.gif" width="9" height="10" />&nbsp;
                                          <a class="agoodclass" href='FlowerList.aspx?type=rose&where=<%=Server.UrlEncode("19朵玫瑰") %>'>19朵玫瑰</a></td>
                                          <td height="23">&nbsp;&nbsp;<img alt="" src="image/main_right_goodclass_flag.gif" width="9" height="10" />&nbsp;
                                          <a class="agoodclass" href='FlowerList.aspx?type=rose&where=<%=Server.UrlEncode("33朵玫瑰") %>'>33朵玫瑰</a></td>
                                        </tr>
                                        <tr>
                                          <td height="23" >&nbsp;&nbsp;<img alt="" src="image/main_right_goodclass_flag.gif" width="9" height="10" />&nbsp;
                                          <a class="agoodclass" href='FlowerList.aspx?type=rose&where=<%=Server.UrlEncode("57朵玫瑰") %>'>57朵玫瑰</a></td>
                                          <td height="23" >&nbsp;&nbsp;<img alt="" src="image/main_right_goodclass_flag.gif" width="9" height="10" />&nbsp;
                                          <a class="agoodclass" href='FlowerList.aspx?type=rose&where=<%=Server.UrlEncode("66朵玫瑰") %>'>66朵玫瑰</a></td>
                                        </tr>
                                        <tr>
                                          <td height="23">&nbsp;&nbsp;<img alt=""  src="image/main_right_goodclass_flag.gif" width="9" height="10" />&nbsp;
                                          <a class="agoodclass" href='FlowerList.aspx?type=rose&where=<%=Server.UrlEncode("99朵玫瑰") %>'>99朵玫瑰</a></td>
                                          <td height="23" >&nbsp;&nbsp;<img alt="" src="image/main_right_goodclass_flag.gif" width="9" height="10" />&nbsp;
                                          <a class="agoodclass" href='FlowerList.aspx?type=rose&where=<%=Server.UrlEncode("999朵玫瑰") %>'>999朵玫瑰</a></td>
                                        </tr>
                                    </table></td>
                                  </tr>
                                </table></td>
                              </tr>
                              <tr>
                                <td width="237">
                                <table width="100%" border="0" cellspacing="0" cellpadding="0">
                                  <tr>
                                    <td height="9" colspan="3"></td>
                                  </tr>
                                  <tr>
                                    <td width="8"></td>
                                    <td><img alt="" src="image/main_right_goodclass_byobject.jpg" width="157" height="30" /></td>
                                    <td width="80">&nbsp;</td>
                                  </tr>
                                  <tr>
                                    <td>&nbsp;</td>
                                    <td colspan="2">
                                    <table width="100%" border="0" cellspacing="0" cellpadding="0">
                                        <tr>
                                          <td width="41%" height="8"></td>
                                          <td width="59%" height="8"></td>
                                        </tr>
                                        <tr>
                                          <td width="41%" height="23" >&nbsp;&nbsp;<img alt="" src="image/main_right_goodclass_flag.gif" width="9" height="10" />&nbsp;
                                          <a class="agoodclass" href='FlowerList.aspx?type=object&where=<%=Server.UrlEncode("恋人") %>'>恋  人</a></td>
                                          <td height="23" >&nbsp;&nbsp;<img alt="" src="image/main_right_goodclass_flag.gif" width="9" height="10" />&nbsp;
                                          <a class="agoodclass" href='FlowerList.aspx?type=object&where=<%=Server.UrlEncode("朋友") %>'>朋  友</a></td>
                                        </tr>
                                        <tr>
                                          <td height="23">&nbsp;&nbsp;<img alt="" src="image/main_right_goodclass_flag.gif" width="9" height="10" />&nbsp;
                                          <a class="agoodclass" href='FlowerList.aspx?type=object&where=<%=Server.UrlEncode("父母") %>'>父  母</a></td>
                                          <td height="23" >&nbsp;&nbsp;<img alt="" src="image/main_right_goodclass_flag.gif" width="9" height="10" />&nbsp;
                                          <a class="agoodclass" href='FlowerList.aspx?type=object&where=<%=Server.UrlEncode("同事") %>'>同  事</a></td>
                                        </tr>
                                        <tr>
                                          <td height="23" >&nbsp;&nbsp;<img alt="" src="image/main_right_goodclass_flag.gif" width="9" height="10" />&nbsp;
                                          <a class="agoodclass" href='FlowerList.aspx?type=object&where=<%=Server.UrlEncode("病人") %>'>病　人</a></td>
                                          <td height="23">&nbsp;&nbsp;<img alt=""  src="image/main_right_goodclass_flag.gif" width="9" height="10" />&nbsp;
                                          <a class="agoodclass" href='FlowerList.aspx?type=object&where=<%=Server.UrlEncode("老师") %>'>老  师</a></td>
                                        </tr>
                                        <tr>
                                          <td height="23" >&nbsp;&nbsp;<img alt="" src="image/main_right_goodclass_flag.gif" width="9" height="10" />&nbsp;
                                          <a class="agoodclass" href='FlowerList.aspx?type=object&where=<%=Server.UrlEncode("婴幼儿") %>'>婴幼儿</a></td>
                                          <td height="23" >&nbsp;&nbsp;<img alt="" src="image/main_right_goodclass_flag.gif" width="9" height="10" />&nbsp;
                                          <a class="agoodclass" href='FlowerList.aspx?type=object&where=<%=Server.UrlEncode("客户") %>'>客  户</a></td>
                                        </tr>
                                    </table></td>
                                  </tr>
                                </table></td>
                              </tr>
                            </table>
                    </div>
