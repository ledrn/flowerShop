/*
 * 描述： 申请加盟业务逻辑类
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
    public class ApplyLeagueManage
    {
        private static IApplyLeague dal = Factory.CreateApplyLeagueDAL();

         /// <summary>
        /// 自定义分页显示获取所有申请加盟信息，以列表形式返回
        /// </summary>
        /// <param name="pageSize">每页容量</param>
        /// <param name="currentPage">当前页码</param>
        /// <param name="whereByName">按申请花店名称查询条件</param>
        /// <param name="whereByState">按申请状态查询条件</param>
        /// <returns>申请加盟信息列表</returns>
        public static IList<ApplyLeagueInfo> GetAllApplyLeague(int pageSize, int currentPage,string whereByName,string whereByState)
        {
            try
            {
                return dal.GetAllApplyLeague(pageSize, currentPage,whereByName,whereByState);
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

        /// <summary>
        /// 根据申请加盟信息编号获取申请加盟信息详细信息
        /// </summary>
        /// <param name="id">申请加盟信息编号</param>
        /// <returns>申请加盟信息实例</returns>
        public static ApplyLeagueInfo GetApplyLeague(int id)
        {
            try
            {
                return dal.GetApplyLeague(id);
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

        /// <summary>
        /// 获取所有申请加盟信息数量
        /// </summary>
        /// <param name="whereByName">按申请花店名称查询条件</param>
        /// <param name="whereByState">按申请状态查询条件</param>
        /// <returns>申请加盟信息数量</returns>
        public static int GetAllApplyLeagueNum(string whereByName,string whereByState)
        {
            try
            {
                return dal.GetAllApplyLeagueNum(whereByName,whereByState);
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

        /// <summary>
        /// 添加申请加盟信息
        /// </summary>
        /// <param name="applyLeague">申请加盟信息实例</param>
        /// <returns>如果添加成功，返回True，失败，返回False</returns>
        public static bool InsertApplyLeague(ApplyLeagueInfo applyLeague)
        {
            try
            {
                return dal.InsertDeleteApplyLeague(applyLeague,"insert");
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

        /// <summary>
        /// 删除申请加盟信息
        /// </summary>
        /// <param name="applyLeague">申请加盟信息实例</param>
        /// <returns>如果删除成功，返回True，失败，返回False</returns>
        public static bool DeleteApplyLeague(ApplyLeagueInfo applyLeague)
        {
            try
            {
                return dal.InsertDeleteApplyLeague(applyLeague, "delete");
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

        /// <summary>
        /// 更新申请加盟信息状态
        /// </summary>
        /// <param name="applyLeague">申请加盟信息实例</param>
        /// <returns>如果更新成功，返回True，失败，返回False</returns>
        public static bool UpdateApplyLeague(ApplyLeagueInfo applyLeague)
        {
            try
            {
                if (dal.InsertDeleteApplyLeague(applyLeague, "update"))
                {
                    FlowerShopInfo flowerShopInfo = new FlowerShopInfo();
                    flowerShopInfo.Name = applyLeague.Title;
                    return FlowerShopManage.InsertFlowerShop(flowerShopInfo);
                }
                else
                {
                    return false;
                }
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }
    }
}
