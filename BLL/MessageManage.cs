/*
 * 描述： 短消息业务逻辑类
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
    public class MessageManage
    {
        private static IMessage dal = Factory.CreateMessageDAL();

        /// <summary>
        /// 自定义分页显示获取某个用户的所有消息，以列表形式返回
        /// </summary>
        /// <param name="pageSize">每页容量</param>
        /// <param name="currentPage">当前页码</param>
        /// <param name="toUser">收消息用户的用户名</param>
        /// <param name="fromUser">发消息用户的用户名</param>
        /// <returns>消息列表</returns>
        public static IList<MessageInfo> GetAllMessage(int pageSize, int currentPage, string toUser,string fromUser)
        {
            try
            {
                return dal.GetAllMessage(pageSize, currentPage, toUser,fromUser);
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

        /// <summary>
        /// 根据短消息编号获取短消息详细信息
        /// </summary>
        /// <param name="id">短消息编号</param>
        /// <returns>短消息实例</returns>
        public static MessageInfo GetMessage(int id)
        {
            try
            {
                return dal.GetMessage(id);
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

        /// <summary>
        /// 获取所有与某个用户相关的所有消息数量
        /// </summary>
        /// <param name="toUser">收消息用户的用户名</param>
        /// <param name="fromUser">发消息用户的用户名</param>
        /// <returns>消息数量</returns>
        public static int GetAllMessageNum(string toUser,string fromUser)
        {
            try
            {
                return dal.GetAllMessageNum(toUser,fromUser);
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

        /// <summary>
        /// 添加消息
        /// </summary>
        /// <param name="message">消息实例</param>
        /// <returns>如果添加成功，返回True，失败，返回False</returns>
        public static bool InsertMessage(MessageInfo message)
        {
            try
            {
                return dal.InsertDeleteMessage(message,"insert");
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

        /// <summary>
        /// 删除消息
        /// </summary>
        /// <param name="message">消息实例</param>
        /// <returns>如果删除成功，返回True，失败，返回False</returns>
        public static bool DeleteMessage(MessageInfo message)
        {
            try
            {
                return dal.InsertDeleteMessage(message, "delete");
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

        /// <summary>
        /// 更新新消息为已读消息
        /// </summary>
        /// <param name="id">短消息编号</param>
        /// <returns>如果更新成功，返回True，失败，返回False</returns>
        public static bool UpdateAfterRead(int id)
        {
            try
            {
                return dal.UpdateAfterRead(id,0);
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

        /// <summary>
        /// 更新消息为已回复
        /// </summary>
        /// <param name="id">短消息编号</param>
        /// <returns>如果更新成功，返回True，失败，返回False</returns>
        public static bool UpdateReSend(int id)
        {
            try
            {
                return dal.UpdateAfterRead(id, -1);
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }
    }
}
