using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using AnalyzeCatchTool.Models;
using AnalyzeCatchTool.Utility;
using System.Text.RegularExpressions;

namespace AnalyzeCatchTool
{
    public delegate void Notify(int total, int current);

    public static class PrimaryTableAnalyze
    {
        public static event Notify motify;
    

        public static void Execute(ConfigurationEntity ce)
        {
            string sourcesql = "select * from " + ce.SourceTableName;
            string tagetAdjust = "select * from " + ce.TargetTableName + " where pageUrl='{0}'";
            AccessDBHelper accDB = new AccessDBHelper(ce.SourceDBConnectionString);
            SqlDBHepler sqlDB = new SqlDBHepler(ce.TargetDBConnectionString);
            DataSet ds = accDB.GetDataSet(sourcesql);
            int total = ds.Tables[0].Rows.Count;
            int cur = 0;
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                cur++;
                if (string.IsNullOrWhiteSpace(ce.CheckRowInstertPrimaryTable) || !CheckDuplicate(ce.CheckRowInstertPrimaryTable, dr, ds.Tables[0].Columns, sqlDB))
                {
                    string[] HandlerColumns = null;
                    if (!string.IsNullOrWhiteSpace(ce.BreakDownColumns))
                    {
                        HandlerColumns = ce.BreakDownColumns.Split(';');
                    }

                    List<SqlParameter> listparam = new List<SqlParameter>();
                    string insertsql = ce.InstertPrimaryTableTemplate;
                    foreach (DataColumn dc in ds.Tables[0].Columns)
                    {
                        if (insertsql.IndexOf("@" + dc.ColumnName) != -1)
                        {
                            listparam.Add(new SqlParameter("@" + dc.ColumnName, dr[dc.ColumnName].ToString()));
                        }
                        //SqlParameter                       
                    }
                    sqlDB.ExecuteNonQuery(insertsql, listparam);

                  
                    Dictionary<string, List<string>> gathers = new Dictionary<string, List<string>>();
                    if (HandlerColumns != null)
                    {
                        foreach (string col in HandlerColumns)
                        {
                            if (!string.IsNullOrWhiteSpace(col) && ds.Tables[0].Columns.Contains(col))
                            {
                                List<string> lst = new List<string>();
                                string[] values = Regex.Split(dr[col].ToString(), ce.SplitString);
                                foreach (var i in values)
                                {
                                    lst.Add(i);
                                }
                                gathers.Add(col, lst);
                            }
                        }

                        //if (string.IsNullOrWhiteSpace(ce.CheckRowInstertPrimaryTable) || !CheckDuplicate(ce.CheckRowInstertPrimaryTable, dr, ds.Tables[0].Columns, sqlDB))
                        
                        List<SqlParameter> checkSubDupliateParm = new List<SqlParameter>();                       
                        for (int ii = 0; ii < gathers.First().Value.Count; ii++)
                        {
                            checkSubDupliateParm = new List<SqlParameter>();    
                            // sub table
                            listparam = new List<SqlParameter>();
                            insertsql = ce.InstertSubTableTemplate;
                            bool hasValue = true;
                            foreach (var key in gathers.Keys)
                            {
                                if (insertsql.IndexOf("@" + key) != -1)
                                {
                                    if (string.IsNullOrWhiteSpace(gathers[key][ii]))
                                    {
                                        hasValue = false;
                                        break;
                                    }
                                    listparam.Add(new SqlParameter("@" + key, HtmlTools.uncode(gathers[key][ii])));
                                } 

                                //sub table param
                                if (ce.CheckRowInstertSubTable.IndexOf("@" + key) != -1)
                                {
                                    checkSubDupliateParm.Add(new SqlParameter("@" + key, HtmlTools.uncode(gathers[key][ii])));
                                } 
                                

                            }                            

                            if (hasValue)
                            {                                
                                PandingParams(insertsql, dr, ds.Tables[0].Columns, listparam);
                                PandingParams(ce.CheckRowInstertSubTable, dr, ds.Tables[0].Columns, checkSubDupliateParm);

                                if (!string.IsNullOrWhiteSpace(ce.CheckRowInstertSubTable))
                                {
                                    if (sqlDB.GetDataSet(ce.CheckRowInstertSubTable, checkSubDupliateParm).Tables[0].Rows.Count > 0)
                                    {
                                        continue;
                                    }                                   
                                }

                                sqlDB.ExecuteNonQuery(insertsql, listparam);
                            }
                        } 


                    }
                }

                if (motify != null)
                {
                    motify(total, cur);
                }
            }
        }

        private static void PandingParams(string template, DataRow dr, DataColumnCollection cols, List<SqlParameter> listparam)
        {
            if (listparam == null)
            {
                listparam = new List<SqlParameter>();
            }
            foreach (DataColumn dc in cols)
            {
                if (template.IndexOf("@" + dc.ColumnName) != -1 && listparam.Find(p=>p.ParameterName =="@" + dc.ColumnName) == null)
                {
                    listparam.Add(new SqlParameter("@" + dc.ColumnName, HtmlTools.uncode(dr[dc.ColumnName].ToString())));
                }
            }
        }

        private static bool CheckDuplicate(string template, DataRow dr, DataColumnCollection cols, SqlDBHepler sqlDB)
        {
            List<SqlParameter>  listparam = new List<SqlParameter>();
            foreach (DataColumn dc in cols)
            {
                if (template.IndexOf("@" + dc.ColumnName) != -1 && listparam.Find(p => p.ParameterName == "@" + dc.ColumnName) == null)
                {
                    listparam.Add(new SqlParameter("@" + dc.ColumnName, dr[dc.ColumnName].ToString()));
                }
            }
            if (sqlDB.GetDataSet(template, listparam).Tables[0].Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
    }
}
