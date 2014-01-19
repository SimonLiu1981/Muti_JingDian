/*
版权所有：版权所有(C) 2011，刘建新
文件编号：M01_ProductsBll.cs
文件名称：ProductsBll.cs
系统编号：Z0003007
系统名称：通用办公系统
模块编号：M01
模块名称：信息发布
设计文档：IOA_M01信息发布XDE建模.mdx
完成日期：2011/3/18
作　　者：
内容摘要：表[Products]业务操作类
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using dx177.Model.Bus;
using dx177.DataAccess.Access.Bus;
using System.Collections;
using System.IO;
using System.Web.UI.WebControls;
using dx177.Access.Bus;
using dx177.Model;
using CampanyCMS.Model.Bus;

namespace dx177.Business.Bus
{
    /// <summary>
	/// Products的BLL 自定义方法
	/// 该BLL已经生成了基本的业务操作，在自动生成的方法中已经提供了事务机制
	/// </summary>
    public partial class ProductsBLL : BaseBLL<Products>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="listControl"></param>
        public void BindDropListTreeType(ListControl listControl)
        {
            string sql = "select * from ProductsType where creator='{0}' or '{0}'='{1}' or ''='{0}' ";
            sql = string.Format(sql, AppContext.GetCurrentName(), AppContext.Admin);
            
            DataTable dt = this.GetDataTable(sql);
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


        public DataTable GetProductList(string Type, string Title,string Creator)
        {
            string sql = @"select a.* ,b.title as typename  from  Products as a left join ProductsType as b on a.PType=b.guid  
                                where ( a.creator='{2}' or '{2}'='{3}'  or  ''='{2}'  ) and  a.title like '%{0}%' and (a.ptype='{1}' or ''='{1}')";
            sql = string.Format(sql, Title, Type, Creator, AppContext.Admin);
            DataTable dt = this.GetDataTable(sql);
            return dt;
        }



        /// <summary>
        ///  
        /// </summary>
        /// <param name="Seqno"></param>
        public void RemoveBySeqno(int Seqno)
        {
            Products obj = ProductsBLL.GetInstance().Get(new Products.Key(Seqno));
            this.Delete(obj);
            //PicturelistBLL.GetInstance().DeleteByPGuid(obj.Guid);
            //删除文件
            if (File.Exists(System.Web.HttpContext.Current.Server.MapPath(obj.Logo)))
            {
                File.Delete(System.Web.HttpContext.Current.Server.MapPath(obj.Logo));
            }
            PicturelistBLL.GetInstance().DeleteByPGuid(obj.Guid);
        }



        public Products Submit(Products n)
        {
            if (n.Seqno > 0)
            {
                this.Update(n);
            }
            else
            {
                this.Insert(n);
            }
            BuildPageBLL.BuildOnePage("产品", n.Creator, n.Seqno.ToString());
            return n;
        }


        public DataTable GetableByType(string guid)
        {
            string sql =string.Format( @"SELECT A.SEQNO,A.GUID,  A.LOGO,A.NOWPRICE ,A.MARKETPRICE ,A.TITLE ,B.TITLE AS TYPENAME  FROM PRODUCTS AS A  
                                                        INNER JOIN PRODUCTSTYPE AS B ON A.PTYPE=B.GUID   WHERE  (A.PTYPE='{0}' OR ''='{0}')  ",guid );
            return this.GetDataTable(sql);
        }
        public DataTable GetableByType(int top )
        {
            string sql = string.Format(@"SELECT top  {0} A.SEQNO,A.GUID,  A.LOGO,A.NOWPRICE ,A.MARKETPRICE ,A.TITLE ,B.TITLE AS TYPENAME  FROM PRODUCTS AS A  
                                                        INNER JOIN PRODUCTSTYPE AS B ON A.PTYPE=B.GUID    ", top);
            return this.GetDataTable(sql);
        }
    }
 
 
    #region 代码自动生成
	/// <summary>
	/// Products的BLL
	/// 该BLL已经生成了基本的业务操作，在自动生成的方法中已经提供了事务机制
	/// </summary>
    public partial class ProductsBLL : BaseBLL<Products>
    {
        #region 自动生成代码：取得相关实体

		/// <summary>
		/// 方法名称: ProductsBLL
		/// 内容摘要: 构造函数进行初始化
		/// </summary>
		protected ProductsBLL()
		{
		}
		private static volatile ProductsBLL m_instance = null;
		/// <summary>
		/// 方法名称: GetInstance
		/// 内容摘要: 取得 ProductsBLL 对象
		/// </summary>
		/// <returns>返回一个已经存在的实体</returns>
		public static ProductsBLL GetInstance()
		{
			// 通用的必要代码 iBatisNet双校检机制,如果实例不存在
			if (m_instance == null)
			{
				lock (typeof (ProductsBLL))
				{

					// 如果实例不存在
					if (m_instance == null)
					{

						// 创建一个的实例
						m_instance = new ProductsBLL();
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
        /// <returns>Products</returns>
        public Products Get(Products.Key key)
        {
            return ProductsDao.GetInstance().SelectByID(key);
        }
        /// <summary>
        /// 方法名称: Select
        /// 内容摘要: 基本查询，不带任何条件的查询
        /// </summary>
        public IList Select()
        {
            return ProductsDao.GetInstance().SelectAll();
        }
        /// <summary>
        /// 方法名称: Insert
        /// 内容摘要: 插入一条新纪录
        /// </summary>
        /// <returns>int</returns>
        public int Insert(Products obj)
        {
            return ProductsDao.GetInstance().Insert(obj);
        }

        /// <summary>
        /// 方法名称: Update
        /// 内容摘要: 更新一条新纪录
        /// </summary>
        /// <returns>int</returns>
        public int Update(Products obj)
        {
            ProductsDao.GetInstance().Update(obj);
            return 1;
        }

        /// <summary>
        /// 方法名称: Delete
        /// 内容摘要: 删除一条新纪录
        /// </summary>
        /// <returns>int</returns>
        public int Delete(Products obj)
        {
            ProductsDao.GetInstance().DeleteByID(obj.GetKey());
            return 1;
        }
		
		
		#endregion
		
    }
	#endregion
}