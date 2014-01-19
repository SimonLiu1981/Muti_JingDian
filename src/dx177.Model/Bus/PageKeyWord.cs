using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dx177.Model.Bus
{
   public  class PageKeyWord
    {
       string _Title = string.Empty;
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
       string _KeyWord = string.Empty;
       public string KeyWord
       {
           get
           {
               return _KeyWord;
           }
           set
           {
               _KeyWord = value;
           }
       }
       string _description = string.Empty;
       public string Description
       {
           get
           {
               return _description;
           }
           set
           {
               _description = value;
           }
       }
    }
}
