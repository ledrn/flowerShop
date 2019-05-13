using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FlowerShop.BLL;
using FlowerShop.Model;

/// <summary>
/// 功能：更新友情链接
/// 时间：2008-09-27
/// </summary>
public partial class Admin_EditFriendLink : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.QueryString["friendLinkId"] != null && Request.QueryString["friendLinkId"] != "")
            {
                //填充原来友情链接信息
                lblId.Text = Request.QueryString["friendLinkId"].ToString();
                FriendLinkInfo friendLinkInfo = FriendLinkManage.GetFriendLink(Convert.ToInt32(lblId.Text.Trim()));
                txtName.Text = friendLinkInfo.Name;
                lblImageURL.Text = friendLinkInfo.ImageURL;
                txtURL.Text = friendLinkInfo.LinkURL;
            }
            else
            {
                Response.Redirect("FriendLinkList.aspx");
            }
        }
    }

    /// <summary>
    /// 上传图片
    /// </summary>
    protected void btnUploadImage_Click(object sender, EventArgs e)
    {
        //上传图片路径
        string strFilePath = Server.MapPath("~") + @"\Files\friendLink\";
        //上传图片
        fileUploadPic.PostedFile.SaveAs(strFilePath + fileUploadPic.FileName);

        lblImageURL.Text = @"\Files\friendLink\" + fileUploadPic.FileName;
    }

    /// <summary>
    /// 更新友情链接信息
    /// </summary>
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        //填充新的友情链接信息
        FriendLinkInfo friendLinkInfo = new FriendLinkInfo();
        friendLinkInfo.ID = Convert.ToInt32(lblId.Text.Trim());
        friendLinkInfo.Name = txtName.Text;
        friendLinkInfo.LinkURL = txtURL.Text;
        friendLinkInfo.ImageURL = lblImageURL.Text;

        //判断是否更新成功
        if (FriendLinkManage.UpdateFriendLink(friendLinkInfo))
        {
            Response.Write("<script>alert('更新成功！');location='FriendLinkList.aspx';</script>");
        }
        else
        {
            Response.Write("<script>alert('更新失败！');</script>");
        }
    }
}
