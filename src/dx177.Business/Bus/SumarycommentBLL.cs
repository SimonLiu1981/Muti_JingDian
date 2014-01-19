/*
版权所有：版权所有(C) 2011，刘建新
文件编号：M01_SumarycommentBll.cs
文件名称：SumarycommentBll.cs
系统编号：Z0003007
系统名称：通用办公系统
模块编号：M01
模块名称：信息发布
设计文档：IOA_M01信息发布XDE建模.mdx
完成日期：2011/3/18
作　　者：
内容摘要：表[SumaryComment]业务操作类
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
	/// Sumarycomment的BLL 自定义方法
	/// 该BLL已经生成了基本的业务操作，在自动生成的方法中已经提供了事务机制
	/// </summary>
    public partial class SumarycommentBLL : BaseBLL<Sumarycomment>
    {
        public Sumarycomment GetSumarycommentByPGuid(string pguid)
        {
            string sql = string.Format("select * from Sumarycomment where pguid= '{0}'", pguid);
            DataTable dt = this.GetDataTable(sql);
            if (dt.Rows.Count == 0)
            {
                Sumarycomment cc = InitSummarycommont(pguid);
                this.Insert(cc);
                return cc;
            }
            else
            {
                return Sumarycomment.Dr2Obj(dt.Rows[0]);
            }
        }

        private Sumarycomment InitSummarycommont(string pguid)
        {
            Sumarycomment cc = new Sumarycomment();
            cc.Score1 = 0;
            cc.Score2 = 0;
            cc.Score3 = 0;
            cc.Score4 = 0;
            cc.Lastcontent = "暂无评论！";
            cc.Pguid = pguid;
            cc.CreateDate = DateTime.Now;
            cc.Creator = "管理员";
            cc.Scount1 = 0;
            cc.Scount2 = 0;
            cc.Scount3 = 0;
            cc.Scount4 = 0;
            cc.Avgscore = 0;
            return cc;
        }

        public Sumarycomment Submit(Sumarycomment obj)
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

        /// <summary>
        /// 重新计算
        /// </summary>
        /// <param name="pguid"></param>
        public Sumarycomment AutoCalculation(string pguid)
        {
            string sql = string.Format("select * from comment where pguid='{0}' and isshow=1 order by seqno", pguid);
            DataTable dt = this.GetDataTable(sql);
            Sumarycomment sc = GetSumarycommentByPGuid(pguid);
            if (dt.Rows.Count == 0)
            {
                sc.Score1 = 0;
                sc.Score2 = 0;
                sc.Score3 = 0;
                sc.Score4 = 0;
                sc.Lastcontent = "暂无评论！";
                sc.Pguid = pguid;
                sc.CreateDate = DateTime.Now;
                sc.Creator = "管理员";
                sc.Scount1 = 0;
                sc.Scount2 = 0;
                sc.Scount3 = 0;
                sc.Scount4 = 0;
                sc.Avgscore = 0;
                this.Submit(sc);
            }
            else
            {
                IList<Comment> ls = Comment.Dt2Objs(dt);
                decimal s1 = 0;
                decimal s2 = 0;
                decimal s3 = 0;
                decimal s4 = 0;
                foreach ( Comment item in ls)
                {
                    s1 += item.Score1;
                    s2 += item.Score2;
                    s3 += item.Score3;
                    s4 += item.Score4;
                }
                sc.Score1 = s1 / ls.Count;
                sc.Score2 = s2 / ls.Count;
                sc.Score3 = s3 / ls.Count;
                sc.Score4 = s4 / ls.Count;
                sc.Scount1 = ls.Count;
                sc.Scount2 = ls.Count;
                sc.Scount3 = ls.Count; 
                sc.Scount4 = ls.Count;
                sc.Avgscore = (s1 + s2 + s3 + s4) / (ls.Count * 4);
                sc.Lastcontent = ls[ls.Count - 1].Content;
                this.Submit(sc);                
            }
            return sc;
        }

        /// <summary>
        /// 删除评论
        /// </summary>
        /// <param name="pguid"></param>
        public void RemoveSumarycommentbyPguid(string pguid)
        {
            string sql = string.Format("delete from Sumarycomment where pguid = '{0}'", pguid);
            Execute(sql);
            CommentBLL.GetInstance().RemoveCommentByPguid(pguid);

            
        }

    }
 
 
    #region 代码自动生成
	/// <summary>
	/// Sumarycomment的BLL
	/// 该BLL已经生成了基本的业务操作，在自动生成的方法中已经提供了事务机制
	/// </summary>
    public partial class SumarycommentBLL : BaseBLL<Sumarycomment>
    {
        #region 自动生成代码：取得相关实体

		/// <summary>
		/// 方法名称: SumarycommentBLL
		/// 内容摘要: 构造函数进行初始化
		/// </summary>
		protected SumarycommentBLL()
		{
		}
		private static volatile SumarycommentBLL m_instance = null;
		/// <summary>
		/// 方法名称: GetInstance
		/// 内容摘要: 取得 SumarycommentBLL 对象
		/// </summary>
		/// <returns>返回一个已经存在的实体</returns>
		public static SumarycommentBLL GetInstance()
		{
			// 通用的必要代码 iBatisNet双校检机制,如果实例不存在
			if (m_instance == null)
			{
				lock (typeof (SumarycommentBLL))
				{

					// 如果实例不存在
					if (m_instance == null)
					{

						// 创建一个的实例
						m_instance = new SumarycommentBLL();
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
		/// <returns>Sumarycomment</returns>
		public Sumarycomment Get(Sumarycomment.Key key)
		{
            return SumarycommentDao.GetInstance().SelectByID(key);
		}
		/// <summary>
		/// 方法名称: Select
		/// 内容摘要: 基本查询，不带任何条件的查询
		/// </summary>
		public IList  Select()
        {
            return SumarycommentDao.GetInstance().SelectAll();              
        }
		/// <summary>
		/// 方法名称: Insert
		/// 内容摘要: 插入一条新纪录
		/// </summary>
		/// <returns>int</returns>
		public int Insert(Sumarycomment obj)
		{
            return SumarycommentDao.GetInstance().Insert(obj);
		}
		
		/// <summary>
		/// 方法名称: Update
		/// 内容摘要: 更新一条新纪录
		/// </summary>
		/// <returns>int</returns>
		public int Update(Sumarycomment obj)
		{
            SumarycommentDao.GetInstance().Update(obj);
            return 1;
		}
		
		/// <summary>
		/// 方法名称: Delete
		/// 内容摘要: 删除一条新纪录
		/// </summary>
		/// <returns>int</returns>
		public int Delete(Sumarycomment obj)
		{
            SumarycommentDao.GetInstance().DeleteByID(obj.GetKey());
            return 1;
		}
		
		#endregion
		
    }
	#endregion
}