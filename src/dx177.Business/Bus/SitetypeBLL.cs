/*
版权所有：版权所有(C) 2011，刘建新
文件编号：M01_SitetypeBll.cs
文件名称：SitetypeBll.cs
系统编号：Z0003007
系统名称：通用办公系统
模块编号：M01
模块名称：信息发布
设计文档：IOA_M01信息发布XDE建模.mdx
完成日期：2011-03-31
作　　者：
内容摘要：表[SiteType]业务操作类
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using dx177.Model.Bus;
using dx177.Model;
using dx177.DataAccess.Access.Bus;
using System.Collections;
using dx177.Access.Bus;

namespace dx177.Business.Bus
{
    /// <summary>
	/// Sitetype的BLL 自定义方法
	/// 该BLL已经生成了基本的业务操作，在自动生成的方法中已经提供了事务机制
	/// </summary>
    public partial class SitetypeBLL : BaseBLL<Sitetype>
    {

        public Sitetype GetNewstypeByguid(string guid)
        {
            string sql = string.Format("select * from Sitetype  where Guid='{0}' ", guid);
            DataTable dt = this.GetDataTable(sql);
            if (dt != null && dt.Rows.Count > 0)
            {
                return Sitetype.Dr2Obj(dt.Rows[0], Sitetype.ColumnNameEnum.DBName);
            }
            return null;
        }

        public DataTable GetSitetypeList(string jqcode)
        {
            string sql = string.Format("select * from SiteType  where  (Jingqucode='{0}' or  '{0}'= '') ", jqcode);
            DataTable dt = this.GetDataTable(sql);
            return dt;
        }

        public string GetSiteTypeGuid (string Code)
        {
            string sql = string.Format("select top 1 Guid from SiteType  where  Code='{0}'", Code);
            DataTable dt = this.GetDataTable(sql);
            if (dt != null && dt.Rows.Count > 0)
            {
                return dt.Rows[0]["Guid"].ToString();
            }
            return string.Empty ;
        }

        public Sitetype GetSitetypeByguid(string guid)
        {
            string sql = string.Format("select * from SiteType  where Guid='{0}' ", guid);
            DataTable dt = this.GetDataTable(sql);
            if (dt != null && dt.Rows.Count > 0)
            {
                return Sitetype.Dr2Obj(dt.Rows[0], Sitetype.ColumnNameEnum.DBName);
            }
            return null;
        }
    }
 
 
    #region 代码自动生成
	/// <summary>
	/// Sitetype的BLL
	/// 该BLL已经生成了基本的业务操作，在自动生成的方法中已经提供了事务机制
	/// </summary>
    public partial class SitetypeBLL : BaseBLL<Sitetype>
    {
        #region 自动生成代码：取得相关实体

		/// <summary>
		/// 方法名称: SitetypeBLL
		/// 内容摘要: 构造函数进行初始化
		/// </summary>
		protected SitetypeBLL()
		{
		}
		private static volatile SitetypeBLL m_instance = null;
		/// <summary>
		/// 方法名称: GetInstance
		/// 内容摘要: 取得 SitetypeBLL 对象
		/// </summary>
		/// <returns>返回一个已经存在的实体</returns>
		public static SitetypeBLL GetInstance()
		{
			// 通用的必要代码 iBatisNet双校检机制,如果实例不存在
			if (m_instance == null)
			{
				lock (typeof (SitetypeBLL))
				{

					// 如果实例不存在
					if (m_instance == null)
					{

						// 创建一个的实例
						m_instance = new SitetypeBLL();
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
        /// <returns>Sitetype</returns>
        public Sitetype Get(Sitetype.Key key)
        {
            return SitetypeDao.GetInstance().SelectByID(key);
        }
        /// <summary>
        /// 方法名称: Select
        /// 内容摘要: 基本查询，不带任何条件的查询
        /// </summary>
        public IList Select()
        {
            return SitetypeDao.GetInstance().SelectAll();
        }
        /// <summary>
        /// 方法名称: Insert
        /// 内容摘要: 插入一条新纪录
        /// </summary>
        /// <returns>int</returns>
        public int Insert(Sitetype obj)
        {
            return SitetypeDao.GetInstance().Insert(obj);
        }

        /// <summary>
        /// 方法名称: Update
        /// 内容摘要: 更新一条新纪录
        /// </summary>
        /// <returns>int</returns>
        public int Update(Sitetype obj)
        {
            SitetypeDao.GetInstance().Update(obj);
            return 1;
        }

        /// <summary>
        /// 方法名称: Delete
        /// 内容摘要: 删除一条新纪录
        /// </summary>
        /// <returns>int</returns>
        public int Delete(Sitetype obj)
        {
            SitetypeDao.GetInstance().DeleteByID(obj.GetKey());
            return 1;
        }
		
		
		#endregion
		
    }
	#endregion
}