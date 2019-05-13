/*
 * 描述： 付款方式信息接口类
 * 时间： 2008年09月20日
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FlowerShop.Model;

namespace FlowerShop.IDAL
{
    public interface IPayType
    {
        /// <summary>
        /// 显示获取所有付款方式信息，以列表形式返回
        /// </summary>
        /// <returns>付款方式信息列表</returns>
        IList<PayTypeInfo> GetAllPayType();

        /// <summary>
        /// 根据付款方式信息编号获取付款方式信息详细信息
        /// </summary>
        /// <param name="id">付款方式信息编号</param>
        /// <returns>付款方式信息实例</returns>
        PayTypeInfo GetPayType(int id);

        /// <summary>
        /// 添加、修改、删除付款方式信息
        /// </summary>
        /// <param name="payType">付款方式信息实例</param>
        /// <param name="type">执行操作的类型</param>
        /// <returns>如果添加成功，返回True，失败，返回False</returns>
        bool InsertUpdateDeletePayType(PayTypeInfo payType, string type);
    }
}
