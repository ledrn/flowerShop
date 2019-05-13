using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FlowerShop.BLL;
using FlowerShop.Model;

/// <summary>
/// 功能：更新商品信息
/// 时间：2008-09-28
/// </summary>
public partial class Admin_EditGood : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.QueryString["goodId"] != null && Request.QueryString["goodId"] != "")
            {
                //填充原来商品信息
                lblId.Text = Request.QueryString["goodId"].ToString();
                GoodInfo good = GoodManage.GetGood(Convert.ToInt32(lblId.Text.Trim()));

                txtComponent.Text = good.Component;
                txtDescribe.Text = good.Describe;
                txtName.Text = good.Name;
                txtPackage.Text = good.Package;
                txtPrice.Text = good.Price.ToString();
                txtSellTime.Text = good.SellTime.ToString();
                txtSendRange.Text = good.SendRange;
                lblImageURL.Text = good.Photo;

                //设置节日类型
                SetCheckBoxListItem(cblFestivalType,good.FestivalType);
                //设置用途类型
                SetCheckBoxListItem(cblUseType,good.UseType);
                //设置花材类型
                SetCheckBoxListItem(cblFlowerMaterial,good.FlowerMaterial);
                //设置玫瑰类型
                SetCheckBoxListItem(cblRoseType,good.RoseType);
                //设置送人类型
                SetCheckBoxListItem(cblSendPerson,good.SendPerson);

                ddlGoodType.SelectedValue = good.GoodType;
                rblSpecial.SelectedValue = good.IsSpecial.ToString();
            }
            else
            {
                Response.Redirect("GoodList.aspx");
            }
        }
    }

    /// <summary>
    /// 上传图片
    /// </summary>
    protected void btnUploadImage_Click(object sender, EventArgs e)
    {
        //上传图片路径
        string strFilePath = Server.MapPath("~") + @"\Files\good\";
        //上传图片
        fileUploadPic.PostedFile.SaveAs(strFilePath + fileUploadPic.FileName);

        lblImageURL.Text = @"\Files\good\" + fileUploadPic.FileName;
    }

    /// <summary>
    /// 更新商品信息到数据库
    /// </summary>
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        //填充商品信息
        GoodInfo good = new GoodInfo();
        good.ID = Convert.ToInt32(lblId.Text.Trim());
        good.Name = txtName.Text;
        good.Component = txtComponent.Text;
        good.Describe = txtDescribe.Text;
        good.GoodType = ddlGoodType.SelectedValue;
        good.IsSpecial = Convert.ToInt32(rblSpecial.SelectedValue);
        good.Package = txtPackage.Text;
        good.Photo = lblImageURL.Text;
        good.Price = Convert.ToInt32(txtPrice.Text);
        good.SellTime = Convert.ToInt32(txtSellTime.Text);
        good.SendRange = txtSendRange.Text;

        //设置节日类型
        good.FestivalType = GetCheckBoxListItem(cblFestivalType);
        //设置用途类型
        good.UseType = GetCheckBoxListItem(cblUseType);
        //设置花材类型
        good.FlowerMaterial = GetCheckBoxListItem(cblFlowerMaterial);
        //设置玫瑰类型
        good.RoseType = GetCheckBoxListItem(cblRoseType);
        //设置送人类型
        good.SendPerson = GetCheckBoxListItem(cblSendPerson);

        //判断是否更新成功
        if (GoodManage.UpdateGood(good))
        {
            Response.Write("<script>alert('更新成功！');location='GoodList.aspx';</script>");
        }
        else
        {
            Response.Write("<script>alert('更新失败！');</script>");
        }
    }

    /// <summary>
    /// 获取复选列表中选中项目的列表
    /// </summary>
    /// <param name="cbl">复选列表控件对象</param>
    /// <returns>选中项目列表</returns>
    private string GetCheckBoxListItem(CheckBoxList cbl)
    {
        string strItems = "";
        for (int i = 0; i < cbl.Items.Count; i++)
        {
            if (cbl.Items[i].Selected == true)
            {
                strItems += cbl.Items[i].Text + ";";
            }
        }
        return strItems;
    }

    /// <summary>
    /// 设置复选列表中项目的选中状态
    /// </summary>
    /// <param name="cbl">复选列表控件对象</param>
    /// <param name="itemList">列表字符串</param>
    private void SetCheckBoxListItem(CheckBoxList cbl, string itemList)
    {
        if (itemList != "")
        {
            itemList = itemList.Substring(0, itemList.Length - 1);
            //将列表字符串分割为字符串数组
            string[] items = itemList.Split(';');
            for (int i = 0; i < items.Length; i++)
            {
                cbl.Items.FindByText(items[i]).Selected = true;
            }
        }
    }
}
