/*
 * 描述： 友情链接实体类，映射数据库中有关友情链接的表
 * 时间： 2008年09月19日
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlowerShop.Model
{
    /// <summary>
    /// 友情链接实体类
    /// </summary>
    [Serializable]
    public class FriendLinkInfo
    {
        public FriendLinkInfo()
        { }

        /// <summary>
        /// 友情链接编号
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
        /// 链接URL地址
        /// </summary>
        public string LinkURL
        {
            set;
            get;
        }
        /// <summary>
        /// 链接图片地址
        /// </summary>
        public string ImageURL
        {
            set;
            get;
        }
    }
}
