using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FlowerShop.BLL;
using FlowerShop.Model;

/// <summary>
/// 功能：用户订单管理
/// 时间：2008-10-08
/// </summary>
public partial class UserCenterOrder : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //判断用户是否登录
        if (Session["users"] != null && Session["users"].ToString() != "")
        {
            if (!IsPostBack)
            {
                //数据绑定
                this.BindData();
            }
        }
        else
        {
            Response.Redirect("UserLogin.aspx");
        }
    }

    /// <summary>
    /// 绑定数据
    /// </summary>
    private void BindData()
    {
        //获取用户实例
        UserInfo userInfo = Session["users"] as UserInfo;

        //绑定数据列表
        gdvData.DataSource = OrderManage.GetAllMainOrderByUserId(UserManage.GetUserByName(userInfo.UserName).ID);
        gdvData.DataBind();
    }

    /// <summary>
    /// 数据绑定的时候
    /// </summary>
    protected void gdvData_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        //更改订单状态显示
        if (e.Row.RowType== DataControlRowType.DataRow)
        {
            e.Row.Cells[4].Text = e.Row.Cells[4].Text.Substring(1);

            //填充总金额
            ((Label)(e.Row.Cells[2].FindControl("lblSumPrice"))).Text = OrderManage.GetAllOrderDetailPrice(e.Row.Cells[0].Text).ToString();
        }

        //当订单状态为“已完成”时，不能够取消订单；如果订单状态为“取消”，不能够再次取消订单
        if (e.Row.Cells[4].Text == "已完成" || e.Row.Cells[4].Text == "取消")
        {
            ((ImageButton)(e.Row.Cells[5].FindControl("imgBtnDelete"))).Enabled = false;
        }
    }

    /// <summary>
    /// 取消订单数据时
    /// </summary>
    protected void gdvData_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        MainOrderInfo orderInfo = new MainOrderInfo();
        orderInfo.ID = gdvData.DataKeys[e.RowIndex].Value.ToString();

        orderInfo.OrderState = "4取消";
        OrderManage.UpdateMainOrder(orderInfo);

        //数据绑定
        this.BindData();
    }
}
