using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SecurityLib;
using FlowerShop.BLL;
using FlowerShop.Model;

/// <summary>
/// 功能：更新用户密码
/// 时间：2008-09-26
/// </summary>
public partial class Admin_UpdateUserPwd : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.QueryString["userId"] != null && Request.QueryString["userId"] != "")
            {
                //根据用户编号获取用户信息
                lblUserId.Text = Request.QueryString["userId"].ToString();
                lblUserName.Text = UserManage.GetUser(Convert.ToInt32(lblUserId.Text.Trim())).UserName;

            }
            else
            {
                Response.Redirect("UserList.aspx");
            }
        }
    }

    /// <summary>
    /// 更改密码
    /// </summary>
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        UserInfo userInfo = new UserInfo();
        //密码进行MD5加密
        userInfo.UserPwd=Security.Encode(txtPwd.Text);
        userInfo.ID = Convert.ToInt32(lblUserId.Text);
        if (UserManage.UpdatePwd(userInfo))
        {
            Response.Write("<script>alert('更新成功！');location='UserList.aspx';</script>");
        }
        else
        {
            Response.Write("<script>alert('更新失败！');</script>");
        }
    }
}
