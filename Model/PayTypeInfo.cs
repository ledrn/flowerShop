/*
 * 描述： 付款方式信息实体类，映射数据库中有关付款方式信息的表
 * 时间： 2008年09月19日
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlowerShop.Model
{
    /// <summary>
    /// 付款方式信息实体类
    /// </summary>
    [Serializable]
    public class PayTypeInfo
    {
        public PayTypeInfo()
        { }

        /// <summary>
        /// 付款方式编号
        /// </summary>
        public int ID
        {
            set;
            get;
        }
        /// <summary>
        /// 名称
        /// </summary>
        public string Name
        {
            set;
            get;
        }
        /// <summary>
        /// 内容
        /// </summary>
        public string PayContent
        {
            set;
            get;
        }
    }
}
