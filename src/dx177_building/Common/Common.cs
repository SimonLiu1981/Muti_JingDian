using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using dx177_building.Model;

namespace dx177_building.Common
{
   public  class Common
    {

       public static void MergeHash(Hashtable FromHash, Hashtable ToHash)
       {
           if (FromHash == null) return;
           foreach (DictionaryEntry de in FromHash)
           {
               if (!ToHash.ContainsKey(de.Key))
               {
                   ToHash.Add(de.Key, de.Value);
               }
           }
       }

       /// <summary>
       /// 通过查询列表获得 每页产品数量
       /// </summary>
       /// <param name="xmlfile"></param>
       /// <returns></returns>
       public static int GetPageSizeByXmlFile(string xmlfile)
       {
           SearchPageSettingMod searchpagesettingmod = BuildCommon.GetSearchPageSettingMod(xmlfile);
           if (searchpagesettingmod != null && !string.IsNullOrEmpty(searchpagesettingmod.TableListPath) )
           {
               XmlTableMod xm = XmlData.XmlDeserialize(typeof(XmlTableMod), searchpagesettingmod.TableListPath) as XmlTableMod;
               if (xm != null)
               {
                   return xm.ColCount * xm.RowCount;
               }
           }
           return 20; 
       }
    }
}
