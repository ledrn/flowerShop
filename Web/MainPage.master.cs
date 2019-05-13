using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

/// <summary>
/// 功能：网站前台母版页
/// 时间：2008-10-06
/// </summary>
public partial class MainPage : System.Web.UI.MasterPage
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
            Response.Redirect("SearchOrder.aspx?orderid=" + txtSearchOrderById.Text.Trim());
        }
        else
        {
            Response.Write("<script>alert('请填写订单编号！');</script>");
        }
    }
}
