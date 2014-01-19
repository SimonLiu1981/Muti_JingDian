using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using dx177.Model.Bus;
using dx177.Access.Bus;
using System.Data;
using System.Collections;

namespace dx177.Business.Bus
{
    /// <summary>
    /// BaseDictTag的BLL 自定义方法
    /// 该BLL已经生成了基本的业务操作，在自动生成的方法中已经提供了事务机制
    /// </summary>
    public partial class BaseDictTypeBLL : BaseBLL<BaseDictType>
    {

        public DataTable GetDictTagType()
        {
            string sql = " select * from Base_Dict_type   ";
            DataTable dt = this.GetDataTable(sql);
            return dt;
        }


    }


    #region 代码自动生成
    /// <summary>
    /// BaseDictTag的BLL
    /// 该BLL已经生成了基本的业务操作，在自动生成的方法中已经提供了事务机制
    /// </summary>
    public partial class BaseDictTypeBLL : BaseBLL<BaseDictType>
    {
        #region 自动生成代码：取得相关实体

        /// <summary>
        /// 方法名称: BaseDictTagBLL
        /// 内容摘要: 构造函数进行初始化
        /// </summary>
        protected BaseDictTypeBLL()
        {
        }
        private static volatile BaseDictTypeBLL m_instance = null;
        /// <summary>
        /// 方法名称: GetInstance
        /// 内容摘要: 取得 BaseDictTagBLL 对象
        /// </summary>
        /// <returns>返回一个已经存在的实体</returns>
        public static BaseDictTypeBLL GetInstance()
        {
            // 通用的必要代码 iBatisNet双校检机制,如果实例不存在
            if (m_instance == null)
            {
                lock (typeof(BaseDictTypeBLL))
                {

                    // 如果实例不存在
                    if (m_instance == null)
                    {

                        // 创建一个的实例
                        m_instance = new BaseDictTypeBLL();
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
        public BaseDictType Get(BaseDictType.Key key)
        {
            return BaseDictTypeDao.GetInstance().SelectByID(key);
            //return base.ISqlDao.SelectOne(key.BaseDictTagId);
        }
        /// <summary>
        /// 方法名称: Select
        /// 内容摘要: 基本查询，不带任何条件的查询
        /// </summary>
        public IList Select()
        {
            return BaseDictTypeDao.GetInstance().SelectAll();
            //return base.ISqlDao.SelectAll();           
        }
        /// <summary>
        /// 方法名称: Insert
        /// 内容摘要: 插入一条新纪录
        /// </summary>
        /// <returns>int</returns>
        public int Insert(BaseDictType obj)
        {
            return BaseDictTypeDao.GetInstance().Insert(obj);
        }

        /// <summary>
        /// 方法名称: Update
        /// 内容摘要: 更新一条新纪录
        /// </summary>
        /// <returns>int</returns>
        public int Update(BaseDictType obj)
        {
            BaseDictTypeDao.GetInstance().Update(obj);
            return 1;
        }

        /// <summary>
        /// 方法名称: Delete
        /// 内容摘要: 删除一条新纪录
        /// </summary>
        /// <returns>int</returns>
        public int Delete(BaseDictType obj)
        {
            BaseDictTypeDao.GetInstance().DeleteByID(obj.GetKey());
            return 1;
        }

        #endregion

    }
    #endregion
}
 