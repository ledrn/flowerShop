using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FlowerShop.BLL;
using FlowerShop.Model;

/// <summary>
/// 功能：修改管理员信息
/// 时间：2008-09-25
/// </summary>
public partial class Admin_EditAdmin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.QueryString["userId"] != null && Request.QueryString["userId"] != "")
            {
                lblUserId.Text = Request.QueryString["userId"].ToString();
                UserInfo userInfo = UserManage.GetUser(Convert.ToInt32(lblUserId.Text));
                //显示管理员信息
                if (userInfo != null)
                {
                    lblUserName.Text = userInfo.UserName;
                    txtRealName.Text = userInfo.RealName;
                }

                ViewState["user"] = userInfo;
            }
            else
            {
                Response.Redirect("UserList.aspx");
            }
        }
    }

    /// <summary>
    /// 更新管理员真实姓名
    /// </summary>
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        UserInfo userInfo = ViewState["user"] as UserInfo;
        if (userInfo != null)
        {
            userInfo.RealName = txtRealName.Text;
            if (UserManage.UpdateUser(userInfo))
            {
                Response.Write("<script>alert('更新成功！');location='UserList.aspx';</script>");
            }
            else
            {
                Response.Write("<script>alert('更新失败！');</script>");
            }
        }
    }
}
