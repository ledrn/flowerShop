/*
 * 描述： 问题与解答信息实体类，映射数据库中有关问题与解答信息的表
 * 时间： 2008年09月19日
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlowerShop.Model
{
    /// <summary>
    /// 问题与解答信息实体类
    /// </summary>
    [Serializable]
    public class QuestionAnswerInfo
    {
        public QuestionAnswerInfo()
        { }

        /// <summary>
		/// 问题与解答编号
		/// </summary>
        public int ID
        {
            set;
            get;
        }
		/// <summary>
		/// 问题
		/// </summary>
        public string Question
        {
            set;
            get;
        }
		/// <summary>
		/// 解答
		/// </summary>
        public string Answer
        {
            set;
            get;
        }
		/// <summary>
		/// 问题类型（加盟常见问题、订单常见问题）
		/// </summary>
        public string QuestionType
        {
            set;
            get;
        }
	}
}
