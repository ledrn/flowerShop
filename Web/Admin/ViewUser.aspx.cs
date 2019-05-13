using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FlowerShop.BLL;
using FlowerShop.Model;

/// <summary>
/// 功能：修改用户信息
/// 时间：2008-09-25
/// </summary>
public partial class Admin_ViewUser : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.QueryString["userId"] != null && Request.QueryString["userId"] != "")
            {
                lblUserId.Text = Request.QueryString["userId"].ToString();

                //根据编号获取用户信息
                UserInfo userInfo = UserManage.GetUser(Convert.ToInt32(lblUserId.Text.Trim()));
                //将信息显示到页面上
                lblAddress.Text = userInfo.Address;
                lblAge.Text = userInfo.Age.ToString();
                lblCity.Text = userInfo.City;
                lblEmail.Text = userInfo.UserEmail;
                lblMobilePhone.Text = userInfo.MobilePhone;
                lblPhone.Text = userInfo.Phone;
                lblPostcode.Text = userInfo.Postcode;
                lblProvinces.Text = userInfo.Provinces;
                lblQQ.Text = userInfo.QQ;
                lblRealName.Text = userInfo.RealName;
                lblSex.Text = userInfo.Sex;
                lblUserName.Text = userInfo.UserName;
                lblWriteTime.Text = userInfo.WriteTime.ToString();
                txtNote.Text = userInfo.Note;
            }
            else
            {
                Response.Redirect("UserList.aspx");
            }
        }
    }
}
