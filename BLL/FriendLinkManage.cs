/*
 * 描述： 友情链接信息业务逻辑类
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
    public class FriendLinkManage
    {
        private static IFriendLink dal = Factory.CreateFriendLinkDAL();

        /// <summary>
        /// 显示获取所有友情链接信息，以列表形式返回
        /// </summary>
        /// <returns>友情链接信息列表</returns>
        public static IList<FriendLinkInfo> GetAllFriendLink()
        {
            try
            {
                return dal.GetAllFriendLink();
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

        /// <summary>
        /// 显示获取4个友情链接信息，以列表形式返回
        /// </summary>
        /// <returns>友情链接信息列表</returns>
        public static IList<FriendLinkInfo> GetToShowFriendLink()
        {
            try
            {
                return dal.GetToShowFriendLink();
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

        /// <summary>
        /// 根据友情链接信息编号获取友情链接信息详细信息
        /// </summary>
        /// <param name="id">友情链接信息编号</param>
        /// <returns>友情链接信息实例</returns>
        public static FriendLinkInfo GetFriendLink(int id)
        {
            try
            {
                return dal.GetFriendLink(id);
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

        /// <summary>
        /// 添加友情链接信息
        /// </summary>
        /// <param name="friendLink">友情链接信息实例</param>
        /// <returns>如果添加成功，返回True，失败，返回False</returns>
        public static bool InsertFriendLink(FriendLinkInfo friendLink)
        {
            try
            {
                return dal.InsertUpdateDeleteFriendLink(friendLink,"insert");
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

        /// <summary>
        /// 修改友情链接信息
        /// </summary>
        /// <param name="friendLink">友情链接信息实例</param>
        /// <returns>如果修改成功，返回True，失败，返回False</returns>
        public static bool UpdateFriendLink(FriendLinkInfo friendLink)
        {
            try
            {
                return dal.InsertUpdateDeleteFriendLink(friendLink, "update");
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

        /// <summary>
        /// 删除友情链接信息
        /// </summary>
        /// <param name="friendLink">友情链接信息实例</param>
        /// <returns>如果删除成功，返回True，失败，返回False</returns>
        public static bool DeleteFriendLink(FriendLinkInfo friendLink)
        {
            try
            {
                return dal.InsertUpdateDeleteFriendLink(friendLink, "delete");
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }
    }
}
