using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Reflection;
using System.IO;
using dx177_building.Model;
using System.Web;
using System.Collections;

namespace dx177_building
{
    public class DataToHtml
    {
        public static string RpStr = "|";
        /// <summary>
        ///  dataRow转HTML
        /// </summary>
        /// <param name="TempText"></param>
        /// <param name="dr"></param>
        /// <returns></returns>
        public static string DataRowToHtml(DataRow dr, string TempText)
        {
            string txt = TempText;
            foreach (DataColumn col in dr.Table.Columns)
            {
                txt = BuildCommon.Replace(txt, RpStr + col.ColumnName.ToUpper() + RpStr, dr[col.ColumnName].ToString());
            }
            return txt;
        }

        /// <summary>
        ///  对象转HTML
        /// </summary>
        /// <param name="TempText"></param>
        /// <param name="dr"></param>
        /// <returns></returns>
        public static string ObjToHtml(object entity, string TempText)
        {
            if (entity is DataRow)
            { 
                DataRow dr =entity as DataRow ;
                if (dr != null)
                {
                    return DataRowToHtml(dr, TempText);
                }
                else
                {
                    return "";
                }
            }
            string txt = TempText; 
            Type type = entity.GetType();
            PropertyInfo[] propertys = type.GetProperties();
            foreach (PropertyInfo pInfo in propertys)
            {
                object obj = pInfo.GetValue(entity, null);
                if (obj == null) continue;
                txt = BuildCommon.Replace(txt, RpStr + pInfo.Name.ToUpper() + RpStr, obj.ToString());  
            }
            return txt;
        }


        /// <summary>
        /// dataTable转HTML
        /// </summary>
        /// <param name="html"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static string DataTableToHtmlTable( DataTable dt, string TempText )
        {
            string rHtml = TempText;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                foreach (DataColumn col in dt.Columns)
                {
                    rHtml = BuildCommon.Replace(rHtml, RpStr + col.ColumnName.ToUpper() + "-" + (i + 1).ToString() + RpStr, dt.Rows[i][col.ColumnName].ToString());
                }
            }
            return rHtml;
        }

        /// <summary>
        /// 公用变量替换
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public static string GobalReplace(string val )
        {
            if (GobalContent.GabolHashPara != null && GobalContent.GabolHashPara.Count>0)
            {
                foreach (DictionaryEntry g in GobalContent.GabolHashPara)
                {
                    if (g.Value!=null)
                         val = val.Replace("|" + g.Key.ToString().ToUpper() + "|", g.Value.ToString());
                }
            }
            return val;
        }
        
 

    }
}
