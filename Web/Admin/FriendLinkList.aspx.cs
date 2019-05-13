using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FlowerShop.BLL;
using FlowerShop.Model;

/// <summary>
/// 功能：友情链接列表
/// 时间：2008-09-27
/// </summary>
public partial class Admin_FriendLinkList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //数据绑定到GridView控件
            BindData();
        }
    }

    /// <summary>
    /// 绑定数据
    /// </summary>
    private void BindData()
    {
        gdvData.DataSource = FriendLinkManage.GetAllFriendLink();
        gdvData.DataBind();
    }

    /// <summary>
    /// 数据绑定的时候
    /// </summary>
    protected void gdvData_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        //设置绑定“编辑”的PostBackURL
        if ((Button)(e.Row.Cells[4].FindControl("btnEdit")) != null)
        {
            ((Button)(e.Row.Cells[4].FindControl("btnEdit"))).PostBackUrl = "EditFriendLink.aspx?friendLinkId=" + e.Row.Cells[0].Text;
        }
    }

    /// <summary>
    /// 删除表格数据时
    /// </summary>
    protected void gdvData_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        FriendLinkInfo friendLinkInfo = new FriendLinkInfo();
        friendLinkInfo.ID = Convert.ToInt32(gdvData.DataKeys[e.RowIndex].Value);

        FriendLinkManage.DeleteFriendLink(friendLinkInfo);

        BindData();
    }
}