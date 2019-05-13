/*
 * 描述： 付款方式信息数据访问类
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
    public class PayTypeDAL:IPayType
    {
        /// <summary>
        /// 显示获取所有付款方式信息，以列表形式返回
        /// </summary>
        /// <returns>付款方式信息列表</returns>
        public IList<PayTypeInfo> GetAllPayType()
        {
            //存储SQL语句
            string strSql;

            IList<PayTypeInfo> payTypeInfos = new List<PayTypeInfo>();

            try
            {
                strSql = "select * from fs_payType";

                //调用访问数据的方法
                Database db = BaseDAL.GetDatabase();
                DbCommand comm = db.GetSqlStringCommand(strSql);
                using (IDataReader reader = db.ExecuteReader(comm))
                {

                    PayTypeInfo payTypeInfo = null;

                    //获取具体的付款方式信息，并将其添加到列表中
                    while (reader.Read())
                    {
                        payTypeInfo = GetPayTypeFormDataReader(reader);

                        payTypeInfos.Add(payTypeInfo);
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception("执行SQL语句时出现问题" + e.Message);
            }
            return payTypeInfos;
        }

        /// <summary>
        /// 根据付款方式信息编号获取付款方式信息详细信息
        /// </summary>
        /// <param name="id">付款方式信息编号</param>
        /// <returns>付款方式信息实例</returns>
        public PayTypeInfo GetPayType(int id)
        {
            //存储SQL语句
            string strSql;

            try
            {
                strSql = "select * from fs_payType where id=@id";

                Database db = BaseDAL.GetDatabase();
                DbCommand comm = db.GetSqlStringCommand(strSql);

                //添加参数
                db.AddInParameter(comm, "id", DbType.Int32, id);

                PayTypeInfo payTypeInfo = null;

                //调用访问数据的方法
                using (IDataReader reader = db.ExecuteReader(comm))
                {
                    //获取具体的付款方式信息
                    while (reader.Read())
                    {
                        payTypeInfo = GetPayTypeFormDataReader(reader);
                    }
                }

                return payTypeInfo;
            }
            catch (Exception e)
            {
                throw new Exception("执行SQL语句时出现问题" + e.Message);
            }
        }

        /// <summary>
        /// 添加、修改、删除付款方式信息
        /// </summary>
        /// <param name="payType">付款方式信息实例</param>
        /// <param name="type">执行操作的类型</param>
        /// <returns>如果添加成功，返回True，失败，返回False</returns>
        public bool InsertUpdateDeletePayType(PayTypeInfo payType, string type)
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
                        strSql = "insert into fs_payType values(@name,@payContent)";
                        comm = db.GetSqlStringCommand(strSql);
                        db.AddInParameter(comm, "name", DbType.String, payType.Name);
                        db.AddInParameter(comm, "payContent", DbType.String, payType.PayContent);

                        break;
                    //更新操作
                    case "update":
                        strSql = "update fs_payType set name=@name,payContent=@payContent where id=@id";
                        comm = db.GetSqlStringCommand(strSql);
                        db.AddInParameter(comm, "name", DbType.String, payType.Name);
                        db.AddInParameter(comm, "payContent", DbType.String, payType.PayContent);
                        db.AddInParameter(comm, "id", DbType.Int32, payType.ID);

                        break;
                    //删除操作
                    case "delete":
                        strSql = "delete from fs_payType where id=@id";
                        comm = db.GetSqlStringCommand(strSql);
                        db.AddInParameter(comm, "id", DbType.Int32, payType.ID);

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

        /// <summary>
        /// 从IDataReader中取出付款方式信息，并返回付款方式信息实体
        /// </summary>
        /// <param name="reader">IDataReader实例</param>
        /// <returns>付款方式信息实体</returns>
        private PayTypeInfo GetPayTypeFormDataReader(IDataReader reader)
        {
            PayTypeInfo payTypeInfo = new PayTypeInfo();

            try
            {
                payTypeInfo.ID = BaseDAL.GetSafeInt(reader["id"]);
                payTypeInfo.Name = BaseDAL.GetSafeString(reader["name"]);
                payTypeInfo.PayContent = BaseDAL.GetSafeString(reader["payContent"]);
                
            }
            catch (Exception er)
            {
                throw er;
            }
            return payTypeInfo;
        }
    }
}
