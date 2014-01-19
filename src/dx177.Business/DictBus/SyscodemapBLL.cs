using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using dx177.Access.Bus;
using dx177.Model.Bus;
using System.Collections;
using System.Data;
using dx177.Model;

namespace dx177.Business.DictBus
{

    /// <summary>
    /// BaseDictTag的BLL 自定义方法
    /// 该BLL已经生成了基本的业务操作，在自动生成的方法中已经提供了事务机制
    /// </summary>
    public partial class SyscodemapBLL : BaseBLL<Syscodemap>
    {

        public DataTable GetSyscodemapListBytype(string type, string TypeName, string name, string jqcode)
        {
            string sql = string.Format(" select * from SysCodeMap  where (type='{0}' or ''='{0}') and TypeName like '%{1}%' and name like '%{2}%' and (JingQuCode='{2}' or '{2}'='') ", type, TypeName, name, jqcode);
            DataTable dt = this.GetDataTable(sql);
            return dt;
        }

        public void Submit(Syscodemap syscodemap, string jqcode)
        {
            syscodemap.Jingqucode = jqcode;
            if (syscodemap.SyscodemapId > 0)
            {
                this.Update(syscodemap);
            }
            else
            {
                this.Insert(syscodemap);
            }
        
        }

    }
 


    #region 代码自动生成
    public partial class SyscodemapBLL : BaseBLL<Syscodemap>  
    {

        #region 自动生成代码：取得相关实体

		/// <summary>
		/// 方法名称: BaseDictTagBLL
		/// 内容摘要: 构造函数进行初始化
		/// </summary>
        protected SyscodemapBLL()
		{
		}
        private static volatile SyscodemapBLL m_instance = null;
		/// <summary>
		/// 方法名称: GetInstance
		/// 内容摘要: 取得 BaseDictTagBLL 对象
		/// </summary>
		/// <returns>返回一个已经存在的实体</returns>
        public static SyscodemapBLL GetInstance()
		{
			// 通用的必要代码 iBatisNet双校检机制,如果实例不存在
			if (m_instance == null)
			{
                lock (typeof(SyscodemapBLL))
				{

					// 如果实例不存在
					if (m_instance == null)
					{

						// 创建一个的实例
                        m_instance = new SyscodemapBLL();
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
        public Syscodemap Get(Syscodemap.Key key)
		{
            return SyscodemapDao.GetInstance().SelectByID(key);
			//return base.ISqlDao.SelectOne(key.BaseDictTagId);
		}
		/// <summary>
		/// 方法名称: Select
		/// 内容摘要: 基本查询，不带任何条件的查询
		/// </summary>
		public IList Select()
        {
            return SyscodemapDao.GetInstance().SelectAll();
            //return base.ISqlDao.SelectAll();           
        }
		/// <summary>
		/// 方法名称: Insert
		/// 内容摘要: 插入一条新纪录
		/// </summary>
		/// <returns>int</returns>
        public int Insert(Syscodemap  obj)
		{
            return SyscodemapDao.GetInstance().Insert(obj);
		}
		
		/// <summary>
		/// 方法名称: Update
		/// 内容摘要: 更新一条新纪录
		/// </summary>
		/// <returns>int</returns>
        public int Update(Syscodemap obj)
		{
            SyscodemapDao.GetInstance().Update(obj);
            return 1;
		}
		
		/// <summary>
		/// 方法名称: Delete
		/// 内容摘要: 删除一条新纪录
		/// </summary>
		/// <returns>int</returns>
        public int Delete(Syscodemap obj)
		{
            SyscodemapDao.GetInstance().DeleteByID(obj.GetKey());
            return 1;
		}
		
		#endregion

    }
    #endregion
}
