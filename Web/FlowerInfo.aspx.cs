using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FlowerShop.BLL;
using FlowerShop.Model;

/// <summary>
/// 功能：商品详细信息
/// 时间：2008-10-07
/// </summary>
public partial class FlowerInfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.QueryString["id"] != null && Request.QueryString["id"] != "")
            {
                lblId.Text = Request.QueryString["id"];

                //根据商品编号获取商品实体
                GoodInfo good = GoodManage.GetGood(Convert.ToInt32(lblId.Text.Trim()));
                //填充信息
                lblComponent.Text = good.Component;
                lblDescribe.Text = good.Describe;
                lblName.Text = good.Name;
                lblPackage.Text = good.Package;
                lblPrice.Text = good.Price.ToString() + "元";
                lblSendRange.Text = good.SendRange;
                imgGoodPic.ImageUrl = Request.ApplicationPath + good.Photo;
            }
            else
            {
                Response.Redirect("FlowerList.aspx");
            }
        }
    }

    /// <summary>
    /// 确认添加到购物车
    /// </summary>
    protected void imgBtnSubmit_Click(object sender, ImageClickEventArgs e)
    {
        //存放新商品到购物车
        GoodGWC good = new GoodGWC();
        good.ID = Convert.ToInt32(lblId.Text.Trim());
        good.IsSpecial = 0;
        good.Name = lblName.Text;
        good.Num = 1;
        good.Price = Convert.ToInt32(lblPrice.Text.Substring(0,lblPrice.Text.IndexOf("元")));
        good.SumPrice = good.Price;

        IList<GoodGWC> goodGWCs=null;

        //添加产品到购物车，先判断购物车中是否有商品存在
        if (Session["buyGood"] != null)
        {
            goodGWCs = Session["buyGood"] as IList<GoodGWC>;
        }
        else
        {
            goodGWCs = new List<GoodGWC>();
        }

        goodGWCs.Add(good);

        Session["buyGood"] = goodGWCs;

        Response.Redirect("OrderList.aspx");
    }
}
