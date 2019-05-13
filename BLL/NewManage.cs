/*
 * 描述： 新闻信息业务逻辑类
 * 时间： 2008年09月19日
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
    public class NewManage
    {
        private static INew dal = Factory.CreateNewDAL();

        /// <summary>
        /// 自定义分页获取所有新闻列表
        /// </summary>
        /// <param name="pageSize">每页容量</param>
        /// <param name="currentPage">当前页码</param>
        /// <param name="whereByTitle">按标题查询条件</param>
        /// <returns>新闻列表</returns>
        public static IList<NewInfo> GetAllNews(int pageSize, int currentPage,string whereByTitle)
        {
            try
            {
                return dal.GetAllNews(pageSize,currentPage,whereByTitle);
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

        /// <summary>
        /// 获取在首页显示新闻列表
        /// </summary>
        /// <returns>新闻列表</returns>
        public static IList<NewInfo> GetIndexNews()
        {
            try
            {
                return dal.GetAllNews(7, 0, "");
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

        /// <summary>
        /// 根据新闻编号获取新闻实体
        /// </summary>
        /// <param name="id">新闻信息编号</param>
        /// <returns>新闻实体</returns>
        public static NewInfo GetNew(int id)
        {
            try
            {
                return dal.GetNew(id);
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

         /// <summary>
        /// 根据新闻类别获取新闻总数
        /// </summary>
        /// <param name="whereByTitle">按标题查询条件</param>
        /// <returns>新闻总数</returns>
        public static int GetAllNewsNum(string whereByTitle)
        {
            try
            {
                return dal.GetAllNewsNum(whereByTitle);
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

        /// <summary>
        /// 添加新闻
        /// </summary>
        /// <param name="newInfo">新闻实体</param>
        /// <returns>如果成功，返回TRUE，失败，返回False</returns>
        public static bool InsertNew(NewInfo newInfo)
        {
            try
            {
                return dal.InsertUpdateDelNew(newInfo,"insert");
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

        /// <summary>
        /// 修改新闻
        /// </summary>
        /// <param name="newInfo">新闻实体</param>
        /// <returns>如果成功，返回TRUE，失败，返回False</returns>
        public static bool UpdateNew(NewInfo newInfo)
        {
            try
            {
                return dal.InsertUpdateDelNew(newInfo, "update");
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

        /// <summary>
        /// 删除新闻
        /// </summary>
        /// <param name="newInfo">新闻实体</param>
        /// <returns>如果成功，返回TRUE，失败，返回False</returns>
        public static bool DeleteNew(NewInfo newInfo)
        {
            try
            {
                return dal.InsertUpdateDelNew(newInfo, "delete");
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }
    }
}
