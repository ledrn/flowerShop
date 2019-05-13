/*
 * 描述： 问题与解答信息业务逻辑类
 * 时间： 2008年09月20日
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FlowerShop.Model;
using FlowerShop.IDAL;
using FlowerShop.DALFactory;

namespace FlowerShop.BLL
{
    public class QuestionAnswerManage
    {
        private static IQuestionAnswer dal = Factory.CreateQuestionAnswerDAL();

        /// <summary>
        /// 自定义分页显示获取所有问题与解答信息，以列表形式返回
        /// </summary>
        /// <param name="pageSize">每页容量</param>
        /// <param name="currentPage">当前页码</param>
        /// <param name="questionType">问题类型</param>
        /// <param name="whereByName">按问题名称条件</param>
        /// <returns>问题与解答信息列表</returns>
        public static IList<QuestionAnswerInfo> GetAllQuestionAnswer(int pageSize, int currentPage, string questionType,string whereByName)
        {
            try
            {
                return dal.GetAllQuestionAnswer(pageSize, currentPage, questionType,whereByName);
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

        /// <summary>
        /// 根据问题与解答信息编号获取问题与解答信息详细信息
        /// </summary>
        /// <param name="id">问题与解答信息编号</param>
        /// <returns>问题与解答信息实例</returns>
        public static QuestionAnswerInfo GetQuestionAnswer(int id)
        {
            try
            {
                return dal.GetQuestionAnswer(id);
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

        /// <summary>
        /// 获取所有问题与解答信息数量
        /// </summary>
        /// <param name="questionType">问题类型</param>
        /// <param name="whereByName">按问题名称条件</param>
        /// <returns>问题与解答信息数量</returns>
        public static int GetAllQuestionAnswerNum(string questionType,string whereByName)
        {
            try
            {
                return dal.GetAllQuestionAnswerNum(questionType,whereByName);
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

        /// <summary>
        /// 添加问题与解答信息
        /// </summary>
        /// <param name="applyLeague">问题与解答信息实例</param>
        /// <returns>如果添加成功，返回True，失败，返回False</returns>
        public static bool InsertQuestionAnswer(QuestionAnswerInfo questionAnswer)
        {
            try
            {
                return dal.InsertUpdateDeleteQuestionAnswer(questionAnswer,"insert");
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

        /// <summary>
        /// 修改问题与解答信息
        /// </summary>
        /// <param name="applyLeague">问题与解答信息实例</param>
        /// <returns>如果修改成功，返回True，失败，返回False</returns>
        public static bool UpdateQuestionAnswer(QuestionAnswerInfo questionAnswer)
        {
            try
            {
                return dal.InsertUpdateDeleteQuestionAnswer(questionAnswer, "update");
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

        /// <summary>
        /// 删除问题与解答信息
        /// </summary>
        /// <param name="applyLeague">问题与解答信息实例</param>
        /// <returns>如果删除成功，返回True，失败，返回False</returns>
        public static bool DeleteQuestionAnswer(QuestionAnswerInfo questionAnswer)
        {
            try
            {
                return dal.InsertUpdateDeleteQuestionAnswer(questionAnswer, "delete");
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }
    }
}
