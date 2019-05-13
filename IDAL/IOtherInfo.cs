/*
 * 描述： 其他信息接口类
 * 时间： 2008年09月20日
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FlowerShop.Model;

namespace FlowerShop.IDAL
{
    public interface IOtherInfo
    {
        /// <summary>
        /// 根据其他信息类型获取其他信息详细信息
        /// </summary>
        /// <param name="type">其他信息类型</param>
        /// <returns>其他信息实例</returns>
        OtherInfo GetOtherInfo(string type);

        /// <summary>
        /// 更新其他信息
        /// </summary>
        /// <param name="otherInfo">其他信息实例</param>
        /// <param name="type">其他信息类型</param>
        /// <returns>如果更新成功，返回True，失败，返回False</returns>
        bool UpdateOtherInfo(OtherInfo otherInfo,string type);
    }
}
