/*
 * 描述： 各地花店信息接口类
 * 时间： 2008年09月20日
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FlowerShop.Model;

namespace FlowerShop.IDAL
{
    public interface IFlowerShop
    {
        /// <summary>
        /// 自定义分页显示获取所有各地花店信息，以列表形式返回
        /// </summary>
        /// <param name="pageSize">每页容量</param>
        /// <param name="currentPage">当前页码</param>
        /// <param name="whereByName">按用户名查询条件</param>
        /// <returns>各地花店信息列表</returns>
        IList<FlowerShopInfo> GetAllFlowerShop(int pageSize, int currentPage,string whereByName);

        /// <summary>
        /// 根据各地花店信息编号获取各地花店信息详细信息
        /// </summary>
        /// <param name="id">各地花店信息编号</param>
        /// <returns>各地花店信息实例</returns>
        FlowerShopInfo GetFlowerShop(int id);

        /// <summary>
        /// 获取所有各地花店信息数量
        /// </summary>
        /// <param name="whereByName">按用户名查询条件</param>
        /// <returns>各地花店信息数量</returns>
        int GetAllFlowerShopNum(string whereByName);

        /// <summary>
        /// 添加、修改、删除各地花店信息
        /// </summary>
        /// <param name="flowerShop">各地花店信息实例</param>
        /// <param name="type">执行操作的类型</param>
        /// <returns>如果添加成功，返回True，失败，返回False</returns>
        bool InsertUpdateDeleteFlowerShop(FlowerShopInfo flowerShop, string type);
    }
}
