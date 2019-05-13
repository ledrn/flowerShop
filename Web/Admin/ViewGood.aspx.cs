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
/// 功能：查看商品信息
/// 时间：2008-09-29
/// </summary>
public partial class Admin_ViewGood : System.Web.UI.Page
{
    //存储返回的URL
    private static string returnUrl = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.QueryString["goodId"] != null && Request.QueryString["goodId"] != "")
            {
                //填充商品信息
                lblId.Text = Request.QueryString["goodId"].ToString();
                GoodInfo good = GoodManage.GetGood(Convert.ToInt32(lblId.Text.Trim()));

                lblComponent.Text = good.Component;
                txtDescribe.Text = good.Describe;
                lblName.Text = good.Name;
                lblPackage.Text = good.Package;
                txtPrice.Text = good.Price.ToString();
                txtSellTime.Text = good.SellTime.ToString();
                lblSendRange.Text = good.SendRange;
                imgPic.ImageUrl = "~" + good.Photo;

                //设置节日类型
                SetCheckBoxListItem(cblFestivalType, good.FestivalType);
                //设置用途类型
                SetCheckBoxListItem(cblUseType, good.UseType);
                //设置花材类型
                SetCheckBoxListItem(cblFlowerMaterial, good.FlowerMaterial);
                //设置玫瑰类型
                SetCheckBoxListItem(cblRoseType, good.RoseType);
                //设置送人类型
                SetCheckBoxListItem(cblSendPerson, good.SendPerson);

                ddlGoodType.SelectedValue = good.GoodType;
                rblSpecial.SelectedValue = good.IsSpecial.ToString();

                //获取返回的URL
                returnUrl = Request.QueryString["returnUrl"].ToString();
            }
        }
    }

    /// <summary>
    /// 设置复选列表中项目的选中状态
    /// </summary>
    /// <param name="cbl">复选列表控件对象</param>
    /// <param name="itemList">列表字符串</param>
    private void SetCheckBoxListItem(CheckBoxList cbl, string itemList)
    {
        if (itemList != "")
        {
            itemList = itemList.Substring(0, itemList.Length - 1);
            //将列表字符串分割为字符串数组
            string[] items = itemList.Split(';');
            for (int i = 0; i < items.Length; i++)
            {
                cbl.Items.FindByText(items[i]).Selected = true;
            }
        }
    }

    /// <summary>
    /// 返回查看商品前的页面
    /// </summary>
    protected void btnReturn_Click(object sender, EventArgs e)
    {

        Response.Redirect(returnUrl);
    }
}
