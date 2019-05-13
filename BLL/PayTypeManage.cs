/*
 * 描述： 付款方式信息业务逻辑类
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
    public class PayTypeManage
    {
        private static IPayType dal = Factory.CreatePayTypeDAL();

        /// <summary>
        /// 显示获取所有付款方式信息，以列表形式返回
        /// </summary>
        /// <returns>付款方式信息列表</returns>
        public static IList<PayTypeInfo> GetAllPayType()
        {
            try
            {
                return dal.GetAllPayType();
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

        /// <summary>
        /// 根据付款方式信息编号获取付款方式信息详细信息
        /// </summary>
        /// <param name="id">付款方式信息编号</param>
        /// <returns>付款方式信息实例</returns>
        public static PayTypeInfo GetPayType(int id)
        {
            try
            {
                return dal.GetPayType(id);
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

        /// <summary>
        /// 添加付款方式信息
        /// </summary>
        /// <param name="payType">付款方式信息实例</param>
        /// <param name="type">执行操作的类型</param>
        /// <returns>如果添加成功，返回True，失败，返回False</returns>
        public static bool InsertPayType(PayTypeInfo payType)
        {
            try
            {
                return dal.InsertUpdateDeletePayType(payType,"insert");
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

        /// <summary>
        /// 修改付款方式信息
        /// </summary>
        /// <param name="payType">付款方式信息实例</param>
        /// <param name="type">执行操作的类型</param>
        /// <returns>如果修改成功，返回True，失败，返回False</returns>
        public static bool UpdatePayType(PayTypeInfo payType)
        {
            try
            {
                return dal.InsertUpdateDeletePayType(payType, "update");
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

        /// <summary>
        /// 删除付款方式信息
        /// </summary>
        /// <param name="payType">付款方式信息实例</param>
        /// <param name="type">执行操作的类型</param>
        /// <returns>如果删除成功，返回True，失败，返回False</returns>
        public static bool DeletePayType(PayTypeInfo payType)
        {
            try
            {
                return dal.InsertUpdateDeletePayType(payType, "delete");
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }
    }
}
