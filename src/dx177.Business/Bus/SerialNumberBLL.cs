using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using dx177.Business.Bus;
using dx177.DataAccess.Access;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Data;


namespace dx177.Business.Bus
{

    public class SerialNumberBLL
    {
        #region 自动生成代码：取得相关实体

        /// <summary>
        /// 方法名称: OrderApplyBLL
        /// 内容摘要: 构造函数进行初始化
        /// </summary>
        protected SerialNumberBLL()
        {
        }
        private static volatile SerialNumberBLL m_instance = null;
        /// <summary>
        /// 方法名称: GetInstance
        /// 内容摘要: 取得 SerialNumberBLL 对象
        /// </summary>
        /// <returns>返回一个已经存在的实体</returns>
        public static SerialNumberBLL GetInstance()
        {
            // 通用的必要代码 iBatisNet双校检机制,如果实例不存在
            if (m_instance == null)
            {
                lock (typeof(SerialNumberBLL))
                {

                    // 如果实例不存在
                    if (m_instance == null)
                    {

                        // 创建一个的实例
                        m_instance = new SerialNumberBLL();
                    }
                }
            }

            // 返回业务逻辑对象
            return m_instance;
        }

        #endregion
        /// <summary>
        /// 得到流水号
        /// </summary>
        /// <param name="pofix">前缀</param>
        /// <param name="datefromat">日期格式如20050512 ：获取当天的日期</param>
        /// <param name="length">长度：根据你的实际需求来填写你的长度（交易量少则长度短些）</param>
        /// <returns>200501020001</returns>
        public string GetSerialumber(string pofix, string datefromat, int length)
        {
            

            OleDbParameter a=new OleDbParameter() ;
            a.ParameterName = "@profix";
            a.DbType = System.Data.DbType.String;
            a.Size = 10;
            a.Value = pofix;
            OleDbParameter b=new OleDbParameter() ;
            b.ParameterName = "@dateFormat";
            b.DbType = System.Data.DbType.String;
            b.Value = datefromat;
            a.Size = 20;
            OleDbParameter c=new OleDbParameter() ;
            c.ParameterName = "@length";
            c.DbType = System.Data.DbType.Int32;            
            c.Value = length;
            OleDbParameter d = new OleDbParameter() ;
            d.DbType = System.Data.DbType.String;
            d.ParameterName = "@result";
            d.Size = 1000;
            d.Direction= System.Data.ParameterDirection.Output;
            OleDbHelper.ExecuteNonQuery(System.Data.CommandType.StoredProcedure, "Pro_CreateSerial", a, b, c, d);


           

            return d.Value.ToString();
        }
 
    }
}
