/*
 * 描述： 用户信息业务逻辑类
 * 时间： 2008年09月22日
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
    public class UserManage
    {
        private static IUser dal = Factory.CreateUserDAL();

        /// <summary>
        /// 自定义分页显示获取所有用户信息，以列表形式返回
        /// </summary>
        /// <param name="pageSize">每页容量</param>
        /// <param name="currentPage">当前页码</param>
        /// <param name="whereByName">按用户名查询条件</param>
        /// <returns>用户信息列表</returns>
        public static IList<UserInfo> GetAllUser(int pageSize, int currentPage,string whereByName)
        {
            try
            {
                return dal.GetAllUser(pageSize,currentPage,whereByName);
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

        /// <summary>
        /// 根据用户信息编号获取用户信息详细信息
        /// </summary>
        /// <param name="id">用户信息编号</param>
        /// <returns>用户信息实例</returns>
        public static UserInfo GetUser(int id)
        {
            try
            {
                return dal.GetUser(id);
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

         /// <summary>
        /// 根据用户名称获取用户信息详细信息
        /// </summary>
        /// <param name="userName">用户名称</param>
        /// <returns>用户信息实例</returns>
        public static UserInfo GetUserByName(string userName)
        {
            try
            {
                return dal.GetUserByName(userName);
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

        /// <summary>
        /// 获取所有用户信息数量
        /// </summary>
        /// <param name="whereByName">按用户名查询条件</param>
        /// <returns>用户信息数量</returns>
        public static int GetAllUserNum(string whereByName)
        {
            try
            {
                return dal.GetAllUserNum(whereByName);
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

        /// <summary>
        /// 添加用户信息
        /// </summary>
        /// <param name="userInfo">用户信息实例</param>
        /// <returns>如果添加成功，返回True，失败，返回False</returns>
        public static bool InsertUser(UserInfo userInfo)
        {
            try
            {
                return dal.InsertUpdateDeleteUser(userInfo,"insert");
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

        /// <summary>
        /// 添加管理员信息
        /// </summary>
        /// <param name="userInfo">管理员信息实例</param>
        /// <returns>如果添加成功，返回True，失败，返回False</returns>
        public static bool InsertAdmin(UserInfo userInfo)
        {
            try
            {
                //添加剩余信息
                userInfo.IsAdmin = 1;
                userInfo.Address = "";
                userInfo.Age = 0;
                userInfo.City = "";
                userInfo.MobilePhone = "";
                userInfo.Note = "";
                userInfo.Phone = "";
                userInfo.Postcode = "";
                userInfo.Provinces = "";
                userInfo.QQ = "";
                userInfo.Sex = "";
                userInfo.UserEmail = "";

                return dal.InsertUpdateDeleteUser(userInfo, "insert");
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

        /// <summary>
        /// 修改用户信息
        /// </summary>
        /// <param name="userInfo">用户信息实例</param>
        /// <returns>如果修改成功，返回True，失败，返回False</returns>
        public static bool UpdateUser(UserInfo userInfo)
        {
            try
            {
                return dal.InsertUpdateDeleteUser(userInfo, "update");
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

        /// <summary>
        /// 删除用户信息
        /// </summary>
        /// <param name="userInfo">用户信息实例</param>
        /// <returns>如果删除成功，返回True，失败，返回False</returns>
        public static bool DeleteUser(UserInfo userInfo)
        {
            try
            {
                return dal.InsertUpdateDeleteUser(userInfo, "delete");
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

        /// <summary>
        /// 判断用户是否合法
        /// </summary>
        /// <param name="userInfo">用户信息实例</param>
        /// <returns>如果用户合法，返回True，否则，返回False</returns>
        public static bool CheckUser(UserInfo userInfo)
        {
            try
            {
                return dal.CheckUser(userInfo);
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

        /// <summary>
        /// 判断管理员是否合法
        /// </summary>
        /// <param name="userInfo">用户信息实例</param>
        /// <returns>如果用户合法，返回True，否则，返回False</returns>
        public static bool CheckAdmin(UserInfo userInfo)
        {
            try
            {
                return dal.CheckAdmin(userInfo);
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="userInfo">需要修改密码的用户信息实体</param>
        /// <returns>如果修改成功，返回True，失败，返回False</returns>
        public static bool UpdatePwd(UserInfo userInfo)
        {
            try
            {
                return dal.UpdatePwd(userInfo);
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

        /// <summary>
        /// 判断用户是否存在
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <returns>如果用户存在，返回True，不存在，返回False</returns>
        public static bool CheckUserExist(string userName)
        {
            try
            {
                return dal.CheckUserExist(userName);
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }
    }
}
