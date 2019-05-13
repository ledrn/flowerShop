/*
 * 描述： 数据访问工厂类
 * 时间： 2008年09月19日
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Configuration;
using FlowerShop.IDAL;

namespace FlowerShop.DALFactory
{
    public class Factory
    {
        private static string assembly = ConfigurationManager.AppSettings["DALAssembly"];

        private static string nsname=ConfigurationManager.AppSettings["DALNameSpace"];

        public Factory()
        { }

        /// <summary>
        /// 创建新闻信息数据库访问
        /// </summary>
        /// <returns>实现了新闻信息接口的新闻信息数据库访问类</returns>
        public static INew CreateNewDAL()
        {
            string classname = nsname + ".NewDAL";

            return Assembly.Load(nsname).CreateInstance(classname) as INew;
        }

        /// <summary>
        /// 创建短消息信息数据库访问
        /// </summary>
        /// <returns>实现了短消息信息接口的短消息信息数据库访问类</returns>
        public static IMessage CreateMessageDAL()
        {
            string classname = nsname + ".MessageDAL";

            return Assembly.Load(nsname).CreateInstance(classname) as IMessage;
        }

        /// <summary>
        /// 创建申请加盟信息数据库访问
        /// </summary>
        /// <returns>实现了申请加盟信息接口的申请加盟信息数据库访问类</returns>
        public static IApplyLeague CreateApplyLeagueDAL()
        {
            string classname = nsname + ".ApplyLeagueDAL";

            return Assembly.Load(nsname).CreateInstance(classname) as IApplyLeague;
        }

        /// <summary>
        /// 创建问题与解答信息数据库访问
        /// </summary>
        /// <returns>实现了问题与解答信息接口的问题与解答信息数据库访问类</returns>
        public static IQuestionAnswer CreateQuestionAnswerDAL()
        {
            string classname = nsname + ".QuestionAnswerDAL";

            return Assembly.Load(nsname).CreateInstance(classname) as IQuestionAnswer;
        }

        /// <summary>
        /// 创建各地花店信息数据库访问
        /// </summary>
        /// <returns>实现了各地花店信息接口的各地花店信息数据库访问类</returns>
        public static IFlowerShop CreateFlowerShopDAL()
        {
            string classname = nsname + ".FlowerShopDAL";

            return Assembly.Load(nsname).CreateInstance(classname) as IFlowerShop;
        }

        /// <summary>
        /// 创建付款方式信息数据库访问
        /// </summary>
        /// <returns>实现了付款方式信息接口的付款方式信息数据库访问类</returns>
        public static IPayType CreatePayTypeDAL()
        {
            string classname = nsname + ".PayTypeDAL";

            return Assembly.Load(nsname).CreateInstance(classname) as IPayType;
        }

        /// <summary>
        /// 创建友情链接信息数据库访问
        /// </summary>
        /// <returns>实现了友情链接信息接口的友情链接信息数据库访问类</returns>
        public static IFriendLink CreateFriendLinkDAL()
        {
            string classname = nsname + ".FriendLinkDAL";

            return Assembly.Load(nsname).CreateInstance(classname) as IFriendLink;
        }

        /// <summary>
        /// 创建其他信息数据库访问
        /// </summary>
        /// <returns>实现了其他信息接口的其他信息数据库访问类</returns>
        public static IOtherInfo CreateOtherInfoDAL()
        {
            string classname = nsname + ".OtherInfoDAL";

            return Assembly.Load(nsname).CreateInstance(classname) as IOtherInfo;
        }

        /// <summary>
        /// 创建商品信息数据库访问
        /// </summary>
        /// <returns>实现了商品信息接口的商品信息数据库访问类</returns>
        public static IGood CreateGoodDAL()
        {
            string classname = nsname + ".GoodDAL";

            return Assembly.Load(nsname).CreateInstance(classname) as IGood;
        }

        /// <summary>
        /// 创建用户信息数据库访问
        /// </summary>
        /// <returns>实现了用户信息接口的用户信息数据库访问类</returns>
        public static IUser CreateUserDAL()
        {
            string classname = nsname + ".UserDAL";

            return Assembly.Load(nsname).CreateInstance(classname) as IUser;
        }

        /// <summary>
        /// 创建订单信息数据库访问
        /// </summary>
        /// <returns>实现了订单信息接口的订单信息数据库访问类</returns>
        public static IOrder CreateOrderDAL()
        {
            string classname = nsname + ".OrderDAL";

            return Assembly.Load(nsname).CreateInstance(classname) as IOrder;
        }
    }
}
