/*
版权所有：版权所有(C) 2011，刘建新
文件编号：M01_CookbookBll.cs
文件名称：CookbookBll.cs
系统编号：Z0003007
系统名称：通用办公系统
模块编号：M01
模块名称：信息发布
设计文档：IOA_M01信息发布XDE建模.mdx
完成日期：2011/3/18
作　　者：
内容摘要：表[Cookbook]业务操作类
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using dx177.Model.Bus;
using System.Collections;
using System.IO;
using dx177.DataAccess.Access.Bus;

namespace dx177.Business.Bus
{
    /// <summary>
	/// Cookbook的BLL 自定义方法
	/// 该BLL已经生成了基本的业务操作，在自动生成的方法中已经提供了事务机制
	/// </summary>
    public partial class CookbookBLL : BaseBLL<Cookbook>
    {
        public IList<Cookbook> GetCookBookByPGuid(string pguid)
        {
            string sql = string.Format("select * from Cookbook where pguid= '{0}'", pguid);
            DataTable dt = this.GetDataTable(sql);
            return Cookbook.Dt2Objs(dt);
        }

        /// <summary>
        /// 删除菜谱
        /// </summary>
        /// <param name="pguid"></param>
        public void RemoveByRestaurantGuid(string pguid)
        {

            string sql = string.Format("select * from Cookbook where pguid= '{0}'", pguid);
            DataTable dt = this.GetDataTable(sql);

            foreach (DataRow dr in dt.Rows)
            {
                RemoveBySeqno(int.Parse(dr["seqno"].ToString()));
            }
            sql = string.Format("Delete from Cookbook where  pguid= '{0}'", pguid);
            this.Execute(sql);
        }

        /// <summary>
        /// 删除菜谱
        /// </summary>
        /// <param name="pguid"></param>
        public void RemoveBySeqno(int pguid)
        {

            Cookbook obj = CookbookBLL.GetInstance().Get(new Cookbook.Key(pguid));
            this.Delete(obj);
            //删除文件
            if (File.Exists(System.Web.HttpContext.Current.Server.MapPath(obj.Logo)))
            {
                File.Delete(System.Web.HttpContext.Current.Server.MapPath(obj.Logo));
            }
        }

        


        /// <summary>
        /// 提交图片
        /// </summary>
        /// <param name="obj"></param>
        public Cookbook Submit(Cookbook obj)
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
    }
 
 
    #region 代码自动生成
	/// <summary>
	/// Cookbook的BLL
	/// 该BLL已经生成了基本的业务操作，在自动生成的方法中已经提供了事务机制
	/// </summary>
    public partial class CookbookBLL : BaseBLL<Cookbook>
    {
        #region 自动生成代码：取得相关实体

		/// <summary>
		/// 方法名称: CookbookBLL
		/// 内容摘要: 构造函数进行初始化
		/// </summary>
		protected CookbookBLL()
		{
		}
		private static volatile CookbookBLL m_instance = null;
		/// <summary>
		/// 方法名称: GetInstance
		/// 内容摘要: 取得 CookbookBLL 对象
		/// </summary>
		/// <returns>返回一个已经存在的实体</returns>
		public static CookbookBLL GetInstance()
		{
			// 通用的必要代码 iBatisNet双校检机制,如果实例不存在
			if (m_instance == null)
			{
				lock (typeof (CookbookBLL))
				{

					// 如果实例不存在
					if (m_instance == null)
					{

						// 创建一个的实例
						m_instance = new CookbookBLL();
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
		/// <returns>Cookbook</returns>
		public Cookbook Get(Cookbook.Key key)
		{
            return CookbookDao.GetInstance().SelectByID(key);
			//return base.ISqlDao.SelectOne(key.Seqno);
		}
		/// <summary>
		/// 方法名称: Select
		/// 内容摘要: 基本查询，不带任何条件的查询
		/// </summary>
		public IList Select()
        {
            return CookbookDao.GetInstance().SelectAll();
           //return base.ISqlDao.SelectAll();           
        }
		/// <summary>
		/// 方法名称: Insert
		/// 内容摘要: 插入一条新纪录
		/// </summary>
		/// <returns>int</returns>
		public int Insert(Cookbook obj)
		{
            return CookbookDao.GetInstance().Insert(obj);
		}
		
		/// <summary>
		/// 方法名称: Update
		/// 内容摘要: 更新一条新纪录
		/// </summary>
		/// <returns>int</returns>
		public int Update(Cookbook obj)
		{
            CookbookDao.GetInstance().Update(obj);
            return 1;
		}
		
		/// <summary>
		/// 方法名称: Delete
		/// 内容摘要: 删除一条新纪录
		/// </summary>
		/// <returns>int</returns>
		public int Delete(Cookbook obj)
		{
            CookbookDao.GetInstance().DeleteByID(obj.GetKey());
            return 1;
		}
		
		#endregion
		
    }
	#endregion
}