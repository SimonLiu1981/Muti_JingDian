using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dx177_building.Model
{
    [Serializable]
   public  class MyHtml
   {
       string _Path = null;
       public string Path
       {
           get
           {
               return _Path;
           }
           set
           {
               _Path = value;
           }
       }

       string _Name = null;
       public string Name
       {
           get
           {
               return _Name;
           }
           set
           {
               _Name = value;
           }
       }
   
   }
}
