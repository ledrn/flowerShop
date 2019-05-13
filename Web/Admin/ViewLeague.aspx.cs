using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FlowerShop.BLL;
using FlowerShop.Model;

/// <summary>
/// 功能：查看申请加盟信息，并可审核申请加盟信息
/// 时间：2008-09-25
/// </summary>
public partial class Admin_ViewLeague : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.QueryString["leagueId"] != null && Request.QueryString["leagueId"] != "")
            {
                //填充申请加盟信息
                lblId.Text = Request.QueryString["leagueId"].ToString();

                ApplyLeagueInfo leagueInfo = ApplyLeagueManage.GetApplyLeague(Convert.ToInt32(lblId.Text.Trim()));
                lblAccountNumber.Text = leagueInfo.AccountNumber;
                lblAddress.Text = leagueInfo.Address;
                lblArea.Text = leagueInfo.Area;
                lblBank.Text = leagueInfo.Bank;
                lblEmail.Text = leagueInfo.Email;
                lblFax.Text = leagueInfo.Fax;
                lblLeagueState.Text = leagueInfo.LeagueState;
                lblMobilePhone.Text = leagueInfo.MobilePhone;
                lblName.Text = leagueInfo.Name;
                lblPayee.Text = leagueInfo.Payee;
                lblPhone.Text = leagueInfo.Phone;
                lblQQ.Text = leagueInfo.QQ;
                lblSendArea.Text = leagueInfo.SendArea;
                lblShopSummary.Text = leagueInfo.ShopSummary;
                lblTitle.Text = leagueInfo.Title;
                lblWriteTime.Text = leagueInfo.WriteTime.ToString();

                //如果审核状态为：“已完成”，则需要将审核通过按钮置为不可用状态
                if (leagueInfo.LeagueState == "已完成")
                {
                    btnApply.Enabled = false;
                }
            }
            else
            {
                Response.Redirect("LeagueList.aspx");
            }
        }
    }

    /// <summary>
    /// 审核通过申请加盟信息
    /// </summary>
    protected void btnApply_Click(object sender, EventArgs e)
    {
        ApplyLeagueInfo leagueInfo = new ApplyLeagueInfo();
        leagueInfo.ID = Convert.ToInt32(lblId.Text.Trim());
        leagueInfo.LeagueState="已完成";
        leagueInfo.Title = lblTitle.Text;
        if (ApplyLeagueManage.UpdateApplyLeague(leagueInfo))
        {
            Response.Write("<script>alert('审核成功！');location='LeagueList.aspx';</script>");
        }
        else
        {
            Response.Write("<script>alert('审核失败！');</script>");
        }
    }
}
