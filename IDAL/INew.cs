/*
 * 描述： 新闻信息接口类
 * 时间： 2008年09月19日
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FlowerShop.Model;

namespace FlowerShop.IDAL
{
    public interface INew
    {
        /// <summary>
        /// 自定义分页获取所有新闻列表
        /// </summary>
        /// <param name="pageSize">每页容量</param>
        /// <param name="currentPage">当前页码</param>
        /// <param name="whereByTitle">按标题查询条件</param>
        /// <returns>新闻列表</returns>
        IList<NewInfo> GetAllNews(int pageSize, int currentPage, string whereByTitle);

        /// <summary>
        /// 根据新闻编号获取新闻实体
        /// </summary>
        /// <param name="id">新闻信息编号</param>
        /// <returns>新闻实体</returns>
        NewInfo GetNew(int id);

        /// <summary>
        /// 添加、修改、删除新闻
        /// </summary>
        /// <param name="newInfo">新闻实体</param>
        /// <param name="type">执行操作的类型</param>
        /// <returns>如果成功，返回TRUE，失败，返回False</returns>
        bool InsertUpdateDelNew(NewInfo newInfo,string type);

        /// <summary>
        /// 获取新闻总数
        /// </summary>
        /// <param name="whereByTitle">按标题查询条件</param>
        /// <returns>新闻总数</returns>
        int GetAllNewsNum(string whereByTitle);
    }
}
