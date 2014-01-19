/*
版权所有：版权所有(C) 2011，刘建新
文件编号：M01_ShopBll.cs
文件名称：ShopBll.cs
系统编号：Z0003007
系统名称：通用办公系统
模块编号：M01
模块名称：信息发布
设计文档：IOA_M01信息发布XDE建模.mdx
完成日期：2011/3/18
作　　者：
内容摘要：表[Shop]业务操作类
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using dx177.Model.Bus;
using dx177.Model.Bus.QueryO;
using dx177.Model;
using System.IO;
using dx177.DataAccess.Access.Bus;
using System.Collections;
using dx177.Access.Bus;
using CampanyCMS.Model.Bus;

namespace dx177.Business.Bus
{
    /// <summary>
	/// Shop的BLL 自定义方法
	/// 该BLL已经生成了基本的业务操作，在自动生成的方法中已经提供了事务机制
	/// </summary>
    public partial class ShopBLL : BaseBLL<Shop>
    {
        /// <summary>
        /// 删除饭店
        /// </summary>
        /// <param name="seqno"></param>
        public void RemoveByseqno(int seqno)
        {
            Shop s = ShopBLL.GetInstance().Get(new Shop.Key(seqno));
            ShopBLL.GetInstance().Delete(s);
            PicturelistBLL.GetInstance().DeleteByPGuid(s.Guid);
            if (File.Exists(System.Web.HttpContext.Current.Server.MapPath(s.Logo)))
            {
                File.Delete(System.Web.HttpContext.Current.Server.MapPath(s.Logo));
            }
           
        }

        public DataTable GetShopData( ShopQuery s)
        {
            string sql = "select  *  from  Shop where title like '%{0}%' and (biztype='{1}' or '{1}'='')  and (JingQuCode ='{2}' or '{2}'='')   ";
            sql = string.Format(sql, s.Title, s.BizType, s.JingQuCode);
            if (!string.IsNullOrEmpty(s.OpenStatus))
            {
                sql += string.Format( " and Status={0} ",s.OpenStatus  );
            }

            if (!string.IsNullOrEmpty(s.Creator ))
            {
                sql += string.Format(" and (creator='{0}' or '{1}'='{0}')  ", s.Creator ,AppContext.Admin );
            }
            DataTable dt = this.GetDataTable(sql);
            return dt;
        }


        public Shop Submit(Shop s)
        {
            IList<Picturelist> dd = PicturelistBLL.GetInstance().GetPicsByGuid(s.Guid);
            if (dd.Count > 0)
            {
                s.Logo = dd[0].Smallimgfile;
            }


            s.LasteUpdateDate = DateTime.Now;
            if (s.Seqno > 0)
            {

                this.Update(s);
            }
            else
            {

                this.Insert(s);
            }
            BuildPageBLL.BuildOnePage("店铺", s.Creator, s.Seqno.ToString());
            PicturelistBLL.GetInstance().UpdateToUsed(s.Guid,s.Creator);
            return s;
        }

       
    }
 
 
    #region 代码自动生成
	/// <summary>
	/// Shop的BLL
	/// 该BLL已经生成了基本的业务操作，在自动生成的方法中已经提供了事务机制
	/// </summary>
    public partial class ShopBLL : BaseBLL<Shop>
    {
        #region 自动生成代码：取得相关实体

		/// <summary>
		/// 方法名称: ShopBLL
		/// 内容摘要: 构造函数进行初始化
		/// </summary>
		protected ShopBLL()
		{
		}
		private static volatile ShopBLL m_instance = null;
		/// <summary>
		/// 方法名称: GetInstance
		/// 内容摘要: 取得 ShopBLL 对象
		/// </summary>
		/// <returns>返回一个已经存在的实体</returns>
		public static ShopBLL GetInstance()
		{
			// 通用的必要代码 iBatisNet双校检机制,如果实例不存在
			if (m_instance == null)
			{
				lock (typeof (ShopBLL))
				{

					// 如果实例不存在
					if (m_instance == null)
					{

						// 创建一个的实例
						m_instance = new ShopBLL();
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
        /// <returns>Shop</returns>
        public Shop Get(Shop.Key key)
        {
            return ShopDao.GetInstance().SelectByID(key);
        }
        /// <summary>
        /// 方法名称: Select
        /// 内容摘要: 基本查询，不带任何条件的查询
        /// </summary>
        public IList Select()
        {
            return ShopDao.GetInstance().SelectAll();
        }
        /// <summary>
        /// 方法名称: Insert
        /// 内容摘要: 插入一条新纪录
        /// </summary>
        /// <returns>int</returns>
        public int Insert(Shop obj)
        {
            return ShopDao.GetInstance().Insert(obj);
        }

        /// <summary>
        /// 方法名称: Update
        /// 内容摘要: 更新一条新纪录
        /// </summary>
        /// <returns>int</returns>
        public int Update(Shop obj)
        {
            ShopDao.GetInstance().Update(obj);
            return 1;
        }

        /// <summary>
        /// 方法名称: Delete
        /// 内容摘要: 删除一条新纪录
        /// </summary>
        /// <returns>int</returns>
        public int Delete(Shop obj)
        {
            ShopDao.GetInstance().DeleteByID(obj.GetKey());
            return 1;
        }
		
		#endregion
		
    }
	#endregion
}