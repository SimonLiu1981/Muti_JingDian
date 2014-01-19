/*
版权所有：版权所有(C) 2011，刘建新
文件编号：M01_RoomBll.cs
文件名称：RoomBll.cs
系统编号：Z0003007
系统名称：通用办公系统
模块编号：M01
模块名称：信息发布
设计文档：IOA_M01信息发布XDE建模.mdx
完成日期：2011/3/18
作　　者：
内容摘要：表[Room]业务操作类
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using dx177.Model.Bus;
using System.IO;
using dx177.Model.Bus.QueryO;
using dx177.Model;
using System.Collections;
using dx177.DataAccess.Access.Bus;

namespace dx177.Business.Bus
{
    /// <summary>
	/// Room的BLL 自定义方法
	/// 该BLL已经生成了基本的业务操作，在自动生成的方法中已经提供了事务机制
	/// </summary>
    public partial class RoomBLL : BaseBLL<Room>
    {

        public List<Room> GetRoomByname(string name, string pguid)
        {
            string sql = string.Format("select seqno from Room where pguid= '{0}' and Roomtitle='{1}'", pguid, name);
            DataTable dt = this.GetDataTable(sql);

            return Room.Dt2Objs(dt, BaseModel.ColumnNameEnum.DBName);
        }

        /// <summary>
        /// 删除房间
        /// </summary>
        /// <param name="pguid"></param>
        public void RemoveByRoomGuid(string pguid)
        {

            string sql = string.Format("select seqno from Room where pguid= '{0}'", pguid);
            DataTable dt = this.GetDataTable(sql);

            foreach (DataRow dr in dt.Rows)
            {
                RemoveBySeqno(int.Parse(dr["seqno"].ToString()));
            }
            sql = string.Format("Delete  from   Room  where pguid= '{0}'", pguid);
            this.Execute(sql);
        }
		
          /// <summary>
        /// 删除房间
        /// </summary>
        /// <param name="Seqno"></param>
        public void RemoveBySeqno(int Seqno)
        {
            Room obj = RoomBLL.GetInstance().Get(new Room.Key(Seqno));
            this.Delete(obj);
            PicturelistBLL.GetInstance().DeleteByPGuid(obj.Guid);

            Hotel h = HotelBLL.GetInstance().GetHotelByGuid(obj.Pguid);
            h.Maxprice = RoomBLL.GetInstance().GetMaxPrice(obj.Pguid);
            h.Minprice = RoomBLL.GetInstance().GetMinPrice(obj.Pguid);
            HotelBLL.GetInstance().Update(h);

            //删除文件
            if (File.Exists(System.Web.HttpContext.Current.Server.MapPath(obj.Logo)))
            {
                File.Delete(System.Web.HttpContext.Current.Server.MapPath(obj.Logo));
            }
        }

        private double RoomBLLGetMaxPrice(string p)
        {
            throw new NotImplementedException();
        }


        public DataTable GetRoom(RoomQuery q)
        {
            string sql = "";
            if (q.PGuid != string.Empty)
            {
                sql = @"   select b.name ,a.* from  Room as a inner join  Hotel as b on a.pguid=b.guid  where a.pguid='{0}' order by price1 asc ";
                sql = string.Format(sql, q.PGuid);
            }
            else
            {
                sql = @"select b.name ,a.* from  Room as a inner join  Hotel as b on a.pguid=b.guid
                                                    where b.name like '%{0}%' and b.hoteltype='{1}'  and  a.Laste_update_date between '{2} 00:00:01' and '{3} 23:59:59' 
                                                          and ((a.price1>={4} and a.price1<={5})  or (a.price2>={4} and a.price2<={5}))   order by price1 asc   ";
                sql = string.Format(sql, q.HotelName, q.HotelType, q.BeginDate, q.EndDate, q.minPrice, q.maxPrice);
            }
            DataTable dt = this.GetDataTable(sql);
            return dt ;
        }


        public Room Submit(Room r)
        {
            IList<Picturelist> dd = PicturelistBLL.GetInstance().GetPicsByGuid(r.Guid);
            if (dd.Count > 0)
            {
                r.Logo = dd[0].Smallimgfile;
            }

            r.LasteUpdateDate = DateTime.Now;
            if (r.Seqno > 0)
            {

                this.Update(r);
            }
            else
            {

                this.Insert(r);
            }
            HotelBLL.GetInstance().UpdateHotelMaxMinPrice(r.Pguid);
            PicturelistBLL.GetInstance().UpdateToUsed(r.Guid, r.Creator);
            return r;
        }

        public double GetMaxPrice(string Guid)
        {
            string sql =string.Format( "select max(price2) maxPrice    from Room where PGUID='{0}' " ,Guid );
            DataTable dt = this.GetDataTable(sql);
            if (dt != null && dt.Rows.Count > 0 && dt.Rows[0]["maxPrice"].ToString()!=string.Empty )
            {
                return double.Parse(dt.Rows[0]["maxPrice"].ToString());
            }
            return 0;
        }



        public double GetMinPrice(string Guid)
        {
            string sql = string.Format("select min(price1) minPrice    from Room where PGUID='{0}' ", Guid);
            DataTable dt = this.GetDataTable(sql);
            if (dt != null && dt.Rows.Count > 0 && dt.Rows[0]["minPrice"].ToString() != string.Empty)
            {
                return double.Parse(dt.Rows[0]["minPrice"].ToString());
            }
            return 0;
        }

        public DataTable GetRoomListByUsername(string Username)
        {
            string sql = string.Format("select  * from Room r where exists (select 1 from hotel h where  h.creator='{0}' and h.guid = r.pguid )  ", Username);
            DataTable dt = this.GetDataTable(sql);
            return dt;
        }


        public Room GetRoom(string Guid)
        {
            string sql = "select * from Room where GUID='" + Guid+"'";
             
            DataTable dt = this.GetDataTable(sql);
            if (dt != null && dt.Rows.Count > 0)
            {
                return Room.Dr2Obj(dt.Rows[0]);
            }
            return null ;
        }

    }
 
 
    #region 代码自动生成
	/// <summary>
	/// Room的BLL
	/// 该BLL已经生成了基本的业务操作，在自动生成的方法中已经提供了事务机制
	/// </summary>
    public partial class RoomBLL : BaseBLL<Room>
    {
        #region 自动生成代码：取得相关实体

		/// <summary>
		/// 方法名称: RoomBLL
		/// 内容摘要: 构造函数进行初始化
		/// </summary>
		protected RoomBLL()
		{
		}
		private static volatile RoomBLL m_instance = null;
		/// <summary>
		/// 方法名称: GetInstance
		/// 内容摘要: 取得 RoomBLL 对象
		/// </summary>
		/// <returns>返回一个已经存在的实体</returns>
		public static RoomBLL GetInstance()
		{
			// 通用的必要代码 iBatisNet双校检机制,如果实例不存在
			if (m_instance == null)
			{
				lock (typeof (RoomBLL))
				{

					// 如果实例不存在
					if (m_instance == null)
					{

						// 创建一个的实例
						m_instance = new RoomBLL();
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
        /// <returns>Room</returns>
        public Room Get(Room.Key key)
        {
            return RoomDao.GetInstance().SelectByID(key);
        }
        /// <summary>
        /// 方法名称: Select
        /// 内容摘要: 基本查询，不带任何条件的查询
        /// </summary>
        public IList Select()
        {
            return RoomDao.GetInstance().SelectAll();
        }
        /// <summary>
        /// 方法名称: Insert
        /// 内容摘要: 插入一条新纪录
        /// </summary>
        /// <returns>int</returns>
        public int Insert(Room obj)
        {
            return RoomDao.GetInstance().Insert(obj);
        }

        /// <summary>
        /// 方法名称: Update
        /// 内容摘要: 更新一条新纪录
        /// </summary>
        /// <returns>int</returns>
        public int Update(Room obj)
        {
            RoomDao.GetInstance().Update(obj);
            return 1;
        }

        /// <summary>
        /// 方法名称: Delete
        /// 内容摘要: 删除一条新纪录
        /// </summary>
        /// <returns>int</returns>
        public int Delete(Room obj)
        {
            RoomDao.GetInstance().DeleteByID(obj.GetKey());
            return 1;
        }
		
		#endregion
		
    }
	#endregion
}