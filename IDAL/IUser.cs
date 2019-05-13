/*
 * 描述： 用户信息接口类
 * 时间： 2008年09月22日
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FlowerShop.Model;

namespace FlowerShop.IDAL
{
    public interface IUser
    {
        /// <summary>
        /// 自定义分页显示获取所有用户信息，以列表形式返回
        /// </summary>
        /// <param name="pageSize">每页容量</param>
        /// <param name="currentPage">当前页码</param>
        /// <param name="whereByName">按用户名查询条件</param>
        /// <returns>用户信息列表</returns>
        IList<UserInfo> GetAllUser(int pageSize, int currentPage,string whereByName);

        /// <summary>
        /// 根据用户信息编号获取用户信息详细信息
        /// </summary>
        /// <param name="id">用户信息编号</param>
        /// <returns>用户信息实例</returns>
        UserInfo GetUser(int id);

        /// <summary>
        /// 根据用户名称获取用户信息详细信息
        /// </summary>
        /// <param name="userName">用户名称</param>
        /// <returns>用户信息实例</returns>
        UserInfo GetUserByName(string userName);

        /// <summary>
        /// 获取所有用户信息数量
        /// </summary>
        /// <param name="whereByName">按用户名查询条件</param>
        /// <returns>用户信息数量</returns>
        int GetAllUserNum(string whereByName);

        /// <summary>
        /// 添加、修改、删除用户信息
        /// </summary>
        /// <param name="userInfo">用户信息实例</param>
        /// <param name="type">执行操作的类型</param>
        /// <returns>如果添加成功，返回True，失败，返回False</returns>
        bool InsertUpdateDeleteUser(UserInfo userInfo, string type);

        /// <summary>
        /// 判断用户是否合法
        /// </summary>
        /// <param name="userInfo">用户信息实例</param>
        /// <returns>如果用户合法，返回True，否则，返回False</returns>
        bool CheckUser(UserInfo userInfo);

        /// <summary>
        /// 判断管理员是否合法
        /// </summary>
        /// <param name="userInfo">用户信息实例</param>
        /// <returns>如果用户合法，返回True，否则，返回False</returns>
        bool CheckAdmin(UserInfo userInfo);

        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="userInfo">需要修改密码的用户信息实体</param>
        /// <returns>如果修改成功，返回True，失败，返回False</returns>
        bool UpdatePwd(UserInfo userInfo);

        /// <summary>
        /// 判断用户是否存在
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <returns>如果用户存在，返回True，不存在，返回False</returns>
        bool CheckUserExist(string userName);
    }
}
