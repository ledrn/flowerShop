/*
 * 描述： 商品信息数据访问类
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
    public class GoodDAL:IGood
    {
        /// <summary>
        /// 自定义分页显示获取所有商品信息，以列表形式返回
        /// </summary>
        /// <param name="pageSize">每页容量</param>
        /// <param name="currentPage">当前页码</param>
        /// <param name="goodQuery">存储查询条件的商品实体</param>
        /// <returns>商品信息列表</returns>
        public IList<GoodInfo> GetAllGoodByType(int pageSize, int currentPage,GoodInfo goodQuery)
        {
            //存储SQL语句
            string strSql;

            IList<GoodInfo> goodInfos = new List<GoodInfo>();

            try
            {
                string queryWhere = GetQueryWhere(goodQuery);

                if (currentPage <= 0)
                {
                    strSql = "select top " + pageSize + " * from fs_goods where " + queryWhere + " order by IsSpecial,ID desc";
                }
                else
                {
                    strSql = "select top " + pageSize + " * from fs_goods where " + queryWhere + " and ID not in(select top " + pageSize * currentPage + " ID from fs_goods where " + queryWhere + " order by IsSpecial,ID desc) order by IsSpecial,ID desc";
                }

                //调用访问数据的方法
                Database db = BaseDAL.GetDatabase();
                DbCommand comm = db.GetSqlStringCommand(strSql);
                using (IDataReader reader = db.ExecuteReader(comm))
                {

                    GoodInfo goodInfo = null;

                    //获取具体的商品信息，并将其添加到列表中
                    while (reader.Read())
                    {
                        goodInfo = GetGoodFormDataReader(reader);

                        goodInfos.Add(goodInfo);
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception("执行SQL语句时出现问题" + e.Message);
            }
            return goodInfos;
        }

        /// <summary>
        /// 获取所有商品信息，以列表形式返回
        /// </summary>
        /// <param name="goodQuery">存储查询条件的商品实体</param>
        /// <returns>商品信息列表</returns>
        public IList<GoodInfo> GetAllGood(GoodInfo goodQuery)
        {
            //存储SQL语句
            string strSql;

            IList<GoodInfo> goodInfos = new List<GoodInfo>();

            try
            {
                string queryWhere = GetQueryWhere(goodQuery);

                strSql = "select * from fs_goods where " + queryWhere + " ";

                //调用访问数据的方法
                Database db = BaseDAL.GetDatabase();
                DbCommand comm = db.GetSqlStringCommand(strSql);
                using (IDataReader reader = db.ExecuteReader(comm))
                {

                    GoodInfo goodInfo = null;

                    //获取具体的商品信息，并将其添加到列表中
                    while (reader.Read())
                    {
                        goodInfo = GetGoodFormDataReader(reader);

                        goodInfos.Add(goodInfo);
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception("执行SQL语句时出现问题" + e.Message);
            }
            return goodInfos;
        }

        /// <summary>
        /// 根据商品信息编号获取商品信息详细信息
        /// </summary>
        /// <param name="id">商品信息编号</param>
        /// <returns>商品信息实例</returns>
        public GoodInfo GetGood(int id)
        {
            //存储SQL语句
            string strSql;

            try
            {
                strSql = "select * from fs_goods where id=@id";

                //调用访问数据的方法
                Database db = BaseDAL.GetDatabase();
                DbCommand comm = db.GetSqlStringCommand(strSql);

                //添加参数
                db.AddInParameter(comm, "id", DbType.Int32, id);

                GoodInfo goodInfo = null;

                using (IDataReader reader = db.ExecuteReader(comm))
                {
                    //获取具体的商品信息
                    while (reader.Read())
                    {
                        goodInfo = GetGoodFormDataReader(reader);
                    }
                }

                return goodInfo;
            }
            catch (Exception e)
            {
                throw new Exception("执行SQL语句时出现问题" + e.Message);
            }
        }

        /// <summary>
        /// 根据商品名称获取商品编号
        /// </summary>
        /// <param name="name">商品名称</param>
        /// <returns>商品编号</returns>
        public int GetGoodIDByName(string name)
        {
            //存储SQL语句
            string strSql = "";

            try
            {
                strSql = "select id from fs_goods where name='" + name + "' ";

                //调用访问数据的方法,并返回商品编号
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
        /// 获取所有商品信息数量
        /// </summary>
        /// <param name="goodQuery">存储查询条件的商品实体</param>
        /// <returns>商品信息数量</returns>
        public int GetAllGoodNumByType(GoodInfo goodQuery)
        {
            //存储SQL语句
            string strSql = "";

            try
            {
                string queryWhere = GetQueryWhere(goodQuery);

                strSql = "select count(*) from fs_goods where " + queryWhere + " ";

                //调用数据访问的方法,并返回商品信息总数
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
        /// 添加、修改、删除商品信息
        /// </summary>
        /// <param name="goodInfo">商品信息实例</param>
        /// <param name="type">执行操作的类型</param>
        /// <returns>如果添加成功，返回True，失败，返回False</returns>
        public bool InsertUpdateDeleteGood(GoodInfo goodInfo, string type)
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
                        strSql = "insert into fs_goods values(@name,@component,@package,@describe,@sendRange,"
                            + "@price,@goodType,@photo,@festivalType,@useType,@flowerMaterial,@roseType,"
                            + "@sendPerson,0,@IsSpecial)";
                        comm = db.GetSqlStringCommand(strSql);
                        db.AddInParameter(comm, "name", DbType.String, goodInfo.Name);
                        db.AddInParameter(comm, "component", DbType.String, goodInfo.Component);
                        db.AddInParameter(comm, "package", DbType.String, goodInfo.Package);
                        db.AddInParameter(comm, "describe", DbType.String, goodInfo.Describe);
                        db.AddInParameter(comm, "sendRange", DbType.String, goodInfo.SendRange);
                        db.AddInParameter(comm, "price", DbType.Int32, goodInfo.Price);
                        db.AddInParameter(comm, "goodType", DbType.String, goodInfo.GoodType);
                        db.AddInParameter(comm, "photo", DbType.String, goodInfo.Photo);
                        db.AddInParameter(comm, "festivalType", DbType.String, goodInfo.FestivalType);
                        db.AddInParameter(comm, "useType", DbType.String, goodInfo.UseType);
                        db.AddInParameter(comm, "flowerMaterial", DbType.String, goodInfo.FlowerMaterial);
                        db.AddInParameter(comm, "roseType", DbType.String, goodInfo.RoseType);
                        db.AddInParameter(comm, "sendPerson", DbType.String, goodInfo.SendPerson);
                        db.AddInParameter(comm, "IsSpecial", DbType.Int32, goodInfo.IsSpecial);

                        break;
                    //更新操作
                    case "update":
                        strSql = "update fs_goods set name=@name,component=@component,package=@package,"
                            + "describe=@describe,sendRange=@sendRange,price=@price,goodType=@goodType,"
                            + "photo=@photo,festivalType=@festivalType,useType=@useType,flowerMaterial=@flowerMaterial,"
                            + "roseType=@roseType,sendPerson=@sendPerson,IsSpecial=@IsSpecial,sellTime=@sellTime where id=@id";
                        comm = db.GetSqlStringCommand(strSql);
                        db.AddInParameter(comm, "name", DbType.String, goodInfo.Name);
                        db.AddInParameter(comm, "component", DbType.String, goodInfo.Component);
                        db.AddInParameter(comm, "package", DbType.String, goodInfo.Package);
                        db.AddInParameter(comm, "describe", DbType.String, goodInfo.Describe);
                        db.AddInParameter(comm, "sendRange", DbType.String, goodInfo.SendRange);
                        db.AddInParameter(comm, "price", DbType.Int32, goodInfo.Price);
                        db.AddInParameter(comm, "goodType", DbType.String, goodInfo.GoodType);
                        db.AddInParameter(comm, "photo", DbType.String, goodInfo.Photo);
                        db.AddInParameter(comm, "festivalType", DbType.String, goodInfo.FestivalType);
                        db.AddInParameter(comm, "useType", DbType.String, goodInfo.UseType);
                        db.AddInParameter(comm, "flowerMaterial", DbType.String, goodInfo.FlowerMaterial);
                        db.AddInParameter(comm, "roseType", DbType.String, goodInfo.RoseType);
                        db.AddInParameter(comm, "sendPerson", DbType.String, goodInfo.SendPerson);
                        db.AddInParameter(comm, "IsSpecial", DbType.Int32, goodInfo.IsSpecial);
                        db.AddInParameter(comm, "sellTime", DbType.Int32, goodInfo.SellTime);
                        db.AddInParameter(comm, "id", DbType.Int32, goodInfo.ID);
 
                        break;
                    //删除操作
                    case "delete":
                        strSql = "delete from fs_goods where id=@id";
                        comm = db.GetSqlStringCommand(strSql);
                        db.AddInParameter(comm, "id", DbType.Int32, goodInfo.ID);

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
        /// 根据商品编号增加卖出次数
        /// </summary>
        /// <param name="id">商品编号</param>
        public void AddSellGoodTime(int id)
        {
            //存储SQL语句
            string strSql = "";

            try
            {
                strSql = "update fs_goods set sellTime=sellTime+1 where id= " +id;

                //调用访问数据的方法
                Database db = BaseDAL.GetDatabase();
                DbCommand comm = db.GetSqlStringCommand(strSql);
                db.ExecuteNonQuery(comm);
            }
            catch (Exception e)
            {
                throw new Exception("执行SQL语句时出现问题" + e.Message);
            }
        }

        /// <summary>
        /// 根据商品类型获取热销最好的4种商品
        /// </summary>
        /// <returns>热销商品列表</returns>
        public IList<GoodInfo> GetGoodsBySellTime()
        {
            //存储SQL语句
            string strSql;

            IList<GoodInfo> goodInfos = new List<GoodInfo>();

            try
            {
                strSql = "select top 4 * from fs_goods where IsSpecial=0 order by sellTime desc";

                Database db = BaseDAL.GetDatabase();
                DbCommand comm = db.GetSqlStringCommand(strSql);

                //调用数据访问的方法
                using (IDataReader reader = db.ExecuteReader(comm))
                {

                    GoodInfo goodInfo = null;

                    //获取具体的商品信息，并将其添加到列表中
                    while (reader.Read())
                    {
                        goodInfo = GetGoodFormDataReader(reader);

                        goodInfos.Add(goodInfo);
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception("执行SQL语句时出现问题" + e.Message);
            }
            return goodInfos;
        }

        /// <summary>
        /// 从IDataReader中取出商品信息，并返回商品信息实体
        /// </summary>
        /// <param name="reader">IDataReader实例</param>
        /// <returns>商品信息实体</returns>
        private GoodInfo GetGoodFormDataReader(IDataReader reader)
        {
            GoodInfo goodInfo = new GoodInfo();

            try
            {
                goodInfo.ID = BaseDAL.GetSafeInt(reader["id"]);
                goodInfo.Component = BaseDAL.GetSafeString(reader["component"]);
                goodInfo.Describe = BaseDAL.GetSafeString(reader["describe"]);
                goodInfo.FestivalType = BaseDAL.GetSafeString(reader["festivalType"]);
                goodInfo.FlowerMaterial = BaseDAL.GetSafeString(reader["flowerMaterial"]);
                goodInfo.GoodType = BaseDAL.GetSafeString(reader["goodType"]);
                goodInfo.IsSpecial = BaseDAL.GetSafeInt(reader["IsSpecial"]);
                goodInfo.Name = BaseDAL.GetSafeString(reader["name"]);
                goodInfo.Package = BaseDAL.GetSafeString(reader["package"]);
                goodInfo.Photo = BaseDAL.GetSafeString(reader["photo"]);
                goodInfo.Price = BaseDAL.GetSafeInt(reader["price"]);
                goodInfo.RoseType = BaseDAL.GetSafeString(reader["roseType"]);
                goodInfo.SellTime = BaseDAL.GetSafeInt(reader["sellTime"]);
                goodInfo.SendPerson = BaseDAL.GetSafeString(reader["sendPerson"]);
                goodInfo.SendRange = BaseDAL.GetSafeString(reader["sendRange"]);
                goodInfo.UseType = BaseDAL.GetSafeString(reader["useType"]);

            }
            catch (Exception er)
            {
                throw er;
            }
            return goodInfo;
        }

        /// <summary>
        /// 获取查询条件的Where条件字符串
        /// </summary>
        /// <param name="goodQuery">存储查询条件的商品实体</param>
        /// <returns>Where条件字符串</returns>
        private string GetQueryWhere(GoodInfo goodQuery)
        {
            string queryWhere = " 1=1 ";

            if (goodQuery == null)
            {
                return queryWhere;
            }
            
            //是否是特殊商品条件
            if (goodQuery.IsSpecial != null && goodQuery.IsSpecial != -1)
            {
                queryWhere += " and IsSpecial=" + goodQuery.IsSpecial + " ";
            }

            //商品类型条件
            if (goodQuery.GoodType != null && goodQuery.GoodType !="")
            {
                queryWhere += " and goodType='" + goodQuery.GoodType + "' ";
            }

            //节日类型条件
            if (goodQuery.FestivalType != null && goodQuery.FestivalType != "")
            {
                queryWhere += " and festivalType like '%" +goodQuery.FestivalType+ "%' ";
            }
            //花材类型
            if (goodQuery.FlowerMaterial != null && goodQuery.FlowerMaterial != "")
            {
                queryWhere += " and flowerMaterial like '%"+goodQuery.FlowerMaterial+"%' ";
            }
            //价格范围
            if (goodQuery.PriceRange != null && goodQuery.PriceRange !="")
            {
                if (goodQuery.PriceRange == "-1")
                {
                    queryWhere += " and price > " + goodQuery.Price.ToString() + " ";
                }
                else
                {
                    queryWhere += " and price between " + goodQuery.Price.ToString() + " and " + goodQuery.PriceRange + " ";
                }
            }
            //玫瑰类型
            if (goodQuery.RoseType != null && goodQuery.RoseType != "")
            {
                queryWhere += " and roseType ='"+goodQuery.RoseType+"' ";
            }
            //送人类型
            if (goodQuery.SendPerson != null && goodQuery.SendPerson != "")
            {
                queryWhere += " and sendPerson like '%"+goodQuery.SendPerson+"%'";
            }
            //用途类型
            if (goodQuery.UseType != null && goodQuery.UseType != "")
            {
                queryWhere += " and useType like '%"+goodQuery.UseType+"%' ";
            }

            //商品名称
            if (goodQuery.Name != null && goodQuery.Name != "")
            {
                queryWhere += " and name like '%"+goodQuery.Name+"%'";
            }

            return queryWhere;
        }
    }
}
