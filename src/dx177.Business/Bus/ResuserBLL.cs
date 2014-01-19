/*
版权所有：版权所有(C) 2011，刘建新
文件编号：M01_ResuserBll.cs
文件名称：ResuserBll.cs
系统编号：Z0003007
系统名称：通用办公系统
模块编号：M01
模块名称：信息发布
设计文档：IOA_M01信息发布XDE建模.mdx
完成日期：2011/3/18
作　　者：
内容摘要：表[ResUser]业务操作类
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using dx177.Model.Bus;
using dx177.DataAccess.Access.Bus;
using System.Collections;

namespace dx177.Business.Bus
{
    /// <summary>
	/// Resuser的BLL 自定义方法
	/// 该BLL已经生成了基本的业务操作，在自动生成的方法中已经提供了事务机制
	/// </summary>
    public partial class ResuserBLL : BaseBLL<Resuser>
    {
        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public Resuser GetResuserByUserName(string username)
        {
            string sql = string.Format("select * from resuser where username='{0}' ", username);
            DataTable dt = this.GetDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                return Resuser.Dr2Obj(dt.Rows[0]);
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public Resuser GetResuserByEmailName(string Email)
        {
            string sql = string.Format("select * from resuser where email='{0}' ", Email);
            DataTable dt = this.GetDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                return Resuser.Dr2Obj(dt.Rows[0]);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 通过域名获得管理的注册用户
        /// </summary>        
        /// <returns></returns>
        public Resuser GetResuserByUserDomain(string domain)
        {
            string sql = string.Format("select * from resuser where domainname='{0}' ", domain);
            DataTable dt = this.GetDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                return Resuser.Dr2Obj(dt.Rows[0]);
            }
            else
            {
                return null;
            }
        }



        /// <summary>
        ///  
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public DataTable  GetResuserList(string UserType)
        {
            string sql = string.Format("select *, case when IsSubdomain=1 then '子域名' else '非子域名' end as domaintype from resuser where  (UserType='{0}' or ''='{0}' ) order by CREATE_DATE desc  ", UserType);
            DataTable dt = this.GetDataTable(sql);
            return dt;
        }

        /// <summary>
        /// 提交
        /// </summary>
        /// <param name="obj"></param>
        public void Submit(Resuser obj)
        {
            obj.LasteUpdateDate = DateTime.Now;
            if (obj.Seqno > 0)
            {
                this.Update(obj);
            }
            else
            {
                this.Insert(obj);
            }
        }

    
    }
 
 
    #region 代码自动生成
	/// <summary>
	/// Resuser的BLL
	/// 该BLL已经生成了基本的业务操作，在自动生成的方法中已经提供了事务机制
	/// </summary>
    public partial class ResuserBLL : BaseBLL<Resuser>
    {
        #region 自动生成代码：取得相关实体

		/// <summary>
		/// 方法名称: ResuserBLL
		/// 内容摘要: 构造函数进行初始化
		/// </summary>
		protected ResuserBLL()
		{
		}
		private static volatile ResuserBLL m_instance = null;
		/// <summary>
		/// 方法名称: GetInstance
		/// 内容摘要: 取得 ResuserBLL 对象
		/// </summary>
		/// <returns>返回一个已经存在的实体</returns>
		public static ResuserBLL GetInstance()
		{
			// 通用的必要代码 iBatisNet双校检机制,如果实例不存在
			if (m_instance == null)
			{
				lock (typeof (ResuserBLL))
				{

					// 如果实例不存在
					if (m_instance == null)
					{

						// 创建一个的实例
						m_instance = new ResuserBLL();
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
        /// <returns>Resuser</returns>
        public Resuser Get(Resuser.Key key)
        {
            return ResuserDao.GetInstance().SelectByID(key);
        }
        /// <summary>
        /// 方法名称: Select
        /// 内容摘要: 基本查询，不带任何条件的查询
        /// </summary>
        public IList Select()
        {
            return ResuserDao.GetInstance().SelectAll();
        }
        /// <summary>
        /// 方法名称: Insert
        /// 内容摘要: 插入一条新纪录
        /// </summary>
        /// <returns>int</returns>
        public int Insert(Resuser obj)
        {
            return ResuserDao.GetInstance().Insert(obj);
        }

        /// <summary>
        /// 方法名称: Update
        /// 内容摘要: 更新一条新纪录
        /// </summary>
        /// <returns>int</returns>
        public int Update(Resuser obj)
        {
            ResuserDao.GetInstance().Update(obj);
            return 1;
        }

        /// <summary>
        /// 方法名称: Delete
        /// 内容摘要: 删除一条新纪录
        /// </summary>
        /// <returns>int</returns>
        public int Delete(Resuser obj)
        {
            ResuserDao.GetInstance().DeleteByID(obj.GetKey());
            return 1;
        }
		
		#endregion
		
    }
	#endregion
}