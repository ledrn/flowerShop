/*
 * 描述： 订单主体实体类，映射数据库中有关订单主体的表
 * 时间： 2008年09月19日
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlowerShop.Model
{
    /// <summary>
    /// 订单主体实体类
    /// </summary>
    [Serializable]
    public class MainOrderInfo
    {
        public MainOrderInfo()
		{}

		/// <summary>
		/// 订单编号(固定规则)
		/// </summary>
        public string ID
        {
            set;
            get;
        }
		/// <summary>
		/// 订单状态（待处理、取消、受理中、已完成、失效）
		/// </summary>
        public string OrderState
        {
            set;
            get;
        }
		/// <summary>
		/// 订单时间
		/// </summary>
        public DateTime? OrderTime
        {
            set;
            get;
        }
		/// <summary>
		/// 配送方式
		/// </summary>
        public string SendType
        {
            set;
            get;
        }
		/// <summary>
		/// 付款方式
		/// </summary>
        public string PayType
        {
            set;
            get;
        }
		/// <summary>
		/// 配送时间
		/// </summary>
        public DateTime? SendTime
        {
            set;
            get;
        }
		/// <summary>
		/// 配送时段
		/// </summary>
        public string SendperiodTime
        {
            set;
            get;
        }
		/// <summary>
		/// 特殊要求
		/// </summary>
        public string SpecialOrder
        {
            set;
            get;
        }
		/// <summary>
		/// 给收货人留言
		/// </summary>
        public string Message
        {
            set;
            get;
        }
		/// <summary>
		/// 署名（保密时署名为“保密”）
		/// </summary>
        public string PenName
        {
            set;
            get;
        }
		/// <summary>
		/// 购买人姓名
		/// </summary>
        public string BuyerName
        {
            set;
            get;
        }
		/// <summary>
		/// 购买人电话
		/// </summary>
        public string BuyerPhone
        {
            set;
            get;
        }
		/// <summary>
		/// 购买人手机
		/// </summary>
        public string BuyerMobilePhone
        {
            set;
            get;
        }
		/// <summary>
		/// 购买人QQ
		/// </summary>
        public string BuyerQQ
        {
            set;
            get;
        }
		/// <summary>
		/// 购买人Email
		/// </summary>
        public string BuyerEmail
        {
            set;
            get;
        }
		/// <summary>
		/// 购买人地址
		/// </summary>
        public string BuyerAddress
        {
            set;
            get;
        }
		/// <summary>
		/// 收货人姓名
		/// </summary>
        public string ConsigneeName
        {
            set;
            get;
        }
		/// <summary>
		/// 收货人电话
		/// </summary>
        public string ConsigneePhone
        {
            set;
            get;
        }
		/// <summary>
		/// 收货人手机
		/// </summary>
        public string ConsigneeMobilePhone
        {
            set;
            get;
        }
		/// <summary>
		/// 收货人QQ
		/// </summary>
        public string ConsigneeQQ
        {
            set;
            get;
        }
		/// <summary>
		/// 收货人Email
		/// </summary>
        public string ConsigneeEmail
        {
            set;
            get;
        }
		/// <summary>
		/// 收货人地址
		/// </summary>
        public string ConsigneeAddress
        {
            set;
            get;
        }
		/// <summary>
		/// 收货人地区（包括省市县地区）
		/// </summary>
        public string ConsigneeArea
        {
            set;
            get;
        }
		/// <summary>
		/// 购买人编号（为0说明是会员购买）
		/// </summary>
        public int? UserId
        {
            set;
            get;
        }

        ///// <summary>
        ///// 此订单明细信息列表
        ///// </summary>
        //public IList<OrderDetailInfo> OrderDetailInfoList
        //{
        //    set;
        //    get;
        //}
	}
}

