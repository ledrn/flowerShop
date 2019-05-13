/*
 * 描述： 问题与解答信息接口类
 * 时间： 2008年09月20日
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FlowerShop.Model;

namespace FlowerShop.IDAL
{
    public interface IQuestionAnswer
    {
        /// <summary>
        /// 自定义分页显示获取所有问题与解答信息，以列表形式返回
        /// </summary>
        /// <param name="pageSize">每页容量</param>
        /// <param name="currentPage">当前页码</param>
        /// <param name="questionType">问题类型</param>
        /// <param name="whereByName">按问题名称条件</param>
        /// <returns>问题与解答信息列表</returns>
        IList<QuestionAnswerInfo> GetAllQuestionAnswer(int pageSize, int currentPage, string questionType, string whereByName);

        /// <summary>
        /// 根据问题与解答信息编号获取问题与解答信息详细信息
        /// </summary>
        /// <param name="id">问题与解答信息编号</param>
        /// <returns>问题与解答信息实例</returns>
        QuestionAnswerInfo GetQuestionAnswer(int id);

        /// <summary>
        /// 获取所有问题与解答信息数量
        /// </summary>
        /// <param name="questionType">问题类型</param>
        /// <param name="whereByName">按问题名称条件</param>
        /// <returns>问题与解答信息数量</returns>
        int GetAllQuestionAnswerNum(string questionType,string whereByName);

        /// <summary>
        /// 添加、修改、删除问题与解答信息
        /// </summary>
        /// <param name="questionAnswer">问题与解答信息实例</param>
        /// <param name="type">执行操作的类型</param>
        /// <returns>如果添加成功，返回True，失败，返回False</returns>
        bool InsertUpdateDeleteQuestionAnswer(QuestionAnswerInfo questionAnswer, string type);
    }
}
