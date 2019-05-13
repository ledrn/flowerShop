/*
 * 描述： 用户信息数据访问类
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
    public class UserDAL:IUser
    {
        /// <summary>
        /// 自定义分页显示获取所有用户信息，以列表形式返回
        /// </summary>
        /// <param name="pageSize">每页容量</param>
        /// <param name="currentPage">当前页码</param>
        /// <param name="whereByName">按用户名查询条件</param>
        /// <returns>用户信息列表</returns>
        public IList<UserInfo> GetAllUser(int pageSize, int currentPage, string whereByName)
        {
            //存储SQL语句
            string strSql;

            IList<UserInfo> userInfos = new List<UserInfo>();

            if (whereByName == null || whereByName == "")
            {
                whereByName = " 1=1 ";
            }
            else
            {
                whereByName = " userName like '%"+whereByName+"%' ";
            }

            try
            {
                if (currentPage <= 0)
                {
                    strSql = "select top " + pageSize + " * from fs_users where "+whereByName+" order by ID desc,isAdmin desc";
                }
                else
                {
                    strSql = "select top " + pageSize + " * from fs_users where " + whereByName + " and ID not in(select top " + pageSize * currentPage + " ID from fs_users where " + whereByName + " order by ID desc,isAdmin desc) order by ID desc,isAdmin desc";
                }

                //调用访问数据的方法
                Database db = BaseDAL.GetDatabase();
                DbCommand comm = db.GetSqlStringCommand(strSql);
                using (IDataReader reader = db.ExecuteReader(comm))
                {

                    UserInfo userInfo = null;

                    //获取具体的用户信息，并将其添加到列表中
                    while (reader.Read())
                    {
                        userInfo = GetUserFormDataReader(reader);

                        userInfos.Add(userInfo);
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception("执行SQL语句时出现问题" + e.Message);
            }
            return userInfos;
        }

        /// <summary>
        /// 根据用户信息编号获取用户信息详细信息
        /// </summary>
        /// <param name="id">用户信息编号</param>
        /// <returns>用户信息实例</returns>
        public UserInfo GetUser(int id)
        {
            //存储SQL语句
            string strSql;

            try
            {
                strSql = "select * from fs_users where id=@id";

                Database db = BaseDAL.GetDatabase();
                DbCommand comm = db.GetSqlStringCommand(strSql);

                //添加参数
                db.AddInParameter(comm, "id", DbType.Int32, id);

                UserInfo userInfo = null;

                //调用访问数据的方法
                using (IDataReader reader = db.ExecuteReader(comm))
                {
                    //获取具体的用户信息
                    while (reader.Read())
                    {
                        userInfo = GetUserFormDataReader(reader);
                    }
                }

                return userInfo;
            }
            catch (Exception e)
            {
                throw new Exception("执行SQL语句时出现问题" + e.Message);
            }
        }

        /// <summary>
        /// 根据用户名称获取用户信息详细信息
        /// </summary>
        /// <param name="userName">用户名称</param>
        /// <returns>用户信息实例</returns>
        public UserInfo GetUserByName(string userName)
        {
            //存储SQL语句
            string strSql;

            try
            {
                strSql = "select * from fs_users where userName=@userName";

                Database db = BaseDAL.GetDatabase();
                DbCommand comm = db.GetSqlStringCommand(strSql);

                //添加参数
                db.AddInParameter(comm, "userName", DbType.String, userName);

                UserInfo userInfo = null;

                //调用访问数据的方法
                using (IDataReader reader = db.ExecuteReader(comm))
                {
                    //获取具体的用户信息
                    while (reader.Read())
                    {
                        userInfo = GetUserFormDataReader(reader);
                    }
                }

                return userInfo;
            }
            catch (Exception e)
            {
                throw new Exception("执行SQL语句时出现问题" + e.Message);
            }
        }

        /// <summary>
        /// 获取所有用户信息数量
        /// </summary>
        /// <param name="whereByName">按用户名查询条件</param>
        /// <returns>用户信息数量</returns>
        public int GetAllUserNum(string whereByName)
        {
            //存储SQL语句
            string strSql = "";

            if (whereByName == null || whereByName == "")
            {
                whereByName = " 1=1 ";
            }
            else
            {
                whereByName = " userName like '%" + whereByName + "'% ";
            }

            try
            {
                strSql = "select count(*) from fs_users where "+whereByName;

                //调用数据访问的方法,并返回用户信息总数
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
        /// 添加、修改、删除用户信息
        /// </summary>
        /// <param name="userInfo">用户信息实例</param>
        /// <param name="type">执行操作的类型</param>
        /// <returns>如果添加成功，返回True，失败，返回False</returns>
        public bool InsertUpdateDeleteUser(UserInfo userInfo, string type)
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
                        strSql = "insert into fs_users values(@userName,@userPwd,@realName,@userEmail,@address,"
                            + "@postcode,@phone,@mobilePhone,@qq,@provinces,@city,@sex,@age,@note,@isAdmin,@writeTime)";
                        comm = db.GetSqlStringCommand(strSql);
                        db.AddInParameter(comm, "userName", DbType.String, userInfo.UserName);
                        db.AddInParameter(comm, "userPwd", DbType.String, userInfo.UserPwd);
                        db.AddInParameter(comm, "realName", DbType.String, userInfo.RealName);
                        db.AddInParameter(comm, "userEmail", DbType.String, userInfo.UserEmail);
                        db.AddInParameter(comm, "address", DbType.String, userInfo.Address);
                        db.AddInParameter(comm, "postcode", DbType.String, userInfo.Postcode);
                        db.AddInParameter(comm, "phone", DbType.String, userInfo.Phone);
                        db.AddInParameter(comm, "mobilePhone", DbType.String, userInfo.MobilePhone);
                        db.AddInParameter(comm, "qq", DbType.String, userInfo.QQ);
                        db.AddInParameter(comm, "provinces", DbType.String, userInfo.Provinces);
                        db.AddInParameter(comm, "city", DbType.String, userInfo.City);
                        db.AddInParameter(comm, "sex", DbType.String, userInfo.Sex);
                        db.AddInParameter(comm, "age", DbType.Int32, userInfo.Age);
                        db.AddInParameter(comm, "note", DbType.String, userInfo.Note);
                        db.AddInParameter(comm, "isAdmin", DbType.Int32, userInfo.IsAdmin);
                        db.AddInParameter(comm, "writeTime", DbType.String, DateTime.Now);

                        break;
                    //更新操作
                    case "update":
                        strSql = "update fs_users set realName=@realName,"
                            + "userEmail=@userEmail,address=@address,postcode=@postcode,phone=@phone,"
                            + "mobilePhone=@mobilePhone,qq=@qq,provinces=@provinces,city=@city,"
                            + "sex=@sex,age=@age,note=@note,isAdmin=@isAdmin where id=@id";
                        comm = db.GetSqlStringCommand(strSql);
                        db.AddInParameter(comm, "realName", DbType.String, userInfo.RealName);
                        db.AddInParameter(comm, "userEmail", DbType.String, userInfo.UserEmail);
                        db.AddInParameter(comm, "address", DbType.String, userInfo.Address);
                        db.AddInParameter(comm, "postcode", DbType.String, userInfo.Postcode);
                        db.AddInParameter(comm, "phone", DbType.String, userInfo.Phone);
                        db.AddInParameter(comm, "mobilePhone", DbType.String, userInfo.MobilePhone);
                        db.AddInParameter(comm, "qq", DbType.String, userInfo.QQ);
                        db.AddInParameter(comm, "provinces", DbType.String, userInfo.Provinces);
                        db.AddInParameter(comm, "city", DbType.String, userInfo.City);
                        db.AddInParameter(comm, "sex", DbType.String, userInfo.Sex);
                        db.AddInParameter(comm, "age", DbType.Int32, userInfo.Age);
                        db.AddInParameter(comm, "note", DbType.String, userInfo.Note);
                        db.AddInParameter(comm, "isAdmin", DbType.Int32, userInfo.IsAdmin);
                        db.AddInParameter(comm, "id", DbType.Int32, userInfo.ID);

                        break;
                    //删除操作
                    case "delete":
                        strSql = "delete from fs_users where id=@id";
                        comm = db.GetSqlStringCommand(strSql);
                        db.AddInParameter(comm, "id", DbType.Int32, userInfo.ID);

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
        /// 判断用户是否合法
        /// </summary>
        /// <param name="userInfo">用户信息实例</param>
        /// <returns>如果用户合法，返回True，否则，返回False</returns>
        public bool CheckUser(UserInfo userInfo)
        {
            //存储SQL语句
            string strSql = "";

            //存储判断是否执行成功
            int lineNum = 0;

            try
            {
                strSql = "select count(*) from fs_users where userName='"+userInfo.UserName+"' and userPwd='"
                    +userInfo.UserPwd+"'";

                //调用数据访问的方法
                Database db = BaseDAL.GetDatabase();
                DbCommand comm = db.GetSqlStringCommand(strSql);

                lineNum = Convert.ToInt32(db.ExecuteScalar(comm));
                
                //判断获取记录的个数，个数为0说明用户不合法，用户>0，用户合法
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
        /// 判断管理员是否合法
        /// </summary>
        /// <param name="userInfo">用户信息实例</param>
        /// <returns>如果用户合法，返回True，否则，返回False</returns>
        public bool CheckAdmin(UserInfo userInfo)
        {
            //存储SQL语句
            string strSql = "";

            //存储判断是否执行成功
            int lineNum = 0;

            try
            {
                strSql = "select count(*) from fs_users where userName='" + userInfo.UserName + "' and userPwd='"
                    + userInfo.UserPwd + "' and isAdmin=1";

                //调用数据访问的方法
                Database db = BaseDAL.GetDatabase();
                DbCommand comm = db.GetSqlStringCommand(strSql);

                lineNum = Convert.ToInt32(db.ExecuteScalar(comm));

                //判断获取记录的个数，个数为0说明用户不合法，用户>0，用户合法
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
        /// 判断用户是否存在
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <returns>如果用户存在，返回True，不存在，返回False</returns>
        public bool CheckUserExist(string userName)
        {
            //存储SQL语句
            string strSql = "";

            //存储判断是否执行成功
            int lineNum = 0;

            try
            {
                strSql = "select count(*) from fs_users where userName='" + userName + "'";

                //调用数据访问的方法
                Database db = BaseDAL.GetDatabase();
                DbCommand comm = db.GetSqlStringCommand(strSql);

                lineNum = Convert.ToInt32(db.ExecuteScalar(comm));

                //判断获取记录的个数，个数为0说明用户不合法，用户>0，用户合法
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
        /// 修改密码
        /// </summary>
        /// <param name="userInfo">需要修改密码的用户信息实体</param>
        /// <returns>如果修改成功，返回True，失败，返回False</returns>
        public bool UpdatePwd(UserInfo userInfo)
        {
            //存储SQL语句
            string strSql = "";

            //存储判断是否执行成功
            int lineNum = 0;

            try
            {
                strSql = "update fs_users set userPwd=@userPwd where id=@id" ;

                Database db = BaseDAL.GetDatabase();
                DbCommand comm = db.GetSqlStringCommand(strSql);

                //添加参数
                db.AddInParameter(comm, "id", DbType.Int32, userInfo.ID);
                db.AddInParameter(comm, "userPwd", DbType.String, userInfo.UserPwd);

                //调用数据访问的方法
                lineNum = db.ExecuteNonQuery(comm);

                //判断获取记录的个数，个数为0说明用户更新失败，>0，更新成功
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
        /// 从IDataReader中取出用户信息，并返回用户信息实体
        /// </summary>
        /// <param name="reader">IDataReader实例</param>
        /// <returns>用户信息实体</returns>
        private UserInfo GetUserFormDataReader(IDataReader reader)
        {
            UserInfo userInfo = new UserInfo();

            try
            {
                userInfo.ID = BaseDAL.GetSafeInt(reader["id"]);
                userInfo.Address = BaseDAL.GetSafeString(reader["address"]);
                userInfo.Age = BaseDAL.GetSafeInt(reader["age"]);
                userInfo.City = BaseDAL.GetSafeString(reader["city"]);
                userInfo.IsAdmin = BaseDAL.GetSafeInt(reader["isAdmin"]);
                userInfo.MobilePhone = BaseDAL.GetSafeString(reader["mobilePhone"]);
                userInfo.Note = BaseDAL.GetSafeString(reader["note"]);
                userInfo.Phone = BaseDAL.GetSafeString(reader["phone"]);
                userInfo.Postcode = BaseDAL.GetSafeString(reader["postcode"]);
                userInfo.Provinces = BaseDAL.GetSafeString(reader["provinces"]);
                userInfo.QQ = BaseDAL.GetSafeString(reader["qq"]);
                userInfo.RealName = BaseDAL.GetSafeString(reader["realName"]);
                userInfo.Sex = BaseDAL.GetSafeString(reader["sex"]);
                userInfo.UserEmail = BaseDAL.GetSafeString(reader["userEmail"]);
                userInfo.UserName = BaseDAL.GetSafeString(reader["userName"]);
                userInfo.UserPwd = BaseDAL.GetSafeString(reader["userPwd"]);
                userInfo.WriteTime = BaseDAL.GetSafeDateTime(reader["writeTime"]);

            }
            catch (Exception er)
            {
                throw er;
            }
            return userInfo;
        }
    }
}
