using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

/// <summary>
/// 功能：会员中心左侧导航
/// 时间：2008-10-08
/// </summary>
public partial class UserCenterLeft : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    /// <summary>
    /// 退出登录
    /// </summary>
    protected void ImageButton6_Click(object sender, ImageClickEventArgs e)
    {
        Session["users"] = null;
        Response.Redirect("UserLogin.aspx");
    }
}
