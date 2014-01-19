/*
版权所有：版权所有(C) 2011，刘建新
文件编号：M01_ModuleBll.cs
文件名称：ModuleBll.cs
系统编号：Z0003007
系统名称：通用办公系统
模块编号：M01
模块名称：信息发布
设计文档：IOA_M01信息发布XDE建模.mdx
完成日期：2011/3/18
作　　者：
内容摘要：表[Module]业务操作类
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using dx177.Model.Bus;
using dx177.Model.Bus.QueryO;
using dx177.DataAccess.Access.Bus;
using System.Collections;
using dx177.Access.Bus;
 

namespace dx177.Business.Bus
{
    /// <summary>
	/// Module的BLL 自定义方法
	/// 该BLL已经生成了基本的业务操作，在自动生成的方法中已经提供了事务机制
	/// </summary>
    public partial class ModuleBLL : BaseBLL<Module>
    {

        public List<string> GetModuleByGuid(string Guid)
        {
            List<string> li = new List<string>();
            DataTable dt = GetModule(Guid);
            foreach (DataRow dr in dt.Rows)
            {
                li.Add(dr["Modulecode"].ToString()); 
            }
            return li;
        }

        public DataTable GetModule(string Guid)
        {
            string sql = string.Format("select * from Module where pguid='{0}'", Guid);
            DataTable dt = this.GetDataTable(sql);
            return dt;
        }

        public void Submit(Module m)
        {
            if (m.Seqno<=0)
            {
                this.Insert(m);
            }
            else
            {
                this.Update(m);
            }

            
        }

        public void Submit(List<string> li,string Pguid)
        {
            
            DataTable dt = GetModule(Pguid);
            foreach (DataRow dr in dt.Rows)
            {
                if (!li.Contains(dr["Modulecode"].ToString()))
                {
                      Module m=Module.Dr2Obj(dr, Module.ColumnNameEnum.DBName);
                      this.Delete(m);
                }
            }
            if (li != null)
            {
                foreach (string s in li)
                {
                    if (!IsExist(Pguid, s))
                    {
                        Module m = new Module();
                        m.Modulecode = s;
                        m.Pguid = Pguid;
                        m.Showidx = 0;
                        this.Insert(m);
                    }
                }
            }
        }

        public bool IsExist(string Guid,string ModelCode)
        {
            string sql = "select 1  from Module where pguid='{0}' and  modulecode='{1}'";
            sql = string.Format(sql, Guid, ModelCode);
            DataTable dt = this.GetDataTable(sql);
            if (dt != null && dt.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }

        public DataTable GetData(ModuleQuery q )
        {
            string sql = @"select a.seqno ,  b.title as modulename  ,case when  isnull(c.title,'')='' then a.title else   c.title  end title   ,a.showidx from Module as a inner join ModuleType as b on b.code=a.modulecode  left  join  
                  (       select guid ,title  from News where ('news'='{0}' or ''='{0}' )
	                union select guid ,title  from    Products where ('products'='{0}' or ''='{0}' )
	                union select guid ,title  from  Questions   where ('questions'='{0}' or ''='{0}' )
	                union select guid ,name as  title  from  Hotel   where ('Hotel'='{0}' or ''='{0}' )
	                union select guid ,roomtitle as title   from  Room   where ('room'='{0}' or ''='{0}' )
	                union select guid ,title   from  Restaurant   where ('Restaurant'='{0}' or ''='{0}' )
	                union select guid ,title   from  HireCar   where ('HireCar'='{0}' or ''='{0}' )
	                union select guid ,title   from  Shop   where ('Shop'='{0}' or ''='{0}' ) )  as c on  a.pguid=c.guid  
                    where  (a.modulecode ='{1}'  or  ''='{1}') and ( (case when  c.title='' then isnull(a.title,'') else   isnull(c.title,'')   end )  like '%{2}%') order by a.showidx desc ";
            sql = string.Format(sql, q.Type, q.code,q.Title);
            DataTable dt = this.GetDataTable(sql);
            return dt;
        }
    }
 
 
    #region 代码自动生成
	/// <summary>
	/// Module的BLL
	/// 该BLL已经生成了基本的业务操作，在自动生成的方法中已经提供了事务机制
	/// </summary>
    public partial class ModuleBLL : BaseBLL<Module>
    {
        #region 自动生成代码：取得相关实体

		/// <summary>
		/// 方法名称: ModuleBLL
		/// 内容摘要: 构造函数进行初始化
		/// </summary>
		protected ModuleBLL()
		{
		}
		private static volatile ModuleBLL m_instance = null;
		/// <summary>
		/// 方法名称: GetInstance
		/// 内容摘要: 取得 ModuleBLL 对象
		/// </summary>
		/// <returns>返回一个已经存在的实体</returns>
		public static ModuleBLL GetInstance()
		{
			// 通用的必要代码 iBatisNet双校检机制,如果实例不存在
			if (m_instance == null)
			{
				lock (typeof (ModuleBLL))
				{

					// 如果实例不存在
					if (m_instance == null)
					{

						// 创建一个的实例
						m_instance = new ModuleBLL();
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
        /// <returns>Module</returns>
        public Module Get(Module.Key key)
        {
            return ModuleDao.GetInstance().SelectByID(key);
        }
        /// <summary>
        /// 方法名称: Select
        /// 内容摘要: 基本查询，不带任何条件的查询
        /// </summary>
        public IList Select()
        {
            return ModuleDao.GetInstance().SelectAll();
        }
        /// <summary>
        /// 方法名称: Insert
        /// 内容摘要: 插入一条新纪录
        /// </summary>
        /// <returns>int</returns>
        public int Insert(Module obj)
        {
            return ModuleDao.GetInstance().Insert(obj);
        }

        /// <summary>
        /// 方法名称: Update
        /// 内容摘要: 更新一条新纪录
        /// </summary>
        /// <returns>int</returns>
        public int Update(Module obj)
        {
            ModuleDao.GetInstance().Update(obj);
            return 1;
        }

        /// <summary>
        /// 方法名称: Delete
        /// 内容摘要: 删除一条新纪录
        /// </summary>
        /// <returns>int</returns>
        public int Delete(Module obj)
        {
            ModuleDao.GetInstance().DeleteByID(obj.GetKey());
            return 1;
        }
		
		#endregion
		
    }
	#endregion
}