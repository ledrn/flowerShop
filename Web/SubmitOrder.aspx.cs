using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FlowerShop.BLL;
using FlowerShop.Model;

/// <summary>
/// 功能：订单完成页面
/// 时间：2008-10-10
/// </summary>
public partial class SubmitOrder : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["orderid"] != null && Request.QueryString["orderid"] != "" 
            && Request.QueryString["sumprice"] != null && Request.QueryString["sumprice"] !="")
        {
            lblOrderId.Text = Request.QueryString["orderid"];
            lblSumPrice.Text = Request.QueryString["sumprice"];
            //清除缓存中的订单信息
            Session["buyGood"] = null;
        }
        else
        {
            Response.Redirect("Index.aspx");
        }
    }
}
