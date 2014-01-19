using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dx177.Model.Bus.QueryO
{
    public class HotelOrderQuery
    {
        /// <summary>
        /// 订单编号
        /// </summary>
        public string Orderno
        {
            get;
            set;
        }
        /// <summary>
        /// 订单状态
        /// </summary>
        public string OrderStatus
        {
            get;
            set;
        }
        /// <summary>
        /// 创建人
        /// </summary>
        public string Creator
        {
            get;
            set;
        }
        /// <summary>
        /// 入住开始时间
        /// </summary>
        public string Begindate
        {
            get;
            set;
        }
        /// <summary>
        /// 入住结束时间
        /// </summary>
        public string Enddate
        {
            get;
            set;
        }

        public string HotelSeqno
        {
            get;
            set;
        }

 
        /// <summary>
        /// 介绍人
        /// </summary>
        public string referrall
        {
            get;
            set;
        }
 
        public string OrderPesonPhone
        {
 

            get;
            set;
        }
        public string OrderPesonName
        {

            get;
            set;
        }

        public string HotelCreator
        {
            get;
            set;
        }
        string m_JingQuCode = "";
        public string JingQuCode
        {
            get
            {
                return m_JingQuCode;
            }
            set
            {
                m_JingQuCode = value;
            }
        }

    }
}
