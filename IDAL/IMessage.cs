/*
 * 描述： 短信息接口类
 * 时间： 2008年09月20日
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FlowerShop.Model;

namespace FlowerShop.IDAL
{
    public interface IMessage
    {
        /// <summary>
        /// 自定义分页显示获取某个用户的所有消息，以列表形式返回
        /// </summary>
        /// <param name="pageSize">每页容量</param>
        /// <param name="currentPage">当前页码</param>
        /// <param name="toUser">收消息用户的用户名</param>
        /// <param name="fromUser">发消息用户的用户名</param>
        /// <returns>消息列表</returns>
        IList<MessageInfo> GetAllMessage(int pageSize, int currentPage, string toUser,string fromUser);

        /// <summary>
        /// 根据短消息编号获取短消息详细信息
        /// </summary>
        /// <param name="id">短消息编号</param>
        /// <returns>短消息实例</returns>
        MessageInfo GetMessage(int id);

        /// <summary>
        /// 获取所有与某个用户相关的所有消息数量
        /// </summary>
        /// <param name="toUser">收消息用户的用户名</param>
        /// <param name="fromUser">发消息用户的用户名</param>
        /// <returns>消息数量</returns>
        int GetAllMessageNum(string toUser,string fromUser);

        /// <summary>
        /// 添加、删除消息
        /// </summary>
        /// <param name="message">消息实例</param>
        /// <param name="type">执行操作的类型</param>
        /// <returns>如果添加成功，返回True，失败，返回False</returns>
        bool InsertDeleteMessage(MessageInfo message,string type);

        /// <summary>
        /// 更新新消息为已读消息
        /// </summary>
        /// <param name="id">短消息编号</param>
        /// <param name="state">短消息状态</param>
        /// <returns>如果更新成功，返回True，失败，返回False</returns>
        bool UpdateAfterRead(int id, int state);
    }
}
