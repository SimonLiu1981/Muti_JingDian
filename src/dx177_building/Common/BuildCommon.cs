using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using dx177_building.Model;
using System.Data;
using System.Reflection;
using System.IO;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.OleDb;
 

namespace dx177_building
{
    public  class BuildCommon
    {

       

        /// <summary>
        /// 获取pagebuttonList里。
        /// </summary>
        /// <param name="xmlPath"></param>
        /// <returns></returns>
        public static SearchPageSettingMod GetSearchPageSettingMod(string xmlPath)
        {
            SearchPageSettingMod xm = XmlData.XmlDeserialize(typeof(SearchPageSettingMod), xmlPath) as SearchPageSettingMod;
            return xm;
        }

        /// <summary>
        /// 通过静态页面获取HTML放入HAS
        /// </summary>
        /// <param name="searchpagesettingmod"></param>
        /// <returns></returns>
        public static Hashtable GetHasChildHtml(ChildHtmlMod[] ChildHtmls)
        {
            Hashtable hs = new Hashtable();
            if (ChildHtmls != null && ChildHtmls.Length > 0)
            {
                foreach (ChildHtmlMod ch in ChildHtmls)
                {
                    string html = BuildCommon.GetHTML(ch.HtmlPath);
                    hs.Add(ch.RepalceCode, html);
                }
            }
            return hs;
        }


        /// <summary>
        ///  
        /// </summary>
        /// <param name="searchpagesettingmod"></param>
        /// <returns></returns>
        public static Hashtable GetDataHas(HashDataMod[] hashDataMods)
        {
            Hashtable hs = new Hashtable();
            if (hashDataMods != null && hashDataMods.Length > 0)
            {
                foreach (HashDataMod ch in hashDataMods)
                {
                    string sql = DataToHtml.GobalReplace(ch.Sql);

                    DataTable dt = BuildCommon.ExecuteDataTable(sql);
                    hs.Add(ch.HashKey, dt);
                }
            }
            return hs;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="searchpagesettingmod"></param>
        /// <returns></returns>
        public static Hashtable GetDataHas(HashDataMod[] hashDataMods,object obj)
        {
            Hashtable hs = new Hashtable();
            if (hashDataMods != null && hashDataMods.Length > 0)
            {               
                foreach (HashDataMod ch in hashDataMods)
                {
                    if (!hs.Contains(ch.HashKey))
                    {
                        string sql = ch.Sql;
                        if (ch.Sql.IndexOf(Variable.ReplaceStr) > -1 && obj != null)
                        {
                            sql = DataToHtml.ObjToHtml(obj, ch.Sql);
                        }
                        sql=DataToHtml.GobalReplace(sql);
                        DataTable dt = BuildCommon.ExecuteDataTable(sql);
                        hs.Add(ch.HashKey, dt);
                    }
                }
            }
            return hs;
        }

       


        /// <summary>
        ///  
        /// </summary>
        /// <param name="searchpagesettingmod"></param>
        /// <returns></returns>
        public static void ChangeSqlByBaseUsername(ref HashDataMod[] hashDataMods,string  BASEUSERNAME)
        {
            Hashtable hs = new Hashtable();
            if (hashDataMods != null && hashDataMods.Length > 0)
            {
                foreach (HashDataMod ch in hashDataMods)
                {
                    string sql = ch.Sql;
                    if (ch.Sql.IndexOf(Variable.ReplaceStr) > -1  )
                    {
                        ch.Sql = Replace(ch.Sql, Variable.ReplaceStr + "BASEUSERNAME" + Variable.ReplaceStr, BASEUSERNAME);
                    }
                }
            }
        }



        /// <summary>
        /// 通过HAS数据，生成的HTML放入HAS
        /// </summary>
        /// <param name="searchpagesettingmod"></param>
        /// <param name="hsTemp"></param>
        /// <returns></returns>
        public static Hashtable GetDataHtmlMods(DataHtmlMod[] DataHtmlMods, Hashtable hsTemp)
        {
            Hashtable hs = new Hashtable();
            if (DataHtmlMods != null && DataHtmlMods.Length > 0 && hsTemp != null )
            {
                try
                {
                    foreach (DataHtmlMod datahtmlmod in DataHtmlMods)
                    {
                         if (string.IsNullOrEmpty(datahtmlmod.ReplaceCode)) 
                            datahtmlmod.ReplaceCode = datahtmlmod.HasKey;
                        if (hsTemp[datahtmlmod.HasKey] != null)
                        {
                            DataTable dt = hsTemp[datahtmlmod.HasKey] as DataTable;
                            if (dt != null && dt.Rows.Count > 0)
                            {
                                XmlTableMod xmltable = new XmlTableMod();
                                CopyEntityToEntity(datahtmlmod, xmltable);
                                string Html = BuildTable.CreateTableList(dt, xmltable);
                                //hs.Add(datahtmlmod.HasKey, Html);
                                if (string.IsNullOrEmpty(datahtmlmod.ReplaceCode))
                                {
                                    hs.Add(datahtmlmod.HasKey, Html);
                                }
                                else
                                {
                                    hs.Add(datahtmlmod.ReplaceCode, Html);
                                }
                            }
                            else
                            {
                                // hs.Add(datahtmlmod.HasKey, "");
                                if (string.IsNullOrEmpty(datahtmlmod.ReplaceCode))
                                {
                                    hs.Add(datahtmlmod.HasKey, "");
                                }
                                else
                                {
                                    hs.Add(datahtmlmod.ReplaceCode, "");
                                }
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    string s = e.ToString();
                }
            }
            return hs;
        }


        public static string GetHtmlByHash(Hashtable hsTemp, string Html)
        {
            if (hsTemp == null || hsTemp.Count <= 0) return Html;
            //替换
            foreach (DictionaryEntry de in hsTemp)
            {
                if (de.Value == null)
                    continue;

                Html = BuildCommon.Replace(Html, Variable.ReplaceStr + de.Key.ToString() + Variable.ReplaceStr, de.Value.ToString());
                
            }
            return Html;
        }

        /// <summary>
        /// UI层使用实体类的问题.
        /// 拷贝值类型和非数组类型．
        /// </summary>
        /// <param name="entity">源实体类</param>
        /// <param name="entity">目标实体类</param>
        private static  void CopyEntityToEntity(object entityFrom, object entityTo)
        {
            if (entityFrom == null || entityTo == null) return;
            Type typeFrom = entityFrom.GetType();
            Type typeTo = entityTo.GetType();

            PropertyInfo[] propertys = typeFrom.GetProperties();
            foreach (PropertyInfo pInfo in propertys)
            {
                PropertyInfo pInfoTo = typeTo.GetProperty(pInfo.Name);
                //不为空且不为数组类型时赋值.
                if (pInfoTo != null && !pInfoTo.PropertyType.IsArray)
                {
                    object obj = pInfo.GetValue(entityFrom, null);
                    if (obj == null) continue;
                    //为值类型或者类型相同时赋值．
                    if (obj.GetType().IsValueType || obj.GetType().Equals(pInfoTo.PropertyType))
                    {
                        pInfoTo.SetValue(entityTo, obj, null);
                    }
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cycledatamods"></param>
        /// <param name="dr"></param>
        /// <param name="Layer"></param>
        /// <returns></returns>
        public static string TreeHtml(TreeMod treemod, object obj,string ParentKey)
        {
            string Html = "";
            foreach (TreeDataMod h in treemod.TreeDataArr)
            {
                if (h.ParentHasKey.ToUpper() == ParentKey.ToUpper())
                {
                    string sql = h.Sql;
                    if (h.Sql.IndexOf(Variable.ReplaceStr) > -1 && obj != null)
                    {
                        sql = DataToHtml.ObjToHtml(obj, h.Sql);
                    }
                    sql= DataToHtml.GobalReplace(sql);
                    DataTable dt = BuildCommon.ExecuteDataTable(sql);
                    XmlTableMod xm=new XmlTableMod() ;
                    CopyEntityToEntity(h, xm);
                    string thtml = string.Empty;
                    bool bchild = HaveChild(treemod, h.HasKey);
                    if (bchild)
                    {
                        if (dt != null && dt.Rows.Count > 0)
                        {
                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                Html += DataToHtml.DataRowToHtml(dt.Rows[i], xm.TdCode);
                                thtml = TreeHtml(treemod, dt.Rows[i], h.HasKey);
                                Html = BuildCommon.Replace(Html, DataToHtml.RpStr + h.HasKey.ToUpper() + DataToHtml.RpStr, thtml);
                                Html = string.Format(xm.TrCode, Html);
                            }
                            Html = string.Format(xm.TableCode, Html);
                        }
                    }
                    else
                    {
                        Html = BuildTable.CreateTableList(dt, xm);
                    }
                    return Html;
                }
            }
            return Html;
        }


        public static bool HaveChild(TreeMod treemod, string ParentKey)
        {
            foreach (TreeDataMod h in treemod.TreeDataArr)
            {
                if (h.ParentHasKey.ToUpper() == ParentKey.ToUpper())
                {
                    return true;
                }
            }
            return false;
        }

         

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cycledatamods"></param>
        /// <param name="dr"></param>
        /// <param name="Layer"></param>
        /// <returns></returns>
        public static string CycleHtml(CycleDataMod[] cycledatamods, object  obj, int Layer )
        {
            string rHtml = "";
            CycleDataMod cycledatamod = GetCycleDataMod(cycledatamods, Layer);
            string sql = cycledatamod.Sql;
            if (obj != null)
            {
                sql = DataToHtml.ObjToHtml(obj, sql);
            }
            sql = DataToHtml.GobalReplace(sql);

            DataTable dt = ExecuteDataTable(sql);
            if (((cycledatamod.LastLayer > 0 && cycledatamod.LastLayer == Layer) || cycledatamod.Sql == string.Empty) && obj != null)
            {
                foreach (DataRow dr1 in dt.Rows)
                {
                    rHtml += DataToHtml.DataRowToHtml(dr1, cycledatamod.CellHtml);
                }
                //如果没有子则不显示子的内容
                if (rHtml != string.Empty)
                {
                    rHtml = string.Format(cycledatamod.RowHtml, rHtml);
                }                
                return rHtml;
            }
            else
            {
                foreach (DataRow dr1 in dt.Rows)
                {
                    string tempTrHtml = DataToHtml.DataRowToHtml(dr1, cycledatamod.CellHtml);
                    string childHtml = CycleHtml(cycledatamods, dr1, Layer + 1);
                    rHtml += string.Format(tempTrHtml, childHtml);
                }
                //如果没有子则不显示子的内容
                if (rHtml != string.Empty)
                {
                    rHtml = string.Format(cycledatamod.RowHtml, rHtml);
                }  
                return rHtml;
            }
        }


        private static  CycleDataMod GetCycleDataMod(CycleDataMod[] cycledatamods ,int Layer)
        {
            foreach (CycleDataMod cycledatamod in cycledatamods)
            {
                if (cycledatamod.Layer == Layer)
                {
                    return cycledatamod;
                }
            }
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Source"></param>
        /// <param name="OldStr"></param>
        /// <param name="NewStr"></param>
        /// <returns></returns>
        public static string Replace(string Source, string OldStr, string NewStr)
        {
            return Source.Replace(OldStr, NewStr);
        }

        public static void DeleteOldPage(string Path)
        {
            if (File.Exists(Path))
            {
                File.Delete(Path);
            }
        }

        public static void BakuFile(string Path)
        {

            string strpath = System.Web.HttpContext.Current.Server.MapPath(Path);
            string oldpath = strpath;
            string filename = strpath.Substring(strpath.LastIndexOf("\\") + 1);
            strpath = strpath.Substring(0, strpath.LastIndexOf("\\"));
            strpath = strpath + "\\log\\" + DateTime.Now.Ticks.ToString() + filename;
            File.Copy(oldpath, strpath);
        }

       
        /// <summary>
        /// 生成HTML
        /// </summary>
        /// <param name="path"></param>
        /// <param name="strHtml"></param>
        public static void CreaetHTMLFile(string path, string strHtml)
        {
            if (path.IndexOf("@@") != -1)
            {
                path = DataToHtml.GobalReplace(path);
            }
            else if (path.IndexOf("~") == -1 && GobalContent.GabolHashPara != null && GobalContent.GabolHashPara["WEBFILEPATH"]!=null)
            {
                path =Path.Combine(GobalContent.GabolHashPara["WEBFILEPATH"].ToString() ,path.Trim('/'))  ;
            }
            if (path.IndexOf("~") != -1 )
            {
                path = System.Web.HttpContext.Current.Server.MapPath(path);
            }
            DeleteOldPage(path);
            FileInfo ii = new FileInfo(path);
            if (!ii.Directory.Exists)
            {
                ii.Directory.Create();
            }
            strHtml = DataToHtml.GobalReplace(strHtml);
            StreamWriter sw = new StreamWriter(path, true, GobalContent.CurrentEncoding);
            sw.Write(strHtml);
            sw.Close();
        }


        /// <summary>
        /// 获取html
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string GetHTML(string path)
        {
            path = System.Web.HttpContext.Current.Server.MapPath(path);
            string strHtml = "";
            StreamReader sr = new StreamReader(path, GobalContent.CurrentEncoding);
            while (sr.Read() != -1)
            {
                strHtml = sr.ReadToEnd();
            }
            sr.Close();
            return strHtml;
        }


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
                        DataTable dt = new DataTable();
                        adp.Fill(dt);
                        return dt;
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


    }
}
