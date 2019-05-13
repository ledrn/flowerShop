using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FlowerShop.BLL;
using FlowerShop.Model;

/// <summary>
/// 功能：回复短信息
/// 时间：2008-09-28
/// </summary>
public partial class Admin_EditMessage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.QueryString["messageId"] != null && Request.QueryString["messageId"] != "")
            {
                //填充需要阅读短信息
                lblId.Text = Request.QueryString["messageId"].ToString();
                MessageInfo message = MessageManage.GetMessage(Convert.ToInt32(lblId.Text.Trim()));
                lblFromUser.Text = message.FromUser;
                lblMessage.Text = message.Message;
                lblTitle.Text = message.Title;
                lblWriteTime.Text = message.WriteTime.ToString();
                
                //更新消息为已读消息
                MessageManage.UpdateAfterRead(Convert.ToInt32(lblId.Text.Trim()));
            }
            else
            {
                Response.Redirect("NewList.aspx");
            }
        }
    }

    /// <summary>
    /// 回复此消息
    /// </summary>
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        //构造回复消息
        MessageInfo message = new MessageInfo();
        message.ToUser = lblFromUser.Text;
        message.Title = txtReTitle.Text;
        message.Message = txtReMessage.Text;
        message.FromUser = "admin";

        //回复消息，并将原有消息状态更新为“已回复”
        if (MessageManage.InsertMessage(message))
        {
            MessageManage.UpdateReSend(Convert.ToInt32(lblId.Text.Trim()));
            Response.Write("<script>alert('回复成功！');location='MessageList.aspx';</script>");
        }
        else
        {
            Response.Write("<script>alert('回复失败！');</script>");
        }
    }
}
