using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FlowerShop.BLL;
using FlowerShop.Model;

/// <summary>
/// 功能：修改订单问题与解答
/// 时间：2008-09-27
/// </summary>
public partial class Admin_EditOrderQA : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.QueryString["qaId"] != null && Request.QueryString["qaId"] != "")
            {
                //填充原来问题与解答信息
                lblId.Text = Request.QueryString["qaId"].ToString();
                QuestionAnswerInfo qa = QuestionAnswerManage.GetQuestionAnswer(Convert.ToInt32(lblId.Text.Trim()));
                txtQuestion.Text = qa.Question;
                FCKeditor1.Value = qa.Answer;
            }
            else
            {
                Response.Redirect("OrderQAList.aspx");
            }
        }
    }

    /// <summary>
    /// 修改问题与解答信息
    /// </summary>
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        //填充新的问题与解答信息
        QuestionAnswerInfo qa = new QuestionAnswerInfo();
        qa.ID = Convert.ToInt32(lblId.Text.Trim());
        qa.Answer = FCKeditor1.Value;
        qa.Question = txtQuestion.Text;

        //判断是否更新成功
        if (QuestionAnswerManage.UpdateQuestionAnswer(qa))
        {
            Response.Write("<script>alert('更新成功！');location='OrderQAList.aspx';</script>");
        }
        else
        {
            Response.Write("<script>alert('更新失败！');</script>");
        }
    }
}
