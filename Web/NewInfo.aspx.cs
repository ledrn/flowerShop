using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FlowerShop.BLL;
using FlowerShop.Model;

/// <summary>
/// 功能：花店新闻详细信息页面
/// 时间：2008-10-12
/// </summary>
public partial class NewInfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["id"] != null && Request.QueryString["id"] != "")
        {
            if (!IsPostBack)
            {
                //根据新闻编号获取新闻详细信息
                FlowerShop.Model.NewInfo newInfo = NewManage.GetNew(Convert.ToInt32(Request.QueryString["id"]));
                lbltitle.Text = newInfo.Title;
                lblContent.Text = newInfo.NewContent;
                lblTime.Text = newInfo.WriteTime.ToString().Split(' ')[0];
            }
        }
    }
}
