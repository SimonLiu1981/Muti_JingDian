using System;
using System.Collections.Generic;
using System.Text;

namespace dx177_building.Model
{
    /// <summary>
    /// 适合替换<table><tr>  <td> </td> </tr>  </table>
    /// 或者 <u><li> <li></u>格式的
    /// </summary>
   [Serializable]
   public class XmlTableMod
   {
       /// <summary>
       /// 头的代码
       /// </summary>
       private string m_TableCode = string.Empty;
       public string TableCode
       {
           get
           {
               return m_TableCode;
           }
           set
           {
               m_TableCode = value;
           }
       }

       /// <summary>
       /// tr的代码
       /// </summary>
       private string m_TrCode = string.Empty;
       public string TrCode
       {
           get
           {
               return m_TrCode;
           }
           set
           {
               m_TrCode = value;
           }
       }
       /// <summary>
       /// td的代码
       /// </summary>
       private string m_TdCode = string.Empty;
       public string TdCode
       {
           get
           {
               return m_TdCode;
           }
           set
           {
               m_TdCode = value;
           }
       }
       /// <summary>
       /// 行
       /// </summary>
       private int  m_RowCount;
       public int RowCount
       {
           get
           {
               return m_RowCount;
           }
           set
           {
               m_RowCount = value;
           }
       }
       /// <summary>
       /// 列
       /// </summary>
       private int  m_ColCount;
       public int ColCount
       {
           get
           {
               return m_ColCount;
           }
           set
           {
               m_ColCount = value;
           }
       }

       /// <summary>
       /// 是否存在特殊代TD码
       /// </summary>
       private int m_SpecialTdColCount = 0;
       public int SpecialTdColCount
       {
           get
           {
               return m_SpecialTdColCount;
           }
           set
           {
               m_SpecialTdColCount = value;
           }
       }

       /// <summary>
       /// 特殊的TD代码
       /// </summary>
       private string m_SpecialTdCode = null;
       public string SpecialTdCode
       {
           get
           {
               return m_SpecialTdCode;
           }
           set
           {
               m_SpecialTdCode = value;
           }
       }

       /// <summary>
       /// 空的TD代码
       /// </summary>
       private string m_EmptyTdCode = null;
       public string EmptyTdCode
       {
           get
           {
               return m_EmptyTdCode;
           }
           set
           {
               m_EmptyTdCode = value;
           }
       }


       /// <summary>
       /// 指定列名
       /// </summary>
       private string m_SpecifyColName = null;
       public string SpecifyColName
       {
           get
           {
               return m_SpecifyColName;
           }
           set
           {
               m_SpecifyColName = value;
           }
       }


       /// <summary>
       /// 指定列值
       /// </summary>
       private string m_SpecifyColValue = null;
       public string SpecifyColValue
       {
           get
           {
               return m_SpecifyColValue;
           }
           set
           {
               m_SpecifyColValue = value;
           }
       }

       /// <summary>
       /// 指定列代码
       /// </summary>
       private string m_SpecifyColcode = null;
       public string SpecifyColcode
       {
           get
           {
               return m_SpecifyColcode;
           }
           set
           {
               m_SpecifyColcode = value;
           }
       }

        
      
   }
}
