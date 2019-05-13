using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FlowerShop.BLL;
using FlowerShop.Model;

/// <summary>
/// 功能：添加订单常见问题
/// 时间：2008-09-27
/// </summary>
public partial class Admin_AddOrderQA : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

     /// <summary>
    /// 添加加盟信息到数据库
    /// </summary>
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        QuestionAnswerInfo qaInfo = new QuestionAnswerInfo();
        qaInfo.Question = txtQuestion.Text;
        qaInfo.Answer = FCKeditor1.Value;
        qaInfo.QuestionType = "订单常见问题";
       
        if (QuestionAnswerManage.InsertQuestionAnswer(qaInfo))
        {
            ShowMessage("添加成功！");
            txtQuestion.Text = "";
            FCKeditor1.Value = "";
            txtQuestion.Focus();
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