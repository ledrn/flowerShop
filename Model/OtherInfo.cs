/*
 * 描述： 其他信息实体类，映射数据库中有关其他信息的表
 * 时间： 2008年09月19日
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlowerShop.Model
{
    /// <summary>
    /// 其他信息实体类
    /// </summary>
    [Serializable]
    public class OtherInfo
    {
        public OtherInfo()
        { }

        /// <summary>
        /// 配送范围页面内容
        /// </summary>
        public string SendRange
        {
            set;
            get;
        }
        /// <summary>
        /// 售后服务说明页面内容
        /// </summary>
        public string AfterSell
        {
            set;
            get;
        }
        /// <summary>
        /// 关于我们页面内容
        /// </summary>
        public string AboutUs
        {
            set;
            get;
        }
        /// <summary>
        /// 主要城市配送详细页面内容
        /// </summary>
        public string Sendmaincity
        {
            set;
            get;
        }
    }
}
