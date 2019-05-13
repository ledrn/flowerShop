/*
 * 描述： 各地花店信息实体类，映射数据库中有关各地花店信息的表
 * 时间： 2008年09月19日
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlowerShop.Model
{
    /// <summary>
    /// 各地花店信息实体类
    /// </summary>
    [Serializable]
    public class FlowerShopInfo
    {
        public FlowerShopInfo()
        { }

        /// <summary>
        /// 花店编号
        /// </summary>
        public int ID
        {
            set;
            get;
        }
        /// <summary>
        /// 花店名称
        /// </summary>
        public string Name
        {
            set;
            get;
        }
    }
}
