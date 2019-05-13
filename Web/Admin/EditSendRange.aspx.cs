using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FlowerShop.BLL;
using FlowerShop.Model;

/// <summary>
/// 功能：修改配送范围
/// 时间：2008-09-27
/// </summary>
public partial class Admin_EditSendRange : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            FCKeditor1.Value = OtherInfoManage.GetSendRangeInfo().SendRange;
        }
    }

    /// <summary>
    /// 更新配送范围到数据库
    /// </summary>
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        OtherInfo otherInfo = new OtherInfo();
        otherInfo.SendRange = FCKeditor1.Value;
        if (OtherInfoManage.UpdateSendRangeInfo(otherInfo))
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
