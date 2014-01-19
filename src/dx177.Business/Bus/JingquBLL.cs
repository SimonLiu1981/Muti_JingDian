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
    public partial class JingqusBLL
    {
        static Dictionary<string, Jingqus> jingquCache = new Dictionary<string, Jingqus>();
        


        public DataTable SearchByConditions(string jingquname, string areaId)
        {
            string sql = string.Format(@" select j.*,isnull(j.priceinfo,'还没有定义景区门票!<br/>请与管理员联系.') as priceinfo1  from JingQus j where (''='{0}' or  JingQuName like '%{0}%') ", jingquname);
            if (areaId != string.Empty)
            {
                sql += string.Format(@" and ('{0}' = '' or  
                             AreaID in ( select {0} 
                             union select a.AreaID from common_Area a  where a.PAreaID = {0} 
                             union select a.AreaID from common_Area a  where a.PAreaID in (select a.AreaID from common_Area a  where a.PAreaID = {0})
                              ))", areaId);
            }

            return this.GetDataTable(sql);
        }

        public List<Jingqus> GetJinQusByAreaid(int areaid, int jingqu_id)
        {
            string sql = string.Format("select * from JingQus where areaid={0} and (jingqu_id<>{1} or {1}=-1)", areaid, jingqu_id);
            DataTable dt = this.GetDataTable(sql);
            if (dt != null && dt.Rows != null && dt.Rows.Count > 0)
            {
                return Jingqus.Dt2Objs(dt);
            }
            return null;
        }

        public List<Jingqus> GetJinQusByParent(string Parent)
        {
            string sql = string.Format("select * from JingQus where Parent='{0}' ", Parent);
            DataTable dt = this.GetDataTable(sql);
            if (dt != null && dt.Rows != null && dt.Rows.Count > 0)
            {
                return Jingqus.Dt2Objs(dt);
            }
            return null;
        }

        public Jingqus GetEntityByJingqucode(string jingqucode)
        {
            if (jingqucode == string.Empty) return null ;

            if (jingquCache.ContainsKey(jingqucode))
            {
                return jingquCache[jingqucode];
            }

            string sql = string.Format("select * from JingQus where JingQuCode = '{0}'", jingqucode);
            DataTable dt = this.GetDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                jingquCache.Add(jingqucode, Jingqus.Dr2Obj(dt.Rows[0]));
                return Jingqus.Dr2Obj(dt.Rows[0]);
            }

            return null;
        }


        public bool FindByTitle(string title)
        {

            string sql = string.Format("select * from questions where title = '{0}'", title.Trim());
            DataTable dt = this.GetDataTable(sql);
            return dt.Rows.Count > 0;
        }
        public string  GetNameByJingqucode(string jingqucode)
        {
           Jingqus j= GetEntityByJingqucode(jingqucode);
           if (j != null)
               return j.Jingquname;
           else
               return string.Empty;
         }



        public void Submit(Jingqus ja,List<string > subjingqu)
        {
            IList<Picturelist> dd = PicturelistBLL.GetInstance().GetPicsByGuid(ja.Guid);
            if (dd.Count > 0)
            {
                ja.Logo = dd[0].Smallimgfile;
            }
            else
            {
                ja.Logo = string.Empty;
            }

            if (ja.JingquId != 0)
            {
                this.Update(ja);
                string sql = string.Format("update JingQus set parent='{2}' where areaid={0} and JingQu_ID<>{1}", ja.Areaid, ja.JingquId, "");
                this.Execute(sql);
                foreach(string s in subjingqu )
                {
                   sql = string.Format("update JingQus set parent='{1}' where JingQuCode='{0}'  ", s, ja.Jingqucode);
                   this.Execute(sql);
                }
              
            }
            else
            {
                this.Insert(ja);
            }

            if (jingquCache.ContainsKey(ja.Jingqucode))
            {
                jingquCache[ja.Jingqucode] = ja;
            }
            else
            {
                jingquCache.Add(ja.Jingqucode, ja);
            }
        }

        public Jingqus GetByGuid(string guid)
        {
            string sql = string.Format("select * from JingQus where guid = '{0}'", guid);
            DataTable dt = this.GetDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                return Jingqus.Dr2Obj(dt.Rows[0]);
            }
            return null;

        }
    }

    #region 代码自动生成
    /// <summary>
    /// Jingqu的BLL
    /// 该BLL已经生成了基本的业务操作，在自动生成的方法中已经提供了事务机制
    /// </summary>
    public partial class JingqusBLL : BaseBLL<Jingqus>
    {
        #region 自动生成代码：取得相关实体

        /// <summary>
        /// 方法名称: JingqusBLL
        /// 内容摘要: 构造函数进行初始化
        /// </summary>
        protected JingqusBLL()
        {
        }
        private static volatile JingqusBLL m_instance = null;
        /// <summary>
        /// 方法名称: GetInstance
        /// 内容摘要: 取得 JingqusBLL 对象
        /// </summary>
        /// <returns>返回一个已经存在的实体</returns>
        public static JingqusBLL GetInstance()
        {
            // 通用的必要代码 iBatisNet双校检机制,如果实例不存在
            if (m_instance == null)
            {
                lock (typeof(JingqusBLL))
                {

                    // 如果实例不存在
                    if (m_instance == null)
                    {

                        // 创建一个的实例
                        m_instance = new JingqusBLL();
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
        /// <returns>Jingqu</returns>
        public Jingqus Get(Jingqus.Key key)
        {
            return JingqusDao.GetInstance().SelectByID(key);
        }
        /// <summary>
        /// 方法名称: Select
        /// 内容摘要: 基本查询，不带任何条件的查询
        /// </summary>
        public IList Select()
        {
            return JingqusDao.GetInstance().SelectAll();
        }
        /// <summary>
        /// 方法名称: Insert
        /// 内容摘要: 插入一条新纪录
        /// </summary>
        /// <returns>int</returns>
        public int Insert(Jingqus obj)
        {
            return JingqusDao.GetInstance().Insert(obj);
        }

        /// <summary>
        /// 方法名称: Update
        /// 内容摘要: 更新一条新纪录
        /// </summary>
        /// <returns>int</returns>
        public int Update(Jingqus obj)
        {
            JingqusDao.GetInstance().Update(obj);
            return 1;
        }

        /// <summary>
        /// 方法名称: Delete
        /// 内容摘要: 删除一条新纪录
        /// </summary>
        /// <returns>int</returns>
        public int Delete(Jingqus obj)
        {
            JingqusDao.GetInstance().DeleteByID(obj.GetKey());
            return 1;
        }


        #endregion

    }
    #endregion
}
