/*
 * 描述： 订单信息数据访问类
 * 时间： 2008年09月22日
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using FlowerShop.IDAL;
using FlowerShop.Model;

namespace FlowerShop.SQLServerDAL
{
    public class OrderDAL:IOrder
    {
        /// <summary>
        /// 自定义分页显示获取所有主订单信息，以列表形式返回
        /// </summary>
        /// <param name="pageSize">每页容量</param>
        /// <param name="currentPage">当前页码</param>
        /// <param name="orderId">按订单编号查询</param>
        /// <param name="orderState">按订单状态查询</param>
        /// <returns>主订单信息列表</returns>
        public IList<MainOrderInfo> GetAllMainOrder(int pageSize, int currentPage,string orderId,string orderState)
        {
            //存储SQL语句
            string strSql;

            IList<MainOrderInfo> mainOrderInfos = new List<MainOrderInfo>();

            if (orderId == null || orderId == "")
            {
                orderId = " 1=1 ";
            }
            else
            {
                orderId = " id ='" + orderId + "' ";
            }

            if (orderState == null || orderState == "")
            {
                orderId += " and 1=1 ";
            }
            else
            {
                orderId += " and orderState = '" + orderState + "' ";
            }

            try
            {
                if (currentPage <= 0)
                {
                    strSql = "select top " + pageSize + " * from fs_mainOrder where "+orderId+" order by orderState,ID desc";
                }
                else
                {
                    strSql = "select top " + pageSize + " * from fs_mainOrder where "+orderId+" and ID not in(select top " + pageSize * currentPage + " ID from fs_mainOrder where "+orderId+" order by orderState,ID desc) order by orderState,ID desc";
                }

                //调用访问数据的方法
                Database db = BaseDAL.GetDatabase();
                DbCommand comm = db.GetSqlStringCommand(strSql);
                using (IDataReader reader = db.ExecuteReader(comm))
                {

                    MainOrderInfo mainOrderInfo = null;

                    //获取具体的主订单信息，并将其添加到列表中
                    while (reader.Read())
                    {
                        mainOrderInfo = GetMainOrderFormDataReader(reader);

                        mainOrderInfos.Add(mainOrderInfo);
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception("执行SQL语句时出现问题" + e.Message);
            }
            return mainOrderInfos;
        }

        /// <summary>
        /// 获取某个用户的所有主订单信息，以列表形式返回
        /// </summary>
        /// <param name="userId">用户编号</param>
        /// <returns>主订单信息列表</returns>
        public IList<MainOrderInfo> GetAllMainOrderByUserId(int userId)
        {
            //存储SQL语句
            string strSql;

            IList<MainOrderInfo> mainOrderInfos = new List<MainOrderInfo>();

            try
            {
                strSql = "select * from fs_mainOrder where userId="+userId+" ";

                //调用访问数据的方法
                Database db = BaseDAL.GetDatabase();
                DbCommand comm = db.GetSqlStringCommand(strSql);
                using (IDataReader reader = db.ExecuteReader(comm))
                {

                    MainOrderInfo mainOrderInfo = null;

                    //获取具体的主订单信息，并将其添加到列表中
                    while (reader.Read())
                    {
                        mainOrderInfo = GetMainOrderFormDataReader(reader);

                        mainOrderInfos.Add(mainOrderInfo);
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception("执行SQL语句时出现问题" + e.Message);
            }
            return mainOrderInfos;
        }

        /// <summary>
        /// 获取所有订单明细信息，以列表形式返回
        /// </summary>
        /// <param name="mainOrderId">主订单编号</param>
        /// <returns>订单明细信息列表</returns>
        public IList<OrderDetailInfo> GetAllOrderDetailBymainOrderId(string mainOrderId)
        {
            //存储SQL语句
            string strSql;

            IList<OrderDetailInfo> orderDetailInfos = new List<OrderDetailInfo>();

            try
            {
                strSql = "select fs_orderDetail.id,name,mainOrderId,fs_orderDetail.goodId,num,price from fs_orderDetail,fs_goods "
                    + "where fs_orderDetail.goodId=fs_goods.id and mainOrderId=@mainOrderId";
 
                Database db = BaseDAL.GetDatabase();
                DbCommand comm = db.GetSqlStringCommand(strSql);

                //添加参数
                db.AddInParameter(comm, "mainOrderId", DbType.String, mainOrderId);

                //调用数据访问的方法
                using (IDataReader reader = db.ExecuteReader(comm))
                {

                    OrderDetailInfo orderDetailInfo = null;

                    //获取具体的订单明细信息，并将其添加到列表中
                    while (reader.Read())
                    {
                        orderDetailInfo = GetOrderDetailFormDataReader(reader);

                        orderDetailInfos.Add(orderDetailInfo);
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception("执行SQL语句时出现问题" + e.Message);
            }
            return orderDetailInfos;
        }

        /// <summary>
        /// 根据主订单信息编号获取订单信息详细信息
        /// </summary>
        /// <param name="id">订单信息编号</param>
        /// <returns>订单信息实例</returns>
        public MainOrderInfo GetMainOrder(string id)
        {
            //存储SQL语句
            string strSql;

            try
            {
                strSql = "select * from fs_mainOrder where id=@id";

                Database db = BaseDAL.GetDatabase();
                DbCommand comm = db.GetSqlStringCommand(strSql);

                //添加参数
                db.AddInParameter(comm, "id", DbType.String, id);

                MainOrderInfo mainOrderInfo = null;
                
                //调用数据访问的方法
                using (IDataReader reader = db.ExecuteReader(comm))
                {
                    //获取具体的主订单信息
                    while (reader.Read())
                    {
                        mainOrderInfo = GetMainOrderFormDataReader(reader);
                    }
                }

                return mainOrderInfo;
            }
            catch (Exception e)
            {
                throw new Exception("执行SQL语句时出现问题" + e.Message);
            }
        }

        /// <summary>
        /// 获取所有主订单信息数量
        /// </summary>
        /// <param name="orderId">按订单编号查询</param>
        /// <param name="orderState">按订单状态查询</param>
        /// <returns>主订单信息数量</returns>
        public int GetAllMainOrderNum(string orderId, string orderState)
        {
            //存储SQL语句
            string strSql = "";

            if (orderId == null || orderId == "")
            {
                orderId = " 1=1 ";
            }
            else
            {
                orderId = " id ='" + orderId + "' ";
            }

            if (orderState == null || orderState == "")
            {
                orderId += " and 1=1 ";
            }
            else
            {
                orderId += " and orderState = '" + orderState + "' ";
            }

            try
            {
                strSql = "select count(*) from fs_mainOrder where "+orderId;

                //调用数据访问的方法,并返回主订单信息总数
                Database db = BaseDAL.GetDatabase();
                DbCommand comm = db.GetSqlStringCommand(strSql);

                return Convert.ToInt32(db.ExecuteScalar(comm));
            }
            catch (Exception e)
            {
                throw new Exception("执行SQL语句时出现问题" + e.Message);
            }
        }

        /// <summary>
        /// 根据主订单编号，获取此订单的总额
        /// </summary>
        /// <param name="mainOrderId">主订单编号</param>
        /// <returns>订单总额</returns>
        public int GetAllOrderDetailPrice(string mainOrderId)
        {
            //存储SQL语句
            string strSql = "";

            try
            {
                strSql = "select sum(price*num) from fs_orderDetail,fs_goods "
                    + "where fs_orderDetail.goodId=fs_goods.id and mainOrderId=@mainOrderId";

                Database db = BaseDAL.GetDatabase();
                DbCommand comm = db.GetSqlStringCommand(strSql);

                //添加参数
                db.AddInParameter(comm, "mainOrderId", DbType.String, mainOrderId);

                //调用数据访问的方法,并返回订单总额
                return Convert.ToInt32(db.ExecuteScalar(comm));
            }
            catch (Exception e)
            {
                throw new Exception("执行SQL语句时出现问题" + e.Message);
            }
        }

        /// <summary>
        /// 获取相应主订单的订单明细信息数量
        /// </summary>
        /// <param name="mainOrderId">主订单编号</param>
        /// <returns>订单明细信息数量</returns>
        public int GetOrderDetailNumByMainOrderId(string mainOrderId)
        {
            //存储SQL语句
            string strSql = "";

            try
            {
                strSql = "select count(*) from fs_orderDetail where mainOrderId=@mainOrderId";

                Database db = BaseDAL.GetDatabase();
                DbCommand comm = db.GetSqlStringCommand(strSql);

                //添加参数
                db.AddInParameter(comm, "mainOrderId", DbType.String, mainOrderId);

                //调用数据访问的方法,并返回订单明细数量
                return Convert.ToInt32(db.ExecuteScalar(comm));
            }
            catch (Exception e)
            {
                throw new Exception("执行SQL语句时出现问题" + e.Message);
            }
        }

        /// <summary>
        /// 添加、修改、删除主订单信息
        /// </summary>
        /// <param name="mainOrderInfo">主订单信息实例</param>
        /// <param name="type">执行操作的类型</param>
        /// <returns>如果添加成功，返回True，失败，返回False</returns>
        public bool InsertUpdateDeleteMainOrder(MainOrderInfo mainOrderInfo, string type)
        {
            //存储SQL语句
            string strSql = "";

            //存储判断是否执行成功
            int lineNum = 0;

            try
            {
                Database db = BaseDAL.GetDatabase();
                DbCommand comm = null;

                switch (type)
                {
                    //插入操作
                    case "insert":
                        strSql = "insert into fs_mainOrder values(@id,@orderState,@orderTime,@sendType,@payType,"
                            + "@sendTime,@sendperiodTime,@specialOrder,@message,@penName,@buyerName,"
                            + "@buyerPhone,@buyerMobilePhone,@buyerQQ,@buyerEmail,@buyerAddress,@consigneeName,"
                            + "@consigneePhone,@consigneeMobilePhone,@consigneeQQ,@consigneeEmail,"
                            + "@consigneeAddress,@consigneeArea,@userId)";
                        comm = db.GetSqlStringCommand(strSql);
                        db.AddInParameter(comm, "sendType", DbType.String, mainOrderInfo.SendType);
                        db.AddInParameter(comm, "orderState", DbType.String, "0待处理");
                        db.AddInParameter(comm, "orderTime", DbType.DateTime, DateTime.Now);
                        db.AddInParameter(comm, "payType", DbType.String, mainOrderInfo.PayType);
                        db.AddInParameter(comm, "sendTime", DbType.DateTime, mainOrderInfo.SendTime);
                        db.AddInParameter(comm, "sendperiodTime", DbType.String, mainOrderInfo.SendperiodTime);
                        db.AddInParameter(comm, "specialOrder", DbType.String, mainOrderInfo.SpecialOrder);
                        db.AddInParameter(comm, "message", DbType.String, mainOrderInfo.Message);
                        db.AddInParameter(comm, "penName", DbType.String, mainOrderInfo.PenName);
                        db.AddInParameter(comm, "buyerName", DbType.String, mainOrderInfo.BuyerName);
                        db.AddInParameter(comm, "buyerPhone", DbType.String, mainOrderInfo.BuyerPhone);
                        db.AddInParameter(comm, "buyerMobilePhone", DbType.String, mainOrderInfo.BuyerMobilePhone);
                        db.AddInParameter(comm, "buyerQQ", DbType.String, mainOrderInfo.BuyerQQ);
                        db.AddInParameter(comm, "buyerEmail", DbType.String, mainOrderInfo.BuyerEmail);
                        db.AddInParameter(comm, "buyerAddress", DbType.String, mainOrderInfo.BuyerAddress);
                        db.AddInParameter(comm, "consigneeName", DbType.String, mainOrderInfo.ConsigneeName);
                        db.AddInParameter(comm, "consigneePhone", DbType.String, mainOrderInfo.ConsigneePhone);
                        db.AddInParameter(comm, "consigneeMobilePhone", DbType.String, mainOrderInfo.ConsigneeMobilePhone);
                        db.AddInParameter(comm, "consigneeQQ", DbType.String, mainOrderInfo.ConsigneeQQ);
                        db.AddInParameter(comm, "consigneeEmail", DbType.String, mainOrderInfo.ConsigneeEmail);
                        db.AddInParameter(comm, "consigneeAddress", DbType.String, mainOrderInfo.ConsigneeAddress);
                        db.AddInParameter(comm, "consigneeArea", DbType.String, mainOrderInfo.ConsigneeArea);
                        db.AddInParameter(comm, "userId", DbType.Int32, mainOrderInfo.UserId);
                        db.AddInParameter(comm, "Id", DbType.String, mainOrderInfo.ID);

                        break;
                    //更新操作
                    case "update":

                        strSql = "update fs_mainOrder set orderState=@orderState where id=@id";
                        comm = db.GetSqlStringCommand(strSql);
                        db.AddInParameter(comm, "Id", DbType.String, mainOrderInfo.ID);
                        db.AddInParameter(comm, "orderState", DbType.String, mainOrderInfo.OrderState);

                        break;
                    //删除操作
                    case "delete":
                        strSql = "delete from fs_mainOrder where id=@id";
                        comm = db.GetSqlStringCommand(strSql);
                        db.AddInParameter(comm, "Id", DbType.String, mainOrderInfo.ID);

                        break;
                }

                //调用数据访问的方法
                lineNum = db.ExecuteNonQuery(comm);

                //判断执行是否成功
                if (lineNum > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                throw new Exception("执行SQL语句时出现问题" + e.Message);
            }
        }

        /// <summary>
        /// 添加、修改、删除订单明细信息
        /// </summary>
        /// <param name="orderDetail">订单明细信息实例</param>
        /// <param name="type">执行操作的类型</param>
        /// <returns>如果添加成功，返回True，失败，返回False</returns>
        public bool InsertUpdateDeleteOrderDetail(OrderDetailInfo orderDetail, string type)
        {
            //存储SQL语句
            string strSql = "";

            //存储判断是否执行成功
            int lineNum = 0;

            try
            {
                Database db = BaseDAL.GetDatabase();
                DbCommand comm = null;

                switch (type)
                {
                    //插入操作
                    case "insert":
                        strSql = "insert into fs_orderDetail values(@mainOrderId,@goodId,@num)";
                        comm = db.GetSqlStringCommand(strSql);
                        db.AddInParameter(comm, "mainOrderId", DbType.String, orderDetail.MainOrderId);
                        db.AddInParameter(comm, "goodId", DbType.Int32, orderDetail.GoodId);
                        db.AddInParameter(comm, "num", DbType.Int32, orderDetail.Num);

                        break;
                    //更新操作
                    case "update":
                        strSql = "update fs_orderDetail set num=@num where id=@id";
                        comm = db.GetSqlStringCommand(strSql);
                        db.AddInParameter(comm, "num", DbType.Int32, orderDetail.Num);
                        db.AddInParameter(comm, "Id", DbType.Int32, orderDetail.ID);

                        break;
                    //删除操作
                    case "delete":
                        strSql = "delete from fs_orderDetail where mainOrderId=@mainOrderId";
                        comm = db.GetSqlStringCommand(strSql);
                        db.AddInParameter(comm, "mainOrderId", DbType.String, orderDetail.MainOrderId);

                        break;
                }
                //调用数据访问的方法
                lineNum = db.ExecuteNonQuery(comm);

                //判断执行是否成功
                if (lineNum > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                throw new Exception("执行SQL语句时出现问题" + e.Message);
            }
        }

        /// <summary>
        /// 从IDataReader中取出主订单信息，并返回主订单信息实体
        /// </summary>
        /// <param name="reader">IDataReader实例</param>
        /// <returns>主订单信息实体</returns>
        private MainOrderInfo GetMainOrderFormDataReader(IDataReader reader)
        {
            MainOrderInfo mainOrderInfo = new MainOrderInfo();

            try
            {
                mainOrderInfo.ID = BaseDAL.GetSafeString(reader["id"]);
                mainOrderInfo.BuyerAddress = BaseDAL.GetSafeString(reader["buyerAddress"]);
                mainOrderInfo.BuyerEmail = BaseDAL.GetSafeString(reader["buyerEmail"]);
                mainOrderInfo.BuyerMobilePhone = BaseDAL.GetSafeString(reader["buyerMobilePhone"]);
                mainOrderInfo.BuyerName = BaseDAL.GetSafeString(reader["buyerName"]);
                mainOrderInfo.BuyerPhone = BaseDAL.GetSafeString(reader["buyerPhone"]);
                mainOrderInfo.BuyerQQ = BaseDAL.GetSafeString(reader["buyerQQ"]);
                mainOrderInfo.ConsigneeAddress = BaseDAL.GetSafeString(reader["consigneeAddress"]);
                mainOrderInfo.ConsigneeArea = BaseDAL.GetSafeString(reader["consigneeArea"]);
                mainOrderInfo.ConsigneeEmail = BaseDAL.GetSafeString(reader["consigneeEmail"]);
                mainOrderInfo.ConsigneeMobilePhone = BaseDAL.GetSafeString(reader["consigneeMobilePhone"]);
                mainOrderInfo.ConsigneeName = BaseDAL.GetSafeString(reader["consigneeName"]);
                mainOrderInfo.ConsigneePhone = BaseDAL.GetSafeString(reader["consigneePhone"]);
                mainOrderInfo.ConsigneeQQ = BaseDAL.GetSafeString(reader["consigneeQQ"]);
                mainOrderInfo.Message = BaseDAL.GetSafeString(reader["message"]);
                mainOrderInfo.OrderState = BaseDAL.GetSafeString(reader["orderState"]);
                mainOrderInfo.OrderTime = BaseDAL.GetSafeDateTime(reader["orderTime"]);
                mainOrderInfo.PayType = BaseDAL.GetSafeString(reader["payType"]);
                mainOrderInfo.PenName = BaseDAL.GetSafeString(reader["penName"]);
                mainOrderInfo.SendperiodTime = BaseDAL.GetSafeString(reader["sendperiodTime"]);
                mainOrderInfo.SendTime = BaseDAL.GetSafeDateTime(reader["sendTime"]);
                mainOrderInfo.SendType = BaseDAL.GetSafeString(reader["sendType"]);
                mainOrderInfo.SpecialOrder = BaseDAL.GetSafeString(reader["specialOrder"]);
                mainOrderInfo.UserId = BaseDAL.GetSafeInt(reader["userId"]);
            }
            catch (Exception er)
            {
                throw er;
            }
            return mainOrderInfo;
        }

        /// <summary>
        /// 从IDataReader中取出订单明细信息，并返回订单明细信息实体
        /// </summary>
        /// <param name="reader">IDataReader实例</param>
        /// <returns>订单明细信息实体</returns>
        private OrderDetailInfo GetOrderDetailFormDataReader(IDataReader reader)
        {
            OrderDetailInfo orderDetailInfo = new OrderDetailInfo();

            try
            {
                orderDetailInfo.ID = BaseDAL.GetSafeInt(reader["id"]);
                orderDetailInfo.GoodId = BaseDAL.GetSafeInt(reader["goodId"]);
                orderDetailInfo.GoodName = BaseDAL.GetSafeString(reader["name"]);
                orderDetailInfo.MainOrderId = BaseDAL.GetSafeString(reader["mainOrderId"]);
                orderDetailInfo.Num = BaseDAL.GetSafeInt(reader["num"]);
                orderDetailInfo.Price = BaseDAL.GetSafeInt(reader["price"]);
               
            }
            catch (Exception er)
            {
                throw er;
            }
            return orderDetailInfo;
        }
    }
}
