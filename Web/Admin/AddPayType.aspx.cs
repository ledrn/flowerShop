using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FlowerShop.BLL;
using FlowerShop.Model;

/// <summary>
/// 功能：添加付款方式信息
/// 时间：2008-09-27
/// </summary>
public partial class Admin_AddPayType : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    /// <summary>
    /// 添加付款方式到数据库
    /// </summary>
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        PayTypeInfo payTypeInfo = new PayTypeInfo();
        payTypeInfo.Name = txtName.Text;
        payTypeInfo.PayContent = txtContent.Text;
        if(PayTypeManage.InsertPayType(payTypeInfo))
        {
            ShowMessage("添加成功！");
            txtName.Text = "";
            txtContent.Text = "";
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
