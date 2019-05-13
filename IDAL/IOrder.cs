/*
 * 描述： 订单信息接口类
 * 时间： 2008年09月22日
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FlowerShop.Model;

namespace FlowerShop.IDAL
{
    public interface IOrder
    {
        /// <summary>
        /// 自定义分页显示获取所有主订单信息，以列表形式返回
        /// </summary>
        /// <param name="pageSize">每页容量</param>
        /// <param name="currentPage">当前页码</param>
        /// <param name="orderId">按订单编号查询</param>
        /// <param name="orderState">按订单状态查询</param>
        /// <returns>主订单信息列表</returns>
        IList<MainOrderInfo> GetAllMainOrder(int pageSize, int currentPage,string orderId,string orderState);

        /// <summary>
        /// 获取所有订单明细信息，以列表形式返回
        /// </summary>
        /// <param name="mainOrderId">主订单编号</param>
        /// <returns>订单明细信息列表</returns>
        IList<OrderDetailInfo> GetAllOrderDetailBymainOrderId(string mainOrderId);

        /// <summary>
        /// 获取某个用户的所有主订单信息，以列表形式返回
        /// </summary>
        /// <param name="userId">用户编号</param>
        /// <returns>主订单信息列表</returns>
        IList<MainOrderInfo> GetAllMainOrderByUserId(int userId);

        /// <summary>
        /// 根据主订单信息编号获取订单信息详细信息
        /// </summary>
        /// <param name="id">订单信息编号</param>
        /// <returns>订单信息实例</returns>
        MainOrderInfo GetMainOrder(string id);

        /// <summary>
        /// 获取所有主订单信息数量
        /// </summary>
        /// <param name="orderId">按订单编号查询</param>
        /// <param name="orderState">按订单状态查询</param>
        /// <returns>主订单信息数量</returns>
        int GetAllMainOrderNum(string orderId,string orderState);

        /// <summary>
        /// 获取相应主订单的订单明细信息数量
        /// </summary>
        /// <param name="mainOrderId">主订单编号</param>
        /// <returns>订单明细信息数量</returns>
        int GetOrderDetailNumByMainOrderId(string mainOrderId);

        /// <summary>
        /// 添加、修改、删除主订单信息
        /// </summary>
        /// <param name="mainOrderInfo">主订单信息实例</param>
        /// <param name="type">执行操作的类型</param>
        /// <returns>如果添加成功，返回True，失败，返回False</returns>
        bool InsertUpdateDeleteMainOrder(MainOrderInfo mainOrderInfo, string type);

        /// <summary>
        /// 添加、修改、删除订单明细信息
        /// </summary>
        /// <param name="orderDetail">订单明细信息实例</param>
        /// <param name="type">执行操作的类型</param>
        /// <returns>如果添加成功，返回True，失败，返回False</returns>
        bool InsertUpdateDeleteOrderDetail(OrderDetailInfo orderDetail, string type);

        /// <summary>
        /// 根据主订单编号，获取此订单的总额
        /// </summary>
        /// <param name="mainOrderId">主订单编号</param>
        /// <returns>订单总额</returns>
        int GetAllOrderDetailPrice(string mainOrderId);
    }
}
