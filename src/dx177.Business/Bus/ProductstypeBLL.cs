/*
版权所有：版权所有(C) 2011，刘建新
文件编号：M01_ProductstypeBll.cs
文件名称：ProductstypeBll.cs
系统编号：Z0003007
系统名称：通用办公系统
模块编号：M01
模块名称：信息发布
设计文档：IOA_M01信息发布XDE建模.mdx
完成日期：2011/3/18
作　　者：
内容摘要：表[ProductsType]业务操作类
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

namespace dx177.Business.Bus
{
    /// <summary>
	/// Productstype的BLL 自定义方法
	/// 该BLL已经生成了基本的业务操作，在自动生成的方法中已经提供了事务机制
	/// </summary>
    public partial class ProductstypeBLL : BaseBLL<Productstype>
    {

        public DataTable GetTreeALL()
        {
            string sql = "select * from ProductsType where creator='{0}' or '{0}'='{1}' or ''='{0}' ";
            sql = string.Format(sql, AppContext.GetCurrentName(), AppContext.Admin);
            DataTable dt = this.GetDataTable(sql);
            return dt;
        }
        public Productstype GetProductstypeByguid(string guid)
        {
            string sql = string.Format("select * from ProductsType  where Guid='{0}' ", guid);
            DataTable dt = this.GetDataTable(sql);
            if (dt != null && dt.Rows.Count > 0)
            {
                return Productstype.Dr2Obj(dt.Rows[0], Productstype.ColumnNameEnum.DBName);
            }
            return null;
        }

    

    }
 


 
    #region 代码自动生成
	/// <summary>
	/// Productstype的BLL
	/// 该BLL已经生成了基本的业务操作，在自动生成的方法中已经提供了事务机制
	/// </summary>
    public partial class ProductstypeBLL : BaseBLL<Productstype>
    {
        #region 自动生成代码：取得相关实体

		/// <summary>
		/// 方法名称: ProductstypeBLL
		/// 内容摘要: 构造函数进行初始化
		/// </summary>
		protected ProductstypeBLL()
		{
		}
		private static volatile ProductstypeBLL m_instance = null;
		/// <summary>
		/// 方法名称: GetInstance
		/// 内容摘要: 取得 ProductstypeBLL 对象
		/// </summary>
		/// <returns>返回一个已经存在的实体</returns>
		public static ProductstypeBLL GetInstance()
		{
			// 通用的必要代码 iBatisNet双校检机制,如果实例不存在
			if (m_instance == null)
			{
				lock (typeof (ProductstypeBLL))
				{

					// 如果实例不存在
					if (m_instance == null)
					{

						// 创建一个的实例
						m_instance = new ProductstypeBLL();
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
        /// <returns>Productstype</returns>
        public Productstype Get(Productstype.Key key)
        {
            return ProductstypeDao.GetInstance().SelectByID(key);
        }
        /// <summary>
        /// 方法名称: Select
        /// 内容摘要: 基本查询，不带任何条件的查询
        /// </summary>
        public IList Select()
        {
            return ProductstypeDao.GetInstance().SelectAll();
        }
        /// <summary>
        /// 方法名称: Insert
        /// 内容摘要: 插入一条新纪录
        /// </summary>
        /// <returns>int</returns>
        public int Insert(Productstype obj)
        {
            return ProductstypeDao.GetInstance().Insert(obj);
        }

        /// <summary>
        /// 方法名称: Update
        /// 内容摘要: 更新一条新纪录
        /// </summary>
        /// <returns>int</returns>
        public int Update(Productstype obj)
        {
            ProductstypeDao.GetInstance().Update(obj);
            return 1;
        }

        /// <summary>
        /// 方法名称: Delete
        /// 内容摘要: 删除一条新纪录
        /// </summary>
        /// <returns>int</returns>
        public int Delete(Productstype obj)
        {
            ProductstypeDao.GetInstance().DeleteByID(obj.GetKey());
            return 1;
        }
		
		#endregion
		
    }
	#endregion
}