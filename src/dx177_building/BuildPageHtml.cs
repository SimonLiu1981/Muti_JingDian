using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using dx177_building.Model;
using System.Data;
using System.Collections;
namespace dx177_building
{
       /// <summary>
       /// 具体页面
       /// </summary>
    public class BuildPageHtml
    {
 
        /// <summary>
        /// 把基的数据放到
        /// </summary>
        /// <param name="BaseXmlPath"></param>
        /// <param name="saveHashKeyCode">缓存用到的Key</param>
        /// <returns></returns>
        public static BaseXmlData GetBaseXml(string BaseXmlPath,string saveHashKeyCode, object obj)
        {
            if (!string.IsNullOrEmpty(BaseXmlPath))
            {
                BaseXmlMod basXml = XmlData.XmlDeserialize(typeof(BaseXmlMod), BaseXmlPath) as BaseXmlMod;
                HashDataMod[] hashdatamods = basXml.HashDataMods;
                BuildCommon.ChangeSqlByBaseUsername(ref hashdatamods, GobalContent.UserName);
                Hashtable hsdata = BuildCommon.GetDataHas(hashdatamods, obj);
                BaseXmlData basexmldata = new BaseXmlData();
                basexmldata.DataHtmlMods = basXml.DataHtmlMods;
                basexmldata.SaveHashKeyCode = saveHashKeyCode;
                basexmldata.HasData = hsdata;
                Hashtable hschild = new Hashtable();
                
                if (basXml.ChildHtmls != null)
                {
                    foreach (ChildHtmlMod childhtmlmod in basXml.ChildHtmls)
                    {
                        string html = BuildCommon.GetHTML(childhtmlmod.HtmlPath);
                        hschild.Add(childhtmlmod.RepalceCode, html);
                    }
                }
                basexmldata.HasChildHtmls = hschild;
                //加入缓存里
                GobalContent.GobalBaseHashAdd(saveHashKeyCode, basexmldata);
                return basexmldata;
            }
            return null ;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="BaseXmlsArr"></param>
        /// <param name="hsdata"></param>
        /// <param name="DataHtmlModList"></param>
        /// <param name="childHasHtml"></param>
        /// <returns></returns>
        public static void  GetBaseXmlForHash(BaseXml[] BaseXmlsArr, ref  HtmlDataForReplace hdata)
        {
            if (BaseXmlsArr != null && BaseXmlsArr.Length>0)
            {
                foreach (BaseXml basexml in BaseXmlsArr)
                {
                    BaseXmlData basexmldata = null;
                    
                    if (GobalContent.GobalBaseHash == null || !GobalContent.GobalBaseHash.ContainsKey(basexml.SaveHashKeyCode))
                    {
                        basexmldata = GetBaseXml(basexml.XmlPath,basexml.SaveHashKeyCode, hdata.obj );
                    }

                    if (basexmldata == null)
                    {
                        object obj = GobalContent.GobalBaseHash[basexml.SaveHashKeyCode];
                        if (obj != null)
                        {
                            basexmldata = obj as BaseXmlData;
                        }
                    }
                     
                    if (basexmldata != null)
                    {
                        hdata.MergeHasData(basexmldata.HasData);
                        hdata.MergeHasChildHtmls(basexmldata.HasChildHtmls);
                        hdata.MergeDataHtml(basexmldata.DataHtmlMods);
                    }
                }
            }
        }

        public static string BuildPage(object obj, string xmlPath, ref  string ReturnPath)
        {
            PageHtmlMod pagehtml = XmlData.XmlDeserialize(typeof(PageHtmlMod), xmlPath) as PageHtmlMod;
            if (pagehtml == null) return string.Empty ;
            HtmlDataForReplace hdata = new HtmlDataForReplace();
            hdata.obj = obj;
            hdata.HasData = BuildCommon.GetDataHas(pagehtml.HashDataMods, obj);
            hdata.HasChildHtmls = BuildCommon.GetHasChildHtml(pagehtml.ChildHtmls);
            if (pagehtml.DataHtmlMods != null)
            {
                hdata.DataHtmlModArr = pagehtml.DataHtmlMods.ToList();
            }
            GetBaseXmlForHash(pagehtml.BaseXmls, ref hdata);
            string SavePath = pagehtml.SavePath;
            string MainPageHtml = pagehtml.MainPageHtml;
            MainPageHtml = BuildCommon.GetHtmlByHash(hdata.HasChildHtmls, MainPageHtml);
            if (obj is DataRow)
            {
                DataRow dr = obj as DataRow;
                MainPageHtml = DataToHtml.DataRowToHtml(dr, MainPageHtml);
                //获取具体的保存路径
                SavePath = DataToHtml.DataRowToHtml(dr, SavePath);
            }
            else
            {
                MainPageHtml = DataToHtml.ObjToHtml(obj, MainPageHtml);
                //获取具体的保存路径
                SavePath = DataToHtml.ObjToHtml(obj, SavePath);
            }
            if (hdata.DataHtmlModArr != null)
            {
                Hashtable dataHtmlhsHas = BuildCommon.GetDataHtmlMods(hdata.DataHtmlModArr.ToArray(), hdata.HasData);
                MainPageHtml = BuildCommon.GetHtmlByHash(dataHtmlhsHas, MainPageHtml);
            }
            MainPageHtml = GetCycleHtml(pagehtml.PageCycleMods, obj, MainPageHtml);
            MainPageHtml = GetTree(pagehtml.TreeMods, obj, MainPageHtml);
            ReturnPath = SavePath;
            return MainPageHtml;
        }

        public static void BuildPage(object obj, string xmlPath)
        {
            string SavePath = "";
            string MainPageHtml = BuildPage(obj, xmlPath, ref SavePath);
            BuildCommon.CreaetHTMLFile(SavePath, MainPageHtml);
        }

        
        /// <summary>
        /// 每个用户生成的路径名不一样 所以用Username来传
        /// </summary>
        /// <param name="xmlPath"></param>
        /// <param name="UserFileName"></param>
        public static void IndexPage(string xmlPath)
        {
            string SavePath = "";
            string MainPageHtml = BuildPage(null , xmlPath, ref SavePath);
            BuildCommon.CreaetHTMLFile(SavePath, MainPageHtml);
        }

     
        public static string GetPageHtml(string xmlPath, ref string SavePath, Hashtable hs)
        {
            PageHtmlMod pagehtml = XmlData.XmlDeserialize(typeof(PageHtmlMod), xmlPath) as PageHtmlMod;
            if (pagehtml == null) return string.Empty ;
            HtmlDataForReplace hdata = new HtmlDataForReplace();
            hdata.HasData = BuildCommon.GetDataHas(pagehtml.HashDataMods, null );
            hdata.HasChildHtmls = BuildCommon.GetHasChildHtml(pagehtml.ChildHtmls);
            if (pagehtml.DataHtmlMods != null)
            {
                hdata.DataHtmlModArr = pagehtml.DataHtmlMods.ToList();
            }
            GetBaseXmlForHash(pagehtml.BaseXmls, ref hdata);
        
            string MainPageHtml = pagehtml.MainPageHtml;
            MainPageHtml = BuildCommon.GetHtmlByHash(hdata.HasChildHtmls, MainPageHtml);
           
            hdata.MergeHasData(hs);
            if (hdata.DataHtmlModArr != null)
            {
                Hashtable dataHtmlhsHas = BuildCommon.GetDataHtmlMods(hdata.DataHtmlModArr.ToArray(), hdata.HasData);
                MainPageHtml = BuildCommon.GetHtmlByHash(dataHtmlhsHas, MainPageHtml);
            }
           
            MainPageHtml = GetCycleHtml(pagehtml.PageCycleMods, null, MainPageHtml);
            MainPageHtml = GetTree(pagehtml.TreeMods, null, MainPageHtml);
            MainPageHtml = DataToHtml.GobalReplace(MainPageHtml);
            return MainPageHtml;
        }

        public static string GetCycleHtml(PageCycleMod[] PageCycleArr, object obj,string MainHtml)
        {
            if (PageCycleArr == null || PageCycleArr.Length <= 0) return MainHtml;
            foreach (PageCycleMod pagecyclemod in PageCycleArr)
            {
                string sql = pagecyclemod.Sql;
                if (!string.IsNullOrEmpty(sql) && obj!=null)
                {
                    sql = DataToHtml.ObjToHtml(obj, sql);
                }
                sql = DataToHtml.GobalReplace(sql);
                DataTable dt = null;
                if (!string.IsNullOrEmpty(sql))
                {
                      dt = BuildCommon.ExecuteDataTable(sql);
                      if (dt != null && dt.Rows.Count > 0)
                      {
                          obj = dt.Rows[0];
                      }
                }
                string  strCycleHtml= GetCycleHtml(pagecyclemod.xmlPath, obj);
                MainHtml=BuildCommon.Replace(MainHtml, Variable.ReplaceStr + pagecyclemod.ReplaceCode + Variable.ReplaceStr, strCycleHtml);   
            }
            return MainHtml;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string  GetCycleHtml(string xmlpath, object obj)
        {
            CycleDataTableMod cycledatatablemod = XmlData.XmlDeserialize(typeof(CycleDataTableMod), xmlpath) as CycleDataTableMod;
            if (cycledatatablemod == null || cycledatatablemod.CycleDataMods == null || cycledatatablemod.CycleDataMods.Length <= 0) return string.Empty ;
            string Html = BuildCommon.CycleHtml(cycledatatablemod.CycleDataMods, obj, 1);
            return Html;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static void CycleHtml(string xmlpath, object obj)
        {
            CycleDataTableMod cycledatatablemod = XmlData.XmlDeserialize(typeof(CycleDataTableMod), xmlpath) as CycleDataTableMod;
            string Html = GetCycleHtml(xmlpath, obj);
            BuildCommon.CreaetHTMLFile(cycledatatablemod.SavePath, Html);
        }



        public static string GetTree(PageCycleMod[] PageTreeArr, object obj, string MainHtml)
        {
            if (PageTreeArr == null || PageTreeArr.Length <= 0) return MainHtml;
            foreach (PageCycleMod pagecyclemod in PageTreeArr)
            {
                string sql = pagecyclemod.Sql;
                if (!string.IsNullOrEmpty(sql) && obj != null)
                {
                    sql = DataToHtml.ObjToHtml(obj, sql);
                }
                sql = DataToHtml.GobalReplace(sql);

                DataTable dt = null;
                if (!string.IsNullOrEmpty(sql))
                {
                    dt = BuildCommon.ExecuteDataTable(sql);
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        obj = dt.Rows[0];
                    }
                }
                string strTreeHtml = GetTree(pagecyclemod.xmlPath, obj);
                MainHtml = BuildCommon.Replace(MainHtml, Variable.ReplaceStr + pagecyclemod.ReplaceCode + Variable.ReplaceStr, strTreeHtml);
            }
            return MainHtml;
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static void CreateTree(string xmlpath, object obj)
        {
            TreeMod treemod = XmlData.XmlDeserialize(typeof(TreeMod), xmlpath) as TreeMod;
            string Html = GetTree(xmlpath, obj);
            BuildCommon.CreaetHTMLFile(treemod.SavePath, Html);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string GetTree(string xmlpath, object obj)
        {
            TreeMod treemod = XmlData.XmlDeserialize(typeof(TreeMod), xmlpath) as TreeMod;
            if (treemod == null || treemod.TreeDataArr == null || treemod.TreeDataArr.Length <= 0 ) return string.Empty;
            string Html= BuildCommon.TreeHtml(treemod, obj, "");
            return Html;
        }
    }
}
