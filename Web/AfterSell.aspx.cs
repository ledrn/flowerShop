using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FlowerShop.BLL;
using FlowerShop.Model;

/// <summary>
/// 功能：售后服务页面
/// 时间：2008-10-10
/// </summary>
public partial class AfterSell : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblAfterSell.Text = OtherInfoManage.GetAfterSellInfo().AfterSell;
    }
}
