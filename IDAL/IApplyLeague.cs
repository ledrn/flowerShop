/*
 * 描述： 申请加盟信息接口类
 * 时间： 2008年09月20日
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FlowerShop.Model;

namespace FlowerShop.IDAL
{
    public interface IApplyLeague
    {
        /// <summary>
        /// 自定义分页显示获取所有申请加盟信息，以列表形式返回
        /// </summary>
        /// <param name="pageSize">每页容量</param>
        /// <param name="currentPage">当前页码</param>
        /// <param name="whereByName">按申请花店名称查询条件</param>
        /// <param name="whereByState">按申请状态查询条件</param>
        /// <returns>申请加盟信息列表</returns>
        IList<ApplyLeagueInfo> GetAllApplyLeague(int pageSize, int currentPage,string whereByName,string whereByState);

        /// <summary>
        /// 根据申请加盟信息编号获取申请加盟信息详细信息
        /// </summary>
        /// <param name="id">申请加盟信息编号</param>
        /// <returns>申请加盟信息实例</returns>
        ApplyLeagueInfo GetApplyLeague(int id);

        /// <summary>
        /// 获取所有申请加盟信息数量
        /// </summary>
        /// <param name="whereByName">按申请花店名称查询条件</param>
        /// <param name="whereByState">按申请状态查询条件</param>
        /// <returns>申请加盟信息数量</returns>
        int GetAllApplyLeagueNum(string whereByName,string whereByState);

        /// <summary>
        /// 添加、删除申请加盟信息
        /// </summary>
        /// <param name="applyLeague">申请加盟信息实例</param>
        /// <param name="type">执行操作的类型</param>
        /// <returns>如果添加成功，返回True，失败，返回False</returns>
        bool InsertDeleteApplyLeague(ApplyLeagueInfo applyLeague, string type);
    }
}
