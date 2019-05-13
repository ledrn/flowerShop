/*
 * 描述： 订单明细实体类，映射数据库中有关订单明细的表
 * 时间： 2008年09月19日
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlowerShop.Model
{
    /// <summary>
    /// 订单明细实体类
    /// </summary>
    [Serializable]
    public class OrderDetailInfo
    {
        public OrderDetailInfo()
		{}

		/// <summary>
		/// 订单明细编号
		/// </summary>
        public int ID
        {
            set;
            get;
        }
		/// <summary>
		/// 订单主表编号
		/// </summary>
        public string MainOrderId
        {
            set;
            get;
        }
		/// <summary>
		/// 商品编号
		/// </summary>
        public int GoodId
        {
            set;
            get;
        }
        /// <summary>
        /// 商品名称
        /// </summary>
        public string GoodName
        {
            set;
            get;
        }
		/// <summary>
		/// 数量
		/// </summary>
        public int Num
        {
            set;
            get;
        }
        /// <summary>
        /// 商品价格
        /// </summary>
        public int Price
        {
            set;
            get;
        }
	}
}
