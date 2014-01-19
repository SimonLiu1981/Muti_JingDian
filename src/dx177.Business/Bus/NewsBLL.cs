/*
版权所有：版权所有(C) 2011，刘建新
文件编号：M01_NewsBll.cs
文件名称：NewsBll.cs
系统编号：Z0003007
系统名称：通用办公系统
模块编号：M01
模块名称：信息发布
设计文档：IOA_M01信息发布XDE建模.mdx
完成日期：2011/3/18
作　　者：
内容摘要：表[News]业务操作类
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using dx177.Model.Bus;
using System.Web.UI.WebControls;
using System.IO;
using System.Collections;
using dx177.DataAccess.Access.Bus;
using dx177.Model;
using dx177.Access.Bus;
using CampanyCMS.Model.Bus;
using dx177.DataAccess.Access;

namespace dx177.Business.Bus
{
    /// <summary>
	/// News的BLL 自定义方法
	/// 该BLL已经生成了基本的业务操作，在自动生成的方法中已经提供了事务机制
	/// </summary>
    public partial class NewsBLL : BaseBLL<News>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="listControl"></param>
        public   void BindDropListTreeType(ListControl listControl )
        {

            string sql = string.Format("select * from NewsType where (JingQuCode ='{0}' or '{0}'='') ", string.Empty);

            DataTable dt = NewstypeBLL.GetInstance().GetDataTable(sql);
            DataTable dtNew = new DataTable();
            dtNew.Columns.Add("PGUID");
            dtNew.Columns.Add("title");
            dtNew.Columns.Add("GUID");
            
            TreeListData("", dt, dtNew);
            if (dtNew == null || dtNew.Rows.Count <= 0)
            {
                listControl.DataSource = dt;
            }
            else
            {
                listControl.DataSource = dtNew;
            }

            listControl.DataTextField = "title";
            listControl.DataValueField = "GUID";
            listControl.DataBind();
        }


        string symbolf = "";
        string symbol = "";
        public void TreeListData(string parentID, DataTable allTable, DataTable NewTable)
        {
            DataRow[] dataArr = allTable.Select("PGUID='" + parentID+"'");
            int total = dataArr.Length;
            for (int i = 0; i < total; i++)
            {
                if ((i + 1) == total)
                    symbol = "└";
                else
                    symbol = "├";
                DataRow newRow = NewTable.NewRow();
                newRow["PGUID"] = dataArr[i]["PGUID"].ToString();
                newRow["title"] = symbolf + symbol + dataArr[i]["title"].ToString();
                newRow["GUID"] = dataArr[i]["GUID"].ToString();
                NewTable.Rows.Add(newRow);
                if ((i + 1) == total)
                    symbolf += "　";
                else
                    symbolf += "│";
                TreeListData(dataArr[i]["GUID"].ToString(), allTable, NewTable);
                symbolf = symbolf.Substring(0, symbolf.Length - 1);
            }
        }

        public DataTable GetNewsList(string Type,string Title,string creator, string jqcode)
        {
            string sql = @"select a.*,b.title as typename 
                                  from News   as a inner join newstype as b on a.tguid=b.guid 
                                  where (b.guid='{0}' or '{0}'='') and a.title like '%{1}%'  and (a.JingQuCode ='{2}' or '{2}'='') ";
            sql = string.Format(sql, Type, Title,  jqcode);
            DataTable dt = this.GetDataTable(sql);
            return dt;
        }


        /// <summary>
        /// 删除房间
        /// </summary>
        /// <param name="Seqno"></param>
        public void RemoveBySeqno(int Seqno)
        {
            News obj = NewsBLL.GetInstance().Get(new News.Key(Seqno));
            this.Delete(obj);
            //PicturelistBLL.GetInstance().DeleteByPGuid(obj.Guid);
            //删除文件
            if (File.Exists(System.Web.HttpContext.Current.Server.MapPath(obj.Logo)))
            {
                File.Delete(System.Web.HttpContext.Current.Server.MapPath(obj.Logo));
            }
        }


        public News Submit(News n)
        {
            if (n.Seqno > 0)
            {
                this.Update(n);
            }
            else
            {
                this.Insert(n);
            }
            
            BuildPageBLL.BuildOnePage("新闻", n.Creator, n.Seqno.ToString());
            return n;
        }


        
        /// <summary>
        /// 查询新闻
        /// </summary>
        /// <param name="orderBy"></param>
        /// <param name="newTypeCode"></param>
        /// <returns></returns>
        public IList<News> Font_Search(string orderBy, string newTypeCode,int maxCount, string jingqucode)
        {
            string sql = string.Format("select {0} * from news where 1=1 ", maxCount > 0 ? "top " + maxCount : "");
            if (!string.IsNullOrEmpty(newTypeCode))            
            {
                sql += string.Format(" and exists (select * from newstype t where t.guid = tguid and t.Code = '{0}')", newTypeCode);            
            }

            if (!string.IsNullOrEmpty(jingqucode))
            {
                sql += string.Format(" and (jingqucode = '{0}')", jingqucode);
            }

            if (!string.IsNullOrEmpty(orderBy))
            {
                sql += " order by " + orderBy + " desc";
            }
            else
            {
                sql += " order by seqno desc";
            }
            DataTable dt = this.GetDataTable(sql);
            return News.Dt2Objs(dt);

        }

        public DataTable GetFont_Table(string Typecode,string jq, int First,int pagesize )
        {
            string sql = @"select a.*,b.title as typename ,j.matchdomain,a.JingQuCode,b.code as typeCode
                                  from News   as a inner join newstype as b on a.tguid=b.guid inner join JingQus as j on a.jingqucode=j.jingqucode
                                  where  (a.JingQuCode ='{1}' or '{1}'='') and (b.Code='{0}' or '{0}'='') order by a.Seqno desc ";
            sql = string.Format(sql, Typecode, jq );
           DataTable dt= DBTool.GetDataForPage(sql, First, pagesize);
           return dt;

        }

        public int  GetFont_TableRowCount(string Typecode, string jq )
        {
            string sql = @"select  count(1) as count1
                                  from News   as a inner join newstype as b on a.tguid=b.guid 
                                  where  (a.JingQuCode ='{1}' or '{1}'='') and (b.Code='{0}' or '{0}'='')";
            sql = string.Format(sql, Typecode, jq);
            DataTable dt = this.GetDataTable(sql);
            return int.Parse(dt.Rows[0]["count1"].ToString());
        }

        public DataTable Query(string Typecode, string jq)
        {
            string sql = @"select a.*,b.title as typename ,j.matchdomain,a.JingQuCode,b.code as typeCode
                                  from News   as a inner join newstype as b on a.tguid=b.guid inner join JingQus as j on a.jingqucode=j.jingqucode
                                  where  (a.JingQuCode ='{1}' or '{1}'='') and (b.Code='{0}' or '{0}'='') order by a.Seqno desc ";
            sql = string.Format(sql, Typecode, jq);
           
            DataTable dt = this.GetDataTable(sql);
            return dt;
        }


        public News GetByGuid(string guid)
        {
            string sql = @"select *   from  News where  Guid='{0}'  ";
            sql = string.Format(sql, guid);
            DataTable dt = this.GetDataTable(sql);
            if (dt != null && dt.Rows.Count > 0)
            {
                return News.Dr2Obj(dt.Rows[0], News.ColumnNameEnum.DBName);
            }
            return null;
        }
         
    }
 
 
    #region 代码自动生成
	/// <summary>
	/// News的BLL
	/// 该BLL已经生成了基本的业务操作，在自动生成的方法中已经提供了事务机制
	/// </summary>
    public partial class NewsBLL : BaseBLL<News>
    {
        #region 自动生成代码：取得相关实体

		/// <summary>
		/// 方法名称: NewsBLL
		/// 内容摘要: 构造函数进行初始化
		/// </summary>
		protected NewsBLL()
		{
		}
		private static volatile NewsBLL m_instance = null;
		/// <summary>
		/// 方法名称: GetInstance
		/// 内容摘要: 取得 NewsBLL 对象
		/// </summary>
		/// <returns>返回一个已经存在的实体</returns>
		public static NewsBLL GetInstance()
		{
			// 通用的必要代码 iBatisNet双校检机制,如果实例不存在
			if (m_instance == null)
			{
				lock (typeof (NewsBLL))
				{

					// 如果实例不存在
					if (m_instance == null)
					{

						// 创建一个的实例
						m_instance = new NewsBLL();
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
        /// <returns>News</returns>
        public News Get(News.Key key)
        {
            return NewsDao.GetInstance().SelectByID(key);
        }
        /// <summary>
        /// 方法名称: Select
        /// 内容摘要: 基本查询，不带任何条件的查询
        /// </summary>
        public IList Select()
        {
            return NewsDao.GetInstance().SelectAll();
        }
        /// <summary>
        /// 方法名称: Insert
        /// 内容摘要: 插入一条新纪录
        /// </summary>
        /// <returns>int</returns>
        public int Insert(News obj)
        {
            return NewsDao.GetInstance().Insert(obj);
        }

        /// <summary>
        /// 方法名称: Update
        /// 内容摘要: 更新一条新纪录
        /// </summary>
        /// <returns>int</returns>
        public int Update(News obj)
        {
            NewsDao.GetInstance().Update(obj);
            return 1;
        }

        /// <summary>
        /// 方法名称: Delete
        /// 内容摘要: 删除一条新纪录
        /// </summary>
        /// <returns>int</returns>
        public int Delete(News obj)
        {
            NewsDao.GetInstance().DeleteByID(obj.GetKey());
            return 1;
        }
		
		
		#endregion
		
    }
	#endregion
}