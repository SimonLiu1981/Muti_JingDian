/*
版权所有：版权所有(C) 2011，刘建新
文件编号：M01_HotelorderBll.cs
文件名称：HotelorderBll.cs
系统编号：Z0003007
系统名称：通用办公系统
模块编号：M01
模块名称：信息发布
设计文档：IOA_M01信息发布XDE建模.mdx
完成日期：2011/3/18
作　　者：
内容摘要：表[HotelOrder]业务操作类
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using dx177.Model.Bus;
 
using dx177.FrameWork;
using dx177.Model.Bus.QueryO;
using dx177.DataAccess.Access.Bus;
using System.Collections;
using dx177.Model;

namespace dx177.Business.Bus
{
    /// <summary>
	/// Hotelorder的BLL 自定义方法
	/// 该BLL已经生成了基本的业务操作，在自动生成的方法中已经提供了事务机制
	/// </summary>
    public partial class HotelorderBLL : BaseBLL<Hotelorder>
    {
        /// <summary>
        /// 提供订单
        /// </summary>
        /// <param name="order"></param>
        public void SubmitOrder(Hotelorder order)
        {            
            if (order.Seqno == 0)
            {
                order.Status = (int)HotelOrderStatus.WaitConfirm;
                order.Orderno = SerialNumberBLL.GetInstance().GetSerialumber("HDD", DateTime.Now.ToString("yyyyMMdd"), 2);//订单好
                order.Guid = System.Guid.NewGuid().ToString();
                order.CreateDate = DateTime.Now;
                this.Insert(order);
            }
            else
            {
                this.Update(order);
            }
            //string sss = 
        }

        public IList<Hotelorder> Search(HotelOrderQuery query, string jqcode)
        {
            string sql = string.Format("select * from Hotelorder where 1=1 ");
            if (!string.IsNullOrEmpty(query.Orderno))
            {
                sql += string.Format(" and orderno like '%{0}%'", query.Orderno);
            }
            if (!string.IsNullOrEmpty(query.OrderStatus))
            {
                sql += string.Format(" and status = {0}", query.OrderStatus);
            }
            if (!string.IsNullOrEmpty(query.Creator))
            {
                sql += string.Format(" and Creator = '{0}'", query.Creator);
            }
            if (!string.IsNullOrEmpty(query.Begindate))
            {
                sql += string.Format(" and Create_date >= '{0}'", query.Begindate);
            }
            if (!string.IsNullOrEmpty(query.Enddate))
            {
                sql += string.Format(" and Create_date <= '{0} 23:59:59'", query.Enddate);
            }
            if (!string.IsNullOrEmpty(query.HotelSeqno))
            {
                sql += string.Format(" and HotelSeqno = {0}", query.HotelSeqno);
            }

            if (!string.IsNullOrEmpty(query.JingQuCode))
            {
                sql += string.Format(" and Hotelseqno in (select seqno from Hotel where jingqucode='{0}')", jqcode);
            }

            if (!string.IsNullOrEmpty(query.referrall))
            {
                sql += string.Format(" and referrall = '{0}'", query.referrall);
            }
 
            if (!string.IsNullOrEmpty(query.OrderPesonPhone))
            {
                sql += string.Format(" and orderuserphone like '{0}'", query.OrderPesonPhone);
            }
            if (!string.IsNullOrEmpty(query.OrderPesonName))
            {
                sql += string.Format(" and orderusername like '%{0}%'", query.OrderPesonName);
            }
 

            sql += " order by seqno desc";
            DataTable dt = this.GetDataTable(sql);
            return Hotelorder.Dt2Objs(dt);

        }


        public IList<Hotelorder> Search(string Personname,string Mobile) 
        {
            string sql = " select  *  from dbo.HotelOrder where personphone = '{0}'  and OrderUserName = '{1}' ";
            sql += " order by seqno desc";
            sql = string.Format(sql,Mobile, Personname);
            DataTable dt = this.GetDataTable(sql);
            return Hotelorder.Dt2Objs(dt);

        }


        public void RemoveHotelOrder(int p)
        {
            string sql = "delete from Hotelorder where seqno = " + p.ToString();
            this.Execute(sql);
        }
    }
 
 
    #region 代码自动生成
	/// <summary>
	/// Hotelorder的BLL
	/// 该BLL已经生成了基本的业务操作，在自动生成的方法中已经提供了事务机制
	/// </summary>
    public partial class HotelorderBLL : BaseBLL<Hotelorder>
    {
        #region 自动生成代码：取得相关实体

		/// <summary>
		/// 方法名称: HotelorderBLL
		/// 内容摘要: 构造函数进行初始化
		/// </summary>
		protected HotelorderBLL()
		{
		}
		private static volatile HotelorderBLL m_instance = null;
		/// <summary>
		/// 方法名称: GetInstance
		/// 内容摘要: 取得 HotelorderBLL 对象
		/// </summary>
		/// <returns>返回一个已经存在的实体</returns>
		public static HotelorderBLL GetInstance()
		{
			// 通用的必要代码 iBatisNet双校检机制,如果实例不存在
			if (m_instance == null)
			{
				lock (typeof (HotelorderBLL))
				{

					// 如果实例不存在
					if (m_instance == null)
					{

						// 创建一个的实例
						m_instance = new HotelorderBLL();
					}
				}
			}

			// 返回业务逻辑对象
			return m_instance;
		}
		
		#endregion

		#region 自动生成代码：基本业务公开函数


        /// <summary>
        /// 方法名称: Get
        /// 内容摘要: 由键值获取一个实体对象
        /// </summary>
        /// <returns>Hotelorder</returns>
        public Hotelorder Get(Hotelorder.Key key)
        {
            return HotelorderDao.GetInstance().SelectByID(key);
        }
        /// <summary>
        /// 方法名称: Select
        /// 内容摘要: 基本查询，不带任何条件的查询
        /// </summary>
        public IList Select()
        {
            return HotelorderDao.GetInstance().SelectAll();
        }
        /// <summary>
        /// 方法名称: Insert
        /// 内容摘要: 插入一条新纪录
        /// </summary>
        /// <returns>int</returns>
        public int Insert(Hotelorder obj)
        {
            return HotelorderDao.GetInstance().Insert(obj);
        }

        /// <summary>
        /// 方法名称: Update
        /// 内容摘要: 更新一条新纪录
        /// </summary>
        /// <returns>int</returns>
        public int Update(Hotelorder obj)
        {
            HotelorderDao.GetInstance().Update(obj);
            return 1;
        }

        /// <summary>
        /// 方法名称: Delete
        /// 内容摘要: 删除一条新纪录
        /// </summary>
        /// <returns>int</returns>
        public int Delete(Hotelorder obj)
        {
            HotelorderDao.GetInstance().DeleteByID(obj.GetKey());
            return 1;
        }
		
		
		#endregion
		
    }
	#endregion
}