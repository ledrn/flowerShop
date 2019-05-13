using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FlowerShop.BLL;
using FlowerShop.Model;

/// <summary>
/// 功能：修改城市配送详细信息
/// 时间：2008-10-10
/// </summary>
public partial class Admin_EditSendmaincity : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            FCKeditor1.Value = OtherInfoManage.GetSendmaincityInfo().Sendmaincity;
        }
    }

    /// <summary>
    /// 更新城市配送详细信息到数据库
    /// </summary>
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        OtherInfo otherInfo = new OtherInfo();
        otherInfo.Sendmaincity = FCKeditor1.Value;
        if (OtherInfoManage.UpdateSendmaincityInfo(otherInfo))
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
