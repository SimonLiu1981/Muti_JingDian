using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using dx177_building.Model;
using System.Collections;
using System.Reflection;
namespace dx177_building
{
   public  class BuildingSearchListHtml
   {
       /// <summary>
       /// 
       /// </summary>
       /// <param name="dt">列表的主数据</param>
       /// <param name="xmlPath">xmlpath</param>
       /// <param name="Hashdata">分块的hash数据</param>
       public static void CreatePageList(DataTable dt, string xmlPath, string Link, string TYPENAME)
       {
           SearchPageSettingMod searchpagesettingmod = BuildCommon.GetSearchPageSettingMod(xmlPath);
           int currentIndex=1 ;
           XmlTableMod xm = XmlData.XmlDeserialize(typeof(XmlTableMod), searchpagesettingmod.TableListPath) as XmlTableMod;
           PageButton p = new PageButton(searchpagesettingmod.PageButtonXmlPath, Link + TYPENAME);
           p.CurrentPageIndex = 1;
           p.pageButtonCount = 10;
           p.PageCount = GetPageCount(dt.Rows.Count, xm.ColCount * xm.RowCount);// dt.Rows.Count / (xm.ColCount * xm.RowCount) + 1;
           p.ItemCount = dt.Rows.Count;

           object obj =dt!=null&&dt.Rows.Count>0?dt.Rows[0]:null ; 
           HtmlDataForReplace hdata = new HtmlDataForReplace();
           hdata.obj = obj;
           hdata.HasData = BuildCommon.GetDataHas(searchpagesettingmod.HashDataMods, obj);
           hdata.HasChildHtmls = BuildCommon.GetHasChildHtml(searchpagesettingmod.ChildHtmls);
           if (searchpagesettingmod.DataHtmlMods!=null)
            hdata.DataHtmlModArr = new List<DataHtmlMod>(searchpagesettingmod.DataHtmlMods);
           BuildPageHtml.GetBaseXmlForHash(searchpagesettingmod.BaseXmls, ref hdata);
           Hashtable datahtmlHash = BuildCommon.GetDataHtmlMods(hdata.DataHtmlModArr.ToArray(), hdata.HasData);

           searchpagesettingmod.MainPageHtml = BuildCommon.GetHtmlByHash(hdata.HasChildHtmls, searchpagesettingmod.MainPageHtml);
           searchpagesettingmod.MainPageHtml = BuildPageHtml.GetCycleHtml(searchpagesettingmod.PageCycleMods, obj, searchpagesettingmod.MainPageHtml);
           searchpagesettingmod.MainPageHtml = BuildCommon.GetHtmlByHash(datahtmlHash, searchpagesettingmod.MainPageHtml);
           searchpagesettingmod.MainPageHtml = BuildCommon.GetHtmlByHash(hdata.HasChildHtmls, searchpagesettingmod.MainPageHtml);
           searchpagesettingmod.MainPageHtml = BuildPageHtml.GetTree(searchpagesettingmod.TreeMods, obj, searchpagesettingmod.MainPageHtml);
           for (int i = 0; i < dt.Rows.Count; )
           {
               string PageHtml = searchpagesettingmod.MainPageHtml;
               DataTable temp = dt.Clone();
               temp.Clear();
               for (int j = 0; j < xm.ColCount*xm.RowCount && i < dt.Rows.Count; j++, i++)
               {
                   temp.ImportRow(dt.Rows[i]);
               }
               p.CurrentPageIndex = currentIndex ;
               string ListHtml = BuildTable.CreateTableList(temp, xm);
               string PagebuttonHtml = p.MainBindpage();
               #region 替换
               PageHtml = BuildCommon.Replace(PageHtml, searchpagesettingmod.PageButtonCode, PagebuttonHtml);
               PageHtml = BuildCommon.Replace(PageHtml, searchpagesettingmod.TableListReplaceCode, ListHtml);
               #endregion
               //替换productlist的类型
               string savepath = BuildCommon.Replace(string.Format(searchpagesettingmod.SavePatch, currentIndex), "|TYPENAME|", TYPENAME);
               PageHtml = BuildCommon.Replace(PageHtml, "|TYPENAME|", TYPENAME);
               BuildCommon.CreaetHTMLFile(savepath , PageHtml);
               currentIndex++;
           }
       }

       private static int GetPageCount(int RecordCount, int TdCount)
       {
           if (RecordCount % TdCount == 0)
           {
               return RecordCount / TdCount;
           }

           return RecordCount / TdCount + 1;
       }

       public static string CreateSearchPage(DataTable dt, string xmlpath, string Link, int currentIndex, int RecordCount)
       {
           SearchPageSettingMod searchpagesettingmod = BuildCommon.GetSearchPageSettingMod(xmlpath);
           XmlTableMod xm = XmlData.XmlDeserialize(typeof(XmlTableMod), searchpagesettingmod.TableListPath) as XmlTableMod;
           PageButton p = new PageButton(searchpagesettingmod.PageButtonXmlPath, Link);
           p.CurrentPageIndex = currentIndex;
           p.pageButtonCount = 10;
           p.PageCount = GetPageCount(RecordCount, xm.ColCount * xm.RowCount); // RecordCount / (xm.ColCount * xm.RowCount) + 1;
           p.ItemCount = RecordCount;
           object obj = dt != null && dt.Rows.Count > 0 ? dt.Rows[0] : null;
           HtmlDataForReplace hdata = new HtmlDataForReplace();
           hdata.obj = obj;
           hdata.HasData = BuildCommon.GetDataHas(searchpagesettingmod.HashDataMods, obj);
           hdata.HasChildHtmls = BuildCommon.GetHasChildHtml(searchpagesettingmod.ChildHtmls);
           if (searchpagesettingmod.DataHtmlMods!=null)
           hdata.DataHtmlModArr = new List<DataHtmlMod>(searchpagesettingmod.DataHtmlMods);
             BuildPageHtml.GetBaseXmlForHash(searchpagesettingmod.BaseXmls, ref hdata);
           Hashtable datahtmlHash = BuildCommon.GetDataHtmlMods(hdata.DataHtmlModArr.ToArray(), hdata.HasData);
           searchpagesettingmod.MainPageHtml = BuildCommon.GetHtmlByHash(hdata.HasChildHtmls, searchpagesettingmod.MainPageHtml);
           searchpagesettingmod.MainPageHtml = BuildPageHtml.GetCycleHtml(searchpagesettingmod.PageCycleMods, obj, searchpagesettingmod.MainPageHtml);
           searchpagesettingmod.MainPageHtml = BuildCommon.GetHtmlByHash(datahtmlHash, searchpagesettingmod.MainPageHtml);
           searchpagesettingmod.MainPageHtml = BuildCommon.GetHtmlByHash(hdata.HasChildHtmls, searchpagesettingmod.MainPageHtml);
           searchpagesettingmod.MainPageHtml = BuildPageHtml.GetTree(searchpagesettingmod.TreeMods, obj, searchpagesettingmod.MainPageHtml);
           string PageHtml = searchpagesettingmod.MainPageHtml;
 
           string ListHtml = BuildTable.CreateTableList(dt, xm);
           string PagebuttonHtml = p.MainBindpage();
           #region 替换
           PageHtml = BuildCommon.Replace(PageHtml, searchpagesettingmod.PageButtonCode, PagebuttonHtml);
           PageHtml = BuildCommon.Replace(PageHtml, searchpagesettingmod.TableListReplaceCode, ListHtml);
           #endregion
           PageHtml = DataToHtml.GobalReplace(PageHtml);
           return PageHtml;
       }

      
   }
}
