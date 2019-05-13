using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FlowerShop.BLL;
using FlowerShop.Model;

/// <summary>
/// 功能：如何付款页面
/// 时间：2008-10-06
/// </summary>
public partial class HowToPay : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataListPayType.DataSource = PayTypeManage.GetAllPayType();
        DataListPayType.DataBind();
    }
}
