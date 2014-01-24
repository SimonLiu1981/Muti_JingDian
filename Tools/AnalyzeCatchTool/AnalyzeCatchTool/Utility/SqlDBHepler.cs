using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace AnalyzeCatchTool.Utility
{
    public class SqlDBHepler
    {
        private SqlConnection conn;
        private SqlDataAdapter oda = new SqlDataAdapter();
        private SqlCommand cmd;
        private DataSet myds = new DataSet();
        public SqlDBHepler(string connectionString)
        {
            conn = new SqlConnection(connectionString);
        }
        public DataSet GetDataSet(string strSQL)
        {
            myds = new DataSet();
            oda = new SqlDataAdapter(strSQL, conn);
            oda.Fill(myds);

            return myds;
        }

        public DataSet GetDataSet(string strSQL, List<SqlParameter> parameters)
        {
            myds = new DataSet();
            cmd = new SqlCommand(strSQL, conn);
            foreach (var p in parameters)
            {
                cmd.Parameters.Add(p);
            }      
            oda = new SqlDataAdapter(cmd);
            oda.Fill(myds);
            return myds;
        }


        public bool ExecuteNonQuery(string strSQL)
        {
            conn.Open();
            cmd = new SqlCommand(strSQL, conn);
            cmd.ExecuteNonQuery();            
            conn.Close();
            return true;
        }

        public bool ExecuteNonQuery(string strSQL,List<SqlParameter> parameters)
        {
            conn.Open();
            cmd = new SqlCommand(strSQL, conn);
            foreach (var p in parameters)
            {
                cmd.Parameters.Add(p);
            }            
            cmd.ExecuteNonQuery();
            conn.Close();
            return true;
        }


        public IDataReader ExecuteReader(string strSQL)
        {
            conn.Open();
            cmd = new SqlCommand(strSQL, conn);
            IDataReader dr = cmd.ExecuteReader();            
            return dr;
        }
    }
}
