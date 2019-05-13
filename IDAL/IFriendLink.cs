/*
 * 描述： 友情链接信息数据访问类
 * 时间： 2008年09月22日
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FlowerShop.Model;

namespace FlowerShop.IDAL
{
    public interface IFriendLink
    {
        /// <summary>
        /// 显示获取所有友情链接信息，以列表形式返回
        /// </summary>
        /// <returns>友情链接信息列表</returns>
        IList<FriendLinkInfo> GetAllFriendLink();

        /// <summary>
        /// 显示获取4个友情链接信息，以列表形式返回
        /// </summary>
        /// <returns>友情链接信息列表</returns>
        IList<FriendLinkInfo> GetToShowFriendLink();

        /// <summary>
        /// 根据友情链接信息编号获取友情链接信息详细信息
        /// </summary>
        /// <param name="id">友情链接信息编号</param>
        /// <returns>友情链接信息实例</returns>
        FriendLinkInfo GetFriendLink(int id);

        /// <summary>
        /// 添加、修改、删除友情链接信息
        /// </summary>
        /// <param name="friendLink">友情链接信息实例</param>
        /// <param name="type">执行操作的类型</param>
        /// <returns>如果添加成功，返回True，失败，返回False</returns>
        bool InsertUpdateDeleteFriendLink(FriendLinkInfo friendLink, string type);
    }
}
