using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dx177.Model.Bus.QueryO
{
   public  class ModuleQuery
   {
       string _code = string.Empty;
       /// <summary>
       ///  
       /// </summary>
       public string code
       {
           get
           {
               return _code;
           }
           set
           {
               _code = value;
           }
       }
       string _Type = string.Empty;
       /// <summary>
       /// 类型
       /// </summary>
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

       string _Title = string.Empty;
       /// <summary>
       /// 标题
       /// </summary>
       public string Title
       {
           get
           {
               return _Title;
           }
           set
           {
               _Title = value;
           }
       }

   }
}
