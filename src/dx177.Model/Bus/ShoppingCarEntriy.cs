using System;
using System.Collections.Generic;
using System.Text;

namespace dx177.Model.Bus
{

    /// <summary>
    /// 购物车列标实体集合
    /// </summary>
    [Serializable]
    public class ShoppingCarEntriy
    {
        int m_Seqno = 0;
        public int Seqno
        {
            get
            {
                return m_Seqno;
            }
            set
            {
                m_Seqno = value;
            }
        }
        /// <summary>
        /// 产品ID
        /// </summary>
        public string ProductId { get; set; }
        /// <summary>
        /// 产品名
        /// </summary>
        public string Name { get; set; }
        int m_Count = 0;
        /// <summary>
        /// 数量
        /// </summary>
        public int Count { 
            get
            {
                return m_Count;
            }
            set 
            {
                m_Count = value;
            }
        }
        /// <summary>
        /// 单价格
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// 总价格
        /// </summary>
        public decimal Total
        {
            get
            {
                return Price * Count;
            }

        }

        int m_Integral = 0;

        /// <summary>
        ///  积分
        /// </summary>
        public int Integral
        {
            get
            {
                return m_Integral;
            }
            set
            {
                m_Integral = value;
            }
        }

        double m_Weight = 0;
        public double  Weight
        {
            get
            {
                return m_Weight;
            }
            set
            {
                m_Weight = value;
            }
        
        }
        double m_TotalWeight = 0;        
        public double TotalWeight
        {
            get
            {
                return this.Weight * this.Count ;
            }
        }
        string m_ImgPath =string.Empty ;
        /// <summary>
        /// 图片地址
        /// </summary>
        public string ImgPath
        {
            get
            {
                return m_ImgPath;
            }
            set
            {
                m_ImgPath = value;
            }
        }
        string  m_Owner = string.Empty;
        /// <summary>
        /// 产品发布人
        /// </summary>
        public string Owner
        {
            get
            {
                return m_Owner;
            }
            set
            {
                m_Owner = value;
            }
        
        }

        bool _NotCarriage = false;
        /// <summary>
        /// 是否免运费
        /// </summary>
        public bool NotCarriage
        {
            get
            {
                return _NotCarriage;
            }
            set
            {
                _NotCarriage = value;
            }
        }
    }

}
