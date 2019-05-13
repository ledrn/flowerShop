using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FlowerShop.BLL;
using FlowerShop.Model;

/// <summary>
/// 功能：添加各地花店
/// 时间：2008-09-26
/// </summary>
public partial class Admin_AddFlowerShop : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    /// <summary>
    /// 添加花店
    /// </summary>
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        //填充花店名称
        FlowerShopInfo flowerShop = new FlowerShopInfo();
        flowerShop.Name = txtName.Text;

        if (FlowerShopManage.InsertFlowerShop(flowerShop))
        {
            ShowMessage("添加成功！");
            txtName.Text = "";
            txtName.Focus();
        }
        else
        {
            ShowMessage("添加失败！");
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
}
