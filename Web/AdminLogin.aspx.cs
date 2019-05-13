using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.Security;
using System.Web.UI.WebControls;
using FlowerShop.BLL;
using FlowerShop.Model;
using SecurityLib;

/// <summary>
/// 功能：管理员登录页面
/// 时间：2008-10-13
/// </summary>
public partial class AdminLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    /// <summary>
    /// 登录到后台
    /// </summary>
    protected void btnLogin_Click(object sender, ImageClickEventArgs e)
    {
        //验证验证码
        if (Session["CheckCode"] != null)
        {
            if (!Session["CheckCode"].ToString().Trim().Equals(txtCheckCode.Text.Trim()))
            {
                txtCheckCode.Text = "";
                Response.Write("<script>alert('验证码错误，请重新输入！')</script>");
                return;
            }
            else
            {
                //判断是否是合法用户
                UserInfo userInfo = new UserInfo();
                userInfo.UserName = txtUserName.Text;
                userInfo.UserPwd = Security.Encode(txtPwd.Text);
                if (UserManage.CheckAdmin(userInfo))
                {
                    //获取登录用户的角色
                    string deptRole = (Roles.GetRolesForUser(userInfo.UserName))[0];
                    if (deptRole == "管理员")
                    {
                        FormsAuthentication.SetAuthCookie(userInfo.UserName, true);
                        //FormsAuthentication.RedirectFromLoginPage(userInfo.UserName, true);
                        Response.Redirect("Admin/Default.aspx");
                    }
                    else
                    {
                        Response.Write("<script>alert('您没有管理员权限，请重新输入！')</script>");
                        return;
                    }
                }
                else
                {
                    Response.Write("<script>alert('用户名或密码错误，请重新输入！')</script>");
                    return;
                }
            }
        }
    }
}
