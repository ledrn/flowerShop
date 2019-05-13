using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FlowerShop.BLL;
using FlowerShop.Model;

/// <summary>
/// 功能：订单查询结果页面
/// 时间：2008-10-09
/// </summary>
public partial class SearchOrder : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["orderid"] != null && Request.QueryString["orderid"] != "")
        {
            //填充相应信息
            lblOrderId.Text = Request.QueryString["orderid"];
            //判断订单是否存在
            if (OrderManage.IsExistMainOrder(lblOrderId.Text.Trim()))
            {
                lblOrderState.Text = "您的订单"+OrderManage.GetMainOrder(lblOrderId.Text.Trim()).OrderState.Substring(1)+"！！";
                lblSumPrice.Text = "，应付款金额：￥" + OrderManage.GetAllOrderDetailPrice(lblOrderId.Text.Trim()).ToString();
                lblOrderId.Text = "订单号：" + lblOrderId.Text;
            }
            else
            {
                lblOrderId.Text = "您所查询的订单编号不存在！";
                lblOrderState.Text = "";
                lblSumPrice.Text = "";
            }
        }
        else
        {
            Response.Redirect("Index.aspx");
        }
    }
}
