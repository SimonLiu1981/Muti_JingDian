/*
版权所有：版权所有(C) 2011，刘建新
文件编号：M01_SitesBll.cs
文件名称：SitesBll.cs
系统编号：Z0003007
系统名称：通用办公系统
模块编号：M01
模块名称：信息发布
设计文档：IOA_M01信息发布XDE建模.mdx
完成日期：2011-03-31
作　　者：
内容摘要：表[Sites]业务操作类
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using dx177.Model.Bus;
using System.IO;
using System.Web.UI.WebControls;
using dx177.DataAccess.Access.Bus;
using System.Collections;
using dx177.Access.Bus;
using dx177.Model;
using CampanyCMS.Model.Bus;
using dx177.FrameWork;

namespace dx177.Business.Bus
{
    /// <summary>
	/// Sites的BLL 自定义方法
	/// 该BLL已经生成了基本的业务操作，在自动生成的方法中已经提供了事务机制
	/// </summary>
    public partial class SitesBLL : BaseBLL<Sites>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="listControl"></param>
        public void BindDropListTreeType(ListControl listControl, string jqcode)
        {

            string sql = string.Format("select * from Sitetype where (Jingqucode='{0}' or  '{0}'= '') ", jqcode);

            DataTable dt = SitetypeBLL.GetInstance().GetDataTable(sql);
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
            DataRow[] dataArr = allTable.Select("PGUID='" + parentID + "'");
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

        public DataTable GetSitesList(string Type, string Title, string jqcode)
        {
            string sql = @"select a.*,b.title as typename  from Sites   as a left join Sitetype as b on a.tguid=b.guid 
                                                                    where (b.guid='{0}' or '{0}'='') and a.title like '%{1}%' and (a.Jingqucode='{2}' or  '{2}'= '')  order by a.seqno desc";
            sql = string.Format(sql, Type, Title, jqcode);
            DataTable dt = this.GetDataTable(sql);
            return dt;
        }


        /// <summary>
        /// 删除房间
        /// </summary>
        /// <param name="Seqno"></param>
        public void RemoveBySeqno(int Seqno)
        {
            Sites obj = SitesBLL.GetInstance().Get(new Sites.Key(Seqno));
            this.Delete(obj);
            //PicturelistBLL.GetInstance().DeleteByPGuid(obj.Guid);
            //删除文件
            if (File.Exists(System.Web.HttpContext.Current.Server.MapPath(obj.Logo)))
            {
                File.Delete(System.Web.HttpContext.Current.Server.MapPath(obj.Logo));
            }
        }


        public Sites Submit(Sites n)
        {
            if (n.Seqno > 0)
            {
                this.Update(n);
            }
            else
            {
                this.Insert(n);
            }
            BuildPageBLL.BuildOnePage("景点", n.Creator, n.Seqno.ToString());
            return n;
        }

        /// <summary>
        /// 查询新闻
        /// </summary>
        /// <param name="orderBy"></param>
        /// <param name="newTypeCode"></param>
        /// <returns></returns>
        public DataTable Font_Search(string orderBy, string newTypeCode,string jqcode)
        {
            string sql = string.Format("select * from Sites where (Jingqucode='{0}' or  '{0}'= '') ", jqcode);
            if (!string.IsNullOrEmpty(newTypeCode))
            {
                sql += string.Format(" and exists (select * from Sitetype t where t.guid = tguid and t.Code = '{0}')", newTypeCode);
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
            return dt;
        }

        /// <summary>
        /// 查询新闻
        /// </summary>
        /// <param name="orderBy"></param>
        /// <param name="newTypeCode"></param>
        /// <returns></returns>
        public DataTable Font_Search(string orderBy, int maxCount, string jqcode)
        {
            string sql = string.Format("select {0} * ,  ( select   matchdomain  from JingQus  as  j where Sites.jingqucode=j.jingqucode ) as matchdomain from Sites  where (Jingqucode='{1}' or  '{1}'= '') ", maxCount > 0 ? "top " + maxCount : "", jqcode);
            
            if (!string.IsNullOrEmpty(orderBy))
            {
                sql += " order by " + orderBy + " desc";
            }
            else
            {
                sql += " order by seqno desc";
            }
            DataTable dt = this.GetDataTable(sql);
            return dt;

        }


         
        public Sites GetByGuid(string guid)
        {
            string sql = @"select *   from  Sites where  Guid='{0}'  ";
            sql = string.Format(sql, guid);
            DataTable dt = this.GetDataTable(sql);
            if (dt != null && dt.Rows.Count > 0)
            {
                return Sites.Dr2Obj(dt.Rows[0], Sites.ColumnNameEnum.DBName);
            }
            return null;
        }

        public DataTable GetHotSite(string jingqucode)
        {
            string sql = @"SELECT top 4  * ,'/'+(select top 1  matchdomain from JingQus as jq  where  jq.jingqucode=a.JingQuCode)+'/' AS JQCOD_PATH   FROM Sites as a    where a.jingqucode='{0}'";
            sql = string.Format(sql, jingqucode);
            DataTable dt =this.GetDataTable(sql);
            return dt;
        }

        public DataTable GetLeftSite(string jingqucode)
        {
            string sql = @"
                            SELECT top  10  * ,'/'+(select top 1  matchdomain from JingQus as jq  where  jq.jingqucode=a.JingQuCode)+'/' AS JQCOD_PATH   FROM Sites as a    where a.jingqucode='{0}' 
                              ";
            sql = string.Format(sql, jingqucode);
            DataTable dt = this.GetDataTable(sql);
            return dt;
        }

        public DataTable GetSiteBytitle(string title)
        {
            string sql = string.Format("select * from Sites where  Title like '%{0}%'", title);
            DataTable dt = this.GetDataTable(sql);
            return dt;
        }

        public void SubitList(List<Sites> ls)
        {
            if (ls != null && ls.Count>0)
            {
                string typeguid = SitetypeBLL.GetInstance().GetSiteTypeGuid(ls[0].Jingqucode);
                foreach (Sites s in ls)
                {
                   DataTable  dt =GetSiteBytitle(s.Title);
                   if (dt == null || dt.Rows.Count <= 0)
                   {
                       s.Guid = StringUtil.getGuid();
                       s.Tguid = typeguid;
                       this.Insert(s);
                       BuildPageBLL.BuildOnePage("景点", s.Creator, s.Seqno.ToString());
                   }
                }
            }
        }
    }
 
 
    #region 代码自动生成
	/// <summary>
	/// Sites的BLL
	/// 该BLL已经生成了基本的业务操作，在自动生成的方法中已经提供了事务机制
	/// </summary>
    public partial class SitesBLL : BaseBLL<Sites>
    {
        #region 自动生成代码：取得相关实体

		/// <summary>
		/// 方法名称: SitesBLL
		/// 内容摘要: 构造函数进行初始化
		/// </summary>
		protected SitesBLL()
		{
		}
		private static volatile SitesBLL m_instance = null;
		/// <summary>
		/// 方法名称: GetInstance
		/// 内容摘要: 取得 SitesBLL 对象
		/// </summary>
		/// <returns>返回一个已经存在的实体</returns>
		public static SitesBLL GetInstance()
		{
			// 通用的必要代码 iBatisNet双校检机制,如果实例不存在
			if (m_instance == null)
			{
				lock (typeof (SitesBLL))
				{

					// 如果实例不存在
					if (m_instance == null)
					{

						// 创建一个的实例
						m_instance = new SitesBLL();
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
        /// <returns>Sites</returns>
        public Sites Get(Sites.Key key)
        {
            return SitesDao.GetInstance().SelectByID(key);
        }
        /// <summary>
        /// 方法名称: Select
        /// 内容摘要: 基本查询，不带任何条件的查询
        /// </summary>
        public IList Select()
        {
            return SitesDao.GetInstance().SelectAll();
        }
        /// <summary>
        /// 方法名称: Insert
        /// 内容摘要: 插入一条新纪录
        /// </summary>
        /// <returns>int</returns>
        public int Insert(Sites obj)
        {
            return SitesDao.GetInstance().Insert(obj);
        }

        /// <summary>
        /// 方法名称: Update
        /// 内容摘要: 更新一条新纪录
        /// </summary>
        /// <returns>int</returns>
        public int Update(Sites obj)
        {
            SitesDao.GetInstance().Update(obj);
            return 1;
        }

        /// <summary>
        /// 方法名称: Delete
        /// 内容摘要: 删除一条新纪录
        /// </summary>
        /// <returns>int</returns>
        public int Delete(Sites obj)
        {
            SitesDao.GetInstance().DeleteByID(obj.GetKey());
            return 1;
        }
		
		#endregion
		
    }
	#endregion
}