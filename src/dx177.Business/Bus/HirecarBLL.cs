/*
版权所有：版权所有(C) 2011，刘建新
文件编号：M01_HirecarBll.cs
文件名称：HirecarBll.cs
系统编号：Z0003007
系统名称：通用办公系统
模块编号：M01
模块名称：信息发布
设计文档：IOA_M01信息发布XDE建模.mdx
完成日期：2011/3/18
作　　者：
内容摘要：表[HireCar]业务操作类
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using dx177.Model.Bus;
using dx177.Model.Bus.QueryO;
using System.IO;
using dx177.Model;
using dx177.DataAccess.Access.Bus;
using System.Collections;
using dx177.Access.Bus;
using CampanyCMS.Model.Bus;

namespace dx177.Business.Bus
{
    /// <summary>
	/// Hirecar的BLL 自定义方法
	/// 该BLL已经生成了基本的业务操作，在自动生成的方法中已经提供了事务机制
	/// </summary>
    public partial class HirecarBLL : BaseBLL<Hirecar>
    {

        public IList<Hirecar> Search(HireCarQuery query)
        {
            string sql = string.Format("select * from Hirecar where  1=1   and (JingQuCode ='{0}' or '{0}'='') ", query.JingQuCode);
            if (!string.IsNullOrEmpty(query.Title))
            {
                sql += string.Format(" and title like '{0}'", query.Title);
            }
            if (!string.IsNullOrEmpty(query.OpenStatus))
            {
                sql += string.Format(" and status ={0}", query.OpenStatus);
            }
            if (!string.IsNullOrEmpty(query.Creator))
            {
                sql += string.Format(" and (Creator ='{0}' or '{0}'='{1}')", query.Creator,AppContext.Admin );
            }

            sql += " order by seqno desc";
            DataTable dt = this.GetDataTable(sql);
            return Hirecar.Dt2Objs(dt);

        }



        public IList<Hirecar> Search(int top, HireCarQuery query)
        {
            string sql =string.Format( "select top {0} * from Hirecar where 1=1 ",top );
            if (!string.IsNullOrEmpty(query.Title))
            {
                sql += string.Format(" and title like '{0}'", query.Title);
            }
            if (!string.IsNullOrEmpty(query.OpenStatus))
            {
                sql += string.Format(" and status ={0}", query.OpenStatus);
            }
            if (!string.IsNullOrEmpty(query.Creator))
            {
                sql += string.Format(" and (Creator ='{0}' or '{0}'='{1}')", query.Creator, AppContext.Admin);
            }

            sql += " order by seqno desc";
            DataTable dt = this.GetDataTable(sql);
            return Hirecar.Dt2Objs(dt);

        }


        /// <summary>
        /// 查询显示到前台页面的方法
        /// </summary>
        /// <param name="moduleCode"></param>
        /// <returns></returns>
        public List<Hirecar> Font_Search(string moduleCode)
        {
            List<Hirecar> hl = new List<Hirecar>();
            string sql = " select h.*  from Hirecar h ";
            if (!string.IsNullOrEmpty(moduleCode))
            {
                sql += string.Format(" inner join Module m on ( h.guid = m.pguid ) where  h.status=1  and  modulecode='{0}' ", moduleCode);
                sql += " order by m.showidx desc, h.seqno desc";
            }
            else
            {
                sql += " order by   h.seqno desc";
            }
            DataTable dt = this.GetDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                hl = Hirecar.Dt2Objs(dt);
            }
            return hl;
        }

        /// <summary>
        /// 删除某个租车信息
        /// </summary>
        /// <param name="seqno"></param>
        public void RemoveHirecar(string seqno)
        {
            Hirecar rest = Get(new Hirecar.Key(int.Parse(seqno)));
            Delete(rest);
            //删除关联图片
            PicturelistBLL.GetInstance().DeleteByPGuid(rest.Guid);
            //删除Logo图片
            if (File.Exists(System.Web.HttpContext.Current.Server.MapPath(rest.Logo)))
            {
                File.Delete(System.Web.HttpContext.Current.Server.MapPath(rest.Logo));
            }
        }


        public Hirecar Submit(Hirecar rest)
        {
            IList<Picturelist> dd = PicturelistBLL.GetInstance().GetPicsByGuid(rest.Guid);
            if (dd.Count > 0)
            {
                rest.Logo = dd[0].Smallimgfile;
            }

            if (rest.Seqno > 0)
            {
                this.Update(rest);
            }
            else
            {
                rest.CreateDate = DateTime.Now;
                this.Insert(rest);
            }
            BuildPageBLL.BuildOnePage("租车", rest.Creator, rest.Seqno.ToString());

            PicturelistBLL.GetInstance().UpdateToUsed(rest.Guid, rest.Creator);
            return rest;
        }


        public DataTable GetLeftHirecar(string jingqucode)
        {
            string sql = @"select top 10 *,  '/'+(select top 1  matchdomain from JingQus as jq  where  jq.jingqucode=a.JingQuCode)+'/' AS JQCOD_PATH    from HireCar  as a 
                             where a.jingqucode='{0}'";
            sql = string.Format(sql, jingqucode);
            DataTable dt = this.GetDataTable(sql);
            return dt;
        }
    }
 
 
    #region 代码自动生成
	/// <summary>
	/// Hirecar的BLL
	/// 该BLL已经生成了基本的业务操作，在自动生成的方法中已经提供了事务机制
	/// </summary>
    public partial class HirecarBLL : BaseBLL<Hirecar>
    {
        #region 自动生成代码：取得相关实体

		/// <summary>
		/// 方法名称: HirecarBLL
		/// 内容摘要: 构造函数进行初始化
		/// </summary>
		protected HirecarBLL()
		{
		}
		private static volatile HirecarBLL m_instance = null;
		/// <summary>
		/// 方法名称: GetInstance
		/// 内容摘要: 取得 HirecarBLL 对象
		/// </summary>
		/// <returns>返回一个已经存在的实体</returns>
		public static HirecarBLL GetInstance()
		{
			// 通用的必要代码 iBatisNet双校检机制,如果实例不存在
			if (m_instance == null)
			{
				lock (typeof (HirecarBLL))
				{

					// 如果实例不存在
					if (m_instance == null)
					{

						// 创建一个的实例
						m_instance = new HirecarBLL();
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
		/// <returns>Hirecar</returns>
		public Hirecar Get(Hirecar.Key key)
		{
            return HirecarDao.GetInstance().SelectByID(key);
		}
		/// <summary>
		/// 方法名称: Select
		/// 内容摘要: 基本查询，不带任何条件的查询
		/// </summary>
		public IList  Select()
        {
            return HirecarDao.GetInstance().SelectAll();
        }
		/// <summary>
		/// 方法名称: Insert
		/// 内容摘要: 插入一条新纪录
		/// </summary>
		/// <returns>int</returns>
		public int Insert(Hirecar obj)
		{
            return HirecarDao.GetInstance().Insert(obj);
		}
		
		/// <summary>
		/// 方法名称: Update
		/// 内容摘要: 更新一条新纪录
		/// </summary>
		/// <returns>int</returns>
		public int Update(Hirecar obj)
		{
            HirecarDao.GetInstance().Update(obj);
            return obj.Seqno;
		}
		
		/// <summary>
		/// 方法名称: Delete
		/// 内容摘要: 删除一条新纪录
		/// </summary>
		/// <returns>int</returns>
		public int Delete(Hirecar obj)
		{
            HirecarDao.GetInstance().DeleteByID(obj.GetKey());
            return obj.Seqno;
		}
		
		#endregion
		
    }
	#endregion
}