/*
 * 描述： 其他信息业务逻辑类
 * 时间： 2008年09月22日
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
    public class OtherInfoManage
    {
        private static IOtherInfo dal = Factory.CreateOtherInfoDAL();

        /// <summary>
        /// 获取其他信息中配送范围详细信息
        /// </summary>
        /// <returns>其他信息实例</returns>
        public static OtherInfo GetSendRangeInfo()
        {
            try
            {
                return dal.GetOtherInfo("sendRange");
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

        /// <summary>
        /// 获取其他信息中售后服务详细信息
        /// </summary>
        /// <returns>其他信息实例</returns>
        public static OtherInfo GetAfterSellInfo()
        {
            try
            {
                return dal.GetOtherInfo("afterSell");
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

        /// <summary>
        /// 获取其他信息中关于我们详细信息
        /// </summary>
        /// <returns>其他信息实例</returns>
        public static OtherInfo GetAboutUsInfo()
        {
            try
            {
                return dal.GetOtherInfo("aboutUs");
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

        /// <summary>
        /// 获取其他信息中主要城市配送详细信息
        /// </summary>
        /// <returns>其他信息实例</returns>
        public static OtherInfo GetSendmaincityInfo()
        {
            try
            {
                return dal.GetOtherInfo("sendmaincity");
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

        /// <summary>
        /// 更新主要城市配送详细信息
        /// </summary>
        /// <param name="otherInfo">其他信息实例</param>
        /// <returns>如果更新成功，返回True，失败，返回False</returns>
        public static bool UpdateSendmaincityInfo(OtherInfo otherInfo)
        {
            try
            {
                return dal.UpdateOtherInfo(otherInfo, "sendmaincity");
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

        /// <summary>
        /// 更新关于我们信息
        /// </summary>
        /// <param name="otherInfo">其他信息实例</param>
        /// <returns>如果更新成功，返回True，失败，返回False</returns>
        public static bool UpdateAboutUsInfo(OtherInfo otherInfo)
        {
            try
            {
                return dal.UpdateOtherInfo(otherInfo,"aboutUs");
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

        /// <summary>
        /// 更新售后服务信息
        /// </summary>
        /// <param name="otherInfo">其他信息实例</param>
        /// <returns>如果更新成功，返回True，失败，返回False</returns>
        public static bool UpdateAfterSellInfo(OtherInfo otherInfo)
        {
            try
            {
                return dal.UpdateOtherInfo(otherInfo, "afterSell");
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

        /// <summary>
        /// 更新配送范围信息
        /// </summary>
        /// <param name="otherInfo">其他信息实例</param>
        /// <returns>如果更新成功，返回True，失败，返回False</returns>
        public static bool UpdateSendRangeInfo(OtherInfo otherInfo)
        {
            try
            {
                return dal.UpdateOtherInfo(otherInfo, "sendRange");
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }
    }
}
