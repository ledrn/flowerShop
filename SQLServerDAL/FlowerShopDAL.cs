/*
 * 描述： 各地花店信息数据访问类
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
    public class FlowerShopDAL:IFlowerShop
    {
        /// <summary>
        /// 自定义分页显示获取所有各地花店信息，以列表形式返回
        /// </summary>
        /// <param name="pageSize">每页容量</param>
        /// <param name="currentPage">当前页码</param>
        /// <param name="whereByName">按用户名查询条件</param>
        /// <returns>各地花店信息列表</returns>
        public IList<FlowerShopInfo> GetAllFlowerShop(int pageSize, int currentPage,string whereByName)
        {
            //存储SQL语句
            string strSql;

            IList<FlowerShopInfo> flowerShopInfos = new List<FlowerShopInfo>();

            if (whereByName == null || whereByName == "")
            {
                whereByName = " 1=1 ";
            }
            else
            {
                whereByName = " name like '%" + whereByName + "%' ";
            }

            try
            {
                if (currentPage <= 0)
                {
                    strSql = "select top " + pageSize + " * from fs_flowerShop where "+whereByName+" order by ID desc";
                }
                else
                {
                    strSql = "select top " + pageSize + " * from fs_flowerShop where "+whereByName+" and ID not in(select top " + pageSize * currentPage + " ID from fs_flowerShop where "+whereByName+" order by ID desc) order by ID desc";
                }

                //调用访问数据的方法
                Database db = BaseDAL.GetDatabase();
                DbCommand comm = db.GetSqlStringCommand(strSql);
                using (IDataReader reader = db.ExecuteReader(comm))
                {

                    FlowerShopInfo flowerShopInfo = null;

                    //获取具体的各地花店信息，并将其添加到列表中
                    while (reader.Read())
                    {
                        flowerShopInfo = GetFlowerShopFormDataReader(reader);

                        flowerShopInfos.Add(flowerShopInfo);
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception("执行SQL语句时出现问题" + e.Message);
            }
            return flowerShopInfos;
        }

        /// <summary>
        /// 根据各地花店信息编号获取各地花店信息详细信息
        /// </summary>
        /// <param name="id">各地花店信息编号</param>
        /// <returns>各地花店信息实例</returns>
        public FlowerShopInfo GetFlowerShop(int id)
        {
            //存储SQL语句
            string strSql;

            try
            {
                strSql = "select * from fs_flowerShop where id=@id";
                Database db = BaseDAL.GetDatabase();
                DbCommand comm = db.GetSqlStringCommand(strSql);

                //添加参数
                db.AddInParameter(comm, "id", DbType.Int32, id);

                FlowerShopInfo flowerShopInfo = null;

                //调用访问数据的方法
                using (IDataReader reader = db.ExecuteReader(comm))
                {
                    //获取具体的新闻信息
                    while (reader.Read())
                    {
                        flowerShopInfo = GetFlowerShopFormDataReader(reader);
                    }
                }

                return flowerShopInfo;
            }
            catch (Exception e)
            {
                throw new Exception("执行SQL语句时出现问题" + e.Message);
            }
        }

        /// <summary>
        /// 获取所有各地花店信息数量
        /// </summary>
        /// <param name="whereByName">按用户名查询条件</param>
        /// <returns>各地花店信息数量</returns>
        public int GetAllFlowerShopNum(string whereByName)
        {
            //存储SQL语句
            string strSql = "";

            if (whereByName == null || whereByName == "")
            {
                whereByName = " 1=1 ";
            }
            else
            {
                whereByName = " name like '%" + whereByName + "%' ";
            }

            try
            {
                strSql = "select count(*) from fs_flowerShop where "+whereByName;

                //调用访问数据的方法,并返回花店总数
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
        /// 添加、修改、删除各地花店信息
        /// </summary>
        /// <param name="flowerShop">各地花店信息实例</param>
        /// <param name="type">执行操作的类型</param>
        /// <returns>如果添加成功，返回True，失败，返回False</returns>
        public bool InsertUpdateDeleteFlowerShop(FlowerShopInfo flowerShop, string type)
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
                        strSql = "insert into fs_flowerShop values(@name)";
                        comm = db.GetSqlStringCommand(strSql);
                        db.AddInParameter(comm, "name", DbType.String, flowerShop.Name);

                        break;
                    //更新操作
                    case "update":
                        strSql = "update fs_flowerShop set name=@name where id=@id";
                        comm = db.GetSqlStringCommand(strSql);
                        db.AddInParameter(comm, "name", DbType.String, flowerShop.Name);
                        db.AddInParameter(comm, "id", DbType.Int32, flowerShop.ID);

                        break;
                    //删除操作
                    case "delete":
                        strSql = "delete from fs_flowerShop where id=@id";
                        comm = db.GetSqlStringCommand(strSql);
                        db.AddInParameter(comm, "id", DbType.Int32, flowerShop.ID);

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
        /// 从IDataReader中取出各地花店信息，并返回各地花店信息实体
        /// </summary>
        /// <param name="reader">IDataReader实例</param>
        /// <returns>各地花店信息实体</returns>
        private FlowerShopInfo GetFlowerShopFormDataReader(IDataReader reader)
        {
            FlowerShopInfo flowerShopInfo = new FlowerShopInfo();

            try
            {
                flowerShopInfo.ID = BaseDAL.GetSafeInt(reader["id"]);
                flowerShopInfo.Name = BaseDAL.GetSafeString(reader["name"]);
                
            }
            catch (Exception er)
            {
                throw er;
            }
            return flowerShopInfo;
        }
    }
}
