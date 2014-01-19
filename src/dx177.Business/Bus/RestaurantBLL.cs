/*
版权所有：版权所有(C) 2011，刘建新
文件编号：M01_RestaurantBll.cs
文件名称：RestaurantBll.cs
系统编号：Z0003007
系统名称：通用办公系统
模块编号：M01
模块名称：信息发布
设计文档：IOA_M01信息发布XDE建模.mdx
完成日期：2011/3/18
作　　者：
内容摘要：表[Restaurant]业务操作类
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

namespace dx177.Business.Bus
{
    /// <summary>
	/// Restaurant的BLL 自定义方法
	/// 该BLL已经生成了基本的业务操作，在自动生成的方法中已经提供了事务机制
	/// </summary>
    public partial class RestaurantBLL : BaseBLL<Restaurant>
    {
        /// <summary>
        /// 删除饭店
        /// </summary>
        /// <param name="seqno"></param>
        public void RemoveRestaurant(string seqno)
        {
            Restaurant rest = RestaurantBLL.GetInstance().Get(new Restaurant.Key(int.Parse(seqno)));
            RestaurantBLL.GetInstance().Delete(rest);
            PicturelistBLL.GetInstance().DeleteByPGuid(rest.Guid);
            if (File.Exists(System.Web.HttpContext.Current.Server.MapPath(rest.Logo)))
            {
                File.Delete(System.Web.HttpContext.Current.Server.MapPath(rest.Logo));
            }
            CookbookBLL.GetInstance().RemoveByRestaurantGuid(rest.Guid);
            SumarycommentBLL.GetInstance().RemoveSumarycommentbyPguid(rest.Guid);
        }

        public Restaurant Submit(Restaurant rest)
        {

            IList<Picturelist> dd = PicturelistBLL.GetInstance().GetPicsByGuid(rest.Guid);
            if (dd.Count > 0)
            {
                rest.Logo = dd[0].Smallimgfile;
            }

            rest.LasteUpdateDate = DateTime.Now;
            if (rest.Seqno > 0)
            {
                this.Update(rest);
            }
            else
            {
                this.Insert(rest);
            }
            SumarycommentBLL.GetInstance().GetSumarycommentByPGuid(rest.Guid);//生成
            PicturelistBLL.GetInstance().UpdateToUsed(rest.Guid, rest.Creator);
            
            return rest;
        }

        public Restaurant GetRestaurantByGuid(string Guid)
        {
            string sql = @"select *   from  Restaurant where  Guid='{0}'  ";
            sql = string.Format(sql, Guid);
            DataTable dt = this.GetDataTable(sql);
            if (dt != null && dt.Rows.Count > 0)
            {
                return Restaurant.Dr2Obj(dt.Rows[0], Restaurant.ColumnNameEnum.DBName);                
            }
            return null;
        }

        public IList<Restaurant> Search(RestaurantQuery query)
        {
            string sql = string.Format("select * from Restaurant where 1=1  and (Jingqucode='{0}' or '{0}'='') ", query.JingQuCode);
            if (!string.IsNullOrEmpty(query.Title))
            {
                sql += string.Format(" and Title like '%{0}%'", query.Title);
            }
            if (!string.IsNullOrEmpty(query.OpenStatus))
            {
                sql += string.Format(" and status ={0}", query.OpenStatus);
            }
            if (!string.IsNullOrEmpty(query.Creator))
            {
                sql += string.Format(" and (Creator ='{0}' or '{0}'='{1}') ", query.Creator,AppContext.Admin );
            }
            sql += " order by Laste_Update_Date desc ";
            return Restaurant.Dt2Objs(this.GetDataTable(sql));
        }


        public DataTable GetResData(string area, string restauranttype)
        {
            string sql = string.Format(@"select * , (select count(1) from Comment where isshow=1 and pguid=a.guid) as Comment  from Restaurant  as a 
                                      where (area='{0}' or ''='{0}' ) and( restauranttype='{1}' or ''='{1}' )  and status=1 ", area, restauranttype);
            DataTable dt = this.GetDataTable(sql);
            return dt;
        }

    }
 
 
    #region 代码自动生成
	/// <summary>
	/// Restaurant的BLL
	/// 该BLL已经生成了基本的业务操作，在自动生成的方法中已经提供了事务机制
	/// </summary>
    public partial class RestaurantBLL : BaseBLL<Restaurant>
    {
        #region 自动生成代码：取得相关实体

		/// <summary>
		/// 方法名称: RestaurantBLL
		/// 内容摘要: 构造函数进行初始化
		/// </summary>
		protected RestaurantBLL()
		{


		}
		private static volatile RestaurantBLL m_instance = null;
		/// <summary>
		/// 方法名称: GetInstance
		/// 内容摘要: 取得 RestaurantBLL 对象
		/// </summary>
		/// <returns>返回一个已经存在的实体</returns>
		public static RestaurantBLL GetInstance()
		{
			// 通用的必要代码 iBatisNet双校检机制,如果实例不存在
			if (m_instance == null)
			{
				lock (typeof (RestaurantBLL))
				{

					// 如果实例不存在
					if (m_instance == null)
					{

						// 创建一个的实例
						m_instance = new RestaurantBLL();
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
        /// <returns>Restaurant</returns>
        public Restaurant Get(Restaurant.Key key)
        {
            return RestaurantDao.GetInstance().SelectByID(key);
        }
        /// <summary>
        /// 方法名称: Select
        /// 内容摘要: 基本查询，不带任何条件的查询
        /// </summary>
        public IList Select()
        {
            return RestaurantDao.GetInstance().SelectAll();
        }
        /// <summary>
        /// 方法名称: Insert
        /// 内容摘要: 插入一条新纪录
        /// </summary>
        /// <returns>int</returns>
        public int Insert(Restaurant obj)
        {
            return RestaurantDao.GetInstance().Insert(obj);
        }

        /// <summary>
        /// 方法名称: Update
        /// 内容摘要: 更新一条新纪录
        /// </summary>
        /// <returns>int</returns>
        public int Update(Restaurant obj)
        {
            RestaurantDao.GetInstance().Update(obj);
            return 1;
        }

        /// <summary>
        /// 方法名称: Delete
        /// 内容摘要: 删除一条新纪录
        /// </summary>
        /// <returns>int</returns>
        public int Delete(Restaurant obj)
        {
            RestaurantDao.GetInstance().DeleteByID(obj.GetKey());
            return 1;
        }
		
		
		#endregion
		
    }
	#endregion
}