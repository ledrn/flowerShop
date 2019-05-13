using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FlowerShop.BLL;
using SecurityLib;
using FlowerShop.Model;

/// <summary>
/// 功能：用户注册页面
/// 时间：2008-10-08
/// </summary>
public partial class RegisterUser : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    /// <summary>
    /// 提交申请
    /// </summary>
    protected void imgBtnSubmit_Click(object sender, ImageClickEventArgs e)
    {
        //判断用户名是否存在
        if (UserManage.CheckUserExist(txtUserName.Text))
        {
            txtUserName.Text = "";
            Response.Write("<script>alert('用户名已存在，请选择其他用户名！');</script>");
            txtUserName.Focus();
        }
        else
        {

            //填充用户实体
            UserInfo userInfo = new UserInfo();
            userInfo.Address = txtAddress.Text;
            userInfo.Age = Convert.ToInt32(txtAge.Text);
            userInfo.City = txtChildLocation.Text;
            userInfo.IsAdmin = 0;
            userInfo.MobilePhone = txtMobilePhone.Text;
            userInfo.Note = txtNote.Text;
            userInfo.Phone = txtPhone.Text;
            userInfo.Postcode = txtPostcode.Text;
            userInfo.Provinces = txtParentLocation.Text;
            userInfo.QQ = txtQQ.Text;
            userInfo.RealName = txtRealName.Text;
            userInfo.Sex = rdoBtnSex.SelectedItem.Value;
            userInfo.UserEmail = txtEmail.Text;
            userInfo.UserName = txtUserName.Text;
            userInfo.UserPwd = Security.Encode(txtUserPwd.Text);

            if (UserManage.InsertUser(userInfo))
            {
                Session["users"] = userInfo;
                Response.Redirect("RegisterSccess.aspx");
               
            }
            else
            {
                Response.Write("<script>alert('用户申请不成功！');</script>");
            }
        }
    }

}
