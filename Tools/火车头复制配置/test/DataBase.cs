using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SQLite;
using System.Configuration;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

namespace test
{
    public  class DataBase
    {
        public static string strcon
        {
            get
            {
                if (ConfigurationSettings.AppSettings["constr"] != null)
                {
                    return ConfigurationSettings.AppSettings["constr"];
                }

                return "Data Source=" + GetPath() + "\\db\\config.db3";
            }
        
        }


        public static DataSet ExecuteDataSet(string commandText)
        {
            
            SQLiteConnection cn = new SQLiteConnection(strcon);
            SQLiteCommand cmd = cn.CreateCommand();
            cmd.CommandText = commandText;  
            if (cmd.Connection.State == ConnectionState.Closed)
                cmd.Connection.Open();
            DataSet ds = new DataSet();
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            da.Fill(ds);
            da.Dispose();
            cmd.Connection.Close();
            cmd.Dispose();
            return ds;
        }

        public static string ReaFile(string filename)
        {
            string str5 = GetPath();
            StreamReader sr = File.OpenText(@str5 + filename);
            string nextLine;
            string content = string.Empty;
            while ((nextLine = sr.ReadLine()) != null)
            {
                content += nextLine + "\n";
            }
            sr.Close();
            return content;
        }


        public static string GetPath()
        {
            string s = Application.StartupPath.Replace(@"bin\Debug", "");
            return s;
        }
        public static void delete(int id)
        {
            
            using (SQLiteConnection connection = new SQLiteConnection(strcon))
            {
                try
                {
                    SQLiteParameter p;
                    string sqlCommand =string.Format ( "delete from  MAIN.[Job] where jobid={0}",id );
                    using (SQLiteCommand cmd = new SQLiteCommand(sqlCommand, connection))
                    {
                        connection.Open();
                       
                        cmd.ExecuteNonQuery();
                    }
                }
                catch
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
           
        }

        public static void Update(int id, string XmlData)
        {

            using (SQLiteConnection connection = new SQLiteConnection(strcon))
            {
                try
                {
                    SQLiteParameter p;
                    string sqlCommand = string.Format("update    MAIN.[Job]   set XmlData=@XmlData   where jobid=@jobid", id);
                    using (SQLiteCommand cmd = new SQLiteCommand(sqlCommand, connection))
                    {
                        connection.Open();
                        p = new SQLiteParameter("@XmlData", DbType.String);
                        p.Value = XmlData;
                        cmd.Parameters.Add(p);
                        p = new SQLiteParameter("@jobid", DbType.Int16 );
                        p.Value = id;
                        cmd.Parameters.Add(p);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }

        }

        public static void Insert(string XmlData, string CronXml, string JobName)
        {
             
            using (SQLiteConnection connection = new SQLiteConnection(strcon))
            {
                try
                {

                    SQLiteParameter p;
                    string sqlCommand = " insert into MAIN.[Job]( [SiteId],[App], [SpiderUrl],[SpiderContent],[OutContent],[CronExpr],[CronId], [CronEnable],[Status],[ListOrder] ,XmlData,CronXml,[JobName]) values (17,'LocoySpider',0,0,0,'','','',1,10,@XmlData,@CronXml,@JobName);";
                    using (SQLiteCommand cmd = new SQLiteCommand(sqlCommand, connection))
                    {
                        connection.Open();

                        p = new SQLiteParameter("@XmlData", DbType.String );
                        p.Value = XmlData;
                        cmd.Parameters.Add(p);
                        p = new SQLiteParameter("@CronXml", DbType.String);
                        p.Value = CronXml;
                        cmd.Parameters.Add(p);
                        p = new SQLiteParameter("@JobName", DbType.String);
                        p.Value = JobName;
                        cmd.Parameters.Add(p);
                      
                        cmd.ExecuteNonQuery();

                      
                    }
                }
                catch
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }           
        }

        public static void Update(string XmlData, string JobName, int jobId)
        {
            using (SQLiteConnection connection = new SQLiteConnection(strcon))
            {

                try
                {

                    SQLiteParameter p;
                    string sqlCommand = " update  MAIN.[Job] set XmlData=@XmlData,JobName=@JobName where JobId=@JobId";
                    using (SQLiteCommand cmd = new SQLiteCommand(sqlCommand, connection))
                    {
                        connection.Open();

                        p = new SQLiteParameter("@XmlData", DbType.String);
                        p.Value = XmlData;
                        cmd.Parameters.Add(p);                        
                        p = new SQLiteParameter("@JobName", DbType.String);
                        p.Value = JobName;
                        cmd.Parameters.Add(p);                        

                        p = new SQLiteParameter("@JobId", DbType.Int32);
                        p.Value = jobId;                        
                        cmd.Parameters.Add(p);                         
                        cmd.ExecuteNonQuery();


                    }
                }
                catch
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
        }
    }
}
