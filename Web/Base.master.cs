using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;

/// <summary>
/// 功能：网站前台简易母版页
/// 时间：2008-10-06
/// </summary>
public partial class Base : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    /// <summary>
    /// 按订单编号搜索
    /// </summary>
    protected void imgBtnSearch_Click(object sender, ImageClickEventArgs e)
    {
        if (txtSearchOrderById.Text != "")
        {
            Response.Redirect("SearchOrder.aspx?orderid="+txtSearchOrderById.Text.Trim());
        }
        else
        {
            Response.Write("<script>alert('请填写订单编号！');</script>");
        }
    }
}
