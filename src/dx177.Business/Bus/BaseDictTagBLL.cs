/*
版权所有：版权所有(C) 2011，刘建新
文件编号：M01_BaseDictTagBll.cs
文件名称：BaseDictTagBll.cs
系统编号：Z0003007
系统名称：通用办公系统
模块编号：M01
模块名称：信息发布
设计文档：IOA_M01信息发布XDE建模.mdx
完成日期：2011/3/21
作　　者：
内容摘要：表[Base_Dict_Tag]业务操作类
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
	/// BaseDictTag的BLL 自定义方法
	/// 该BLL已经生成了基本的业务操作，在自动生成的方法中已经提供了事务机制
	/// </summary>
    public partial class BaseDictTagBLL : BaseBLL<BaseDictTag>
    {

        public DataTable GetDictTag(string enum_type_name)
        {
            string sql = string.Format( " select * from Base_Dict_Tag  where enum_type_name='{0}'",enum_type_name)  ;
            DataTable dt = this.GetDataTable(sql);
            return dt;
        }


        public BaseDictTag GetaDictag(string enum_type_name, string enum_value)
        {
            if (enum_value == string.Empty) return null;

            string sql = string.Format(" select * from Base_Dict_Tag where Enum_Type_Name='{0}' and enum_value='{1}'", enum_type_name, enum_value);
            DataTable dt = this.GetDataTable(sql);
            if (dt != null && dt.Rows.Count > 0)
            {
                return BaseDictTag.Dr2Obj(dt.Rows[0], BaseDictTag.ColumnNameEnum.DBName);
            }
            return null ;
        }

        public string  GetDictagName(string enum_type_name, string enum_value)
        {
            BaseDictTag b = GetaDictag(enum_type_name, enum_value);
            if (b != null)
                return b.TagName;
            else
                return string.Empty;
        }
    }
 
 
    #region 代码自动生成
	/// <summary>
	/// BaseDictTag的BLL
	/// 该BLL已经生成了基本的业务操作，在自动生成的方法中已经提供了事务机制
	/// </summary>
    public partial class BaseDictTagBLL : BaseBLL<BaseDictTag>
    {
        #region 自动生成代码：取得相关实体

		/// <summary>
		/// 方法名称: BaseDictTagBLL
		/// 内容摘要: 构造函数进行初始化
		/// </summary>
		protected BaseDictTagBLL()
		{
		}
		private static volatile BaseDictTagBLL m_instance = null;
		/// <summary>
		/// 方法名称: GetInstance
		/// 内容摘要: 取得 BaseDictTagBLL 对象
		/// </summary>
		/// <returns>返回一个已经存在的实体</returns>
		public static BaseDictTagBLL GetInstance()
		{
			// 通用的必要代码 iBatisNet双校检机制,如果实例不存在
			if (m_instance == null)
			{
				lock (typeof (BaseDictTagBLL))
				{

					// 如果实例不存在
					if (m_instance == null)
					{

						// 创建一个的实例
						m_instance = new BaseDictTagBLL();
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
		/// <returns>BaseDictTag</returns>
		public BaseDictTag Get(BaseDictTag.Key key)
		{
            return BaseDictTagDao.GetInstance().SelectByID(key);
			//return base.ISqlDao.SelectOne(key.BaseDictTagId);
		}
		/// <summary>
		/// 方法名称: Select
		/// 内容摘要: 基本查询，不带任何条件的查询
		/// </summary>
		public IList Select()
        {
            return BaseDictTagDao.GetInstance().SelectAll();
            //return base.ISqlDao.SelectAll();           
        }
		/// <summary>
		/// 方法名称: Insert
		/// 内容摘要: 插入一条新纪录
		/// </summary>
		/// <returns>int</returns>
		public int Insert(BaseDictTag obj)
		{
            return BaseDictTagDao.GetInstance().Insert(obj);
		}
		
		/// <summary>
		/// 方法名称: Update
		/// 内容摘要: 更新一条新纪录
		/// </summary>
		/// <returns>int</returns>
		public int Update(BaseDictTag obj)
		{
            BaseDictTagDao.GetInstance().Update(obj);
            return 1;
		}
		
		/// <summary>
		/// 方法名称: Delete
		/// 内容摘要: 删除一条新纪录
		/// </summary>
		/// <returns>int</returns>
		public int Delete(BaseDictTag obj)
		{
            BaseDictTagDao.GetInstance().DeleteByID(obj.GetKey());
            return 1;
		}
		
		#endregion
		
    }
	#endregion
}