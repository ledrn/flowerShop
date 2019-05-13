using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FlowerShop.BLL;
using FlowerShop.Model;

/// <summary>
/// 功能：友情链接列表
/// 时间：2008-10-06
/// </summary>
public partial class FriendLink : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataListFriendLink.DataSource = FriendLinkManage.GetToShowFriendLink();
        DataListFriendLink.DataBind();
    }

    /// <summary>
    /// 数据绑定
    /// </summary>
    protected void DataListFriendLink_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        //设置显示图片的路径
        if (((Image)e.Item.FindControl("imgPic")) != null)
        {
            ((Image)e.Item.FindControl("imgPic")).ImageUrl = Request.ApplicationPath + ((Image)e.Item.FindControl("imgPic")).ImageUrl;
        }
    }
}
