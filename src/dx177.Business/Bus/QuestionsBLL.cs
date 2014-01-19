/*
版权所有：版权所有(C) 2011，刘建新
文件编号：M01_QuestionsBll.cs
文件名称：QuestionsBll.cs
系统编号：Z0003007
系统名称：通用办公系统
模块编号：M01
模块名称：信息发布
设计文档：IOA_M01信息发布XDE建模.mdx
完成日期：2011/3/18
作　　者：
内容摘要：表[Questions]业务操作类
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using dx177.Model.Bus;
using dx177.Model;
using dx177.FrameWork;
using dx177.DataAccess.Access.Bus;
using System.Collections;
using dx177.Access.Bus;
using CampanyCMS.Model.Bus;
using dx177.DataAccess.Access;
using dx177.Model.Bus.QueryO;

namespace dx177.Business.Bus
{
    /// <summary>
	/// Questions的BLL 自定义方法
	/// 该BLL已经生成了基本的业务操作，在自动生成的方法中已经提供了事务机制
	/// </summary>
    public partial class QuestionsBLL : BaseBLL<Questions>
    {


        /// <summary>
        /// 查询问题
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public IList<Questions> Search(QuestionsQuery query)
        {
            string top = string.Empty;
            if (query.TopNumber > 0)
            {
                top = "top " + query.TopNumber;
            }
            string sql = string.Format("select {1} * from Questions where (JingQuCode='{0}' or '{0}' = '')", query.JingQuCode, top);
            if (!string.IsNullOrEmpty(query.Title))
            {
                sql += string.Format(" and Title like '%{0}%'", query.Title);
            }
            if (!string.IsNullOrEmpty(query.QuestStatus))
            {
                sql += string.Format(" and status ={0}", query.QuestStatus);
            }
            if (!string.IsNullOrEmpty(query.Creator))
            {
                sql += string.Format(" and Creator ='{0}'", query.Creator);
            }

            if (!string.IsNullOrEmpty(query.Orderby))
            {
                sql += " order by " + query.Orderby + " desc";
            }
            else
            {
                sql += " order by seqno desc";
            }
            DataTable dt = this.GetDataTable(sql);
            return Questions.Dt2Objs(dt);
        }


         
        /// <summary>
        /// 更新问题状态
        /// </summary>
        /// <param name="guid"></param>
        public void UpdateStatus(string guid)
        {
            string sql = string.Format("select * from replyquestion where pguid ='{0}'", guid);
            DataTable dt = this.GetDataTable(sql);
            Questions q = GetByGuid(guid); 
            if (dt.Rows.Count > 0)
            {
                q.Status = (int)QuestionStatus.HasReply;
            }
            sql = string.Format("select * from replyquestion where pguid ='{0}' and isright =1 ", guid);
            dt = this.GetDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                q.Status = (int)QuestionStatus.HasSolved;
            }
            this.Update(q);
        }

        /// <summary>
        /// 查询问题
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public DataTable SearchData(QuestionsQuery query)
        {

            string sql = "select a.*,(select count(*) as tcount  from ReplyQuestion where pguid=a.guid)  as tcount , b.title as  qtypename , b.code typecode ,  ( select   matchdomain  from JingQus  as  j where a.jingqucode=j.jingqucode ) as matchdomain  from Questions as a inner join QstType as b on  b.guid=a.qtype  where 1=1 ";
 
             
            if (!string.IsNullOrEmpty(query.Qtype))
            {
                sql += string.Format(" and b.code='{0}'", query.Qtype);
            }
            if (!string.IsNullOrEmpty(query.QuestStatus))
            {
                sql += string.Format(" and a.status ={0}", query.QuestStatus);
            }

            if (!string.IsNullOrEmpty(query.JingQuCode))
            {
                sql += string.Format(" and a.JingQuCode ='{0}'", query.JingQuCode);
            }

            

            sql += " order by a.seqno desc";
            DataTable dt = this.GetDataTable(sql);
            return dt;
        }


        public Questions GetByGuid(string guid)
        {
            string sql =string.Format( "select * from Questions where 1=1 and guid='{0}' ",guid);
            DataTable dt = this.GetDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                return Questions.Dr2Obj(dt.Rows[0]);
            }
            return null;
        }

        public void Submit(Questions rest)
        {
            if (rest.Seqno > 0)
            {
                this.Update(rest);
            }
            else
            {                
                rest.CreateDate = DateTime.Now;
                this.Insert(rest);
            }

            BuildPageBLL.BuildOnePage("问题", rest.Creator, rest.Seqno.ToString());
        }

        public void RemoveQuestions(string seqno)
        {
            string sql = string.Format("delete from ReplyQuestion where pguid in (select guid from questions where seqno = {0})", seqno);
            this.Execute(sql);
            sql = string.Format("delete from questions where seqno = {0}", seqno);
            this.Execute(sql);
            
        }


        public DataTable GetFont_Table(string qtype, string jq, int First, int pagesize)
        {
            string sql = @"select * , j.matchdomain ,(  select title from  Qsttype as qt where qt.guid =a.qtype  ) as SORTNAME  from  Questions      as a inner join JingQus as j on a.jingqucode=j.jingqucode
                where (a.qtype='{0}' or '{0}'='' )  and  (a.JingQuCode ='{1}' or '{1}'='')  order by create_date desc";
            sql = string.Format(sql, qtype, jq);
            DataTable dt = DBTool.GetDataForPage(sql, First, pagesize);
            return dt;

        }

        public int GetFont_TableRowCount(string qtype, string jq)
        {
            string sql = @"select count(1) as count1  from  Questions      as a inner join JingQus as j on a.jingqucode=j.jingqucode
                where (a.qtype='{0}' or '{0}'='' )  and  (a.JingQuCode ='{1}' or '{1}'='')  ";
            sql = string.Format(sql, qtype, jq);
            sql = string.Format(sql, qtype, jq);
            DataTable dt = this.GetDataTable(sql);
            return int.Parse(dt.Rows[0]["count1"].ToString());
        }

         
    }
 
 
    #region 代码自动生成
	/// <summary>
	/// Questions的BLL
	/// 该BLL已经生成了基本的业务操作，在自动生成的方法中已经提供了事务机制
	/// </summary>
    public partial class QuestionsBLL : BaseBLL<Questions>
    {
        #region 自动生成代码：取得相关实体

		/// <summary>
		/// 方法名称: QuestionsBLL
		/// 内容摘要: 构造函数进行初始化
		/// </summary>
		protected QuestionsBLL()
		{
		}
		private static volatile QuestionsBLL m_instance = null;
		/// <summary>
		/// 方法名称: GetInstance
		/// 内容摘要: 取得 QuestionsBLL 对象
		/// </summary>
		/// <returns>返回一个已经存在的实体</returns>
		public static QuestionsBLL GetInstance()
		{
			// 通用的必要代码 iBatisNet双校检机制,如果实例不存在
			if (m_instance == null)
			{
				lock (typeof (QuestionsBLL))
				{

					// 如果实例不存在
					if (m_instance == null)
					{

						// 创建一个的实例
						m_instance = new QuestionsBLL();
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
        /// <returns>Questions</returns>
        public Questions Get(Questions.Key key)
        {
            return QuestionsDao.GetInstance().SelectByID(key);
        }
        /// <summary>
        /// 方法名称: Select
        /// 内容摘要: 基本查询，不带任何条件的查询
        /// </summary>
        public IList Select()
        {
            return QuestionsDao.GetInstance().SelectAll();
        }
        /// <summary>
        /// 方法名称: Insert
        /// 内容摘要: 插入一条新纪录
        /// </summary>
        /// <returns>int</returns>
        public int Insert(Questions obj)
        {
            return QuestionsDao.GetInstance().Insert(obj);
        }

        /// <summary>
        /// 方法名称: Update
        /// 内容摘要: 更新一条新纪录
        /// </summary>
        /// <returns>int</returns>
        public int Update(Questions obj)
        {
            QuestionsDao.GetInstance().Update(obj);
            return 1;
        }

        /// <summary>
        /// 方法名称: Delete
        /// 内容摘要: 删除一条新纪录
        /// </summary>
        /// <returns>int</returns>
        public int Delete(Questions obj)
        {
            QuestionsDao.GetInstance().DeleteByID(obj.GetKey());
            return 1;
        }
		
		
		#endregion
		
    }
	#endregion
}