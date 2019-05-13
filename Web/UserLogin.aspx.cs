using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FlowerShop.BLL;
using FlowerShop.Model;
using SecurityLib;

/// <summary>
/// 功能：用户登录页面
/// 时间：2008-10-08
/// </summary>
public partial class UserLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["users"] != null && Session["users"].ToString() != "")
        {
            //如果用户登录状态有效，直接转到会员中心
            Response.Redirect("UserCenterDefault.aspx");
        }
    }

    /// <summary>
    /// 验证用户合法后，转到会员中心
    /// </summary>
    protected void imgBtnSubmit_Click(object sender, ImageClickEventArgs e)
    {
        //填充用户信息实体
        UserInfo userInfo = new UserInfo();
        userInfo.UserName = txtUserName.Text;
        userInfo.UserPwd = Security.Encode(txtUserPwd.Text);

        if (UserManage.CheckUser(userInfo))
        {
            //验证用户合法后，转到会员中心
            Session["users"] = userInfo;
            Response.Redirect("UserCenterDefault.aspx");
        }
        else
        {
            ClientScript.RegisterStartupScript(this.GetType(), "", "<script >alert('用户名或密码无效，请重新输入！')</script>");
        }
    }
}
