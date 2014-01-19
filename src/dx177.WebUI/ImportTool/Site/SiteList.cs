using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dx177.WebUI.HotelInfoImport
{
    [Serializable]
   public   class SiteList
    {
       public string jingqu
       {
           get;
           set;
       }

       public List<Site>  SiteListArr
       {
           get;
           set;
       }

    }
}
