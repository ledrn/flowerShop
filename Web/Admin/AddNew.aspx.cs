using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FlowerShop.BLL;
using FlowerShop.Model;

/// <summary>
/// 功能：添加花店新闻信息
/// 时间：2008-09-26
/// </summary>
public partial class Admin_AddNew : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    /// <summary>
    /// 添加新闻到数据库中
    /// </summary>
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        NewInfo newInfo = new NewInfo();
        newInfo.Title = txtNewTitle.Text;
        newInfo.NewContent = FCKeditor1.Value;
        if (NewManage.InsertNew(newInfo))
        {
            ShowMessage("添加成功！");
            txtNewTitle.Text = "";
            FCKeditor1.Value = "";
            txtNewTitle.Focus();
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
