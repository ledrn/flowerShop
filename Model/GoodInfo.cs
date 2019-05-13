/*
 * 描述： 商品实体类，映射数据库中有关商品的表
 * 时间： 2008年09月19日
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlowerShop.Model
{
    /// <summary>
    /// 商品实体类
    /// </summary>
    [Serializable]
    public class GoodInfo
    {
        public GoodInfo()
		{}

		/// <summary>
		/// 商品编号
		/// </summary>
        public int ID
        {
            set;
            get;
        }
		/// <summary>
		/// 商品名称
		/// </summary>
        public string Name
        {
            set;
            get;
        }
		/// <summary>
		/// 商品组成
		/// </summary>
        public string Component
        {
            set;
            get;
        }
		/// <summary>
		/// 包装
		/// </summary>
        public string Package
        {
            set;
            get;
        }
		/// <summary>
		/// 描述（花语）
		/// </summary>
        public string Describe
        {
            set;
            get;
        }
		/// <summary>
		/// 配送范围
		/// </summary>
        public string SendRange
        {
            set;
            get;
        }
		/// <summary>
		/// 价格
		/// </summary>
        public int? Price
        {
            set;
            get;
        }
		/// <summary>
		/// 商品类型（鲜花、果篮、蛋糕、巧克力）
		/// </summary>
        public string GoodType
        {
            set;
            get;
        }
		/// <summary>
		/// 图片所在位置
		/// </summary>
        public string Photo
        {
            set;
            get;
        }
		/// <summary>
		/// 节日类型
		/// </summary>
        public string FestivalType
        {
            set;
            get;
        }
		/// <summary>
		/// 用途类型
		/// </summary>
        public string UseType
        {
            set;
            get;
        }
		/// <summary>
		/// 花材类型
		/// </summary>
        public string FlowerMaterial
        {
            set;
            get;
        }
		/// <summary>
		/// 玫瑰类型（按多少枝玫瑰分类）
		/// </summary>
        public string RoseType
        {
            set;
            get;
        }
		/// <summary>
		/// 送人类型
		/// </summary>
        public string SendPerson
        {
            set;
            get;
        }
		/// <summary>
		/// 卖出次数
		/// </summary>
        public int? SellTime
        {
            set;
            get;
        }
		/// <summary>
		/// 是否特殊商品（1为是，0为不是,2为其他服务）
		/// </summary>
        public int? IsSpecial
        {
            set;
            get;
        }

        /// <summary>
        /// 查询价格的范围
        /// </summary>
        public string PriceRange
        {
            get;
            set;
        }
	}
}

