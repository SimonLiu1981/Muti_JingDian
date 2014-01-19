using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using dx177.Model.Bus;
using dx177.FrameWork;
using dx177.DataAccess.Access.Bus;
using System.Collections;
using dx177.Access.Bus;

namespace dx177.Business.Bus
{

    public partial class RoompriceBLL : BaseBLL<Roomprice>
    {

         
        public List<Roomprice> GetRoomprice(string guid ,string sdate,string edate)
        {
            string sql = string.Format(" select * from RoomPrice  where pguid='{0}'  and SDate>='{1}' and EDate<='{2} 23:59:59' ", guid, sdate, edate);
            DataTable dt = this.GetDataTable(sql);
            if (dt.Rows.Count <= 0)
            {
                return null ;
            }
            else
            {
                return Roomprice.Dt2Objs(dt);
            }
        }

        public DataTable  GetRoomprice(string guid )
        {
            string sql = string.Format("  select  a.*, b.RoomTitle as RoomTitle ,(select name  from Hotel as c  where  c.guid=b.pguid ) as HotelName   from RoomPrice as a inner join room  as b on b.GUID=a.PGUID  where a.pguid='{0}'  ", guid);
            DataTable dt = this.GetDataTable(sql);
            return dt;
        }
       
    }



    #region 代码自动生成
    /// <summary>
    /// Roomprice的BLL
    /// 该BLL已经生成了基本的业务操作，在自动生成的方法中已经提供了事务机制
    /// </summary>
    public partial class RoompriceBLL : BaseBLL<Roomprice>
    {
        #region 自动生成代码：取得相关实体

        /// <summary>
        /// 方法名称: RoompriceBLL
        /// 内容摘要: 构造函数进行初始化
        /// </summary>
        protected RoompriceBLL()
        {
        }
        private static volatile RoompriceBLL m_instance = null;
        /// <summary>
        /// 方法名称: GetInstance
        /// 内容摘要: 取得 RoompriceBLL 对象
        /// </summary>
        /// <returns>返回一个已经存在的实体</returns>
        public static RoompriceBLL GetInstance()
        {
            // 通用的必要代码 iBatisNet双校检机制,如果实例不存在
            if (m_instance == null)
            {
                lock (typeof(RoompriceBLL))
                {

                    // 如果实例不存在
                    if (m_instance == null)
                    {

                        // 创建一个的实例
                        m_instance = new RoompriceBLL();
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
        /// <returns>Roomprice</returns>
        public Roomprice Get(Roomprice.Key key)
        {
            return RoompriceDao.GetInstance().SelectByID(key);
        }
        /// <summary>
        /// 方法名称: Select
        /// 内容摘要: 基本查询，不带任何条件的查询
        /// </summary>
        public IList Select()
        {
            return RoompriceDao.GetInstance().SelectAll();
        }
        /// <summary>
        /// 方法名称: Insert
        /// 内容摘要: 插入一条新纪录
        /// </summary>
        /// <returns>int</returns>
        public int Insert(Roomprice obj)
        {
            return RoompriceDao.GetInstance().Insert(obj);
        }

        /// <summary>
        /// 方法名称: Update
        /// 内容摘要: 更新一条新纪录
        /// </summary>
        /// <returns>int</returns>
        public int Update(Roomprice obj)
        {
            RoompriceDao.GetInstance().Update(obj);
            return obj.Seqno;
        }

        /// <summary>
        /// 方法名称: Delete
        /// 内容摘要: 删除一条新纪录
        /// </summary>
        /// <returns>int</returns>
        public int Delete(Roomprice obj)
        {
            RoompriceDao.GetInstance().DeleteByID(obj.GetKey());
            return obj.Seqno;
        }

        #endregion

    }
    #endregion
}
