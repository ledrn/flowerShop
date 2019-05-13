/*
 * 描述： 商品信息业务逻辑类
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
    public class GoodManage
    {
        private static IGood dal = Factory.CreateGoodDAL();

        /// <summary>
        /// 自定义分页显示获取所有商品信息，以列表形式返回
        /// </summary>
        /// <param name="pageSize">每页容量</param>
        /// <param name="currentPage">当前页码</param>
        /// <param name="goodQuery">存储查询条件的商品实体</param>
        /// <returns>商品信息列表</returns>
        public static IList<GoodInfo> GetAllGoodByType(int pageSize, int currentPage, GoodInfo goodQuery)
        {
            try
            {
                return dal.GetAllGoodByType(pageSize,currentPage,goodQuery);
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

        /// <summary>
        /// 获取服务商品列表
        /// </summary>
        /// <returns>商品信息列表</returns>
        public static IList<GoodInfo> GetServiceGoods()
        {
            int pageSize = 0;
            try
            {
                GoodInfo goodQuery = new GoodInfo();
                goodQuery.IsSpecial=1;
                pageSize = dal.GetAllGoodNumByType(goodQuery);
                return dal.GetAllGoodByType(pageSize, 0, goodQuery);
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

        /// <summary>
        /// 获取配送范围列表
        /// </summary>
        /// <returns>配送范围信息列表</returns>
        public static IList<GoodInfo> GetSendTypes()
        {
            int pageSize = 0;
            try
            {
                GoodInfo goodQuery = new GoodInfo();
                goodQuery.IsSpecial = 2;
                pageSize = dal.GetAllGoodNumByType(goodQuery);
                return dal.GetAllGoodByType(pageSize, 0, goodQuery);
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

        /// <summary>
        /// 获取在首页显示的鲜花列表12个
        /// </summary>
        /// <returns>鲜花列表</returns>
        public static IList<GoodInfo> GetIndexFlowers()
        {
            try
            {
                GoodInfo goodQuery = new GoodInfo();
                goodQuery.GoodType = "鲜花";
                goodQuery.IsSpecial = 0;
                return dal.GetAllGoodByType(12, 0, goodQuery);
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

        /// <summary>
        /// 获取在首页显示的水果列表5个
        /// </summary>
        /// <returns>水果列表</returns>
        public static IList<GoodInfo> GetIndexFriuts()
        {
            try
            {
                GoodInfo goodQuery = new GoodInfo();
                goodQuery.GoodType = "果篮";
                goodQuery.IsSpecial = 0;
                return dal.GetAllGoodByType(5, 0, goodQuery);
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

        /// <summary>
        /// 获取在首页显示的蛋糕列表5个
        /// </summary>
        /// <returns>蛋糕列表</returns>
        public static IList<GoodInfo> GetIndexCakes()
        {
            try
            {
                GoodInfo goodQuery = new GoodInfo();
                goodQuery.GoodType = "蛋糕";
                goodQuery.IsSpecial = 0;
                return dal.GetAllGoodByType(5, 0, goodQuery);
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

        /// <summary>
        /// 获取在首页显示的巧克力列表5个
        /// </summary>
        /// <returns>巧克力列表</returns>
        public static IList<GoodInfo> GetIndexChocolates()
        {
            try
            {
                GoodInfo goodQuery = new GoodInfo();
                goodQuery.GoodType = "巧克力";
                goodQuery.IsSpecial = 0;
                return dal.GetAllGoodByType(5, 0, goodQuery);
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

        /// <summary>
        /// 根据商品信息编号获取商品信息详细信息
        /// </summary>
        /// <param name="id">商品信息编号</param>
        /// <returns>商品信息实例</returns>
        public static GoodInfo GetGood(int id)
        {
            try
            {
                return dal.GetGood(id);
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

        /// <summary>
        /// 获取所有商品信息数量
        /// </summary>
        /// <param name="goodQuery">存储查询条件的商品实体</param>
        /// <returns>商品信息数量</returns>
        public static int GetAllGoodNumByType(GoodInfo goodQuery)
        {
            try
            {
                return dal.GetAllGoodNumByType(goodQuery);
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

        /// <summary>
        /// 添加商品信息
        /// </summary>
        /// <param name="goodInfo">商品信息实例</param>
        /// <returns>如果添加成功，返回True，失败，返回False</returns>
        public static bool InsertGood(GoodInfo goodInfo)
        {
            try
            {
                return dal.InsertUpdateDeleteGood(goodInfo,"insert");
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

        /// <summary>
        /// 修改商品信息
        /// </summary>
        /// <param name="goodInfo">商品信息实例</param>
        /// <returns>如果修改成功，返回True，失败，返回False</returns>
        public static bool UpdateGood(GoodInfo goodInfo)
        {
            try
            {
                return dal.InsertUpdateDeleteGood(goodInfo, "update");
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

        /// <summary>
        /// 删除商品信息
        /// </summary>
        /// <param name="goodInfo">商品信息实例</param>
        /// <returns>如果删除成功，返回True，失败，返回False</returns>
        public static bool DeleteGood(GoodInfo goodInfo)
        {
            try
            {
                return dal.InsertUpdateDeleteGood(goodInfo, "delete");
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

        /// <summary>
        /// 根据商品编号增加卖出次数
        /// </summary>
        /// <param name="id">商品编号</param>
        public static void AddSellGoodTime(int id)
        {
            try
            {
                dal.AddSellGoodTime(id);
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

        /// <summary>
        /// 获取热销最好的4种商品
        /// </summary>
        /// <returns>热销鲜花列表</returns>
        public static IList<GoodInfo> GetHotSellBySellTime()
        {
            try
            {
                return dal.GetGoodsBySellTime();
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

        /// <summary>
        /// 获取所有服务商品
        /// </summary>
        /// <returns>服务商品列表</returns>
        public static IList<GoodInfo> GetSpecialGood()
        {
            try
            {
                GoodInfo queryGood = new GoodInfo();
                queryGood.IsSpecial = 1;

                return dal.GetAllGood(queryGood);
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

        /// <summary>
        /// 根据商品名称获取商品编号
        /// </summary>
        /// <param name="name">商品名称</param>
        /// <returns>商品编号</returns>
        public static int GetGoodIDByName(string name)
        {
            try
            {
                return dal.GetGoodIDByName(name);
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }
        
    }
}
