using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FlowerShop.BLL;
using FlowerShop.Model;

/// <summary>
/// 功能：修改关于我们
/// 时间：2008-09-27
/// </summary>
public partial class Admin_EditAboutUs : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            FCKeditor1.Value = OtherInfoManage.GetAboutUsInfo().AboutUs;
        }
    }

    /// <summary>
    /// 更新关于我们到数据库
    /// </summary>
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        OtherInfo otherInfo = new OtherInfo();
        otherInfo.AboutUs = FCKeditor1.Value;
        if (OtherInfoManage.UpdateAboutUsInfo(otherInfo))
        {
            ShowMessage("修改成功！");
        }
        else
        {
            ShowMessage("修改失败！");
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
