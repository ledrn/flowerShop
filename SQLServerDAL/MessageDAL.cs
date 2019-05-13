/*
 * 描述： 短消息数据访问类
 * 时间： 2008年09月20日
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
    public class MessageDAL:IMessage 
    {
        /// <summary>
        /// 自定义分页显示获取某个用户的所有消息，以列表形式返回
        /// </summary>
        /// <param name="pageSize">每页容量</param>
        /// <param name="currentPage">当前页码</param>
        /// <param name="toUser">收消息用户的用户名</param>
        /// <param name="fromUser">发消息用户的用户名</param>
        /// <returns>消息列表</returns>
        public IList<MessageInfo> GetAllMessage(int pageSize, int currentPage, string toUser,string fromUser)
        {
            //存储SQL语句
            string strSql;

            IList<MessageInfo> messageInfos = new List<MessageInfo>();

            if (fromUser == null || fromUser == "")
            {
                fromUser = " 1=1 ";
            }
            else
            {
                fromUser = " fromUser like '%" + fromUser + "%' ";
            }

            try
            {
                if (currentPage <= 0)
                {
                    strSql = "select top " + pageSize + " * from fs_message where toUser=@toUser and "+fromUser+" order by isNew desc,ID desc";
                }
                else
                {
                    strSql = "select top " + pageSize + " * from fs_message where toUser=@toUser and "+fromUser+" and ID not in(select top " + pageSize * currentPage + " ID from fs_message where toUser=@toUser and "+fromUser+" order by isNew desc,ID desc) order by isNew desc,ID desc";
                }

                Database db = BaseDAL.GetDatabase();
                DbCommand comm = db.GetSqlStringCommand(strSql);

                //添加参数
                db.AddInParameter(comm, "toUser", DbType.String, toUser);

                //调用访问数据的方法
                using (IDataReader reader = db.ExecuteReader(comm))
                {

                    MessageInfo messageInfo = null;

                    //获取具体的短消息信息，并将其添加到列表中
                    while (reader.Read())
                    {
                        messageInfo = GetMessageFormDataReader(reader);

                        messageInfos.Add(messageInfo);
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception("执行SQL语句时出现问题" + e.Message);
            }
            return messageInfos;
        }

        /// <summary>
        /// 根据短消息编号获取短消息详细信息
        /// </summary>
        /// <param name="id">短消息编号</param>
        /// <returns>短消息实例</returns>
        public MessageInfo GetMessage(int id)
        {
            //存储SQL语句
            string strSql;

            try
            {
                strSql = "select * from fs_message where id=@id";

                Database db = BaseDAL.GetDatabase();
                DbCommand comm = db.GetSqlStringCommand(strSql);

                //添加参数
                db.AddInParameter(comm, "id", DbType.Int32, id);

                MessageInfo messageInfo = new MessageInfo();

                //调用访问数据的方法
                using (IDataReader reader = db.ExecuteReader(comm))
                {
                    //获取具体的新闻信息
                    while (reader.Read())
                    {
                        messageInfo = GetMessageFormDataReader(reader);
                    }
                }

                return messageInfo;
            }
            catch (Exception e)
            {
                throw new Exception("执行SQL语句时出现问题" + e.Message);
            }
        }

        /// <summary>
        /// 获取所有与某个用户相关的所有消息数量
        /// </summary>
        /// <param name="toUser">收消息用户的用户名</param>
        /// <param name="fromUser">发消息用户的用户名</param>
        /// <returns>消息数量</returns>
        public int GetAllMessageNum(string toUser,string fromUser)
        {
            //存储SQL语句
            string strSql = "";

            if (fromUser == null || fromUser == "")
            {
                fromUser = " 1=1 ";
            }
            else
            {
                fromUser = " fromUser like '%" + fromUser + "%' ";
            }

            try
            {
                strSql = "select count(*) from fs_message where toUser=@toUser and "+fromUser;

                Database db = BaseDAL.GetDatabase();
                DbCommand comm = db.GetSqlStringCommand(strSql);

                //添加参数
                db.AddInParameter(comm, "toUser", DbType.String, toUser);

                //调用数据访问的方法,并返回消息总数
                return Convert.ToInt32(db.ExecuteScalar(comm));
            }
            catch (Exception e)
            {
                throw new Exception("执行SQL语句时出现问题" + e.Message);
            }
        }

        /// <summary>
        /// 添加、删除消息
        /// </summary>
        /// <param name="message">消息实例</param>
        /// <param name="type">执行操作的类型</param>
        /// <returns>如果添加成功，返回True，失败，返回False</returns>
        public bool InsertDeleteMessage(MessageInfo message,string type)
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
                        strSql = "insert into fs_message values(@toUser,@fromUser,@title,@message,@writeTime,@isNew)";
                        comm = db.GetSqlStringCommand(strSql);
                        db.AddInParameter(comm, "title", DbType.String, message.Title);
                        db.AddInParameter(comm, "fromUser", DbType.String, message.FromUser);
                        db.AddInParameter(comm, "toUser", DbType.String, message.ToUser);
                        db.AddInParameter(comm, "message", DbType.String, message.Message);
                        db.AddInParameter(comm, "isNew", DbType.Int32, 1);                  //固定新添加的消息为新消息
                        db.AddInParameter(comm, "writeTime", DbType.DateTime, DateTime.Now);

                        break;
                    
                    //删除操作
                    case "delete":
                        strSql = "delete from fs_message where id=@id";
                        comm = db.GetSqlStringCommand(strSql);
                        db.AddInParameter(comm, "id", DbType.Int32, message.ID);

                        break;
                }

                //调用访问数据的方法
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
        /// 更新新消息为已读消息
        /// </summary>
        /// <param name="id">短消息编号</param>
        /// <param name="state">短消息状态</param>
        /// <returns>如果更新成功，返回True，失败，返回False</returns>
        public bool UpdateAfterRead(int id,int state)
        {
            //存储SQL语句
            string strSql = "";

            //存储判断是否执行成功
            int lineNum = 0;

            try
            {
                strSql = "update fs_message set isNew=@isNew where id=@id";

                Database db = BaseDAL.GetDatabase();
                DbCommand comm = db.GetSqlStringCommand(strSql);

                //添加参数
                db.AddInParameter(comm, "isNew", DbType.Int32, state);
                db.AddInParameter(comm, "id", DbType.Int32, id);

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
        /// 从IDataReader中取出短消息信息，并返回短消息信息实体
        /// </summary>
        /// <param name="reader">IDataReader实例</param>
        /// <returns>短消息信息实体</returns>
        private MessageInfo GetMessageFormDataReader(IDataReader reader)
        {
            MessageInfo messageInfo = new MessageInfo();

            try
            {
                messageInfo.ID = BaseDAL.GetSafeInt(reader["id"]);
                messageInfo.Title = BaseDAL.GetSafeString(reader["title"]);
                messageInfo.ToUser = BaseDAL.GetSafeString(reader["toUser"]);
                messageInfo.FromUser = BaseDAL.GetSafeString(reader["fromUser"]);
                messageInfo.WriteTime = BaseDAL.GetSafeDateTime(reader["writeTime"]);
                messageInfo.IsNew = BaseDAL.GetSafeInt(reader["isNew"]);
                messageInfo.Message = BaseDAL.GetSafeString(reader["message"]);
            }
            catch (Exception er)
            {
                throw er;
            }
            return messageInfo;
        }
    }
}
