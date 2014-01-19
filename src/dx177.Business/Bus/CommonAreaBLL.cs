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
    public partial class CommonAreaBLL : BaseBLL<CommonArea>
    {
        public DataTable GetProvince()
        {
            string sql = ("select top 27 * from common_area a where a.PAreaID = 0");
            return this.GetDataTable(sql);
        }

        public List<CommonArea> GetByParentAreaID(int pid)
        {
            string sql = string.Format("select * from common_Area where PAreaID = {0}", pid);

            return CommonArea.Dt2Objs(this.GetDataTable(sql));

        }

        public CommonArea GetByAreaID(string Areaid)
        {
            string sql = string.Format("select * from common_Area where AreaID = {0}", Areaid);


            DataTable dt = (this.GetDataTable(sql));
            if (dt.Rows.Count > 0)
            {
                return CommonArea.Dr2Obj(dt.Rows[0], dx177.Model.BaseModel.ColumnNameEnum.DBName);
            }
            else
            {
                return null;
            }

        }
        public string  GetByAreaName(string Areaid)
        {
            CommonArea a = GetByAreaID(Areaid);
            if (a != null)
                return a.Areaname;
            else
                return string.Empty;
        }


    }


    #region 代码自动生成
    /// <summary>
    /// Comment的BLL
    /// 该BLL已经生成了基本的业务操作，在自动生成的方法中已经提供了事务机制
    /// </summary>
    public partial class CommonAreaBLL : BaseBLL<CommonArea>
    {
        #region 自动生成代码：取得相关实体

        /// <summary>
        /// 方法名称: CommentBLL
        /// 内容摘要: 构造函数进行初始化
        /// </summary>
        protected CommonAreaBLL()
        {
        }
        private static volatile CommonAreaBLL m_instance = null;
        /// <summary>
        /// 方法名称: GetInstance
        /// 内容摘要: 取得 CommonAreaBLL 对象
        /// </summary>
        /// <returns>返回一个已经存在的实体</returns>
        public static CommonAreaBLL GetInstance()
        {
            // 通用的必要代码 iBatisNet双校检机制,如果实例不存在
            if (m_instance == null)
            {
                lock (typeof(CommonAreaBLL))
                {

                    // 如果实例不存在
                    if (m_instance == null)
                    {

                        // 创建一个的实例
                        m_instance = new CommonAreaBLL();
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
        /// <returns>Comment</returns>
        public CommonArea Get(CommonArea.Key key)
        {
            return CommonAreaDao.GetInstance().SelectByID(key);
        }
        /// <summary>
        /// 方法名称: Select
        /// 内容摘要: 基本查询，不带任何条件的查询
        /// </summary>
        public IList Select()
        {
            return CommonAreaDao.GetInstance().SelectAll();
        }
        /// <summary>
        /// 方法名称: Insert
        /// 内容摘要: 插入一条新纪录
        /// </summary>
        /// <returns>int</returns>
        public int Insert(CommonArea obj)
        {
            return CommonAreaDao.GetInstance().Insert(obj);
        }

        /// <summary>
        /// 方法名称: Update
        /// 内容摘要: 更新一条新纪录
        /// </summary>
        /// <returns>int</returns>
        public int Update(CommonArea obj)
        {
            CommonAreaDao.GetInstance().Update(obj);
            return 1;
        }

        /// <summary>
        /// 方法名称: Delete
        /// 内容摘要: 删除一条新纪录
        /// </summary>
        /// <returns>int</returns>
        public int Delete(CommonArea obj)
        {
            CommonAreaDao.GetInstance().DeleteByID(obj.GetKey());
            return 1;
        }

        #endregion

    }
    #endregion
}