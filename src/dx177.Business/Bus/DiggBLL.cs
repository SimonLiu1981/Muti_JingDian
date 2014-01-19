/*
版权所有：版权所有(C) 2011，刘建新
文件编号：M01_DiggBll.cs
文件名称：DiggBll.cs
系统编号：Z0003007
系统名称：通用办公系统
模块编号：M01
模块名称：信息发布
设计文档：IOA_M01信息发布XDE建模.mdx
完成日期：2011/3/18
作　　者：
内容摘要：表[Digg]业务操作类
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using dx177.Model.Bus;
using dx177.FrameWork;
using dx177.DataAccess.Access.Bus;
using System.Collections;

namespace dx177.Business.Bus
{
    /// <summary>
	/// Digg的BLL 自定义方法
	/// 该BLL已经生成了基本的业务操作，在自动生成的方法中已经提供了事务机制
	/// </summary>
    public partial class DiggBLL : BaseBLL<Digg>
    {
        /// <summary>
        /// 是否该IP访问了此对象,返回flase后，插入一条
        /// </summary>
        /// <param name="guid"></param>
        /// <param name="ip"></param>
        /// <returns></returns>
        public bool ExistsIp(string guid, string ip, DiggType dingType)
        {
            string today = DateTime.Now.ToString("yyyy-MM-dd");
            string sql = string.Format("select * from digg where pguid='{0}' and ip='{1}' and CREATE_DATE='{2}' and diggtype={3} ", guid, ip, today, (int)dingType);
            DataTable dt = this.GetDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                Digg digg = new Digg();
                digg.CreateDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                digg.Ip = ip;
                digg.Pguid = guid;
                digg.Diggtype = (int)dingType;                     
                this.Insert(digg);
                return false;
            }
        }
       
    }
 
 
    #region 代码自动生成
	/// <summary>
	/// Digg的BLL
	/// 该BLL已经生成了基本的业务操作，在自动生成的方法中已经提供了事务机制
	/// </summary>
    public partial class DiggBLL : BaseBLL<Digg>
    {
        #region 自动生成代码：取得相关实体

		/// <summary>
		/// 方法名称: DiggBLL
		/// 内容摘要: 构造函数进行初始化
		/// </summary>
		protected DiggBLL()
		{
		}
		private static volatile DiggBLL m_instance = null;
		/// <summary>
		/// 方法名称: GetInstance
		/// 内容摘要: 取得 DiggBLL 对象
		/// </summary>
		/// <returns>返回一个已经存在的实体</returns>
		public static DiggBLL GetInstance()
		{
			// 通用的必要代码 iBatisNet双校检机制,如果实例不存在
			if (m_instance == null)
			{
				lock (typeof (DiggBLL))
				{

					// 如果实例不存在
					if (m_instance == null)
					{

						// 创建一个的实例
						m_instance = new DiggBLL();
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
		/// <returns>Digg</returns>
		public Digg Get(Digg.Key key)
		{
            return DiggDao.GetInstance().SelectByID(key);
		}
		/// <summary>
		/// 方法名称: Select
		/// 内容摘要: 基本查询，不带任何条件的查询
		/// </summary>
		public IList Select()
        {
            return DiggDao.GetInstance().SelectAll();
        }
		/// <summary>
		/// 方法名称: Insert
		/// 内容摘要: 插入一条新纪录
		/// </summary>
		/// <returns>int</returns>
		public int Insert(Digg obj)
		{
            return DiggDao.GetInstance().Insert(obj);
		}
		
		/// <summary>
		/// 方法名称: Update
		/// 内容摘要: 更新一条新纪录
		/// </summary>
		/// <returns>int</returns>
		public int Update(Digg obj)
		{
            DiggDao.GetInstance().Update(obj);
            return obj.Seqno;
		}
		
		/// <summary>
		/// 方法名称: Delete
		/// 内容摘要: 删除一条新纪录
		/// </summary>
		/// <returns>int</returns>
		public int Delete(Digg obj)
		{
            DiggDao.GetInstance().DeleteByID(obj.GetKey());
            return obj.Seqno;
		}
		
		#endregion
		
    }
	#endregion
}