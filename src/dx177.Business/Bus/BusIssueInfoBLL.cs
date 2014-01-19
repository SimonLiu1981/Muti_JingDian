/*
版权所有：版权所有(C) 2011，刘建新
文件编号：M01_BusIssueInfoBll.cs
文件名称：BusIssueInfoBll.cs
系统编号：Z0003007
系统名称：通用办公系统
模块编号：M01
模块名称：信息发布
设计文档：IOA_M01信息发布XDE建模.mdx
完成日期：2011-03-31
作　　者：
内容摘要：表[Bus_Issue_Info]业务操作类
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using dx177.Model.Bus;
using dx177.DataAccess.Access.Bus;
using System.Collections;
using dx177.Model;
using dx177.Access.Bus;
using CampanyCMS.Model.Bus;

namespace dx177.Business.Bus
{
    /// <summary>
	/// BusIssueInfo的BLL 自定义方法
	/// 该BLL已经生成了基本的业务操作，在自动生成的方法中已经提供了事务机制
	/// </summary>
    public partial class BusIssueInfoBLL : BaseBLL<BusIssueInfo>
    {
        public DataTable GetIssueList(string Type, string Title,string jingqucode)
        {
            string sql = @"  select *    , title as   typename from  Bus_Issue_Info where title like '%{0}%' and (infoType='{1}' or ''='{1}' )  and (JingQuCode='{2}' or '{2}'='') ";
            sql = string.Format(sql, Title, Type, jingqucode);
            DataTable dt = this.GetDataTable(sql);
            return dt;
        }
        public bool Submit(BusIssueInfo b)
        {
            if (b.Seqno > 0)
            {
                return this.Update(b) > 0;
            }
            else
            {
                return this.Insert(b) > 0;
            }
            BuildPageBLL.BuildOnePage("文章", b.Creator, b.Seqno.ToString());
        }

        public BusIssueInfo GetBusIssueInfo(string code, string jingqucode)
        {
            string sql = string.Format("select * from  Bus_Issue_Info where code='{0}' and (JingQuCode='{1}' or '{1}'='{1}') ", code, jingqucode);
            DataTable dt = this.GetDataTable(sql);
            if (dt != null && dt.Rows.Count > 0)
            {
                return BusIssueInfo.Dr2Obj(dt.Rows[0], BusIssueInfo.ColumnNameEnum.DBName);
            }
            return null;
        }
    }
 
 
    #region 代码自动生成
	/// <summary>
	/// BusIssueInfo的BLL
	/// 该BLL已经生成了基本的业务操作，在自动生成的方法中已经提供了事务机制
	/// </summary>
    public partial class BusIssueInfoBLL : BaseBLL<BusIssueInfo>
    {
        #region 自动生成代码：取得相关实体

		/// <summary>
		/// 方法名称: BusIssueInfoBLL
		/// 内容摘要: 构造函数进行初始化
		/// </summary>
		protected BusIssueInfoBLL()
		{
		}
		private static volatile BusIssueInfoBLL m_instance = null;
		/// <summary>
		/// 方法名称: GetInstance
		/// 内容摘要: 取得 BusIssueInfoBLL 对象
		/// </summary>
		/// <returns>返回一个已经存在的实体</returns>
		public static BusIssueInfoBLL GetInstance()
		{
			// 通用的必要代码 iBatisNet双校检机制,如果实例不存在
			if (m_instance == null)
			{
				lock (typeof (BusIssueInfoBLL))
				{

					// 如果实例不存在
					if (m_instance == null)
					{

						// 创建一个的实例
						m_instance = new BusIssueInfoBLL();
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
		/// <returns>BusIssueInfo</returns>
		public BusIssueInfo Get(BusIssueInfo.Key key)
		{
            return BusIssueInfoDao.GetInstance().SelectByID(key);
		}
		/// <summary>
		/// 方法名称: Select
		/// 内容摘要: 基本查询，不带任何条件的查询
		/// </summary>
		public IList Select()
        {
            return BusIssueInfoDao.GetInstance().SelectAll();
        }
		/// <summary>
		/// 方法名称: Insert
		/// 内容摘要: 插入一条新纪录
		/// </summary>
		/// <returns>int</returns>
		public int Insert(BusIssueInfo obj)
		{
            return BusIssueInfoDao.GetInstance().Insert(obj);
		}
		
		/// <summary>
		/// 方法名称: Update
		/// 内容摘要: 更新一条新纪录
		/// </summary>
		/// <returns>int</returns>
		public int Update(BusIssueInfo obj)
		{
            BusIssueInfoDao.GetInstance().Update(obj);
            return 1;
		}
		
		/// <summary>
		/// 方法名称: Delete
		/// 内容摘要: 删除一条新纪录
		/// </summary>
		/// <returns>int</returns>
		public int Delete(BusIssueInfo obj)
		{
            BusIssueInfoDao.GetInstance().DeleteByID(obj.GetKey());
            return 1;
		}
		
		#endregion
		
    }
	#endregion
}