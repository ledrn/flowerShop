using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FlowerShop.BLL;
using FlowerShop.Model;
using System.Text.RegularExpressions;

/// <summary>
/// 功能：查看购物车并对所添加商品进行操作页面
/// 时间：2008-10-09
/// </summary>
public partial class OrderList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["buyGood"] != null)
        {
            if (!IsPostBack)
            {
                //数据绑定
                this.BindData();

                //绑定服务商品列表
                chkBoxListServiceGood.DataSource = GoodManage.GetServiceGoods();
                chkBoxListServiceGood.DataTextField = "Name";
                chkBoxListServiceGood.DataValueField = "ID";
                chkBoxListServiceGood.DataBind();
            }
        }
        else
        {
            Response.Redirect("Index.aspx");
        }
    }

    /// <summary>
    /// 绑定数据
    /// </summary>
    private void BindData()
    {
        //获取购物车中的商品
        IList<GoodGWC> goodGWCs = Session["buyGood"] as IList<GoodGWC>;

        //绑定数据列表
        gdvData.DataSource = goodGWCs;
        gdvData.DataBind();

        //计算总价
        int sum = 0;
        foreach(GoodGWC good in goodGWCs)
        {
            sum = good.SumPrice+sum;
        }

        lblAllSumPrice.Text = "合计：" + sum.ToString() + "元";

    }

    /// <summary>
    /// 更新商品数量
    /// </summary>
    protected void gdvData_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
         Regex r=new Regex("^[0-9]{1,}$");
         if (!r.IsMatch(((TextBox)gdvData.Rows[e.RowIndex].FindControl("txtNum")).Text))
         {
             ClientScript.RegisterStartupScript(this.GetType(), "", "<script >alert('请输入整数！')</script>");
         }
         else
         {
             //获取购物车中的商品
             IList<GoodGWC> goodGWCs = Session["buyGood"] as IList<GoodGWC>;

             goodGWCs[e.RowIndex].Num = Convert.ToInt32(((TextBox)gdvData.Rows[e.RowIndex].FindControl("txtNum")).Text);
             goodGWCs[e.RowIndex].SumPrice = goodGWCs[e.RowIndex].Num * goodGWCs[e.RowIndex].Price;

             Session["buyGood"] = goodGWCs;

             //数据绑定
             this.BindData();
         }
    }

    /// <summary>
    /// 删除选择商品
    /// </summary>
    protected void gdvData_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        //获取购物车中的商品
        IList<GoodGWC> goodGWCs = Session["buyGood"] as IList<GoodGWC>;
        goodGWCs.RemoveAt(e.RowIndex);

        Session["buyGood"] = goodGWCs;

        //数据绑定
        this.BindData();
    }

    /// <summary>
    /// 当列表中的项被选中的时候，添加到购物车中
    /// </summary>
    protected void chkBoxListServiceGood_SelectedIndexChanged(object sender, EventArgs e)
    {
        //获取选中项的商品信息
        GoodInfo good = new GoodInfo();
        good = GoodManage.GetGood(Convert.ToInt32(chkBoxListServiceGood.SelectedValue));

        //填充到购物车实例中
        GoodGWC goodGWC = new GoodGWC();
        goodGWC.ID = good.ID;
        goodGWC.IsSpecial = 1;
        goodGWC.Name = good.Name;
        goodGWC.Num = 1;
        goodGWC.Price = Convert.ToInt32(good.Price);
        goodGWC.SumPrice = goodGWC.Price;

        IList<GoodGWC> goodGWCs = Session["buyGood"] as IList<GoodGWC>;

        goodGWCs.Add(goodGWC);

        Session["buyGood"] = goodGWCs;

        //将选定项取消选择
        chkBoxListServiceGood.SelectedItem.Selected = false;

        //数据绑定
        this.BindData();
    }
}
