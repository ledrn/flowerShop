using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FlowerShop.BLL;
using FlowerShop.Model;

/// <summary>
/// 功能：网站前台首页
/// 时间：2008-10-06
/// </summary>
public partial class Index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //鲜花速递数据源绑定
        DataListFlower.DataSource = GoodManage.GetIndexFlowers();
        DataListFlower.DataBind();

        //果篮数据源绑定
        DataListFriut.DataSource = GoodManage.GetIndexFriuts();
        DataListFriut.DataBind();

        //蛋糕数据源绑定
        DataListCake.DataSource = GoodManage.GetIndexCakes();
        DataListCake.DataBind();

        //巧克力数据源绑定
        DataListChocolate.DataSource = GoodManage.GetIndexChocolates();
        DataListChocolate.DataBind();

        //花店新闻数据源绑定
        IList<FlowerShop.Model.NewInfo> news = NewManage.GetIndexNews();
        for (int i = 0; i < news.Count; i++)
        {
            //设置新闻标题的显示字数，超过需补“...”
            if (news[i].Title.Length > 17)
            {
                news[i].Title = news[i].Title.Substring(0, 17) + "...";
            }
        }
        DataListFlowerNews.DataSource = news;
        DataListFlowerNews.DataBind();

        //加盟花店数据源绑定
        IList<FlowerShopInfo> flowershops = FlowerShopManage.GetIndexFlowerShop();
        for (int i = 0; i < flowershops.Count; i++)
        {
            //设置加盟花店名称的显示字数，超过需补“...”
            if (flowershops[i].Name.Length > 25)
            {
                flowershops[i].Name = flowershops[i].Name.Substring(0, 25) + "...";
            }
        }
        DataListNewLeague.DataSource = flowershops;
        DataListNewLeague.DataBind();
    }

    /// <summary>
    /// 按订单编号搜索
    /// </summary>
    protected void imgBtnSearch_Click(object sender, ImageClickEventArgs e)
    {
        if (txtSearchOrderById.Text != "")
        {
            Response.Redirect("SearchOrder.aspx?orderid=" + txtSearchOrderById.Text.Trim());
        }
        else
        {
            Response.Write("<script>alert('请填写订单编号！');</script>");
        }
    }

    /// <summary>
    /// 鲜花速递数据绑定
    /// </summary>
    protected void DataListFlower_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        //设置显示图片的路径
        if (((Image)e.Item.FindControl("imgFlowerPic")) != null)
        {
            ((Image)e.Item.FindControl("imgFlowerPic")).ImageUrl = Request.ApplicationPath + ((Image)e.Item.FindControl("imgFlowerPic")).ImageUrl;
        }
    }

    /// <summary>
    /// 果篮数据绑定
    /// </summary>
    protected void DataListFriut_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        //设置显示图片的路径
        if (((Image)e.Item.FindControl("imgFriutPic")) != null)
        {
            ((Image)e.Item.FindControl("imgFriutPic")).ImageUrl = Request.ApplicationPath + ((Image)e.Item.FindControl("imgFriutPic")).ImageUrl;
        }
    }

    /// <summary>
    /// 蛋糕数据绑定
    /// </summary>
    protected void DataListCake_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        //设置显示图片的路径
        if (((Image)e.Item.FindControl("imgCakePic")) != null)
        {
            ((Image)e.Item.FindControl("imgCakePic")).ImageUrl = Request.ApplicationPath + ((Image)e.Item.FindControl("imgCakePic")).ImageUrl;
        }
    }

    /// <summary>
    /// 巧克力数据绑定
    /// </summary>
    protected void DataListChocolate_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        //设置显示图片的路径
        if (((Image)e.Item.FindControl("imgChocolatePic")) != null)
        {
            ((Image)e.Item.FindControl("imgChocolatePic")).ImageUrl = Request.ApplicationPath + ((Image)e.Item.FindControl("imgChocolatePic")).ImageUrl;
        }
    }

    /// <summary>
    /// 花店新闻数据绑定
    /// </summary>
    protected void DataListFlowerNews_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        if (((Label)e.Item.FindControl("lblNewTime")) != null)
        {
            ((Label)e.Item.FindControl("lblNewTime")).Text = ((Label)e.Item.FindControl("lblNewTime")).Text.Split(' ')[0];
        }
    }
}
