using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FlowerShop.BLL;
using FlowerShop.Model;

/// <summary>
/// 功能：订单详细信息输入页面
/// 时间：2008-10-09
/// </summary>
public partial class FillOrder : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //配送范围数据绑定
            ddlSendType.DataSource = GoodManage.GetSendTypes();
            ddlSendType.DataTextField = "Name";
            ddlSendType.DataValueField = "Id";
            ddlSendType.DataBind();
            ddlSendType.SelectedIndex = 0;

            Calendar1.Text = DateTime.Now.ToShortDateString();
        }
    }

    /// <summary>
    /// 确认完成订单
    /// </summary>
    protected void imgBtnNext_Click(object sender, ImageClickEventArgs e)
    {
        //获取订单编号并放到订单实例中
        MainOrderInfo mainOrderInfo = new MainOrderInfo();
        mainOrderInfo.ID = OrderManage.GetOrderID();
        //填充其他信息到订单实例中
        mainOrderInfo.BuyerAddress = txtBuyerAddress.Text;
        mainOrderInfo.BuyerEmail = txtBuyerEmail.Text;
        mainOrderInfo.BuyerMobilePhone = txtBuyerMobilePhone.Text;
        mainOrderInfo.BuyerName = txtBuyerName.Text;
        mainOrderInfo.BuyerPhone = txtBuyerPhone.Text;
        mainOrderInfo.BuyerQQ = txtBuyerQQ.Text;
        mainOrderInfo.ConsigneeAddress = txtConsigneeAddress.Text;
        mainOrderInfo.ConsigneeArea = txtLocation.Text;
        mainOrderInfo.ConsigneeEmail = txtConsigneeEmail.Text;
        mainOrderInfo.ConsigneeMobilePhone = txtConsigneeMobilePhone.Text;
        mainOrderInfo.ConsigneeName = txtConsigneeName.Text;
        mainOrderInfo.ConsigneePhone = txtConsigneePhone.Text;
        mainOrderInfo.ConsigneeQQ = txtConsigneeQQ.Text;
        mainOrderInfo.Message = txtMessage.Text;
        mainOrderInfo.PayType = rdoBtnListPayType.SelectedValue;
        mainOrderInfo.SendperiodTime = rdoBtnSendperiodTime.SelectedValue;
        mainOrderInfo.SendTime = Convert.ToDateTime(Calendar1.Text);
        mainOrderInfo.SendType = ddlSendType.SelectedItem.Text;
        mainOrderInfo.SpecialOrder = txtSpecialOrder.Text;
        //如果是会员购买，需填写会员编号
        //判断用户是否登录
        if (Session["users"] != null && Session["users"].ToString() != "")
        {
            //获取用户实例
            UserInfo userInfo = Session["users"] as UserInfo;
            mainOrderInfo.UserId = UserManage.GetUserByName(userInfo.UserName).ID;
        }
        else
        {
            mainOrderInfo.UserId =0;
        }
        //判断是否是匿名
        if (rdoBtnPenName.SelectedValue == "匿名")
        {
            mainOrderInfo.PenName = "匿名";
        }
        else
        {
            mainOrderInfo.PenName = txtPenName.Text;
        }

        //判断是否超时
        if (Session["buyGood"] != null)
        {
            //添加订单到数据库
            if (OrderManage.InsertMainOrder(mainOrderInfo))
            {
                //添加子订单，先获取Session中的购物车列表
                //获取购物车中的商品
                IList<GoodGWC> goodGWCs = Session["buyGood"] as IList<GoodGWC>;
                OrderDetailInfo orderDetail = null;

                //添加配送方式产生的费用到购物车
                GoodGWC goodGWC = new GoodGWC();
                goodGWC.ID = Convert.ToInt32(ddlSendType.SelectedValue);
                goodGWC.IsSpecial = 2;
                goodGWC.Name = ddlSendType.SelectedItem.Text;
                goodGWC.Num = 1;
                goodGWC.Price = Convert.ToInt32(GoodManage.GetGood(goodGWC.ID).Price);
                goodGWC.SumPrice = goodGWC.Price;

                goodGWCs.Add(goodGWC);

                Session["buyGood"] = goodGWCs;

                //计算总金额
                int sum = 0;

                //循环添加子订单
                foreach (GoodGWC good in goodGWCs)
                {
                    orderDetail = new OrderDetailInfo();
                    orderDetail.GoodId = good.ID;
                    orderDetail.MainOrderId = mainOrderInfo.ID;
                    orderDetail.Num = good.Num;
                    
                    //添加到数据库中
                    OrderManage.InsertOrderDetail(orderDetail);

                    //对商品添加销售次数
                    if (good.IsSpecial == 0)
                    {
                        GoodManage.AddSellGoodTime(good.ID);
                    }

                    //计算总金额
                    sum += good.SumPrice;
                }

                Response.Redirect("SubmitOrder.aspx?orderid="+mainOrderInfo.ID+"&sumprice="+sum.ToString());
            }
            else
            {
                Response.Write("<script>alert('添加订单不成功！');</script>");
            }
        }
        else
        {
            Response.Write("<script>alert('用户操作超时，请重新选择商品！');location='Index.aspx'</script>");
        }
    }
}
