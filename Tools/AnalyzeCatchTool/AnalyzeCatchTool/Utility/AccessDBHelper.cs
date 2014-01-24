using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Linq;
using System.Text;

namespace AnalyzeCatchTool.Utility
{
    public class AccessDBHelper
    {
        private OleDbConnection conn;
        private OleDbDataAdapter oda = new OleDbDataAdapter();
        private OleDbCommand cmd;
        private DataSet myds = new DataSet();
        public AccessDBHelper(string path)
        { 
            conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path);
        }
        public DataSet GetDataSet(string strSQL)
        {
            myds = new DataSet();
            oda = new OleDbDataAdapter(strSQL, conn);
            oda.Fill(myds);

            return myds;
        }

        public bool ExecuteNonQuery(string strSQL)
        {
            conn.Open();
            cmd = new OleDbCommand(strSQL, conn);
            cmd.ExecuteNonQuery();            
            conn.Close();
            return true;
        }

        public IDataReader ExecuteReader(string strSQL)
        {
            conn.Open();
            cmd = new OleDbCommand(strSQL, conn);
            IDataReader dr = cmd.ExecuteReader();
            return dr;            
        }

    }
}
