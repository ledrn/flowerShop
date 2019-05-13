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
/// 功能：用户信息更新页面
/// 时间：2008-10-08
/// </summary>
public partial class UserCenterUpdateUserInfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //判断用户是否登录
        if (Session["users"] != null && Session["users"].ToString() != "")
        {
            if (!IsPostBack)
            {
                //数据绑定显示
                UserDataBind();
            }
        }
        else
        {
            Response.Redirect("UserLogin.aspx");
        }
    }

    /// <summary>
    /// 数据绑定显示
    /// </summary>
    private void UserDataBind()
    {
        //根据Session获取用户实例
        //获取用户实例
        UserInfo userInfo = Session["users"] as UserInfo;
        txtUserName.Text = userInfo.UserName;
        userInfo = UserManage.GetUserByName(txtUserName.Text.Trim());
        txtAddress.Text = userInfo.Address;
        lblId.Text = userInfo.ID.ToString();
        txtAge.Text = userInfo.Age.ToString();
        txtEmail.Text = userInfo.UserEmail;
        txtMobilePhone.Text = userInfo.MobilePhone;
        txtNote.Text = userInfo.Note;
        txtPhone.Text = userInfo.Phone;
        txtPostcode.Text = userInfo.Postcode;
        txtQQ.Text = userInfo.QQ;
        txtRealName.Text = userInfo.RealName;
        rdoBtnSex.SelectedValue = userInfo.Sex;

        txtParentLocation.Text = userInfo.Provinces;
        txtChildLocation.Text = userInfo.City;
                
    }

    /// <summary>
    /// 更新用户信息
    /// </summary>
    protected void imgBtnSubmit_Click(object sender, ImageClickEventArgs e)
    {
        //获取用户修改后信息，并填充到用户实体中
        UserInfo userInfo = new UserInfo();
        userInfo.ID = Convert.ToInt32(lblId.Text.Trim());
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

        //如果选中需要修改密码复选项，则修改密码
        if (chkIsUpdatePwd.Checked == true)
        {
            userInfo.UserPwd = Security.Encode(txtUserPwd.Text);
            UserManage.UpdatePwd(userInfo);
        }

        if (UserManage.UpdateUser(userInfo))
        {
            Response.Write("<script>alert('用户信息修改成功！');location='UserCenterDefault.aspx'</script>");
        }
        else
        {
            Response.Write("<script>alert('用户信息修改不成功！');</script>");
        }
    }
}
