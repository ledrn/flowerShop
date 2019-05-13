using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FlowerShop.BLL;
using FlowerShop.Model;

/// <summary>
/// 功能：会员中心默认页面
/// 时间：2008-10-08
/// </summary>
public partial class UserCenterDefault : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //判断用户是否登录
        if (Session["users"] != null && Session["users"].ToString() != "")
        {
            //获取用户实例
            UserInfo userInfo = Session["users"] as UserInfo;
            lblUserName.Text = userInfo.UserName;
            //显示用户的IP地址
            lblUserIP.Text = Request.UserHostAddress;
        }
        else
        {
            Response.Redirect("UserLogin.aspx");
        }

    }
}
