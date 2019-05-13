using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using FlowerShop.BLL;
using FlowerShop.Model;

/// <summary>
/// 功能：查看订单信息并更改订单状态
/// 时间：2008-09-29
/// </summary>
public partial class Admin_EditOrder : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.QueryString["orderId"] != null && Request.QueryString["orderId"] != "")
            {
                //填充原来订单信息
                lblOrderId.Text = Request.QueryString["orderId"].ToString();
                MainOrderInfo orderInfo = OrderManage.GetMainOrder(lblOrderId.Text);
                lblBuyerAddress.Text = orderInfo.BuyerAddress;
                lblBuyerEmail.Text = orderInfo.BuyerEmail;
                lblBuyerMobilePhone.Text = orderInfo.BuyerMobilePhone;
                lblBuyerName.Text = orderInfo.BuyerName;
                lblBuyerPhone.Text = orderInfo.BuyerPhone;
                lblBuyerQQ.Text = orderInfo.BuyerQQ;
                lblConsigneeAddress.Text = orderInfo.ConsigneeAddress;
                lblConsigneeArea.Text = orderInfo.ConsigneeArea;
                lblConsigneeEmail.Text = orderInfo.ConsigneeEmail;
                lblConsigneeMobilePhone.Text = orderInfo.ConsigneeMobilePhone;
                lblConsigneeName.Text = orderInfo.ConsigneeName;
                lblConsigneePhone.Text = orderInfo.ConsigneePhone;
                lblConsigneeQQ.Text = orderInfo.ConsigneeQQ;
                lblMessage.Text = orderInfo.Message;
                lblOrderState.Text = orderInfo.OrderState.Substring(1);//去掉前边的排序数字
                lblOrderTime.Text = orderInfo.OrderTime.ToString();
                lblPayType.Text = orderInfo.PayType;
                lblPenName.Text = orderInfo.PenName;
                lblSendperiodTime.Text = orderInfo.SendperiodTime;
                lblSendTime.Text = orderInfo.SendTime.ToString();
                lblSendType.Text = orderInfo.SendType;
                lblSpecialOrder.Text = orderInfo.SpecialOrder;
                if (orderInfo.UserId == 0)
                {
                    lblUserId.Text = "非会员";
                }
                else
                {
                    lblUserId.Text = orderInfo.UserId.ToString();
                }

                //绑定数据到订单明细列表
                if (OrderManage.GetOrderDetailNumByMainOrderId(lblOrderId.Text) > 0)
                {
                    gdvData.DataSource = OrderManage.GetAllOrderDetailBymainOrderId(lblOrderId.Text);
                    gdvData.DataBind();
                    //显示订单总额
                    lblSumPrice.Text = OrderManage.GetAllOrderDetailPrice(lblOrderId.Text).ToString();
                }
                else
                {
                    lblSumPrice.Text = "0";
                }
            }
            else
            {
                Response.Redirect("OrderList.aspx");
            }
        }
    }

    /// <summary>
    /// 更改订单状态为“受理中”
    /// </summary>
    protected void btnAccepting_Click(object sender, EventArgs e)
    {
        MainOrderInfo orderInfo = new MainOrderInfo();
        orderInfo.ID = lblOrderId.Text;
        orderInfo.OrderState = "1受理中";
        if (OrderManage.UpdateMainOrder(orderInfo))
        {
            ShowMessage("更改订单状态为“受理中”！");
        }
        else
        {
            ShowMessage("更改订单状态失败！");
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

    /// <summary>
    /// 更改订单状态为“已完成”
    /// </summary>
    protected void btnAccepted_Click(object sender, EventArgs e)
    {
        MainOrderInfo orderInfo = new MainOrderInfo();
        orderInfo.ID = lblOrderId.Text;
        orderInfo.OrderState = "2已完成";
        if (OrderManage.UpdateMainOrder(orderInfo))
        {
            ShowMessage("更改订单状态为“已完成”！");
        }
        else
        {
            ShowMessage("更改订单状态失败！");
        }
    }

    /// <summary>
    /// 更改订单状态为“失效”
    /// </summary>
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        MainOrderInfo orderInfo = new MainOrderInfo();
        orderInfo.ID = lblOrderId.Text;
        orderInfo.OrderState = "3失效";
        if (OrderManage.UpdateMainOrder(orderInfo))
        {
            ShowMessage("更改订单状态为“失效”！");
        }
        else
        {
            ShowMessage("更改订单状态失败！");
        }
    }

    /// <summary>
    /// 数据绑定的时候
    /// </summary>
    protected void gdvData_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        //设置绑定“查看”的PostBackURL
        if ((Button)(e.Row.Cells[5].FindControl("btnEdit")) != null)
        {
            ((Button)(e.Row.Cells[5].FindControl("btnEdit"))).PostBackUrl = "ViewGood.aspx?goodId=" + e.Row.Cells[1].Text + "&returnUrl=" + Request.CurrentExecutionFilePath + "?orderId="+lblOrderId.Text;
        }
    }
}
