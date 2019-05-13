/*
 * 描述： 用户信息实体类，映射数据库中有关用户信息的表
 * 时间： 2008年09月19日
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlowerShop.Model
{
    /// <summary>
    /// 用户信息实体类
    /// </summary>
    [Serializable]
    public class UserInfo
    {
        public UserInfo()
        { }

        /// <summary>
        /// 用户编号
        /// </summary>
        public int ID
        {
            set;
            get;
        }
        /// <summary>
        /// 用户登录名
        /// </summary>
        public string UserName
        {
            set;
            get;
        }
        /// <summary>
        /// 用户登录密码
        /// </summary>
        public string UserPwd
        {
            set;
            get;
        }
        /// <summary>
        /// 用户真实姓名
        /// </summary>
        public string RealName
        {
            set;
            get;
        }
        /// <summary>
        /// 电子邮件
        /// </summary>
        public string UserEmail
        {
            set;
            get;
        }
        /// <summary>
        /// 联系地址
        /// </summary>
        public string Address
        {
            set;
            get;
        }
        /// <summary>
        /// 邮政编码
        /// </summary>
        public string Postcode
        {
            set;
            get;
        }
        /// <summary>
        /// 联系电话
        /// </summary>
        public string Phone
        {
            set;
            get;
        }
        /// <summary>
        /// 手机
        /// </summary>
        public string MobilePhone
        {
            set;
            get;
        }
        /// <summary>
        /// QQ号
        /// </summary>
        public string QQ
        {
            set;
            get;
        }
        /// <summary>
        /// 省份
        /// </summary>
        public string Provinces
        {
            set;
            get;
        }
        /// <summary>
        /// 城市
        /// </summary>
        public string City
        {
            set;
            get;
        }
        /// <summary>
        /// 性别
        /// </summary>
        public string Sex
        {
            set;
            get;
        }
        /// <summary>
        /// 年龄
        /// </summary>
        public int? Age
        {
            set;
            get;
        }
        /// <summary>
        /// 备忘
        /// </summary>
        public string Note
        {
            set;
            get;
        }
        /// <summary>
        /// 是否是管理员（1为管理员，0为普通用户）
        /// </summary>
        public int? IsAdmin
        {
            set;
            get;
        }
        /// <summary>
        /// 申请时间
        /// </summary>
        public DateTime? WriteTime
        {
            set;
            get;
        }
    }
}

