/*
 * 描述： 新闻信息数据访问类
 * 时间： 2008年09月19日
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
    public class NewDAL:INew
    {
        /// <summary>
        /// 自定义分页获取所有新闻列表
        /// </summary>
        /// <param name="pageSize">每页容量</param>
        /// <param name="currentPage">当前页码</param>
        /// <param name="whereByTitle">按标题查询条件</param>
        /// <returns>新闻列表</returns>
        public IList<NewInfo> GetAllNews(int pageSize, int currentPage,string whereByTitle)
        {
            //存储SQL语句
            string strSql;

            IList<NewInfo> newInfos = new List<NewInfo>();

            if (whereByTitle == null || whereByTitle == "")
            {
                whereByTitle = " 1=1 ";
            }
            else
            {
                whereByTitle = " title like '%" + whereByTitle + "%' ";
            }

            try
            {
                if (currentPage <= 0)
                {
                    strSql = "select top " + pageSize + " * from fs_news where "+whereByTitle+" order by ID desc";
                }
                else
                {
                    strSql = "select top " + pageSize + " * from fs_news where "+whereByTitle+" and ID not in(select top " + pageSize * currentPage + " ID from fs_news where "+whereByTitle+" order by ID desc) order by ID desc";
                }

                //调用访问数据的方法
                Database db = BaseDAL.GetDatabase();
                DbCommand comm = db.GetSqlStringCommand(strSql);
                using (IDataReader reader = db.ExecuteReader(comm))
                {

                    NewInfo newInfo = null;

                    //获取具体的新闻信息，并将其添加到列表中
                    while (reader.Read())
                    {
                        newInfo = GetNewFormDataReader(reader);

                        newInfos.Add(newInfo);
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception("执行SQL语句时出现问题" + e.Message);
            }
            return newInfos;
        }

        /// <summary>
        /// 根据新闻编号获取新闻实体
        /// </summary>
        /// <param name="id">新闻信息编号</param>
        /// <returns>新闻实体</returns>
        public NewInfo GetNew(int id)
        {
            //存储SQL语句
            string strSql;

            try
            {
                strSql = "select * from fs_news where id=@id";

                Database db = BaseDAL.GetDatabase();
                DbCommand comm = db.GetSqlStringCommand(strSql);

                //添加参数
                db.AddInParameter(comm, "id", DbType.Int32, id);

                NewInfo newInfo = null;

                //调用访问数据的方法
                using (IDataReader reader = db.ExecuteReader(comm))
                {
                    //获取具体的新闻信息
                    while (reader.Read())
                    {
                        newInfo = GetNewFormDataReader(reader);
                    }

                }
                return newInfo;
            }
            catch (Exception e)
            {
                throw new Exception("执行SQL语句时出现问题" + e.Message);
            }
        }

        /// <summary>
        /// 根据新闻类别获取新闻总数
        /// </summary>
        /// <param name="whereByTitle">按标题查询条件</param>
        /// <returns>新闻总数</returns>
        public int GetAllNewsNum(string whereByTitle)
        {
            //存储SQL语句
            string strSql="";

            if (whereByTitle == null || whereByTitle == "")
            {
                whereByTitle = " 1=1 ";
            }
            else
            {
                whereByTitle = " title like '%" + whereByTitle + "%' ";
            }

            try
            {
                strSql = "select count(*) from fs_news where "+whereByTitle;

                //调用数据访问的方法,并返回新闻总数
                Database db = BaseDAL.GetDatabase();
                DbCommand comm = db.GetSqlStringCommand(strSql);

                return Convert.ToInt32(db.ExecuteScalar(comm));
            }
            catch (Exception e)
            {
                throw new Exception("执行SQL语句时出现问题" + e.Message);
            }
        }

        /// <summary>
        /// 添加、修改、删除新闻
        /// </summary>
        /// <param name="newInfo">新闻实体</param>
        /// <param name="type">执行操作的类型</param>
        /// <returns>如果成功，返回TRUE，失败，返回False</returns>
        public bool InsertUpdateDelNew(NewInfo newInfo,string type)
        {
            //存储SQL语句
            string strSql="";

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
                        strSql = "insert into fs_news values(@title,@newContent,@writeTime)";
                        comm = db.GetSqlStringCommand(strSql);
                        db.AddInParameter(comm, "title", DbType.String, newInfo.Title);
                        db.AddInParameter(comm, "newContent", DbType.String, newInfo.NewContent);
                        db.AddInParameter(comm, "writeTime", DbType.DateTime, DateTime.Now);

                        break;
                    //更新操作
                    case "update":
                        strSql = "update fs_news set title=@title,newContent=@newContent where id=@id";
                        comm = db.GetSqlStringCommand(strSql);
                        db.AddInParameter(comm, "title", DbType.String, newInfo.Title);
                        db.AddInParameter(comm, "newContent", DbType.String, newInfo.NewContent);
                        db.AddInParameter(comm, "id", DbType.Int32, newInfo.ID);

                        break;
                    //删除操作
                    case "delete":
                        strSql = "delete from fs_news where id=@id";
                        comm = db.GetSqlStringCommand(strSql);
                        db.AddInParameter(comm, "id", DbType.Int32, newInfo.ID);

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
        /// 从IDataReader中取出新闻信息，并返回新闻信息实体
        /// </summary>
        /// <param name="reader">IDataReader实例</param>
        /// <returns>新闻信息实体</returns>
        private NewInfo GetNewFormDataReader(IDataReader reader)
        {
            NewInfo newInfo = new NewInfo();

            try
            {
                newInfo.ID = BaseDAL.GetSafeInt(reader["id"]);
                newInfo.Title = BaseDAL.GetSafeString(reader["title"]);
                newInfo.NewContent = BaseDAL.GetSafeString(reader["newContent"]);
                newInfo.WriteTime = BaseDAL.GetSafeDateTime(reader["writeTime"]);

            }
            catch (Exception er)
            {
                throw er;
            }
            return newInfo;
        }
    }
}
