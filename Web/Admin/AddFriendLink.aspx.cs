using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FlowerShop.BLL;
using FlowerShop.Model;

/// <summary>
/// 功能：添加友情链接
/// 时间：2008-09-27
/// </summary>
public partial class Admin_AddFriendLink : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    /// <summary>
    /// 上传图片
    /// </summary>
    protected void btnUploadImage_Click(object sender, EventArgs e)
    {
        if (fileUploadPic.FileName != "")
        {
            //上传图片路径
            string strFilePath = Server.MapPath("~") + @"\Files\friendLink\";
            //上传图片
            fileUploadPic.PostedFile.SaveAs(strFilePath + fileUploadPic.FileName);

            lblImageURL.Text = @"\Files\friendLink\" + fileUploadPic.FileName;
        }
    }

    /// <summary>
    /// 添加友情链接到数据库
    /// </summary>
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        //填充友情链接信息
        FriendLinkInfo friendInfo = new FriendLinkInfo();
        friendInfo.Name = txtName.Text;
        friendInfo.LinkURL = txtURL.Text;
        friendInfo.ImageURL = lblImageURL.Text;

        if (FriendLinkManage.InsertFriendLink(friendInfo))
        {
            ShowMessage("添加成功！");
            txtName.Text = "";
            txtURL.Text = "Http://";
            lblImageURL.Text = "";
            txtName.Focus();
        }
        else
        {
            ShowMessage("添加失败！");
        }
    }

    /// <summary>
    /// 显示消息对话框
    /// </summary>
    /// <param name="message">消息内容</param>
    private void ShowMessage(string message)
    {
        ClientScript.RegisterStartupScript(this.GetType(), "", "<script >alert('" + message + "')</script>");
    }
}
