using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using dx177.Model.Bus;
using dx177.Access.Bus;
using System.Collections;
using System.Data;
using dx177.Model;
using dx177.FrameWork;
using System.IO;
using System.Web;

namespace dx177.Business.Bus
{

    /// <summary>
    /// Qsttype的BLL 自定义方法
    /// 该BLL已经生成了基本的业务操作，在自动生成的方法中已经提供了事务机制
    /// </summary>
    public partial class QsttypeBLL : BaseBLL<Qsttype>
    {
        public DataTable GetQsttypeList(string jingquCode)
        {
            string sql = string.Format("select * from Qsttype  where (JingQuCode='{0}' or '{0}' = '')", string.Empty);
            DataTable dt = this.GetDataTable(sql);
            return dt;
        }

        public string GetQstGuid(string title)
        {
            string sql = string.Format("select guid  from Qsttype where title  like '%{0}%'",title ) ;
            DataTable dt = this.GetDataTable(sql);
            if (dt != null && dt.Rows.Count > 0)
            {
                return dt.Rows[0]["guid"].ToString();
            }
            return string.Empty;
        }


        public Qsttype GetQsttypeByguid(string guid)
        {
            string sql = string.Format("select * from Qsttype  where Guid='{0}' ", guid);
            DataTable dt = this.GetDataTable(sql);
            if (dt != null && dt.Rows.Count > 0)
            {
                return Qsttype.Dr2Obj(dt.Rows[0], Qsttype.ColumnNameEnum.DBName);
            }
            return null;
        }

        public Qsttype GetQsttypeBycode(string code)
        {
            if (code == string.Empty) return null;
            string sql = string.Format("select * from Qsttype  where code='{0}' ", code);
            DataTable dt = this.GetDataTable(sql);
            if (dt != null && dt.Rows.Count > 0)
            {
                return Qsttype.Dr2Obj(dt.Rows[0], Qsttype.ColumnNameEnum.DBName);
            }
            return null;
        }


        public string  GetQsttypeNameBycode(string code)
        {
           Qsttype q= GetQsttypeBycode(code);
           if (q != null)
               return q.Title;
           else
               return string.Empty;
        }

        public void CreateJs(string jqcode)
        {
            string sql = string.Format("select * from Qsttype where pguid='' and  (JingQuCode='{0}' or '{0}' = '')", jqcode);
            string class_level_1 = "var class_level_1=new Array({0});";
            string class_level_2 = "var class_level_2=new Array({0}) ;";
            DataTable dt = this.GetDataTable(sql);
            string tem1 = "";
            string tem2 = ""; 
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                tem1 += string.Format("  new Array(\"{0}\",\"{1}\") {2}  \r\n", dt.Rows[i]["guid"].ToString(), dt.Rows[i]["title"].ToString(), i == (dt.Rows.Count-1) ? "" : ",");
                sql = string.Format("select * from Qsttype where pguid='{0}'", dt.Rows[i]["guid"].ToString());
                DataTable dt1 = this.GetDataTable(sql);
                for (int j = 0; j < dt1.Rows.Count; j++)
                {
                    tem2 += string.Format("  new Array(\"{0}\",\"{1}\",\"{2}\") {3}  \r\n", dt.Rows[i]["guid"].ToString(), dt1.Rows[j]["guid"].ToString(), dt1.Rows[j]["title"].ToString(), j == (dt1.Rows.Count - 1) && i == (dt.Rows.Count - 1) ? "" : ",");
                }
            }
            class_level_1 = string.Format(class_level_1, tem1);
            class_level_2 = string.Format(class_level_2, tem2);
            class_level_1 = class_level_1 + " \r\n  \r\n" + class_level_2;


            string Hjs = HttpContext.Current.Server.MapPath("~/js/") + "qs_" + jqcode + ".js";
            if (File.Exists(Hjs))
            {
                File.Delete(Hjs);
            }

            FileInfo ii = new FileInfo(Hjs);
            if (!ii.Directory.Exists)
            {
                ii.Directory.Create();
            }

            HtmlUitl.CreaetHTMLFile(Hjs, class_level_1,"uft8");
        }
    }

    #region 代码自动生成
    /// <summary>
    /// Qsttype的BLL
    /// 该BLL已经生成了基本的业务操作，在自动生成的方法中已经提供了事务机制
    /// </summary>
    public partial class QsttypeBLL : BaseBLL<Qsttype>
    {
        #region 自动生成代码：取得相关实体

        /// <summary>
        /// 方法名称: QsttypeBLL
        /// 内容摘要: 构造函数进行初始化
        /// </summary>
        protected QsttypeBLL()
        {
        }
        private static volatile QsttypeBLL m_instance = null;
        /// <summary>
        /// 方法名称: GetInstance
        /// 内容摘要: 取得 QsttypeBLL 对象
        /// </summary>
        /// <returns>返回一个已经存在的实体</returns>
        public static QsttypeBLL GetInstance()
        {
            // 通用的必要代码 iBatisNet双校检机制,如果实例不存在
            if (m_instance == null)
            {
                lock (typeof(QsttypeBLL))
                {

                    // 如果实例不存在
                    if (m_instance == null)
                    {

                        // 创建一个的实例
                        m_instance = new QsttypeBLL();
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
        /// <returns>Qsttype</returns>
        public Qsttype Get(Qsttype.Key key)
        {
            return QsttypeDao.GetInstance().SelectByID(key);
        }
        /// <summary>
        /// 方法名称: Select
        /// 内容摘要: 基本查询，不带任何条件的查询
        /// </summary>
        public IList Select()
        {
            return QsttypeDao.GetInstance().SelectAll();
        }
        /// <summary>
        /// 方法名称: Insert
        /// 内容摘要: 插入一条新纪录
        /// </summary>
        /// <returns>int</returns>
        public int Insert(Qsttype obj)
        {
            return QsttypeDao.GetInstance().Insert(obj);
        }

        /// <summary>
        /// 方法名称: Update
        /// 内容摘要: 更新一条新纪录
        /// </summary>
        /// <returns>int</returns>
        public int Update(Qsttype obj)
        {
            QsttypeDao.GetInstance().Update(obj);
            return obj.Seqno;
        }

        /// <summary>
        /// 方法名称: Delete
        /// 内容摘要: 删除一条新纪录
        /// </summary>
        /// <returns>int</returns>
        public int Delete(Qsttype obj)
        {
            QsttypeDao.GetInstance().DeleteByID(obj.GetKey());
            return obj.Seqno;
        }

        #endregion

    }

    #endregion
}


 