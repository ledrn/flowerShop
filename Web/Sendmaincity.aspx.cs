using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FlowerShop.BLL;
using FlowerShop.Model;

/// <summary>
/// 功能：主要城市配送详细信息页面
/// 时间：2008-10-10
/// </summary>
public partial class Sendmaincity : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblSendmaincity.Text = OtherInfoManage.GetSendmaincityInfo().Sendmaincity;
    }
}
