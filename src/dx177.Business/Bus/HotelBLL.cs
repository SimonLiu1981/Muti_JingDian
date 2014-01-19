/*
版权所有：版权所有(C) 2011，刘建新
文件编号：M01_HotelBll.cs
文件名称：HotelBll.cs
系统编号：Z0003007
系统名称：通用办公系统
模块编号：M01
模块名称：信息发布
设计文档：IOA_M01信息发布XDE建模.mdx
完成日期：2011/3/18
作　　者：
内容摘要：表[Hotel]业务操作类
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
using dx177.DataAccess.Access;
using dx177.Access.Bus;
using dx177_building;
using dx177.FrameWork;
using CampanyCMS.Model.Bus;

namespace dx177.Business.Bus
{
    /// <summary>
	/// Hotel的BLL 自定义方法
	/// 该BLL已经生成了基本的业务操作，在自动生成的方法中已经提供了事务机制
	/// </summary>
    public partial class HotelBLL : BaseBLL<Hotel>
    {
        public DataTable GetHotelList(HotelQuery h)
        {
            string sql = @"select *   from  Hotel where name like '%{0}%' and (hoteltype='{1}' or '{1}'='' ) and  ((minprice<={2} and maxprice>={2}) or (minprice>={2} and minprice<={3} and maxprice>={2}))
                            and Laste_update_date between '{4} 00:00:01' and '{5} 23:59:59' and (Jingqucode='{7}' or '{7}'='')  order by  seqno  desc  ";
            sql = string.Format(sql,
                h.Name, 
                h.HotelType, 
                h.Price1, 
                h.Price2, 
                h.BeginDate, 
                h.EndDate,
                h.Creator,                 
                h.JingQuCode);

            DataTable dt = this.GetDataTable(sql);
            return dt ;
        }

        public DataTable RecommendHotel(string Jingqu)
        {
            string sql = @" select top 5  * from (
                (select top 5 h.*  , '/'+ h.JingQuCode+'/'  as  JQRP_CODE   ,'/'+(select top 1  matchdomain from JingQus as jq  where  jq.jingqucode=h.JingQuCode)+'/' AS JQCOD_PATH  , ( select top 1 AreaName from JingQu_Area where JinqQuCode=h.area) as areaname 
                         from Hotel h,Module m where h.guid = m.pguid and h.status=1 and h.jingqucode='{0}' and modulecode='recommend'  ) union   all 
                (select top 5   h.*  , '/'+ h.JingQuCode+'/'  as  JQRP_CODE   ,'/'+(select top 1  matchdomain from JingQus as jq  where  jq.jingqucode=h.JingQuCode)+'/' AS JQCOD_PATH  , ( select top 1 AreaName from JingQu_Area where JinqQuCode=h.area) as areaname 
                            from Hotel h,Module m where h.guid = m.pguid and h.status=1  and modulecode='recommend'   ) )  as b  ";
            sql = string.Format(sql, Jingqu);
            DataTable dt = this.GetDataTable(sql);
            return dt;
        }

        public Hotel GetByHotelRefInfo(HotelRefType refType, string refHotelId)
        {
            string sql = @"select * from  Hotel where refType={0} and refhotelid={1}  ";
            sql = string.Format(sql, refType.ToString("d"), refHotelId);
            DataTable dt = this.GetDataTable(sql);
            if (dt != null && dt.Rows.Count > 0)
            {
                return Hotel.Dr2Obj(dt.Rows[0], Hotel.ColumnNameEnum.DBName);
            }
            return null;
        }

        public DataTable SearchHotel(HotelQuery h)
        {

            string sql = @"select  a.* ,(select top 1 tag_name  from Base_Dict_Tag where enum_value=a.HotelType and enum_type_name='HotelType' ) as  hoteltypename
                        , isnull( scount1 ,0) as scount ,isnull(  AvgScore ,0) as AvgScore  , (select top 1  matchdomain from JingQus as jq  where  jq.jingqucode=a.JingQuCode)  AS matchdomain 
                        from  Hotel as a left join SumaryComment as b on  b.pguid =a.guid  where a.status=1  and  name like '%{0}%' and (hoteltype='{1}' or '{1}'='' )  and (Jingqucode='{5}' or '{5}'='') and  (area='{4}' or ''='{4}' )  and ((minprice<={2} and maxprice>={2}) or (minprice>={2} and minprice<={3} and maxprice>={2}))    order by  a.ShowPr  desc , a.seqno desc   ";
            sql = string.Format(sql, h.Name, h.HotelType, h.Price1, h.Price2, h.Area, h.JingQuCode);

            DataTable dt = this.GetDataTable(sql);
            return dt ;
        }

        public DataTable GetHotePicList(int seqno)
        {
            string sql = @"select * from PictureList where  pguid in (select guid from Hotel where seqno={0}) 
                                                    or pguid in ( select guid  from Room where pguid in (select guid from Hotel where seqno ={0}) ) ";
            sql = string.Format(sql, seqno);
            DataTable dt = this.GetDataTable(sql);
            return dt;
        }

 
        /// <summary>
        /// 查询显示到前台页面的方法
        /// </summary>
        /// <param name="moduleCode"></param>
        /// <returns></returns>
        public List<Hotel> Font_Search(string moduleCode)
        {
            List<Hotel> res = new List<Hotel>();
            string sql = " select h.*,m.showidx  from Hotel h,Module m where h.guid = m.pguid and h.status=1 ";
            if (!string.IsNullOrEmpty(moduleCode))
            {
                sql += string.Format(" and modulecode='{0}' ", moduleCode);            
            }
            sql += " order by m.showidx desc";
            DataTable dt = this.GetDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                IList il = Hotel.Dt2Objs(dt);
                foreach (Hotel t in il)
                {
                    res.Add(t);
                }
            }
            return res;
        }

 
        public Hotel GetHotelByGuid(string Guid)
        {
            string sql = @"select *   from  Hotel where  Guid='{0}'  ";
            sql = string.Format(sql, Guid);
            DataTable dt = this.GetDataTable(sql);
            if (dt != null && dt.Rows.Count > 0)
            {
               return  Hotel.Dr2Obj(dt.Rows[0], Hotel.ColumnNameEnum.DBName);
            }
            return null;
        }
        /// <summary>
        /// 删除饭店
        /// </summary>
        /// <param name="seqno"></param>
        public void RemoveHotel(int  seqno)
        {
            Hotel h = HotelBLL.GetInstance().Get(new Hotel.Key(seqno));
            RoomBLL.GetInstance().RemoveByRoomGuid(h.Guid);
            SumarycommentBLL.GetInstance().RemoveSumarycommentbyPguid(h.Guid);
            HotelBLL.GetInstance().Delete(h);
            PicturelistBLL.GetInstance().DeleteByPGuid(h.Guid);
            if (File.Exists(System.Web.HttpContext.Current.Server.MapPath(h.Logo)))
            {
                File.Delete(System.Web.HttpContext.Current.Server.MapPath(h.Logo));
            }
        }


        /// <summary>
        /// 查询手机显示数据。
        /// </summary>
        /// <param name="minprice"></param>
        /// <param name="maxprice"></param>
        /// <param name="creator"></param>
        /// <returns></returns>
        public DataTable SearchMoblieData(decimal minprice, decimal maxprice, string creator)
        {
            string sql = string.Format(@" select a.* from Hotel a left join MyHotelList b  on (a.guid = b.pguid and b.creator = '{0}')
                        where ((minprice<={1} and maxprice>={1}) or (minprice>={1} and minprice<={2} and maxprice>={1}))  order by isnull(b.showindex,-1) desc ", creator, minprice, maxprice);

            return base.GetDataTable(sql);
        }


        /// <summary>
        /// 查询手机显示数据。
        /// </summary>
        /// <param name="minprice"></param>
        /// <param name="maxprice"></param>
        /// <param name="creator"></param>
        /// <returns></returns>
        public DataTable SearchMoblieData(int top, decimal minprice, decimal maxprice, string creator)
        {
            string sql = string.Format(@" select top {3} a.* from Hotel a left join MyHotelList b  on (a.guid = b.pguid and b.creator = '{0}')
                        where ((minprice<={1} and maxprice>={1}) or (minprice>={1} and minprice<={2} and maxprice>={1}))  order by isnull(b.showindex,-1) desc ", creator, minprice, maxprice, top);

            return base.GetDataTable(sql);
        }

        public Hotel Submit(Hotel h)
        {
            IList<Picturelist> dd = PicturelistBLL.GetInstance().GetPicsByGuid(h.Guid);
            if (dd.Count > 0)
            {
                h.Logo = dd[0].Smallimgfile;
            }

            h.LasteUpdateDate = DateTime.Now;
            if (h.Seqno > 0)
            {
               
                this.Update(h);
            }
            else
            {
                
                this.Insert(h);
            }
            //生成
            BuildPageBLL.BuildOnePage("酒店", h.Creator, h.Seqno.ToString());

            PicturelistBLL.GetInstance().UpdateToUsed(h.Guid, h.Creator);
            return h;
        }


         


        public void UpdateHotelMaxMinPrice(string Pguid)
        {
            Hotel h = HotelBLL.GetInstance().GetHotelByGuid(Pguid);
            h.Maxprice = RoomBLL.GetInstance().GetMaxPrice(Pguid);
            h.Minprice = RoomBLL.GetInstance().GetMinPrice(Pguid);
            HotelBLL.GetInstance().Update(h);
        }

        public void UpdateHotel(string Guid,Room r )
        {
             Hotel h=   GetHotelByGuid(Guid);
             if (r.Price1 < h.Minprice)
             {
                 h.Minprice = r.Price1;
             }
             if (r.Price2 > h.Maxprice)
             {
                 h.Maxprice = r.Price2;
             }
             this.Update(h);
        }

        public DataTable Search(HotelQuery query)
        {
            string sql = "select * from Hotel  where 1=1 ";
            if (!string.IsNullOrEmpty(query.Creator))
            {
                sql += string.Format(" and Creator ='{0}'", query.Creator);
            }
            sql += " order by seqno desc";
            DataTable dt = this.GetDataTable(sql);
            return dt;
        }

        public Hotel  GetHotelByUser(string UserName)
        {
            string sql =string.Format ( "select * from  Hotel where creator='{0}' ",UserName ) ;
            DataTable dt = this.GetDataTable(sql);
            if (dt != null && dt.Rows.Count > 0)
            {
                return Hotel.Dr2Obj(dt.Rows[0], Hotel.ColumnNameEnum.DBName);
            }
            return null;
        }

        public DataTable GetMyHotelList(string creator)
        {
            string sql = @"select  a.logo,a.area, a.Name, a.MaxPrice,a.MinPrice ,  '已加入'  as IsMyHotel ,b.showindex,b.seqno, a.seqno seqno1, a.guid   
from Hotel a left join MyHotelList b  on (a.guid = b.pguid and b.creator = '{0}')
order by isnull(b.showindex,-1) desc";
            sql = string.Format(sql, creator);
            DataTable dt = this.GetDataTable(sql);
            return dt;
        }


        public DataTable Search(HotelQuery h, int first, int pagesize)
        {
            string sql = @"select  a.*  ,(select count(1)  from Comment as b  where b.pguid=a.guid) COMMENTCOUNT,(select top 1 tag_name  from  Base_Dict_Tag where enum_type_name='AREA' and enum_value=a.area) as areaname ,a.area  AS AREASEQNO  ,(select top 1 tag_name  from  Base_Dict_Tag where enum_type_name='HotelType' and enum_value=a.HotelType) as sortname 
                        from  Hotel as a left join SumaryComment as b on  b.pguid =a.guid  where a.status=1  and  name like '%{0}%' and (hoteltype='{1}' or '{1}'='' )  and  (area='{4}' or ''='{4}' )  and ((minprice<={2} and maxprice>={2}) or (minprice>={2} and minprice<={3} and maxprice>={2}))    order by  a.ShowPr  desc , a.seqno desc   ";
            sql = string.Format(sql, h.Name, h.HotelType, h.Price1, h.Price2, h.Area);
            return DBTool.GetDataForPage(sql, first, pagesize);
        }

        public int SearchCount(HotelQuery h )
        {
            string sql = @"select  count(1) as tcount  from  Hotel as a left join SumaryComment as b on  b.pguid =a.guid  where a.status=1  and  name like '%{0}%' and (hoteltype='{1}' or '{1}'='' )  and  (area='{4}' or ''='{4}' )  and ((minprice<={2} and maxprice>={2}) or (minprice>={2} and minprice<={3} and maxprice>={2}))     ";
            sql = string.Format(sql, h.Name, h.HotelType, h.Price1, h.Price2, h.Area);
            DataTable dt = DBTool.ExecuteDataTable(sql );
            return int.Parse (dt.Rows[0]["tcount"].ToString());
        }
    }


 
 
    #region 代码自动生成
	/// <summary>
	/// Hotel的BLL
	/// 该BLL已经生成了基本的业务操作，在自动生成的方法中已经提供了事务机制
	/// </summary>
    public partial class HotelBLL : BaseBLL<Hotel>
    {
        #region 自动生成代码：取得相关实体

		/// <summary>
		/// 方法名称: HotelBLL
		/// 内容摘要: 构造函数进行初始化
		/// </summary>
		protected HotelBLL()
		{
		}
		private static volatile HotelBLL m_instance = null;
		/// <summary>
		/// 方法名称: GetInstance
		/// 内容摘要: 取得 HotelBLL 对象
		/// </summary>
		/// <returns>返回一个已经存在的实体</returns>
		public static HotelBLL GetInstance()
		{
			// 通用的必要代码 iBatisNet双校检机制,如果实例不存在
			if (m_instance == null)
			{
				lock (typeof (HotelBLL))
				{

					// 如果实例不存在
					if (m_instance == null)
					{

						// 创建一个的实例
						m_instance = new HotelBLL();
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
		/// <returns>Hotel</returns>
		public Hotel Get(Hotel.Key key)
		{
            return HotelDao.GetInstance().SelectByID(key);
		}
		/// <summary>
		/// 方法名称: Select
		/// 内容摘要: 基本查询，不带任何条件的查询
		/// </summary>
		public IList Select()
        {
            return HotelDao.GetInstance().SelectAll();    
        }
		/// <summary>
		/// 方法名称: Insert
		/// 内容摘要: 插入一条新纪录
		/// </summary>
		/// <returns>int</returns>
		public int Insert(Hotel obj)
		{
            return HotelDao.GetInstance().Insert(obj);
            
		}
		
		/// <summary>
		/// 方法名称: Update
		/// 内容摘要: 更新一条新纪录
		/// </summary>
		/// <returns>int</returns>
		public int Update(Hotel obj)
		{
            HotelDao.GetInstance().Update(obj);
            return obj.Seqno;
		}
		
		/// <summary>
		/// 方法名称: Delete
		/// 内容摘要: 删除一条新纪录
		/// </summary>
		/// <returns>int</returns>
		public int Delete(Hotel obj)
		{
            HotelDao.GetInstance().DeleteByID(obj.GetKey());
            return obj.Seqno;
		}
		
		#endregion
		
    }
	#endregion
}