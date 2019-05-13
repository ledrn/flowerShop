using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using SecurityLib;
using FlowerShop.BLL;
using FlowerShop.Model;

/// <summary>
/// 功能：添加管理员
/// 时间：2008-09-23
/// </summary>
public partial class Admin_AddUser : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    /// <summary>
    /// 添加管理员
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        //判断用户是否存在，存在给出提示信息
        if (UserManage.CheckUserExist(txtUserName.Text))
        {
            txtUserName.Text = "";
            ShowMessage("用户名存在，请重新输入！");
        }
        else
        {
            //给用户实体填充信息
            UserInfo userInfo = new UserInfo();
            userInfo.UserName = txtUserName.Text;
            userInfo.UserPwd =Security.Encode(txtUserPwd.Text);
            userInfo.RealName = txtRealName.Text;
           
            //添加用户到数据库
            if (UserManage.InsertAdmin(userInfo))
            {
                //定义Membership用户
                MembershipUser newEmp = Membership.CreateUser(userInfo.UserName.Trim(), userInfo.UserPwd.Trim());
                
                //判断用户是否在角色表中出现
                if (Roles.IsUserInRole(newEmp.UserName.Trim(), "管理员"))
                {
                    throw new ArgumentException("帐号" + newEmp.UserName.Trim() + "已经存在于角色管理员中");
                }
                else
                {
                    //添加用户到角色
                    Roles.AddUserToRole(newEmp.UserName.Trim(), "管理员");
                }

                ShowMessage("添加管理员成功！");
                txtUserName.Text = "";
                txtRealName.Text = "";
            }
            else
            {
                ShowMessage("添加管理员失败！");
            }
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
