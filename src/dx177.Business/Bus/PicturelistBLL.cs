/*
版权所有：版权所有(C) 2011，刘建新
文件编号：M01_PicturelistBll.cs
文件名称：PicturelistBll.cs
系统编号：Z0003007
系统名称：通用办公系统
模块编号：M01
模块名称：信息发布
设计文档：IOA_M01信息发布XDE建模.mdx
完成日期：2011/3/18
作　　者：
内容摘要：表[PictureList]业务操作类
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using dx177.Model.Bus;
using System.Collections;
using System.Web.UI;
using System.IO;
using dx177.Model.Bus.QueryO;
using dx177.DataAccess.Access.Bus;
using dx177.Access.Bus;

namespace dx177.Business.Bus
{
    /// <summary>
	/// Picturelist的BLL 自定义方法
	/// 该BLL已经生成了基本的业务操作，在自动生成的方法中已经提供了事务机制
	/// </summary>
    public partial class PicturelistBLL : BaseBLL<Picturelist>
    {
        /// <summary>
        /// 通过GUID
        /// </summary>
        /// <param name="guid"></param>
        /// <returns></returns>
        public IList<Picturelist> GetPicsByGuid(string guid)
        {

            string sql = string.Format(@"select * from Picturelist f
			where 1=1 and pguid = '{0}' order by showidx", guid);
            DataTable dt = this.GetDataTable(sql);
            return Picturelist.Dt2Objs(dt);
            //return this.ISqlDao.Select("Picturelist_GetPicsByGuid", hs); 
        }

        /// <summary>
        /// 提交图片
        /// </summary>
        /// <param name="obj"></param>
        public Picturelist Submit(Picturelist obj)
        {
            if (obj.Seqno > 0)
            {
                this.Update(obj);
            }
            else
            {
                this.Insert(obj);
            }
            return obj;
        }

        public void DeleteByPGuid(string pguid)
        {
            string sql = string.Format("select * from Picturelist where pguid= '{0}'", pguid);
            DataTable dt = this.GetDataTable(sql);
            List<Picturelist> list = Picturelist.Dt2Objs(dt);
            foreach (var dr in list)
            {
                Delete(dr.Seqno);
            }
        }

        /// <summary>
        /// 删除，并删除图片
        /// </summary>
        /// <param name="seqno"></param>
        public void Delete(int seqno)
        {
            Picturelist obj = PicturelistBLL.GetInstance().Get(new Picturelist.Key(seqno));
            this.Delete(obj);

                        
            if (obj.Bigimgfile != string.Empty && File.Exists(System.Web.HttpContext.Current.Server.MapPath(obj.Bigimgfile)))
            {
                File.Delete(System.Web.HttpContext.Current.Server.MapPath(obj.Bigimgfile));
            }

            if (obj.Bigimgfile != string.Empty && File.Exists(System.Web.HttpContext.Current.Server.MapPath(UploadPicturesBLL.Get100pxPath(obj.Bigimgfile))))
            {
                File.Delete(System.Web.HttpContext.Current.Server.MapPath(UploadPicturesBLL.Get100pxPath(obj.Bigimgfile)));
            }

            if (obj.Bigimgfile != string.Empty && File.Exists(System.Web.HttpContext.Current.Server.MapPath(UploadPicturesBLL.Get300pxPath(obj.Bigimgfile))))
            {
                File.Delete(System.Web.HttpContext.Current.Server.MapPath(UploadPicturesBLL.Get300pxPath(obj.Bigimgfile)));
            }

            if (obj.Bigimgfile != string.Empty && File.Exists(System.Web.HttpContext.Current.Server.MapPath(UploadPicturesBLL.Get600pxPath(obj.Bigimgfile))))
            {
                File.Delete(System.Web.HttpContext.Current.Server.MapPath(UploadPicturesBLL.Get600pxPath(obj.Bigimgfile)));
            }

            if (obj.Smallimgfile != string.Empty && File.Exists(System.Web.HttpContext.Current.Server.MapPath(obj.Smallimgfile)))
            {
                File.Delete(System.Web.HttpContext.Current.Server.MapPath(obj.Smallimgfile));
            }

        }
        /// <summary>
        /// 更新图片被用
        /// </summary>
        /// <param name="pguid"></param>
        /// <param name="admin"></param>
        public void UpdateToUsed(string pguid, string userName)
        {
            string sql = string.Format("update PictureList set create_date=getdate(),creator='{0}' where pguid='{1}'", userName, pguid);
            this.Execute(sql);
        }

        public IList<Picturelist> Search(PicturelistQuery query)
        {
            string sql = string.Format(@"select * from Picturelist f
			                where 1=1 and (Creator='{0}' or '{0}'='')  and (JingQuCode ='{1}' or '{1}'='') ", query.CreateBy, query.JingQuCode);

            if (!string.IsNullOrEmpty(query.Title))
            {
                sql += string.Format(" and title like '%{0}%'", query.Title);
            }
            if (!string.IsNullOrEmpty(query.hasUsed) &&
                query.hasUsed == "1"
                )
            {
                sql += " and create_date > '1900-1-1'";
            }

            if (!string.IsNullOrEmpty(query.hasUsed) &&
                query.hasUsed == "0"
                )
            {
                sql += " and create_date = '1900-1-1'";
            }
            DataTable dt = this.GetDataTable(sql);
            return Picturelist.Dt2Objs(dt);
            //return this.ISqlDao.Select("Picturelist_Search", hs); 
                        
        }
    }
 
 
    #region 代码自动生成
	/// <summary>
	/// Picturelist的BLL
	/// 该BLL已经生成了基本的业务操作，在自动生成的方法中已经提供了事务机制
	/// </summary>
    public partial class PicturelistBLL : BaseBLL<Picturelist>
    {
        #region 自动生成代码：取得相关实体

		/// <summary>
		/// 方法名称: PicturelistBLL
		/// 内容摘要: 构造函数进行初始化
		/// </summary>
		protected PicturelistBLL()
		{
		}
		private static volatile PicturelistBLL m_instance = null;
		/// <summary>
		/// 方法名称: GetInstance
		/// 内容摘要: 取得 PicturelistBLL 对象
		/// </summary>
		/// <returns>返回一个已经存在的实体</returns>
		public static PicturelistBLL GetInstance()
		{
			// 通用的必要代码 iBatisNet双校检机制,如果实例不存在
			if (m_instance == null)
			{
				lock (typeof (PicturelistBLL))
				{

					// 如果实例不存在
					if (m_instance == null)
					{

						// 创建一个的实例
						m_instance = new PicturelistBLL();
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
		/// <returns>Picturelist</returns>
		public Picturelist Get(Picturelist.Key key)
		{
            return PicturelistDao.GetInstance().SelectByID(key);
		}
        /// <summary>
        /// 方法名称: Select
        /// 内容摘要: 基本查询，不带任何条件的查询
        /// </summary>
        public IList Select()
        {
            return PicturelistDao.GetInstance().SelectAll();
        }
		/// <summary>
		/// 方法名称: Insert
		/// 内容摘要: 插入一条新纪录
		/// </summary>
		/// <returns>int</returns>
		public int Insert(Picturelist obj)
        {
            return PicturelistDao.GetInstance().Insert(obj);
		}
		
		/// <summary>
		/// 方法名称: Update
		/// 内容摘要: 更新一条新纪录
		/// </summary>
		/// <returns>int</returns>
		public int Update(Picturelist obj)
		{
            PicturelistDao.GetInstance().Update(obj);
            return obj.Seqno;
		}
		
		/// <summary>
		/// 方法名称: Delete
		/// 内容摘要: 删除一条新纪录
		/// </summary>
		/// <returns>int</returns>
		public int Delete(Picturelist obj)
		{
            PicturelistDao.GetInstance().DeleteByID(obj.GetKey());
            return obj.Seqno; ;
		}
		
		#endregion
		
    }
	#endregion
}