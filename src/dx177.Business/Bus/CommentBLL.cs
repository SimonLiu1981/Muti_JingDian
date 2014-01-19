/*
版权所有：版权所有(C) 2011，刘建新
文件编号：M01_CommentBll.cs
文件名称：CommentBll.cs
系统编号：Z0003007
系统名称：通用办公系统
模块编号：M01
模块名称：信息发布
设计文档：IOA_M01信息发布XDE建模.mdx
完成日期：2011/3/18
作　　者：
内容摘要：表[Comment]业务操作类
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using dx177.Model.Bus;
using dx177.Model.Bus.QueryO;
using dx177.Business.DictBus;
using dx177.DataAccess.Access.Bus;
using System.Collections;
using dx177.Model;
using dx177.Access.Bus;

namespace dx177.Business.Bus
{
    /// <summary>
	/// Comment的BLL 自定义方法
	/// 该BLL已经生成了基本的业务操作，在自动生成的方法中已经提供了事务机制
	/// </summary>
    public partial class CommentBLL : BaseBLL<Comment>
    {
        /// <summary>
        /// 查询综合统计
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public DataTable SearchSummaryCommont(CommentQuery1 query, string jqcode)
        {
            string sql = string.Format("select * from comment_view where JingQucode is not null and  (JingQucode='{0}' or '{0}'='{0}' )  ", jqcode);
            
            if (!string.IsNullOrEmpty(query.ObjTitle))
            {
                sql += string.Format(" and objtitle like '%{0}%' ",query.ObjTitle);
            }
            
            if (!string.IsNullOrEmpty(query.IsNoReply) && query.IsNoReply == "1")
            {
                sql += string.Format(" and 未答复点评>0 and 总点评数>0 ", query.ObjTitle);
            }

            if (!string.IsNullOrEmpty(query.IsNew) && query.IsNew == "1")
            {
                sql += string.Format(" and 新点评>0 and 总点评数>0 ", query.ObjTitle);
            }


            sql += " order by 未答复点评 desc,新点评 desc";
            return this.GetDataTable(sql);
        }

        public IList<Comment> SearchComment(CommentQuery query)
        {
            List<Comment> res = new List<Comment>();

            string sql = ("select * from Comment where  1=1 ");
            if (!string.IsNullOrEmpty(query.Key))
            {
                sql += string.Format(" and Content like '%{0}%'", query.Key);
            }
            if (!string.IsNullOrEmpty(query.IsNew) && query.IsNew == "1")
            {
                sql += " and isnew=1 ";
            }

            if (!string.IsNullOrEmpty(query.IsNoReply) && query.IsNoReply == "1")
            {
                sql += " and (ReplyContent ='' or ReplyContent is null) ";
            }

            if (!string.IsNullOrEmpty(query.IsShow) && query.IsShow == "1")
            {
                sql += " and isshow=1 ";
            }
            if (!string.IsNullOrEmpty(query.pguid))
            {
                sql += string.Format(" and pguid='{0}' ", query.pguid);
            }

            sql += " order by seqno desc";
            DataTable dt = this.GetDataTable(sql);

            if (dt.Rows.Count > 0)
            {
                res = Comment.Dt2Objs(dt);
            }
            return res;
            
        }


        /// <summary>
        /// 增加一个评分
        /// </summary>
        /// <param name="cc"></param>
        public Comment Submit(Comment cc)
        {
            
            cc.Avgscore = (cc.Score1 + cc.Score2 + cc.Score3 + cc.Score4) / 4;//平均分
            if (cc.Seqno > 0)
            {
                this.Update(cc);
            }
            else
            {
                if (cc.Creator == string.Empty)
                {
                    cc.Creator = "匿名用户";
                }
                cc.CreateDate = DateTime.Now;
                cc.Isnew = 1;
                cc.Isshow = 0;                              
                this.Insert(cc);
            }

            //重新计算评分
            SumarycommentBLL.GetInstance().AutoCalculation(cc.Pguid);  
            return cc;
            
        }

        /// <summary>
        /// 获得Socre1Lable
        /// </summary>
        /// <param name="type">1:酒店，2饭店</param>
        /// <returns></returns>
        public string GetSocre1Lable(string type)
        {
            return type == "1" ? Dict.Tag["HotelScoreLable", "1", 2052] : Dict.Tag["QuestionScoreLable", "1", 2052];
        }


        /// <summary>
        /// 获得Socre1Lable
        /// </summary>
        /// <param name="type">1:酒店，2饭店</param>
        /// <returns></returns>
        public string GetSocre2Lable(string type)
        {
            return type == "1" ? Dict.Tag["HotelScoreLable", "2", 2052] : Dict.Tag["QuestionScoreLable", "2", 2052];
        }



        /// <summary>
        /// 获得Socre1Lable
        /// </summary>
        /// <param name="type">1:酒店，2饭店</param>
        /// <returns></returns>
        public string GetSocre3Lable(string type)
        {
            return type == "1" ? Dict.Tag["HotelScoreLable", "3", 2052] : Dict.Tag["QuestionScoreLable", "3", 2052];
        }




        /// <summary>
        /// 获得Socre1Lable
        /// </summary>
        /// <param name="type">1:酒店，2饭店</param>
        /// <returns></returns>
        public string GetSocre4Lable(string type)
        {
            return type == "1" ? Dict.Tag["HotelScoreLable", "4", 2052] : Dict.Tag["QuestionScoreLable", "4", 2052];
        }


        public void RemoveCommentByPguid(string pguid)
        {
            string sql = string.Format("delete from comment where pguid = '{0}'", pguid);
            Execute(sql);
        }

        public string GetCommentCount(string pguid)
        {
            string sql = string.Format("select count(1) from comment where pguid = '{0}' and isshow =1", pguid);
            DataTable dt = this.GetDataTable(sql);
            if (dt == null || dt.Rows.Count <= 0) return "0";
            return dt.Rows[0][0].ToString();
        }

        public void RemoveComment(string seqno)
        {
            Comment cm = CommentBLL.GetInstance().Get(new Comment.Key(int.Parse(seqno)));

            if (cm != null)
            {
                this.Delete(cm);
                //重新计算评分
                SumarycommentBLL.GetInstance().AutoCalculation(cm.Pguid);                
            }
            
        }
    }
 
 
    #region 代码自动生成
	/// <summary>
	/// Comment的BLL
	/// 该BLL已经生成了基本的业务操作，在自动生成的方法中已经提供了事务机制
	/// </summary>
    public partial class CommentBLL : BaseBLL<Comment>
    {
        #region 自动生成代码：取得相关实体

		/// <summary>
		/// 方法名称: CommentBLL
		/// 内容摘要: 构造函数进行初始化
		/// </summary>
		protected CommentBLL()
		{
		}
		private static volatile CommentBLL m_instance = null;
		/// <summary>
		/// 方法名称: GetInstance
		/// 内容摘要: 取得 CommentBLL 对象
		/// </summary>
		/// <returns>返回一个已经存在的实体</returns>
		public static CommentBLL GetInstance()
		{
			// 通用的必要代码 iBatisNet双校检机制,如果实例不存在
			if (m_instance == null)
			{
				lock (typeof (CommentBLL))
				{

					// 如果实例不存在
					if (m_instance == null)
					{

						// 创建一个的实例
						m_instance = new CommentBLL();
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
		/// <returns>Comment</returns>
		public Comment Get(Comment.Key key)
		{
            return CommentDao.GetInstance().SelectByID(key);
		}
		/// <summary>
		/// 方法名称: Select
		/// 内容摘要: 基本查询，不带任何条件的查询
		/// </summary>
		public IList Select()
        {
            return CommentDao.GetInstance().SelectAll();
        }
		/// <summary>
		/// 方法名称: Insert
		/// 内容摘要: 插入一条新纪录
		/// </summary>
		/// <returns>int</returns>
		public int Insert(Comment obj)
		{
            return CommentDao.GetInstance().Insert(obj);
		}
		
		/// <summary>
		/// 方法名称: Update
		/// 内容摘要: 更新一条新纪录
		/// </summary>
		/// <returns>int</returns>
		public int Update(Comment obj)
		{
            CommentDao.GetInstance().Update(obj);
			return 1;
		}
		
		/// <summary>
		/// 方法名称: Delete
		/// 内容摘要: 删除一条新纪录
		/// </summary>
		/// <returns>int</returns>
		public int Delete(Comment obj)
		{
            CommentDao.GetInstance().DeleteByID(obj.GetKey());
            return 1;
		}
		
		#endregion
		
    }
	#endregion
}