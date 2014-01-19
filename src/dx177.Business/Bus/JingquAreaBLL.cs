using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using dx177.Model.Bus;
using dx177.Access.Bus;
using System.Collections;
using System.Data;

namespace dx177.Business.Bus
{
    public partial class JingquAreaBLL
    {

        public DataTable GetByJingqucode(string jingqucode)
        {
            string sql = string.Format("select * from JingQu_Area where JinqQuCode = '{0}'", jingqucode);
            DataTable dt = this.GetDataTable(sql);
            return dt;
        }





        public void Submit(JingquArea ja)
        {
            if (ja.Jingquareaid != 0)
            {
                this.Update(ja);
            }
            else
            {
                this.Insert(ja);
            }
        }
    }

    #region 代码自动生成
    /// <summary>
    /// JingquArea的BLL
    /// 该BLL已经生成了基本的业务操作，在自动生成的方法中已经提供了事务机制
    /// </summary>
    public partial class JingquAreaBLL : BaseBLL<JingquArea>
    {
        #region 自动生成代码：取得相关实体

        /// <summary>
        /// 方法名称: JingquAreaBLL
        /// 内容摘要: 构造函数进行初始化
        /// </summary>
        protected JingquAreaBLL()
        {
        }
        private static volatile JingquAreaBLL m_instance = null;
        /// <summary>
        /// 方法名称: GetInstance
        /// 内容摘要: 取得 JingquAreaBLL 对象
        /// </summary>
        /// <returns>返回一个已经存在的实体</returns>
        public static JingquAreaBLL GetInstance()
        {
            // 通用的必要代码 iBatisNet双校检机制,如果实例不存在
            if (m_instance == null)
            {
                lock (typeof(JingquAreaBLL))
                {

                    // 如果实例不存在
                    if (m_instance == null)
                    {

                        // 创建一个的实例
                        m_instance = new JingquAreaBLL();
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
        /// <returns>JingquArea</returns>
        public JingquArea Get(JingquArea.Key key)
        {
            return JingquAreaDao.GetInstance().SelectByID(key);
        }
        /// <summary>
        /// 方法名称: Select
        /// 内容摘要: 基本查询，不带任何条件的查询
        /// </summary>
        public IList Select()
        {
            return JingquAreaDao.GetInstance().SelectAll();
        }
        /// <summary>
        /// 方法名称: Insert
        /// 内容摘要: 插入一条新纪录
        /// </summary>
        /// <returns>int</returns>
        public int Insert(JingquArea obj)
        {
            return JingquAreaDao.GetInstance().Insert(obj);
        }

        /// <summary>
        /// 方法名称: Update
        /// 内容摘要: 更新一条新纪录
        /// </summary>
        /// <returns>int</returns>
        public int Update(JingquArea obj)
        {
            JingquAreaDao.GetInstance().Update(obj);
            return 1;
        }

        /// <summary>
        /// 方法名称: Delete
        /// 内容摘要: 删除一条新纪录
        /// </summary>
        /// <returns>int</returns>
        public int Delete(JingquArea obj)
        {
            JingquAreaDao.GetInstance().DeleteByID(obj.GetKey());
            return 1;
        }


        #endregion

    }
    #endregion
}
