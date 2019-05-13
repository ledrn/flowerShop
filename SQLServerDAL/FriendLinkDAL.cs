/*
 * 描述： 友情链接信息数据访问类
 * 时间： 2008年09月22日
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
    public class FriendLinkDAL:IFriendLink
    {
	    /// <summary>
        /// 显示获取所有友情链接信息，以列表形式返回
        /// </summary>
        /// <returns>友情链接信息列表</returns>
        public IList<FriendLinkInfo> GetAllFriendLink()
	    {
	        //存储SQL语句
            string strSql;

            IList<FriendLinkInfo> friendLinkInfos = new List<FriendLinkInfo>();

            try
            {
                strSql = "select * from fs_friendLink";

                //调用访问数据的方法
                Database db = BaseDAL.GetDatabase();
                DbCommand comm = db.GetSqlStringCommand(strSql);
                using (IDataReader reader = db.ExecuteReader(comm))
                {

                    FriendLinkInfo friendLinkInfo = null;

                    //获取具体的友情链接信息，并将其添加到列表中
                    while (reader.Read())
                    {
                        friendLinkInfo = GetFriendLinkFormDataReader(reader);

                        friendLinkInfos.Add(friendLinkInfo);
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception("执行SQL语句时出现问题" + e.Message);
            }
            return friendLinkInfos;
	    }

        /// <summary>
        /// 显示获取4个友情链接信息，以列表形式返回
        /// </summary>
        /// <returns>友情链接信息列表</returns>
        public IList<FriendLinkInfo> GetToShowFriendLink()
        {
            //存储SQL语句
            string strSql;

            IList<FriendLinkInfo> friendLinkInfos = new List<FriendLinkInfo>();

            try
            {
                strSql = "select top 4 * from fs_friendLink";

                Database db = BaseDAL.GetDatabase();
                DbCommand comm = db.GetSqlStringCommand(strSql);

                //调用数据访问的方法
                using (IDataReader reader = db.ExecuteReader(comm))
                {

                    FriendLinkInfo friendLinkInfo = null;

                    //获取具体的友情链接信息，并将其添加到列表中
                    while (reader.Read())
                    {
                        friendLinkInfo = GetFriendLinkFormDataReader(reader);

                        friendLinkInfos.Add(friendLinkInfo);
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception("执行SQL语句时出现问题" + e.Message);
            }
            return friendLinkInfos;
        }

        /// <summary>
        /// 根据友情链接信息编号获取友情链接信息详细信息
        /// </summary>
        /// <param name="id">友情链接信息编号</param>
        /// <returns>友情链接信息实例</returns>
        public FriendLinkInfo GetFriendLink(int id)
        {
            //存储SQL语句
            string strSql;
 
            try
            {
                strSql = "select * from fs_friendLink where id=@id";

                //调用访问数据的方法
                Database db = BaseDAL.GetDatabase();
                DbCommand comm = db.GetSqlStringCommand(strSql);

                //添加参数
                db.AddInParameter(comm, "id", DbType.Int32, id);

                FriendLinkInfo friendLinkInfo = null;

                using (IDataReader reader = db.ExecuteReader(comm))
                {
                    //获取具体的友情链接信息
                    while (reader.Read())
                    {
                        friendLinkInfo = GetFriendLinkFormDataReader(reader);
                    }
                }

                return friendLinkInfo;
            }
            catch (Exception e)
            {
                throw new Exception("执行SQL语句时出现问题" + e.Message);
            }
        }

        /// <summary>
        /// 添加、修改、删除友情链接信息
        /// </summary>
        /// <param name="friendLink">友情链接信息实例</param>
        /// <param name="type">执行操作的类型</param>
        /// <returns>如果添加成功，返回True，失败，返回False</returns>
        public bool InsertUpdateDeleteFriendLink(FriendLinkInfo friendLink, string type)
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
                        strSql = "insert into fs_friendLink values(@name,@linkURL,@imageURL)";
                        comm = db.GetSqlStringCommand(strSql);
                        db.AddInParameter(comm, "name", DbType.String, friendLink.Name);
                        db.AddInParameter(comm, "linkURL", DbType.String, friendLink.LinkURL);
                        db.AddInParameter(comm, "imageURL", DbType.String, friendLink.ImageURL);

                        break;
                    //更新操作
                    case "update":
                        strSql = "update fs_friendLink set name=@name,linkURL=@linkURL,imageURL=@imageURL where id=@id";
                        comm = db.GetSqlStringCommand(strSql);
                        db.AddInParameter(comm, "name", DbType.String, friendLink.Name);
                        db.AddInParameter(comm, "linkURL", DbType.String, friendLink.LinkURL);
                        db.AddInParameter(comm, "imageURL", DbType.String, friendLink.ImageURL);
                        db.AddInParameter(comm, "id", DbType.Int32, friendLink.ID);

                        break;
                    //删除操作
                    case "delete":
                        strSql = "delete from fs_friendLink where id=@id";
                        comm = db.GetSqlStringCommand(strSql);
                        db.AddInParameter(comm, "id", DbType.Int32, friendLink.ID);

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
        /// 从IDataReader中取出友情链接信息，并返回友情链接信息实体
        /// </summary>
        /// <param name="reader">IDataReader实例</param>
        /// <returns>友情链接信息实体</returns>
        private FriendLinkInfo GetFriendLinkFormDataReader(IDataReader reader)
        {
            FriendLinkInfo friendLinkInfo = new FriendLinkInfo();

            try
            {
                friendLinkInfo.ID = BaseDAL.GetSafeInt(reader["id"]);
                friendLinkInfo.Name = BaseDAL.GetSafeString(reader["name"]);
                friendLinkInfo.LinkURL = BaseDAL.GetSafeString(reader["linkURL"]);
                friendLinkInfo.ImageURL = BaseDAL.GetSafeString(reader["imageURL"]);
            }
            catch (Exception er)
            {
                throw er;
            }
            return friendLinkInfo;
        }
    }
}
