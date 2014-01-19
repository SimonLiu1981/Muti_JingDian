using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using dx177.Model;
using dx177.DataAccess.Access;
 

namespace dx177.Business
{
    public abstract class BaseBLL<T>
    {
        
		/// <summary>
        /// 执行SQL方法
        /// </summary>
        /// <param name="sql"></param>
        public void Execute(string sql)
        {
            DBTool.ExecuteNonQuery(sql); 
        }

		/// <summary>
        /// 执行SQL 取得Table
        /// </summary>
        /// <param name="sql">sql</param>
        /// <returns>DataTable</returns>
        public DataTable GetDataTable(string sql)
        {
            return DBTool.ExecuteDataTable(sql);
        }
		 
        /// <summary>
        /// 执行存储过程
        /// </summary>
        /// <param name="tag">标签名</param>
        /// <param name="paramObject">参数</param>
        /// <returns>返回</returns>
        public Object ExecuteProcedure(string tag, object paramObject)
        {
            return null;
        }   

        /// <summary>
        /// 回滚事务
        /// </summary>
        internal void RollBackTransaction()
        {
             
        }
        /// <summary>
        /// 提交事务
        /// </summary>
        internal void CommitTransaction()
        {
           
        }
		
    }
}