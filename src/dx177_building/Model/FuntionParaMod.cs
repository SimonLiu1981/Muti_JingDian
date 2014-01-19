using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dx177_building.Model
{
   [Serializable]
   public  class FuntionParaMod
   {
       string _Type = string.Empty;
       public string Type
       {
           get
           {
               return _Type;
           }
           set
           {
               _Type = value;
           }
       }

       string _Sql = string.Empty;
       public string Sql
       {
           get
           {
               return _Sql;
           }
           set
           {
               _Sql = value;
           }
       }

       string _CycleSql = string.Empty;
       public string CycleSql
       {
           get
           {
               return _CycleSql;
           }
           set
           {
               _CycleSql = value;
           }
       }
       string _ParaArr = string.Empty ;
       public string ParaArr
       {
           get
           {
               return _ParaArr;
           }
           set
           {
               _ParaArr = value;
           }
       }

       string _xmlPath = string.Empty ;
       public string xmlPath
       {
           get
           {
               return _xmlPath;
           }
           set
           {
               _xmlPath = value;
           }
       }
 
   
   }
}
