using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FlowerShop.BLL;
using FlowerShop.Model;

/// <summary>
/// 功能：更新新闻信息
/// 时间：2008-09-26
/// </summary>
public partial class Admin_EditNew : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.QueryString["newId"] != null && Request.QueryString["newId"] != "")
            {
                //填充原来新闻信息
                lblNewId.Text = Request.QueryString["newId"].ToString();
                NewInfo newInfo = NewManage.GetNew(Convert.ToInt32(lblNewId.Text.Trim()));
                txtNewTitle.Text = newInfo.Title;
                FCKeditor1.Value = newInfo.NewContent;
                lblWriteTime.Text = newInfo.WriteTime.ToString();
            }
            else
            {
                Response.Redirect("NewList.aspx");
            }
        }
    }

    /// <summary>
    /// 更新新闻信息到数据库
    /// </summary>
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        //填充新的新闻信息
        NewInfo newInfo = new NewInfo();
        newInfo.ID = Convert.ToInt32(lblNewId.Text.Trim());
        newInfo.Title = txtNewTitle.Text;
        newInfo.NewContent = FCKeditor1.Value;

        //判断是否更新成功
        if (NewManage.UpdateNew(newInfo))
        {
            Response.Write("<script>alert('更新成功！');location='NewList.aspx';</script>");
        }
        else
        {
            Response.Write("<script>alert('更新失败！');</script>");
        }
    }
}
