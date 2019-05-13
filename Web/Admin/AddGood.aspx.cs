using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FlowerShop.BLL;
using FlowerShop.Model;

/// <summary>
/// 功能：添加商品
/// 时间：2008-09-28
/// </summary>
public partial class Admin_AddGood : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    /// <summary>
    /// 上传图片
    /// </summary>
    protected void btnUploadImage_Click(object sender, EventArgs e)
    {
        if (fileUploadPic.FileName != "")
        {
            //上传图片路径
            string strFilePath = Server.MapPath("~") + @"\Files\good\";
            //上传图片
            fileUploadPic.PostedFile.SaveAs(strFilePath + fileUploadPic.FileName);

            lblImageURL.Text = @"\Files\good\" + fileUploadPic.FileName;
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

    /// <summary>
    /// 添加商品
    /// </summary>
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        //填充商品信息
        GoodInfo good = new GoodInfo();
        good.Name = txtName.Text;
        good.Component = txtComponent.Text;
        good.Describe = txtDescribe.Text;
        good.GoodType = ddlGoodType.SelectedValue;
        good.IsSpecial = Convert.ToInt32(rblSpecial.SelectedValue);
        good.Package = txtPackage.Text;
        good.Photo = lblImageURL.Text;
        good.Price = Convert.ToInt32(txtPrice.Text);
        good.SellTime = 0;
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

        if (GoodManage.InsertGood(good))
        {
            ShowMessage("添加成功！");
            //清除输入的内容 
            ClearInput();
            txtName.Focus();
        }
        else
        {
            ShowMessage("添加失败！");
        }

    }

    /// <summary>
    /// 清除输入内容
    /// </summary>
    private void ClearInput()
    {
        txtName.Text = "";
        txtComponent.Text = "";
        txtDescribe.Text="";
        txtPackage.Text = "";
        lblImageURL.Text = "";
        txtPrice.Text = "0";
        txtSendRange.Text = "";
        cblFestivalType.ClearSelection();
        cblUseType.ClearSelection();
        cblFlowerMaterial.ClearSelection();
        cblRoseType.ClearSelection();
        cblSendPerson.ClearSelection();
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
}
