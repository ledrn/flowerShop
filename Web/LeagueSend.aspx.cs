using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FlowerShop.BLL;
using FlowerShop.Model;

/// <summary>
/// 功能：加盟添加页面
/// 时间：2008-10-08
/// </summary>
public partial class LeagueSend : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    /// <summary>
    /// 提交加盟申请
    /// </summary>
    protected void imgBtnSubmit_Click(object sender, ImageClickEventArgs e)
    {
        //填充加盟信息实体
        ApplyLeagueInfo leagueInfo = new ApplyLeagueInfo();
        leagueInfo.AccountNumber = txtAccountNumber.Text ;
        leagueInfo.Address = txtAddress.Text;
        leagueInfo.Area = txtLocation.Text;
        leagueInfo.Bank = txtBank.Text;
        leagueInfo.Email = txtEmail.Text;
        leagueInfo.Fax = txtFax.Text;
        leagueInfo.MobilePhone = txtMobilePhone.Text;
        leagueInfo.Name = txtName.Text;
        leagueInfo.Payee = txtPayee.Text;
        leagueInfo.Phone = txtPhone.Text;
        leagueInfo.QQ = txtQQ.Text;
        leagueInfo.SendArea = txtSendArea.Text;
        leagueInfo.ShopSummary = txtShopSummary.Text;
        leagueInfo.Title = txtTitle.Text;

        if (ApplyLeagueManage.InsertApplyLeague(leagueInfo))
        {
            Response.Redirect("LeagueSendSccess.aspx");
        }
        else
        {
            Response.Write("<script>alert('加盟申请不成功！');</script>");
        }
    }
}
