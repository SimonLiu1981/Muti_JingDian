using System;
 
using System.Data;
using System.Collections;
using System.Web.UI.WebControls;
using System.Web.Script.Serialization;

namespace dx177.FrameWork
{
	/// <summary>
	/// CommonUnitl ��ժҪ˵����
	/// </summary>
	public class CommonUnitl
	{
		public CommonUnitl()
		{
			//
			// TODO: �ڴ˴���ӹ��캯���߼�
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
        /// ����ת�ַ���
        /// </summary>
        /// <param name="arry">����</param>
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
        /// �������listbox��value,Textֵ ���ַ������� 
        /// </summary>
        /// <param name="list">�ؼ�</param>
        /// <param name="Type">����(v--Value,t--Text)</param>
        /// <returns>�ַ���</returns>
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
        /// ֻ���ڼ�һ��
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="ColumnNameArr">������|�ֿ�</param>
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
        /// <param name="Svalue">������|�ֿ�</param>
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
        /// ����ʵ���ɶ�Ӧ��json��ʽ
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static string JavaScriptSerializerString(object p)
        {
            JavaScriptSerializer json = new JavaScriptSerializer();
            // ���л�����ΪJSON�ַ���
            return json.Serialize(p);

        }
	}
}
