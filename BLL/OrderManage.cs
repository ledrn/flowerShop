/*
 * 描述： 订单信息业务逻辑类
 * 时间： 2008年09月22日
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FlowerShop.Model;
using FlowerShop.IDAL;
using FlowerShop.DALFactory;

namespace FlowerShop.BLL
{
    public class OrderManage
    {
        private static IOrder dal = Factory.CreateOrderDAL();

        /// <summary>
        /// 自定义分页显示获取所有主订单信息，以列表形式返回
        /// </summary>
        /// <param name="pageSize">每页容量</param>
        /// <param name="currentPage">当前页码</param>
        /// <param name="orderId">按订单编号查询</param>
        /// <param name="orderState">按订单状态查询</param>
        /// <returns>主订单信息列表</returns>
        public static IList<MainOrderInfo> GetAllMainOrder(int pageSize, int currentPage,string orderId,string orderState)
        {
            try
            {
                return dal.GetAllMainOrder(pageSize, currentPage,orderId,orderState);
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

        /// <summary>
        /// 获取某个用户的所有主订单信息，以列表形式返回
        /// </summary>
        /// <param name="userId">用户编号</param>
        /// <returns>主订单信息列表</returns>
        public static IList<MainOrderInfo> GetAllMainOrderByUserId(int userId)
        {
            try
            {
                return dal.GetAllMainOrderByUserId(userId);
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

         /// <summary>
        /// 获取所有订单明细信息，以列表形式返回
        /// </summary>
        /// <param name="mainOrderId">主订单编号</param>
        /// <returns>订单明细信息列表</returns>
        public static IList<OrderDetailInfo> GetAllOrderDetailBymainOrderId(string mainOrderId)
        {
            try
            {
                return dal.GetAllOrderDetailBymainOrderId(mainOrderId);
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

        /// <summary>
        /// 根据主订单信息编号获取订单信息详细信息
        /// </summary>
        /// <param name="id">订单信息编号</param>
        /// <returns>订单信息实例</returns>
        public static MainOrderInfo GetMainOrder(string id)
        {
            try
            {
                return dal.GetMainOrder(id);
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

        /// <summary>
        /// 获取所有主订单信息数量
        /// </summary>
        /// <param name="orderId">按订单编号查询</param>
        /// <param name="orderState">按订单状态查询</param>
        /// <returns>主订单信息数量</returns>
        public static int GetAllMainOrderNum(string orderId, string orderState)
        {
            try
            {
                return dal.GetAllMainOrderNum(orderId,orderState);
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

        /// <summary>
        /// 获取相应主订单的订单明细信息数量
        /// </summary>
        /// <param name="mainOrderId">主订单编号</param>
        /// <returns>订单明细信息数量</returns>
        public static int GetOrderDetailNumByMainOrderId(string mainOrderId)
        {
            try
            {
                return dal.GetOrderDetailNumByMainOrderId(mainOrderId);
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

        /// <summary>
        /// 根据主订单编号，获取此订单的总额
        /// </summary>
        /// <param name="mainOrderId">主订单编号</param>
        /// <returns>订单总额</returns>
        public static int GetAllOrderDetailPrice(string mainOrderId)
        {
            try
            {
                return dal.GetAllOrderDetailPrice(mainOrderId);
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

        /// <summary>
        /// 添加主订单信息
        /// </summary>
        /// <param name="mainOrderInfo">主订单信息实例</param>
        /// <returns>如果添加成功，返回True，失败，返回False</returns>
        public static bool InsertMainOrder(MainOrderInfo mainOrderInfo)
        {
            try
            {
                return dal.InsertUpdateDeleteMainOrder(mainOrderInfo,"insert");
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

        /// <summary>
        /// 修改主订单信息
        /// </summary>
        /// <param name="mainOrderInfo">主订单信息实例</param>
        /// <returns>如果修改成功，返回True，失败，返回False</returns>
        public static bool UpdateMainOrder(MainOrderInfo mainOrderInfo)
        {
            try
            {
                return dal.InsertUpdateDeleteMainOrder(mainOrderInfo, "update");
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

        /// <summary>
        /// 删除主订单信息
        /// </summary>
        /// <param name="mainOrderInfo">主订单信息实例</param>
        /// <returns>如果删除成功，返回True，失败，返回False</returns>
        public static bool DeleteMainOrder(MainOrderInfo mainOrderInfo)
        {
            try
            {
                return dal.InsertUpdateDeleteMainOrder(mainOrderInfo, "delete");
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

        /// <summary>
        /// 添加订单明细信息
        /// </summary>
        /// <param name="orderDetail">订单明细信息实例</param>
        /// <returns>如果添加成功，返回True，失败，返回False</returns>
        public static bool InsertOrderDetail(OrderDetailInfo orderDetail)
        {
            try
            {
                return dal.InsertUpdateDeleteOrderDetail(orderDetail, "insert");
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

        /// <summary>
        /// 修改订单明细信息
        /// </summary>
        /// <param name="orderDetail">订单明细信息实例</param>
        /// <returns>如果修改成功，返回True，失败，返回False</returns>
        public static bool UpdateOrderDetail(OrderDetailInfo orderDetail)
        {
            try
            {
                return dal.InsertUpdateDeleteOrderDetail(orderDetail, "update");
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

        /// <summary>
        /// 删除订单明细信息
        /// </summary>
        /// <param name="orderDetail">订单明细信息实例</param>
        /// <returns>如果删除成功，返回True，失败，返回False</returns>
        public static bool DeleteOrderDetail(OrderDetailInfo orderDetail)
        {
            try
            {
                return dal.InsertUpdateDeleteOrderDetail(orderDetail, "delete");
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

        /// <summary>
        /// 生成订单编号（规则：固定前缀fs+年月日时分秒）
        /// </summary>
        /// <returns>订单编号</returns>
        public static string GetOrderID()
        {
            string orderId = "";

            orderId = "fs" + DateTime.Now.ToString("yyyyMMddhhmmss") + DateTime.Now.Millisecond;

            return orderId;
        }

        /// <summary>
        /// 根据订单编号来判断订单是否存在
        /// </summary>
        /// <param name="mainOrderId">订单编号</param>
        /// <returns>订单存在返回True；不存在返回False</returns>
        public static bool IsExistMainOrder(string mainOrderId)
        {
            try
            {
                MainOrderInfo orderInfo = new MainOrderInfo();
                orderInfo = dal.GetMainOrder(mainOrderId);
                if (orderInfo == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }
    }
}
