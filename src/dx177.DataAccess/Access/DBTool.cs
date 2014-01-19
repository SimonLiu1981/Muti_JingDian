using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Configuration;

namespace dx177.DataAccess.Access
{
    /// <summary>
    /// DBTool 的摘要说明。
    /// </summary>
    public class DBTool
    {
        protected static string connectionString = string.Format(ConfigurationSettings.AppSettings["ConnectionNewString"], System.Web.HttpContext.Current.Request.PhysicalApplicationPath);
        /// <summary>
        /// 执行SQL,返回DataTable
        /// </summary>
        /// <param name="Sql">SQL</param>
        /// <returns></returns>
        public static DataTable ExecuteDataTable(string Sql)
        {

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    string sqlCommand = Sql;
                    using (OleDbCommand cmd = new OleDbCommand(sqlCommand, connection))
                    {
                        connection.Open();
                        OleDbDataAdapter adp = new OleDbDataAdapter(sqlCommand, connection);
                        adp.SelectCommand = cmd;
                        DataSet ds = new DataSet();
                        adp.Fill(ds);
                        return ds.Tables[0];
                    }
                }
                catch (Exception ex)
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                    return null;
                }
            }
        }
        /// <summary>
        /// 获得TABLE
        /// </summary>
        /// <param name="Sql"></param>
        /// <param name="startRecord"></param>
        /// <param name="maxRecords"></param>
        /// <returns></returns>
        public static DataTable GetTable(string Sql, int startRecord, int maxRecords)
        {

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    string sqlCommand = Sql;
                    using (OleDbCommand cmd = new OleDbCommand(sqlCommand, connection))
                    {
                        connection.Open();
                        OleDbDataAdapter adp = new OleDbDataAdapter(sqlCommand, connection);
                        adp.SelectCommand = cmd;
                        DataSet ds = new DataSet();
                        adp.Fill(ds, startRecord, maxRecords, "table");
                        return ds.Tables[0];
                    }
                }
                catch (Exception ex)
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                    return null;
                }
            }

        }
        /// <summary>
        /// 执行SQL
        /// </summary>
        public static void ExecuteNonQuery(string Sql)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    string sqlCommand = Sql;
                    using (OleDbCommand cmd = new OleDbCommand(sqlCommand, connection))
                    {                        
                        connection.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                    throw ex;
                }
            }
        }


        /// <summary>
        /// 执行查询语句，返回分页的DATATABLE
        /// </summary>
        /// <param name="SQLString">查询语句</param>
        /// <returns>DataSet</returns>
        public static DataTable GetDataForPage(string SQLString, int first, int pagesize)
        {

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                DataSet ds = new DataSet();
                try
                {
                    connection.Open();
                    OleDbDataAdapter dataAdapter = new OleDbDataAdapter(SQLString, connection);
                    int min = (first - 1) * pagesize;
                    int max = first * pagesize;
                    dataAdapter.Fill(ds, min, max, "output");
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                return ds.Tables["output"];
            }
        }




    }
}
