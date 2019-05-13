/*
 * 描述： 申请加盟数据访问类
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
    public class ApplyLeagueDAL:IApplyLeague
    {
        /// <summary>
        /// 自定义分页显示获取所有申请加盟信息，以列表形式返回
        /// </summary>
        /// <param name="pageSize">每页容量</param>
        /// <param name="currentPage">当前页码</param>
        /// <param name="whereByName">按申请花店名称查询条件</param>
        /// <param name="whereByState">按申请状态查询条件</param>
        /// <returns>申请加盟信息列表</returns>
        public IList<ApplyLeagueInfo> GetAllApplyLeague(int pageSize, int currentPage,string whereByName,string whereByState)
        {
            //存储SQL语句
            string strSql;

            IList<ApplyLeagueInfo> applyLeagueInfos = new List<ApplyLeagueInfo>();

            //按申请花店名称查询条件
            if (whereByName == null || whereByName == "")
            {
                whereByName = " 1=1 ";
            }
            else
            {
                whereByName = " title like '%" + whereByName + "%' ";
            }
            //按申请状态查询条件
            if (whereByState != null && whereByState != "")
            {
                whereByName += " and leagueState='"+whereByState+"' ";
            }

            try
            {
                if (currentPage <= 0)
                {
                    strSql = "select top " + pageSize + " * from fs_applyLeague where "+whereByName+" order by ID desc";
                }
                else
                {
                    strSql = "select top " + pageSize + " * from fs_applyLeague where "+whereByName+" and ID not in(select top " + pageSize * currentPage + " ID from fs_applyLeague where "+whereByName+" order by ID desc) order by ID desc";
                }

                //调用访问数据的方法
                Database db = BaseDAL.GetDatabase();
                DbCommand comm = db.GetSqlStringCommand(strSql);
                using (IDataReader reader = db.ExecuteReader(comm))
                {

                    ApplyLeagueInfo applyLeagueInfo = null;

                    //获取具体的申请加盟信息，并将其添加到列表中
                    while (reader.Read())
                    {
                        applyLeagueInfo = GetApplyLeagueFormDataReader(reader);

                        applyLeagueInfos.Add(applyLeagueInfo);
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception("执行SQL语句时出现问题" + e.Message);
            }
            return applyLeagueInfos;
        }

        /// <summary>
        /// 根据申请加盟信息编号获取申请加盟信息详细信息
        /// </summary>
        /// <param name="id">申请加盟信息编号</param>
        /// <returns>申请加盟信息实例</returns>
        public ApplyLeagueInfo GetApplyLeague(int id)
        {
            //存储SQL语句
            string strSql;

            try
            {
                strSql = "select * from fs_applyLeague where id=@id";

                Database db = BaseDAL.GetDatabase();
                DbCommand comm = db.GetSqlStringCommand(strSql);

                //添加参数
                db.AddInParameter(comm, "id", DbType.Int32, id);

                ApplyLeagueInfo applyLeagueInfo = null;

                //调用访问数据的方法
                using (IDataReader reader = db.ExecuteReader(comm))
                {
                    //获取具体的新闻信息
                    while (reader.Read())
                    {
                        applyLeagueInfo = GetApplyLeagueFormDataReader(reader);
                    }
                }
                return applyLeagueInfo;
            }
            catch (Exception e)
            {
                throw new Exception("执行SQL语句时出现问题" + e.Message);
            }
        }

        /// <summary>
        /// 获取所有申请加盟信息数量
        /// </summary>
        /// <param name="whereByName">按申请花店名称查询条件</param>
        /// <param name="whereByState">按申请状态查询条件</param>
        /// <returns>申请加盟信息数量</returns>
        public int GetAllApplyLeagueNum(string whereByName,string whereByState)
        {
            //存储SQL语句
            string strSql = "";

            //按申请花店名称查询条件
            if (whereByName == null || whereByName == "")
            {
                whereByName = " 1=1 ";
            }
            else
            {
                whereByName = " title like '%" + whereByName + "%' ";
            }
            //按申请状态查询条件
            if (whereByState != null && whereByState != "")
            {
                whereByName += " and leagueState='" + whereByState + "' ";
            }

            try
            {
                strSql = "select count(*) from fs_applyLeague where "+whereByName;

                //调用访问数据的方法,并返回申请加盟总数
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
        /// 添加、删除申请加盟信息
        /// </summary>
        /// <param name="applyLeague">申请加盟信息实例</param>
        /// <param name="type">执行操作的类型</param>
        /// <returns>如果添加成功，返回True，失败，返回False</returns>
        public bool InsertDeleteApplyLeague(ApplyLeagueInfo applyLeague, string type)
        {
            //存储SQL语句
            string strSql = "";

            //存储判断是否执行成功
            int lineNum = 0;

            try
            {
                Database db = BaseDAL.GetDatabase();
                DbCommand comm =null;

                switch (type)
                {
                    //插入操作
                    case "insert":
                        strSql = "insert into fs_applyLeague values(@title,@area,@name,@address,"
                            +"@phone,@mobilePhone,@fax,@email,@qq,@bank,@accountNumber,@payee,"
                            + "@sendArea,@shopSummary,@writeTime,@leagueState)";
                        comm = db.GetSqlStringCommand(strSql);
                        db.AddInParameter(comm, "title", DbType.String, applyLeague.Title);
                        db.AddInParameter(comm, "accountNumber", DbType.String, applyLeague.AccountNumber);
                        db.AddInParameter(comm, "address", DbType.String, applyLeague.Address);
                        db.AddInParameter(comm, "area", DbType.String, applyLeague.Area);
                        db.AddInParameter(comm, "name", DbType.String, applyLeague.Name);
                        db.AddInParameter(comm, "phone", DbType.String, applyLeague.Phone);
                        db.AddInParameter(comm, "mobilePhone", DbType.String, applyLeague.MobilePhone);
                        db.AddInParameter(comm, "fax", DbType.String, applyLeague.Fax);
                        db.AddInParameter(comm, "email", DbType.String, applyLeague.Email);
                        db.AddInParameter(comm, "qq", DbType.String, applyLeague.QQ);
                        db.AddInParameter(comm, "bank", DbType.String, applyLeague.Bank);
                        db.AddInParameter(comm, "payee", DbType.String, applyLeague.Payee);
                        db.AddInParameter(comm, "sendArea", DbType.String, applyLeague.SendArea);
                        db.AddInParameter(comm, "shopSummary", DbType.String, applyLeague.ShopSummary);
                        db.AddInParameter(comm, "writeTime", DbType.DateTime, DateTime.Now);
                        db.AddInParameter(comm, "leagueState", DbType.String, "待处理");

                        break;
                    //更新操作（更新申请状态）
                    case "update":
                        strSql = "update fs_applyLeague set leagueState=@leagueState where id=@id";
                        comm = db.GetSqlStringCommand(strSql);
                        db.AddInParameter(comm, "leagueState", DbType.String, applyLeague.LeagueState);
                        db.AddInParameter(comm, "id", DbType.Int32, applyLeague.ID);

                        break;

                    //删除操作
                    case "delete":
                        strSql = "delete from fs_applyLeague where id=@id";
                        comm = db.GetSqlStringCommand(strSql);
                        db.AddInParameter(comm, "id", DbType.Int32, applyLeague.ID);

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
        /// 从IDataReader中取出申请加盟信息，并返回申请加盟信息实体
        /// </summary>
        /// <param name="reader">IDataReader实例</param>
        /// <returns>申请加盟信息实体</returns>
        private ApplyLeagueInfo GetApplyLeagueFormDataReader(IDataReader reader)
        {
            ApplyLeagueInfo applyLeagueInfo = new ApplyLeagueInfo();

            try
            {
                applyLeagueInfo.ID = BaseDAL.GetSafeInt(reader["id"]);
                applyLeagueInfo.Title = BaseDAL.GetSafeString(reader["title"]);
                applyLeagueInfo.AccountNumber = BaseDAL.GetSafeString(reader["accountNumber"]);
                applyLeagueInfo.Address = BaseDAL.GetSafeString(reader["address"]);
                applyLeagueInfo.WriteTime = BaseDAL.GetSafeDateTime(reader["writeTime"]);
                applyLeagueInfo.Area = BaseDAL.GetSafeString(reader["area"]);
                applyLeagueInfo.Bank = BaseDAL.GetSafeString(reader["bank"]);
                applyLeagueInfo.Email = BaseDAL.GetSafeString(reader["email"]);
                applyLeagueInfo.Fax = BaseDAL.GetSafeString(reader["fax"]);
                applyLeagueInfo.MobilePhone = BaseDAL.GetSafeString(reader["mobilePhone"]);
                applyLeagueInfo.Name = BaseDAL.GetSafeString(reader["name"]);
                applyLeagueInfo.Payee = BaseDAL.GetSafeString(reader["payee"]);
                applyLeagueInfo.Phone = BaseDAL.GetSafeString(reader["phone"]);
                applyLeagueInfo.QQ = BaseDAL.GetSafeString(reader["qq"]);
                applyLeagueInfo.SendArea = BaseDAL.GetSafeString(reader["sendArea"]);
                applyLeagueInfo.ShopSummary = BaseDAL.GetSafeString(reader["shopSummary"]);
                applyLeagueInfo.LeagueState = BaseDAL.GetSafeString(reader["leagueState"]);
                
            }
            catch (Exception er)
            {
                throw er;
            }
            return applyLeagueInfo;
        }
    }
}
