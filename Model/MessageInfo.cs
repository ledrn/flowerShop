/*
 * 描述： 短消息实体类，映射数据库中有关短消息的表
 * 时间： 2008年09月19日
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlowerShop.Model
{
    /// <summary>
    /// 短消息实体类
    /// </summary>
    [Serializable]
    public class MessageInfo
    {
        public MessageInfo()
		{}

		/// <summary>
		/// 消息编号
		/// </summary>
        public int ID
        {
            set;
            get;
        }
		/// <summary>
		/// 收消息人
		/// </summary>
        public string ToUser
        {
            set;
            get;
        }
		/// <summary>
		/// 发消息人
		/// </summary>
        public string FromUser
        {
            set;
            get;
        }
		/// <summary>
		/// 消息标题
		/// </summary>
        public string Title
        {
            set;
            get;
        }
		/// <summary>
		/// 消息内容
		/// </summary>
        public string Message
        {
            set;
            get;
        }
		/// <summary>
		/// 消息发送时间
		/// </summary>
        public DateTime? WriteTime
        {
            set;
            get;
        }
		/// <summary>
		/// 是否是新消息（1为是，0为不是）
		/// </summary>
        public int? IsNew
        {
            set;
            get;
        }
	}
}
