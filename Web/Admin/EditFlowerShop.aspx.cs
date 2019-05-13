using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FlowerShop.BLL;
using FlowerShop.Model;

/// <summary>
/// 功能：更新花店名称
/// 时间：2008-09-26
/// </summary>
public partial class Admin_EditFlowerShop : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.QueryString["flowerShopId"] != null && Request.QueryString["flowerShopId"] != "")
            {
                //填充原来新闻信息
                lblFlowerShopId.Text = Request.QueryString["flowerShopId"].ToString();
                txtName.Text = FlowerShopManage.GetFlowerShop(Convert.ToInt32(lblFlowerShopId.Text.Trim())).Name;
            }
            else
            {
                Response.Redirect("FlowerShopList.aspx");
            }
        }
    }

    /// <summary>
    /// 更新花店名称
    /// </summary>
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        //填充新的各地花店信息
        FlowerShopInfo flowerInfo = new FlowerShopInfo();
        flowerInfo.ID = Convert.ToInt32(lblFlowerShopId.Text.Trim());
        flowerInfo.Name = txtName.Text;

        //判断是否更新成功
        if (FlowerShopManage.UpdateFlowerShop(flowerInfo))
        {
            Response.Write("<script>alert('更新成功！');location='FlowerShopList.aspx';</script>");
        }
        else
        {
            Response.Write("<script>alert('更新失败！');</script>");
        }
    }
}
