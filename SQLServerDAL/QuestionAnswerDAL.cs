/*
 * 描述： 问题与解答信息数据访问类
 * 时间： 2008年09月20日
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using FlowerShop.IDAL;
using FlowerShop.Model;

namespace FlowerShop.SQLServerDAL
{
    public class QuestionAnswerDAL:IQuestionAnswer
    {
        /// <summary>
        /// 自定义分页显示获取所有问题与解答信息，以列表形式返回
        /// </summary>
        /// <param name="pageSize">每页容量</param>
        /// <param name="currentPage">当前页码</param>
        /// <param name="questionType">问题类型</param>
        /// <param name="whereByName">按问题名称条件</param>
        /// <returns>问题与解答信息列表</returns>
        public IList<QuestionAnswerInfo> GetAllQuestionAnswer(int pageSize, int currentPage, string questionType,string whereByName)
        {
            //存储SQL语句
            string strSql;

            IList<QuestionAnswerInfo> questionAnswerInfos = new List<QuestionAnswerInfo>();

            if (whereByName == null || whereByName == "")
            {
                whereByName = " 1=1 ";
            }
            else
            {
                whereByName = " question like '%" + whereByName + "%' ";
            }

            try
            {
                if (currentPage <= 0)
                {
                    strSql = "select top " + pageSize + " * from fs_questionAnswer where "+whereByName+" and questionType=@questionType order by ID desc";
                }
                else
                {
                    strSql = "select top " + pageSize + " * from fs_questionAnswer where " +whereByName+" and questionType=@questionType and ID not in(select top " + pageSize * currentPage + " ID from fs_questionAnswer where " +whereByName+ " and questionType=@questionType order by ID desc) order by ID desc";
                }
                
                Database db = BaseDAL.GetDatabase();
                DbCommand comm = db.GetSqlStringCommand(strSql);

                //添加参数
                db.AddInParameter(comm, "questionType", DbType.String, questionType);
                //调用访问数据的方法
                using (IDataReader reader = db.ExecuteReader(comm))
                {

                    QuestionAnswerInfo questionAnswerInfo = null;

                    //获取具体的问题与解答信息，并将其添加到列表中
                    while (reader.Read())
                    {
                        questionAnswerInfo = GetQuestionAnswerFormDataReader(reader);

                        questionAnswerInfos.Add(questionAnswerInfo);
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception("执行SQL语句时出现问题" + e.Message);
            }
            return questionAnswerInfos;
        }

        /// <summary>
        /// 根据问题与解答信息编号获取问题与解答信息详细信息
        /// </summary>
        /// <param name="id">问题与解答信息编号</param>
        /// <returns>问题与解答信息实例</returns>
        public QuestionAnswerInfo GetQuestionAnswer(int id)
        {
            //存储SQL语句
            string strSql;

            try
            {
                strSql = "select * from fs_questionAnswer where id=@id";

                Database db = BaseDAL.GetDatabase();
                DbCommand comm = db.GetSqlStringCommand(strSql);

                //添加参数
                db.AddInParameter(comm, "id", DbType.Int32, id);

                QuestionAnswerInfo questionAnswerInfo = null;

                //调用访问数据的方法
                using (IDataReader reader = db.ExecuteReader(comm))
                {
                    //获取具体的问题与解答信息
                    while (reader.Read())
                    {
                        questionAnswerInfo = GetQuestionAnswerFormDataReader(reader);
                    }
                }

                return questionAnswerInfo;
            }
            catch (Exception e)
            {
                throw new Exception("执行SQL语句时出现问题" + e.Message);
            }
        }

        /// <summary>
        /// 获取所有问题与解答信息数量
        /// </summary>
        /// <param name="questionType">问题类型</param>
        /// <param name="whereByName">按问题名称条件</param>
        /// <returns>问题与解答信息数量</returns>
        public int GetAllQuestionAnswerNum(string questionType,string whereByName)
        {
            //存储SQL语句
            string strSql = "";

            if (whereByName == null || whereByName == "")
            {
                whereByName = " 1=1 ";
            }
            else
            {
                whereByName = " question like '%" + whereByName + "%' ";
            }

            try
            {
                strSql = "select count(*) from fs_questionAnswer where questionType=@questionType and "+whereByName;

                Database db = BaseDAL.GetDatabase();
                DbCommand comm = db.GetSqlStringCommand(strSql);

                //添加参数
                db.AddInParameter(comm, "questionType", DbType.String, questionType);

                //调用数据访问的方法,并返回问题与解答信息总数
                return Convert.ToInt32(db.ExecuteScalar(comm));
            }
            catch (Exception e)
            {
                throw new Exception("执行SQL语句时出现问题" + e.Message);
            }
        }

        /// <summary>
        /// 添加、修改、删除问题与解答信息
        /// </summary>
        /// <param name="applyLeague">问题与解答信息实例</param>
        /// <param name="type">执行操作的类型</param>
        /// <returns>如果添加成功，返回True，失败，返回False</returns>
        public bool InsertUpdateDeleteQuestionAnswer(QuestionAnswerInfo questionAnswer, string type)
        {
            //存储SQL语句
            string strSql = "";

            //存储判断是否执行成功
            int lineNum = 0;

            try
            {
                Database db = BaseDAL.GetDatabase();
                DbCommand comm = null;

                switch (type)
                {
                    //插入操作
                    case "insert":
                        strSql = "insert into fs_questionAnswer values(@question,@answer,@questionType)";
                        comm = db.GetSqlStringCommand(strSql);
                        db.AddInParameter(comm, "question", DbType.String, questionAnswer.Question);
                        db.AddInParameter(comm, "answer", DbType.String, questionAnswer.Answer);
                        db.AddInParameter(comm, "questionType", DbType.String, questionAnswer.QuestionType);

                        break;
                    //更新操作
                    case "update":
                        strSql = "update fs_questionAnswer set question=@question,answer=@answer where id=@id";
                        comm = db.GetSqlStringCommand(strSql);
                        db.AddInParameter(comm, "question", DbType.String, questionAnswer.Question);
                        db.AddInParameter(comm, "answer", DbType.String, questionAnswer.Answer);
                        db.AddInParameter(comm, "id", DbType.Int32, questionAnswer.ID);

                        break;
                    //删除操作
                    case "delete":
                        strSql = "delete from fs_questionAnswer where id=@id";
                        comm = db.GetSqlStringCommand(strSql);
                        db.AddInParameter(comm, "id", DbType.Int32, questionAnswer.ID);

                        break;
                }
                //调用数据访问的方法
                lineNum = db.ExecuteNonQuery(comm);

                //判断执行是否成功
                if (lineNum > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                throw new Exception("执行SQL语句时出现问题" + e.Message);
            }
        }

        /// <summary>
        /// 从IDataReader中取出问题与解答信息，并返回问题与解答信息实体
        /// </summary>
        /// <param name="reader">IDataReader实例</param>
        /// <returns>问题与解答信息实体</returns>
        private QuestionAnswerInfo GetQuestionAnswerFormDataReader(IDataReader reader)
        {
            QuestionAnswerInfo questionAnswerInfo = new QuestionAnswerInfo();

            try
            {
                questionAnswerInfo.ID = BaseDAL.GetSafeInt(reader["id"]);
                questionAnswerInfo.Answer = BaseDAL.GetSafeString(reader["answer"]);
                questionAnswerInfo.Question = BaseDAL.GetSafeString(reader["question"]);
                questionAnswerInfo.QuestionType = BaseDAL.GetSafeString(reader["questionType"]);
            }
            catch (Exception er)
            {
                throw er;
            }
            return questionAnswerInfo;
        }
    }
}
