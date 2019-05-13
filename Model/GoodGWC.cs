/*
 * 描述： 商品购物车实体类
 * 时间： 2008年10月09日
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlowerShop.Model
{
    /// <summary>
    /// 商品购物车实体类
    /// </summary>
    [Serializable]
    public class GoodGWC
    {
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
        /// 价格
        /// </summary>
        public int Price
        {
            set;
            get;
        }

        /// <summary>
        /// 商品数量
        /// </summary>
        public int Num
        {
            set;
            get;
        }
        /// <summary>
        /// 商品总额
        /// </summary>
        public int SumPrice
        {
            set;
            get;
        }
        /// <summary>
        /// 是否特殊商品（1为是，0为不是,2为其他服务）
        /// </summary>
        public int IsSpecial
        {
            set;
            get;
        }
    }
}
