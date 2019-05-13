/*
 * 描述： 其他信息数据访问类
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
    public class OtherInfoDAL:IOtherInfo
    {
        /// <summary>
        /// 根据其他信息类型获取其他信息详细信息
        /// </summary>
        /// <param name="type">其他信息类型</param>
        /// <returns>其他信息实例</returns>
        public OtherInfo GetOtherInfo(string type)
        {
            //存储SQL语句
            string strSql = "";

            strSql = "select "+type+" from fs_otherInfo";
 
            try
            {
                //调用访问数据的方法
                Database db = BaseDAL.GetDatabase();
                DbCommand comm = db.GetSqlStringCommand(strSql);

                OtherInfo otherInfo = new OtherInfo();

                using (IDataReader reader = db.ExecuteReader(comm))
                {
                    //获取具体的其他信息
                    while (reader.Read())
                    {
                        switch (type)
                        {
                            case "sendRange":
                                otherInfo.SendRange = BaseDAL.GetSafeString(reader["sendRange"]);
                                break;
                            case "afterSell":
                                otherInfo.AfterSell = BaseDAL.GetSafeString(reader["afterSell"]);
                                break;
                            case "aboutUs":
                                otherInfo.AboutUs = BaseDAL.GetSafeString(reader["aboutUs"]);
                                break;
                            case "sendmaincity":
                                otherInfo.Sendmaincity = BaseDAL.GetSafeString(reader["sendmaincity"]);
                                break;
                        }
                    }
                }

                return otherInfo;
            }
            catch (Exception e)
            {
                throw new Exception("执行SQL语句时出现问题" + e.Message);
            }
        }

        /// <summary>
        /// 更新其他信息
        /// </summary>
        /// <param name="otherInfo">其他信息实例</param>
        /// <param name="type">其他信息类型</param>
        /// <returns>如果更新成功，返回True，失败，返回False</returns>
        public bool UpdateOtherInfo(OtherInfo otherInfo,string type)
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
                    //更新配送范围
                    case "sendRange":
                        strSql = "update fs_otherInfo set sendRange=@sendRange";
                        comm = db.GetSqlStringCommand(strSql);
                       db.AddInParameter(comm, "sendRange", DbType.String, otherInfo.SendRange);

                        break;
                    //更新售后服务
                    case "afterSell":
                        strSql = "update fs_otherInfo set afterSell=@afterSell";
                        comm = db.GetSqlStringCommand(strSql);
                        db.AddInParameter(comm, "afterSell", DbType.String, otherInfo.AfterSell);

                        break;
                    //更新关于我们
                    case "aboutUs":
                        strSql = "update fs_otherInfo set aboutUs=@aboutUs";
                        comm = db.GetSqlStringCommand(strSql);
                        db.AddInParameter(comm, "aboutUs", DbType.String, otherInfo.AboutUs);

                        break;
                    //更新主要城市配送详细
                    case "sendmaincity":
                        strSql = "update fs_otherInfo set sendmaincity=@sendmaincity";
                        comm = db.GetSqlStringCommand(strSql);
                        db.AddInParameter(comm, "sendmaincity", DbType.String, otherInfo.Sendmaincity);

                        break;
                }
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
    }
}
