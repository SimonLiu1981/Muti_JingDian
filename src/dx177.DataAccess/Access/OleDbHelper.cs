using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Collections;
using System.Configuration;
namespace dx177.DataAccess.Access
{
  

     
        public abstract class OleDbHelper
        {
            #region Print Helper类
            public static readonly string connectionString = ConfigurationSettings.AppSettings["ConnectionNewString"];
            //哈希表处理缓存，可以存储任意类型的参数
            private static Hashtable parmCache = Hashtable.Synchronized(new Hashtable());
            /// <summary>
            /// 为执行命令准备参数
            /// </summary>
            /// <param name="cmd">OleDbCommand命令</param>
            /// <param name="conn">已经存在的数据连接</param>
            /// <param name="trans">数据库食物处理</param>
            /// <param name="cmdType">OleDbCommand命令类型(存储过程，T-SQL语句，等等。)</param>
            /// <param name="cmdText">t-sql语句</param>
            /// <param name="cmdParms">返回带参数的命令</param>
            private static void PrepareCommand(OleDbCommand cmd, 
                OleDbConnection conn, 
                OleDbTransaction trans, 
                CommandType cmdType, 
                string cmdText, 
                OleDbParameter[] cmdParms)
            {
                //判断数据库连接状态
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                cmd.Connection = conn;
                cmd.CommandText = cmdText;
                //判断是否需要事务处理
                if (trans != null)
                {
                    cmd.Transaction = trans;
                }
                cmd.CommandType = cmdType;
                if (cmdParms != null)
                {
                    foreach (OleDbParameter parm in cmdParms)
                    {
                        cmd.Parameters.Add(parm);
                    }
                }
            }
            /// <summary>
            /// 一个不需要返回值的OleDbCommand命令，
            /// 通过指定专用的连接字符串。使用参数数组形式提供参数列表 
            /// </summary>
            /// <param name="cmdType">OleDbCommand命令类型(存储过程， T-SQL语句， 等等。) </param>
            /// <param name="cmdText">存储过程的名字或者 T-SQL 语句</param>
            /// <param name="commParams">以数组形式提供OleDbCommand命令中用到的参数列表</param>
            /// <returns>返回一个数值表示此OleDbCommand命令执行后影响的行数</returns>
            public static int ExecuteNonQuery(CommandType cmdType, string cmdText, params OleDbParameter[] commParams)
            {
                OleDbCommand cmd = new OleDbCommand();
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    //通过PrePareCommand方法将参数逐个加入到SqlCommand的参数集合中
                    PrepareCommand(cmd, conn, null, cmdType, cmdText, commParams);
                    int val = 0;
                    try
                    {
                        val = cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        string sss = "";
                    }
                    cmd.Parameters.Clear();//清空OleDbCommand中的参数列表
                    return val;
                }
            }
            /// <summary>
            /// 执行一条不返回结果的OleDbCommand，通过一个已经存在的数据库连接
            /// 使用参数数组提供参数
            /// </summary>
            /// <param name="connection">一个现有的数据库连接</param>
            /// <param name="cmdType">OleDbCommand命令类型(存储过程，t-sql语句...)</param>
            /// <param name="cmdText">存储过程名字或者T_SQL语句</param>
            /// <param name="cmdParams">以数组的形式提供OleDbCommand命令中用到的参数列表</param>
            /// <returns>返回一个数值表示此OleDbCommand命令执行后 受影响的行数</returns>
            public static int ExecuteNonQuery(OleDbConnection connection, CommandType cmdType, string cmdText, params OleDbParameter[] cmdParams)
            {
                OleDbCommand cmd = new OleDbCommand();
                PrepareCommand(cmd, connection, null, cmdType, cmdText, cmdParams);
                int val = cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                return val;
            }
            /// <summary>
            /// 执行一条不返回结果的OleDbCommand，通过一个已经存在的数据库事物处理 
            /// </summary>
            /// <param name="trans">一个存在的 sql 事物处理</param>
            /// <param name="cmdType">OleDbCommand命令类型 (存储过程， T-SQL语句， 等等。)</param>
            /// <param name="cmdText">存储过程的名字或者 T-SQL 语句</param>
            /// <param name="cmdParams">以数组的形式提供OleDbCommand命令中用到的参数列表</param>
            /// <returns>返回一个数值 表示此OleDbCommand命令执行后受影响的行数</returns>
            public static int ExecuteNonQuery(OleDbTransaction trans, CommandType cmdType, string cmdText, params OleDbParameter[] cmdParams)
            {
                OleDbCommand cmd = new OleDbCommand();
                PrepareCommand(cmd, trans.Connection, trans, cmdType, cmdText, cmdParams);
                int val = cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                return val;
            }
            /// <summary>
            /// 执行一条返回结果集的OleDbCommand命令，通过专用的连接字符串。
            /// 使用参数数组提供参数
            /// </summary>
            /// <param name="connectionString">一个有效的数据库连接</param>
            /// <param name="cmdType">OleDbCommand命令类型(存储过程，T-SQL语句...)</param>
            /// <param name="cmdText">存储过程名字或者T-SQL语句</param>
            /// <param name="cmdParams">以数组形式提供OleDbCommand中用到的参数列表</param>
            /// <returns>返回一个包含结果的OleDbDataReader</returns>
            public static OleDbDataReader ExecureReader(string connectionString, CommandType cmdType, string cmdText, params OleDbParameter[] cmdParams)
            {
                OleDbCommand cmd = new OleDbCommand();
                OleDbConnection conn = new OleDbConnection(connectionString);
                // 在这里使用try/catch处理是因为如果方法出现异常，则SqlDataReader就不存在，
                //CommandBehavior.CloseConnection的语句就不会执行，触发的异常由catch捕获。
                //关闭数据库连接，并通过throw再次引发捕捉到的异常。
                try
                {
                    PrepareCommand(cmd, conn, null, cmdType, cmdText, cmdParams);
                    OleDbDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    cmd.Parameters.Clear();
                    return rdr;
                }
                catch
                {
                    conn.Close();
                    throw;
                }
            }
            /// <summary>
            /// 执行一条返回第一条记录的第一列的OleDbCommand命令，通过专用的连接字符串。
            /// 使用参数数组提供参数
            /// </summary>
            /// <param name="cmdType">OleDbCommand命令类型(存储过程，T-SQL语句)</param>
            /// <param name="cmdText">存储过程名或者T-SQL语句</param>
            /// <param name="cmdParams">以数组形式提供OleDbCommand命令中用到的参数列表</param>
            /// <returns>返回一个object类型的数据，可以通过Convert.To{Type}方法转换类型</returns>
            public static object ExecuteScalar(CommandType cmdType, string cmdText, params OleDbParameter[] cmdParams)
            {
                OleDbCommand cmd = new OleDbCommand();
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    PrepareCommand(cmd, conn, null, cmdType, cmdText, cmdParams);
                    object val = cmd.ExecuteScalar();
                    cmd.Parameters.Clear();
                    return val;
                }
            }
            /// <summary>
            /// 执行一条返回第一条记录第一列的SqlCommand命令，通过已经存在的数据库连接。
            /// 使用参数数组提供参数
            /// </summary>
            /// <param name="conn">一个已经存在的数据库连接</param>
            /// <param name="cmdType">OleDbCommand命令类型</param>
            /// <param name="cmdText">存储过程名或者t-sql</param>
            /// <param name="cmdParams">以数组形式提供OleDbCommand命令中用到的参数列表</param>
            /// <returns>返回一个object类型的数据，可以通过 Convert.To{Type}方法转换类型</returns>
            public static object ExecuteScalar(OleDbConnection conn, CommandType cmdType, string cmdText, params OleDbParameter[] cmdParams)
            {
                OleDbCommand cmd = new OleDbCommand();
                PrepareCommand(cmd, conn, null, cmdType, cmdText, cmdParams);
                object val = cmd.ExecuteScalar();
                cmd.Parameters.Clear();
                return val;
            }
            /// <summary>
            /// 缓存参数数组
            /// </summary>
            /// <param name="cacheKey">参数缓存的键值</param>
            /// <param name="cmdParams">被缓存的参数列表</param>
            public static void CacheParameters(string cacheKey, params OleDbParameter[] cmdParams)
            {
                parmCache[cacheKey] = cmdParams;
            }
            /// <summary>
            /// 获取被缓存的参数
            /// </summary>
            /// <param name="cacheKey">用于查找参数的Key值</param>
            /// <returns>返回缓存的参数数组</returns>
            public static OleDbParameter[] GetCachedParameters(string cacheKey)
            {
                OleDbParameter[] cachedParms = (OleDbParameter[])parmCache[cacheKey];
                if (cachedParms == null)
                {
                    return null;
                }
                //新建一个参数的克隆列表
                OleDbParameter[] clonedParms = new OleDbParameter[cachedParms.Length];
                //通过循环为克隆参数列表赋值
                for (int i = 0; i < cachedParms.Length; i++)
                {
                    clonedParms[i] = (OleDbParameter)((ICloneable)cachedParms[i]).Clone();
                }
                return clonedParms;
            }
            #endregion
        }
    

}
