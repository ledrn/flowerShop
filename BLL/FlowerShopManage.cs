/*
 * 描述： 各地花店信息业务逻辑类
 * 时间： 2008年09月20日
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
    public class FlowerShopManage
    {
        private static IFlowerShop dal = Factory.CreateFlowerShopDAL();

        /// <summary>
        /// 自定义分页显示获取所有各地花店信息，以列表形式返回
        /// </summary>
        /// <param name="pageSize">每页容量</param>
        /// <param name="currentPage">当前页码</param>
        /// <param name="whereByName">按花店名查询条件</param>
        /// <returns>各地花店信息列表</returns>
        public static IList<FlowerShopInfo> GetAllFlowerShop(int pageSize, int currentPage,string whereByName)
        {
            try
            {
                return dal.GetAllFlowerShop(pageSize, currentPage,whereByName);
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

        /// <summary>
        /// 获取在首页显示的花店7个
        /// </summary>
        /// <returns></returns>
        public static IList<FlowerShopInfo> GetIndexFlowerShop()
        {
            try
            {
                return dal.GetAllFlowerShop(7, 0, "");
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

         /// <summary>
        /// 根据各地花店信息编号获取各地花店信息详细信息
        /// </summary>
        /// <param name="id">各地花店信息编号</param>
        /// <returns>各地花店信息实例</returns>
        public static FlowerShopInfo GetFlowerShop(int id)
        {
            try
            {
                return dal.GetFlowerShop(id);
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

        /// <summary>
        /// 获取所有各地花店信息数量
        /// </summary>
        /// <param name="whereByName">按用户名查询条件</param>
        /// <returns>各地花店信息数量</returns>
        public static int GetAllFlowerShopNum(string whereByName)
        {
            try
            {
                return dal.GetAllFlowerShopNum(whereByName);
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

        /// <summary>
        /// 添加各地花店信息
        /// </summary>
        /// <param name="flowerShop">各地花店信息实例</param>
        /// <returns>如果添加成功，返回True，失败，返回False</returns>
        public static bool InsertFlowerShop(FlowerShopInfo flowerShop)
        {
            try
            {
                return dal.InsertUpdateDeleteFlowerShop(flowerShop,"insert");
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

        /// <summary>
        /// 修改各地花店信息
        /// </summary>
        /// <param name="flowerShop">各地花店信息实例</param>
        /// <returns>如果修改成功，返回True，失败，返回False</returns>
        public static bool UpdateFlowerShop(FlowerShopInfo flowerShop)
        {
            try
            {
                return dal.InsertUpdateDeleteFlowerShop(flowerShop, "update");
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

        /// <summary>
        /// 删除各地花店信息
        /// </summary>
        /// <param name="flowerShop">各地花店信息实例</param>
        /// <returns>如果删除成功，返回True，失败，返回False</returns>
        public static bool DeleteFlowerShop(FlowerShopInfo flowerShop)
        {
            try
            {
                return dal.InsertUpdateDeleteFlowerShop(flowerShop, "delete");
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }
    }
}
