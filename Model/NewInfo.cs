/*
 * 描述： 新闻实体类，映射数据库中有关新闻的表
 * 时间： 2008年09月19日
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlowerShop.Model
{
    /// <summary>
    ///  新闻实体类
    /// </summary>
    [Serializable]
    public class NewInfo
    {
        public NewInfo()
		{}

		/// <summary>
		/// 新闻编号
		/// </summary>
        public int ID
        {
            set;
            get;
        }
		/// <summary>
		/// 新闻名称
		/// </summary>
        public string Title
        {
            set;
            get;
        }
		
		/// <summary>
		/// 新闻内容
		/// </summary>
        public string NewContent
        {
            set;
            get;
        }
		/// <summary>
		/// 新闻发布时间
		/// </summary>
        public DateTime? WriteTime
        {
            set;
            get;
        }
	}
}

