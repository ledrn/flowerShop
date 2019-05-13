/*
 * 描述： 商品信息接口类
 * 时间： 2008年09月22日
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FlowerShop.Model;

namespace FlowerShop.IDAL
{
    public interface IGood
    {
        /// <summary>
        /// 自定义分页显示获取所有商品信息，以列表形式返回
        /// </summary>
        /// <param name="pageSize">每页容量</param>
        /// <param name="currentPage">当前页码</param>
        /// <param name="goodQuery">存储查询条件的商品实体</param>
        /// <returns>商品信息列表</returns>
        IList<GoodInfo> GetAllGoodByType(int pageSize, int currentPage,GoodInfo goodQuery);

        /// <summary>
        /// 根据商品信息编号获取商品信息详细信息
        /// </summary>
        /// <param name="id">商品信息编号</param>
        /// <returns>商品信息实例</returns>
        GoodInfo GetGood(int id);

        /// <summary>
        /// 获取所有商品信息数量
        /// </summary>
        /// <param name="goodQuery">存储查询条件的商品实体</param>
        /// <returns>商品信息数量</returns>
        int GetAllGoodNumByType(GoodInfo goodQuery);

        /// <summary>
        /// 根据商品名称获取商品编号
        /// </summary>
        /// <param name="name">商品名称</param>
        /// <returns>商品编号</returns>
        int GetGoodIDByName(string name);

        /// <summary>
        /// 添加、修改、删除商品信息
        /// </summary>
        /// <param name="goodInfo">商品信息实例</param>
        /// <param name="type">执行操作的类型</param>
        /// <returns>如果添加成功，返回True，失败，返回False</returns>
        bool InsertUpdateDeleteGood(GoodInfo goodInfo, string type);

        /// <summary>
        /// 根据商品编号增加卖出次数
        /// </summary>
        /// <param name="id">商品编号</param>
        void AddSellGoodTime(int id);

        /// <summary>
        /// 根据商品类型获取热销最好的4种商品
        /// </summary>
        /// <returns>热销商品列表</returns>
        IList<GoodInfo> GetGoodsBySellTime();

        /// <summary>
        /// 获取所有商品信息，以列表形式返回
        /// </summary>
        /// <param name="goodQuery">存储查询条件的商品实体</param>
        /// <returns>商品信息列表</returns>
        IList<GoodInfo> GetAllGood(GoodInfo goodQuery);
    }
}
