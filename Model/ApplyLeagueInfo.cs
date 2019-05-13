/*
 * 描述： 申请加盟信息实体类，映射数据库中有关申请加盟信息的表
 * 时间： 2008年09月19日
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlowerShop.Model
{
    /// <summary>
    /// 申请加盟信息实体类
    /// </summary>
    [Serializable]
    public class ApplyLeagueInfo
    {
        public ApplyLeagueInfo()
        { }

        /// <summary>
		/// 申请加盟编号
		/// </summary>
        public int ID
        {
            set;
            get;
        }
		/// <summary>
		/// 花店名称
		/// </summary>
        public string Title
        {
            set;
            get;
        }
		/// <summary>
		/// 所在地区（包括省市县地区）
		/// </summary>
        public string Area
        {
            set;
            get;
        }
		/// <summary>
		/// 花店负责人姓名
		/// </summary>
        public string Name
        {
            set;
            get;
        }
		/// <summary>
		/// 花店地址
		/// </summary>
        public string Address
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
		/// 传真
		/// </summary>
        public string Fax
        {
            set;
            get;
        }
		/// <summary>
		/// 电子邮件
		/// </summary>
        public string Email
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
		/// 开户行
		/// </summary>
        public string Bank
        {
            set;
            get;
        }
		/// <summary>
		/// 账号
		/// </summary>
        public string AccountNumber
        {
            set;
            get;
        }
		/// <summary>
		/// 收款人
		/// </summary>
        public string Payee
        {
            set;
            get;
        }
		/// <summary>
		/// 配送区域
		/// </summary>
        public string SendArea
        {
            set;
            get;
        }
		/// <summary>
		/// 花店简介
		/// </summary>
        public string ShopSummary
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
        /// <summary>
        /// 加盟状态
        /// </summary>
        public string LeagueState
        {
            set;
            get;
        }
	}
}

