﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FlowerShop.BLL;
using FlowerShop.Model;

/// <summary>
/// 功能：网站前台美味蛋糕列表页
/// 时间：2008-10-10
/// </summary>
public partial class CakeList : System.Web.UI.Page
{
    //设置每页显示条目数
    private int pageSize = 21;
    //定义几个保存分页参数变量
    private int pageCount, recCount, currentPage, pages, jumpPage;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            GoodInfo goodQuery = new GoodInfo();
            goodQuery.IsSpecial = 0;
            goodQuery.GoodType = "蛋糕";

            //获取总记录数
            recCount = GoodManage.GetAllGoodNumByType(goodQuery);
            //初始状态下
            ViewState["Query"] = goodQuery;

            //参数初始化
            InitParameter();

            this.BindData();
        }
    }

    /// <summary>
    /// 鲜花速递数据绑定
    /// </summary>
    protected void DataListFlower_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        //设置显示图片的路径
        if (((Image)e.Item.FindControl("imgFlowerPic")) != null)
        {
            ((Image)e.Item.FindControl("imgFlowerPic")).ImageUrl = Request.ApplicationPath + ((Image)e.Item.FindControl("imgFlowerPic")).ImageUrl;
        }
    }

    /// <summary>
    /// 用到的参数初始化
    /// </summary>
    private void InitParameter()
    {
        //计算总页数
        pageCount = recCount / pageSize + OverPage();

        //保存总页参数到ViewState
        ViewState["PageCounts"] = recCount / pageSize - ModPage();
        //保存一个为0的页面索引值到ViewState
        ViewState["PageIndex"] = 0;
        //保存PageCount到ViewState，跳页时判断用户输入数是否超出页码范围
        ViewState["JumpPages"] = pageCount;
        //显示LPageCount、LRecordCount的状态
        this.lbPageCount.Text = pageCount.ToString();

        //判断跳页文本框失效
        if (recCount <= 20)
            tbGogoPage.Enabled = false;
        else
            tbGogoPage.Enabled = true;
    }

    /// <summary>
    /// 绑定数据
    /// </summary>
    private void BindData()
    {
        GoodInfo query = ViewState["Query"] as GoodInfo;
        //从ViewState中读取页码值保存到CurrentPage变量中进行按钮失效运算
        currentPage = (int)ViewState["PageIndex"];
        //从ViewState中读取总页参数进行按钮失效运算
        pages = (int)ViewState["PageCounts"];
        //判断四个按钮（首页、上一页、下一页、尾页）状态
        if (currentPage + 1 > 1)
        {
            lbtnFirstpage.Enabled = true;
            lbtnPrevpage.Enabled = true;
        }
        else
        {
            lbtnFirstpage.Enabled = false;
            lbtnPrevpage.Enabled = false;
        }
        if (currentPage == pages)
        {
            lbtnNextpage.Enabled = false;
            lbtnLastpage.Enabled = false;
        }
        else
        {
            lbtnNextpage.Enabled = true;
            lbtnLastpage.Enabled = true;
        }

        //数据绑定到DataListFlower控件
        DataListFlower.DataSource = GoodManage.GetAllGoodByType(pageSize, currentPage, query);

        DataListFlower.DataBind();

        //显示Label控件LCurrentPaget和文本框控件gotoPage状态
        lbCurrentPage.Text = (currentPage + 1).ToString();
        tbGogoPage.Text = (currentPage + 1).ToString();
    }

    /// <summary>
    /// 计算余页
    /// </summary>
    /// <returns></returns>
    public int OverPage()
    {
        int pages = 0;
        if (recCount % pageSize != 0)
            pages = 1;
        else
            pages = 0;
        return pages;
    }

    /// <summary>
    /// 计算余页，防止SQL语句执行时溢出查询范围
    /// </summary>
    public int ModPage()
    {
        int pages = 0;
        if (recCount % pageSize == 0 && recCount != 0)
            pages = 1;
        else
            pages = 0;
        return pages;
    }

    /// <summary>
    /// 对四个按钮（首页、上一页、下一页、尾页）返回的CommandName值进行操作
    /// </summary>
    protected void Page_OnClick(object sender, CommandEventArgs e)
    {
        //从ViewState中读取页码值保存到CurrentPage变量中进行参数运算
        currentPage = (int)ViewState["PageIndex"];
        //从ViewState中读取总页参数运算
        pages = (int)ViewState["PageCounts"];

        string cmd = e.CommandName;
        switch (cmd)//筛选CommandName
        {
            case "next":
                currentPage++;
                break;
            case "prev":
                currentPage--;
                break;
            case "last":
                currentPage = pages;
                break;
            default:
                currentPage = 0;
                break;
        }
        //将运算后的CurrentPage变量再次保存至ViewState
        ViewState["PageIndex"] = currentPage;
        //调用数据绑定函数BindData()
        BindData();
    }

    /// <summary>
    /// 跳页代码
    /// </summary>
    protected void tbGogoPage_TextChanged(object sender, EventArgs e)
    {
        //从ViewState中读取可用页数值保存到JumpPage变量中
        jumpPage = (int)ViewState["JumpPages"];
        //判断用户输入值是否超过可用页数范围值
        if (Int32.Parse(tbGogoPage.Text) > jumpPage || Int32.Parse(tbGogoPage.Text) <= 0)
        {
        }
        else
        {
            //转换用户输入值保存在int型InputPage变量中
            int InputPage = Int32.Parse(tbGogoPage.Text.ToString()) - 1;
            //写入InputPage值到ViewState["PageIndex"]中
            ViewState["PageIndex"] = InputPage;
            //调用数据绑定函数BindData()再次进行数据绑定运算
            BindData();
        }
    }
}
