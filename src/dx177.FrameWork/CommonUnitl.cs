using System;
 
using System.Data;
using System.Collections;
using System.Web.UI.WebControls;
using System.Web.Script.Serialization;

namespace dx177.FrameWork
{
	/// <summary>
	/// CommonUnitl 的摘要说明。
	/// </summary>
	public class CommonUnitl
	{
		public CommonUnitl()
		{
			//
			// TODO: 在此处添加构造函数逻辑
			//
		}

        public static int CheckLg(string Url,string strEnPath)
        {
            if ( Url.ToUpper().IndexOf(strEnPath.ToUpper() )>-1)
            {
            
                return (int) Licd.EN ;
            }

             return (int) Licd.CN  ;
        }

        /// <summary>
        /// 数组转字符串
        /// </summary>
        /// <param name="arry">数组</param>
        /// <returns></returns>
        public static string[] StringToArray(string strarry, char c)
        {
            if (!string.IsNullOrEmpty(strarry))
            {
                return strarry.Split(c);
            }
            return new String[0];
        }
        /// <summary>
        /// 获得所有listbox的value,Text值 用字符串返回 
        /// </summary>
        /// <param name="list">控件</param>
        /// <param name="Type">类型(v--Value,t--Text)</param>
        /// <returns>字符串</returns>
        public static string CheckboxBoxTostrArr(CheckBoxList list, string Type)
        {
            string rval = "";
            for (int i = 0; i < list.Items.Count; i++)
            {
                if (Type.ToLower() == "text")
                {
                    if (list.Items[i].Selected)
                    {
                        rval += list.Items[i].Text + ",";
                    }
                }
                else
                {
                    if (list.Items[i].Selected)
                    {
                        rval += list.Items[i].Value + ",";
                    }
                }
            }
            rval = rval.Trim(',');
            return rval;
        }

        /// <summary>
        /// 只限于加一行
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="ColumnNameArr">多列用|分开</param>
        /// <param name="ValuNameArr"></param>
        public static void NewTable(DataTable dt, string ColumnNameArr, string ValuNameArr)
        {
            string[] columnArr = ColumnNameArr.Split('|');
            for (int i = 0; i < columnArr.Length; i++)
            {
                TableAddColumn(dt, columnArr[i], "");
            }
            TableAddRow(dt, ValuNameArr);
        }



        public static void TableAddColumn(DataTable dt, string ColumnName, string typeName)
        {
            if (!string.IsNullOrEmpty(typeName.Trim()))
            {
                Type myClassType = Type.GetType(typeName);

                dt.Columns.Add(ColumnName, myClassType);
            }
            else
            {
                dt.Columns.Add(ColumnName );
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="Svalue">多列用|分开</param>
        public static void TableAddRow(DataTable dt ,string Svalue )
        {
            string[] arr=Svalue.Split('|') ; 
            DataRow dr = dt.NewRow();
            for (int i = 0; i < arr.Length; i++)
            {
                dr[i] = arr[i];
            }
            dt.Rows.Add(dr);
        }

        public static void MergeHash(Hashtable FromHash, Hashtable ToHash)
        {
            foreach (DictionaryEntry de in FromHash)
            {
                if (ToHash.ContainsKey(de.Key))
                {
                    ToHash.Remove(de.Key);
                }
                ToHash.Add(de.Key, de.Value );
            }
 
        }
        /// <summary>
        /// 反射实体变成对应的json格式
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static string JavaScriptSerializerString(object p)
        {
            JavaScriptSerializer json = new JavaScriptSerializer();
            // 序列化对象为JSON字符串
            return json.Serialize(p);

        }
	}
}
