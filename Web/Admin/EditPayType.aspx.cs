using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FlowerShop.BLL;
using FlowerShop.Model;

/// <summary>
/// 功能：更新付款方式信息
/// 时间：2008-09-27
/// </summary>
public partial class Admin_EditPayType : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.QueryString["payTypeId"] != null && Request.QueryString["payTypeId"] != "")
            {
                //填充原来付款方式信息
                lblId.Text = Request.QueryString["payTypeId"].ToString();
                PayTypeInfo payTypeInfo = PayTypeManage.GetPayType(Convert.ToInt32(lblId.Text.Trim()));
                txtContent.Text = payTypeInfo.PayContent;
                txtName.Text = payTypeInfo.Name;
            }
            else
            {
                Response.Redirect("PayTypeList.aspx");
            }
        }
    }

    /// <summary>
    /// 修改付款方式到数据库
    /// </summary>
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        //填充新的付款方式信息
        PayTypeInfo payTypeInfo = new PayTypeInfo();
        payTypeInfo.ID = Convert.ToInt32(lblId.Text.Trim());
        payTypeInfo.Name = txtName.Text;
        payTypeInfo.PayContent = txtContent.Text;

        //判断是否更新成功
        if (PayTypeManage.UpdatePayType(payTypeInfo))
        {
            Response.Write("<script>alert('更新成功！');location='PayTypeList.aspx';</script>");
        }
        else
        {
            Response.Write("<script>alert('更新失败！');</script>");
        }
    }
}
