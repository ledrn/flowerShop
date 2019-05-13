using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FlowerShop.BLL;
using FlowerShop.Model;

/// <summary>
/// 功能：用户发消息
/// 时间：2008-10-08
/// </summary>
public partial class UserCenterSendMessage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //判断用户是否登录
        if (Session["users"] == null || Session["users"].ToString() == "")
        {
           Response.Redirect("UserLogin.aspx");
        }
    }

    /// <summary>
    /// 用户向管理员发消息
    /// </summary>
    protected void imgBtnSubmit_Click(object sender, ImageClickEventArgs e)
    {
        //消息实体
        MessageInfo message = new MessageInfo();
        message.Title = txtMessageTitle.Text;
        message.Message = txtMessageContent.Text;
        message.ToUser = "admin";
        message.FromUser = (Session["users"] as UserInfo).UserName;

        if (MessageManage.InsertMessage(message))
        {
            txtMessageContent.Text = "";
            txtMessageTitle.Text = "";
            Response.Write("<script>alert('消息发送成功！');</script>");
        }
        else
        {
            Response.Write("<script>alert('消息发送不成功！');</script>");
        }
    }
}
