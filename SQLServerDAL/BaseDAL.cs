/*
 * 描述： 基础数据类，实现了安全访问数据的方法
 * 时间： 2008年09月19日
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace FlowerShop.SQLServerDAL
{
    public static class BaseDAL
    {
        /// <summary>
        /// 获取企业库的数据库操作类实例
        /// </summary>
        /// <returns></returns>
        public static Database GetDatabase()
        {
            return DatabaseFactory.CreateDatabase("ConnectionStr");
        }

        #region 安全读取数据方法

        /// <summary>
        /// 安全取得字符串
        /// </summary>
        /// <param name="o">Object实例</param>
        /// <param name="defvalue">默认值</param>
        /// <returns>转换后字符串</returns>
        public static string GetSafeString(object o, string defvalue)
        {
            string result = defvalue;

            if (o != DBNull.Value)
                result = Convert.ToString(o);

            return result;
        }

        /// <summary>
        /// 安全取得字符串,不成功返回空字符串
        /// </summary>
        /// <param name="o">Object实例</param>
        /// <returns></returns>
        public static string GetSafeString(object o)
        {
            return GetSafeString(o, string.Empty);
        }

        /// <summary>
        /// 安全取得整型值
        /// </summary>
        /// <param name="o">Object实例</param>
        /// <param name="defvalue">默认值</param>
        /// <returns>转换后整型值</returns>
        public static int GetSafeInt(object o, int defvalue)
        {
            int result = defvalue;

            if (o != DBNull.Value)
                result = Convert.ToInt32(o);

            return result;
        }

        /// <summary>
        /// 安全取得整型值,不成功返回-1
        /// </summary>
        /// <param name="o">Object实例</param>
        /// <returns>转换后整型值</returns>
        public static int GetSafeInt(object o)
        {
            return GetSafeInt(o, -1);
        }

        /// <summary>
        /// 安全取得日期
        /// </summary>
        /// <param name="o">Object实例</param>
        /// <param name="defvalue">默认值</param>
        /// <returns>转换后日期</returns>
        public static DateTime GetSafeDateTime(object o, DateTime defvalue)
        {
            DateTime result = defvalue;

            if (o != DBNull.Value)
                result = Convert.ToDateTime(o);

            return result;
        }

        /// <summary>
        /// 安全取得日期,不成功返回最大日期
        /// </summary>
        /// <param name="o">Object实例</param>
        /// <returns>转换后日期</returns>
        public static DateTime GetSafeDateTime(object o)
        {
            //最小日期常量超出了Sql Server能表示的最小日期,但最大值满足,因此使用最大值MaxValue
            return GetSafeDateTime(o, DateTime.MaxValue);
        }

        #endregion
    }
}
